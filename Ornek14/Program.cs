

using Islem;
using Microsoft.Extensions.DependencyInjection;
using Ornek14;
using Soyutlama;
using System.Windows.Input;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        IOgrenci _ogr = Fabrika.OgrenciFabrika.NesneGetir("OnLisans");
        List<IDers> _dersListe;
        IKullanici _kullanici;

       
        _ogr.TranskriptHesapla(_ogr.DersListe);

        _ogr = Fabrika.OgrenciFabrika.NesneGetir<LisansOgrenci>();

        _ogr.TranskriptHesapla(_ogr.DersListe);

        OgrenciDersSayfasi.DersGetir(_ogr);
        Console.WriteLine("Yeni kod satırı");
       ///aeiaeiuaieu
        Console.WriteLine("Hello, World!");
    }
}