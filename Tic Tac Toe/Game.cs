using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Game
    {
        public bool GameIsStarted { get; set; } = false;
        private Board GameBoard;
        Players p1;
        Players p2;


        public Game()
        {
            
        }

        public void StartGame()
        {
            GameIsStarted = true;

            GameBoard = new Board();

        }

        public void CheckWinner()
        {
            GameBoard.CheckWinner(p1, p2);
        }


        public void ChangeRoles()
        {
            p1.ChangeRole();
            p2.ChangeRole();
        }

        public void CreatePlayers(string name1, string name2)
        {
            p1 = new Players(name1, GameCst.O, ref GameBoard);
            p2 = new Players(name2, GameCst.X, ref GameBoard);
        }

        public void playersMove(bool turn, int x , int y)
        {
            if (turn = GameCst.O)
            {
                if (p1.turn == GameCst.O)
                {
                    p1.Move(x, y);
                }
                else
                {
                    p2.Move(x, y);
                }
            }
            if (turn = GameCst.X)
            {
                if (p1.turn == GameCst.X)
                {
                    p1.Move(x, y);
                }
                else
                {
                    p2.Move(x, y);
                }
            }
        }
        



    }
}
