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
using Tic_Tac_Toe_Game.Models.MoveTypes;

namespace Tic_Tac_Toe_Game.Views
{
    public partial class DifficultyForm : Form
    {
        GameController gameController;
        public DifficultyForm()
        {
            InitializeComponent();
            gameController = GameController.getGameController();
        }

        private void DifficultyForm_Load(object sender, EventArgs e)
        {
            setDefaults();
        }

        private void setDefaults()
        {
            gameController = GameController.getGameController();

            //Set Form Dimensions
            Rectangle workingRect = Screen.PrimaryScreen.WorkingArea;
            this.MaximumSize = new Size(workingRect.Width / 4, workingRect.Height / 2);
            this.MinimumSize = new Size(workingRect.Width / 4, workingRect.Height / 2);
            this.CenterToScreen();

            this.DifficultyRadioGroup.Text = "Select Difficulty";
            this.DifficultyRadioGroup.MinimumSize = this.MinimumSize;
            this.DifficultyRadioGroup.MaximumSize = this.MaximumSize;

            this.SubmitBtn.Location = new Point(this.DifficultyRadioGroup.Width / 2 - this.SubmitBtn.Width / 2, this.DifficultyRadioGroup.Height * 3 / 4);
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (this.EasyDiffBtn.Checked || this.MediumDiffBtn.Checked || this.HardDiffBtn.Checked) {

                AI_MoveType moveType = null;
                int delay = 100;
                if (this.EasyDiffBtn.Checked)
                {
                    moveType = new BasicAI_MoveType();
                    delay = 20;
                }
                else if (this.MediumDiffBtn.Checked)
                {
                    moveType = new MediumAI_MoveType();
                    delay = 10;
                }
                else {
                    moveType = new HardAI_MoveType();
                    delay = 5;
                }

                gameController.setComputerDifficulty(moveType, delay);
                Dispose();
                return;
            }
            MessageBox.Show("Please Select a Difficulty!"); //None of the options were selected.
        }
    }
}
