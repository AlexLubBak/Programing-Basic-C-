using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRegtangle
{
    class Program
    {
        static void Main(string[] args)
        {

            double side = Double.Parse(Console.ReadLine());

            double areaRegtangle = side * side;

            Console.WriteLine($"Square= {areaRegtangle}");

        }
    }
}
