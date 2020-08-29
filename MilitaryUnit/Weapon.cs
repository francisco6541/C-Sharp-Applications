using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MilitaryUnit
{
    class Weapon
    {
        public string weapon { get; set; }
        public int mags { get; set; }
        public int roundspermag { get; set; }

        public void WeaponDetails()
        {
            Console.WriteLine($"Weapon: {weapon}  \nMag Count: {mags}\n" +
                $"Rounds Per Mag: {roundspermag}");
            Console.Write("Weapon Inspection: ");
            WeaponInspection();
        }

        public virtual void WeaponInspection()
        {
            Console.WriteLine("You passed your weapon inspection.");
        }
    }
}
