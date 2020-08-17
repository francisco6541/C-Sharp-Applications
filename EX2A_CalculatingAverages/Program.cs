/*
Class:        ISTA 220 Programming Fundamentals
Student:      Francisco Velazquez
Instructor:   Christine Lee
Date:         07/18/2020
Descrption:   This is an application that accepts test scores and returns the average of those scores plus a letter grade.
Revised:      
Revision By:  
Revision:     
*/

using SumOfNumbers;
using AverageTenScores;
using AverageSpecificNumber;
using AverageNonSpecificNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX2A_CalculatingAverages;
using System.Threading;
using System.Net;

namespace EX2A_CalculatingAverages
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
            part1 a = new part1();
            part2 b = new part2();
            part3 c = new part3();
            part4 d = new part4();
            Console.Clear();
            Console.WriteLine("Hello Christine!");
            Console.WriteLine("This is my application for calculating averages.");
            Console.WriteLine("I had a hard time with this one but I tried my best. I hope you like it!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Sum of numbers");
            Console.WriteLine("2) Average ten scores");
            Console.WriteLine("3) Average a specific number of scores");
            Console.WriteLine("4) Average a non-specific number of scores");
            Console.WriteLine("5) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                a.firstmethod();
                return true;
            }
            else if (result == "2")
            {
                b.secondmethod();
                return true;
            }

            else if (result == "3")
            {
                c.thirdmethod();
                return true;
            }
            else if (result == "4")
            {
                d.forthmethod();
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
        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Are you sure?");
            Console.WriteLine("Y or N?");
            string result = Console.ReadLine();

            if (result == "Y")
            {
                Console.Clear();
                Console.WriteLine("Thank you! Goodbye!");
            }
            else if (result == "y")
            {
                Console.Clear();
                Console.WriteLine("Thank you! Goodbye!");
            }
            else if (result == "N")
            {
                MainMenu();
            }
            else if (result == "n")
            {
                MainMenu();
            }
            //Reference: Hayden Barnes


        }
    }
}

namespace SumOfNumbers
{
    class part1
    {
        public void firstmethod()
        {
            double sum = 0;
            int numberOfTests = 10;

            
            for (int count = 1; count <= numberOfTests; count++) // Start the count
            {
                Console.Write($"This is test score {count}. Please enter a number between 0 and 100: ");

                double testScore = 0;

                while (!double.TryParse(Console.ReadLine(), out testScore))
                {
                    Console.Write("Please enter a valid number: ");
                }

                while (testScore < 0 | testScore > 100)
                {
                    Console.Write("Please enter a valid number: ");
                    testScore = double.Parse(Console.ReadLine());
                }

                //get the total
                sum = sum + testScore;
            }

            //Calculate and display
            Console.WriteLine($"The sum of your test scores is: {sum}");
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
            //Reference: https://stackoverflow.com/questions/52548557/creating-an-average-test-score-using-the-for-loop
        }
    }
}

namespace AverageTenScores
{
    class part2
    {
        public void secondmethod()
        {
            double sum = 0;
            int numberOfTests = 10;

            for (int count = 1; count <= numberOfTests; count++) // Start the count
            {
                Console.Write($"This is test score {count}. Please enter a number between 0 and 100: ");

                double testScore = 0;

                while (!double.TryParse(Console.ReadLine(), out testScore))
                {
                    Console.Write("Please enter a valid number: ");
                }

                while (testScore < 0 | testScore > 100)
                {
                    Console.Write("Please enter a valid number: ");
                    testScore = double.Parse(Console.ReadLine());
                }

                //get the total
                sum = sum + testScore;
            }

            //Calculate and display
            double average = sum / numberOfTests;
            if (average > 90 & average < 101)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is A.");
            }
            else if (average > 80 & average < 91)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is B.");
            }
            else if (average > 70 & average < 81)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is C.");
            }
            else if (average > 60 & average < 71)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is D.");
            }
            else if (average < 61)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is E.");
            }
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
            //Reference: https://stackoverflow.com/questions/52548557/creating-an-average-test-score-using-the-for-loop
        }
    }
}

namespace AverageSpecificNumber
{
    class part3
    {
        public void thirdmethod()
        {
            double sum = 0;
            Console.Write("Please enter how many scores you want to enter: ");
            int numberOfTests = int.Parse(Console.ReadLine());

            for (int count = 1; count <= numberOfTests; count++) // Start the count
            {
                Console.Write($"This is test score {count}. Please enter a number between 0 and 100: ");

                double testScore = 0;

                while (!double.TryParse(Console.ReadLine(), out testScore))
                {
                    Console.Write("Please enter a valid number: ");
                }

                while (testScore < 0 | testScore > 100)
                {
                    Console.Write("Please enter a valid number: ");
                    testScore = double.Parse(Console.ReadLine());
                }

                //get the total
                sum = sum + testScore;
            }

            //Calculate and display
            double average = sum / numberOfTests;
            if (average > 90 & average < 101)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is A.");
            }
            else if (average > 80 & average < 91)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is B.");
            }
            else if (average > 70 & average < 81)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is C.");
            }
            else if (average > 60 & average < 71)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is D.");
            }
            else if (average < 61)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is E.");
            }
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
            //Reference: https://stackoverflow.com/questions/52548557/creating-an-average-test-score-using-the-for-loop
        }
    }
}

namespace AverageNonSpecificNumber
{
    class part4
    {
        public void forthmethod()
        {
            double sum = 0;
            int numberOfTests = 0;

            for (int count = 1; count >= numberOfTests; count++) // Start the count
            {
                Console.Write($"This is test score {count}. If you are done type d, otherwise press any key to continue: ");
                if (Console.ReadLine() is "d")
                {
                    break;
                }

                Console.Write($"Please enter a number between 0 and 100: ");

                double testScore = 0;

                while (!double.TryParse(Console.ReadLine(), out testScore))
                {
                    Console.Write("Please enter a valid number: ");
                }

                while (testScore < 0 | testScore > 100)
                {
                    Console.Write("Please enter a valid number: ");
                    testScore = double.Parse(Console.ReadLine());
                }

                //get the total
                sum = sum + testScore;
            }

            //Calculate and display
            double average = sum / numberOfTests;
            if (average > 90 & average < 101)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is A.");
            }
            else if (average > 80 & average < 91)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is B.");
            }
            else if (average > 70 & average < 81)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is C.");
            }
            else if (average > 60 & average < 71)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is D.");
            }
            else if (average < 61)
            {
                Console.WriteLine($"The average of your test scores is: {average}. Your letter grade is E.");
            }
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
            //Reference: https://stackoverflow.com/questions/52548557/creating-an-average-test-score-using-the-for-loop
        }
    }
}