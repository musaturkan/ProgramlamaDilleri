using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Ramazan");
            var hesapSonuc = Sigmoid(1);
            //Fonksiyon argüman parantezleriyle çağırılır. Argüman olmasa da argüman parantezeleri yazılır
            EkranaYaz("Hoşgeldin Ramazan");
            ///Aynı isimli fakat farklı parametreli birden fazla metot yazılabilir
            ///Bu işleme metotların aşırı yüklenmesi denir. metod overloading
            
            Console.WriteLine(hesapSonuc);
            var toplam = Topla(45, 55);

            double cevre = 0;
            var alan = AlanHesapla(5, ref cevre);
            Console.WriteLine(cevre);
        }

        public static void EkranaYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        public static void EkranaYaz(int mesaj)
        {
            Console.WriteLine("Sayı:{0}", mesaj);
        }

        public static void EkranaYaz(double mesaj)
        {
            Console.WriteLine("Sayı:{0}", mesaj);
        }
        public static double Sigmoid(int deger) 
        {
            //Metodun ismi, parametre türü ve parametre sayısı metot imzası olarak adlandırılır
            //Her metodun imzası farklı olmalıdır
            //Fonksiyon parametresi olmasa bile parametre parantezleri yazılmalıdır
                        
            double sonuc = 0;
            sonuc = 1 / (1 + Math.Pow(Math.E, -deger));

            return sonuc;
        }

        /// <summary>
        /// Seçimlik parametreli metot yazılırken argümanlara varsayılan değer atanmalıdır
        /// </summary>
        /// <param name="sayi1">Varsayılan değeri sıfır kabul edilir</param>
        /// <param name="sayi2">Varsayılan değeri sıfır kabul edilir</param>
        /// <returns></returns>
        public static double Topla(double sayi1=0, double sayi2=0)
        {
            return sayi1+sayi2;
        }

        ///ref ve out anahtar sözcükleri
        public static double AlanHesapla(double yariCap, ref double a)
        {
            double alan = 2 * Math.PI * yariCap*yariCap;
            double cemberCevresi = 2 * Math.PI * yariCap;

            a = cemberCevresi;

            return alan;
        }
        

        ///Rekürsif fonksiyon - Özyinelemeli fonksiyon
        //Hiyerarşik verileri derinliğin sonuna kadar sorgulama
        //Faktöriyel hesapalamada kullanılır
        //şarta bağlı tekrar eden işlemlerde kullanılabilir
        public static double Faktoriyel(int sayi)
        {        
            //5*4*3*2*1
            if (sayi == 1)
            {
                return 1;
            }
            else
            {
                return sayi * Faktoriyel(sayi - 1);
            }
            
        }


        ///Asenkron metot tanımlama
        ///Ana iş parçacağını kilitlemeden diğer işlemelrin devam etmesini sağlar
        ///Asenkron programlama için async, await ve Task kullanılır
        ///


    }
}
