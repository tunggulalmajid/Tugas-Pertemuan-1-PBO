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
            ikan wader = new ikan("wader", "waderion", "putih", "sungai", 10000);
            ikan teri = new ikan("teri", "terion", "putih", "laut", 1000000);
            burung merpati = new burung("merpati", "merpation", "putih, hitam, abu abu","jawa", 900000 );
            burung Jalak = new burung("Jalak", "Jalak aja", "putih", "bali", 900);
            mobil_sedan vios = new mobil_sedan("Toyota Vios", 2001, 1500, "Hitam, Putih", 100000000);
            mobil_sedan civic = new mobil_sedan("Honda Civic", 2004, 1700, "Hitam, Putih, Merah", 500000000);
        }
    }
}
