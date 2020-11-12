using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEx6
{
    class Tank
    {
        IWeapon weapon;
        public Tank(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Shoot(string objective)
        {
            Console.WriteLine("Tank shooting...");
            this.weapon.fire(objective);
        }

        public void changeGun(IWeapon weapon)
        {
            this.weapon = weapon;
        }
    }
}
