using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryOrnek
{
    public class ProductFactory
    {
        public IProduct GetProduct(string name)
        {
            if (name == "One")
                return new ProductOne("usdfds4");
            else if (name == "Two")
                return new ProductTwo("usdfs44");
            else
                return null;
        }
    }
}
