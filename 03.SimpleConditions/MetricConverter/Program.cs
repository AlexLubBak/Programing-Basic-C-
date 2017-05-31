using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {


            double value = double.Parse(Console.ReadLine());
            String vhodnaEdinica = Console.ReadLine();
            String izhodnaEdinica = Console.ReadLine();
            double izhodnaValue = 0.0;

            if (vhodnaEdinica.Equals("m") && izhodnaEdinica.Equals("mm"))
            {

                izhodnaValue = value * 1000;
            }
            else if (vhodnaEdinica.Equals("m") && izhodnaEdinica.Equals("cm"))
            {
                izhodnaValue = value * 100;
            }
            else if (vhodnaEdinica.Equals("m") && izhodnaEdinica.Equals("mi"))
            {
                izhodnaValue = value * 0.000621371192;
            }
            else if (vhodnaEdinica.Equals("m") && izhodnaEdinica.Equals("in"))
            {
                izhodnaValue = value * 39.3700787;
            }
            else if (vhodnaEdinica.Equals("m") && izhodnaEdinica.Equals("km"))
            {
                izhodnaValue = value * 0.001;
            }
            else if (vhodnaEdinica.Equals("m") && izhodnaEdinica.Equals("ft"))
            {
                izhodnaValue = value * 3.2808399;
            }
            else if (vhodnaEdinica.Equals("m") && izhodnaEdinica.Equals("yd"))
            {
                izhodnaValue = value * 1.0936133;
            }
            else if (vhodnaEdinica.Equals("mm") && izhodnaEdinica.Equals("m"))
            {
                izhodnaValue = value / 1000;
            }
            else if (vhodnaEdinica.Equals("mm") && izhodnaEdinica.Equals("cm"))
            {
                izhodnaValue = value / 10;
            }
            else if (vhodnaEdinica.Equals("mm") && izhodnaEdinica.Equals("mi"))
            {
                izhodnaValue = value * 0.000000621371192;
            }
            else if (vhodnaEdinica.Equals("mm") && izhodnaEdinica.Equals("in"))
            {
                izhodnaValue = value * 0.0393700787;
            }
            else if (vhodnaEdinica.Equals("mm") && izhodnaEdinica.Equals("km"))
            {
                izhodnaValue = value * 0.000001;
            }
            else if (vhodnaEdinica.Equals("mm") && izhodnaEdinica.Equals("ft"))
            {
                izhodnaValue = value * 0.0032808399;
            }
            else if (vhodnaEdinica.Equals("mm") && izhodnaEdinica.Equals("yd"))
            {
                izhodnaValue = value * 0.0010936133;
            }
            else if (vhodnaEdinica.Equals("cm") && izhodnaEdinica.Equals("m"))
            {
                izhodnaValue = value / 100;
            }
            else if (vhodnaEdinica.Equals("cm") && izhodnaEdinica.Equals("mm"))
            {
                izhodnaValue = value * 10;
            }
            else if (vhodnaEdinica.Equals("cm") && izhodnaEdinica.Equals("mi"))
            {
                izhodnaValue = value * 0.00000621371192;
            }
            else if (vhodnaEdinica.Equals("cm") && izhodnaEdinica.Equals("in"))
            {
                izhodnaValue = value * 0.393700787;
            }
            else if (vhodnaEdinica.Equals("cm") && izhodnaEdinica.Equals("km"))
            {
                izhodnaValue = value * 0.00001;
            }
            else if (vhodnaEdinica.Equals("cm") && izhodnaEdinica.Equals("ft"))
            {
                izhodnaValue = value * 0.032808399;
            }
            else if (vhodnaEdinica.Equals("cm") && izhodnaEdinica.Equals("yd"))
            {
                izhodnaValue = value * 0.010936133;
            }
            else if (vhodnaEdinica.Equals("mi") && izhodnaEdinica.Equals("m"))
            {
                izhodnaValue = value / 0.000621371192;
            }
            else if (vhodnaEdinica.Equals("mi") && izhodnaEdinica.Equals("mm"))
            {
                izhodnaValue = value / 0.000000621371192;
            }
            else if (vhodnaEdinica.Equals("mi") && izhodnaEdinica.Equals("cm"))
            {
                izhodnaValue = value / 0.00000621371192;
            }
            else if (vhodnaEdinica.Equals("mi") && izhodnaEdinica.Equals("in"))
            {
                izhodnaValue = value * 39.3700787 / 0.000621371192;
            }
            else if (vhodnaEdinica.Equals("mi") && izhodnaEdinica.Equals("km"))
            {
                izhodnaValue = value / 0.621371192;
            }
            else if (vhodnaEdinica.Equals("mi") && izhodnaEdinica.Equals("ft"))
            {
                izhodnaValue = value * 3.2808399 / 0.000621371192;
            }
            else if (vhodnaEdinica.Equals("mi") && izhodnaEdinica.Equals("yd"))
            {
                izhodnaValue = value * 1.0936133 / 0.000621371192;
            }
            else if (vhodnaEdinica.Equals("in") && izhodnaEdinica.Equals("m"))
            {
                izhodnaValue = value / 39.3700787;
            }
            else if (vhodnaEdinica.Equals("in") && izhodnaEdinica.Equals("mm"))
            {
                izhodnaValue = value / 0.0393700787;
            }
            else if (vhodnaEdinica.Equals("in") && izhodnaEdinica.Equals("cm"))
            {
                izhodnaValue = value / 0.393700787;
            }
            else if (vhodnaEdinica.Equals("in") && izhodnaEdinica.Equals("mi"))
            {
                izhodnaValue = value * 0.000621371192 / 39.3700787;
            }
            else if (vhodnaEdinica.Equals("in") && izhodnaEdinica.Equals("km"))
            {
                izhodnaValue = value / 39370.0787;
            }
            else if (vhodnaEdinica.Equals("in") && izhodnaEdinica.Equals("ft"))
            {
                izhodnaValue = value * 3.2808399 / 39.3700787;
            }
            else if (vhodnaEdinica.Equals("in") && izhodnaEdinica.Equals("yd"))
            {
                izhodnaValue = value * 1.0936133 / 39.3700787;
            }
            else if (vhodnaEdinica.Equals("km") && izhodnaEdinica.Equals("m"))
            {
                izhodnaValue = value * 1000;
            }
            else if (vhodnaEdinica.Equals("km") && izhodnaEdinica.Equals("mm"))
            {
                izhodnaValue = value * 1000000;
            }
            else if (vhodnaEdinica.Equals("km") && izhodnaEdinica.Equals("cm"))
            {
                izhodnaValue = value * 100000;
            }
            else if (vhodnaEdinica.Equals("km") && izhodnaEdinica.Equals("mi"))
            {
                izhodnaValue = value * 0.621371192;
            }
            else if (vhodnaEdinica.Equals("km") && izhodnaEdinica.Equals("in"))
            {

                izhodnaValue = value * 39370.0787;
            }
            else if (vhodnaEdinica.Equals("km") && izhodnaEdinica.Equals("ft"))
            {
                izhodnaValue = value * 3280.8399;
            }
            else if (vhodnaEdinica.Equals("km") && izhodnaEdinica.Equals("yd"))
            {
                izhodnaValue = value * 1093.6133;
            }
            else if (vhodnaEdinica.Equals("ft") && izhodnaEdinica.Equals("m"))
            {
                izhodnaValue = value / 3.2808399;
            }
            else if (vhodnaEdinica.Equals("ft") && izhodnaEdinica.Equals("mm"))
            {
                izhodnaValue = value / 0.0032808399;
            }
            else if (vhodnaEdinica.Equals("ft") && izhodnaEdinica.Equals("cm"))
            {
                izhodnaValue = value / 0.032808399;
            }
            else if (vhodnaEdinica.Equals("ft") && izhodnaEdinica.Equals("mi"))
            {
                izhodnaValue = value * 0.000621371192 / 3.2808399;
            }
            else if (vhodnaEdinica.Equals("ft") && izhodnaEdinica.Equals("in"))
            {
                izhodnaValue = value * 39.3700787 / 3.2808399;
            }
            else if (vhodnaEdinica.Equals("ft") && izhodnaEdinica.Equals("km"))
            {
                izhodnaValue = value / 3280.8399;
            }
            else if (vhodnaEdinica.Equals("ft") && izhodnaEdinica.Equals("yd"))
            {
                izhodnaValue = value * 1.0936133 / 3.2808399;
            }
            else if (vhodnaEdinica.Equals("yd") && izhodnaEdinica.Equals("m"))
            {
                izhodnaValue = value / 1.0936133;
            }
            else if (vhodnaEdinica.Equals("yd") && izhodnaEdinica.Equals("mm"))
            {
                izhodnaValue = value / 0.0010936133;
            }
            else if (vhodnaEdinica.Equals("yd") && izhodnaEdinica.Equals("cm"))
            {
                izhodnaValue = value / 0.010936133;
            }
            else if (vhodnaEdinica.Equals("yd") && izhodnaEdinica.Equals("mi"))
            {
                izhodnaValue = value * 0.000621371192 / 1.0936133;
            }
            else if (vhodnaEdinica.Equals("yd") && izhodnaEdinica.Equals("in"))
            {
                izhodnaValue = value * 39.3700787 / 1.0936133;
            }
            else if (vhodnaEdinica.Equals("yd") && izhodnaEdinica.Equals("km"))
            {
                izhodnaValue = value / 1093.6133;
            }
            else if (vhodnaEdinica.Equals("yd") && izhodnaEdinica.Equals("ft"))
            {
                izhodnaValue = value * 3.2808399 / 1.0936133;
            }
            else if (vhodnaEdinica.Equals("m") && izhodnaEdinica.Equals("m"))
            {
                izhodnaValue = value;
            }
            else if (vhodnaEdinica.Equals("mm") && izhodnaEdinica.Equals("mm"))
            {
                izhodnaValue = value;
            }
            else if (vhodnaEdinica.Equals("cm") && izhodnaEdinica.Equals("cm"))
            {
                izhodnaValue = value;
            }
            else if (vhodnaEdinica.Equals("mi") && izhodnaEdinica.Equals("mi"))
            {
                izhodnaValue = value;
            }
            else if (vhodnaEdinica.Equals("in") && izhodnaEdinica.Equals("in"))
            {
                izhodnaValue = value;
            }
            else if (vhodnaEdinica.Equals("km") && izhodnaEdinica.Equals("km"))
            {
                izhodnaValue = value;
            }
            else if (vhodnaEdinica.Equals("ft") && izhodnaEdinica.Equals("ft"))
            {
                izhodnaValue = value;
            }
            else if (vhodnaEdinica.Equals("yd") && izhodnaEdinica.Equals("yd"))
            {
                izhodnaValue = value;
            }

            Console.WriteLine($"{izhodnaValue} {izhodnaEdinica}");
        }
    }
}
