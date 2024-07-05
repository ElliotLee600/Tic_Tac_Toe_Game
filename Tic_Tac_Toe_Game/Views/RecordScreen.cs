using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Models;

namespace Tic_Tac_Toe_Game.Views
{
    public partial class RecordScreen : Form
    {
        public RecordScreen()
        {
            InitializeComponent();
        }

        private void RecordScreen_Load(object sender, EventArgs e)
        {
            int[,] winloss = GameModel.getGameModel().getRecords();

            Rectangle workingRect = Screen.PrimaryScreen.WorkingArea;
            this.MaximumSize = new Size(workingRect.Width * 1 / 4, workingRect.Height * 2 / 4);
            this.MinimumSize = new Size(workingRect.Width * 1 / 4, workingRect.Height * 2 / 4);
            this.CenterToScreen();

            int screenWidth = this.MinimumSize.Width;
            int screenHeight = this.MinimumSize.Height;

            DifficultyTabs.MinimumSize = new Size(screenWidth, screenHeight * 9 / 10);
            DifficultyTabs.MaximumSize = new Size(screenWidth, screenHeight * 9 / 10);
            DifficultyTabs.Location = new Point(0, 0);

            ExitButton.MinimumSize = new Size(screenWidth / 4, screenHeight / 10);
            ExitButton.MaximumSize = new Size(screenWidth / 4, screenHeight / 10);
            ExitButton.Location = new Point(screenWidth * 3 / 8, screenHeight * 7 / 10);

            EasyHeader.Location = new Point(0, screenHeight / 25);
            EasyBody.Location = new Point(0, screenHeight / 6);
            EasyBody.Text = "Wins: " + winloss[0, 0] + "\n\nDraws: " + winloss[0, 1] + "\n\nLosses: " + winloss[0, 2];

            MediumHeader.Location = new Point(0, screenHeight / 25);
            MediumBody.Location = new Point(0, screenHeight / 6);
            MediumBody.Text = "Wins: " + winloss[1, 0] + "\n\nDraws: " + winloss[1, 1] + "\n\nLosses: " + winloss[1, 2];

            HardHeader.Location = new Point(0, screenHeight / 25);
            HardBody.Location = new Point(0, screenHeight / 6);
            HardBody.Text = "Wins: " + winloss[2, 0] + "\n\nDraws: " + winloss[2, 1] + "\n\nLosses: " + winloss[2, 2];
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
