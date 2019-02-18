//cheng wenwen
//Pe7: make class for Potion
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // make a Potion  object "myCustomPotion"
            Potion myCustomPotion;
            myCustomPotion = new Potion("Cooo", "red", 60, "runfast", 8);
            Potion defaultPotion = new Potion();
            // print data out
            myCustomPotion.PrintPotion();
            defaultPotion.PrintPotion();
            //use the Potion and Print ut out
            myCustomPotion.UsePotion();
            myCustomPotion.PrintPotion();

        }
    }
}