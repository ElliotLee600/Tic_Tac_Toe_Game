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
using Tic_Tac_Toe_Game.Models;
using Tic_Tac_Toe_Game.Utils;

namespace Tic_Tac_Toe_Game.Views
{
    public partial class GameScreen : Form
    {
        GameController gameController;
        PictureBox[,] visualGrid;
        Bitmap default_resize;
        Bitmap x_image_resize;
        Bitmap o_image_resize;
        public GameScreen()
        {
            InitializeComponent();
            gameController = GameController.getGameController();
            //this
            GameModel.getGameModel().setGameScreen(this);

            Rectangle workingRect = Screen.PrimaryScreen.WorkingArea;
            //Setting up screen
            this.MaximumSize = new Size(workingRect.Width * 3 / 4, workingRect.Height * 3 / 4);
            this.MinimumSize = new Size(workingRect.Width * 3 / 4, workingRect.Height * 3 / 4);
            this.CenterToScreen();

            int screenWidth = this.MinimumSize.Width;
            int screenHeight = this.MinimumSize.Height;

            difficultySetBtn.MinimumSize = new Size(workingRect.Width / 10, workingRect.Height / 15);
            difficultySetBtn.MaximumSize = new Size(workingRect.Width / 10, workingRect.Height / 15);
            difficultySetBtn.Location = new Point(screenWidth * 33 / 40, screenHeight * 2 / 20);

            RecordButton.MinimumSize = new Size(workingRect.Width / 10, workingRect.Height / 15);
            RecordButton.MaximumSize = new Size(workingRect.Width / 10, workingRect.Height / 15);
            RecordButton.Location = new Point(screenWidth * 33 / 40, screenHeight * 4 / 20);

            Image originalImage;
            default_resize = null;
            try
            {
                originalImage = Image.FromFile("Views/Sprites/ttt_background_default.png");
                default_resize = new Bitmap(originalImage, new Size(screenWidth / 6, screenHeight / 6));

                originalImage = Image.FromFile("Views/Sprites/ttt_grid_x.png");
                x_image_resize = new Bitmap(originalImage, new Size(screenWidth / 6, screenHeight / 6));

                originalImage = Image.FromFile("Views/Sprites/ttt_grid_o.png");
                o_image_resize = new Bitmap(originalImage, new Size(screenWidth / 6, screenHeight / 6));

                //temp.Image = Image.FromFile("Views/Sprites/ttt_background_default.png");
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Images failed to load");
                default_resize = new Bitmap("Views/Sprites/ttt_background_default.png");
                x_image_resize = new Bitmap("Views/Sprites/ttt_grid_x.png");
                o_image_resize = new Bitmap("Views/Sprites/ttt_grid_o.png");
            }


            visualGrid = new PictureBox[3, 3];
            PictureBox temp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp = new PictureBox();
                    temp.Size = new Size(screenWidth / 6, screenHeight / 6);
                    temp.Location = new Point(screenWidth * (j + 1) / 6, screenHeight * (i + 1) / 6);
                    temp.Image = default_resize;
                    temp.Tag = new Move(i, j);
                    temp.Click += grid_Click;
                    temp.Parent = this;
                    visualGrid[i, j] = temp;

                }
            }
        }

        private void grid_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Enabled = false;
            Move gridPos = (Move)pb.Tag;
            Boolean gridSuccess = gameController.processGridClick(gridPos);
            if (!gridSuccess)
            {
                pb.Enabled = true;
            }
            //MessageBox.Show(gridPos.row + " " + gridPos.col);
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
            gameController.resetGame();
            difficultySetBtn.Enabled = true;
        }

        public void updateGrid(int[,] board, int turn)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    visualGrid[i, j].Enabled = false;
                    if (board[i, j] == 1)
                    {
                        visualGrid[i, j].Image = x_image_resize;
                    }
                    else if (board[i, j] == -1)
                    {
                        visualGrid[i, j].Image = o_image_resize;
                    }
                    else
                    {
                        visualGrid[i, j].Image = default_resize;
                        //visualGrid[i, j].Enabled = true;
                        if (turn % 2 == 1)
                        {
                            visualGrid[i, j].Enabled = true;
                        }
                    }
                }
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            gameController.updateTick();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            RecordScreen recordScreen = new RecordScreen();
            recordScreen.ShowDialog();
        }
    }
}
