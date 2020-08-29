using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    public class Vehicle
    {
        public string vehicletype { get; set; }
        public int passengercapacity { get; set; }

        public virtual void VehicleDetails()
        {
            Console.WriteLine($"Vehicle Type: {vehicletype} \nPassenger Capacity: {passengercapacity}");
            Console.Write("Vehicle Temperature: ");
            VehicleTemp();
        }

        public virtual void VehicleTemp()
        {
            Console.WriteLine("It's nice and toasty.");
        }
    }
}

