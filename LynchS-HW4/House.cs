using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Class for everything taking place inside the house
 */
namespace LynchS_HW12
{
    class House

    {
        // attribute
        public bool continueGame;

        // create setup object
        Setup gameSet; 

        // default constructor
        public House()
        {
            gameSet = new Setup();
        }

        // constructor
        public House(Setup stp)
        {
            gameSet = stp;
        }

        // method to describe the interior of the house.
        public void HouseInterior()
        {
            Console.WriteLine("\nYou pick the journal up, and look down the long hallway of the mysterious house. It's probably about time to pick up your feet and get a move on, right?"
                + "\n\nYou slowly walk down the hallway and gaze at the many doors. Two on your left, two on your right and one final door at the end of the hall. Each one has a label, and you decide to peek into the doors as you walk by."
                + "\n\nThe first door on your right is labeled 'Dining Room.' Inside the room is a long table, with one chair on either side. The table is covered with dark stains, but nothing else stands out about the room. It's pretty empty."
                + "\n\nThe room directly across from the dining room is the living room. You peek into that room and notice that the walls are entirely covered in old newspaper clippings. You try to make out the words, but most of them are scrated out. You do happen to notice the word 'murder' and 'grotesque' a few times, however. "
                + "\n\nHm. Weird, but I mean, that's normal, right?"
                + "\n\nYou decide to move on to looking into the next room on your right, which happens to be the kitchen. Hey, it's your lucky day! You're starving! But as you quickly looking into the room, you realize there isn't any food. Cookbooks are scattered about, as well as many rusted knives. Eh, that's boring stuff. Time to move on."
                + "\n\nThe next room on the left is the libary. Books. Blegh. You never were a reader. You never liked books, but you always especially hated any video games that involved tons of text. Those are the worst, right? Psh."
                + "\nYou look into the library and see more cookbooks. Two titles specifically stand out to you: Unusual Recipes and 1001 Ways to Skin an Animal. Maybe you should add these to your own personal library? They could be good reads."
                + "\n\nAnd finally, you move on to the unmarked door at the end of the hallway. The door looks to be boarded up. Oof, you felt a shiver as you walked up closer to it. And upon closer inspection, you noticed scratch marks all over the door, and is that...a human nail?? Naw, it couldn't be....right?");
        }

        // method for maggot to greet adventurer at door.
        public void MaggotGreet(int[] personInfo)
        {
            // call on deformed maggot class. create object
            // create arrays for the various attributes
            string[] maggotColors = { "grey", "gray", "pasty white", "charcoal", "white", "cream", "off white", "rainbow", "black", "red"};
            int[] maggotWrinkles = { 0, 1, 2, 3, 1000, 666, 7, 8, 9, 10 };
            int[] maggotEyes = { 0, 1, 2, 3, 4, 100, 5, 7, 9, 19 };
            Random rGen = new Random();

            DeformedMaggot normalMaggot = new DeformedMaggot();
            normalMaggot.magColor = maggotColors[gameSet.ThrowDie(4, 5)];
            normalMaggot.magEyes = maggotEyes[gameSet.ThrowDie(4,5)];
            normalMaggot.magHealth = 100;
            normalMaggot.magLegs = personInfo[rGen.Next(personInfo.Length)];
            normalMaggot.magWrinkles = maggotWrinkles[gameSet.ThrowDie(4, 5)];
            //DeformedMaggot weirdMaggot = new DeformedMaggot(100, 666, 1, "charcoal",100);
            // call on deformed maggot class. create object.
            DeformedMaggot weirdMaggot = new DeformedMaggot();
            weirdMaggot.magColor = maggotColors[gameSet.ThrowDie(4, 5)];
            weirdMaggot.magEyes = maggotEyes[gameSet.ThrowDie(4, 5)];
            weirdMaggot.magHealth = 100;
            weirdMaggot.magLegs = personInfo[rGen.Next(personInfo.Length)];
            weirdMaggot.magWrinkles = maggotWrinkles[gameSet.ThrowDie(4, 5)];

            // describe the two animals
            Console.WriteLine("\nAs you start to contemplate why you're here exactly, you notice a pair of deformed maggots crawling towards you."
                + "\nOh my goodness, they're huge!! One of them is somewhat normal looking (despite its size), while the other is quite unusual."
                + "\n\nYou look at the features of the normal maggot. It has " + normalMaggot.magColor + " flesh, " +  normalMaggot.magEyes + " eyes, " 
                + normalMaggot.magLegs + " legs, and " + normalMaggot.magWrinkles + " wrinkles. Diiiis-gusting! Blech!");
            Console.WriteLine("\nYou take a look at the other maggot, and realize it's even more disgusting. Its " + weirdMaggot.magEyes + " eyes sparkle at you with contempt. Can maggots even do that?" 
                + "Its " + weirdMaggot.magLegs + " legs look even more gross as they wriggle with its " + weirdMaggot.magColor + " flesh."
                + " But you definitely have to admire the weird maggot for its " + weirdMaggot.magWrinkles + " wrinkle. That's a nice wrinkle. Props to you, weird maggot!");
        }

        //method where the player deals with the maggots. uses nested if statements
        public void maggotInteraction()
        {
            Console.WriteLine("\nHm...there must be a way to get rid of them! You wouldn't normally think of trying to murder two, defenseless animals...but these are different!"
                + "They're...creepy and gross. They should totally die, yeah! Or at least just get out of your sight...");
            Console.WriteLine("\nYou take a look at your surroundings to see if there may be anything useful."
                + "\nYou notice what appears to be a dog leash (d) and a sword (s), you may also quit (q).");
            Console.Write("\nWhat do you pick? ");
            string maggotDef = Console.ReadLine();
            maggotDef = maggotDef.ToLower().Trim();

            // while loop to check for valid user input
            while (maggotDef != "d" && maggotDef != "s" && maggotDef != "q")
            {
                Console.WriteLine("You have entered invalid data. Please enter in a (d), (s), or enter (q) to quit.");
                maggotDef = Console.ReadLine();

                // call on quitgame
                gameSet.GameEnd();
            }

            // if statements for the user input.
            if (maggotDef == "d")
            {
                Console.WriteLine("\nYou have chosen to use the dog leash!");
                Console.WriteLine("\nThe two maggots start inching towards you as you try and figure out what you're supposed to do with this thing."
                    + " They keep crawling uncomfortably closer and closer...and then, in a panic, you just throw the leash in self defense."
                    + "\nThe maggots get tangled up in the leash!!"
                    + "\nThey keep writhing in agony, and they eventually seem to give up. One of them gives you a look as if to say you played well. Sweet.");
            }
            else if(maggotDef == "s")
            {
                Console.WriteLine("\nYou have chosen to use the sword!");
                Console.WriteLine("\nSick. You've always wanted to look like a badass!!"
                    + " Buuuut, unfortunately, you just end up dropping the heavy thing onto your feet and chopping off some limbs."
                    + "\nOuch, am I right?"
                    + "\nThe maggots crawl closer to you and don't seem to mind your lack of legs! How kind! Oh wait, no. They're just coming to eat you. And hey, now you've been eaten by maggots. Tough luck.");
                gameSet.GameEnd();
            }
            else if(maggotDef == "q")
            {
                Console.WriteLine("\nYou have chosen to quit.");
                gameSet.GameEnd();
            }
            else
            {
                Console.WriteLine("Seriously?! You didn't even pick an option!! Fine, then! Enjoy your fate!");
                gameSet.GameEnd();
            }
        }


        // method for exploring the kitchen
        public void KitchenExplore()
        {
            // create new random object
            Random rKitchen = new Random();

            // create userFood object
            List<string> userFood = gameSet.UserFood;

            // generate random number that is the length of the userFood list. set it as a string

            Console.WriteLine("\nThere doesn't seem to be any food in the kitchen, which you already noticed earlier. What's the point of even going there? Eh, you've made up your mind."
                + "\nYou continue to look around the kitchen and keep noticing just how many rusty knives there are in there. Yikes. Someone should really clean up the place!"
                + "\nYou start to open some of the cupboards and realize that the only cookbooks in here seem to contain instructions on eating...human flesh? No, it can't be. Must be a spelling mistake. Yeah, that seems right."
                + "\nLooking around, you start to notice a lot of " + userFood[rKitchen.Next(userFood.Count)] + " meat. There's also a ton of " + userFood[rKitchen.Next(userFood.Count)] + " all over the filthy counters. Weird. It doesn't seem to have been eaten at all."
                + " You decide to open the grimey fridge, only to find " + userFood[rKitchen.Next(userFood.Count)] + "."
                + "Interesting...whoever lives here must be a meat lover!");
        }

        // method for exploring the living room
        public void LivingRoomExplore()
        {
            Console.WriteLine("\nYou peek into that room and notice that the walls are entirely covered in old newspaper clippings. You try to make out the words, but most of them are scrated out. You do happen to notice the word 'murder' and 'grotesque' a few times, however.");
            Console.WriteLine("\nWait...haven't we heard something like that before?");
            Console.WriteLine("\nRegardless, you think it's pretty nice for the person who lives here to have a hobby. Collecting antiques is pretty nice!");
        }

        // method for exploring the unmarked door
        public void UnmarkedDoorExplore()
        {
            Console.WriteLine("he door looks to be boarded up. Oof, you felt a shiver as you walked up closer to it. And upon closer inspection, you noticed scratch marks all over the door, and is that...a human nail?? Naw, it couldn't be....right?");
            Console.WriteLine("\nWait...haven't we heard something like that before?");
            Console.WriteLine("\nAnyways, you keep looking at the door trying to open it, but hey. You can't exactly unlock doors with your mind! Or can you..."
                + "\nYou decide to try unlocking the mysterious door somehow.");
            Console.WriteLine("\n\nThe way you see it, you have 4 different options. You can use the sword you found earlier (s), use the maggots you have tied up (m), lounge around and do nothing (l) or quit (q)");
            Console.Write("\nWhat do you decide to do? ");
            string dunDoorUn = Console.ReadLine();
            dunDoorUn = dunDoorUn.ToLower();

            // while loop to check for valid user input
            while (dunDoorUn != "s" || dunDoorUn != "m" || dunDoorUn != "l" || dunDoorUn != "q")
            {
                Console.WriteLine("You have entered invalid data. Please enter in a (d), (s), or enter (q) to quit.");
                dunDoorUn = Console.ReadLine();

                // call on quitgame
                gameSet.GameEnd();
            }

            // nested if statements for different outcomes
            if (dunDoorUn == "s")
            {
                Console.WriteLine("\nYou decide to try using the sword to open the door. After all, you didn't use it earlier! It must have SOME function, right?"
                    + "\nYou pick it up from where it was stranded in the hallway, and decide to use it as leverage to bust open the door. Smart!"
                    + "...but not smart enough. In the process of trying to pry the door open, you slip on accident and end up swinging the sword right to your very own neck! Oh dear."
                    + " It appears that you have very much chopped off your own head. Yikes.");
                gameSet.GameEnd();
            }
            else if(dunDoorUn == "m")
            {
                Console.WriteLine("\nThe leash worked last time for the maggots, right? It ought to work again! ...or at least that's what your mind led you to believe.");
                Console.WriteLine("\nYou pick up the tangled mess of maggots and leash, and throw them all at the door. Maybe the sheer force of it will cause the door to open, or at least the absurdness of the situation."
                    + "...but alas, it does not work. The maggot/leash combo bounces off the door and hits you square in the face. You're done for.");
                gameSet.GameEnd();
            }
            else if(dunDoorUn == "l")
            {
                Console.WriteLine("\nEh, what's the rush? There's really no need to try and figure this thing out right now. You decide to just lounge around and lean against the nearby wall."
                    + " But wait...what's this?? As soon as your back presses against the totally not suspicious, discolored piece of wall, the door miraculously opens!! My, oh my! I believe you've done it!");
            }
            else if(dunDoorUn == "q")
            {
                Console.WriteLine("\nYou have chosen to quit.");
                gameSet.GameEnd();
            }
            else
            {
                Console.WriteLine("You didn't pick anything!!");
                gameSet.GameEnd();
            }
        }

        // method for exploring the dining room
        public void DiningRoomExplore()
        {
            Console.WriteLine("\nInside the room is a long table, with one chair on either side. The table is covered with dark stains, but nothing else stands out about the room. It's pretty empty.");
            Console.WriteLine("\nWait...haven't we heard something like that before?");
            Console.WriteLine("\nPshawwww, let's pretend that that isn't true. You keep looking around the room and are enamoured by the vintage style of the room."
                + " The rug is tattered and seems to be chewed in various places, but that just adds to the aesthetic!");
        }

        // method for exploring the library
        public void LibraryExplore()
        {
            Console.WriteLine("\nYou You look into the library and see more cookbooks. Two titles specifically stand out to you: Unusual Recipes and 1001 Ways to Skin an Animal. Maybe you should add these to your own personal library? They could be good reads.");
            Console.WriteLine("\nWait...haven't we heard something like that before?");
            Console.WriteLine("\nI mean, what more is there to a library? Books and more books. Unless...one of these books leads to a secret passageway!!"
                + "\nHaha, there's no way that's possible.");
        }

        // call on dungeon class
        Dungeon dungeonAreas = new Dungeon();

        // method to ask user which room they want to move to. use switch statement
        public void WhichRoom()
        {
            Console.WriteLine("\n\nNow! It's finally time to decide where you'd like to go!");
            

            // do while loop to let the adventurer keep exploring rooms, and to initially select a room
            do
            {
                Console.WriteLine("Pick which one of these room you'd like to enter.");
                Console.WriteLine("1.Kitchen");
                Console.WriteLine("2.Living Room");
                Console.WriteLine("3.Unmarked Door");
                Console.WriteLine("4.Dining Room");
                Console.WriteLine("5.Library");
                Console.Write("\nEnter a choice (1, 2, 3, 4, or 5), or (q) to quit: ");
                string roomNumberStr = Console.ReadLine();


                // while loop to check for valid user input
                while (roomNumberStr != "1" || roomNumberStr != "2" || roomNumberStr != "3" || roomNumberStr != "4" || roomNumberStr != "5" || roomNumberStr != "q")
                {
                    Console.WriteLine("You have entered invalid data. Please enter in a (1, 2, 3, 4, 5, or q)");
                    roomNumberStr = Console.ReadLine();

                    // call on quitgame
                    gameSet.GameEnd();
                }

                // convert roomnumberstr to a char
                char roomNumberChar = roomNumberStr[0];


                //assign the room number/room with a switch statement
                switch (roomNumberChar)
                {
                    case '1': // kitchen
                        Console.WriteLine("You've decided to explore the kitchen!");
                        KitchenExplore();
                        break;

                    case '2': // living room
                        Console.WriteLine("You've decided to explore the living room!");
                        LivingRoomExplore();
                        break;

                    case '3': // unmarked door
                        Console.WriteLine("You've decided to explore the...unmarked door?");
                        UnmarkedDoorExplore();
                        Console.WriteLine("\n\nYou are finally able to make it into the unmarked door!! I mean, it didn't exactly take very long...but wow, what a feat!"
                            + "\nYou start walking down the eerie stairs...further and further into the dark abyss...yeesh. Oh! Here it is! Finally!! The bottom of the staircase!!");
                        bool goBack = dungeonAreas.DungeonArea1();
                        if(goBack == true)
                        {
                            WhichRoom();
                            break;
                        }
                        break;

                    case '4': // dining room
                        Console.WriteLine("You've decided to explore the dining room!");
                        DiningRoomExplore();
                        break;

                    case '5': // library
                        Console.WriteLine("You've decided to explore the library!");
                        LibraryExplore();
                        break;

                    default:
                        Console.WriteLine("GOD, why couldn't you just enter in one of the possible values???");
                        Console.WriteLine("You're just going to head right into the library regardless.");
                        LibraryExplore();
                        break;
                }

                // ask user if they want to continue exploring
                Console.WriteLine("\n\nDo you want to continue adventuring? (y) or (n): ");
                string contStr = Console.ReadLine();
                contStr.ToLower();
                

               //if statement to check for what the user said
               if(contStr == "y")
                {
                    continueGame = true;
                }
                else
                {
                    continueGame = false;
                    System.Environment.Exit(1);
                }

            } while (continueGame == true);
        }
        // Once inside the house, the player sees a long hallway with many doors. Each is labled. 
        // Can go to the kitchen, living room, library, dining room, or an unmarked door.

        // Kitchen - some cook books scattered around, all are old and tattered. lots of cooking supplies (specifically knives) are in the sink. has a trap set if door is opened there. Axe falls from the ceiling and GAME OVER.

        // Living room - can look around or not. Loads of old newspaper clippings. Talking about murders that happened.

        // Unmarked door - Cannot open door. Player sees that it boarded up. Scratches on it.

        // Dining room - a long table with dark stains. only two chairs on either end. otherwise empty.

        // Library - can look around shelves. Sees one title: "Unusual Recipes." Sees another title: "1001 Ways to Skin an Animal"
        // Can pick either book. If player picks the skinning book, nothing happens except the player learns things about skinning animals
        // If cooking book is picked, bookshelf opens up to reveal a room with a trap door.
    }
}
