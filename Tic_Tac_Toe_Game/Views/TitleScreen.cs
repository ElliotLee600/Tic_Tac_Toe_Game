using Tic_Tac_Toe_Game.Controls;

namespace Tic_Tac_Toe_Game
{
    public partial class TitleScreen : Form
    {
        TitleScreenController titleScreenController;
        public TitleScreen()
        {
            InitializeComponent();
            this.Visible = true;
            titleScreenController = TitleScreenController.getTitleScreenController();

            Rectangle workingRect = Screen.PrimaryScreen.WorkingArea;
            this.MaximumSize = new Size(workingRect.Width * 2 / 4, workingRect.Height * 2 / 4);
            this.MinimumSize = new Size(workingRect.Width * 2 / 4, workingRect.Height* 2 / 4);
            this.CenterToScreen();

            int screenWidth = this.MinimumSize.Width;
            int screenHeight = this.MinimumSize.Height;

            playButton.MinimumSize = new Size(screenWidth / 4, screenHeight / 6);
            playButton.MaximumSize = new Size(screenWidth / 4, screenHeight / 6);
            playButton.Location = new Point(screenWidth * 3 / 8, screenHeight * 4 / 6);

            TitleScreenText.MaximumSize = new Size(screenWidth / 2, screenHeight / 6);
            TitleScreenText.MinimumSize = new Size(screenWidth / 2, screenHeight / 6);
            TitleScreenText.Location = new Point(screenWidth * 32 / 100, screenHeight * 1 / 8);
        }

        private void TitleScreen_Load(object sender, EventArgs e)
        {
            setDefaults();
        }

        private void setDefaults()
        {
            titleScreenController = TitleScreenController.getTitleScreenController();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            titleScreenController.createGameScreen();
            this.Close();

        }
    }
}
