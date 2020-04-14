using System;
using System.Collections.Generic;
using System.Text;

namespace RobotVsDinosaurs
{
    class Simulation
    {
        public void Run()
        {
            
            string NumberOfFleets;
            string MyWeapon;
            string MyHerds;            
            string MyLocation;

            Console.WriteLine("Welcome to the Robots vs Dinosaurs game!");
            Console.WriteLine("");
            Console.WriteLine("Please select number of Robot fleets");
            NumberOfFleets = Console.ReadLine();

            Console.WriteLine("Please select the Robot's weapon: ");
            Console.WriteLine("1) Machine Gun");
            Console.WriteLine("2) Bazooka");
            Console.WriteLine("3) Laser Gun");
            MyWeapon = Console.ReadLine();
            if (MyWeapon == "1")
            {
                MyWeapon = "Machine Gun";
            }
            else if (MyWeapon == "2")
            {
                MyWeapon = "Bazooka";
            }
            else if (MyWeapon == "3")
            {
                MyWeapon = "Laser Gun";
            }

            Console.WriteLine("Please select number of Dinosaur herds");
            MyHerds = Console.ReadLine();

            Console.WriteLine("Please enter your battlefield location");
            Console.WriteLine("1) Jupiter");
            Console.WriteLine("2) Earth");
            Console.WriteLine("3) Mars");
            MyLocation = Console.ReadLine();
            if (MyLocation == "1") 
            {
                MyLocation = "Jupiter";
            }
            else if (MyLocation == "2")
            {
                MyLocation = "Earth";
            }
            else if (MyLocation == "3")
            {
                MyLocation = "Mars";
            }
            Console.WriteLine("Your battle will take place on " + MyLocation);
            Console.WriteLine(NumberOfFleets + " Robot Fleets VS " + MyHerds + " Dinosaur Herds");


        }

    }
}
