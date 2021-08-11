using System;
namespace GameOfNim
{
    public class StupidComputer : IPlayer
    {
        public StupidComputer()
        {
        }

        public int GetTurn(int marblesRemaining)
        {
            Random r = new();
            return r.Next(1, marblesRemaining / 2);
        }
    }
}
