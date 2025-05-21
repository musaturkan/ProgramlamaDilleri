using Kutuphane;
using Kutuphane.Arayuz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek9
{
    /// <summary>
    /// Farklı sınıflar için bir genişletme metodu yazıyoruz.
    /// </summary>
    public static class ExtensionsMethods
    {
        public static void Kos(this Tavsan tavsan,int mesafe)
        {
            Console.WriteLine("Tavşan koşarak kaçtı");
        }

        public static void FreneBas(this Arac arac)
        {
            Console.WriteLine("{0} markalı Aracın frenine basıldı",arac.Marka);
        }

        public static void BuyukHarf(this string kelime)
        {
            Console.WriteLine(kelime.ToUpper());
        }
    }
}
