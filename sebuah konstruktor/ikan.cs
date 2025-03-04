using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunggul_Abdul_Majid_242410102058
{
    class ikan
    {
        public string nama;
        public string nama_ilmiah;
        public string warna;
        public string tempat_hidup;


        public ikan(string nama_ikan, string nama_ilmiah_ikan, string warna_ikan, string tempat_hidup_ikan)
        {
            nama = nama_ikan;
            nama_ilmiah = nama_ilmiah_ikan;
            warna = warna_ikan;
            tempat_hidup = tempat_hidup_ikan;

            Console.WriteLine($"Nama Ikan : {nama}");
            Console.WriteLine($"Nama Ilmiah : {nama_ilmiah}");
            Console.WriteLine($"Warna Ikan : {warna}");
            Console.WriteLine($"Tempat Hidup : {tempat_hidup}");
            Console.WriteLine("");


        }

    }
}
