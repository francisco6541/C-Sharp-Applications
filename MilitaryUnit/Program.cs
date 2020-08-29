/*
Class:        ISTA322 Developing ASP.NET Web Apps
Student:      Francisco Velazquez
Instructor:   Christine Lee
Date:         08/29/2020
Descrption:   This program makes use of inheritence and abstraction to show the details of a military unit and their mission.
Revised:      
Revision By:  
Revision:     
*/

using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Runtime.CompilerServices;

namespace MilitaryUnit
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Military Unit project!");
            Console.ReadKey();
            Console.WriteLine("This project makes use of inheritence and abstraction.");
            Console.ReadKey();
            Console.WriteLine("The following details are classified. Do you possess the right clearance?");
            Console.Write("Please enter y for yes or n for no: ");
            string clearance = Console.ReadLine();
            if (clearance == "y" | clearance == "Y")
            {
                Console.Clear();
                Console.WriteLine("Good stuff! Behold the details of my military unit and their mission!");
                Console.ReadKey();
                try
                {
                    Unit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                }
                finally
                {
                    Console.Clear();
                    Console.WriteLine("Soooo... What did you think?");
                    Console.ReadKey();
                    Console.WriteLine("Pretty Cool huh?");
                    Console.ReadKey();
                    Console.WriteLine("Planned it all out myself!");
                    Console.ReadKey();
                    Console.WriteLine("Well thank you for looking at my mission details.");
                    Console.ReadKey();
                    Console.WriteLine("Now go and don't tell anybody. \nGoodbye!");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
            if (clearance == "n" | clearance == "N")
            {
                Console.Clear();
                Console.WriteLine("Well at least you were honest.");
                Console.ReadKey();
                Console.WriteLine("Come back when you have the right clearance.");
                Console.ReadKey();
                Environment.Exit(1);
            }
            else if (clearance != "y" | clearance != "Y" | clearance != "n" | clearance != "N")
            {
                Console.Clear();
                Console.WriteLine("AH HA!");
                Console.ReadKey();
                Console.WriteLine("Trying to pull a fast one on me huh!?");
                Console.ReadKey();
                Console.WriteLine("Not today user!");
                Console.ReadKey();
                Console.WriteLine("Now get lost!");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }

        public static void Unit()
        {
            Console.Clear();
            Norway mission = new Norway()
            {
                country = "Norway",
                numberofvic = 3,
                peoplepervic = 2,
                currentseason = "Winter"

            };

            Humvee vehicle = new Humvee()
            {
                vehicletype = "Humvee",
                passengercapacity = 4,
                armorlevel = "Heavily Armored",
            };

            M16 m16 = new M16()
            {
                weapon = "It's that good old M16",
                mags = 6,
                roundspermag = 30
            };
            mission.MissionDetails();
            Console.WriteLine();
            vehicle.VehicleDetails();
            Console.WriteLine();
            m16.WeaponDetails();
            Console.ReadKey();

        }
    }
}
