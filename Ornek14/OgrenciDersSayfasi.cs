using Soyutlama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek14
{
    public static class OgrenciDersSayfasi
    {
        public static List<IDers> DersGetir(IOgrenci ogr)
        {
            return ogr.TranskriptHesapla(ogr.DersListe);
        }
    }
}
