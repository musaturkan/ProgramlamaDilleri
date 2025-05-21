using Kutuphane.DataIslem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12.Islem
{
    public class Mesaj
    {
        public static void SmsGonder(int OgrenciId, int mesaj)
        {
            Console.WriteLine("SMS Gönderildi");
        }

        public static void EpostaGonder(int OgrenciId, string Mesaj)
        {
            Console.WriteLine("SMS Gönderildi");
        }

        public static void TeslimMesaj(object? nesne,SiparisEventArgs e)
        {
            Console.WriteLine("{0} {1} Sipariş teslim edildi",e.Adet, e.UrunAdi);
        }
    }
}
