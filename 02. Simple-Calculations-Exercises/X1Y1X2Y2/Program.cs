using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X1Y1X2Y2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());
            double x2 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());


            double area = Math.Abs(x1 - x2) * Math.Abs(y2 - y1);
            double perimeter = (2 * Math.Abs(x1 - x2) + 2 *Math.Abs (y2 - y1));

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
