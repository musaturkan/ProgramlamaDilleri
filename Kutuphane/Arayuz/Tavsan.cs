using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Arayuz
{
    public class Tavsan : IHayvan
    {
        public string Name { get; set; }
        public IHayvan Sahibi { get; set; }
        public void Konus()
        {
           
        }

        public void Yuru(int metre)
        {
            
        }
    }
}
