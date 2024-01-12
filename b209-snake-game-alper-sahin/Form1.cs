using System.Drawing;
using System.Windows.Forms;

namespace b209_snake_game_alper_sahin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer timer;
        int sizeMatrix;
        int[,] matrix;
        SnakeDirection direction;
        Point headPosition;
        int lastSegment;
        Random random;
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
            random = new Random();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Stop();
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            pictureBox1.Visible = true;
            scoreText.Visible = true;
            label1.Visible = true;
            timer.Start();
            timer.Tick += Timer_Tick;
            sizeMatrix = 20;
            matrix = new int[sizeMatrix, sizeMatrix];
            Initialize();
            playButton.Visible = false;
            difficultyButton.Visible = false;
            howPlayButton.Visible = false;
            exitButton.Visible = false;
        }
        private void MainMenuVisible()
        {

        }
        private void Initialize()
        {
            timer.Start();
            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
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

            graphics.FillRectangle(Brushes.Gray, 0, 0, pictureBox1.Width, pictureBox1.Height);

            SizeF sizeCell = new SizeF((float)pictureBox1.Width / sizeMatrix, (float)pictureBox1.Height / sizeMatrix);

            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        graphics.FillRectangle(Brushes.White, i * sizeCell.Width + 1, j * sizeCell.Height + 1, sizeCell.Width - 2, sizeCell.Height - 2);

                    }
                    else if (matrix[i, j] == (int)MatrixObject.Food)
                    {
                        graphics.FillRectangle(Brushes.Red, i * sizeCell.Width + 1, j * sizeCell.Height + 1, sizeCell.Width - 2, sizeCell.Height - 2);

                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.Blue, i * sizeCell.Width + 1, j * sizeCell.Height + 1, sizeCell.Width - 2, sizeCell.Height - 2);

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
            if (walkPosition.X < 0 || walkPosition.Y < 0 || walkPosition.X == sizeMatrix || walkPosition.Y == sizeMatrix || matrix[walkPosition.X, walkPosition.Y] > 0)
            {
                timer.Stop();
                Thread.Sleep(1000);
                Initialize();
                return;
            }
            if (matrix[walkPosition.X, walkPosition.Y] == (int)MatrixObject.Food)
            {
                lastSegment++;
                GenerateFood();
            }
            scoreText.Text = (lastSegment - 3).ToString(); // score board
            matrix[walkPosition.X, walkPosition.Y] = 1;
            matrix[headPosition.X, headPosition.Y]++;

            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                case 'W':
                    if (direction != SnakeDirection.Down)
                        direction = SnakeDirection.Up;
                    break;
                case 'D':
                case 'd':
                    if (direction != SnakeDirection.Left)
                        direction = SnakeDirection.Right;
                    break;
                case 'S':
                case 's':
                    if (direction != SnakeDirection.Up)
                        direction = SnakeDirection.Down;
                    break;
                case 'A':
                case 'a':
                    if (direction != SnakeDirection.Right)
                        direction = SnakeDirection.Left;
                    break;
                case ' ':
                    if (timer.Enabled)
                        timer.Stop();
                    else
                        timer.Start();
                    break;

            }
        }

        private void GenerateFood()
        {
            Point foodPosition;
            do
            {
                foodPosition = new Point(random.Next() % sizeMatrix, random.Next() % sizeMatrix);
            } while (matrix[foodPosition.X, foodPosition.Y] != 0);
            matrix[foodPosition.X, foodPosition.Y] = (int)MatrixObject.Food;
        }


    }
}