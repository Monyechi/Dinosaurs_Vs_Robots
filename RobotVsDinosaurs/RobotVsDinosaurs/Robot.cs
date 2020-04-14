using System;
using System.Collections.Generic;
using System.Text;

namespace RobotVsDinosaurs
{
    class Robot
    {
        //member variables (Has A)        
        public int Health;
        public int PowerLevel;
        public int AttackPower;
        public Weapon weapon;
        //constructor (spawner)
        public Robot()
        {           
            Health = 100;
            PowerLevel = 100;
            AttackPower = 50;
            weapon = new Weapon("Machine Gun", "Gun", 35);

        }
        //memeber methods (Can Do)
    }
}
