using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOrnek
{
     public class MP4Oynatici: IModernMedyaOynatabilen
    {
        public void OynatVLC(string dosyaAdi, string dosyaUzantisi)
        {

        }

        public void OynatMP4(string dosyaAdi, string dosyaUzantisi)
        {
            Console.WriteLine(dosyaAdi + " dosyası yürütülüyor.");
        }

        public void OynatAVI(string dosyaAdi, string dosyaUzantisi)
        {
            throw new NotImplementedException();
        }
    }
}
