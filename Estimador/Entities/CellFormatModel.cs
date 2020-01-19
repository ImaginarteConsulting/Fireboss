using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Estimador.Entities
{
    public class CellFormatModel
    {
        private int colSpanQty;
        private int rowSpanQty;
        private float sizeQty;

        #region Can fill this properties from JSON
        public float width { set; get; } = 100;
        public string name { set; get; }
        public bool enabled { set; get; } = true;
        public bool showHeader { set; get; } = true;
        public float size { set { sizeQty = value; } get { return (sizeQty <= 0 ? 6 : sizeQty); } }
        public int rowSpan { set { rowSpanQty = value; } get { return (rowSpanQty <= 0 ? 1 : rowSpanQty); } }
        public int colSpan { set { colSpanQty = value; } get { return (colSpanQty <= 0 ? 1 : colSpanQty); } }
        public string backColorName { set; get; } = "#F0F0F0";
        public string foreColorName { set; get; } = "#363636";

        #endregion

        public Color BackColor
        {
            get
            {
                if (this.backColorName == null) this.backColorName = "#FFFFFF";
                return (Color)new ColorConverter().ConvertFromString(this.backColorName);
            }
        }
        public Color ForeColor
        {
            get
            {
                if (this.foreColorName == null) this.foreColorName = "#000000";
                return (Color)new ColorConverter().ConvertFromString(this.foreColorName);
            }
        }

        public static CellFormatModel DefaultCellFormatModel {
            get
            {
                return new CellFormatModel()
                {
                    width = 100,
                    name = string.Empty,
                    enabled = true,
                    showHeader = true,
                    size = 6,
                    rowSpan = 1,
                    colSpan = 1,
                    backColorName = "#FFFFFF",
                    foreColorName = "#000000"
                };
            }
        }
    }
}
