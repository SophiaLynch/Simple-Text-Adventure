using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Child class of raven
 */
namespace LynchS_HW12
{
    class MeanRaven : Raven
    {
        // attributes
        const int SKILL_LEVEL = 2;

        // constructor
        public MeanRaven() : base(SKILL_LEVEL)
        {
        }

        // implement attack
        public override bool Attack()
        {
            Console.WriteLine("The mean raven looks pretty mean, but not especially intimidating. What a rude dude!");

            if (IsAttackSuccessful())
            {
                Console.WriteLine("Oh no!! The mean raven attacked you!! That's not actually that spooky");
                return true;
            }
            else
            {
                Console.WriteLine("Yeehaw, the mean raven missed! What an idiot.");
                return false;
            }
        }
    }
}
