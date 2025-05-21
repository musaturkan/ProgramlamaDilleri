using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public interface IArac
    {
        void AtesEt();

        void HareketEttir()
        {
            Console.WriteLine("Hareket etti");
        }
    }
}
