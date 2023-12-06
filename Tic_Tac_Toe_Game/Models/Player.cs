using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Models.MoveTypes;

namespace Tic_Tac_Toe_Game.Models
{
    internal class Player
    {
        protected IMoveType moveType;

        public Player(IMoveType moveType)
        {
            this.moveType = moveType;
        }

        public Player() {
            moveType = null;
        }
    }
}
