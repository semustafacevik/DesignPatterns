using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOrnek
{
    public class MedyaAdapter: IMedyaOynatabilen
    {
        IModernMedyaOynatabilen modernMedyaOynatici;

        public MedyaAdapter(string dosyaUzantisi)
        {
            if (dosyaUzantisi == "vlc")
                modernMedyaOynatici = new VLCOynatici();

            else if (dosyaUzantisi == "mp4")
                modernMedyaOynatici = new MP4Oynatici();

            else if (dosyaUzantisi == "avi")
                modernMedyaOynatici = new AVIOynatici();
        }

        public void Oynat(string dosyaAdi, string dosyaUzantisi)
        {
            if (dosyaUzantisi == "vlc")
                modernMedyaOynatici.OynatVLC(dosyaAdi, dosyaUzantisi);

            else if (dosyaUzantisi == "mp4")
                modernMedyaOynatici.OynatMP4(dosyaAdi, dosyaUzantisi);

            else if (dosyaUzantisi == "avi")
                modernMedyaOynatici.OynatAVI(dosyaAdi, dosyaUzantisi);
        }
    }
}
