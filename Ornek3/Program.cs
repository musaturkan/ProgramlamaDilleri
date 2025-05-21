using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Karar yapıları kullanmak
            //0 ile 1000 arasındaki 7 ve 13'e kalansız bölünen sayıların
            //ekrana yazılması
            int toplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 7 == 0 && i % 13 == 0)
                {
                    toplam += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(toplam);
            //&&:Mantıksal ve operatörüdür.
            //||:Mantıksal veya operatörüdür
            //int sayi = 10;
            //if (sayi > 100 && sayi < 20)
            //{

            //}
            //else if (sayi > 90)
            //{

            //}
            //else if (sayi > 80)
            //{

            //}
            //else 
            //{

            //}
        }
    }
}
