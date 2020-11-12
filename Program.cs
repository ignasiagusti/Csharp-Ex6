using System;

namespace CsharpEx6
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineGun mg = new MachineGun();
            Bazooka bz = new Bazooka();
            Pistol ps = new Pistol();

            Soldier soldier1 = new Soldier(mg);
            soldier1.Shoot("ninja");
            soldier1.changeGun(bz);
            soldier1.Shoot("ninja");
            soldier1.changeGun(ps);
            soldier1.Shoot("ninja");

            MachineGun mg2 = new MachineGun();
            Bazooka bz2 = new Bazooka();
            Pistol ps2 = new Pistol();

            Tank tank1 = new Tank(mg);
            tank1.Shoot("soldiers");
            tank1.changeGun(bz);
            tank1.Shoot("soldiers");
            tank1.changeGun(ps);
            tank1.Shoot("soldiers");

        }
    }
}
