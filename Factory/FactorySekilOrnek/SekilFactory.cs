using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySekilOrnek
{
    public class SekilFactory
    {
        public enum enSekilTuru
        {
            enKare,
            enDaire,
        };

        public ISekil GetSekil(enSekilTuru sekilTuru)
        {
            switch (sekilTuru)
            {
                case enSekilTuru.enKare:
                    return new Kare();

                case enSekilTuru.enDaire:
                    return new Daire();

                default:
                    return null;
            }
        }
    }
}
