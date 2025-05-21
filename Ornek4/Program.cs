using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //çok boyutlu diziler, matrisler, görüntüler...
            //2 satır 4 sütundan oluşan matrisi çok boyutlu dizi ile temsil etmek
            int[,] matris = {
                               {1,5,4,7 },
                               {8,4,6,8 }
                            };

            Console.WriteLine(matris[1,3]);
            //matrisin elemanlarına sırayla erişip ekrana yazdırmak
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0;j<4; j++)
                {
                    Console.Write(" {0}",matris[i,j]);
                }
                Console.WriteLine();
            }
            //Ekrana yıldızlardan şekil yazdırmak
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j || i+j==10|| j==5)
                    {
                        Console.Write("*");
                    }
                    else if(i==5)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            ///Matrisin transpozunu nasıl alabiliriz? Bu işlemi yapan kodu yazınız.

        }
    }
}
