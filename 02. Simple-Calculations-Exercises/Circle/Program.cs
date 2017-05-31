using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = Double.Parse(Console.ReadLine());

            double areaCircle = Math.PI * radius * radius;
            double perimeterCircle = 2 * Math.PI * radius;

            Console.WriteLine($"Area = {areaCircle}");
            Console.WriteLine($"Perimeter = {perimeterCircle}");

        }
    }
}
