using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class ReportOptions
    {
        public string Title { get; set; }
        public bool IsColor { get; set; }
        public List<object> Graphs { get; set; }
        public List<string> Designers { get; set; }
        public List<object> DataDetails { get; set; }

    }
}
