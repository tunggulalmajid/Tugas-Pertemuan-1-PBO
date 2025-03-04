using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tunggul_Abdul_Majid_242410102058
{
    class mobil_sedan
    {
        public string merk;
        public string nama;
        public string warna;
        public int cc;
        public int tahun_keluar;
        public ulong harga;

        public mobil_sedan(string Merk, string nama_mobil, int cc_mobil, string warna_mobil, int tahun_keluar_pertama, ulong harga_mobil)
        {
            merk = Merk;
            nama = nama_mobil;
            cc = cc_mobil;
            warna = warna_mobil;
            tahun_keluar = tahun_keluar_pertama;
            harga = harga_mobil;

            Console.WriteLine($"Merk Sedan : {merk}");
            Console.WriteLine($"Nama Sedan : {nama}");
            Console.WriteLine($"Kapasitas CC : {cc}");
            Console.WriteLine($"Warna Sedan : {warna}");
            Console.WriteLine($"Tahun Keluar Pertama : {tahun_keluar}");
            Console.WriteLine($"Harga Saat Ini : Rp. {harga}");
            Console.WriteLine("");
        }
    }
}
