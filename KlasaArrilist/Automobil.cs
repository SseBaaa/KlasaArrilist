using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaArrilist
{
    internal class Automobil
    {
        private string marka;
        public Automobil(string m)
        {
            marka = m;
        }
        public string dajMarku()
        {
            return marka;
        }
    }
}
