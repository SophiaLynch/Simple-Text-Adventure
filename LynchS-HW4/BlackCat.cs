using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * BlackCat animal class. Inherits from IEdible
 */
namespace LynchS_HW12
{
    class BlackCat : IEdible
    {
        // attributes
        private int numChunks = 3;
        //private bool isConsumed = false;

        // use numchunks. takes 3 bites to finish the meal
        public void Bite()
        {
            Console.WriteLine("You decide to eat the black cat and take a bite.");

            // if statement with taking a bite, and seeing if the meal is finished
            if(numChunks >= 0)
            {
                Console.WriteLine("You take another bite of the black cat. This thing is a full on meal!");
                //isConsumed = false;
                numChunks--;
            }
            if(numChunks == 0)
            {
                Console.WriteLine("You have finished eating the cat. That certainly was...strange. I'm uncomfortable.");
                //isConsumed = true;
            }
        }

        // method returns if animal is consumed or not
        public bool IsConsumed()
        {
            if(numChunks > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
