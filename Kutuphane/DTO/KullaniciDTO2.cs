using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DTO
{
    public class KullaniciDTO2:IDto
    {
        public int Id { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Parola { get; set; }
    }
}
