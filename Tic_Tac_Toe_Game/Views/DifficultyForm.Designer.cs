namespace Tic_Tac_Toe_Game.Views
{
    partial class DifficultyForm
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
            EasyDiffBtn = new RadioButton();
            DifficultyRadioGroup = new GroupBox();
            HardDiffBtn = new RadioButton();
            MediumDiffBtn = new RadioButton();
            SubmitBtn = new Button();
            DifficultyRadioGroup.SuspendLayout();
            SuspendLayout();
            // 
            // EasyDiffBtn
            // 
            EasyDiffBtn.AutoSize = true;
            EasyDiffBtn.Location = new Point(0, 26);
            EasyDiffBtn.Name = "EasyDiffBtn";
            EasyDiffBtn.Size = new Size(59, 24);
            EasyDiffBtn.TabIndex = 0;
            EasyDiffBtn.TabStop = true;
            EasyDiffBtn.Text = "Easy";
            EasyDiffBtn.UseVisualStyleBackColor = true;
            // 
            // DifficultyRadioGroup
            // 
            DifficultyRadioGroup.Controls.Add(SubmitBtn);
            DifficultyRadioGroup.Controls.Add(HardDiffBtn);
            DifficultyRadioGroup.Controls.Add(MediumDiffBtn);
            DifficultyRadioGroup.Controls.Add(EasyDiffBtn);
            DifficultyRadioGroup.Location = new Point(0, 3);
            DifficultyRadioGroup.Name = "DifficultyRadioGroup";
            DifficultyRadioGroup.Size = new Size(250, 204);
            DifficultyRadioGroup.TabIndex = 1;
            DifficultyRadioGroup.TabStop = false;
            DifficultyRadioGroup.Text = "Select Difficulty";
            // 
            // HardDiffBtn
            // 
            HardDiffBtn.AutoSize = true;
            HardDiffBtn.Location = new Point(0, 86);
            HardDiffBtn.Name = "HardDiffBtn";
            HardDiffBtn.Size = new Size(63, 24);
            HardDiffBtn.TabIndex = 2;
            HardDiffBtn.TabStop = true;
            HardDiffBtn.Text = "Hard";
            HardDiffBtn.UseVisualStyleBackColor = true;
            // 
            // MediumDiffBtn
            // 
            MediumDiffBtn.AutoSize = true;
            MediumDiffBtn.Location = new Point(0, 56);
            MediumDiffBtn.Name = "MediumDiffBtn";
            MediumDiffBtn.Size = new Size(83, 26);
            MediumDiffBtn.TabIndex = 1;
            MediumDiffBtn.TabStop = true;
            MediumDiffBtn.Text = "Medium";
            MediumDiffBtn.UseCompatibleTextRendering = true;
            MediumDiffBtn.UseVisualStyleBackColor = true;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(62, 141);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(94, 29);
            SubmitBtn.TabIndex = 3;
            SubmitBtn.Text = "Confirm";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // DifficultyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DifficultyRadioGroup);
            Name = "DifficultyForm";
            Text = "DifficultyForm";
            Load += DifficultyForm_Load;
            DifficultyRadioGroup.ResumeLayout(false);
            DifficultyRadioGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton EasyDiffBtn;
        private GroupBox DifficultyRadioGroup;
        private RadioButton HardDiffBtn;
        private RadioButton MediumDiffBtn;
        private Button SubmitBtn;
    }
}