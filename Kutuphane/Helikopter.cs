using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Helikopter:Arac,IArac
    {
        public int PervaneUzunlugu { get; set; }
        public void AtesEt()
        {
            Console.WriteLine("Helikopter ateş edildi");
        }
    }
}
