﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game.Views;

namespace Tic_Tac_Toe_Game.Controls
{
    public class TitleScreenController
    {
        private static TitleScreenController titleScreenController;
        private static readonly Object initLock = new Object();


        private TitleScreenController() { }

        public static TitleScreenController getTitleScreenController()
        {
            if (titleScreenController == null)
            {
                lock (initLock)
                {
                    if (titleScreenController == null)
                    {
                        //We only want exactly one TitleScreenController.
                        titleScreenController = new TitleScreenController();
                    }
                }
            }
            return titleScreenController;
        }

        public void createGameScreen() { 
            GameScreen gameScreen = new GameScreen();
            gameScreen.ShowDialog();
        }
    }
}
