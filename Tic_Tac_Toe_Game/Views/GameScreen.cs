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
        PictureBox[,] visualGrid;
        public GameScreen()
        {
            InitializeComponent();
            gameController = GameController.getGameController();

            Rectangle workingRect = Screen.PrimaryScreen.WorkingArea;
            //Setting up screen
            this.MaximumSize = new Size(workingRect.Width * 3 / 4, workingRect.Height * 3 /4 );
            this.MinimumSize = new Size(workingRect.Width * 3 / 4, workingRect.Height * 3 / 4);
            this.CenterToScreen();

            int screenWidth = this.MinimumSize.Width;
            int screenHeight = this.MinimumSize.Height;

            difficultySetBtn.MinimumSize = new Size(workingRect.Width / 10, workingRect.Height / 15);
            difficultySetBtn.MaximumSize = new Size(workingRect.Width / 10, workingRect.Height / 15);
            difficultySetBtn.Location = new Point(screenWidth * 33/40, screenHeight * 2/20);
            Image originalImage;
            Bitmap resize = null;
            try
            {
                originalImage = Image.FromFile("Views/Sprites/ttt_background_default.png");
                resize = new Bitmap(originalImage, new Size(screenWidth / 6, screenHeight / 6));

                //temp.Image = Image.FromFile("Views/Sprites/ttt_background_default.png");
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Images failed to load");
                resize = new Bitmap("Views/Sprites/ttt_background_default.png");
            }
            

            visualGrid = new PictureBox[3, 3];
            PictureBox temp;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++)
                {
                    temp =  new PictureBox();
                    temp.Size = new Size(screenWidth/6, screenHeight/6);
                    temp.Location = new Point(screenWidth * (j + 1) / 6, screenHeight * (i + 1) / 6);
                    temp.Image = resize;
                    
                    temp.Parent = this;
                    visualGrid[i, j] = temp;
                    
                }
            }
        }

        private void difficultySetBtn_Click(object sender, EventArgs e)
        {
            gameController.createDifficultyScreen();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            gameController = GameController.getGameController();
            setDefaults();
        }

        private void setDefaults()
        {
            
            difficultySetBtn.Enabled = true;
        }
    }
}
