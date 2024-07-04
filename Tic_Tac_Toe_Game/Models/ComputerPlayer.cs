using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Models.MoveTypes;

namespace Tic_Tac_Toe_Game.Models
{
    public class ComputerPlayer : Player
    {
        protected int timerDelay;
        public ComputerPlayer(IMoveType moveType, int turnOrder, int delay) : base(moveType, turnOrder) {
            active = false;
            timerDelay = delay;
        }
        
    }
}
