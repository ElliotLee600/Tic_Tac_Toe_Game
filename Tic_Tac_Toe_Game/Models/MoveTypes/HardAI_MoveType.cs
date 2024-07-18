using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Utils;

namespace Tic_Tac_Toe_Game.Models.MoveTypes
{
    public class HardAI_MoveType : AI_MoveType
    {
        public const int HARD_ID = 2;

        public int leafStates; //for testing purposes

        

        public override Move getMove(int[,] board, int turn)
        {
            Move[] moves = possibleMoves(board, turn);
            Move curMove =  null;
            int currentMax = -10;
            int temp;
            int symbol = (turn % 2 == 1) ? 1 : -1;
            int alpha = -10;
            int beta = 10;
            leafStates = 0;
            //MessageBox.Show("sym:"+symbol);
            foreach (Move m in moves)
            {
                temp = minimax_min(simulateMove(board, m.row, m.col, symbol), symbol * -1, turn + 1, alpha, beta);
                if (temp > currentMax)
                {
                    currentMax = temp;
                    curMove = m;
                    
                }
                if (temp > alpha)
                {
                    alpha = temp;
                }
                //MessageBox.Show(temp + "/ row: " + m.row + "/ col: " + m.col);
            }
            //MessageBox.Show("Leafstates expanded: " + leafStates);
            return curMove;
        }
        public override int getID()
        {
            return HARD_ID;
        }

        public override String getType()
        {
            return "Hard";
        }

        public int[,] simulateMove(int[,] board, int row, int col, int symbol)
        {
            int[,] newboard = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    newboard[i,j] = board[i,j];
                }
            }
            newboard[row, col] = symbol;
            return newboard;
        }

        public static int checkBoard(int[,] board, int symbol) {
            for (int i = 0; i < 3; i++) {
                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2] && board[i, 0] != 0) {
                    return (symbol == board[i, 0]) ? 1 : -1;
                }
                if (board[0, i] == board[1, i] && board[0, i] == board[2, i] && board[0, i] != 0)
                {
                    return (symbol == board[0, i]) ? 1 : -1;
                }

            }
            if (board[0, 0] != 0 && board[0, 0] == board[1, 1] && board[0,0] == board[2, 2]) {
                return (symbol == board[0, 0]) ? 1 : -1;
            }
            if (board[1, 1] != 0 && board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
            {
                return (symbol == board[1, 1]) ? 1 : -1;
            }
            return 0;

        }

        public int minimax_min(int[,] board, int symbol, int turn, int alpha, int beta) {
            int eval = checkBoard(board, symbol * -1); //-1 is so board is evaluated from starting player's perspective
            if (eval != 0) {
                leafStates++;
                return eval; //nonzero eval means game should be over, regardless of how full board is.
            }
            int currentMin = 10;
            int temp;
            Move[] moves = possibleMoves(board, turn);
            if (moves == null) {
                leafStates++;
                return eval;
            }
            foreach (Move m in moves) {
                temp = minimax_max(simulateMove(board, m.row, m.col, symbol), symbol * -1, turn + 1, alpha, beta);
                if (temp < currentMin) {
                    currentMin = temp;
                }
                if (temp < alpha) {
                    //MessageBox.Show("MinBranch skipped due to value: " + temp + " and alpha: " + alpha);
                    break;
                }
                if (temp < beta) {
                    beta = temp;
                }
            }
            return currentMin;
        }

        public int minimax_max(int[,] board, int symbol, int turn, int alpha, int beta)
        {
            int currentMax = -10;
            int temp;
            int eval = checkBoard(board, symbol);
            if (eval != 0)
            {
                leafStates++;
                return eval; //nonzero eval means game should be over, regardless of how full board is.
            }
            Move[] moves = possibleMoves(board, turn);
            if (moves == null)
            {
                leafStates++;
                return eval;
            }
            foreach (Move m in moves)
            {
                temp = minimax_min(simulateMove(board, m.row, m.col, symbol), symbol * -1, turn + 1, alpha, beta);
                if (temp > currentMax)
                {
                    currentMax = temp;
                }
                if (temp > beta) {
                    break;
                }
                if (temp > alpha) {
                    alpha = temp;
                }
            }
            return currentMax;
        }
    }
}
