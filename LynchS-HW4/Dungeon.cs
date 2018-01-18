using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Class for everything taking place inside the dungeon
 * Player goes through 4 different dungeon levels.
 */
namespace LynchS_HW12
{
    class Dungeon
    {
        // call on yard class
        Setup gameSet = new Setup();

        // call on house class
       // House gameHouse = new House();

        // ask user if they want to leave the dungeon and explore rest of the house or quit
        public bool LeaveDungeon()
        {
            Console.WriteLine("\n\nWould you like to leave the dungeon to continue exploring the house, or quit? (y), (n) or (q): ");
            string leaveStr = Console.ReadLine();
            leaveStr.ToLower();

            //if statement to check for what the user said
            if (leaveStr == "y")
            {
                return true;
            }
            if (leaveStr == "q")
            {
                System.Environment.Exit(1);
                return false;
            }
            else
            {
                return false;
            }
        }

        // If player enters unmarked door, players ends up in the dungeon.

        // Dungeon has many enemies all of a sudden. Skinned rabbits and other various zombified animals. 

        // In order to get out of the dungeon and escape with their life, the player must pass through 4 trials.

        // method for first dungeon area
        public bool DungeonArea1()
        {
            // first area contains maggots. smaller than the ones upstairs, but there are many
            Console.WriteLine("\n\nYou make it to the bottom. It's even spookier. They definitely need some remodeling here. You're about to take another step when you see them."
                + " More maggots!!! Oh God, why!! How could you do this? But God can't hear you right now; only the maggots can.");
            Console.WriteLine("You anxiously look around to see what you can distract them with. They aren't nearly as huge as the ones you saw upstairs, but they're still disgusting and bothersome.");
            Console.WriteLine("You can either use your (s)hoelaces, a nearby (t)oothpick discarded on the ground, go (b)ack upstairs or (q)uit the game.");
            Console.Write("\n\nWhat do you do? ");
            string dun1 = Console.ReadLine();
            dun1 = dun1.ToLower();

            // while loop to check for valid user input
            while (dun1 != "s" || dun1 != "t" || dun1 != "q" || dun1 != "b")
            {
                Console.WriteLine("You have entered invalid data. Please enter in a (t), (s), or enter (q) to quit.");
                dun1 = Console.ReadLine();

                // call on quitgame
                gameSet.GameEnd();
            }

            // if statements for the choice made
            if (dun1 == "s")
            {
                Console.WriteLine("\n\nYou have picked to use your shoelaces.");
                Console.WriteLine("\nShoelaces, dog leashes...they're the same thing, right? And sure enough, once you dangle that little shoelace in front of the maggots, they're obsessed."
                    + " You decide to let them have a little alone time, and you continue on to the next part of the dungeon.");
                DungeonArea2();
            }
            if(dun1 == "t")
            {
                Console.WriteLine("\n\nYou have decided to use the tiny little toothpick you found on the ground.");
                Console.WriteLine("\nYou pick up the toothpick in the hopes that you can somehow fight off all these tiny maggots. But instead, you only create a bridge between yourself and them." 
                    + " They start to crawl up the toothpick and feast upon your flesh. Just kidding. They're mostly just tickling you, but you drop down dead anyways. It was a traumatic experience.");
                gameSet.GameEnd();
            }
            if(dun1 == "q")
            {
                Console.WriteLine("\n\nYou have decided to quit the game.");
                gameSet.GameEnd();
            }
            if (dun1 == "b")
            {
                Console.WriteLine("\n\nYou have decided to return to the house.");
                return true;
            }
            else
            {
                Console.WriteLine("\nYou didn't even make a valid choice...poor you...");
                gameSet.GameEnd();
            }
            return true;
        }

        

        // method for second dungeon area
        public void DungeonArea2()
        {
            // random object 
            Random rGenOb = new Random();
            int diceRollNew = rGenOb.Next(1, 2);

            // second area contains various insects. worms, spiders, etc. they are a bit bigger than maggots
            Console.WriteLine("\n\nThe second area of the dungeon seems a little more spacious. Hmm...you wonder why that is...oh no!! More insects! Yuck!");

            int ravenResult;

            // if statements about child classes
            if(diceRollNew == 1)
            {
                Console.WriteLine("You see a zombie raven in the room as well. Spooky.");
                Raven ravenObj;
                ravenResult = 1;
            }
            else
            {
                Console.WriteLine("You see a mean raven in the room as well. Not so spooky!");
                Raven ravenObj;
                ravenResult = 2;
            }

            // ask if they want to touch the animal
            Console.WriteLine("\nWould you like to touch the animal? (Y)es or (N)o: ");
            string touchAnimal = Console.ReadLine().ToUpper().Trim();
            char touchAniChar = touchAnimal[0];

            // switch statements determining if they want to touch the animal
            switch(touchAniChar)
            {
                case 'Y': // touch the animal!

                    Console.WriteLine("You've decided to touch the raven! Oh, scary!");

                    if(ravenResult == 1)
                    {
                        ZombieRaven zomboRav = new ZombieRaven();
                        bool attackYes = zomboRav.Attack();

                        // see if attack worked or not
                        if (attackYes == true)
                        {
                            gameSet.GameEnd();
                        }
                    }
                    else if(ravenResult == 2)
                    {
                        MeanRaven meanRav = new MeanRaven();
                        bool attackYes = meanRav.Attack();

                        // see if attack worked or not
                        if(attackYes == false)
                        {
                            gameSet.GameEnd();
                        }
                    }
                    else if ((ravenResult != 2) && (ravenResult != 1))
                    {
                        Console.WriteLine("The raven tried to attack you but totally missed. What a dumb.");
                    }

                    break;

                case 'N': // dont touch the animal
                    Console.WriteLine("\nYou have decided to just ignore the animal. Good choice.");
                    break;

                default:
                    break;
            }

            Console.WriteLine("You anxiously look around to see what you can distract the other creatures with. They're bigger than the maggots from the previous room. What can you do?!");
            Console.WriteLine("You can either use your remaining (s)hoelace, a (j)ar of tar on the ground, or (q)uit the game.");
            Console.Write("\n\nWhat do you do? ");
            string dun2 = Console.ReadLine();
            dun2 = dun2.ToLower();

            // while loop to check for valid user input
            while (dun2 != "s" || dun2 != "j" || dun2 != "q")
            {
                Console.WriteLine("You have entered invalid data. Please enter in a (j), (s), or enter (q) to quit.");
                dun2 = Console.ReadLine();

                // call on quitgame
                gameSet.GameEnd();
            }

            // if statements for the choice made
            if (dun2 == "s")
            {
                Console.WriteLine("\n\nYou have picked to use your shoelaces.");
                Console.WriteLine("\nMaggots, other bugs and insects...they're the same thing, right? Third time's the charm! A shoelace should work again!"
                    + " You throw your shoelace at the various creepy little critters, but they don't seem to notice. They just keep buzzing and crawling closer and closer to your general vicinity, until they take up your entire vision.");
                gameSet.GameEnd();
            }
            if (dun2 == "j")
            {
                Console.WriteLine("\n\nYou have decided to use the tar jar to help you somehow.");
                Console.WriteLine("\nYou open up the jar and throw it onto the ground, shattering the jar in the process. Wait...why did you open the jar only to throw it anyways? Well, I never said you were a clever one."
                    + " But apparently, you just so happened to be clever enough just now, because the bugs start to get stuck in the tar! Hurray! You can now move on!");
                DungeonArea3();
            }
            if (dun2 == "q")
            {
                Console.WriteLine("\n\nYou have decided to quit the game.");
                gameSet.GameEnd();
            }
            else
            {
                Console.WriteLine("\nYou didn't even make a valid choice...poor you...");
                gameSet.GameEnd();
            }
        }

        


        // method for third dungeon area
        public void DungeonArea3()
        {
            // third area contains skinned rabbits. they are even bigger
            Console.WriteLine("\n\nThe third area of the dungeon seems even more spacious. Hmm...you wonder why that is. Yikes. Skinned rabbits! And they're not dead! Or are they? The logistics don't really matter. What matters is that they're moving!");

            // write lines to show the two animals that are edible
            Console.WriteLine("Also in the area, you notice two more types of creatures: a locust and a black cat.");
            Console.WriteLine("Hm...you realize your tummy as rumbling as you haven't had anything to eat today. They could certainly be...tasty...");

            // create objects for the two creatures
            BlackCat blCt = new BlackCat();
            Locust loc = new Locust();

            // allow the adventurer to eat the creatures
            Console.WriteLine("Would you like to eat the creatures right now? (Y/N) or (Q)uit: ");
            string eatCreatStr = Console.ReadLine().Trim().ToUpper();
            char eatCreat = eatCreatStr[0];

            // switch statement for the options of eating the animals or not
            switch(eatCreat)
            {
                case 'Y': // yes
                    Console.WriteLine("You decide to eat the two animals! The locust seems to be more of a light snack, while the black cat will take more effort.");

                    // call on Bite from two creature classes
                    loc.Bite();
                    blCt.Bite();
                    break;

                case 'N': // no
                    Console.WriteLine("Very well. You decide to suffer the hunger and just go about your way in the dungeon. There are other creatures here, after all, and they seem more dangerous.");
                    break;

                case 'Q': // quiet
                    Console.WriteLine("You have decided to quit... but let's first check how much of these two animals you have consumed unknowingly.");

                    // if statement to check if theyre fully consumed
                    if((loc.IsConsumed() == false) || (blCt.IsConsumed() == false))
                    {
                        Console.WriteLine("How rude!! You're quitting while still leaving a mess behind! That's disgusting. You ought to be ashamed of yourself.");
                        gameSet.GameEnd();
                    }
                    else
                    {
                        Console.WriteLine("You haven't left a mess. Good on you.");
                        gameSet.GameEnd();
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine("You anxiously look around to see what you can distract the rabbits with. They're bigger than the bugs from the previous room. What can you do?!");
            Console.WriteLine("You can either use a single dirty, fuzzy (s)lipper you found on the ground, a (r)ope strewn across the floor, or (q)uit the game.");
            Console.Write("\n\nWhat do you do? ");
            string dun3 = Console.ReadLine();
            dun3 = dun3.ToLower();
            char dun3Char = dun3[0];

            // switch statement for the options
            switch(dun3Char)
            {
                case 's': // dirty slipper
                    Console.WriteLine("\n\nYou have decided to use the dirty, fluffy slipper.");
                    Console.WriteLine("\nYou don't even have a plan with this thing. You might as well try though! There isn't exactly much of a choice."
                        + " You throw the slipper at the rabbits. Wait a second...what's happening?? They're crowding around the slipper! They must have recognized it as one of their own!"
                        + " They seem to start worshipping the fuzzy slipper, perhaps envious of it's furry coat; it's something they lack, being skinned and all."
                        + " Now's your chance to escape!");
                    DungeonArea4();
                    break;

                case 'r': // rope
                    Console.WriteLine("\n\nYou have decided to use the rope.");
                    Console.WriteLine("\nRope equals shoelace, yeah? Shoelaces and ropes and leashes and the like have been pretty useful so far. Let's just keep using them, huh?"
                        + " You try to entrap the rabbits with the rope somehow, but they mostly just seem unamused. One of them even bites through the rope, and then nips at your finger afterwards."
                        + " Those damn rabbits!! They must have known you were anemic!! You feel faint from the blood loss, and soon enough fall to the ground.");
                    gameSet.GameEnd();
                    break;

                case 'q': // quit
                    Console.WriteLine("\n\nYou have decided to quit the game.");
                    break;

                default: //default
                    Console.WriteLine("\n\nNo valid selection was made, loser! You're donezo!");
                    gameSet.GameEnd();
                    break;
            }
        }


        // method for fourth dungeon area
        public void DungeonArea4()
        {
            // fourth area contains...people?? no, it cant be.
            Console.WriteLine("\n\nThe fourth area of the dungeon is definitely the most spacious of all.");
            Console.WriteLine("You anxiously look around to see what will come at you next...oh! It looks like there's another person down here! You shout out to them, hoping they can help you!");
            Console.WriteLine("But once they turn around...you see that they have no face! Ahhh, the horror! They can't be a real person, can they?");
            Console.WriteLine("How will you get rid of them this time? They're coming right for you!! You can either use a nearby (s)hotgun, (o)pen your arms in fear, or (q)uit the game.");
            Console.Write("\n\nWhat do you do? ");
            string dun4 = Console.ReadLine();
            dun4 = dun4.ToLower();

            // while loop to check for valid user input
            while (dun4 != "s" || dun4 != "o" || dun4 != "q")
            {
                Console.WriteLine("You have entered invalid data. Please enter in a (1, 2, 3, 4, 5, or q");
                dun4 = Console.ReadLine();

                // call on quitgame
                gameSet.GameEnd();
            }

            char dun4Char = dun4[0];

            // switch statement for the options
            switch (dun4Char)
            {
                case 's': // shotgun
                    Console.WriteLine("\n\nYou have decided to use the shotgun");
                    Console.WriteLine("\nLet's do it. You suddenly feel brave as you pick up the shotgun, and aim at the frightening creature."
                        + " You put your finger on the trigger...aaaand..."
                        + " BLAM! You hear a sudden noise and right as you pull the trigger, your arm jerks down in response."
                        + " You just shot your foot off! The humanoid creature is now even more alerted to your being down there, and comes after you. Goodbye, cruel world...");
                    gameSet.GameEnd();
                    break;

                case 'o': // open arms
                    Console.WriteLine("\n\nYou have decided to pretty much do nothing and just be a coward");
                    Console.WriteLine("\nThe being tilts its head in response to you throwing your arms wide open in fear."
                        + " It draws closer and closer to you...and, oh God, this is it!! You're going to die!! You brace yourself for your eyes to be gouged out. but instead..."
                        + " the creature just puts its arms around you? Did it just want a hug this entire time? Poor thing must have been lonely.");
                    break;

                case 'q': // quit
                    Console.WriteLine("\n\nYou have decided to quit the game.");
                    break;

                default: //default
                    Console.WriteLine("\n\nNo valid selection was made, loser! You're donezo!");
                    gameSet.GameEnd();
                    break;
            }
        }
    }
}
