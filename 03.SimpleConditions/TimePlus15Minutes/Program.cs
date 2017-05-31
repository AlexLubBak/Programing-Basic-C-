using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timePlusMinute = (hour * 60) + minutes + 15;

            hour = timePlusMinute / 60;

            if (hour >= 24)
            {
                hour = hour % 24;
            }
            minutes = timePlusMinute % 60;

            if (minutes>=10)
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }

            
        }
    }
}
