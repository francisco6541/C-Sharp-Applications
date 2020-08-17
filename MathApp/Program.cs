/*
Class:        ISTA220 Programming Fundamentals
Student:      Francisco Velazquez
Instructor:   Christine Lee
Date:         08/01/2020
Descrption:   This application does simple addition, subtraction, multiplication, and division.
Revised:      
Revision By:  
Revision:     
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello and welcome to my math application!");
            Console.WriteLine("In this application you will choose an operator, choose two numbers, and the app will do the math and return the answer.");
            Console.WriteLine("Choose an operator:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Multiplication");
            Console.WriteLine("3) Subtraction");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Addition();
                return true;
            }
            else if (result == "2")
            {
                Multiplication();
                return true;
            }

            else if (result == "3")
            {
                Subtraction();
                return true;
            }
            else if (result == "4")
            {
                Division();
                return true;
            }
            else if (result == "5")
            {
                Exit();
                return false;
            }
            else
            {
                Console.WriteLine("Please choose a valid option.");
                Console.ReadLine();
                return true;
            }
        }

        static void Addition()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("You selected addition!");
                Console.Write("Please enter the first number: ");
                double numone = double.Parse(Console.ReadLine());
                Console.Write("Please enter the second number: ");
                double numtwo = double.Parse(Console.ReadLine());
                double sum = numone + numtwo;
                Console.WriteLine($"{numone} + {numtwo} = {sum}");
                Console.ReadLine();
            }
            catch (Exception eXp)
            {
                Console.WriteLine(eXp.Message);
                Addition();
            }
        }

        static void Multiplication()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("You selected multiplication!");
                Console.Write("Please enter the first number: ");
                double numone = double.Parse(Console.ReadLine());
                Console.Write("Please enter the second number: ");
                double numtwo = double.Parse(Console.ReadLine());
                double product = numone * numtwo;
                Console.WriteLine($"{numone} * {numtwo} = {product}");
                Console.ReadLine();
            }
            catch (Exception eXp)
            {
                Console.WriteLine(eXp.Message);
                Multiplication();
            }
        }

        static void Subtraction()
        {
            try
            {
            Console.Clear();
            Console.WriteLine("You selected subtraction!");
            Console.Write("Please enter the first number: ");
            double numone = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double numtwo = double.Parse(Console.ReadLine());
            double difference = numone - numtwo;
            Console.WriteLine($"{numone} - {numtwo} = {difference}");
            Console.ReadLine();
            }
            catch (Exception eXp)
            {
                Console.WriteLine(eXp.Message);
                Subtraction();
            }
        }

        static void Division()
        {
            try
            {
            Console.Clear();
            Console.WriteLine("You selected division!");
            Console.Write("Please enter the first number: ");
            double numone = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double numtwo = double.Parse(Console.ReadLine());
            double quotient = numone / numtwo;
            Console.WriteLine($"{numone} / {numtwo} = {quotient}");
            Console.ReadLine();
            }
            catch (DivideByZeroException dZe)
            {
                Console.WriteLine(dZe.Message);
            }
            catch (Exception eXp)
            {
                Console.WriteLine(eXp.Message);
                Division();
            }
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Are you sure?");
            Console.WriteLine("Y or N?");
            string result = Console.ReadLine();

            if (result == "Y" | result == "y")
            {
                Console.Clear();
                Console.WriteLine("Thanks for stopping by!");
            }
            else if (result == "N" | result == "n")
            {
                MainMenu();
            }
            else
            {
                Exit();
            }
        }
    }
}
