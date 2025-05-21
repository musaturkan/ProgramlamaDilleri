using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Arayuz
{
    public class Kullanici:IKullanici
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Adres { get; set; }
        //public IHayvan Hayvan { get; set; }
        public List<IHayvan>? Hayvanlar { get; set; }
        public IArac? Arac { get; set; }

        //public Bulbul Bulbul { get; set; }
        //public Kurt Kurt { get; set; }
        //public Horoz Horoz { get; set; }

        //public Kurt Kurt2 { get; set; }
    }
}
