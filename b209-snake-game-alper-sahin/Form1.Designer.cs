namespace b209_snake_game_alper_sahin
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            scoreText = new Label();
            label1 = new Label();
            playButton = new Button();
            difficultyButton = new Button();
            exitButton = new Button();
            label2 = new Label();
            easyButton = new Button();
            hardButton = new Button();
            mediumButton = new Button();
            expertButton = new Button();
            label3 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 700);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Location = new Point(766, 51);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(56, 15);
            scoreText.TabIndex = 1;
            scoreText.Text = "scoreText";
            scoreText.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(729, 51);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Score:";
            label1.Visible = false;
            // 
            // playButton
            // 
            playButton.Location = new Point(262, 174);
            playButton.Name = "playButton";
            playButton.Size = new Size(215, 52);
            playButton.TabIndex = 3;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // difficultyButton
            // 
            difficultyButton.Location = new Point(262, 232);
            difficultyButton.Name = "difficultyButton";
            difficultyButton.Size = new Size(215, 52);
            difficultyButton.TabIndex = 4;
            difficultyButton.Text = "Difficulty";
            difficultyButton.UseVisualStyleBackColor = true;
            difficultyButton.Click += difficultyButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(262, 290);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(215, 52);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 104);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "100";
            // 
            // easyButton
            // 
            easyButton.Location = new Point(483, 174);
            easyButton.Name = "easyButton";
            easyButton.Size = new Size(215, 52);
            easyButton.TabIndex = 8;
            easyButton.Text = "EASY";
            easyButton.UseVisualStyleBackColor = true;
            easyButton.Visible = false;
            easyButton.Click += easyButton_Click;
            // 
            // hardButton
            // 
            hardButton.Location = new Point(483, 290);
            hardButton.Name = "hardButton";
            hardButton.Size = new Size(215, 52);
            hardButton.TabIndex = 9;
            hardButton.Text = "HARD";
            hardButton.UseVisualStyleBackColor = true;
            hardButton.Visible = false;
            hardButton.Click += hardButton_Click;
            // 
            // mediumButton
            // 
            mediumButton.Location = new Point(483, 232);
            mediumButton.Name = "mediumButton";
            mediumButton.Size = new Size(215, 52);
            mediumButton.TabIndex = 10;
            mediumButton.Text = "MEDIUM";
            mediumButton.UseVisualStyleBackColor = true;
            mediumButton.Visible = false;
            mediumButton.Click += mediumButton_Click;
            // 
            // expertButton
            // 
            expertButton.Location = new Point(483, 348);
            expertButton.Name = "expertButton";
            expertButton.Size = new Size(215, 52);
            expertButton.TabIndex = 11;
            expertButton.Text = "EXPERT";
            expertButton.UseVisualStyleBackColor = true;
            expertButton.Visible = false;
            expertButton.Click += expertButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(759, 97);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 12;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 71);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 13;
            // 
            // listView1
            // 
            listView1.Location = new Point(65, 89);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 725);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(expertButton);
            Controls.Add(mediumButton);
            Controls.Add(hardButton);
            Controls.Add(easyButton);
            Controls.Add(label2);
            Controls.Add(exitButton);
            Controls.Add(difficultyButton);
            Controls.Add(playButton);
            Controls.Add(label1);
            Controls.Add(scoreText);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label scoreText;
        private Label label1;
        private Button playButton;
        private Button difficultyButton;
        private Button exitButton;
        private Label label2;
        private Button easyButton;
        private Button hardButton;
        private Button mediumButton;
        private Button expertButton;
        private Label label3;
        private Label label4;
        private ListView listView1;
    }
}