using Kutuphane.DataIslem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12.Islem
{
    public class KullaniciOlaylari
    {
        public void YeniEkle(Kutuphane.DTO.KullaniciDto yeni)
        {
            KullaniciIslem kullanici = new KullaniciIslem();
            kullanici.KullaniciEkleHandler += Kullanici_KullaniciEkleHandler;
            kullanici.KullaniciEkle(yeni);
         
        }

        private void Kullanici_KullaniciEkleHandler(DataModel.Kullanici kullanici)
        {
            ///bu olan tetiklendiğinde yazılacak kodlar buraya eklenecektir.
            Console.WriteLine("Kullanıcı ekleme olayı tetiklendi");
        }
    }
}
