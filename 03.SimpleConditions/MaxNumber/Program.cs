using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter two integers: ");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine($"Greater number: {numberOne}");
            }
            else
            {
                Console.WriteLine($"Greater number: {numberTwo}");
            }



        }
    }
}
