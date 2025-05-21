using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kamyon:Arac,IArac
    {
        public int MaksimumYuk { get; set; }
        public void AtesEt()
        {
            Console.WriteLine("Kamyondan ateş edildi");
        }

        public void HareketEttir()
        {
            Console.WriteLine("Kamyon hareket etti");
        }
    }
}
