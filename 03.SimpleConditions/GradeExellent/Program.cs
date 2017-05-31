using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeExellent
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Exellent!");
            }
            else
            {
                Console.WriteLine("Not exellent.");
            }

        }
    }
}
