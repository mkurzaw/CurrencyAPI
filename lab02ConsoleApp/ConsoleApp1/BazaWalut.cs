using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BazaWalut : DbContext
    {
        public virtual DbSet<SeriesPerDate> Dane { get; set; }
    }
}
