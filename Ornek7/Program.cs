using Kutuphane;


//Urun u = new Urun();
//Urun urun1 = new Urun();
//u.Id = 10;
//u.MarkaId = 105;
//u.UrunAdi = "Televizyon";
//u.Fiyat = 18550;

//urun1.Id = 11;
//urun1.MarkaId = 106;
//urun1.UrunAdi = "Lamba";
//urun1.Fiyat = 45;


//List<Urun> urunListe = new List<Urun>();
//urunListe.Add(urun1);
//urunListe.Add(u);

//foreach (var siradakiUrun in urunListe)
//{
//    Console.WriteLine(siradakiUrun.UrunAdi);
//    var urunFiyatı= siradakiUrun.Fiyat + siradakiUrun.Fiyat * 0.18m;
//    Console.WriteLine("Urünün satış fiyatı:{0}",urunFiyatı);
//}

Arac araba1 = new Arac();
Console.WriteLine(araba1.YakitMiktari);
araba1.Marka = "Toyota";
araba1.Renk = "Mavi";
araba1.UretimYili = -2019;
araba1.YakitYukle(70);
Console.WriteLine(araba1.YakitMiktari);
araba1.MotorCalisiyorMu = true;
araba1.HareketEt(20);

Console.WriteLine(araba1.YakitMiktari);
araba1.HareketEt(500);
Console.WriteLine(araba1.YakitMiktari);

Kamyon k = new Kamyon();
k.Marka = "Scania";
Otomobil o = new Otomobil();
o.Marka = "Mazda";
Ucak u = new Ucak();
u.Marka = "Kızılelma";

Islem islem=new Islem();
islem.AracHareketEttir(k,23);
islem.AracHareketEttir(u,54);
islem.AracHareketEttir(o,78);
islem.AracHareketEttir(araba1,67);