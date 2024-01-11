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


        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.FillRectangle(Brushes.Gray, 0, 0, pictureBox1.Width,pictureBox1.Height);

            pictureBox1.BackgroundImage = bitmap;
        }
    }
}