using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sebuah_konstruktor
{
    internal class mobil_sedan
    {
        public string nama;
        public string warna;
        public int cc;
        public int tahun_keluar;
        public int harga;
        
        public mobil_sedan(string nama_mobil, int tahun_keluar_pertama, int cc_mobil, string warna_mobil, int harga_mobil) 
        { 
            nama = nama_mobil;
            tahun_keluar = tahun_keluar_pertama;
            cc = cc_mobil;
            warna = warna_mobil;
            harga = harga_mobil;

            Console.WriteLine($"Nama Sedan : {nama}");
            Console.WriteLine($"Tahun Keluar Pertama : {tahun_keluar}");
            Console.WriteLine($"Kapasitas CC : {cc}");
            Console.WriteLine($"Warna Sedan : {warna}");
            Console.WriteLine($"Harga Saat Ini : {harga}");
            Console.WriteLine("");


        }
    }
}
