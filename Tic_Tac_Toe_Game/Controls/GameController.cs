using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Models;
using Tic_Tac_Toe_Game.Models.MoveTypes;
using Tic_Tac_Toe_Game.Views;

namespace Tic_Tac_Toe_Game.Controls
{
    /* Acts as the central Game Controller.
     * Implemented using the singleton design pattern.
     * 
     */
    public class GameController
    {

        private static GameController gameController;
        private static readonly Object initLock = new Object();
        Rectangle workingRect; //has dimensions of main display.

        private Player computerPlayer;
        private Player humanPlayer;

        private GameController() {
            workingRect = Screen.PrimaryScreen.WorkingArea;
            computerPlayer = new Player(new MediumAI_MoveType(), 0);
            humanPlayer = new Player(new Player_MoveType(), 1);

        }

        public static GameController getGameController()
        {
            if (gameController == null)
            {
                lock (initLock)
                {
                    if (gameController == null)
                    {
                        //We only want exactly one GameController.
                        gameController = new GameController();
                    }
                }
            }
            return gameController;
        }

        public void createDifficultyScreen()
        {
            DifficultyForm difficultyForm = new DifficultyForm();
            difficultyForm.ShowDialog();

        }

        public void setComputerDifficulty(IMoveType moveType) {
            computerPlayer.setMoveType(moveType);
        }
    }
}
