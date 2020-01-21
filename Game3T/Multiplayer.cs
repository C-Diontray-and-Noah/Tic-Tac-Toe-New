using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3T
{
    class Multiplayer
    {
        public static void TTTMultiplayer(string[] placeHolders)
        {
            bool win = false;
            bool xOrO = false;
            int turns = 0;
            int userChoice = 0;
            string playerOne = null;
            string playerTwo = null;
            string winner = null;

            do
            {
                //Takes the input of whether player one would like to play with Xs or Os, assigns player two accordingly
                while (xOrO == false)
                {
                    Console.WriteLine("Player 1 : X or O?");
                    playerOne = Console.ReadLine();
                    playerOne = playerOne.ToUpper();
                    if (playerOne == "X")
                    {
                        Console.WriteLine("Player 1 is Xs!\nPlayer 2 is Os!");
                        playerTwo = "O";
                        xOrO = true;
                        Board.TTTBoard(placeHolders);
                    }
                    else if (playerOne == "O")
                    {
                        Console.WriteLine("Player 1 is Os!\nPlayer 2 is Xs!");
                        playerTwo = "X";
                        xOrO = true;
                        Board.TTTBoard(placeHolders);
                    }
                    else
                        Console.WriteLine("Not an option");
                }
                //Starts player 1's turn
                if (turns % 2 == 0)
                {
                    Console.WriteLine("Player 1's turn : ");
                    userChoice = Convert.ToInt32(Console.ReadLine());

                    while (turns % 2 == 0)
                    {
                        //Evaluates whether the space chosen by player one is already taken
                        if (placeHolders[userChoice] == "X" || placeHolders[userChoice] == "O")
                        {
                            Console.WriteLine("Already taken. Choose another.");
                            userChoice = Convert.ToInt32(Console.ReadLine());
                        }
                        //Evaluates whether the space chosen is an actual space
                        else if (placeHolders[userChoice] == "1" || placeHolders[userChoice] == "2" || placeHolders[userChoice] == "3" ||
                            placeHolders[userChoice] == "4" || placeHolders[userChoice] == "5" || placeHolders[userChoice] == "6" || placeHolders[userChoice] == "7"
                            || placeHolders[userChoice] == "8" || placeHolders[userChoice] == "9")
                        {
                            placeHolders[userChoice] = playerOne;
                            ++turns;
                        }
                        else
                        {
                            Console.WriteLine("That is not an answer. Choose 1 through 9.");
                            userChoice = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Board.TTTBoard(placeHolders);
                }
                //Starts player 2's turn
                else
                {
                    Console.WriteLine("Player 2's turn : ");

                    while (turns % 2 != 0)
                    {
                        userChoice = Convert.ToInt32(Console.ReadLine());
                        if (placeHolders[userChoice] == "X" || placeHolders[userChoice] == "O")
                        {
                            Console.WriteLine("Already taken. Choose another.");
                        }
                        else if (placeHolders[userChoice] == "1" || placeHolders[userChoice] == "2" || placeHolders[userChoice] == "3" ||
                           placeHolders[userChoice] == "4" || placeHolders[userChoice] == "5" || placeHolders[userChoice] == "6" || placeHolders[userChoice] == "7"
                           || placeHolders[userChoice] == "8" || placeHolders[userChoice] == "9")
                        {
                            placeHolders[userChoice] = playerTwo;
                            ++turns;
                        }
                        else
                        {

                            placeHolders[userChoice] = playerTwo;
                            ++turns;
                        }
                    }
                    Board.TTTBoard(placeHolders);
                }

                //Win outcomes for player one
                if (placeHolders[1] == playerOne && placeHolders[2] == playerOne && placeHolders[3] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[4] == playerOne && placeHolders[5] == playerOne && placeHolders[6] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[7] == playerOne && placeHolders[8] == playerOne && placeHolders[9] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[1] == playerOne && placeHolders[4] == playerOne && placeHolders[7] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[2] == playerOne && placeHolders[5] == playerOne && placeHolders[8] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[4] == playerOne && placeHolders[6] == playerOne && placeHolders[9] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[1] == playerOne && placeHolders[5] == playerOne && placeHolders[9] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[3] == playerOne && placeHolders[5] == playerOne && placeHolders[7] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }

                //Win outcomes for player two
                if (placeHolders[1] == playerOne && placeHolders[2] == playerOne && placeHolders[3] == playerOne)
                {
                    win = true;
                    winner = "Player 2";
                }
                if (placeHolders[4] == playerTwo && placeHolders[5] == playerTwo && placeHolders[6] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                if (placeHolders[7] == playerTwo && placeHolders[8] == playerTwo && placeHolders[9] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                if (placeHolders[1] == playerTwo && placeHolders[4] == playerTwo && placeHolders[7] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                if (placeHolders[2] == playerTwo && placeHolders[5] == playerTwo && placeHolders[8] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                if (placeHolders[3] == playerTwo && placeHolders[6] == playerTwo && placeHolders[9] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                if (placeHolders[1] == playerTwo && placeHolders[5] == playerTwo && placeHolders[9] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }
                if (placeHolders[3] == playerTwo && placeHolders[5] == playerTwo && placeHolders[7] == playerTwo)
                {
                    win = true;
                    winner = "Player 2";
                }

                //Tie game outcome
                if (turns == 9)
                {
                    win = true;
                }
            } while (win == false);
            //Win game result
            if (winner != null)
            {
                Console.WriteLine("{0} wins!", winner);
            }
            //Tie game result
            else
            {
                Console.WriteLine("No winner. Try harder next time.");
            }
        }
    }
}
