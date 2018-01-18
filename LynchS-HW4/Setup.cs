using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Initial setup for the game
 * Ask player for their name
 * Create an introduction for the game
 */
namespace LynchS_HW12
{

    class Setup
    {
        // list variable
        private List<string> userFood;

        // add constructor
        public Setup(List<string> usFd)
        {
            userFood = usFd;
        }

        public Setup()
        {
            
        }

        // playerName attribute
        private string playerName;

        // getter for playerName
        public string GetCharacterName()
        {
            return playerName;
        }

        // setter for playerName
        public void SetCharacterName(string plNm)
        {
            playerName = plNm;
        }

        // array for int values from the player
        private int[] playerInfos;

        // get and set for the player int values array
        public int[] PlayerInfos
        {
            get { return playerInfos; }
            set { playerInfos = value; }
        }

        // getter and setter for userfood
        public List<string> UserFood
        {
            get { return userFood; }
            set { userFood = value; }
        }

        // method to ask for types of meat
        public void UserFoodInput()
        {
            while (true)
            {
                //ask user for food names
                Console.WriteLine("Please enter in a type of meat. This data will be added to a list of food. ");
                string foodInput = Console.ReadLine();

                // verify that the entry is valid
                while (string.IsNullOrEmpty(foodInput))
                {
                    Console.WriteLine("Invalid entry. Please enter in a type of meat. This data will be added to a list of food. ");
                    foodInput = Console.ReadLine();
                }

                // add the data to a list
                userFood.Add(foodInput);

                // ask the user if they want to add more food to the list
                Console.WriteLine("Do you want to add more meat to the list? (y) or (n): ");
                string answerUse = Console.ReadLine();
                answerUse = answerUse.Trim().ToLower();

                while ((answerUse != "n") && (answerUse != "y"))
                {
                    Console.WriteLine("Invalid entry. That isn't a (y) or a (n). Please enter in (y)es or (n)o: ");
                    answerUse = Console.ReadLine().Trim().ToLower();
                }

                if (answerUse == "n")
                {
                    Console.WriteLine("\nYou have decided not to add any more food to the list.");
                    break;
                }
            }

            // foreach loop to display the list
            foreach(string fdIn in userFood)
            {
                Console.WriteLine("Meat in your list: " + fdIn);
            }
        }

        // create method to get player info
        public void GetCharacter()
        {

            // Title of the game
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter, if you dare...'The Abyss' \n_________________________________");

            // Greet the user here and ask for their input, such as a name.
            Console.WriteLine("Now...may I ask who has decided to experience this nightmare? (enter (q) to quit)");
            SetCharacterName(Console.ReadLine());

            // set charName equal to playerName
            SetCharacterName(GetCharacterName());
            
            // calling quitgame method
            QuitGame();

            // loop to check that the player didnt enter in nothing
            while (GetCharacterName() == "")
            {
                // Greet the user here and ask for their input, such as a name.
                Console.WriteLine("You have entered invalid data. Please enter your name, or enter (q) to quit.");
                SetCharacterName(Console.ReadLine());

                // calling quitgame method
                QuitGame();
            }

            Console.WriteLine("I'm truly sorry you're here, " + playerName + "...");

            // trim blank spaces from the name.
            SetCharacterName(GetCharacterName().Trim(' '));
        }

        // method to get 10 random int values from the player and store them
        public int[] Personalize()
        {
            // initialize an array
            playerInfos = new int[10];
            Console.WriteLine("\nNow, we are just going to get 10 integer values from you.");

            // for loop to get 10 values
            for (int i = 0; i < playerInfos.Length; i++)
            {
                Console.WriteLine("\nEnter in an int value between 10 to 100 for value number " + (i + 1) + ": ");
                string intStrVal = Console.ReadLine();
                int intVal;
                bool parsedIntVal = int.TryParse(intStrVal, out intVal);

                // while loop to validate input
                while (!parsedIntVal || !(intVal >= 10 && intVal <= 100))
                {
                    Console.WriteLine("You entered in an incorrect value. Please enter in an int value between 10 to 100: ");
                    intStrVal = Console.ReadLine();
                    parsedIntVal = int.TryParse(intStrVal, out intVal);

                    //if (parsedIntVal && (intVal >= 10 && intVal <= 100))
                    //    break;
                }

                // put the intVal value given by the player into the array
                playerInfos[i] = intVal;
                //Console.WriteLine("Here are your current inputs: " + personalInfo[i]);
            }

            // foreach loop to show the array
            foreach (int numVals in playerInfos)
            {
                Console.WriteLine("\nHere are your array values: " + numVals);
            }

            // call UserFoodList method
            UserFoodInput();

            return playerInfos;

            /*foreach (int num1 in personalInfo)
            {
                Console.WriteLine(num1);
            }

            for (int i = 0; i < personalInfo.Length; i++)
            {
                Console.WriteLine(personalInfo[i]);
            }*/

            

        }

        // create method for game introductions
        public void Introduction()
        {
            // Give some background as to what the story is and what the situation is.
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nThe Abyss is a dark, and even borderline horror, interactive text based game."
                + "\nThroughout the game, it is up to you to make decisions based on the choices presents to you."
                + "\nOnly a keyboard is required to be able to play, so enjoy!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            // ask the user if they're ready to play. make sure they enter "Y" or "N," or a q to quit
            Console.Write("Are you ready to play? (Y/N). Enter in (q) to quit.");
            QuitGame();
            string playerInitialAnswer = Console.ReadLine();
            playerInitialAnswer = playerInitialAnswer.ToUpper();
            playerInitialAnswer = playerInitialAnswer.Substring(0, 1);

            // while loop to check user input for ENTER.
            while (playerInitialAnswer != "Y" && playerInitialAnswer != "N")
            {
                Console.WriteLine("You have entered invalid data. Please enter in a (Y), (N) or enter (q) to quit.");
                playerInitialAnswer = Console.ReadLine().ToUpper().Trim();

                // call on quitgame
                QuitGame();
            }

            // if player enters Y, continue with the game. if not, then do not progress
            Console.ForegroundColor = ConsoleColor.Red;
            if (playerInitialAnswer == "Y")
            {
                Console.WriteLine("Very well...then let us begin...");
            }
            else
            {
                Console.WriteLine("That was a very wise decision...");
                System.Environment.Exit(1);
            }
        }

        // method to throw die and return a value
        public int ThrowDie(int sidesNum1, int sidesNum2)
        {
            Random rGen = new Random();
            int roll1 = rGen.Next(sidesNum1) + 1;
            int roll2 = rGen.Next(sidesNum2) + 1;
            return roll1 + roll2;
        }

        // overload method to throw die and return a value. also accept a new parameter to show how many die thrown
        public int ThrowDie(int sidesNum1, int sidesNum2, int diceThrown)
        {
            Random rGen = new Random();
            int roll1 = rGen.Next(sidesNum1) + 1;
            roll1 = roll1 * diceThrown;
            roll1 = roll1 / diceThrown;
            int roll2 = rGen.Next(sidesNum2) + 1;
            roll2 = roll2 * diceThrown;
            roll2 = roll2 / diceThrown;
            return roll1 + roll2;
        }

        // method for if the player decides to quit

        public void QuitGame()
        {
            // if statement for if player quits
            if (playerName == "q" || playerName == "Q")
            {
                Console.WriteLine("You have decided to quit the game.");
                System.Environment.Exit(1);
            }
        }

        // create a method for ending the game
        public void GameEnd()
        {
            Console.WriteLine("Oh, how fortunate...");
            Console.WriteLine("It appears that you have died...lucky you.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any key to exit the game.");
            System.Environment.Exit(1);
        }
    }
}
