using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject36
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# sınavı için örnek

            CBitki b1 = new CBitki();
            b1.Beslenme = "gübre";

            CBitki b2 = b1;
            b2.Beslenme = "su";

            Console.WriteLine("b1 beslenme = " + b1.Beslenme);
            Console.ReadLine();
        }
    }
}
