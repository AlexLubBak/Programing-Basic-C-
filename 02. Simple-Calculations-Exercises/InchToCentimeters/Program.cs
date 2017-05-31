using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = Double.Parse(Console.ReadLine());

            double centimeters = inches * 2.54;

            Console.WriteLine($"centimeters= {centimeters}");

        }
    }
}
