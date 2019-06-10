using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrnek
{
    public class HollandaAdresFactory: IAdresFactory
    {
        public Adres AdresOlustur()
        {
            return new HollandaAdres();
        }

        public TelNumarası TelefonOlustur()
        {
            return new HollandaTelefon();
        }
    }
}
