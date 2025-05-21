// See https://aka.ms/new-console-template for more information
using Kutuphane;
using Kutuphane.Arayuz;
using Ornek9;

Console.WriteLine("Hello, World!");
///Tavsan sınfına yeni bir özellik eklemek istiyorum.
///

Tavsan t = new Tavsan();
t.Kos(5);

Arac a  = new Arac();
a.Marka = "TOGG";
a.FreneBas();

string kelime = "bilecik";
kelime.BuyukHarf();
