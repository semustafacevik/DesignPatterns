using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOrnek
{
    public class MedyaOynatici : IMedyaOynatabilen
    {
        MedyaAdapter madater;

        public void Oynat(string dosyaUzantisi, string dosyaAdi)
        {
            if (dosyaUzantisi == "mp3")
                Console.WriteLine(dosyaAdi + " dosyası yürütülüyor.");

            else if(dosyaUzantisi == "vlc" || dosyaUzantisi == "mp4" || dosyaUzantisi == "avi")
            {
                madater = new MedyaAdapter(dosyaUzantisi);
                madater.Oynat(dosyaAdi, dosyaUzantisi);
            }

            else
                Console.WriteLine("XXXX  -> " + dosyaAdi + " dosyası yürütülemiyor.");
        }
    }
}
