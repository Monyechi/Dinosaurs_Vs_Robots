using System;
using System.Collections.Generic;
using System.Text;

namespace RobotVsDinosaurs
{
    class Weapon
    {
        //member variables (Has A)
        public string Name;
        public string Type;
        public int AttackPower;
        public int NumberOfRounds;

        //constructor (spawner)
        public Weapon(string name, string type, int attackPower)
        {
            this.Name = name;
            this.Type = type;
            this.AttackPower = attackPower;
            //Weapon machineGun = new Weapon();
            //machineGun.Name = "Machine Gun";
            //machineGun.Type = "Gun";
            //machineGun.AttackPower = 30;
            //machineGun.NumberOfRounds = 15;

            //Weapon Bazooka = new Weapon();
            //Bazooka.Name = "Bazooka";
            //Bazooka.Type = "RPG";
            //Bazooka.AttackPower = 50;
            //Bazooka.NumberOfRounds = 3;

            //Weapon LaserGun = new Weapon();
            //LaserGun.Name = "Laser Gun";
            //LaserGun.Type = "Gun";
            //LaserGun.AttackPower = 75;
            //LaserGun.NumberOfRounds = 15;

        }
       

        //memeber methods (Can Do)
    }
}
