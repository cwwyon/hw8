using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    //make a class named Potion
    class Potion
    {
        //set 5 fields
        public string name;
        public string color;
        public float strength;
        public string usage;
        public int doses;

        //set parameyrerized constructor
        public Potion(string pname, string pcolor, float pstregth, string pusage, int pdoses)
        {
            name = pname;
            color = pcolor;
            strength = pstregth;
            usage = pusage;
            doses = pdoses;

        }
        //set a overloaded cobnstructor
        public Potion()
        {
            name = "Potion";
            color = "colorless";
            strength = 50;
            usage = "To cast on a person";
            doses = 10;
        }

        //set a UserPotion to make each time using the potion, doses mius 1
        public void UsePotion()
        {

            doses = doses - 1;
            Console.WriteLine("Using " + name + " potion" + "...{0} doeses left", doses);
            Console.WriteLine("");


        }
        //pring the data to user
        public void PrintPotion()
        {
            Console.WriteLine("Potion :");
            Console.WriteLine("  Name : " + name);
            Console.WriteLine("  usage : " + usage);
            Console.WriteLine("  strength :" + strength);
            Console.WriteLine("  color :" + color);
            Console.WriteLine("  Remaining doses :" + doses);
            Console.WriteLine("");
        }

    }
}
