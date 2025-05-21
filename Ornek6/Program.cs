using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Ornek6
{/// <summary>
/// async: Metodun asenkron olduğun belirten anahtar kelimedir
/// await: Asenkron işlemin bitmesini bekler, ana iş parçacığını bloklamazw
/// Task:asenkronolarak veri döndüren metodun geri dönüş tipidir
/// Task<T>:Asenkron metodun geri döndüreceği veri tipinin bildirimesi
/// Task sınfı altındaki metotlar kullanılarak asenkron işlemler başlatılabilir, bekletilebilir, toplu
/// toplu asenkron işlemleri yapılabilir. Asenkron olmayan metotlar paralel başlatılabilir
/// </summary>
    public class Program
    {
        static  async Task  Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            // Metot1Async();
            //Metot2Async();
            //Metot3Async();
            ///Farklı görevleri Task ile paralel başlatmak
            //Task gorev = Task.Factory.StartNew(() =>
            //{
            //    Task.Factory.StartNew(() => {
            //        Metot1();
            //    }, TaskCreationOptions.AttachedToParent);
            //    Task.Factory.StartNew(() => {
            //        Metot2();
            //    }, TaskCreationOptions.AttachedToParent);
            //    Task.Factory.StartNew(() => {
            //        Metot3();
            //    }, TaskCreationOptions.AttachedToParent);

            //}, TaskCreationOptions.AttachedToParent);

            //gorev.Wait();
            //await gorev;

            ///Asenkron metotları paralel çalıştırmanın diğer yolu
            Task gorev1 = Metot2Async();
            Task gorev2 = Metot3Async();
            Task gorev3 = Metot1Async();
            await Task.WhenAll(gorev1, gorev2,gorev3);


            //Metot1();
            //Metot2();
            //Metot3();
            Console.WriteLine(DateTime.Now);
        }

        /// <summary>
        /// 3 saniye süren işlem metodu
        /// </summary>
        public static void Metot1()
        {            
            Thread.Sleep(3000);
        }

        public static void Metot2()
        {
            Thread.Sleep(3000);
        }
        public static void Metot3()
        {
            Thread.Sleep(3000);
        }

        public static async Task<int> Metot1Async()
        {
            ///await anahtar kelimesi Sadece asenkron metot inçinde kullanılır
            ///asenkron metot içindeki bir işlemin bitmesini beklemek için kullanılır
            await Task.Delay(3000);

            return 45;
        }

        public static async Task Metot2Async()
        {
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Asenkron bir metot çağırıldığında ana program parçasındaki işlemler kilitlenmez
        /// </summary>
        /// <returns></returns>
        public static async Task Metot3Async()
        {
            //List<Task> gorevListe= new List<Task>();    

            //for (int i=0;i<50;i++)
            //{
            //    Task gorev = Task.Factory.StartNew(() =>
            //    {
            //        OrtalamHesap(i);
            //    });
            //    gorevListe.Add(gorev);
            //}

            //Task.WaitAll(gorevListe.ToArray());

            Thread.Sleep(3000);
        }
    }
}
