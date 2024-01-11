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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
            sizeMatrix = 10;
            matrix = new int[sizeMatrix, sizeMatrix];
            Initialize();
        }

        private void Initialize()
        {
            matrix[5, 5] = 1;
            matrix[6, 5] = 2;
            matrix[7, 5] = 3;

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
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
                    else
                    {
                        graphics.FillRectangle(Brushes.Blue, i * sizeCell.Width + 1, j * sizeCell.Height + 1, sizeCell.Width - 2, sizeCell.Height - 2);

                    }
                }
            }   


            pictureBox1.BackgroundImage = bitmap;
        }
    }
}