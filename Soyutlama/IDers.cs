using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyutlama
{
    public interface IDers
    {
        public string Kodu { get; set; }
        public string Ad { get; set; }
        public int Akts { get; set; }
        public int Kredi { get; set; }
    }
}
