using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToeGame
    {
        public char[] board;
        public enum Player { USER, COMPUTER };
        public const int HEAD = 1;
        public TicTacToeGame()
        {
            board = new char[10];
        }
        public void CreateBoard()
        {
         
            for (int position = 1; position < board.Length; position++)
            {
                board[position] = ' ';
            }
        }

        public char Choice()
        {
            Console.WriteLine("Enter your choice. \nX \n0");
            char userChoice = Convert.ToChar(Console.ReadLine());
            char.ToUpper(userChoice);
            string choice;
            switch (userChoice)
            {
                case 'X':
                    choice = "You Chose: X";
                    break;
                case '0':
                    choice = "You Chose: 0";
                    break;
                default:
                    choice = "Invalid Choice";
                    break;
            }
            Console.WriteLine(choice);
            if (choice == "Invalid Choice")
                Choice();
            return userChoice;
        }
        public void ShowBoard()
        {
            Console.WriteLine(board[1] + "|" +board[2]+ "|" +board[3]);
            Console.WriteLine("_______ ");
            Console.WriteLine(board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("_______ ");
            Console.WriteLine(board[7] + "|" + board[8] + "|" + board[9]);
        }
        public bool PositionCheck(int position)
        {
            if (board[position] == ' ')
                return true;
            else
            {
                Console.WriteLine("Position already occupied");
                return false;
            }
        }
        public void PlayerMovement(char choice)
        {
            Console.WriteLine("Select the position you want to play on");
            int userChoice = int.Parse(Console.ReadLine());
            bool emptyPosition = PositionCheck(userChoice);
            if (emptyPosition == true)
            {
                board[userChoice] = choice;
                ShowBoard();
            }
            else
            {
                Console.WriteLine("Try Again");
                PlayerMovement(choice);
            }
        }
        public Player Toss()
        {
            Random random = new Random();
            int toss = random.Next(1, 2);
            if (toss == HEAD)
            {
                Console.WriteLine("User will begin");
                return Player.USER;
            }
            else
            {
                Console.WriteLine("Computer will begin");
                return Player.COMPUTER;
            }
        }
    }
}

