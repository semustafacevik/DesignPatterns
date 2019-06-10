using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrnek
{
    public class ABDAdresFactory : IAdresFactory
    {
        public Adres AdresOlustur()
        {
            return new ABDAdres();
        }

        public TelNumarası TelefonOlustur()
        {
            return new ABDTelefon();
        }
    }
}
