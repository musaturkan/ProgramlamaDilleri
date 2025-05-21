using Kutuphane.Arayuz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek8
{
    public class HayvanIslem
    {
        public void HayvanKonustur(IHayvan hayvan)
        {
            hayvan.Konus();
            hayvan.Yuru(45);
        }
    }
}
