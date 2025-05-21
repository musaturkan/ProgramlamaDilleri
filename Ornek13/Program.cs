// See https://aka.ms/new-console-template for more information
using Kutuphane.DataIslem;
using Ornek13.Pattern;

Console.WriteLine("Hello, World!");

Singleton s = Singleton.NesneGetir();

KullaniciIslem kullaniciIslem = Singleton.KullaniciIslem();

KullaniciIslem kullaniciIslem3 = Singleton.KullaniciIslem();

KullaniciIslem kullaniciIslem2 = Singleton.KullaniciIslem();

try
{
    MasaIslem mi = FabrikaIslem.IslemGetir<MasaIslem>();
    KullaniciIslem ki = FabrikaIslem.IslemGetir<KullaniciIslem>();  
    
}
catch
{
    //hata olduğunde verilecek mesaj ve yapılacak işlemler
}




