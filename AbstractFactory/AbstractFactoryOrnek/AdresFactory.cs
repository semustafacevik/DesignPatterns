using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrnek
{
    public interface IAdresFactory
    {
        Adres AdresOlustur();
        TelNumarası TelefonOlustur();
    }
}
