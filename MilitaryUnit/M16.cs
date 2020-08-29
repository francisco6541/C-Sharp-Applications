using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class M16 : Weapon
    {
        public override void WeaponInspection()
        {
            Console.WriteLine("Where's your RCO!?");
        }
    }
}
