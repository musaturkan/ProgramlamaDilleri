using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            //tam sayı değişkenler int ile tanımlanır
            //int maas = 5400;
            //int sayi1 = 25;
            //sayi1 = maas + 100;
            int dogumYili;
            int yas;
            string kullaniciAdi;
            float ondalikSayi;
            decimal hiz;
            double ondalikSayi2;
            Int64 sayi;
            bool cinsiyet;
            DateTime dogumTarihi;
            dogumTarihi = DateTime.Now.AddYears(-20);
            dogumTarihi.ToString("#dd.MM.yyyy");
            int saat = dogumTarihi.Hour;

            Console.WriteLine("Merhaba. adınızı giriniz");
            //Console.WriteLine(sayi1);
            
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine(kullaniciAdi + " hoşgeldin");
            Console.WriteLine("Doğduğun yılı gir");
            dogumYili = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Hesaplanan yaşınız:");
            yas = 2025 - dogumYili;
            Console.WriteLine(yas);
            //Console.WriteLine(2025 - dogumYili);

        }

        /// <summary>
        /// bu metot örnek olarak yazılmıştır
        /// </summary>
        static void ahmet()
        {
            int maas = 5000;
        }
    }

    public class Mehmet 
    {
        int yas = 40;
        static void Yazdır() 
        { 

        }
    }


}
