using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyutlama
{
    public interface IOgrenci
    {
        public List<IDers> DersListe { get; }
        public List<IDers> TranskriptHesapla(List<IDers> dersListe);
        public void DersEkle(IDers yeniDers);

    }
}
