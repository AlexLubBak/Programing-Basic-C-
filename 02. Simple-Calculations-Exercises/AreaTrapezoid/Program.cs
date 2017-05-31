using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTrapezoid
{
    class Program
    {
        static void Main(string[] args)
        {

            double sideA = Double.Parse(Console.ReadLine());
            double sideB = Double.Parse(Console.ReadLine());
            double h = Double.Parse(Console.ReadLine());

            double areaTrapezoid = (sideA + sideB) * h / 2;

            Console.WriteLine($"Area Trapezoid= {areaTrapezoid}");

        }
    }
}
