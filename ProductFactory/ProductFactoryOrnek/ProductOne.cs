using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryOrnek
{
    public class ProductOne: IProduct
    {
        private string seriNo;

        public ProductOne(string seriNo)
        {
            this.seriNo = seriNo;
        }


        public string Isimlendir()
        {
            return "Ürün1 --> ";
        }

        public string Numaralandir()
        {
            return seriNo;
        }
    }
}
