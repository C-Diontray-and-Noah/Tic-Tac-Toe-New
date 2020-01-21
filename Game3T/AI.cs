using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3T
{
    class AI
    {
        public static void TTTAI(string[] placeHolders)
        {
            bool xOrO = false;
            bool win = false;
            bool acceptableResponse = false;
            string playerOne = null;
            string playerAI = null;
            string winner = null;
            int userChoice = 0;
            int turns = 0;
            int randomNumber = 0;
            Random random = new Random();

            do {
                //Takes the input of whether player one would like to play with Xs or Os, assigns the computer accordingly
                while (xOrO == false)
                {
                    Console.WriteLine("Player 1 : X or O?");
                    playerOne = Console.ReadLine();
                    playerOne = playerOne.ToUpper();
                    if (playerOne == "X")
                    {
                        Console.WriteLine("Player 1 is Xs!\nComputer is Os!");
                        playerAI = "O";
                        xOrO = true;
                        Board.TTTBoard(placeHolders);
                    }
                    else if (playerOne == "O")
                    {
                        Console.WriteLine("Player 1 is Os!\nComputer is Xs!");
                        playerAI = "X";
                        xOrO = true;
                        Board.TTTBoard(placeHolders);
                    }
                    else
                    {
                        Console.WriteLine("Not an option");
                    }
                }
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
                        //Evaluates whether the space chosen by the user is a real value available
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
                }
                //Win outcomes for player one
                if (placeHolders[1] == playerOne && placeHolders[2] == playerOne && placeHolders[3] == playerOne)
                {
                    winner = "Player 1";
                    win = true;
                }
                else if (placeHolders[4] == playerOne && placeHolders[5] == playerOne && placeHolders[6] == playerOne)
                {
                    winner = "Player 1";
                    win = true;
                }
                else if (placeHolders[7] == playerOne && placeHolders[8] == playerOne && placeHolders[9] == playerOne)
                {
                    winner = "Player 1";
                    win = true;
                }
                else if (placeHolders[1] == playerOne && placeHolders[4] == playerOne && placeHolders[7] == playerOne)
                {
                    winner = "Player 1";
                    win = true;
                }
                else if (placeHolders[2] == playerOne && placeHolders[5] == playerOne && placeHolders[8] == playerOne)
                {
                    winner = "Player 1";
                    win = true;
                }
                else if (placeHolders[3] == playerOne && placeHolders[6] == playerOne && placeHolders[9] == playerOne)
                {
                    winner = "Player 1";
                    win = true;
                }
                else if (placeHolders[1] == playerOne && placeHolders[5] == playerOne && placeHolders[9] == playerOne)
                {
                    winner = "Player 1";
                    win = true;
                }
                else if (placeHolders[3] == playerOne && placeHolders[5] == playerOne && placeHolders[7] == playerOne)
                {
                    winner = "Player 1";
                    win = true;
                }
                else
                {
                    //Tie game outcome
                    if (turns == 9)
                    {
                        win = true;
                    }
                    else
                    {
                        Board.TTTBoard(placeHolders);
                        //Runs computer's turn text and waits briefly
                        Console.WriteLine("Computer's turn : ");
                        System.Threading.Thread.Sleep(1000);
                        acceptableResponse = false;
                        //Runs the computer's choice based on logical moves to make and empty spaces. Does this for every possible user choice

                        //Responses to the choice of 1
                        if (userChoice == 1)
                        {
                            while (acceptableResponse == false)
                            {
                                randomNumber = random.Next(1, 3);
                                if (placeHolders[2] == playerOne && placeHolders[3] != playerAI && placeHolders[3] != playerOne || placeHolders[3] == playerOne && placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                    {
                                        placeHolders[2] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else if (randomNumber == 2 && placeHolders[3] != playerOne && placeHolders[3] != playerAI)
                                {
                                    placeHolders[3] = playerAI;
                                    acceptableResponse = true;
                                }
                                else if (placeHolders[4] == playerOne && placeHolders[7] != playerAI && placeHolders[7] != playerOne || placeHolders[7] == playerOne && placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                    {
                                        placeHolders[4] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[7] != playerOne && placeHolders[7] != playerAI)
                                    {
                                        placeHolders[7] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else
                                {
                                    //last ditch responses
                                    if (placeHolders[9] != playerOne && placeHolders[9] != playerAI)
                                    {
                                        placeHolders[9] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                    {
                                        placeHolders[5] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[8] != playerOne && placeHolders[8] != playerAI)
                                    {
                                        placeHolders[8] = playerAI;
                                        acceptableResponse = true;
                                    }

                                }
                            }
                        }
                        //Responses to the choice of 2
                        else if (userChoice == 2)
                        {
                            while (acceptableResponse == false)
                            {
                                randomNumber = random.Next(1, 3);
                                if (placeHolders[1] == playerOne && placeHolders[3] != playerAI && placeHolders[3] != playerOne || placeHolders[3] == playerOne && placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                    {
                                        placeHolders[1] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[3] != playerOne && placeHolders[3] != playerAI)
                                    {
                                        placeHolders[3] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else if (placeHolders[5] == playerOne && placeHolders[8] != playerAI && placeHolders[8] != playerOne || placeHolders[8] == playerOne && placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                    {
                                        placeHolders[5] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[8] != playerOne && placeHolders[8] != playerAI)
                                    {
                                        placeHolders[8] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else
                                {
                                    //last ditch responses
                                    if (placeHolders[7] != playerOne && placeHolders[7] != playerAI)
                                    {
                                        placeHolders[7] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[9] != playerOne && placeHolders[9] != playerAI)
                                    {
                                        placeHolders[9] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                    {
                                        placeHolders[4] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                            }
                        }
                        //Responses to the choice of 3
                        else if (userChoice == 3)
                        {
                            while (acceptableResponse == false)
                            {
                                randomNumber = random.Next(1, 3);
                                if (placeHolders[1] == playerOne && placeHolders[2] != playerAI && placeHolders[2] != playerOne || placeHolders[2] == playerOne && placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                    {
                                        placeHolders[1] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                    {
                                        placeHolders[2] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else if (placeHolders[6] == playerOne && placeHolders[9] != playerAI && placeHolders[9] != playerOne || placeHolders[9] == playerOne && placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[9] != playerOne && placeHolders[9] != playerAI)
                                    {
                                        placeHolders[9] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else
                                {
                                    //last ditch responses
                                    if (placeHolders[7] != playerOne && placeHolders[7] != playerAI)
                                    {
                                        placeHolders[7] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                    {
                                        placeHolders[5] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[8] != playerOne && placeHolders[8] != playerAI)
                                    {
                                        placeHolders[8] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                    {
                                        placeHolders[4] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                            }
                        }
                        //Responses to the choice of 4
                        else if (userChoice == 4)
                        {
                            while (acceptableResponse == false)
                            {
                                randomNumber = random.Next(1, 3);
                                if (placeHolders[5] == playerOne && placeHolders[6] != playerAI && placeHolders[6] != playerOne || placeHolders[6] == playerOne && placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                    {
                                        placeHolders[5] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else if (placeHolders[1] == playerOne && placeHolders[7] != playerAI && placeHolders[7] != playerOne || placeHolders[7] == playerOne && placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                    {
                                        placeHolders[1] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[7] != playerOne && placeHolders[7] != playerAI)
                                    {
                                        placeHolders[7] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else
                                {
                                    //last ditch responses
                                    if (placeHolders[3] != playerOne && placeHolders[3] != playerAI)
                                    {
                                        placeHolders[3] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[9] != playerOne && placeHolders[9] != playerAI)
                                    {
                                        placeHolders[9] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[8] != playerOne && placeHolders[8] != playerAI)
                                    {
                                        placeHolders[9] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                    {
                                        placeHolders[2] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                            }
                        }
                        //Responses to the choice of 5
                        else if (userChoice == 5)
                        {
                            while (acceptableResponse == false)
                            {
                                randomNumber = random.Next(1, 3);
                                if (placeHolders[3] == playerOne && placeHolders[4] != playerAI && placeHolders[4] != playerOne || placeHolders[4] == playerOne && placeHolders[3] != playerOne && placeHolders[3] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[3] != playerOne && placeHolders[3] != playerAI)
                                    {
                                        placeHolders[3] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                    {
                                        placeHolders[4] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else if (placeHolders[2] == playerOne && placeHolders[8] != playerAI && placeHolders[8] != playerOne || placeHolders[8] == playerOne && placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                    {
                                        placeHolders[2] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[8] != playerOne && placeHolders[8] != playerAI)
                                    {
                                        placeHolders[8] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else
                                {
                                    //last ditch responses
                                    if (placeHolders[7] != playerOne && placeHolders[7] != playerAI)
                                    {
                                        placeHolders[7] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[9] != playerOne && placeHolders[9] != playerAI)
                                    {
                                        placeHolders[9] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                    {
                                        placeHolders[1] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                            }
                        }
                        //Responses to the choice of 6
                        else if (userChoice == 6)
                        {
                            while (acceptableResponse == false)
                            {
                                randomNumber = random.Next(1, 3);
                                if (placeHolders[4] == playerOne && placeHolders[5] != playerAI && placeHolders[5] != playerOne || placeHolders[5] == playerOne && placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                    {
                                        placeHolders[4] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                    {
                                        placeHolders[5] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else if (placeHolders[3] == playerOne && placeHolders[9] != playerAI && placeHolders[9] != playerOne || placeHolders[9] == playerOne && placeHolders[3] != playerOne && placeHolders[3] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[3] != playerOne && placeHolders[3] != playerAI)
                                    {
                                        placeHolders[3] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[9] != playerOne && placeHolders[9] != playerAI)
                                    {
                                        placeHolders[9] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else
                                {
                                    //last ditch responses
                                    if (placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                    {
                                        placeHolders[1] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[7] != playerOne && placeHolders[7] != playerAI)
                                    {
                                        placeHolders[7] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                    {
                                        placeHolders[2] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                            }
                        }
                        //Responses to the choice of 7
                        else if (userChoice == 7)
                        {
                            while (acceptableResponse == false)
                            {
                                randomNumber = random.Next(1, 3);
                                if (placeHolders[1] == playerOne && placeHolders[4] != playerAI && placeHolders[4] != playerOne || placeHolders[4] == playerOne && placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                    {
                                        placeHolders[1] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                    {
                                        placeHolders[4] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else if (placeHolders[8] == playerOne && placeHolders[9] != playerAI && placeHolders[9] != playerOne || placeHolders[9] == playerOne && placeHolders[8] != playerOne && placeHolders[8] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[8] != playerOne && placeHolders[8] != playerAI)
                                    {
                                        placeHolders[8] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[9] != playerOne && placeHolders[9] != playerAI)
                                    {
                                        placeHolders[9] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else
                                {
                                    //last ditch responses
                                    if (placeHolders[3] != playerOne || placeHolders[3] != playerAI)
                                    {
                                        placeHolders[3] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                    {
                                        placeHolders[2] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                    {
                                        placeHolders[5] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                            }
                        }
                        //Responses to the choice of 8
                        else if (userChoice == 8)
                        {
                            while (acceptableResponse == false)
                            {
                                randomNumber = random.Next(1, 3);
                                if (placeHolders[7] == playerOne && placeHolders[9] != playerAI && placeHolders[9] != playerOne || placeHolders[9] == playerOne && placeHolders[7] != playerOne && placeHolders[7] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[7] != playerOne && placeHolders[7] != playerAI)
                                    {
                                        placeHolders[7] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[9] != playerOne && placeHolders[9] != playerAI)
                                    {
                                        placeHolders[9] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else if (placeHolders[2] == playerOne && placeHolders[5] != playerAI && placeHolders[5] != playerOne || placeHolders[5] == playerOne && placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                    {
                                        placeHolders[2] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[8] != playerOne && placeHolders[8] != playerAI)
                                    {
                                        placeHolders[5] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else
                                {
                                    //last ditch responses
                                    if (placeHolders[3] != playerOne && placeHolders[3] != playerAI)
                                    {
                                        placeHolders[3] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                    {
                                        placeHolders[4] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                    {
                                        placeHolders[1] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                            }
                        }
                        //Responses to the choice of 9
                        else if (userChoice == 9)
                        {
                            while (acceptableResponse == false)
                            {
                                randomNumber = random.Next(1, 3);
                                if (placeHolders[6] == playerOne && placeHolders[7] != playerAI && placeHolders[7] != playerOne || placeHolders[7] == playerOne && placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[7] != playerOne && placeHolders[7] != playerAI)
                                    {
                                        placeHolders[7] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else if (placeHolders[3] == playerOne && placeHolders[6] != playerAI && placeHolders[6] != playerOne || placeHolders[6] == playerOne && placeHolders[3] != playerOne && placeHolders[3] != playerAI)
                                {
                                    if (randomNumber == 1 && placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                    {
                                        placeHolders[3] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (randomNumber == 2 && placeHolders[6] != playerOne && placeHolders[6] != playerAI)
                                    {
                                        placeHolders[6] = playerAI;
                                        acceptableResponse = true;
                                    }
                                }
                                else
                                {
                                    //last ditch responses
                                    if (placeHolders[1] != playerOne && placeHolders[1] != playerAI)
                                    {
                                        placeHolders[1] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[2] != playerOne && placeHolders[2] != playerAI)
                                    {
                                        placeHolders[2] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[4] != playerOne && placeHolders[4] != playerAI)
                                    {
                                        placeHolders[4] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[5] != playerOne && placeHolders[5] != playerAI)
                                    {
                                        placeHolders[5] = playerAI;
                                        acceptableResponse = true;
                                    }
                                    else if (placeHolders[8] != playerOne && placeHolders[8] != playerAI)
                                    {
                                        placeHolders[8] = playerAI;
                                        acceptableResponse = true;
                                    }

                                }
                            }
                        }





                        //Win outcomes for the computer
                        if (placeHolders[1] == playerAI && placeHolders[2] == playerAI && placeHolders[3] == playerAI)
                        {
                            winner = "Computer";
                            win = true;
                        }
                        else if (placeHolders[3] == playerAI && placeHolders[4] == playerAI && placeHolders[5] == playerAI)
                        {
                            winner = "Computer";
                            win = true;
                        }
                        else if (placeHolders[6] == playerAI && placeHolders[7] == playerAI && placeHolders[8] == playerAI)
                        {
                            winner = "Computer";
                            win = true;
                        }
                        else if (placeHolders[0] == playerAI && placeHolders[3] == playerAI && placeHolders[6] == playerAI)
                        {
                            winner = "Computer";
                            win = true;
                        }
                        else if (placeHolders[1] == playerAI && placeHolders[4] == playerAI && placeHolders[7] == playerAI)
                        {
                            winner = "Computer";
                            win = true;
                        }
                        else if (placeHolders[2] == playerAI && placeHolders[5] == playerAI && placeHolders[8] == playerAI)
                        {
                            winner = "Computer";
                            win = true;
                        }
                        else if (placeHolders[2] == playerAI && placeHolders[4] == playerAI && placeHolders[6] == playerAI)
                        {
                            winner = "Computer";
                            win = true;
                        }
                        else if (placeHolders[0] == playerAI && placeHolders[4] == playerAI && placeHolders[8] == playerAI)
                        {
                            winner = "Computer";
                            win = true;
                        }
                        else
                        {
                            ++turns;
                        }
                    }
                }
                Board.TTTBoard(placeHolders);
            } while (win == false);
            //Win game result
            if (winner != null)
            {
                Console.WriteLine("{0} wins!", winner);
                xOrO = true;
            }
            //Tie game result
            else
            {
                Console.WriteLine("No winner. Try harder next time.");
            }
        }

    } 
            
} 
