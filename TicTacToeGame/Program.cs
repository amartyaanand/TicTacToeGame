using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
            char choice = game.Choice();
            game.ShowBoard();
            game.PlayerMovement(choice);
        }
    }
}
