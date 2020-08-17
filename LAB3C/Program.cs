/*
Class:        ISTA220 Programming Fundamentals
Student:      Francisco Velazquez
Instructor:   Christine Lee
Date:         07/31/2020
Descrption:   The is application contains 3 programs. One that provides tuition cost over 5 years, one that converts feet to inches, and one that will return the greater number of two.
Revised:      
Revision By:  
Revision:     
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3C
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
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1) Tuition over 5 years");
            Console.WriteLine("2) Foot to inch conversion");
            Console.WriteLine("3) Greater number");
            Console.WriteLine("4) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                tuition();
                return true;
            }
            else if (result == "2")
            {
                conversion();
                return true;
            }
            else if (result == "3")
            {
                greater();
                return true;
            }
            else if (result == "4")
            {
                Exit();
                return false;
            }
            else
            {
                Console.WriteLine("Please choose a valid option!");
                Console.ReadLine();
                return true;
            }
        }

        static void tuition()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my tuition over 5 years program.");
            Console.WriteLine("In this program I will outline how much your tuition increases over 5 years.");
            Console.WriteLine("You tuition begins at $6000 and increases by 2% every year for 5 years.");
            double tuition = 6000;
            int count = 5;
            for (int year = 1; year <= count; year++)
            {
                Console.WriteLine($"For year {year} your tuition will be {tuition}.");
                tuition = tuition + (tuition * .02);
            }
            Console.ReadLine();
        }

        static void conversion()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Welcome to my foot to inch conversion program.");
                Console.WriteLine("In this program you will input how many feet you want to convert and the program will convert it to inches.");
                Console.WriteLine("How many feet do you want to convert?");
                double feet = double.Parse(Console.ReadLine());
                double inches = feet * 12;
                Console.WriteLine($"{feet} feet is {inches} inches.");
                Console.ReadLine();
            }
            catch (Exception eXp)
            {
                Console.WriteLine(eXp.Message);
                Console.ReadLine();
                conversion();
            }
        }

        static void greater()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Welcome to my greater number program.");
                Console.WriteLine("In this program you will input two numbers and the program will let you know which number is greater.");
                Console.Write("Please input the first number: ");
                double numone = double.Parse(Console.ReadLine());
                Console.Write("PLease input the second number: ");
                double numtwo = double.Parse(Console.ReadLine());
                if (numone > numtwo)
                {
                    Console.WriteLine($"{numone} is greater than {numtwo}.");
                }
                else if (numtwo > numone)
                {
                    Console.WriteLine($"{numtwo} is greater than {numone}.");
                }
                else if (numone == numtwo | numtwo == numone)
                {
                    Console.WriteLine($"{numone} is equal to {numtwo}.");
                }
                Console.ReadLine();
            }
            catch (Exception eXp)
            {
                Console.WriteLine(eXp.Message);
                Console.ReadLine();
                greater();
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
                Console.WriteLine("Thank you! Goodbye!");
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
