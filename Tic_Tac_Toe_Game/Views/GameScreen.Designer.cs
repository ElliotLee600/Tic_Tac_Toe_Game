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
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RecordButton);
            Controls.Add(difficultySetBtn);
            Name = "GameScreen";
            Text = "Tic-Tac-Toe Game Screen";
            Load += GameScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button difficultySetBtn;
        private System.Windows.Forms.Timer MainTimer;
        private Button RecordButton;
    }
}