//Class:      ISTA 220 Programming Fundamentals
//Student:    Francisco Velazquez
//Instructor: Christine E Lee, Instructor
//Date:       07/22/2020

/*********************************************************

This project has one method that asks for the users name and another method that calculates the area of a rectangle.

Revisions:


Revision Date:


Revised By:


********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWorkPT2_FranciscoVelazquez07222020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! What is you first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Hello {firstName}! What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine($"So your name is {firstName} {lastName}. That's a nice name!");
            Console.ReadLine();
            Program p = new Program();
            p.secondMethod();
        }
        public void secondMethod()
        {
            Console.Write("Please input width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Please input length: ");
            int length = int.Parse(Console.ReadLine());
            double area = width * length;
            Console.WriteLine($"The area of your rectangle is {area}");
            Console.ReadLine();
        }
    }
}
