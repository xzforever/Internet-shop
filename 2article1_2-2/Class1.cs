using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article1_2_2
{
    class Electronics
    {
        public string Name;
        public int Voltage;
        public int Weight;

        public void PrintElectro()
        {
            Console.WriteLine($"Type: {Name}");
            Console.WriteLine($"Voltage: {Voltage}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine();
        }
    }
    class Books
    {
        public string Name;
        public int Weight;
        public int PageNum;

        public void PrintBooks()
        {
            Console.WriteLine($"Type: {Name}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Number of pages: {PageNum}");
            Console.WriteLine();
        }
    }

}
