namespace Tic_Tac_Toe_Game.Views
{
    partial class RecordScreen
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
            DifficultyTabs = new TabControl();
            tabPage1 = new TabPage();
            EasyBody = new Label();
            EasyHeader = new Label();
            tabPage2 = new TabPage();
            MediumHeader = new Label();
            tabPage3 = new TabPage();
            HardBody = new Label();
            HardHeader = new Label();
            ExitButton = new Button();
            MediumBody = new Label();
            DifficultyTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // DifficultyTabs
            // 
            DifficultyTabs.Controls.Add(tabPage1);
            DifficultyTabs.Controls.Add(tabPage2);
            DifficultyTabs.Controls.Add(tabPage3);
            DifficultyTabs.Location = new Point(27, 27);
            DifficultyTabs.Name = "DifficultyTabs";
            DifficultyTabs.SelectedIndex = 0;
            DifficultyTabs.Size = new Size(507, 270);
            DifficultyTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(EasyBody);
            tabPage1.Controls.Add(EasyHeader);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(499, 237);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Easy";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // EasyBody
            // 
            EasyBody.AutoSize = true;
            EasyBody.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EasyBody.Location = new Point(30, 175);
            EasyBody.Name = "EasyBody";
            EasyBody.Size = new Size(62, 25);
            EasyBody.TabIndex = 1;
            EasyBody.Text = "label2";
            // 
            // EasyHeader
            // 
            EasyHeader.AutoSize = true;
            EasyHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            EasyHeader.Location = new Point(22, 30);
            EasyHeader.Name = "EasyHeader";
            EasyHeader.Size = new Size(289, 35);
            EasyHeader.TabIndex = 0;
            EasyHeader.Text = "Record Against Easy AI:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(MediumBody);
            tabPage2.Controls.Add(MediumHeader);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(499, 237);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Medium";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MediumHeader
            // 
            MediumHeader.AutoSize = true;
            MediumHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            MediumHeader.Location = new Point(41, 37);
            MediumHeader.Name = "MediumHeader";
            MediumHeader.Size = new Size(337, 35);
            MediumHeader.TabIndex = 0;
            MediumHeader.Text = "Record Against Medium AI:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(HardBody);
            tabPage3.Controls.Add(HardHeader);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(499, 237);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hard";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // HardBody
            // 
            HardBody.AutoSize = true;
            HardBody.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HardBody.Location = new Point(35, 172);
            HardBody.Name = "HardBody";
            HardBody.Size = new Size(62, 25);
            HardBody.TabIndex = 1;
            HardBody.Text = "label2";
            // 
            // HardHeader
            // 
            HardHeader.AutoSize = true;
            HardHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            HardHeader.Location = new Point(38, 29);
            HardHeader.Name = "HardHeader";
            HardHeader.Size = new Size(296, 35);
            HardHeader.TabIndex = 0;
            HardHeader.Text = "Record Against Hard AI:";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(209, 379);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Return";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MediumBody
            // 
            MediumBody.AutoSize = true;
            MediumBody.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MediumBody.Location = new Point(69, 180);
            MediumBody.Name = "MediumBody";
            MediumBody.Size = new Size(59, 25);
            MediumBody.TabIndex = 1;
            MediumBody.Text = "label1";
            // 
            // RecordScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(DifficultyTabs);
            Name = "RecordScreen";
            Text = "RecordScreen";
            Load += RecordScreen_Load;
            DifficultyTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl DifficultyTabs;
        private TabPage tabPage1;
        private Label EasyBody;
        private Label EasyHeader;
        private TabPage tabPage2;
        private Label MediumHeader;
        private TabPage tabPage3;
        private Button ExitButton;
        private Label HardBody;
        private Label HardHeader;
        private Label MediumBody;
    }
}