using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFormulasRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("Hello Christine! Lets get started with some math!");
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");
            double area = Math.PI * Math.Pow(intradius, 2);
            Console.WriteLine($"The area is {area}");

            //Part 2
            Console.WriteLine("Part 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            string strradius2 = Console.ReadLine();
            int intradius2 = int.Parse(strradius2);
            double volume = (1.3333333333 * Math.PI * Math.Pow(intradius2, 3)) / 2;
            Console.WriteLine($"The volume is {volume}");

            //Part 3
            Console.WriteLine("Part 3, area of a triangle (Heron's formula).");
            Console.Write("Enter an integer for side a: ");
            string strsidea = Console.ReadLine();
            int intsidea = int.Parse(strsidea);
            Console.Write("Enter an integer for side b: ");
            string strsideb = Console.ReadLine();
            int intsideb = int.Parse(strsideb);
            Console.Write("Enter an integer for side c: ");
            string strsidec = Console.ReadLine();
            int intsidec = int.Parse(strsidec);
            double semiperimeter = (intsidea + intsideb + intsidec) / 2.0;
            double area2 = Math.Sqrt(semiperimeter * (semiperimeter - intsidea) * (semiperimeter - intsideb) * (semiperimeter - intsidec));
            Console.WriteLine($"The area is {area2}");

            //Part 4
            Console.WriteLine("Part 4, solving a quadratic equation.");
            Console.Write("Enter an integer for a: ");
            string stra = Console.ReadLine();
            int a = int.Parse(stra);
            Console.Write("Enter an integer for b: ");
            string strb = Console.ReadLine();
            int b = int.Parse(strb);
            Console.Write("Enter an integer for c: ");
            string strc = Console.ReadLine();
            int c = int.Parse(strc);
            double sqrtpart = Math.Sqrt((b * b) - (4 * a * c));
            double x1 = (-b + sqrtpart) / (2 * a);
            double x2 = (-b - sqrtpart) / (2 * a);
            Console.WriteLine($"The positive solution is {x1}");
            Console.WriteLine($"The negative solution is {x2}");
            Console.WriteLine("That was quite the jump from Hello World! but I hope you enjoyed my first little program!");
        }
    }
}
