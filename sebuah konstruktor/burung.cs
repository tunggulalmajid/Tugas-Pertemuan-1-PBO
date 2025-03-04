using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebuah_konstruktor
{
    internal class burung
    {
        public string nama;
        public string nama_ilmiah;
        public string warna;
        public string asal;

        public burung(string nama_burung,string nama_ilmiah_burung ,string warna_burung, string asal_burung ) 
        {
            nama = nama_burung;
            nama_ilmiah = nama_ilmiah_burung;
            warna = warna_burung;
            asal = asal_burung;

            Console.WriteLine($"Nama Burung : {nama}");
            Console.WriteLine($"Nama Ilmiah : {nama_ilmiah}");
            Console.WriteLine($"Warna : {warna}");
            Console.WriteLine($"Asal : {asal}");
            Console.WriteLine("");
        }
    }
}
