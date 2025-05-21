using Kutuphane.Arayuz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Günlük hayattaki nesnelerin, hakkında veriler tuttuğumuz kavramların (sipariş, fatura v.)
//programlama ortamındaki karşılıklarına sınıf diyoruz.
//Sınıflar nesnelerin hangi yeteneklere sahip olacağını belirten şablonlardır.
namespace Kutuphane
{
    public class Arac:IArac
    {
        protected double _yakitMiktari;
        public int? UretimYili { get; set; }
        public string? Renk { get; set; }
        public string? Marka { get; set; }
        public double YakitMiktari { get 
                                        {
                                            return _yakitMiktari;
                                        }
                                    }
        public  IKullanici  Komutan { get; set; }
        public void YakitYukle(double yuklenenYakit)
        {
            if (yuklenenYakit > 0)
            {
                _yakitMiktari += yuklenenYakit;
            }
        }
        public bool MotorCalisiyorMu {  get; set; }

        public virtual void HareketEt(int km)
        {
            YakitAzalt(km);
            Console.WriteLine("Araç {0}km hareket etti",km);
        }

        protected void YakitAzalt(int km)
        {
            var harcananYakitMiktari = km * 0.1;
            _yakitMiktari -= harcananYakitMiktari;
            if (_yakitMiktari < 0)
            {
                _yakitMiktari = 0;
                MotorCalisiyorMu = false;
            }
        }

        public void AtesEt()
        {
            Console.WriteLine("Araçtan ateş edildi");
        }
    }
}
