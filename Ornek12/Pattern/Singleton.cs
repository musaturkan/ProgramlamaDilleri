using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12.Pattern
{
    public class Singleton
    {
        private static Singleton _nesne;
        private Singleton() 
        {
            _nesne = new Singleton();
        }
        public static Singleton SingletonNesneGetir()
        {
            if (_nesne == null) 
            {
                _nesne = new Singleton();
            }
            return _nesne;
        }
    }
}
