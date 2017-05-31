using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateStringNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            String town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

        }
    }
}
