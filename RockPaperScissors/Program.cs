﻿using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU;
            int randomInt;
            
            bool playAgain = true;

            while (playAgain == true)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {



                    Console.WriteLine("Choose between ROCK, PAPER, or SCISSORS:             ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();
                    //random # between 1 and 4
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if(inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("COMPUTER WINS!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("COMPUTER WINS!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("COMPUTER WINS!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            break;
                    }
                    Console.WriteLine($"SCORES: \t PLAYER: \t{scorePlayer}\tCPU: \t{scoreCPU}");
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player Wins!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Computer wins!");
                }
               
                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
