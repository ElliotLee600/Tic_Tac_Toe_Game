using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game.Utils
{
    //Utility class used to easily store the 2 coordinates of a move.
    public class Move
    {
        public int row;
        public int col;

        public Move(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

       

        public override bool Equals(object? obj)
        {
            if (obj is Move) {
                Move otherMove = (Move)obj;
                if (otherMove.row == this.row && otherMove.col == this.col)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
