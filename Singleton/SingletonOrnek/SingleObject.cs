using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonOrnek
{
    public class SingleObject
    {
        private static SingleObject instance;

        private SingleObject()
        {
        }

        public static SingleObject getIntance()
        {
            if (instance == null)
            {
                instance = new SingleObject();
                Console.WriteLine("Yeni");
            }

            else
                Console.WriteLine("Var olan");

            return instance;
        }

    }
}
