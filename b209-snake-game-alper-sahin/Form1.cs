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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
            sizeMatrix = 10;
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

            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    graphics.FillRectangle(Brushes.White, i*(pictureBox1.Width/sizeMatrix) +1, j * (pictureBox1.Height / sizeMatrix)+1, (pictureBox1.Width / sizeMatrix) -2, (pictureBox1.Height / sizeMatrix) -2);
                }
            }   


            pictureBox1.BackgroundImage = bitmap;
        }
    }
}