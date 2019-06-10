using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            MedyaOynatici mo = new MedyaOynatici();

            mo.Oynat("mp3", "Ceza");
            mo.Oynat("mp4", "JLO");
            mo.Oynat("avi", "Baby Driver");
            mo.Oynat("mpeg", "Şahin");

            Console.ReadLine();

        }
    }
}
