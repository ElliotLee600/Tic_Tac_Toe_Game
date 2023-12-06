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


        public GameController() { }

        public static GameController getGameController()
        {
            if (gameController == null)
            {
                lock (gameController)
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
