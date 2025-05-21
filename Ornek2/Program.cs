using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlamak
            int[] maas = { 2500, 3540, 5874, 1254, 98745, 21457, 6589, 5478, 2587 };
            maas.Append(5000);
            Console.WriteLine(maas[0]);
            //Dizi elemanlarına döngülerle erişmek
            for(int i = 0; i<maas.Length; i++)
            {
                int vergi = maas[i] / 50;
                Console.WriteLine("{0}. maas:{1}",i,maas[i]);
            }
            Console.WriteLine("*******************************");
            Console.WriteLine("Vergi düşülmüş maaşlar");
            //while döngüsü ile dizi elemanlarına erişmek
            int sayac = 0;
            while (sayac < 9)
            {
                int vergi = maas[sayac] / 50;
                Console.WriteLine("{0}. maas:{1}", sayac+1, maas[sayac]-vergi);
                sayac++;
            }
            //do while döngüsü
            do
            {
                //ilk döngü işlemleri şarta bakılmaksızın çalıştırılır
            } while (sayac < 9); 
            //foreach döngüsü kullanmak
            foreach (int siradakiMaas in maas) 
            {
                //Console.WriteLine("siradaki maaş:");
                //Console.WriteLine(siradakiMaas);
                Console.WriteLine("maaaş:{0}", siradakiMaas);
            }
  

        }
    }
}
