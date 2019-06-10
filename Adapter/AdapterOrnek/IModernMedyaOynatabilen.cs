using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOrnek
{
    public interface IModernMedyaOynatabilen
    {
        void OynatVLC(string dosyaAdi, string dosyaUzantisi);
        void OynatMP4(string dosyaAdi, string dosyaUzantisi);
        void OynatAVI(string dosyaAdi, string dosyaUzantisi);
    }
}
