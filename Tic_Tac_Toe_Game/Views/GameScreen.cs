using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Controls;

namespace Tic_Tac_Toe_Game.Views
{
    public partial class GameScreen : Form
    {
        GameController gameController;
        public GameScreen()
        {
            InitializeComponent();
            gameController = GameController.getGameController();
        }

        private void difficultySetBtn_Click(object sender, EventArgs e)
        {
            gameController.createDifficultyScreen();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            setDefaults();
        }

        private void setDefaults()
        {
            gameController = GameController.getGameController();
        }
    }
}
