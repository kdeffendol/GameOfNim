using System;
namespace GameOfNim
{
    public class GameBoard
    {
        public int MarblesRemaining { get; private set; }
        public int ComputerMode { get; private set; } // 0 = smart, 1 = stupid
        public int FirstTurn { get; private set; } //0 - computer first, 1 - user first

        public GameBoard()
        {
            var rand = new Random();
            MarblesRemaining = rand.Next(10, 100);
            ComputerMode = rand.Next(0, 1);
            FirstTurn = rand.Next(0, 1);
        }
        
    }
}
