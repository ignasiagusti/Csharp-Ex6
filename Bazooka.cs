using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEx6
{
    class Bazooka : IWeapon
    {
        public void fire(string objective)
        {
            Console.WriteLine("You've shot {0} with the Bazooka", objective);
        }
    }
}
