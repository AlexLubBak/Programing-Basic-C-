using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {

            string figure = Console.ReadLine().ToLower();

            double area = 0;

            switch (figure)
            {
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    area = squareSide * squareSide;
                    break;

                case "rectangle":
                    double rectangleSideA = double.Parse(Console.ReadLine());
                    double rectangleSideB = double.Parse(Console.ReadLine());
                    area = rectangleSideA * rectangleSideB;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = radius * radius * Math.PI;
                    break;

                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHight = double.Parse(Console.ReadLine());
                    area = (triangleSide * triangleHight) / 2;
                    break;

                


            }

            Console.WriteLine("{0:f3}", area);

        }
    }
}
