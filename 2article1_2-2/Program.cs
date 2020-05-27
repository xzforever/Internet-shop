using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article1_2_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Electronics pc = new Electronics();
            pc.Name = "Computer";
            pc.Voltage = 12;
            pc.Weight = 5;

            Electronics phone = new Electronics();
            phone.Name = "Phone";
            phone.Voltage = 10;
            phone.Weight = 03;

            Books book1 = new Books();
            book1.Name = "Novel";
            book1.Weight = 05;
            book1.PageNum = 399;

            Books book2 = new Books();
            book2.Name = "Horror";
            book2.Weight = 04;
            book2.PageNum = 150;

            pc.PrintElectro();
            phone.PrintElectro();
            book1.PrintBooks();
            book2.PrintBooks();

        }
    }
}
