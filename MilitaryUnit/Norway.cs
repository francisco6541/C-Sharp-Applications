using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MilitaryUnit
{
    class Norway : Mission
    {
        public string currentseason { get; set; }

        public override void MissionDetails()
        {
            Console.WriteLine($"Mission Location: {country} \nNumber Of Vehicles: {numberofvic} \nPeople Per Vehicle: {peoplepervic} \nCurrent Season: {currentseason}");
            Console.WriteLine("Mission Objective: ");
            MissionObective();
        }

        public override void MissionObective()
        {
            Console.WriteLine("Scout the area for the Marines who were too drunk to make it back.");
        }
    }
}
