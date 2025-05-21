using Kutuphane.DataIslem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek13.Pattern
{
    public static class FabrikaIslem
    {
        public static T IslemGetir<T>() where T : class,IIslem,new()
        {
            return new T();
        }

        public static IIslem NesneGetir(string nesneAdi)
        {
            if (nesneAdi == "MasaIslem")
            {
                return new MasaIslem();
            }
            else
            {
                return new MasaIslem();
            }
        }

        //public static MasaIslem MasaIslemGetir()
        //{
        //    return new MasaIslem(); 
        //}

        //public static KullaniciIslem KullaniciIslemGetir()
        //{
        //    return new KullaniciIslem();
        //}

        //public static SiparisIslem SiparisIslemGetir()
        //{
        //    return new SiparisIslem();
        //}

    }
}
