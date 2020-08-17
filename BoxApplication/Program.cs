//Box application C# classes
//Instructor: Christine Lee
//2020

using System;

namespace BoxApplication
{
    class Box
    {
        //Member functions and Encapsulation

        public double length;
        public double breadth;
        public double height;

        public void setlength(double len) {
            length = len;
        }

        public void setbreadth(double bre)
        {
            breadth = bre;
        }

        public void setheight(double hei)
        {
            height = hei;
        }

        public double getVolume()
        {
            //do the math
            return length * breadth * height;
        }
    }

    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box(); //Declares Box1 of type Box
            Box Box2 = new Box(); //Declares Box2 of type Box
            double volume = 0.0;

            //declare box 1 of type box
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            //declare box 2 of type box
            Box2.height = 11.0;
            Box2.length = 2.0;
            Box2.breadth = 3.0;

            //volume of box 1
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Volume of Box1 : {0}", volume);

            //volume of box 2
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Volume of Box2 : {0}", volume);
            Console.ReadKey();
        }
    }
}
