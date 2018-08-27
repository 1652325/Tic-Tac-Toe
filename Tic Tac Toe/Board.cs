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
            int countP1FirstDiagonal = 0;
            int countP2FirstDiagonal = 0;
            int countP1SecondDiagonal = 0;
            int countP2SecondDiagonal = 0;
            for (int i = 0; i < 3; i++)
            {
                countP1 = 0;
                countP2 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (GameBoard[i, j] == GameCst.BlockO)
                        countP1++;

                    if (GameBoard[i, j] == GameCst.BlockX)
                        countP2++;
                    if (i == j && GameBoard[i, j] == GameCst.BlockO)
                        countP1FirstDiagonal++;

                    if (i == j && GameBoard[i, j] == GameCst.BlockX)
                        countP2FirstDiagonal++;
                    if (i + j == 2 && GameBoard[i, j] == GameCst.BlockO)
                        countP1SecondDiagonal++;
                    if (i + j == 2 && GameBoard[i, j] == GameCst.BlockX)
                        countP2SecondDiagonal++;

                    if (countP1 == 3)
                    {
                        MessageBox.Show(p1.Name + " à gagné");
                        return true;
                    }
                    if (countP2 == 3)
                    {
                        MessageBox.Show(p2.Name + " à gagné");
                        return true;
                    }
                    if (countP1FirstDiagonal == 3)
                    {
                        MessageBox.Show(p1.Name + " à gagné");
                        return true;
                    }
                    if (countP2FirstDiagonal == 3)
                    {
                        MessageBox.Show(p2.Name + " à gagné");
                        return true;
                    }
                    if (countP1SecondDiagonal == 3)
                    {
                        MessageBox.Show(p1.Name + " à gagné");
                        return true;
                    }
                    if (countP2SecondDiagonal == 3)
                    {
                        MessageBox.Show(p2.Name + " à gagné");
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
