using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySekilOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            SekilFactory sf = new SekilFactory();

            ISekil sekil1 = sf.GetSekil(SekilFactory.enSekilTuru.enKare);
            sekil1.SekilCiz();

            ISekil sekil2 = sf.GetSekil(SekilFactory.enSekilTuru.enDaire);
            sekil2.SekilCiz();

            Console.Read();
        }
    }
}
