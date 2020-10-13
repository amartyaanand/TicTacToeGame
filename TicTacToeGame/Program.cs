using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
            game.Choice();
            game.ShowBoard();
        }
    }
}
