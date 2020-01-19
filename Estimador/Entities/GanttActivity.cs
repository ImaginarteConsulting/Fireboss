using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimador.Entities
{
    public class GanttActivity
    {
        public string Category { set; get; }
        public IEnumerable<int> GanttPositions { set; get; }

        public GanttActivity(string category, IEnumerable<int> ganttPositions)
        {
            this.Category = category;
            this.GanttPositions = ganttPositions;
        }
    }
}
