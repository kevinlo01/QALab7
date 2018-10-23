using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe
    {
        public int[,] CreateBoard()
        {
            //2 Dimensional Array, First Column is position of board , 0| 1| 2 
            //Second Column is 0 = empty, 1 = x, 2 = o                 3| 4| 5 
            //                                                         6| 7| 8
            int[,] boardArray = new int[9, 2] {
                {0, 0}, {1, 0}, {2, 0}, {3, 0}, {4, 0}, {5, 0}, {6, 0}, {7, 0}, {8, 0}
            };
            return boardArray;
        }

        public string CurrentPlayer(int turn, string playerOne, string playerTwo)
        {
            //Assuming Player One Always Goes First Because X always goes First and 
            //Player One is Always X and Turn 1 is First turn
            if (turn % 2 == 0)
            {
                return playerTwo;
            }
            else
            {
                return playerOne;
            }
        }

        public string ChangePlayer(string playerOne, string playerTwo, string currentPlayer)
        {
            if (currentPlayer == playerOne)
            {
                return playerTwo;
            }
            else
            {
                return playerOne;
            }
        }
        public void MakeMove(string playerOne, string playerTwo, string currentPlayer, int[,] boardArray, int position)
        {
            //Position is ordered like this                0| 1| 2
            //Assume Player One is x and Player Two is o   3| 4| 5
            //x = 1 and o = 2                              6| 7| 8
            //Would call SpaceInUse Method before MakeMove to check if it was empty 
            if (currentPlayer == playerOne)
            {
                for (int j = 0; j < boardArray.GetLength(1); j++)
                {
                    boardArray[position, j] = 1;
                }
            }
            else
            {
                for (int j = 0; j < boardArray.GetLength(1); j++)
                {
                    boardArray[position, j] = 2;
                }
            }
        }
        public Boolean SpaceInUse(int[,] boardArray, int position)
        {
            for (int j = 0; j < boardArray.GetLength(1); j++)
            {
                if (boardArray[position, j] != 0)
                    {
                        return true;
                    }
                else
                    {
                        return false;
                    }
            }
            return false;
        }

    }
}
