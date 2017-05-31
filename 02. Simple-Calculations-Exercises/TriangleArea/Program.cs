using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = Double.Parse(Console.ReadLine());
            double height = Double.Parse(Console.ReadLine());


            double areaTriangle = Math.Round((side * height / 2), 2);

            Console.WriteLine($"Triangle area = {areaTriangle}");

        }
    }
}
