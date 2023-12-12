﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game.Controls
{
    internal class TitleScreenController
    {
        private static TitleScreenController titleScreenController;
        private static readonly Object syncLock = new Object();


        public TitleScreenController() { }

        public static TitleScreenController getTitleScreenController()
        {
            if (titleScreenController == null)
            {
                lock (syncLock)
                {
                    if (titleScreenController == null)
                    {
                        titleScreenController = new TitleScreenController();
                    }
                }
            }
            return titleScreenController;
        }
    }
}
