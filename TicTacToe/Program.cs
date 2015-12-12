using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string version = "v0.1";
            string player1, player2, winner;
            string A = "1";
            string B = "2";
            string C = "3";
            string D = "4";
            string E = "5";
            string F = "6";
            string G = "7";
            string H = "8";
            string I = "9";
            string next = "Press enter to continue...";
            bool play = false;

            Console.Title = "Tic Tac Toe";

            Console.WriteLine("**************************");
            Console.WriteLine("Welcome to Tic Tac Toe {0}", version);
            Console.WriteLine("Created by James");
            Console.WriteLine(next);
            Console.WriteLine("**************************");
            Console.ReadLine();


            Console.Clear();

                //player1 name setting
                    Console.WriteLine("**************************");
                    Console.WriteLine("Enter Player 1's name:");
                    player1 = Console.ReadLine();
                    Console.WriteLine(next);
                    Console.WriteLine("**************************");
                    Console.ReadLine();

                    //player2 name setting
                    Console.Clear();
                    Console.WriteLine("**************************");
                    Console.WriteLine("Enter Player 2's name:");
                    player2 = Console.ReadLine();
                    Console.WriteLine(next);
                    Console.WriteLine("**************************");
                    Console.ReadLine();
                    play = true;

               
                //actual game

                    string[,] board = new string[3, 3];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            board[i, j] = "n";
                        }
                    }


                    Console.Write(board[0,0]);
                    Console.Write(board[0, 1]);
                    Console.Write(board[0, 2]);

                    Console.WriteLine(board[1, 0]);
                    Console.Write(board[1, 1]);
                    Console.Write(board[1, 2]);

                    Console.WriteLine(board[2, 0]);
                    Console.Write(board[2, 1]);
                    Console.Write(board[2, 2]);

                    Console.ReadLine();
        }
    }
}