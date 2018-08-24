using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Board
    {
        public int[,] GameBoard { get; set; }
        public Board()
        {
            GameBoard = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameBoard[i, j] = 0;
                }
            }
        }
        public bool PositionIsEmpty(int x, int y)
        {
            if (GameBoard[x,y] == GameCst.BlockEmpty)
            {
                return true;
            }
            return false;
        }

        public void PlaceBlock(int x , int y, bool BlockType)
        {
            if (PositionIsEmpty(x, y))
            {
                if (BlockType == GameCst.O)
                    GameBoard[x, y] = GameCst.BlockO;

                else
                    GameBoard[x, y] = GameCst.BlockX;
            }
        }
    }
}
