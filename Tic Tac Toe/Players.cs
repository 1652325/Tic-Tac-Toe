using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Players
    {
        private string name;
        public bool turn { get; }
        private bool BlockType;
        public Board Board;

        public string Name
        {
            get { return name; }
        }

        public Players(string Name, bool BlockType, ref Board Board)
        {
            name = Name;
            this.BlockType = BlockType;
            this.Board = Board;
        }

        public void Move(int x, int y)
        {
            Board.PlaceBlock(x, y, this.BlockType);
        }

        public void ChangeRole()
        {
            BlockType = GameCst.O ? GameCst.X : GameCst.O;
        }
    }
}
