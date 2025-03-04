using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sebuah_konstruktor;

namespace Tunggul_Abdul_Majid_242410102058
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama : Tunggul Abdul Majid, NIM : 242410102058\n");
            
            mobil_sedan vios = new mobil_sedan("Toyota", "Vios",1500,"Putih", 2022, 5000000000);
            mobil_sedan camry = new mobil_sedan("Toyota", "Camry", 1500, "Putih", 2023, 6000000000);
            ikan salmon = new ikan("salmon", "Salmo salar", "Putih", "Laut");
            ikan cupang = new ikan("Cupang", "Betta Splendens", "Hitam", "Kolam, Aquarium");
            burung cenderawasih = new burung("Cenderawasih", "Paradisaea Rubra","Merah", "Papua, Indonesia");
            burung kakatua = new burung("Kakatua", "Cacatuidae", "Putih", "Australia, Indonesia Timur, dan Papua Nugini");
            komputer kentang = new komputer("Intel Core i3 7100", "Asrock H110", "Gamemax 450 watt", "Zotac GTX 750 TI", "Cube Gaming weiss");
            komputer bagus = new komputer("Intel Core i5 12500k", "Asrock Z390", "Cooler Master MWE 650 watt", "MSI RTX 4060 TI", "NZXT One");


            Console.ReadLine();
        }
    }
    
}
