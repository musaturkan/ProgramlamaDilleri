using Kutuphane;
using Kutuphane.Arayuz;
public class Program
{
    
    private static void Main(string[] args)
    {
        double ortalama = 78.87f;
        int sayi;
        sayi = 12;
        var k = "Ali";
        List<int> liste = new List<int>();
        liste.Add(15);liste.Add(87);liste.Add(47);liste.Add(68);

        List<string> liste2 = new List<string>();
        List<Kutuphane.Arayuz.IHayvan> liste3 = new List<Kutuphane.Arayuz.IHayvan>();

        var sonuc = Topla<int>(sayi, 15);
        var sonuc2 = Topla<double>(ortalama, 15);
        var sonuc3 = Topla<string>("merhaba", " selam");

        GenericHayvan<Horoz> h = new GenericHayvan<Horoz>();
        h.HayvanKonustur();
        GenericHayvan<Kurt> h2 = new GenericHayvan<Kurt>();
        h2.HayvanKonustur();
        GenericHayvan<Tavsan>h3=new GenericHayvan<Tavsan>();

        GenericSinif<Ucak> u = new GenericSinif<Ucak>();
        var c = u.Getir();

        //Kamyon k1 = new Kamyon();
        //Ucak u = new Ucak();

        GenericSinif<Kamyon>u2=new GenericSinif<Kamyon>();
        var d = u2.Getir();

        Console.WriteLine("Hello, World!");

        dynamic dinamikDeger;
        dinamikDeger = 25;
        Console.WriteLine("dinamik tipin türü:{0}", dinamikDeger.GetType());
        sonuc = sayi + dinamikDeger;

        dinamikDeger = "Merhaba";
        Console.WriteLine("dinamik tipin türü:{0}", dinamikDeger.GetType());
        dinamikDeger = new GenericSinif<Kamyon>();
        Console.WriteLine("dinamik tipin türü:{0}", dinamikDeger.GetType());
        var nesne = dinamikDeger.Getir();
    }
    //Generic Topla metodunu yazmak
    public static T Topla<T>(T sayi1, T sayi2) //where T:struct
    {
        dynamic a = sayi1;
        dynamic b = sayi2;
        return  a + b;
    }
    ///where ile T tipine yazılacak tiplerin türü kısıtlanabilir
    ///T tipi bir obje olmak zorundaysa where T:class şeklinde belirtilir
    ///T tipi belli bir sınıftan türetilen nesneler olmak zorunda ise where T:IHayvan
    ///T tipi new ile türetilmek zorundadır where T:new()
    ///T tipi değer tipli değişken olsun istenirse where T:struct

    //public static int Topla(int sayi1, int sayi2)
    //{
    //    return sayi1+sayi2;
    //}

    //public static int Topla(int sayi1, double sayi2)
    //{
    //    return sayi1 + sayi2;
    //}
}