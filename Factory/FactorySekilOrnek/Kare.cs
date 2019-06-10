using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySekilOrnek
{
    public class Kare: ISekil
    {
        public void SekilCiz()
        {
            Console.WriteLine("*Kare çizilecek");
        }
    }
}
