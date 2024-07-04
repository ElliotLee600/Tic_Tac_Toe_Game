using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Utils;

namespace Tic_Tac_Toe_Game.Models.MoveTypes
{
    public class MediumAI_MoveType : AI_MoveType
    {
        public const int MEDIUM_ID = 1;
        public MediumAI_MoveType() { }
        public override Move getMove(int[,] board, int turn)
        {
            if (turn > 9) {
                return null; //the 9th turn should be the last
            }
            if (turn <= 2)
            {
                //Pick center square if possible, otherwise pick a random square in early turns
                return board[1, 1] == 0 ? new Move(1, 1)
                    : base.possibleMoves(board, turn)[AI_MoveType.rand.Next(0, board.Length - turn)];
            }
            Move gMove = CheckForTwo(board);
            //Pick a line/diagonal/col with 2 of the opponent's shape, otherwise pick a random square
            return gMove != null ? gMove : base.possibleMoves(board, turn)[AI_MoveType.rand.Next(0, board.Length - turn + 1)];
        }

        public override int getID()
        {
            return MEDIUM_ID;
        }

        public override String getType() {
            return "Medium";
        }

        private Move CheckForTwo(int[,] board)
        {
            //Check for horizontal close matches
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] + board[i, 1] + board[i, 2] > 1)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == 0)
                        {
                            return new Move(i, j);
                        }
                    }
                }
            }

            //Check for vertical close matches
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] + board[1, i] + board[2, i] > 1)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[j, i] == 0)
                        {
                            return new Move(j, i);
                        }
                    }
                }
            }

            //Check for diagonal close matches
            if (board[0, 0] + board[1, 1] + board[2, 2] > 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, i] == 0)
                    {
                        return new Move(i, i);
                    }
                }
            }

            if (board[2, 0] + board[1, 1] + board[0, 2] > 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[2 - i, i] == 0)
                    {
                        return new Move(2 - i, i);
                    }
                }
            }
            return null;
        }
    }
}
