namespace Tic_Tac_Toe_Game
{
    partial class TitleScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playButton = new Button();
            TitleScreenText = new Label();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Location = new Point(327, 329);
            playButton.Name = "playButton";
            playButton.Size = new Size(94, 29);
            playButton.TabIndex = 0;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // TitleScreenText
            // 
            TitleScreenText.AutoSize = true;
            TitleScreenText.Font = new Font("Viner Hand ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleScreenText.Location = new Point(205, 97);
            TitleScreenText.Name = "TitleScreenText";
            TitleScreenText.Size = new Size(351, 97);
            TitleScreenText.TabIndex = 1;
            TitleScreenText.Text = "Tic Tac Toe";
            // 
            // TitleScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TitleScreenText);
            Controls.Add(playButton);
            Name = "TitleScreen";
            Text = "Tic-Tac-Toe Title Screen";
            Load += TitleScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playButton;
        private Label TitleScreenText;
    }
}
