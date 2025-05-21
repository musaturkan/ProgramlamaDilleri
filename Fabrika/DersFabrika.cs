using Soyutlama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika
{
    public static class DersFabrika
    {
        public static T NesneGetir<T>() where T : class, IDers, new()
        {
            return new T();
        }
    }
}
