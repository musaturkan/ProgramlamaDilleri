// See https://aka.ms/new-console-template for more information
using Kutuphane;
using Kutuphane.DataIslem;
using Kutuphane.DTO;
using System.CodeDom.Compiler;

Console.WriteLine("Hello, World!");

//Ogrenci ogr1 = new Ogrenci(); //Ogrenci sınıfından nesne oluşturma

//ogr1.ad = "alperen";
//ogr1.Soyad = "ünleyen";
//ogr1.Yas = 18;

//Ogrenci ogr2= new Ogrenci();
//ogr2.ad = "gamze";
//ogr2.Soyad = "atEş";
//ogr2.Yas = -25;


//Console.WriteLine(ogr2.Soyad);

KullaniciIslem islem = new KullaniciIslem();
KullaniciDto yeniKullanici = new KullaniciDto();
Console.WriteLine("Yeni kullanıcını adını giriniz");
yeniKullanici.Ad=Console.ReadLine();
Console.WriteLine("Yeni kullanıcının soyadını giriniz");
yeniKullanici.Soyad=Console.ReadLine();
islem.KullaniciEkle(yeniKullanici);

var liste = islem.KullaniciListeGetir();
foreach (var siradakiKullanici in liste)
{
    Console.WriteLine("{0} {1} - DogumTarihi:{2}",siradakiKullanici.Ad,siradakiKullanici.Soyad,siradakiKullanici.DogumTarihi);
}


