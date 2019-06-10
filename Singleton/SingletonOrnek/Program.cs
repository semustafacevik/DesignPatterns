using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleObject s1 = SingleObject.getIntance();
            SingleObject s2 = SingleObject.getIntance();
            SingleObject s3 = SingleObject.getIntance();
        }
    }
}
