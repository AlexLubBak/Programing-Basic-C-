﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine();

            if (sex.Equals("f"))
            {
                if (age<16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (sex.Equals("m"))
            {
                if (age<16)
                {
                    Console.WriteLine("Master");
                }
                else if (age>=16)
                {
                    Console.WriteLine("Mr.");
                }
            }


        }


    }
}
