using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebuah_konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ikan salmon = new ikan("salmon", "Salmo salar", "Putih", "Laut");
            ikan cupang = new ikan("Cupang", "Betta Splendens", "Hitam", "Kolam, Aquarium");
            burung cenderawasih = new burung("Cenderawasih", "Paradisaea Rubra","Merah", "Papua, Indonesia");
            burung kakatua = new burung("Kakatua", "Cacatuidae", "Putih", "Australia, Indonesia Timur, dan Papua Nugini");
            mobil_sedan vios = new mobil_sedan("Toyota", "Vios",1500,"Putih", 2022, 5000000000);
            mobil_sedan camry = new mobil_sedan("Toyota", "Camry", 1500, "Putih", 2023, 6000000000);
        }
    }
}
