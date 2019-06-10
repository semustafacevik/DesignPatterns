using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory pf = new ProductFactory();

            IProduct product1 = pf.GetProduct("One");
            Console.WriteLine(product1.Isimlendir() + product1.Numaralandir());

            IProduct product2 = pf.GetProduct("Two");
            Console.WriteLine(product2.Isimlendir() + product2.Numaralandir());

            Console.Read();
        }
    }
}
