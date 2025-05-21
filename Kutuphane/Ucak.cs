using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Ucak:Arac,IArac
    {
        public int KanatUzunlugu { get; set; }

        public override void HareketEt(int km)
        {
            YakitAzalt(km); 
            Console.WriteLine("Uçak havalandı. {0}km uçtu",km);
        }

        public void AtesEt()
        {
            Console.WriteLine("Uçaktan ateş edildi");
        }

        public void HareketEttir()
        {
            Console.WriteLine("Uçak hareket etti");
        }
    }
}
