using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1
{
    public class SeriesPerDate
    {
        public string disclaimer { set; get; }
        public string license { set; get; }
        public long timestamp { set; get; }
        public int ID { set; get; }
        public string Base { set; get; }
        public Rates rates { set; get; }
        

    }
}
