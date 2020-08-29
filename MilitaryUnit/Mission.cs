using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Mission
    {
        public string country { get; set; }
        public int numberofvic { get; set; }
        public int peoplepervic { get; set; }

        public virtual void MissionDetails()
        {
            Console.WriteLine($"Mission Location: {country} \nNumber Of Vehicles: {numberofvic} \nPeople Per Vehicle: {peoplepervic}");
            Console.WriteLine("Mission Objective: ");
            MissionObective();
        }

        public virtual void MissionObective()
        {
            Console.WriteLine("This is classified information. Do you have the right clearance for this?");
        }
    }
}
