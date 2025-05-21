using Kutuphane.DataIslem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek13.Pattern
{
    public class Singleton
    {
        private static Singleton _nesne;
        private static KullaniciIslem _kullaniciIslem;
        private static object _lock = new object();
        private Singleton() { }

        public static Singleton NesneGetir()
        {
            lock (_lock)
            {
                if (_nesne == null)
                {
                    _nesne = new Singleton();
                }
                return _nesne;
            }
        }

        public static KullaniciIslem KullaniciIslem()
        {
            lock (_lock)
            {
                if (_kullaniciIslem == null)
                {
                    _kullaniciIslem = FabrikaIslem.IslemGetir<KullaniciIslem>();
                }
                return _kullaniciIslem;
            }
        }
    }
}
