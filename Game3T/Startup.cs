using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3T
{
    class Startup
    {
        static void Main(string[] args)
        {
            string userInput = null;
            bool quit = false;
            string[] placeHolders = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            //Asks the player if they would like to play Tic Tac Toe
            Console.WriteLine("Welcome to Tic Tac Toe! Would you like to play Tic Tac Toe?");
            userInput = Console.ReadLine();
            while (userInput.ToLower() == "yes" || userInput.ToLower() != "no")
            {
                if (userInput.ToLower() == "yes")
                {
                    while (quit == false)
                    {

                        //Asks for singleplayer or multiplayer, responds accordingly
                        Console.WriteLine("Would you like to play singleplayer or multiplayer?");
                        userInput = Console.ReadLine();
                        while (userInput.ToLower() != "singleplayer" && userInput != "multiplayer" && userInput != "end")
                        {
                            //Responds to an answer other than singleplayer or multiplayer and then tries again for an input
                            if (userInput != "singleplayer" && userInput != "multiplayer" && userInput != "end")
                            {
                                Console.WriteLine("Not an option. Enter singleplayer or multiplayer.");
                                userInput = Console.ReadLine();
                            }
                        }
                        //Runs game against AI
                        if (userInput.ToLower() == "singleplayer")
                        {
                            AI.TTTAI(placeHolders);
                            userInput = "end";
                        }
                        //Runs game against another player
                        else if (userInput.ToLower() == "multiplayer")
                        {
                            Multiplayer.TTTMultiplayer(placeHolders);
                            userInput = "end";


                        }
                        //Resets the board
                        for (int i = 0; i < placeHolders.Length; ++i)
                        {
                            placeHolders[i] = Convert.ToString(i);
                        }
                        //Asks if the user would like to play again
                        Console.WriteLine("Would you like to play again?");
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == "no")
                        {
                            userInput = "no";
                            quit = true;
                        }
                        else if (userInput.ToLower() == "yes")
                        {
                            Main(args);
                        }
                        else
                        {
                            Console.WriteLine("Not an answer. Try again.");
                            userInput = Console.ReadLine();
                        }
                    }
                }
                //Responds to no by saying goodbye, code stops after this
                else if (userInput.ToLower() == "no")
                {
                   
                }
                //Responds to any answer other than yes or no followed by the game asking again
                else
                {
                    Console.WriteLine("That is not yes or no. Try entering yes or no.");
                    userInput = Console.ReadLine();
                }
                userInput = "no";
            }
            //Occurrence of all while statements ceasing
            Console.WriteLine("Goodbye!");
        }
        
    }
}

