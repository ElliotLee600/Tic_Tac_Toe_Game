using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Utils;

namespace Tic_Tac_Toe_Game.Models.MoveTypes
{
    public class BasicAI_MoveType : AI_MoveType
    {

        public const int BASIC_ID = 0;
        public BasicAI_MoveType() { }

        public override string getType()
        {
            return "Easy";
        }

        public override int getID()
        {
            return BASIC_ID;
        }

        public override Move getMove(int[,] board, int turn)
        {
            if (turn > 9) {
                return null; //there should only be up to 9 turns
            }
            //Easy simply picks a random valid move.
            return base.possibleMoves(board, turn)[AI_MoveType.rand.Next(0, board.Length - turn + 1)];
        }

    }
}
