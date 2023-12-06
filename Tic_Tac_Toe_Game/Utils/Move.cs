using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game.Utils
{
    //Utility class used to easily store the 2 coordinates of a move.
    internal class Move
    {
        public int row;
        public int col;

        public Move(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
