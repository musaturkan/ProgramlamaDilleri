using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Delegate Event İlişkisi
///Delegate olayın hangi metot veya metotları çağıracağını belirtir
///Event bir olayın dinlenebilmesini ve güvenli şekilde tetiklenmesini sağlar
///Delegate olmadan event olmaz, ancak delegate tek başına olay değildir
///Delegate = Metot Referansı
///Event = Olay bildirimi. Kimin ne zaman çalışacağını delegate belirler
///Event anahtar kelimesi dışarıdan delegatin doğrudan tetiklenmesini engeller Böylece sadece sınıf içinden tetiklenebilir
///Bir delegate birden fazla sınıfta kullanılmak istenirse namespace içinde tanımlanabilir
///Sadece sınıfa özel olarak kullanılacaksa ilgili sınıf içinde tanımlanabilir.
namespace Ornek12.Delegates
{
    public delegate void BildirimHandler(int ogrenciId, int dersId);
    public class Ogrenci
    {
        public delegate void NotIlanHandler(int ogrenciId, int dersId);
        public delegate void MesajGonderHandler(int ogrenciId, string mesaj);
  

        public event BildirimHandler NotIlanOlayi;
        public event BildirimHandler DersOnayOlayi;
        public event BildirimHandler MesajGonderOlayi;
        public event BildirimHandler DersSecmeOlayi;
        public void NotIlan(int OgrenciId,int DersId)
        {
            Console.WriteLine("Ogrenci notu ilan edildi");
            NotIlanOlayi?.Invoke(OgrenciId, DersId);
        }

        public void DersOnay(int DersId, int OgrenciId)
        {
            Console.WriteLine("Öğrencinin dersi onaylandı");
            DersOnayOlayi?.Invoke(DersId,OgrenciId);
        }
    }


    public class Ders
    {
        public event BildirimHandler YoklamaGiris;
        public event BildirimHandler NotIlanOlayi;
        public event EventHandler<DataModel.Kullanici> NotIlanEdildi;
        public void YoklamaGir(int DersId, int OgrenciId)
        {
            Console.WriteLine("Yoklama girildi");
            YoklamaGiris?.Invoke(OgrenciId, DersId);
        }

        public void NotIlan(int DersId,int DersAcmaNo)
        {
            Console.WriteLine("... dersinin notu ilan edildi");
            NotIlanOlayi?.Invoke(DersId, DersAcmaNo);

            NotIlanEdildi?.Invoke(this,new DataModel.Kullanici());
        }
    }
}
