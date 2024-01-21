using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace b209_snake_game_alper_sahin
{
    public partial class Form1 : Form
    {
        private List<PlayerRanking> players;
        public Form1()
        {
            InitializeComponent();
            players = new List<PlayerRanking>();
            UploadPlayers();
            PlayerList();
        }
        private DateTime lastKeyPressTime;
        System.Windows.Forms.Timer timer;
        int lenghtMatrix;
        int widthMatrix;
        int[,] matrix;
        SnakeDirection direction;
        Point headPosition;
        int lastSegment;
        Random random;
        int second = 250;

        enum MatrixObject
        {
            Food = -1,
            Spike = -2
        }
        enum SnakeDirection
        {
            Up,
            Right,
            Down,
            Left
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MainMenuVisible();
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || numericUpDown1.Value == 0 || numericUpDown2.Value == 0)
            {
                MessageBox.Show("Please Enter Your Username, Width or Length");
            }
            else
            {
                PlayVisible();
                random = new Random();
                timer = new System.Windows.Forms.Timer();
                timer.Tick += Timer_Tick;
                lenghtMatrix = (int)numericUpDown1.Value;
                widthMatrix = (int)numericUpDown2.Value;
                matrix = new int[widthMatrix - 1, lenghtMatrix - 1];
                timer.Start();
                timer.Interval = second;
                label3.Text = timer.Interval.ToString();
                Initialize();
            }


        }
        private void PlayVisible()
        {
            this.KeyPreview = true;
            pictureBox1.Visible = true;
            scoreText.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label16.Visible = true;

            playButton.Visible = false;
            difficultyButton.Visible = false;
            exitButton.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label8.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            listBox1.Visible = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            numericUpDown1.Visible = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Visible = false;
            numericUpDown2.Enabled = false;
            DifficultyVisible();
            textBox1.Parent.Focus();
            numericUpDown1.Parent.Focus();
            numericUpDown2.Parent.Focus();
            label17.Visible = false;
            label18.Visible = false;
            label2.Visible = false;
        }

        private void MainMenuVisible()
        {
            pictureBox1.Visible = false;
            scoreText.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label16.Visible = false;

            playButton.Visible = true;
            difficultyButton.Visible = true;
            exitButton.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label8.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            listBox1.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            numericUpDown1.Visible = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Visible = true;
            numericUpDown2.Enabled = true;
            label17.Visible = true;
            label18.Visible = true;
            label2.Visible = true;
        }
        private void Initialize()
        {
            timer.Start();
            for (int i = 1; i < widthMatrix - 1; i++)
            {
                for (int j = 1; j < lenghtMatrix - 1; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            GenerateFood();
            headPosition = new Point(5, 5);
            matrix[5, 5] = 1;
            matrix[6, 5] = 2;
            matrix[7, 5] = 3;
            lastSegment = 3;
            direction = SnakeDirection.Left;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            GameLogic();
            Draw();
        }

        private void Draw()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.SlateGray, 0, 0, pictureBox1.Width, pictureBox1.Height);
            SizeF sizeCell = new SizeF((float)pictureBox1.Width / widthMatrix, (float)pictureBox1.Height / lenghtMatrix);

            for (int i = 0; i < widthMatrix; i++)
            {
                for (int j = 0; j < lenghtMatrix; j++)
                {
                    if (i == 0 || j == lenghtMatrix - 1 || i == widthMatrix - 1 || j == 0)
                    {
                        graphics.FillRectangle(Brushes.DarkSlateBlue, i * sizeCell.Width, j * sizeCell.Height, sizeCell.Width - 3, sizeCell.Height - 3);
                    }
                    else if (matrix[i, j] == 0)
                    {
                        graphics.FillRectangle(Brushes.LightGreen, i * sizeCell.Width, j * sizeCell.Height, sizeCell.Width - 3, sizeCell.Height - 3);
                    }
                    else if (matrix[i, j] == (int)MatrixObject.Food)
                    {
                        graphics.FillRectangle(Brushes.Red, i * sizeCell.Width, j * sizeCell.Height, sizeCell.Width - 3, sizeCell.Height - 3);
                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.DarkGreen, i * sizeCell.Width, j * sizeCell.Height, sizeCell.Width - 3, sizeCell.Height - 3);
                    }
                }
            }
            pictureBox1.BackgroundImage = bitmap;
        }

        private void GameLogic()
        {
            Point walkPosition;
            switch (direction)
            {
                case SnakeDirection.Up:
                    walkPosition = new Point(headPosition.X, headPosition.Y - 1);
                    break;
                case SnakeDirection.Right:
                    walkPosition = new Point(headPosition.X + 1, headPosition.Y);
                    break;
                case SnakeDirection.Down:
                    walkPosition = new Point(headPosition.X, headPosition.Y + 1);
                    break;
                case SnakeDirection.Left:
                    walkPosition = new Point(headPosition.X - 1, headPosition.Y);
                    break;
                default:
                    throw new Exception("It is not possible fot the snake to not have a direction");
            }
            if (walkPosition.X < 1 || walkPosition.Y < 1 || walkPosition.X == widthMatrix - 1 || walkPosition.Y == lenghtMatrix - 1 || matrix[walkPosition.X, walkPosition.Y] > 0)
            {
                timer.Stop();
                SaveDatabeseClick();
                MainMenuVisible();
                return;
            }
            if (matrix[walkPosition.X, walkPosition.Y] == (int)MatrixObject.Food)
            {
                lastSegment++;
                GenerateFood();
            }
            scoreText.Text = (lastSegment - 3).ToString(); 
            matrix[walkPosition.X, walkPosition.Y] = 1;
            matrix[headPosition.X, headPosition.Y]++;

            for (int i = 1; i < widthMatrix - 1; i++)
            {
                for (int j = 1; j < lenghtMatrix - 1; j++)
                {
                    if (matrix[i, j] == lastSegment)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (matrix[i, j] > 1)
                    {
                        matrix[i, j]++;
                    }
                }
            }
            headPosition = walkPosition;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - lastKeyPressTime;
            if (elapsed.TotalMilliseconds < 200) 
                return;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (direction != SnakeDirection.Down)
                        direction = SnakeDirection.Up;
                    break;
                case Keys.Right:
                    if (direction != SnakeDirection.Left)
                        direction = SnakeDirection.Right;
                    break;
                case Keys.Down:
                    if (direction != SnakeDirection.Up)
                        direction = SnakeDirection.Down;
                    break;
                case Keys.Left:
                    if (direction != SnakeDirection.Right)
                        direction = SnakeDirection.Left;
                    break;
                case Keys.Space:
                    if (timer.Enabled)
                        timer.Stop();
                    else
                        timer.Start();
                    break;
            }
            lastKeyPressTime = DateTime.Now;
        }


        private void GenerateFood()
        {
            Point foodPosition;
            do
            {
                foodPosition = new Point(random.Next(1, widthMatrix - 1), random.Next(1, lenghtMatrix - 1));
            } while (matrix[foodPosition.X, foodPosition.Y] != 0);
            matrix[foodPosition.X, foodPosition.Y] = (int)MatrixObject.Food;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void difficultyButton_Click(object sender, EventArgs e)
        {
            easyButton.Visible = true;
            mediumButton.Visible = true;
            hardButton.Visible = true;
            expertButton.Visible = true;
        }
        private void easyButton_Click(object sender, EventArgs e)
        {
            second = 2000;
            DifficultyVisible();
        }
        private void mediumButton_Click(object sender, EventArgs e)
        {
            second = 1000;
            DifficultyVisible();
        }
        private void hardButton_Click(object sender, EventArgs e)
        {
            second = 500;
            DifficultyVisible();
        }
        private void expertButton_Click(object sender, EventArgs e)
        {
            second = 250;
            DifficultyVisible();
        }
        private void DifficultyVisible()
        {
            easyButton.Visible = false;
            mediumButton.Visible = false;
            hardButton.Visible = false;
            expertButton.Visible = false;
        }
        /////////////////////TXT FILES DATABASE//////////////////////
        private void PlayerList()
        {
            listBox1.Items.Clear();
            textBox1.MaxLength = 5;

            foreach (var player in players.OrderByDescending(o => o.Score).Take(10))
            {
                listBox1.Items.Add($"{player.Name}: {player.Score} Score");
            }
        }
        private void UploadPlayers()
        {
            try
            {
                string[] lines = File.ReadAllLines("..\\..\\..\\ratings.txt");
                foreach (var line in lines)
                {
                    string[] info = line.Split(' ');
                    string name = info[0];
                    int score = int.Parse(info[1]);

                    players.Add(new PlayerRanking { Name = name, Score = score });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading notebook: " + ex.Message);
            }
        }
        private void SaveDatabeseClick()
        {
            string name = textBox1.Text;
            int score;

            if (int.TryParse(scoreText.Text, out score))
            {
                players.Add(new PlayerRanking { Name = name, Score = score });
                PlayerList();
                textBox1.Clear();
                try
                {
                    using (StreamWriter sw = File.AppendText("..\\..\\..\\ratings.txt"))
                    {
                        sw.WriteLine($"{name} {score}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while writing to notepad: " + ex.Message);
                }
            }
        }


    }
}