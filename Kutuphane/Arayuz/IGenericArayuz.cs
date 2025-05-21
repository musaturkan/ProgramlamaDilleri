using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Arayuz
{
    /// <summary>
    /// Generic arayüz tanımlamak
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericArayuz<T>
    {
        void Ekle(T veri);
        T Getir();
    }


    public class GenericSinif<T> : IGenericArayuz<T> where T : class, new()
    {
        T _veri;
        public GenericSinif()
        {
            _veri = new T();
        }
        public void Ekle(T veri)
        {
           //_veri = veri;
        }

        public T Getir()
        {
            return _veri;
        }
    }
}
