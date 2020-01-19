using Estimador.CustomControls;
using Estimador.Entities;
using Estimador.LanguagesSupport;
using Estimador.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using G = System.Globalization;
namespace Estimador
{
    public partial class Main : Form
    {
        LanguageSupportManager languageSupportManager = new LanguageSupportManager();
        TemplateBO templateBO = new TemplateBO();
        Template template = new Template();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            titleLabel.Text = languageSupportManager.GetStringValue("MainTitle");
            baseHourLabel.Text = languageSupportManager.GetStringValue("BaseHoursDescriptor");
            effortTakenLabel.Text = languageSupportManager.GetStringValue("EffortTakenDescriptor");
            effortSavedLabel.Text = languageSupportManager.GetStringValue("EffortSavedDescriptor");
            totalTimeLabel.Text = languageSupportManager.GetStringValue("TotalTimeDescriptor");

            priceHourLabel.Text = languageSupportManager.GetStringValue("PricePerHourDescriptor");
            totalPriceLabel.Text = languageSupportManager.GetStringValue("TotalPriceDescriptor");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            configuration.ShowDialog(this);
            controlContainer.Controls.Clear();

            baseHoursData.Text =    "0";
            effortSavedData.Text =  "0";
            effortTakenData.Text =  "0";
            totalTimeData.Text =    "0";
            priceHourData.Text =    "0";
            totalPriceData.Text =   "0";

        }

        private DataTable GetHeader()
        {
            DataTable headerContent = new DataTable();
            headerContent.Columns.Add("{\"enabled\":\"true\",\"showHeader\":\"false\"}");
            headerContent.Rows.Add("{\"name\":\"" + languageSupportManager.GetStringValue("Main_GetHeader_ExportPdf_Title") + "\",\"colspan\":\"2\",\"size\":\"6\"}");
            return headerContent;
        }

        private DataTable GetBodyContent1()
        {
            DataTable tableContent = new DataTable();
            tableContent.Columns.Add(CellPdfValue(languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_Category")));
            tableContent.Columns.Add(CellPdfValue(languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_Weight")));
            tableContent.Columns.Add(CellPdfValue(languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_EffortTaken"), "#660000", "#ff7675"));
            tableContent.Columns.Add(CellPdfValue(languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_EfforSaved"), "#006600", "#55efc4"));
            tableContent.Columns.Add(CellPdfValue(languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_HoursTaken"), "#660000", "#ff7675"));
            tableContent.Columns.Add(CellPdfValue(languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_HoursSaved"), "#006600", "#55efc4"));

            int baseHours = template.Base;
            double priceHour = template.PriceHour;
            double totalEffortTaken = 0;
            double totalEffortSaved = 0;


            foreach (ICustomControl customControl in this.controlContainer.Controls)
            {
                double effortTaken = (customControl.Effort ? customControl.EstimatedWeight : 0);
                double effortSaved = (!customControl.Effort ? customControl.EstimatedWeight : 0);
                if (!(effortTaken == 0 && effortSaved == 0))
                {
                    bool isPercentField = (customControl.ControlType.Trim().ToUpper() == "PERCENT");
                    double weight = (isPercentField ? customControl.EstimatedWeight : customControl.Weight);

                    tableContent.Rows.Add(
                        customControl.Description,
                        weight,
                        effortTaken,
                        effortSaved,
                        effortTaken * baseHours,
                        effortSaved * baseHours
                    );

                    totalEffortTaken += effortTaken;
                    totalEffortSaved += effortSaved;
                }
            }

            tableContent.Rows.Add("{\"name\":\"\",\"colspan\":\"6\"}");

            tableContent.Rows.Add("{\"name\":\"" + languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_BaseHours") + "\",\"colspan\":\"4\"}", "{\"name\":\"" + baseHours.ToString("0.00") + "\",\"colspan\":\"2\"}");
            tableContent.Rows.Add("{\"name\":\"" + languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_SubTotalEffort") + "\",\"colspan\":\"4\"}", CellPdfValue(totalEffortTaken.ToString("0.00")), CellPdfValue(totalEffortSaved.ToString("0.00")));
            tableContent.Rows.Add("{\"name\":\"" + languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_SubTotalHours") + "\",\"colspan\":\"4\"}", CellPdfValue((totalEffortTaken * baseHours).ToString("0.00")), CellPdfValue((totalEffortSaved * baseHours).ToString("0.00")));
            tableContent.Rows.Add("{\"name\":\"" + languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_TotalHours") + "\",\"colspan\":\"4\"}", "{\"name\":\"" + ((totalEffortTaken - totalEffortSaved) * baseHours).ToString("0.00") + "\",\"colspan\":\"2\"}");

            DialogResult question = MessageBox.Show(languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_WarningPrintPrices"), languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_WarningPrintPricesTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (question == DialogResult.Yes)
            {
                tableContent.Rows.Add("{\"name\":\"" + languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_PricePerHour") + "\",\"colspan\":\"4\"}", "{\"name\":\"$" + priceHour.ToString("0.00") + "\",\"colspan\":\"2\"}");
                tableContent.Rows.Add("{\"name\":\"" + languageSupportManager.GetStringValue("Main_GetBodyContent1_ExportPdf_TotalPrice") + "\",\"colspan\":\"4\"}", "{\"name\":\"$" + (((totalEffortTaken - totalEffortSaved) * baseHours) * priceHour).ToString("0.00") + "\",\"colspan\":\"2\"}");
            }

            return tableContent;
        }
        private double CalculateEffortHoursByCategory(string category, int baseHours)
        {
            
            double totalEffortTakenByCategory = 0;
            double totalEffortSavedByCategory = 0;

            foreach (ICustomControl customControl in this.controlContainer.Controls)
            {
                if (category.Trim().ToUpper() == customControl.Category.Trim().ToUpper())
                {
                    totalEffortTakenByCategory += (customControl.Effort ? customControl.EstimatedWeight : 0);
                    totalEffortSavedByCategory += (!customControl.Effort ? customControl.EstimatedWeight : 0);
                }
            }

            return (totalEffortTakenByCategory - totalEffortSavedByCategory) * baseHours;
        }

        private int CalculateEffortHoursWeeks(int baseHours)
        {
            double totalEffortTaken = 0;
            double totalEffortSaved = 0;

            foreach (ICustomControl customControl in this.controlContainer.Controls)
            {
                double effortTaken = (customControl.Effort ? customControl.EstimatedWeight : 0);
                double effortSaved = (!customControl.Effort ? customControl.EstimatedWeight : 0);

                totalEffortTaken += effortTaken;
                totalEffortSaved += effortSaved;
            }

            double weeks = (((totalEffortTaken - totalEffortSaved) * baseHours) / 40);

            return GetIntegerWithOutRound(weeks);
        }

        private int GetIntegerWithOutRound(double number)
        {
            string convertedNumber = number.ToString("0.00", new G.NumberFormatInfo() {
                NumberDecimalSeparator = ".",
                NumberGroupSeparator = ","
            });

            return Convert.ToInt32(convertedNumber.Split('.')[0]);
        }

        private DataTable GetBodyContentGantt()
        {
            int baseHours = template.Base;

            var categories = (from ICustomControl control in this.controlContainer.Controls
                             orderby control.Category ascending
                             select control.Category).Distinct();

            double weekTotal = 1;
            List<GanttActivity> ganttActivities = new List<GanttActivity>();
            int weeks = CalculateEffortHoursWeeks(baseHours);

            foreach (string category in categories)
            {
                double totalEffortHoursByCategory = CalculateEffortHoursByCategory(category, baseHours);
                weekTotal += (totalEffortHoursByCategory / 40);

                int weeksRounded = Convert.ToInt32(weekTotal);

                int maxWeekNumber = MaxWeekNumberIntoList(ganttActivities);

                List<int> weeksRoundedList = new List<int>();

                if (weeksRounded < weeks)
                    weeksRoundedList.Add(weeksRounded);
                else
                    weeksRoundedList.Add(weeks);

                while (maxWeekNumber < weeksRounded)
                {
                    maxWeekNumber++;
                    weeksRoundedList.Add(maxWeekNumber);
                }

                ganttActivities.Add(new GanttActivity(category, weeksRoundedList));

            }


            DataTable gantt = BuildGantt(weeks , ganttActivities);

            return gantt;
        }

        private int MaxWeekNumberIntoList(IEnumerable<GanttActivity> ganttActivities)
        {
            int maxWeekValue = 0;

            foreach (GanttActivity ganttActivity in ganttActivities)
            {
                int maxWeek = (from ga in ganttActivity.GanttPositions
                           select ga).Max();

                if (maxWeek > maxWeekValue) maxWeekValue = maxWeek;
            }

            return maxWeekValue;
        }

        private DataTable BuildGantt(int weeks, List<GanttActivity> ganttActivities)
        {
            DataTable gantt = new DataTable();

            //Oculto todos los encabezados autogenerados
            for (int w = 0; w < weeks + 1; w++)
                gantt.Columns.Add("{\"name\":\"" + w + "\",\"enabled\":\"true\",\"showHeader\":\"false\"}");

            gantt.Rows.Add(CellPdfValue(".","#FFFFFF","#FFFFFF", (weeks + 1).ToString()));

            //Celdas de encabezado
            List<object> headerCells = new List<object>();
            headerCells.Add("{\"name\":\"" + languageSupportManager.GetStringValue("Main_BuildGantt_ExportPdf_CategoryHeader") + "\",\"rowspan\":\"2\"}");
            int month = 1;
            for (int w = 0; w < weeks; w++)
            {
                if ((w % 4) == 0)
                {
                    headerCells.Add("{\"name\":\"" + languageSupportManager.GetStringValue("Main_BuildGantt_ExportPdf_MonthHeader") + " " + month + "\",\"colspan\":\"4\"}");
                    month++;
                }
            }
            gantt.Rows.Add(headerCells.ToArray());
            
            //Celdas de encabezado2
            List<object> headerCells2 = new List<object>();
            int weekCounter = 0;
            for (int w = 1; w <= weeks; w++)
            {
                int weekNumber = (w - (4 * weekCounter));
                headerCells2.Add("{\"name\":\"" + weekNumber + "\"}");
                if (weekNumber % 4 == 0) weekCounter++;
            }
            gantt.Rows.Add(headerCells2.ToArray());

            //Celdas de cuerpo
            foreach (GanttActivity ganttActivity in ganttActivities)
            {
                List<object> cells = new List<object>();

                cells.Add(ganttActivity.Category);

                for (int w = 1; w <= weeks; w++)
                {
                    if (ganttActivity.GanttPositions.Contains(w))
                    {
                        cells.Add(CellPdfValue("", "#f1c40f", "#f1c40f"));
                    }
                    else
                    {
                        cells.Add("");
                    }


                }

                gantt.Rows.Add(cells.ToArray());
            }

            return gantt;
        }


        private void makeReportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = languageSupportManager.GetStringValue("SaveDialogTitle");
            saveFileDialog.FileName = languageSupportManager.GetStringValue("Main_ExportPdf_DefaultFileNameTemplate") + $".{DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")}.pdf";
            saveFileDialog.Filter = languageSupportManager.GetStringValue("Main_ExportPdf_Filter") + "|*.pdf";
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                List<DataTable> report = new List<DataTable>();
                report.Add(GetHeader());
                report.Add(GetBodyContent1());
                report.Add(GetBodyContentGantt());
                

                DataTableToPdfControllerBO dataTableToPdf = new DataTableToPdfControllerBO(report, saveFileDialog.FileName);
                dataTableToPdf.StartConversion();

                Process.Start(saveFileDialog.FileName);
            }

        }

        private string CellPdfValue(string value, string foreColor, string backColor, string colSpan)
        {
            return "{\"name\":\"" + value + "\",\"foreColorName\":\"" + foreColor + "\",\"backColorName\":\"" + backColor + "\",\"colspan\":\"" + colSpan + "\"}";
        }
        private string CellPdfValue(string value, string foreColor, string backColor)
        {
            return "{\"name\":\"" + value + "\",\"foreColorName\":\"" + foreColor + "\",\"backColorName\":\"" + backColor + "\"}";
        }
        private string CellPdfValue(string value)
        {
            return "{\"name\":\"" + value + "\"}";
        }


        private void RefreshTemplate(string path)
        {
            template = templateBO.LoadTemplate(path);
            int y = 0;
            controlContainer.Controls.Clear();
            foreach (CustomControl customControl in template.CustomControls)
            {

                if (customControl.ControlType.ToUpper().Trim() == "NUMBER")
                {
                    NumberControl numberControl = new NumberControl();
                    numberControl.EstimatedWeigthChanged += CustomControl_EstimatedWeigthChanged;
                    numberControl.Top = y;
                    MapControl(customControl, numberControl);

                    controlContainer.Controls.Add(numberControl);
                    y += numberControl.Height + numberControl.Margin.Bottom;
                }
                else if (customControl.ControlType.ToUpper().Trim() == "PERCENT")
                {
                    PercentControl percentControl = new PercentControl();
                    percentControl.EstimatedWeigthChanged += CustomControl_EstimatedWeigthChanged;
                    percentControl.Top = y;
                    MapControl(customControl, percentControl);

                    controlContainer.Controls.Add(percentControl);
                    y += percentControl.Height + percentControl.Margin.Bottom;
                }
                else if (customControl.ControlType.ToUpper().Trim() == "OPTIONBOOL")
                {
                    OptionBoolControl optionControl = new OptionBoolControl();
                    optionControl.EstimatedWeigthChanged += CustomControl_EstimatedWeigthChanged;
                    optionControl.Top = y;
                    MapControl(customControl, optionControl);

                    controlContainer.Controls.Add(optionControl);
                    y += optionControl.Height + optionControl.Margin.Bottom;
                }
            }

            CustomControl_EstimatedWeigthChanged();
        }

        private void CustomControl_EstimatedWeigthChanged()
        {
            double savedEffort = 0;
            double takenEffort = 0;

            foreach (ICustomControl customControl in this.controlContainer.Controls)
            {
                if (customControl.Effort)
                    takenEffort += customControl.EstimatedWeight;
                else
                    savedEffort += customControl.EstimatedWeight;
            }

            baseHoursData.Text = $"{template.Base} " + languageSupportManager.GetStringValue("Main_CustomControl_EstimatedWeightChanges_Unit");
            effortSavedData.Text = $"{savedEffort.ToString("0.00")}";
            effortTakenData.Text = $"{takenEffort.ToString("0.00")}";

            double totalEffortHours = ((takenEffort - savedEffort) * template.Base);
            totalTimeData.Text = $"{totalEffortHours.ToString("0.00")} " + languageSupportManager.GetStringValue("Main_CustomControl_EstimatedWeightChanges_Unit");

            priceHourData.Text = $"${template.PriceHour.ToString("0.00")}";
            totalPriceData.Text = $"${(totalEffortHours * template.PriceHour).ToString("0.00")}";
        }

        private void MapControl(ICustomControl customControlData, ICustomControl customControlControl)
        {
            customControlControl.ControlType = customControlData.ControlType;
            customControlControl.DefaultValue = customControlData.DefaultValue;
            customControlControl.Description = customControlData.Description;
            customControlControl.Effort = customControlData.Effort;
            customControlControl.Weight = customControlData.Weight;
            customControlControl.Category = customControlData.Category;
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = languageSupportManager.GetStringValue("OpenDialogTitle");
            openFileDialog.Filter = languageSupportManager.GetStringValue("Main_LoadTemplate_Filter_etmp") + "|*.etmp|" + languageSupportManager.GetStringValue("Main_LoadTemplate_Filter_estm") + "|*.estm";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                RefreshTemplate(openFileDialog.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Filter = languageSupportManager.GetStringValue("Main_SaveButton_Filter_estm") + "|*.estm";
            saveFileDialog.FileName = languageSupportManager.GetStringValue("Main_SaveButton_DefaultFileNameTemplate") + $".{DateTime.Now.ToString("yyyyMMdd")}";
            saveFileDialog.Title = languageSupportManager.GetStringValue("SaveDialogTitle");
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;


            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {

                Template usedTemplate = new Template();
                usedTemplate.Base = template.Base;
                usedTemplate.PriceHour = template.PriceHour;
                usedTemplate.CustomControls = new List<CustomControl>();

                foreach (ICustomControl usedControl in controlContainer.Controls)
                {
                    CustomControl customControl = new CustomControl();
                    customControl.Category = usedControl.Category;
                    customControl.Description = usedControl.Description;
                    customControl.ControlType = usedControl.ControlType;
                    customControl.Effort = usedControl.Effort;
                    customControl.Weight = usedControl.Weight;

                    if (usedControl.GetType() == typeof(NumberControl))
                    {
                        NumberControl numberControl = (NumberControl)usedControl;
                        customControl.DefaultValue =  numberControl.SelectedNumber.ToString();
                    }
                    else if (usedControl.GetType() == typeof(OptionBoolControl))
                    {
                        OptionBoolControl optionBoolControl = (OptionBoolControl)usedControl;
                        customControl.DefaultValue = optionBoolControl.SelectedOption.ToString();
                    }
                    else if (usedControl.GetType() == typeof(PercentControl))
                    {
                        PercentControl percentControl = (PercentControl)usedControl;
                        int percent = Convert.ToInt32(percentControl.EstimatedWeight * 100);

                        customControl.DefaultValue = percent.ToString();

                    }

                    usedTemplate.CustomControls.Add(customControl);
                }

                templateBO.SaveTemplate(usedTemplate, saveFileDialog.FileName);
            }

        }
    }
}
