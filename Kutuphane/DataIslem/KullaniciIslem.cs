using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using Kutuphane.DTO;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane.DataIslem
{
    public class KullaniciIslem : IIslem
    {
      public  enum YemekTurleri
        {
            Tatlı,
            Atıştırmalık,
            Et_yemeği,
            Izgara
        }

        public enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }

        public delegate void KullaniciEkle_temsilci(DataModel.Kullanici kullanici);

        public event KullaniciEkle_temsilci? KullaniciEkleHandler;

        /// <summary>
        /// Kullanıcı listesini dto nesnesi olarak döndüren metot
        /// </summary>
        public List<DTO.KullaniciDto> KullaniciListeGetir()
        {
            DataModel.LokantaContext model = new DataModel.LokantaContext();
            List<DTO.KullaniciDto> liste = new List<DTO.KullaniciDto>();
            liste = model.Kullanici.Select(s => new DTO.KullaniciDto
                                                {
                                                    Id=s.Id,
                                                    Ad=s.Ad,
                                                    Soyad=s.Soyad,
                                                    DogumTarihi=s.DogumTarihi

                                                }).ToList();



            return liste;
        }

        public void KullaniciEkle(DTO.KullaniciDto yeniKullanici)
        {
            DataModel.LokantaContext model  =new DataModel.LokantaContext();
            // Yeni entity nesnesi oluşturp propertyleri eşleştirme yöntemi
            //DataModel.Kullanici kullanici = new DataModel.Kullanici();
            //kullanici.Ad = yeniKullanici.Ad;
            //kullanici.Soyad = yeniKullanici.Soyad;
            //kullanici.DogumTarihi = yeniKullanici.DogumTarihi;
            ///DTO nesnelerini üçüncü parti dönüşüm kütüphaneleri ile dönüştürmek
            ///Kendi yazdığımız metot ile dönüşümü yapmak.
            ///

            DtoEntityDonusum donusum = new DtoEntityDonusum();
            //var kullanici = donusum.KullaniciDonustur(yeniKullanici);

            var kullanici = donusum.EntiyDonustur<DataModel.Kullanici, DTO.KullaniciDto>(yeniKullanici);

            //var c = donusum.EntiyDonustur<DataModel.Kullanici, DTO.KullaniciDTO2>(yeniKullanici);

            //var d = donusum.EntiyDonustur<Masa, abc>(donusturulmekIstenenNesse);

            model.Kullanici.Add(kullanici);

            model.SaveChanges();
        }

        public void KullaniciEkle(DTO.KullaniciDTO2 kullanici)
        {
            DataModel.LokantaContext model = new DataModel.LokantaContext();

            DtoEntityDonusum d=new DtoEntityDonusum();
            var k = d.EntiyDonustur<DataModel.Kullanici, DTO.KullaniciDTO2>(kullanici);

            KullaniciEkleHandler?.Invoke(k);
        }

        public void OrnekMetot()
        {
            ///sistemde kayıtlı yemek türleri
            ///1 tatlı
            ///2 et yemeği
            ///3 atıştırmalık
            ///
            DataModel.LokantaContext model = new LokantaContext();
            model.Yemek.Where(p => p.YemekTur.Ad == YemekTurleri.Tatlı.ToString()).ToList();

        }

        /// <summary>
        /// Deconstructor yani yıkıcı metot tanımıdır
        /// </summary>
        ~KullaniciIslem()
        {
            ///nesne bellekten silinirken çalışacak kodlar
        }

    }
}
