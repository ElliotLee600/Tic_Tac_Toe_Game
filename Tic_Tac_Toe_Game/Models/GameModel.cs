using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game.Models
{
    /*
     * Acts as the central game model.
     * Implemented using the singleton design pattern.
     */
    internal class GameModel
    {
        public static GameModel gameModel;
        public static GameModel getGameModel()
        {
            if (gameModel == null)
            {
                lock (gameModel)
                {
                    if (gameModel == null)
                    {
                        gameModel = new GameModel(); //Ensures there should only ever be one GameModel
                    }
                }

            }
            return gameModel;
        }
    }
}
