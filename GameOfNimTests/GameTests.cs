using System;
using GameOfNim;
using Xunit;

namespace GameOfNimTests
{
    public class GameTests
    {
        [Fact]
        public void WhenCreated_ShouldHavePileSize()
        {
            GameBoard game = new();
            Assert.InRange(game.MarblesRemaining, 10, 100);
        }

        [Fact]
        public void WhenCreated_ShouldHaveComputerMode()
        {
            GameBoard game = new();
            Assert.InRange(game.ComputerMode, 0, 1);
        }

        [Fact]
        public void WhenCreated_ShouldHaveFirstTurn()
        {
            GameBoard game = new();
            Assert.InRange(game.FirstTurn, 0, 1);
        }

        [Fact]
        public void IsValidMove()
        {

        }
    }
}
