using DataModel;
using Kutuphane.DataIslem.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataIslem
{
    public class SiparisEventArgs : EventArgs
    {
        public int Adet { get; }
        public string UrunAdi { get; }
        public SiparisEventArgs(string urunAdi, int adet)
        {
            UrunAdi = urunAdi;
            Adet = adet;
        }
    }
    public class SiparisIslem: IIslem
    {
        public event BildirimHandler? SiparisVerildi;
        public event BildirimHandler? SiparisIptal;

        public event EventHandler<SiparisEventArgs>? TeslimEdildi;
        public event EventHandler<Urun>? ZamYapildi;
        public void SiparisEkle(int kullaniciId, int UrunId)
        {
            Console.WriteLine("Sipariş eklendi");
            SiparisVerildi?.Invoke(kullaniciId, "Sipariş verildi");
        }

        public void SiparisIptalEt(int kullaniciId, int UrunId)
        {
            Console.WriteLine("Sipariş eklendi");
            SiparisIptal?.Invoke(kullaniciId, "Sipariş verildi");
        }

        public void SiparisTeslimEt(int siparisId)
        {
            Console.WriteLine("Sipariş eklendi");
            SiparisEventArgs e = new SiparisEventArgs("Telefon", 2);
            
            TeslimEdildi?.Invoke(this, e);
        }

        public void ZamYap(Urun urun)
        {
            Console.WriteLine("{0} ismili ürüne zam yapıldı", urun.UrunAdi);
            ZamYapildi?.Invoke(this, urun);
        }
    }
}
