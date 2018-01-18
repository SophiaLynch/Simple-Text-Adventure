using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Sophia Lynch
 * GDAPS 1
 * Homework 12
 * Test and functional classes
 * Instantiating objects
 * Method parameters and the use of methods
 */
namespace LynchS_HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list for food
            List<string> userFood = new List<string>();
            

            // call on methods from setup class and create an object of Setup
            Setup gameSetup = new Setup(userFood);
            gameSetup.GetCharacter();
            int[] personalityValues = gameSetup.Personalize();
            gameSetup.Introduction();

            // call on methods from yard class and create an object of yard
            Yard gameYard = new Yard();
            gameYard.ExploreYard(gameSetup.GetCharacterName());
            gameYard.FrontDoor(gameSetup.GetCharacterName());

            // create house object. call on house interior method
            Console.WriteLine("Test");
            House gameHouse = new House(gameSetup);
            

            // check if liveOrDie is true or not, and then call on the appropriate methods
            if(gameYard.liveOrDie == true)
            {
                gameHouse.HouseInterior();
                gameHouse.MaggotGreet(personalityValues);
                gameHouse.maggotInteraction();
                gameHouse.WhichRoom();
            }
            else
            {
                gameSetup.GameEnd();
            }
        }
    }
}
