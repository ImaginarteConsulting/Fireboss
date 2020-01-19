using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimador.Entities
{
    public interface ICustomControl
    {
        string Category { set; get; }
        string Description { set; get; }
        string ControlType { set; get; }
        double Weight { set; get; }
        string DefaultValue { set; get; }
        bool Effort { set; get; }
        double EstimatedWeight { set; get; }

        void Compute();
    }
}
