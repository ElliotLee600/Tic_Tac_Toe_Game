using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tic_Tac_Toe_Game.Models.MoveTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Utils;

namespace Tic_Tac_Toe_Game.Models.MoveTypes.Tests
{
    [TestClass()]
    public class HardAI_MoveTypeTests
    {
        [TestMethod()]
        public void getMoveTest()
        {
            int turn = 1;
            int[,] board = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
            board[1, 1] = 1;
            board[0, 0] = -1;
            board[1, 2] = 1;
            board[0, 1] = -1;
           
            
            turn = 5;
            Move expectedMove = new Move(0, 2);
            HardAI_MoveType hard = new HardAI_MoveType();
            Assert.AreEqual(expectedMove, hard.getMove(board, turn));
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
            board[1, 1] = 1;
            turn = 2;
            expectedMove = new Move(0, 2);
            Assert.AreEqual(expectedMove, hard.getMove(board, turn));

        }
        /*
        [TestMethod()]
        public void getIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getTypeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void simulateMoveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void checkBoardTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void minimax_minTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void minimax_maxTest()
        {
            Assert.Fail();
        }
        */
    }
}