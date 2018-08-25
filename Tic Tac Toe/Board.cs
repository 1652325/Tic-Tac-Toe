using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public bool CheckWinner(Players p1, Players p2)
        {
            int countP1 = 0;
            int countP2 = 0;

            for (int i = 0; i < 3; i++)
            {
                countP1 = 0;
                countP2 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (GameBoard[i, j] == GameCst.BlockX)
                        countP1++;

                    if (GameBoard[i, j] == GameCst.BlockO)
                        countP2++;

                    if (countP1 == 3)
                    {
                        MessageBox.Show(p1.Name + "à gagné");
                        return true;
                    }
                    if (countP2 == 3)
                    {
                        MessageBox.Show(p2.Name + "à gagné");
                        return true;
                    }
                }
            }
            countP1 = 0;
            countP2 = 0;

            for (int i = 0; i < 3; i++)
            {
                countP1 = 0;
                countP2 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (i == j && GameBoard[i, j] == GameCst.BlockX)
                        countP1++;

                    if (i == j && GameBoard[i, j] == GameCst.BlockO)
                        countP2++;

                    if (countP1 == 3)
                    {
                        MessageBox.Show(p1.Name + "à gagné");
                        return true;
                    }
                    if (countP2 == 3)
                    {
                        MessageBox.Show(p2.Name + "à gagné");
                        return true;
                    }
                }
            }
            return false;

        }
    }
}
