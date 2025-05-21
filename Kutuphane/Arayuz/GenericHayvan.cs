using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Arayuz
{
    /// <summary>
    /// Generic sınıf tanımlamak
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericHayvan<T> where T:IHayvan, new()
    {
        T _hayvan = new T();
        public void HayvanKonustur()
        {
            _hayvan.Konus();
        }
    }


    public class NesneOlustur<T> where T : new() 
    {
        public T NesneGetir()
        {
            return new T();
        }
    }
}
