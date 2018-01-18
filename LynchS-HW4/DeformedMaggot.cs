using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Class for animal created (deformed maggot in this case)
 * Maggot attributes are here and method to greet player at door
 */
namespace LynchS_HW12
{
    class DeformedMaggot
    {
        // attributes
        public int magLegs;
        public int magEyes;
        public int magWrinkles;
        public string magColor;
        public int magHealth;

        // default constructor
        public DeformedMaggot()
        {
            magLegs = 0;
            magEyes = 1;
            magWrinkles = 600;
            magColor = "white";
            magHealth = 150;
        }

        // parameterized constructor
        //public DeformedMaggot(int mLegs, int mEyes, int mWrinkles, string mColor, int mHealth)
        //{
        //   magLegs = mLegs;
        //    magEyes = mEyes;
        //    magWrinkles = mWrinkles;
        //    magColor = mColor;
        //    magHealth = mHealth;
        //}

        // description of animal you're seeing
        public void AnimalDesc()
        {
            Console.WriteLine("\nAs you start to contemplate why you're here exactly, you notice a pair of deformed maggots crawling towards you."
                + "\nOh my goodness, they're huge!! One of them is somewhat normal looking (despite its size), while the other is quite unusual.");
        }
    }
}
