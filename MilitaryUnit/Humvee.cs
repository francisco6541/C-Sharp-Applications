using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Humvee : Vehicle
    {
        public string armorlevel { get; set; }

        public override void VehicleDetails()
        {
            Console.WriteLine($"Vehicle Type: {vehicletype} \nPassenger Capacity: {passengercapacity} \nArmor Level: {armorlevel}");
            Console.Write("Vehicle Temperature: ");
            VehicleTemp();
        }

        public override void VehicleTemp()
        {
            Console.WriteLine("It's overheating!");
        }
    }
}
