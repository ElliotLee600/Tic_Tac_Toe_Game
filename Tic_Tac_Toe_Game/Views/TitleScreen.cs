using Tic_Tac_Toe_Game.Controls;

namespace Tic_Tac_Toe_Game
{
    public partial class TitleScreen : Form
    {
        TitleScreenController titleScreenController;
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void TitleScreen_Load(object sender, EventArgs e)
        {
            setDefaults();
        }

        private void setDefaults()
        {
            titleScreenController = TitleScreenController.getTitleScreenController();
        }
    }
}
