using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estimador.Entities;

namespace Estimador.CustomControls
{
    public partial class OptionBoolControl : UserControl, ICustomControl
    {
        public OptionBoolControl()
        {
            InitializeComponent();
        }

        public bool SelectedOption { set; get; }

        public delegate void EstimatedWeightEventHandler();
        public event EstimatedWeightEventHandler EstimatedWeigthChanged;

        public string Category { get; set; }

        public string Description
        {
            get
            {
                return optionLabel.Text;
            }

            set
            {
                optionLabel.Text = value;
            }
        }

        public string ControlType { get; set; }
        public double Weight { get; set; }
        public double EstimatedWeight { set; get; }

        public string DefaultValue { set; get; }
        public bool Effort { get; set; }

        private void OptionBoolControl_Load(object sender, EventArgs e)
        {
            checkFalse.Paint += CheckFalse_Paint;
            checkTrue.Paint += CheckTrue_Paint;
            SelectedOption = bool.Parse(DefaultValue);

            Compute();
        }

        private void CheckTrue_Paint(object sender, PaintEventArgs e)
        {
            if(SelectedOption)
                e.Graphics.DrawRectangle(new Pen(ColorTranslator.FromHtml("#3498db"), 1), 0, 0, checkTrue.Width - 1, checkTrue.Height - 1);
        }

        private void CheckFalse_Paint(object sender, PaintEventArgs e)
        {
            if (!SelectedOption)
                e.Graphics.DrawRectangle(new Pen(ColorTranslator.FromHtml("#3498db"), 1), 0, 0, checkFalse.Width - 1, checkFalse.Height - 1);
        }

        public void Compute()
        {
            checkFalse.Invalidate();
            checkTrue.Invalidate();

            bool useWeight = SelectedOption;

            if (useWeight)
                this.EstimatedWeight = Weight;
            else
                this.EstimatedWeight = 0;

            estimatedWeightLabel.Text = this.EstimatedWeight.ToString();

            if (!this.Effort)
                estimatedWeightLabel.ForeColor = ColorTranslator.FromHtml("#27ae60");
            else
                estimatedWeightLabel.ForeColor = ColorTranslator.FromHtml("#c0392b");

            if (this.EstimatedWeigthChanged != null)
                EstimatedWeigthChanged();

        }

        private void checkTrue_Click(object sender, EventArgs e)
        {
            SelectedOption = true;
            Compute();
        }

        private void checkFalse_Click(object sender, EventArgs e)
        {
            SelectedOption = false;
            Compute();
        }

        private void LightControl(Control control, bool needLight)
        {
            if (needLight)
            {
                control.Tag = control.BackColor;
                control.BackColor = ControlPaint.Dark(checkTrue.BackColor);
            }
            else
            {
                control.BackColor = (Color)control.Tag;
            }
        }

        private void checkTrue_MouseEnter(object sender, EventArgs e)
        {
            LightControl(checkTrue, true);
        }

        private void checkTrue_MouseLeave(object sender, EventArgs e)
        {
            LightControl(checkTrue, false);
        }

        private void checkFalse_MouseEnter(object sender, EventArgs e)
        {
            LightControl(checkFalse, true);
        }

        private void checkFalse_MouseLeave(object sender, EventArgs e)
        {
            LightControl(checkFalse, false);
        }
    }
}
