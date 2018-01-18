using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Raven parent class
 */
namespace LynchS_HW12
{
    abstract class Raven
    {
        // attributes
        private int attackSkill;

        // abstract method for its attack
        public abstract bool Attack();

        // constructor
        public Raven(int attSk)
        {
            attackSkill = attSk;
        }

        // method to determine if attack worked
        protected bool IsAttackSuccessful()
        {
            // random obj for dice roll between 1 and 6
            Random rGenO = new Random();
            int diceRollAtt = rGenO.Next(1, 7);

            if(attackSkill >= diceRollAtt)
            {
                Console.WriteLine("\n\nAttack skill is greater than or equal to the rolled amount!");
                return true;
            }
            return false;
        }
    }
}
