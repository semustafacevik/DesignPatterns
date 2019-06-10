using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrnek
{
    public abstract class Adres
    {
        public string getTamAdres(string ulke)
        {
            return ulke + " -->  ";
        }
    }
}
