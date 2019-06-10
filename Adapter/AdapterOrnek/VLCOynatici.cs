using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOrnek
{
    public class VLCOynatici : IModernMedyaOynatabilen
    {
        public void OynatAVI(string dosyaAdi, string dosyaUzantisi)
        {
            throw new NotImplementedException();
        }

        public void OynatMP4(string dosyaAdi, string dosyaUzantisi)
        {
            Console.WriteLine(dosyaAdi + " dosyası yürütülüyor.");
        }

        public void OynatVLC(string dosyaAdi, string dosyaUzantisi)
        {

        }
    }
}