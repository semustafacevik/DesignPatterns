using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySekilOrnek
{
    public class Daire: ISekil
    {
        public void SekilCiz()
        {
            Console.WriteLine("** Daire çizilecek");
        }
    }
}
