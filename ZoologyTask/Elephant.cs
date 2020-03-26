using System;
using System.Collections.Generic;
using System.Text;

namespace ZoologyTask
{
    public class Elephant : ISpecies,IBodyCharacteristics,IDiet,IReproduction,IDomestication
    {
       public void African()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("African Elephants");
            Console.WriteLine("-Found in 38 countries of Africa.");
            Console.WriteLine("-They stand upto 4m and weigh around 7000kg");
        }

       public void Asian()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Asian Elephants");
            Console.WriteLine("They are 3.4m tall and weigh 5400kg");
        }

        public void Trunk()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Body Characteristics");
            Console.WriteLine("1.Trunk");
            Console.WriteLine("-It is used to tear up their food and then place it in their mouth");
        }

        public void Tusk()
        {
            Console.WriteLine("2.Tusk");
            Console.WriteLine("-It is Used to dig for water, salt, and roots.");
            Console.WriteLine("-Also used to debark trees,to eat the bark," +
                " to dig into baobab trees to get at the pulp inside.");
            Console.WriteLine("-And used to move trees and branches when clearing a path.");
        }

        public void Teeth()
        {
            Console.WriteLine("3.Teeth");
            Console.WriteLine("-They usually have 28 teeths.");
        }

        public void Skin()
        {
            Console.WriteLine("4.Skin");
            Console.WriteLine("-It is extremely tough around most parts of its body and measures about" +
                " 2.5 cm (1 in) thick.");
        }

        public void Legs()
        {
            Console.WriteLine("5.Legs");
            Console.WriteLine("They are great straight pillars, as they must be to support its bulk weight.");
        }

        public void Ears()
        {
            Console.WriteLine("6.Ears");
            Console.WriteLine(" Elephant ears are made of a very thin layer of skin stretched over " +
                "cartilage and a rich network of blood vessels.");
        }

        public void Herbivores()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Diet");
            Console.WriteLine("-Elephants are herbivores, spending 16 hours a day collecting plant food.");
        }

        public void Interval()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Reproduction");
            Console.WriteLine("-Females give birth at intervals of about every 5 years. ");
        }

        public void Weight()
        {
            Console.WriteLine("-At birth, calves weigh around 90–115 kg. ");
        }

        public void Use()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Dometication");
            Console.WriteLine("-Elephants have been working animals used in various capacities by humans.");
            Console.WriteLine("-------------------------------------------------------------------------------");
        }
    }
}
