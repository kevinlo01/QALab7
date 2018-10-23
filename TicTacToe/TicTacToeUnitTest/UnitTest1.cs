using TicTacToe;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToe.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void Has9ActiveFields()
        {
            TicTacToe controller = new TicTacToe();
            int[,] boardArray = controller.CreateBoard();
            int activeField = 0;
            activeField = boardArray.Length/2;
            Assert.AreEqual(9, activeField);
        }

        [TestMethod()]
        public void CurrentPlayerIsXTest()
        {
            TicTacToe controller = new TicTacToe();
            string player = controller.CurrentPlayer(3, "x", "o");
            Assert.AreEqual("x", player);
        }

        [TestMethod()]
        public void CurrentPlayerIsOTest()
        {
            TicTacToe controller = new TicTacToe();
            string player = controller.CurrentPlayer(2, "x", "o");
            Assert.AreEqual("o", player);
        }

        [TestMethod()]
        public void CurrentPlayerPlaceXOnBoard()
        {
            TicTacToe controller = new TicTacToe();
            int[,] boardArray = controller.CreateBoard();
            controller.MakeMove("x", "o", "x", boardArray, 0);
            Assert.AreEqual(1, boardArray[0, 1]);

        }

        [TestMethod()]
        public void CurrentPlayerPlaceOOnBoard()
        {
            TicTacToe controller = new TicTacToe();
            int[,] boardArray = controller.CreateBoard();
            controller.MakeMove("x", "o", "o", boardArray, 0);
            Assert.AreEqual(2, boardArray[0, 1]);

        }

        [TestMethod()]
        public void PlacementIsUnoccupied()
        {
            TicTacToe controller = new TicTacToe();
            int[,] boardArray = controller.CreateBoard();
            Boolean inUse = controller.SpaceInUse(boardArray, 1);
            Assert.AreEqual(true, inUse);
        }
    }
}

