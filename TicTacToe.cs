using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace TicTacToe
{
    internal class Program
    {
        public static void PrintBlocks(string[] blocks) //method to print game GUI
        {
            //print game GUI
            Console.WriteLine(" "); //prints first line
            
            // prints second line 
            if (blocks[0] == " " && blocks[1] == " " && blocks[2] == " ")
            {
                // if all 3 values are empty
                Console.WriteLine(" " + "1" + " | " + "2" + " | " + "3");
            }
            else if (blocks[0] == " " && blocks[1] == " ")
            {
                // if first 2 values are empty
                Console.WriteLine(" " + "1" + " | " + "2" + " | " + blocks[2]);
            }
            else if (blocks[1] == " " && blocks[2] == " ")
            {
                // if last 2 values are empty
                Console.WriteLine(" " + blocks[0] + " | " + "2" + " | " + "3");
            }
            else if (blocks[0] == " " && blocks[2] == " ")
            {
                // if first and last values are empty
                Console.WriteLine(" " + "1" + " | " + blocks[1] + " | " + "3");
            }
            else if (blocks[0] == " ")
            {
                // if first value is empty
                Console.WriteLine(" " + "1" + " | " + blocks[1] + " | " + blocks[2]);
            }
            else if (blocks[1] == " ")
            {
                // if second value is empty
                Console.WriteLine(" " + blocks[0] + " | " + "2" + " | " + blocks[2]);
            }
            else if (blocks[2] == " ")
            {
                // if last value is empty
                Console.WriteLine(" " + blocks[0] + " | " + blocks[1] + " | " + "3");
            }
            else
            {
                // if all lines are full
                Console.WriteLine(" " + blocks[0] + " | " + blocks[1] + " | " + blocks[2]);
            }

            Console.WriteLine("---+---+---"); //prints third line
            
            //prints fourth line 
            if (blocks[3] == " " && blocks[4] == " " && blocks[5] == " ")
            {
                // if all 3 values are empty
                Console.WriteLine(" " + "4" + " | " + "5" + " | " + "6");
            }
            else if (blocks[3] == " " && blocks[4] == " ")
            {
                // if first 2 values are empty
                Console.WriteLine(" " + "4" + " | " + "5" + " | " + blocks[5]);
            }
            else if (blocks[4] == " " && blocks[5] == " ")
            {
                // if last 2 values are empty
                Console.WriteLine(" " + blocks[3] + " | " + "5" + " | " + "6");
            }
            else if (blocks[3] == " " && blocks[5] == " ")
            {
                // if first and last values are empty
                Console.WriteLine(" " + "4" + " | " + blocks[4] + " | " + "6");
            }
            else if (blocks[3] == " ")
            {
                // if first value is empty
                Console.WriteLine(" " + "4" + " | " + blocks[4] + " | " + blocks[5]);
            }
            else if (blocks[4] == " ")
            {
                // if second value is empty
                Console.WriteLine(" " + blocks[3] + " | " + "5" + " | " + blocks[5]);
            }
            else if (blocks[5] == " ")
            {
                // if last value is empty
                Console.WriteLine(" " + blocks[3] + " | " + blocks[4] + " | " + "6");
            }
            else
            {
                // if all lines are full
                Console.WriteLine(" " + blocks[3] + " | " + blocks[4] + " | " + blocks[5]);
            }
            Console.WriteLine("---+---+---"); //prints fifth line

            // prints sixth line 
            if (blocks[6] == " " && blocks[7] == " " && blocks[8] == " ")
            {
                // if all 3 values are empty
                Console.WriteLine(" " + "7" + " | " + "8" + " | " + "9");
            }
            else if (blocks[6] == " " && blocks[7] == " ")
            {
                // if first 2 values are empty
                Console.WriteLine(" " + "7" + " | " + "8" + " | " + blocks[8]);
            }
            else if (blocks[7] == " " && blocks[8] == " ")
            {
                // if last 2 values are empty
                Console.WriteLine(" " + blocks[6] + " | " + "8" + " | " + "9");
            }
            else if (blocks[6] == " " && blocks[8] == " ")
            {
                // if first and last values are empty
                Console.WriteLine(" " + "7" + " | " + blocks[7] + " | " + "9");
            }
            else if (blocks[6] == " ")
            {
                // if first value is empty
                Console.WriteLine(" " + "7" + " | " + blocks[7] + " | " + blocks[8]);
            }
            else if (blocks[7] == " ")
            {
                // if second value is empty
                Console.WriteLine(" " + blocks[6] + " | " + "8" + " | " + blocks[8]);
            }
            else if (blocks[8] == " ")
            {
                // if last value is empty
                Console.WriteLine(" " + blocks[6] + " | " + blocks[7] + " | " + "9");
            }
            else
            {
                // if all lines are full
                Console.WriteLine(" " + blocks[6] + " | " + blocks[7] + " | " + blocks[8]);
            }

            Console.WriteLine(" "); 
        }
        static void Main(string[] args)
        {
            // declare values
            bool gameDone = false;
            bool turnDone = false;
            int currentTurn = 1;
            string player1Name;
            string player2Name;
            int choose;
            string chooseFirst;
            float playerWinner = 0f;
            // game values

            string[] blocks = { " ", " ", " ", " ", " ", " ", " ", " ", " "};

            // b1 | b2 | b3
            // ---+----+---
            // b4 | b5 | b6
            // ---+----+---
            // b7 | b8 | b9

            // get player names
            Console.WriteLine("Welcome to TIC TAC TOE!");
            Console.WriteLine(" ");
            Console.Write("Please entre player one's name(X): ");
            player1Name = Console.ReadLine();
            Console.Write("Please entre player two's name(O): ");
            player2Name = Console.ReadLine();

            while (gameDone == false) // main game part
            {

                // print game GUI
                PrintBlocks(blocks); //call method

                if (currentTurn == 1) // player one playes
                {
                    turnDone = false;
                    while (turnDone == false)  // player chooses block and block is inserted
                    {
                        Console.WriteLine(player1Name + " choose your block!");
                        chooseFirst = Console.ReadLine();
                        choose = Convert.ToInt32(chooseFirst);
                        if (blocks[choose - 1] == " ")
                        {

                            Console.WriteLine("X inserted into block " + choose + " !");
                            Console.WriteLine(" ");
                            choose = choose - 1;
                            blocks[choose] = "X";
                            turnDone = true;
                        }
                        else
                        {
                            Console.WriteLine("This location is altready occupied!");
                            Console.WriteLine(" ");
                        }


                    }
                }
                else if (currentTurn == 2)
                {
                    turnDone = false;
                    while (turnDone == false)  // player chooses block and block is inserted
                    {
                        Console.WriteLine(player2Name + " choose your block!");
                        chooseFirst = Console.ReadLine();
                        choose = Convert.ToInt32(chooseFirst);
                        if (blocks[choose - 1] == " ")
                        {

                            Console.WriteLine("X inserted into block " + choose + " !");
                            Console.WriteLine(" ");
                            choose = choose - 1;
                            blocks[choose] = "O";
                            turnDone = true;
                        }
                        else
                        {
                            Console.WriteLine("This location is altready occupied!");
                            Console.WriteLine(" ");
                        }
                    }

                }
                
                if (currentTurn == 1) // change turns
                {
                    currentTurn = 2;
                }
                else
                {
                    currentTurn = 1;
                }

                // finding out if sombody won

                // first check to check if player 1(X) won

                // checks horizontal lines
                if (blocks[0] == "X") // check if first horizontal line is all X's
                {
                    if (blocks[1] == "X")
                    {
                        if (blocks[2] == "X")
                        {
                            playerWinner = 1f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[3] == "X") // check if second horizontal line is all X's
                {
                    if (blocks[4] == "X")
                    {
                        if (blocks[5] == "X")
                        {
                            playerWinner = 1f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[6] == "X") // check if last horizontal line is all X's
                {
                    if (blocks[7] == "X")
                    {
                        if (blocks[8] == "X")
                        {
                            playerWinner = 1f;
                            gameDone = true;
                        }
                    }
                }

                //checks vertical lines
                if (blocks[0] == "X") //check if first vertical line is all X's
                {
                    if (blocks[3] == "X")
                    {
                        if (blocks[6] == "X")
                        {
                            playerWinner = 1f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[1] == "X") //check if second vertical line is all X's
                {
                    if (blocks[4] == "X")
                    {
                        if (blocks[7] == "X")
                        {
                            playerWinner = 1f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[2] == "X") //check if last vertical line is all X's
                {
                    if (blocks[5] == "X")
                    {
                        if (blocks[8] == "X")
                        {
                            playerWinner = 1f;
                            gameDone = true;
                        }
                    }
                }

                // check if sideways lines 
                if (blocks[0] == "X") //check if left to right line is all X's
                {
                    if (blocks[4] == "X")
                    {
                        if (blocks[8] == "X")
                        {
                            playerWinner = 1f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[2] == "X") //check if right to left line is all X's
                {
                    if (blocks[4] == "X")
                    {
                        if (blocks[5] == "X")
                        {
                            playerWinner = 1f;
                            gameDone = true;
                        }
                    }
                }

                // first check to check if player 2(O) won

                // checks horizontal lines
                if (blocks[0] == "O") // check if first horizontal line is all O's
                {
                    if (blocks[1] == "O")
                    {
                        if (blocks[2] == "O")
                        {
                            playerWinner = 2f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[3] == "O") // check if second horizontal line is all O's
                {
                    if (blocks[4] == "O")
                    {
                        if (blocks[5] == "O")
                        {
                            playerWinner = 2f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[6] == "O") // check if last horizontal line is all O's
                {
                    if (blocks[7] == "O")
                    {
                        if (blocks[8] == "O")
                        {
                            playerWinner = 2f;
                            gameDone = true;
                        }
                    }
                }

                //checks vertical lines
                if (blocks[0] == "O") //check if first vertical line is all O's
                {
                    if (blocks[3] == "O")
                    {
                        if (blocks[6] == "O")
                        {
                            playerWinner = 2f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[1] == "O") //check if second vertical line is all O's
                {
                    if (blocks[4] == "O")
                    {
                        if (blocks[7] == "O")
                        {
                            playerWinner = 2f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[2] == "O") //check if last vertical line is all O's
                {
                    if (blocks[5] == "O")
                    {
                        if (blocks[8] == "O")
                        {
                            playerWinner = 2f;
                            gameDone = true;
                        }
                    }
                }

                // check if sideways lines
                if (blocks[0] == "O") //check if left to right line is all O's
                {
                    if (blocks[4] == "O")
                    {
                        if (blocks[8] == "O")
                        {
                            playerWinner = 2f;
                            gameDone = true;
                        }
                    }
                }
                if (blocks[2] == "O") //check if right to left line is all O's
                {
                    if (blocks[4] == "O")
                    {
                        if (blocks[5] == "O")
                        {
                            playerWinner = 2f;
                            gameDone = true;
                        }
                    }
                }

                // checks if all lines all full and draw happens
                
                if (playerWinner == 0f) //makes sure nobody won
                {
                    if (blocks[0] != " ")
                    {
                        if (blocks[1] != " ")
                        {
                            if (blocks[2] != " ")
                            {
                                if (blocks[3] != " ")
                                {
                                    if (blocks[4] != " ")
                                    {
                                        if (blocks[5] != " ")
                                        {
                                            if (blocks[6] != " ")
                                            {
                                                if (blocks[7] != " ")
                                                {
                                                    if (blocks[8] != " ")
                                                    {
                                                        playerWinner = 0f;
                                                        gameDone = true;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            PrintBlocks(blocks); //call method to print GUI
            // checks who won if anyone did
            if (playerWinner == 1f) //player one won
            {
                Console.WriteLine("Congratulations " + player1Name + " won!");
            }
            else if (playerWinner == 2f) //player two won
            {
                Console.WriteLine("Congratulations " + player2Name + " won!");
            }
            else if (playerWinner == 0f) //nobody won (draw)
            {
                Console.WriteLine("It's a draw nobody won!");
            }
            
        }
    }
}
