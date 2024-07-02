using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Utils;

namespace Tic_Tac_Toe_Game.Models.MoveTypes
{
    public abstract class AI_MoveType : IMoveType
    {
        public static Random rand = new Random();
        public abstract Move getMove(int[,] board, int turn);

        public abstract string getType();

        public abstract int getID();

        public Move[] possibleMoves(int[,] board, int turn)
        {
            if (turn > 9) {
                return null;
            }
            Move[] pMoves = new Move[board.Length - turn + 1]; //Turn starts at 1.
            int counter = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 0)
                    {
                        pMoves[counter++] = new Move(i, j);
                    }
                    if (counter == pMoves.Length)
                    {
                        return pMoves;
                    }
                }
            }
            return pMoves;
        }
    }
}
