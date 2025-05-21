using Soyutlama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    public class LisansUstuOgrenci : IOgrenci
    {
        public List<IDers> DersListe
        {
            get
            {
                List<IDers> okunanDersListesi = new List<IDers>();
                okunanDersListesi.Add(new Ders { Kodu = "BLP101", Ad = "Programlama", Akts = 5, Kredi = 4 });
                okunanDersListesi.Add(new Ders { Kodu = "BLP102", Ad = "Veri Tabanı", Akts = 4, Kredi = 3 });
                okunanDersListesi.Add(new Ders { Kodu = "BLP103", Ad = "Web Programlama", Akts = 3, Kredi = 3 });
                okunanDersListesi.Add(new Ders { Kodu = "BLP104", Ad = "Mobil Uygulama", Akts = 2, Kredi = 3 });
                okunanDersListesi.Add(new Ders { Kodu = "BLP105", Ad = "Tasarım Desenleri", Akts = 3, Kredi = 3 });
                return okunanDersListesi;
            }
        }
        public void DersEkle(IDers yeniDers)
        {
            Console.WriteLine("Lisansüstü öğrenciye ders eklendi");
        }

        public List<IDers> TranskriptHesapla(List<IDers> dersListe)
        {
            Console.WriteLine("Lisansüstü  öğrencisi için transkript hesaplandı");
            var liste = DersListe.Select(s => new Ders
            {
                Kodu = s.Kodu,
                Ad = s.Ad,
                Akts = s.Akts
            }).ToList();

            List<IDers> sonuc = new List<IDers>();
            sonuc.AddRange(liste);
            return sonuc;
        }
    }
}
