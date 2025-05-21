using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Arayuz
{
    public interface IHayvan
    {
        string Name { get; set; }
        void Konus();
        void Yuru(int metre);

    }
}
