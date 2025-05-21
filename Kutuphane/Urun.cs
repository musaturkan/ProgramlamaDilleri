using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//?:Null geçilebilen değişken tanımlamaya yarar
namespace Kutuphane
{
    public class Urun
    {        
        public int Id { get; set; }
        public decimal? Fiyat { get; set; }
        public string? UrunAdi { get; set; }
        public int? MarkaId { get; set; }
    }
}
