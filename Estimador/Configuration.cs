using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estimador.Entities;
using Estimador.Objects;
using System.Text.RegularExpressions;
using Estimador.LanguagesSupport;

namespace Estimador
{
    public partial class Configuration : Form
    {
        LanguageSupportManager languageSupportManager = new LanguageSupportManager();
        private TemplateBO templateBO = new TemplateBO();
        private Template template;
        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            leftTopPanel.Top = 0;
            leftTopPanel.Left = headerPanel.Width - leftTopPanel.Width - 5;

            baseLabel.Text = languageSupportManager.GetStringValue("Configuration_BaseHours_Descriptor");
            priceHourLabel.Text = languageSupportManager.GetStringValue("Configuration_PricePerHour_Descriptor");
            ControlsLabel.Text = languageSupportManager.GetStringValue("Configuration_Controls_Descriptor");

            Category.HeaderText = languageSupportManager.GetStringValue("Configuration_Controls_Columns_Category");
            Description.HeaderText = languageSupportManager.GetStringValue("Configuration_Controls_Columns_Description");
            Type.HeaderText = languageSupportManager.GetStringValue("Configuration_Controls_Columns_Type");
            Pond.HeaderText = languageSupportManager.GetStringValue("Configuration_Controls_Columns_Pond");
            DefaultValue.HeaderText = languageSupportManager.GetStringValue("Configuration_Controls_Columns_DefaultValue");
            Effort.HeaderText = languageSupportManager.GetStringValue("Configuration_Controls_Columns_Effort");
            Delete.HeaderText = languageSupportManager.GetStringValue("Configuration_Controls_Columns_Delete");
        }

        private void RefreshTemplate(string path)
        {
            template = templateBO.LoadTemplate(path);

            baseHoursTextBox.Text = template.Base.ToString();
            priceHourTextBox.Text = template.PriceHour.ToString();
            gridTemplateControls.Rows.Clear();


            foreach (CustomControl customControl in template.CustomControls)
            {
                string category = (customControl.Category == null ? "99. Otros" : customControl.Category);
                gridTemplateControls.Rows.Add(category, customControl.Description, customControl.ControlType, customControl.Weight.ToString(), customControl.DefaultValue.ToString(), customControl.Effort.ToString());
            }

            //Formateo los campos
            for (var rowIndex = 0; rowIndex < gridTemplateControls.Rows.Count - 1; rowIndex++)
            {
                DataGridViewRow row = gridTemplateControls.Rows[rowIndex];
                object controlType = gridTemplateControls["TYPE", rowIndex].Value;
                DataGridViewCell pondCell = gridTemplateControls["Pond", rowIndex];

                if (pondCell != null)
                {
                    if (pondCell.Value != null)
                    {
                        double pond = Convert.ToDouble(pondCell.Value);
                        int baseHour = 0;
                        int.TryParse(baseHoursTextBox.Text, out baseHour);

                        pondCell.ToolTipText = languageSupportManager.GetStringValue("Configuration_RefreshTemplate_TooltipEstimationBase") + $" {baseHour} " + languageSupportManager.GetStringValue("Configuration_RefreshTemplate_TooltipUnit") + ". " + languageSupportManager.GetStringValue("Configuration_RefreshTemplate_TooltipWeightRepresents") + " {(pond * baseHour).ToString()} " + languageSupportManager.GetStringValue("Configuration_RefreshTemplate_TooltipUnit") + ".";
                    }
                }

                if (controlType != null) {
                    switch (controlType.ToString().Trim().ToUpper())
                    {
                        case "OPTIONBOOL":
                            {
                                SwitchCellType("DefaultValue", rowIndex, ControlTypes.OptionBool);
                                break;
                            }
                        case "NUMBER":
                            {
                                SwitchCellType("DefaultValue", rowIndex, ControlTypes.Number);
                                break;
                            }
                        case "PERCENT":
                            {
                                SwitchCellType("DefaultValue", rowIndex, ControlTypes.Percent);
                                MakeActivablePond(-1, rowIndex, false);
                                break;
                            }
                    }

                }

                object effortValue = gridTemplateControls["Effort", rowIndex].Value;

                if (effortValue != null) {
                    PaintEffortRow(bool.Parse(effortValue.ToString()), rowIndex);
                }

            }

        }

        

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridTemplateControls_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridTemplateControls.Rows[e.RowIndex].Height = 27;
            
            var columnName = gridTemplateControls.Columns[e.ColumnIndex].Name.Trim().ToUpper();

            if (columnName == "DELETE")
                e.Value = Estimador.Properties.Resources.delete_48px;

            
        }

        private void gridTemplateControls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var columnName = gridTemplateControls.Columns[e.ColumnIndex].Name.Trim().ToUpper();

            if (columnName == "DELETE")
            {
                DataGridViewRow rowReference = gridTemplateControls.Rows[e.RowIndex];
                if (!rowReference.IsNewRow)
                    gridTemplateControls.Rows.Remove(rowReference);
            }

        }

        private void Message(bool show, string text)
        {
            messageLabel.Text = text;
            messageLabel.Visible = show;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Title = languageSupportManager.GetStringValue("SaveDialogTitle");
            saveFileDialog.Filter = languageSupportManager.GetStringValue("Configuration_SaveButton_Filter_etmp") + "|*.etmp|" + languageSupportManager.GetStringValue("Configuration_SaveButton_Filter_estm") + "|*.estm";
            saveFileDialog.FileName = languageSupportManager.GetStringValue("Configuration_SaveButton_DefaultFileName") + $".{DateTime.Now.ToString("yyyyMMdd")}";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            Message(true,languageSupportManager.GetStringValue("Configuration_SaveButton_AsyncSavingMessage"));


            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                gridTemplateControls.EndEdit(DataGridViewDataErrorContexts.Commit);

                Template template = new Template();
                template.Base = 0;

                if (Regex.IsMatch(baseHoursTextBox.Text, @"^\d{1,2}$"))
                {
                    template.Base = int.Parse(baseHoursTextBox.Text);
                }

                if (Regex.IsMatch(priceHourTextBox.Text, @"^\d{1,4}$"))
                {
                    template.PriceHour = double.Parse(priceHourTextBox.Text);
                }

                template.CustomControls = new List<CustomControl>();

                foreach (DataGridViewRow row in gridTemplateControls.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        CustomControl customControl = new CustomControl();
                        customControl.Category = (string)row.Cells[0].Value;
                        customControl.Description = (string)row.Cells[1].Value;
                        customControl.ControlType = (string)row.Cells[2].Value;
                        customControl.Weight = (row.Cells[3].Value == null ? double.Parse("0") : double.Parse(row.Cells[3].Value.ToString()));
                        customControl.DefaultValue = (row.Cells[4].Value == null ? string.Empty : row.Cells[4].Value.ToString());
                        customControl.Effort = bool.Parse((string)row.Cells[5].Value);

                        template.CustomControls.Add(customControl);
                    }
                }

                templateBO.SaveTemplate(template, saveFileDialog.FileName);

                Message(true, languageSupportManager.GetStringValue("Configuration_SaveButton_AsyncSavedMessage"));
            }
            else
            {
                Message(true, languageSupportManager.GetStringValue("Configuration_SaveButton_AsyncCenceledMessage"));
            }
        }

        private enum ControlTypes
        {
            OptionBool = 0,
            Number = 1,
            Percent = 2
        }
        private void SwitchCellType(string colName, int rowIndex, ControlTypes controlType)
        {
            DataGridViewCell dataGridViewCell = gridTemplateControls[colName, rowIndex];

            switch (controlType)
            {
                case ControlTypes.OptionBool:
                    {
                        DataGridViewComboBoxCell cbCell = new DataGridViewComboBoxCell();
                        cbCell.Items.Add("True");
                        cbCell.Items.Add("False");
                        try
                        {
                            if (dataGridViewCell.Value == null) throw new Exception("Valor nulo");

                            cbCell.Value = dataGridViewCell.Value;
                        }
                        catch (Exception ex)
                        {
                            cbCell.Value = "False";
                        }

                        gridTemplateControls[colName, rowIndex] = cbCell;

                        break;
                    }
                case ControlTypes.Percent:
                    {
                        DataGridViewTextBoxCell tbCell = new DataGridViewTextBoxCell();

                        tbCell.Value = dataGridViewCell.Value;

                        gridTemplateControls[colName, rowIndex] = tbCell;

                        break;
                    }
                case ControlTypes.Number:
                    {
                        DataGridViewTextBoxCell tbCell = new DataGridViewTextBoxCell();
                        tbCell.Value = dataGridViewCell.Value;

                        gridTemplateControls[colName, rowIndex] = tbCell;

                        break;
                    }
            }
        }

        private void PaintEffortRow(bool effort, int rowIndex)
        {
            string effortColor = (effort ? "#FFF0F0" : "#F0FFF0");
            gridTemplateControls.Rows[rowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml(effortColor);
        }

        private void MakeActivablePond(double value, int rowIndex, bool enabled = true)
        {
            DataGridViewCell pondCell = gridTemplateControls["Pond", rowIndex];
            pondCell.Style.Format = "n2";
            pondCell.Value = value;
            pondCell.ReadOnly = !enabled;
        }
        private void gridTemplateControls_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                var columnName = gridTemplateControls.Columns[e.ColumnIndex].Name.Trim().ToUpper();

                if (columnName == "TYPE")
                {
                    object controlType = gridTemplateControls[e.ColumnIndex, e.RowIndex].Value;
                    string controlTypeUpper = controlType.ToString().ToUpper().Trim();

                    switch (controlTypeUpper)
                    {
                        case "OPTIONBOOL":
                            {
                                SwitchCellType("DefaultValue", e.RowIndex, ControlTypes.OptionBool);
                                MakeActivablePond(0.25, e.RowIndex);
                                break;
                            }
                        case "NUMBER":
                            {
                                SwitchCellType("DefaultValue", e.RowIndex, ControlTypes.Number);
                                MakeActivablePond(0.25, e.RowIndex);
                                break;
                            }
                        case "PERCENT":
                            {
                                SwitchCellType("DefaultValue", e.RowIndex, ControlTypes.Percent);
                                MakeActivablePond(-1, e.RowIndex, false);
                                break;
                            }

                    }
                }
                else if (columnName == "EFFORT")
                {
                    object effortValue = gridTemplateControls[e.ColumnIndex, e.RowIndex].Value;

                    if (effortValue != null)
                        PaintEffortRow(bool.Parse(effortValue.ToString()), e.RowIndex);
                }
                else if (columnName == "POND")
                {
                    DataGridViewCell pondCell = gridTemplateControls[e.ColumnIndex, e.RowIndex];

                    if (pondCell != null)
                    {
                        if (pondCell.Value != null)
                        {
                            double pond = Convert.ToDouble(pondCell.Value);
                            int baseHour = 0;
                            int.TryParse(baseHoursTextBox.Text, out baseHour);

                            pondCell.ToolTipText = languageSupportManager.GetStringValue("Configuration_RefreshTemplate_TooltipEstimationBase") + $" {baseHour} " + languageSupportManager.GetStringValue("Configuration_RefreshTemplate_TooltipUnit") + ". " + languageSupportManager.GetStringValue("Configuration_RefreshTemplate_TooltipWeightRepresents") + " {(pond * baseHour).ToString()} " + languageSupportManager.GetStringValue("Configuration_RefreshTemplate_TooltipUnit") + ".";
                        }
                    }

                }


            }

        }

        private void gridTemplateControls_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            var x = e.Exception;
        }

        private void loadTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Title= languageSupportManager.GetStringValue("OpenDialogTitle");
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = languageSupportManager.GetStringValue("Configuration_LoadTemplate_Filter_etmp") + "|*.etmp|" + languageSupportManager.GetStringValue("Configuration_LoadTemplate_Filter_estm") + "|*.estm";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                RefreshTemplate(openFileDialog.FileName);
            }
        }

        private void aboutUs_Click(object sender, EventArgs e)
        {
            AboutUS aboutUS = new AboutUS();
            aboutUS.ShowDialog(this);
        }
    }
}
