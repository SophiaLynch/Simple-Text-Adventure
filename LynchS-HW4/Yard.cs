using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Class for everything taking place in the yard
 * User moves a certain amount of steps to get to the front door
 * User randomly rolls to see if they can open the door, or if they die.
 */
namespace LynchS_HW12
{
    class Yard
    {
        // User must decide how many steps to move.
        // When they go to the house, find out door is locked.
        // Roll to either die or open door

        

        // attributes
        public bool liveOrDie;


        // method to get to the front door
        public void ExploreYard(string playerName)
        {
            // create const value for number of steps to get to house
            const int stepsToHouse = 37;

            // ask the user for how many steps they want to move
            Console.WriteLine("\nYou wake up on a strange hill...unsure of where you are. You see a house in the gulley that looks old and seems to be falling apart."
                + " Surrounding the house is a yard full of dead plants, and various sticky substances that are a dark brown substance."
                + " \nYou decide to start walking towards the house.");
            Console.Write("How many steps would you like to move? ");
            string playerStepsHouseStr = Console.ReadLine();

            // convert their answer to an integer
            int playerStepsHouseInt;
            bool parsedStepsHouse = int.TryParse(playerStepsHouseStr, out playerStepsHouseInt);

            // check to see if they have the correct amount of steps
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nYou have chosen to walk " + playerStepsHouseInt + " steps. ");

            // attribute for many steps left to the house
            int stepsHouseLeft = stepsToHouse - playerStepsHouseInt;


            Console.ForegroundColor = ConsoleColor.Red;

            // for loop for getting to the front steps. when the player doesn't enter in enough steps.
            for (int i = stepsHouseLeft; i > 0; i = stepsHouseLeft)
            {
                Console.WriteLine("\nYou didn't walk quite far enough to make it to the house. While approaching, however, you noticed the dead flowerbed and lamented about how they were about as lively as your future.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nYou still need to walk " + stepsHouseLeft + " steps.\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEnter in a new amount of steps to walk: ");
                playerStepsHouseStr = Console.ReadLine();
                parsedStepsHouse = int.TryParse(playerStepsHouseStr, out playerStepsHouseInt);
                stepsHouseLeft = stepsHouseLeft - playerStepsHouseInt;
            }

            if (stepsToHouse < playerStepsHouseInt)
            {
                Console.WriteLine("Woahhhh, there. You walked a little too far past the house. You might want to take a step back. "
                    + "In fact, you may want to take " + stepsHouseLeft + " steps back. No matter; you get close to the house regardless.");
                Console.WriteLine("\nYou make it to the front door of the house and instantly regret waking up in the first place...");
            }
            if (stepsToHouse == playerStepsHouseInt)
            {
                Console.WriteLine("\nYou walk 37 steps to the house and land straight at the front door. Should you really enter? Doesn't it seem dangerous? "
                    + "Is all of that fowl smelling, dark brown substance dried up blood? You think to yourself that that's a ridiculous notion. "
                    + "It's probably some nice, delicious chocolate. Hey, who knows! This could be an abandoned chocolate factory!");
            }
            if (parsedStepsHouse == false)
            {
                Console.WriteLine("\nThat's not a valid integer value, geeze. Why can't you just do as you're told?! No matter. I suppose we'll just take you to the front door step regardless. "
                    + "You're too incompetent to do something simple.");
                Console.WriteLine("\nYou magically appear at the front door. There. Are you happy?");
            }


        }

        // call on Setup class
        Setup setObj = new Setup();

        // method to open front door
        public void FrontDoor(string firstName)
        {
            // create a string constant with 8 colors
            const string myColors = "blood red,gray,black,red,ash,charcoal,soot,rainbow";

            // ask user for lastname
            Console.WriteLine("Now, pitiful player...tell me your last name?");
            string lastName = Console.ReadLine();

            // set full name
            setObj.SetCharacterName(firstName + " " + lastName);

            // local attribute for character name
            string plName = setObj.GetCharacterName();

            // add a note to the front of the door that tells the player they need a key
            string doorKeyNote = plName + ", there is a hidden key to open this door. Look around...but it may be best if you just don't.";
            Console.WriteLine("You decide it's about time to try and open the door. You made it all the way here, so you might as well try...right? Upon closer examination, however, the door appears to be locked."
                + " As you try to turn the handle once more, you finally notice a small note taped to the keyhole. \nIt reads: " + doorKeyNote);

            Setup diceCreation = new Setup();
            int diceRoll1 = diceCreation.ThrowDie(4, 6);
            int diceRoll2 = diceCreation.ThrowDie(4, 6, 2);
            int diceRollBoth = diceRoll1 + diceRoll2;

            // add a comment telling the player what's about to happen.
            Console.WriteLine("\nYou know what? We're going to make things worse for you, dear " + plName + ". To give you a chance to escape, we're going to give you two random numbers. "
                + "If the two values added together are greater than 4, then you're forced to enter this terrible place. If not, then you'll escape a fate worse than death...");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nYou rolled a " + diceRoll1 + " and a " + diceRoll2);
            Console.WriteLine("\nThe two values added together equal: " + diceRollBoth);

            // if the player rolls above a 4, they get through the door. If not, then they die.
            if (diceRollBoth > 4)
            {
                liveOrDie = true;
                Console.WriteLine("\nYour value is greater than 4.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHow unfortunate, " + plName + ". You now must enter this fortress of despair. And sure, this house isn't literally a fortress...but think of it this way: "
                    + "the amount of despair you'll feel will be about equivalent to the size of a fortress. Possibly even more.");
            }
            if (diceRollBoth < 4)
            {
                liveOrDie = false;
                Console.WriteLine("\nYour value is less than 4...");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOh my, you sure did get lucky, " + plName + "! Now, it's time to escape your fate worse then death...by experiencing the latter. What? Did you expect to leave this place and live?"
                    + " You either live in eternal pain, die after experiencing an almost eternal pain, or die on the doorstep."
                    + " It seems you've gotten the best option simply by chance.");
                Console.WriteLine("\nRight as you try to escape, you realize that you can't pull your feel away from the doormat. What's happening? This crazy narrator can't be serious, right?"
                    + " The harder you try and pull away, the deeper your feet start to sink into the stone floor. They keep sinking until there's nothing left of you, and you're surrounded by darkness.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat a way to go!");
                //System.Environment.Exit(1);
            }

            // the player is entering the building. find the third color in the myColors string; an object of that color will appear.
            string noComma1 = myColors.Substring(myColors.IndexOf(",") + 1);
            string noComma2 = noComma1.Substring(noComma1.IndexOf(",") + 1);
            int findComma = noComma2.IndexOf(",");
            string objColor = noComma2.Substring(0, findComma);
            Console.WriteLine("\nAs soon as you open the door, you see a glowing, black journal on the floor in front of you.");
        }

        

    }
}
