using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //methods
                //classes
                //for, foreach
                //do, loops
                //arrays - linq
                //error handling try..catch
                //increement your indexes and 0 based


                /*//Trivia about Arrays
                //In C# index arrays start with a 0.
                //Languages that are not 0 based include:
                //Fortran, FoxPro, Julia, Smalltalk
                */
                //--------------------------------------------

                //Declare our first array this array is:
                //int[] evenNums; //integer array
                //string[] cities;

                //int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };

                string[] cities = new string[3] { "Fayetteville", "Broadway", "Sanford" };
                Array.Sort(cities);
                Console.WriteLine(cities[0]);
                Console.WriteLine(cities[1]);
                Console.WriteLine(cities[2]);
                Console.ReadLine();
                //Array.Sort - sorts the arrays in order. It will show the ones in order and ignore what you chose.
                //Array.Reverse - It will draw the numbers from the end instead of the front.

                //int[] evenNums = new int[5];
                //evenNums[0] = 10;
                //evenNums[1] = 50;
                //evenNums[4] = 84; //what is the error here?

                //Console.WriteLine(evenNums[0]);
                //Console.WriteLine(evenNums[1]);
                //Console.WriteLine(evenNums[4]);
                //Console.ReadLine();

                //string[] Consoles = new string[4];
                //Consoles[0] = "Playstation ";
                //Consoles[1] = "is better than ";
                //Consoles[2] = "Xbox. ";
                //Consoles[3] = "Don't @ me.";
                //Console.Write(Consoles[0]);
                //Console.Write(Consoles[1]);
                //Console.Write(Consoles[2]);
                //Console.Write(Consoles[3]);
                //Console.ReadLine();

                //---------------For and Foreach------------------//
                //int[] evenNums = { 2, 4, 6, 8, 10 };
                //for (int i = 0; i < evenNums.Length; i++)
                //    Console.WriteLine(evenNums[i]);
                //Console.ReadLine();

                //int[] evenNums = { 2, 4, 6, 8, 10 };
                //string[] cities = { "Rochester", "Broadway", "Fayetteville" };

                //foreach (var item in evenNums)
                //    Console.WriteLine(item);

                //foreach (var city in cities)
                //    Console.WriteLine(city);
                //Console.ReadLine();

                //string[] cars = { "Porsche", "Volkswagen", "Audi" };
                //foreach (var FavCars in cars)
                //    Console.WriteLine(FavCars);
                //Console.ReadLine();
            }
            catch(Exception eXp)
            {
                Console.WriteLine(eXp.Message);
            }
        }
    }
}
