namespace Tic_Tac_Toe_Game.Views
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            difficultySetBtn = new Button();
            MainTimer = new System.Windows.Forms.Timer(components);
            RecordButton = new Button();
            gameEndLabel = new Label();
            TurnLabel = new Label();
            StartGameButton = new Button();
            SuspendLayout();
            // 
            // difficultySetBtn
            // 
            difficultySetBtn.Location = new Point(652, 25);
            difficultySetBtn.Name = "difficultySetBtn";
            difficultySetBtn.Size = new Size(122, 29);
            difficultySetBtn.TabIndex = 0;
            difficultySetBtn.Text = "Set Difficulty";
            difficultySetBtn.UseVisualStyleBackColor = true;
            difficultySetBtn.Click += difficultySetBtn_Click;
            // 
            // MainTimer
            // 
            MainTimer.Enabled = true;
            MainTimer.Interval = 50;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // RecordButton
            // 
            RecordButton.Location = new Point(649, 60);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(125, 29);
            RecordButton.TabIndex = 1;
            RecordButton.Text = "Records";
            RecordButton.UseVisualStyleBackColor = true;
            RecordButton.Click += RecordButton_Click;
            // 
            // gameEndLabel
            // 
            gameEndLabel.AutoSize = true;
            gameEndLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameEndLabel.Location = new Point(189, 27);
            gameEndLabel.Name = "gameEndLabel";
            gameEndLabel.Size = new Size(117, 46);
            gameEndLabel.TabIndex = 2;
            gameEndLabel.Text = "label1";
            // 
            // TurnLabel
            // 
            TurnLabel.AutoSize = true;
            TurnLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TurnLabel.Location = new Point(208, 82);
            TurnLabel.Name = "TurnLabel";
            TurnLabel.Size = new Size(73, 31);
            TurnLabel.TabIndex = 3;
            TurnLabel.Text = "label1";
            // 
            // StartGameButton
            // 
            StartGameButton.Location = new Point(367, 362);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(94, 29);
            StartGameButton.TabIndex = 4;
            StartGameButton.Text = "Start Game";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartGameButton);
            Controls.Add(TurnLabel);
            Controls.Add(gameEndLabel);
            Controls.Add(RecordButton);
            Controls.Add(difficultySetBtn);
            Name = "GameScreen";
            Text = "Tic-Tac-Toe Game Screen";
            Load += GameScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button difficultySetBtn;
        private System.Windows.Forms.Timer MainTimer;
        private Button RecordButton;
        private Label gameEndLabel;
        private Label TurnLabel;
        private Button StartGameButton;
    }
}