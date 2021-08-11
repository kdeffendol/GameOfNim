using System;
using GameOfNim;
using Xunit;

namespace GameOfNimTests
{
    public class StupidComputerTests
    {
        [Fact]
        public void StupidComputer_MakesLegalMove()
        {
            StupidComputer stupidComputer = new();
            Assert.InRange(stupidComputer.GetTurn(80), 1, 40);
        }
    }
}