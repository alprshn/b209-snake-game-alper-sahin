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
            easyButton = new Button();
            hardButton = new Button();
            mediumButton = new Button();
            expertButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label16 = new Label();
            label17 = new Label();
            label2 = new Label();
            label18 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            scoreText.ForeColor = Color.Lime;
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
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(729, 51);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Score:";
            label1.Visible = false;
            // 
            // playButton
            // 
            playButton.Location = new Point(332, 213);
            playButton.Name = "playButton";
            playButton.Size = new Size(215, 52);
            playButton.TabIndex = 3;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // difficultyButton
            // 
            difficultyButton.Location = new Point(332, 271);
            difficultyButton.Name = "difficultyButton";
            difficultyButton.Size = new Size(215, 52);
            difficultyButton.TabIndex = 4;
            difficultyButton.Text = "Difficulty";
            difficultyButton.UseVisualStyleBackColor = true;
            difficultyButton.Click += difficultyButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(332, 329);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(215, 52);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // easyButton
            // 
            easyButton.Location = new Point(553, 213);
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
            hardButton.Location = new Point(553, 329);
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
            mediumButton.Location = new Point(553, 271);
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
            expertButton.Location = new Point(553, 387);
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
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(767, 86);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(107, 86);
            label5.Name = "label5";
            label5.Size = new Size(171, 30);
            label5.TabIndex = 15;
            label5.Text = "10 Highest Score";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(59, 122);
            label6.Name = "label6";
            label6.Size = new Size(26, 30);
            label6.TabIndex = 16;
            label6.Text = "1.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(57, 152);
            label7.Name = "label7";
            label7.Size = new Size(30, 30);
            label7.TabIndex = 17;
            label7.Text = "2.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(57, 182);
            label8.Name = "label8";
            label8.Size = new Size(30, 30);
            label8.TabIndex = 18;
            label8.Text = "3.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(57, 212);
            label9.Name = "label9";
            label9.Size = new Size(30, 30);
            label9.TabIndex = 19;
            label9.Text = "4.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(57, 242);
            label10.Name = "label10";
            label10.Size = new Size(30, 30);
            label10.TabIndex = 20;
            label10.Text = "5.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(53, 392);
            label11.Name = "label11";
            label11.Size = new Size(38, 30);
            label11.TabIndex = 25;
            label11.Text = "10.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(57, 362);
            label12.Name = "label12";
            label12.Size = new Size(30, 30);
            label12.TabIndex = 24;
            label12.Text = "9.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(57, 332);
            label13.Name = "label13";
            label13.Size = new Size(30, 30);
            label13.TabIndex = 23;
            label13.Text = "8.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(58, 302);
            label14.Name = "label14";
            label14.Size = new Size(29, 30);
            label14.TabIndex = 22;
            label14.Text = "7.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(57, 272);
            label15.Name = "label15";
            label15.Size = new Size(30, 30);
            label15.TabIndex = 21;
            label15.Text = "6.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 26;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.SlateGray;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(91, 122);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(187, 300);
            listBox1.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Lime;
            label16.Location = new Point(729, 86);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 28;
            label16.Text = "Speed:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(336, 185);
            label17.Name = "label17";
            label17.Size = new Size(60, 15);
            label17.TabIndex = 29;
            label17.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 98);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 30;
            label2.Text = "Length";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(468, 98);
            label18.Name = "label18";
            label18.Size = new Size(39, 15);
            label18.TabIndex = 31;
            label18.Text = "Width";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(407, 118);
            numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(41, 23);
            numericUpDown1.TabIndex = 34;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(468, 118);
            numericUpDown2.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(41, 23);
            numericUpDown2.TabIndex = 35;
            numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(940, 725);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label18);
            Controls.Add(label2);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(expertButton);
            Controls.Add(mediumButton);
            Controls.Add(hardButton);
            Controls.Add(easyButton);
            Controls.Add(exitButton);
            Controls.Add(difficultyButton);
            Controls.Add(playButton);
            Controls.Add(label1);
            Controls.Add(scoreText);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private Button easyButton;
        private Button hardButton;
        private Button mediumButton;
        private Button expertButton;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label16;
        private Label label17;
        private Label label2;
        private Label label18;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}