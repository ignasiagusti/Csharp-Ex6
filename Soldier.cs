using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEx6
{
    class Soldier
    {
        IWeapon weapon;
        public Soldier(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Shoot(string objective)
        {
            Console.WriteLine("Soldier shooting...");
            this.weapon.fire(objective);
        }

        public void changeGun(IWeapon weapon)
        {
            this.weapon = weapon;
        }
    }
}
