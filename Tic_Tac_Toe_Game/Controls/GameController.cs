using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game.Controls
{
    /* Acts as the central Game Controller.
     * Implemented using the singleton design pattern.
     * 
     */
    internal class GameController
    {

        private static GameController gameController;
        private static readonly Object syncLock = new Object();


        public GameController() { }

        public static GameController getGameController()
        {
            if (gameController == null)
            {
                lock (syncLock)
                {
                    if (gameController == null)
                    {
                        gameController = new GameController();
                    }
                }
            }
            return gameController;
        }
    }
}
