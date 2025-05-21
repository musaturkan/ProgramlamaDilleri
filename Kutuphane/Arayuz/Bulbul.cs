using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Arayuz
{
    public class Bulbul : IHayvan
    {
        public string Name { get; set; }

        public void Konus()
        {
            Console.WriteLine("cik cik cik cik");
        }

        public void Yuru(int metre)
        {
            Console.WriteLine("Bülbül yürüdü");
        }
    }
}
