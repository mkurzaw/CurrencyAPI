using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SeriesPerDate
    {
        public string disclaimer { set; get; }
        public string license { set; get; }
        public long timestamp { set; get; }
        public string Base { set; get; }
        List<Rates> rates { set; get; }

    }
}
