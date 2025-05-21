

using Kutuphane.DataIslem;
using Ornek12.Delegates;
using Ornek12.Islem;

Ogrenci ogrenci = new Ogrenci();
//NotIlanHandler notIlanTemsilci = ogrenci.NotIlan;
//notIlanTemsilci(45, 258);

//notIlanTemsilci = ogrenci.DersOnay;
//notIlanTemsilci(45, 698);

ogrenci.NotIlanOlayi += Mesaj.SmsGonder;
ogrenci.DersOnayOlayi += Mesaj.SmsGonder;

ogrenci.NotIlan(58, 34);


SiparisIslem siparis  = new SiparisIslem();
siparis.SiparisVerildi += Mesaj.EpostaGonder;
siparis.SiparisIptal += Mesaj.EpostaGonder;
siparis.TeslimEdildi += Mesaj.TeslimMesaj; 


siparis.SiparisEkle(45, 34);
siparis.SiparisTeslimEt(45);
