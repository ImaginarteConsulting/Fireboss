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
    public partial class NumberControl : UserControl , ICustomControl
    {
        public NumberControl()
        {
            InitializeComponent();
        }
        public delegate void EstimatedWeightEventHandler();
        public event EstimatedWeightEventHandler EstimatedWeigthChanged;
        public string Category { get; set; }

        public string Description
        {
            get
            {
                return numberLabel.Text;
            }

            set
            {
                numberLabel.Text = value;
            }
        }

        public string ControlType { get; set; }
        public double Weight { get; set; }
        public double EstimatedWeight { set; get; }

        public string DefaultValue { set; get; }

        public bool Effort { get; set; }

        public int SelectedNumber { set; get; }
        private void NumberControl_Load(object sender, EventArgs e)
        {
            int selectedNumber = 0;
            int.TryParse(DefaultValue, out selectedNumber);
            SelectedNumber = selectedNumber;

            Compute();
        }


        public void Compute()
        {
            this.EstimatedWeight = this.Weight * double.Parse(SelectedNumber.ToString());
            estimatedWeightLabel.Text = this.EstimatedWeight.ToString();
            numberSelectedLabel.Text = SelectedNumber.ToString("00");

            if (!this.Effort)
                estimatedWeightLabel.ForeColor = ColorTranslator.FromHtml("#27ae60");
            else
                estimatedWeightLabel.ForeColor = ColorTranslator.FromHtml("#c0392b");

            if(this.EstimatedWeigthChanged != null)
                EstimatedWeigthChanged();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SelectedNumber++;
            if (SelectedNumber > 99) SelectedNumber = 99;
            Compute();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            SelectedNumber--;
            if (SelectedNumber < 0) SelectedNumber = 0;
            Compute();
        }
    }
}
