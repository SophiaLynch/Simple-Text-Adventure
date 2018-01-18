using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Child class of Raven
 */
namespace LynchS_HW12
{
    class ZombieRaven : Raven
    {
        // attributes
        const int SKILL_LEVEL = 5;

        // constructor
        public ZombieRaven() : base(SKILL_LEVEL)
        {
        }

        // implement attack
        public override bool Attack()
        {
            Console.WriteLine("\n The zombie raven is quite terrifying, and oh gosh it smells awful!!!");

            if(IsAttackSuccessful())
            {
                Console.WriteLine("Oh no!! The zombie raven attacked you!! Yikes!");
                return true;
            }
            else
            {
                Console.WriteLine("Yeehaw, the zombie raven missed! What an idiot.");
                return false;
            }
        }
    }
}
