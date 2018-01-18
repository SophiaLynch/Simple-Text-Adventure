using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Locust animal class. Inherits from IEdible
 */
namespace LynchS_HW12
{
    class Locust : IEdible
    {
        // attributes
        private bool isConsumed = false;

        // try to eat create. takes multiple times
        public void Bite()
        {
            Console.WriteLine("You have decided to eat the locust!");
            // if statement responds to value of isconsumed
            if(isConsumed == false)
            {
                Console.WriteLine("You're still eating the locust.");
            }
            if(isConsumed == true)
            {
                Console.WriteLine("You have finished eating the locust.");
            }
        }

        // method returns if animal is consumed or not
        public bool IsConsumed()
        {
            return isConsumed;
        }
    }
}
