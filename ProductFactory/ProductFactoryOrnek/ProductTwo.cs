using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryOrnek
{
    public class ProductTwo: IProduct
    {
        private string seriNo;

        public ProductTwo (string seriNo)
        {
            this.seriNo = seriNo;
        }

        public string Isimlendir()
        {
            return "Ürün2 --> ";
        }

        public string Numaralandir()
        {
            return seriNo;
        }
    }
}
