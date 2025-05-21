using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Arayuz
{
    public class Horoz : IHayvan
    {
        public string Name { get ; set ; }

        //public Kullanici Sahibi { get; set; }
        public IKullanici Sahibi { get; set; }
        public void Konus()
        {
            Console.WriteLine("Üürür üüüüüü");
        }

        public void Yuru(int metre)
        {
            Console.WriteLine("Horoz yürüdü");
        }
    }
}
