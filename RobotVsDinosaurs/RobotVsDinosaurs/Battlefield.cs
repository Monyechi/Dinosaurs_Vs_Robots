using System;
using System.Collections.Generic;
using System.Text;

namespace RobotVsDinosaurs
{
    class BattleField
    {
        //member variables (Has A)
        Fleet fleet;
        Herd herd;
        public string Jungle;
        public string Urban;
        public string Rural;
        //constructor (spawner)
        public BattleField()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        //memeber methods (Can Do)

        public void RunBattle()
        {
            while((fleet.robot1.Health > 0 && fleet.robot2.Health > 0 && fleet.robot3.Health > 0) && (herd.dinosaur1.Health > 0 && herd.dinosaur2.Health > 0 && herd.dinosaur3.Health > 0))
            {
                herd.dinosaur1.Health -= fleet.robot1.weapon.AttackPower;
                herd.dinosaur2.Health -= fleet.robot2.weapon.AttackPower;
                herd.dinosaur3.Health -= fleet.robot3.weapon.AttackPower;
            }

            if (herd.dinosaur1.Health + herd.dinosaur2.Health + herd.dinosaur3.Health > fleet.robot1.Health + fleet.robot2.Health + fleet.robot3.Health) 
            {
                Console.WriteLine("All Robots are dead! Dinosaurs win!");
            }
            else if (fleet.robot1.Health + fleet.robot2.Health + fleet.robot3.Health > herd.dinosaur1.Health + herd.dinosaur2.Health + herd.dinosaur3.Health)
            {
                Console.WriteLine("All Dinosaurs are dead! Robots win!");
            }
            // if gets to here, means one team has died, display winner
        }
    }
}
