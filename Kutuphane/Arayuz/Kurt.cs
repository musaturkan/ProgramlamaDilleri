using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Arayuz
{
    public class Kurt : IHayvan
    {
        public string Name { get; set; }
        public IHayvan Sahibi { get; set; }
        public void Konus()
        {
            Console.WriteLine("aaaauuuuu aaaauuuuuu aaaauuuuuuu");
        }

        public void Yuru(int metre)
        {
            Console.WriteLine("Kurt yürüdü");
        }
    }
}
