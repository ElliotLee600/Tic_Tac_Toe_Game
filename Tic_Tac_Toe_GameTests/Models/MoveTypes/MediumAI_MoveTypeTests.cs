using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tic_Tac_Toe_Game.Models.MoveTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Utils;

namespace Tic_Tac_Toe_Game.Models.MoveTypes.Tests
{
    [TestClass()]
    public class MediumAI_MoveTypeTests
    {
        [TestMethod()]
        public void getMoveTest()
        {
            int turn = 1;
            int[,] board = new int[3, 3];
            for (int i = 0; i < 3; i++) { 
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
            IMoveType medium = new MediumAI_MoveType();
            Move expectedMove = new Move(1, 1);

            //Tests for Medium AI prioritizing the middle square
            Assert.AreEqual(expectedMove, medium.getMove(board, turn));

            //Tests if Medium AI will block a row with 2 X's
            for (int row = 0; row < 3; row++) {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        board[i, j] = 0;
                    }
                }
                turn = 4;
                board[row, 0] = 1;
                board[row, 1] = 1;
                expectedMove = new Move(row, 2);

                Assert.AreEqual(expectedMove, medium.getMove(board, turn));
            }

            //Tests if Medium AI will block a column with 2 X's
            for (int col = 0; col < 3; col++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        board[i, j] = 0;
                    }
                }
                turn = 4;
                board[0, col] = 1;
                board[2, col] = 1;
                expectedMove = new Move(1, col);

                Assert.AreEqual(expectedMove, medium.getMove(board, turn));
            }

            //Tests to see if MediumAI will block a diagonal with 2 X's
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }

            turn = 4;
            board[2, 2] = 1;
            board[1, 1] = 1;
            expectedMove = new Move(0, 0);

            Assert.AreEqual(expectedMove, medium.getMove(board, turn));


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
            turn = 4;
            board[0, 2] = 1;
            board[2, 0] = 1;
            expectedMove = new Move(1, 1);

            Assert.AreEqual(expectedMove, medium.getMove(board, turn));


            //Tests to see if MediumAI correctly outputs null when turn>9
            turn = 10;

            Assert.AreEqual(null, medium.getMove(board, turn));

        }
    }
}