using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soyutlama;
using Islem;

namespace Fabrika
{
    public static class OgrenciFabrika
    {
        public static T NesneGetir<T>() where T : class, IOgrenci, new()
        {
            return new T();
        }
        public static IOgrenci NesneGetir(string NesneTuru)
        {
            if (NesneTuru == "OnLisans")
            {
                return new OnLisansOgrenci();
            }
            else if(NesneTuru=="Lisans")
            {
                return new LisansOgrenci();
            }
            else //if (NesneTuru == "Lisansustu")
            {
                return new LisansOgrenci();
            }
        }
    }
}
