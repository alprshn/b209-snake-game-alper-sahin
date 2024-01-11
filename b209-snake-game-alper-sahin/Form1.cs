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
        int lastSegment;

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
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
            sizeMatrix = 20;
            matrix = new int[sizeMatrix, sizeMatrix];
            Initialize();
        }

        private void Initialize()
        {
            matrix[2, 2] = (int)MatrixObject.Food;
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
                    if (matrix[i,j] == 0)
                    {
                        graphics.FillRectangle(Brushes.White, i * sizeCell.Width + 1, j * sizeCell.Height + 1, sizeCell.Width - 2, sizeCell.Height - 2);

                    }
                    else if (matrix[i,j] == (int)MatrixObject.Food)
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
                    else if (matrix[i, j] == 1)
                    {
                        switch (direction) 
                        {
                            case SnakeDirection.Up:
                                matrix[i , j-1] = 1; break;
                            case SnakeDirection.Right:
                                matrix[i + 1, j] = 1; break;
                            case SnakeDirection.Down:
                                matrix[i, j + 1] = 1; break;
                            case SnakeDirection.Left:
                                matrix[i - 1, j] = 1; break;
                        }

                        matrix[i - 1, j]++;
                    }
                }
            }
        }
    }
}