using System;
using System.Collections.Generic;

using iTextSharp.text.pdf;
using iTextSharp.text;

using System.Data;
using System.IO;
using D = System.Drawing;
using DI = System.Drawing.Imaging;
using System.Web.Script.Serialization;
using Estimador.Entities;

namespace Estimador.Objects
{
    public class DataTableToPdfControllerBO
    {
        #region Events
            /// <summary>
            /// What you need us to do when creating the header cell
            /// </summary>
            public event CreateHeaderCellHandler OnHeaderCellCreate;

            /// <summary>
            /// What you need us to do when creating the intersection of column and row
            /// </summary>
            public event CreateIntersectCellHandler OnBodyIntersectCellCreate;
        #endregion

        #region Delegates
            public delegate void CreateHeaderCellHandler(DataColumn cellColumn, ref List<float> columnWidthsFloat, ref PdfPTable tableLayout);
            public delegate void CreateIntersectCellHandler(DataRow cellRow, DataColumn cellColumn, ref PdfPTable tableLayout);
        #endregion

        #region Properties
            /// <summary>
            /// Will filled from constructor, datatables to convert to.
            /// </summary>
            public List<DataTable> DataTables { private set; get; }
            
            /// <summary>
            /// Will filled from constructor, destination pdf file.
            /// </summary>
            public string FullPathFile { private set; get; }
        #endregion

        #region Event methods
        private void DataTableToPdfControllerV2_OnBodyIntersectCellCreate(DataRow cellRow, DataColumn cellColumn, ref PdfPTable tableLayout)
        {
            CellFormatModel cellColumnFormatModel = CellFormatFromJson(cellColumn.ColumnName);

            if (cellColumnFormatModel.enabled)
            {
                string cellValue = (cellRow[cellColumn.ColumnName].GetType() == typeof(System.DBNull) ? null : (string)cellRow[cellColumn.ColumnName]);
                if (cellValue != null)
                {
                    CellFormatModel cellRowFormatModel = CellFormatFromJson(Convert.ToString(cellValue).Trim());

                    var text = (string.IsNullOrEmpty(cellRowFormatModel.name) ? string.Empty : cellRowFormatModel.name);

                    if (text.Split(';', '|').Length > 1)
                        AddCellImagesToBody(tableLayout, text, cellRowFormatModel);
                    else if (text.Split(';', '|').Length == 1 && (text.ToLower().EndsWith(".png", StringComparison.InvariantCulture) || text.ToLower().EndsWith(".jpg", StringComparison.InvariantCulture) || text.ToLower().EndsWith(".jpeg", StringComparison.InvariantCulture) || text.ToLower().EndsWith(".bmp", StringComparison.InvariantCulture) || text.ToLower().EndsWith(".gif", StringComparison.InvariantCulture)))
                        AddCellSimpleImageToBody(tableLayout, text, cellRowFormatModel);
                    else
                        AddCellToBody(tableLayout, text, cellRowFormatModel);
                }
            }
        }

        private void DataTableToPdfControllerV2_OnHeaderCellCreate(DataColumn cellColumn, ref List<float> columnWidthsFloat, ref PdfPTable tableLayout)
        {
            CellFormatModel cellColumnFormatModel = CellFormatFromJson(cellColumn.ColumnName);

            if (cellColumnFormatModel.enabled)
            {
                columnWidthsFloat.Add(cellColumnFormatModel.width);

                if (cellColumnFormatModel.showHeader)
                    AddCellToHeader(tableLayout, cellColumnFormatModel.name, cellColumnFormatModel);
            }
        }

        #endregion

        /// <summary>
        /// Initialize an instance with necessary information.
        /// </summary>
        /// <param name="dataTables">List of datatables that you need to add to your pdf.</param>
        /// <param name="fullPathFile">FullPath when PDF will be created</param>
        public DataTableToPdfControllerBO(List<DataTable> dataTables, string fullPathFile)
        {
            this.DataTables = dataTables;
            this.FullPathFile = Environment.ExpandEnvironmentVariables(fullPathFile);

            if (this.DataTables.Count <= 0) throw new Exception("You must to add dataTables before continue");
            if (!Directory.Exists(Path.GetDirectoryName(this.FullPathFile))) throw new Exception("You must to add a valid directory");

            this.OnHeaderCellCreate += DataTableToPdfControllerV2_OnHeaderCellCreate;
            this.OnBodyIntersectCellCreate += DataTableToPdfControllerV2_OnBodyIntersectCellCreate;
        }
        
        #region Functional methods
            /// <summary>
            /// Give start to the conversion
            /// </summary>
            public void StartConversion()
            {
                using (Document document = new Document())
                {
                    PdfWriter.GetInstance(document, new FileStream(this.FullPathFile, FileMode.Create));

                    document.Open();

                    foreach (DataTable dataTable in this.DataTables)
                    {
                        document.Add(Add_Content_To_PDF(dataTable));
                    }

                    document.Close();
                }
            }
            
            /// <summary>
            /// Give a dataTable, we return a PdfTable.
            /// </summary>
            /// <param name="dataTable"></param>
            /// <returns></returns>
            private PdfPTable Add_Content_To_PDF(DataTable dataTable)
            {
                PdfPTable tableLayout = new PdfPTable(dataTable.Columns.Count);

                tableLayout.WidthPercentage = 95;

                List<float> columnWidthsFloat = new List<float>();

                foreach (DataColumn column in dataTable.Columns)
                    OnHeaderCellCreate(column, ref columnWidthsFloat, ref tableLayout);

                if (columnWidthsFloat.Count > 0)
                    tableLayout.SetWidths(columnWidthsFloat.ToArray());

                foreach (DataRow row in dataTable.Rows)
                    foreach (DataColumn column in dataTable.Columns)
                        OnBodyIntersectCellCreate(row, column, ref tableLayout);

                return tableLayout;
            }
        #endregion

        #region Generic methods
            /// <summary>
            /// Converts any json string to CellFormat
            /// </summary>
            /// <param name="json"></param>
            /// <returns></returns>
            private CellFormatModel CellFormatFromJson(string json)
                {
                    CellFormatModel cellFormatModel = CellFormatModel.DefaultCellFormatModel;

                    try
                    {
                        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                        cellFormatModel = javaScriptSerializer.Deserialize<CellFormatModel>(json);
                        if (cellFormatModel == null) cellFormatModel = CellFormatModel.DefaultCellFormatModel;
                    }
                    catch
                    {
                        cellFormatModel.name = json;
                    }
                    return cellFormatModel;
                }
            
            /// <summary>
            /// Add new header
            /// </summary>
            /// <param name="tableLayout"></param>
            /// <param name="cellText"></param>
            /// <param name="cellFormatModel"></param>
            private void AddCellToHeader(PdfPTable tableLayout, string cellText, CellFormatModel cellFormatModel = null)
            {
                if (cellFormatModel == null)
                    cellFormatModel = CellFormatModel.DefaultCellFormatModel;

                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, cellFormatModel.size, 1, new BaseColor(cellFormatModel.ForeColor)))) { VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(cellFormatModel.BackColor), Colspan = cellFormatModel.colSpan, Rowspan = cellFormatModel.rowSpan });
            }

            /// <summary>
            /// Add new generic cell to body
            /// </summary>
            /// <param name="tableLayout"></param>
            /// <param name="cellText"></param>
            /// <param name="cellFormatModel"></param>
            private void AddCellToBody(PdfPTable tableLayout, string cellText, CellFormatModel cellFormatModel = null)
            {
                if (cellFormatModel == null)
                    cellFormatModel = CellFormatModel.DefaultCellFormatModel;

                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, cellFormatModel.size, 1, new BaseColor(cellFormatModel.ForeColor)))) { VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(cellFormatModel.BackColor), Colspan = cellFormatModel.colSpan, Rowspan = cellFormatModel.rowSpan });
            }
            
            /// <summary>
            /// Add simple image cell to body
            /// </summary>
            /// <param name="tableLayout"></param>
            /// <param name="absoluteImageUri"></param>
            /// <param name="cellFormatModel"></param>
            private void AddCellSimpleImageToBody(PdfPTable tableLayout, string absoluteImageUri, CellFormatModel cellFormatModel = null)
            {
                if (cellFormatModel == null)
                    cellFormatModel = CellFormatModel.DefaultCellFormatModel;
                try
                {
                    var image = Image.GetInstance(absoluteImageUri);

                    tableLayout.AddCell(new PdfPCell(image, true) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(cellFormatModel.BackColor), Colspan = cellFormatModel.colSpan, Rowspan = cellFormatModel.rowSpan });
                }
                catch (Exception ex)
                {
                    AddCellToBody(tableLayout, ex.Message, cellFormatModel);
                }
            }
            /// <summary>
            /// Add multiple images cell to body
            /// </summary>
            /// <param name="tableLayout"></param>
            /// <param name="concatImages"></param>
            /// <param name="cellFormatModel"></param>
            private void AddCellImagesToBody(PdfPTable tableLayout, string concatImages, CellFormatModel cellFormatModel = null)
            {
                if (cellFormatModel == null)
                    cellFormatModel = CellFormatModel.DefaultCellFormatModel;

                string[] imagesPath = concatImages.Split(';', '|');
                PdfPTable imagesTable = new PdfPTable(1) { WidthPercentage = 100 };

                foreach (string img in imagesPath)
                {
                    try
                    {
                        if (img.ToLower().EndsWith(".png", StringComparison.InvariantCulture) || img.ToLower().EndsWith(".jpg", StringComparison.InvariantCulture) || img.ToLower().EndsWith(".jpeg", StringComparison.InvariantCulture) || img.ToLower().EndsWith(".bmp", StringComparison.InvariantCulture) || img.ToLower().EndsWith(".gif", StringComparison.InvariantCulture))
                        {

                            //D.Image drawingImage = (D.Image)(new D.Bitmap(D.Image.FromFile(img), new D.Size(800,1120)));

                            var image = Image.GetInstance(D.Image.FromFile(img), DI.ImageFormat.Png);
                            //var image = Image.GetInstance(drawingImage, DI.ImageFormat.Png);

                            imagesTable.AddCell(new PdfPCell(image, true) { Border = 0, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(cellFormatModel.BackColor), Colspan = cellFormatModel.colSpan, Rowspan = cellFormatModel.rowSpan });
                        }
                        else
                        {
                            throw new Exception(img);
                        }
                    }
                    catch (Exception e)
                    {
                        PdfPCell cell = new PdfPCell() { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(cellFormatModel.BackColor), Colspan = cellFormatModel.colSpan, Rowspan = cellFormatModel.rowSpan };
                        cell.AddElement(new Phrase(e.Message, new Font(Font.FontFamily.HELVETICA, 8, 1, new BaseColor(cellFormatModel.ForeColor))));
                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        imagesTable.AddCell(cell);
                    }
                }

                tableLayout.AddCell(imagesTable);
            }

        #endregion
    }

}
