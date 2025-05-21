using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Otomobil:Arac,IArac
    {
        public int MaksimumHiz { get; set; }
        public void AtesEt()
        {
            Console.WriteLine("Otomobilden ateş edildi");
        }
    }
}
