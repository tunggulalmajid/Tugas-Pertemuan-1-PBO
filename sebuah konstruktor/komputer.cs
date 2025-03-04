using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebuah_konstruktor
{
    class komputer
    {
        public string Processor;
        public string Motherboard;
        public string PSU;
        public string VGA;
        public string Casing;

        public komputer(string processor, string motherboard, string pSU, string vGA, string casing)
        {
            Processor = processor;
            Motherboard = motherboard;
            PSU = pSU;
            VGA = vGA;
            Casing = casing;

            Console.WriteLine($"Processor : {Processor}");
            Console.WriteLine($"Motherboard : {Motherboard}");
            Console.WriteLine($"Power Supply : {PSU}");
            Console.WriteLine($"VGA : {VGA}");
            Console.WriteLine($"Casing : {Casing}");
            Console.WriteLine("");
        }

    }
}
