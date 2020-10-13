using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToeGame
    {
        public char[] board;
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
        public void Choice()
        {
            Console.WriteLine("Enter your choice.(X/0)");
            string userChoice = Console.ReadLine();
            char.ToUpper(userChoice[0]);
            string choice;
            switch (userChoice)
            {
                case "X":
                    choice = "You Chose: X";
                    break;
                case "0":
                    choice = "You Chose: 0";
                    break;
                default:
                    choice = "Invalid Choice";
                    break;
            }
            Console.WriteLine(choice);
            if (choice == "Invalid Choice")
                Choice();
        }
        public void ShowBoard()
        {
            Console.WriteLine(board[1] + "|" +board[2]+ "|" +board[3]);
            Console.WriteLine("_______ ");
            Console.WriteLine(board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("_______ ");
            Console.WriteLine(board[7] + "|" + board[8] + "|" + board[9]);
        }
    }
}

