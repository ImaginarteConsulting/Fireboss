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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Estimador.CustomControls
{
    public partial class PercentControl : UserControl, ICustomControl
    {
        public PercentControl()
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
                return percentLabel.Text;
            }

            set
            {
                percentLabel.Text = value;
            }
        }
        public string ControlType { get; set; }
        public double Weight { get; set; }
        public double EstimatedWeight { set; get; }
        


        public string DefaultValue
        {
            get
            {
                return percentTrack.Value.ToString();
            }

            set
            {
                percentTrack.Value = int.Parse(value);
            }
        }

        public bool Effort { get; set; }

        private void percentTrack_ValueChanged(object sender, EventArgs e)
        {
            Compute();
        }

        public void Compute()
        {
            this.EstimatedWeight = (double)percentTrack.Value / (double)100;
            estimatedWeightLabel.Text = this.EstimatedWeight.ToString();

            if (!this.Effort)
                estimatedWeightLabel.ForeColor = ColorTranslator.FromHtml("#27ae60");
            else
                estimatedWeightLabel.ForeColor = ColorTranslator.FromHtml("#c0392b");

            if (this.EstimatedWeigthChanged != null)
                EstimatedWeigthChanged();

            GenerateGraph(500, percentTrack.Value, ColorTranslator.FromHtml("#ecf0f1"), ColorTranslator.FromHtml("#bdc3c7"),ColorTranslator.FromHtml("#34495e"));
        }
        private void PercentControl_Load(object sender, EventArgs e)
        {
            Compute();
        }

        public void GenerateGraph(int max, int value, Color backgroundColor, Color lineColor, Color fillColor)
        {
            Image resultImage = null;

            int square = 300;

            using (Bitmap bitmap = new Bitmap(square, square))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.FillEllipse(new SolidBrush(backgroundColor), new Rectangle(0, 0, square, square));
                    g.DrawArc(new Pen(lineColor, 5), new Rectangle(20, 20, square - 40, square - 40), 0, 360);

                    int fillment = (value * 360) / max;

                    g.DrawArc(new Pen(fillColor, 15), new Rectangle(20, 20, square - 40, square - 40), -90, fillment);

                    StringFormat stringFormat = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    g.DrawString($"{value} %", new Font("Segoe UI Bold", 40), new SolidBrush(fillColor), new Rectangle(20, 20, square - 40, square - 40), stringFormat);
                }
                resultImage = (Image)bitmap.Clone();
            }

            percentImage.Image = resultImage;
            percentImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
