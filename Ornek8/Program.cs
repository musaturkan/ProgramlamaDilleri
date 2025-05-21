
//interface kavramı

using Kutuphane;
using Kutuphane.Arayuz;
using Ornek8;

internal class Program
{
    private static void Main(string[] args)
    {
        //IHayvan k = new Kurt();

        //IHayvan b = new Bulbul();
        //IHayvan h = new Horoz();
        //HayvanIslem islem = new HayvanIslem();
        //k = new Bulbul();
        //islem.HayvanKonustur(k);
        //k = new Horoz();
        //islem.HayvanKonustur(k);
        //islem.HayvanKonustur(h);
        //islem.HayvanKonustur(b);

        //AracIslem aracIslem = new AracIslem();
        //aracIslem.Arac = new Ucak();
        //aracIslem.Arac.AtesEt();
        //aracIslem.Arac=new Kamyon();
        //aracIslem.Arac.AtesEt();
        Kullanici kullanici = new Kullanici();
        while (true)
        {
            Console.WriteLine("Kullanmak için bir araç seçiniz. k:kamyon,u:uçak,o:otomobil,h:helikopter");
            string secim = Console.ReadLine();
            if (secim == "k")
            {
                kullanici.Arac = new Kamyon();
            }
            else if (secim == "u")
            {
                kullanici.Arac = new Ucak();
            }
            else if (secim == "h")
            {
                kullanici.Arac = new Helikopter();
            }
            else
            {
                kullanici.Arac = new Otomobil();
            }

            kullanici.Arac.AtesEt();
            AracIslem islem = new AracIslem();
            islem.AracHareketEttir(kullanici.Arac);
        }
    }
}