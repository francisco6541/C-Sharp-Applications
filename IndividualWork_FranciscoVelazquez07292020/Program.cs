/*
Class:        ISTA220 Programming Fundamentals
Student:      Francisco Velazquez
Instructor:   Christine Lee
Date:         07/29/2020
Descrption:   This application asks you for a number from 1 to 7 that is in line with your favorite day of the week. It performs this function either with if else statememts or with a switch.
Revised:      
Revision By:  
Revision:     
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork_07292020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Christine!");
            Console.WriteLine("There are 2 methods to this app. Please 1 for method one and 2 for method two");
            int method = 0;
            while (!int.TryParse(Console.ReadLine(), out method))
            {
                Console.Write("Please enter a number: ");
            }
            while(method < 1 | method > 2)
            {
                Console.WriteLine("Please enter 1 for method one or 2 for method 2");
                Console.ReadLine();
            }
            if (method is 1)
            {
                Console.WriteLine("You have chosen method one!");
            }
            else if (method is 2)
            {
                Console.WriteLine("You have chosen method two!");
                Program p = new Program();
                p.methodtwo();
            }

            //Method one: Favorite day using if else statements
            Console.WriteLine("Please input a number from 1 to 7 that will represent your favorite day of the week.");
            int weekday = 0;
            while (!int.TryParse(Console.ReadLine(), out weekday))
            {
                Console.Write("Please enter a number: ");
            }
            while (weekday < 1 | weekday > 7)
            {
                Console.WriteLine("Please enter number between 1 and 7");
                Console.ReadLine();
            }
            if (weekday is 1)
            {
                Console.WriteLine("Your favorite day is Sunday!");
            }
            else if (weekday is 2)
            {
                Console.WriteLine("Your favorite day is Monday!");
            }
            else if (weekday is 3)
            {
                Console.WriteLine("Your favorite day is Tuesday!");
            }
            else if (weekday is 4)
            {
                Console.WriteLine("Your favorite day is Wednesday!");
            }
            else if (weekday is 5)
            {
                Console.WriteLine("Your favorite day is Thursday!");
            }
            else if (weekday is 6)
            {
                Console.WriteLine("Your favorite day is Friday!");
            }
            else if (weekday is 7)
            {
                Console.WriteLine("Your favorite day is Saturday!");
            }
        }

        public void methodtwo()
        {
            //Method two: Favorite day using switch statement
            Console.WriteLine("Please input a number from 1 to 7 that will represent your favorite day of the week.");
            int Weekday = 0;
            while (!int.TryParse(Console.ReadLine(), out Weekday))
            {
                Console.Write("Please enter a number: ");
            }
            while (Weekday < 1 | Weekday > 7)
            {
                Console.WriteLine("Please enter number between 1 and 7");
                Console.ReadLine();
            }
            switch (Weekday)
            {
                case 1:
                    Console.WriteLine("Your favorite day is Sunday!");
                    break;
                case 2:
                    Console.WriteLine("Your favorite day is Monday!");
                    break;
                case 3:
                    Console.WriteLine("Your favorite day is Tuesday!");
                    break;
                case 4:
                    Console.WriteLine("Your favorite day is Wednesday!");
                    break;
                case 5:
                    Console.WriteLine("Your favorite day is Thursday!");
                    break;
                case 6:
                    Console.WriteLine("Your favorite day is Friday!");
                    break;
                case 7:
                    Console.WriteLine("Your favorite day is Saturday!");
                    break;
                default:
                    Console.WriteLine("You didn't choose a day! =(");
                    break;
            }
            Environment.Exit(0);
        }
    }
}
