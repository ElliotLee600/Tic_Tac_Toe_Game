using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Models.MoveTypes;
using Tic_Tac_Toe_Game.Utils;

namespace Tic_Tac_Toe_Game.Models
{
    public class Player : ISubscriber
    {
        protected IMoveType moveType;
        protected int turnOrder; //1 means going first, 0 means going 2nd.
        protected Boolean active = true;

        public Player(IMoveType moveType, int turnOrder)
        {
            this.moveType = moveType;
            this.turnOrder = turnOrder;
        }

        public Player() {
            moveType = null;
            turnOrder = 0;
        }

        public void update() {
            //TODO: Implement
            return;
        }

        public Boolean isActive() {
            return active;
        }

        public void setActive(bool active) {
            return;
        }

        public void setMoveType(IMoveType moveType) {
            this.moveType = moveType;
        }

        public Move getMove(int[,] board, int turn) {
            return moveType.getMove(board, turn);
        }
    }
}
