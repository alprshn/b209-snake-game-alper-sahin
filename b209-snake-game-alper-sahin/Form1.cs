using System.Drawing;
using System.Reflection;
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
        int second = 100;

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
        private void TxtRead()
        {

            //StreamReader streamReader = File.OpenText("..\\..\\..\\ratings.txt");

            string filePath = "..\\..\\..\\ratings.txt";
            
            List<PlayerRanking> players = ReadPlayer(filePath);

            players = players.OrderByDescending(o => o.Score).ToList();

            listView1.Items.Clear();

            foreach (var player in players)
            {
                ListViewItem item = new ListViewItem(player.Ranking.ToString());
                item.SubItems.Add(player.Name);
                item.SubItems.Add(player.Score.ToString());
                listView1.Items.Add(item);
            }
        }

        private List<PlayerRanking> ReadPlayer(string filePath)
        {
            List<PlayerRanking> players = new List<PlayerRanking>();

            // Dosyayý satýr satýr oku
            foreach (string line in File.ReadAllLines(filePath))
            {
                // Satýrdaki boþluklarý temizle
                string cleanLine = line.Trim();

                // Satýr boþsa atla
                if (string.IsNullOrEmpty(cleanLine))
                    continue;

                // Satýrý parçala
                string[] parts = cleanLine.Split('\t');

                // Parçalarý kontrol et
                if (parts.Length >= 3)
                {
                    if (int.TryParse(parts[0].Replace(".", ""), out int rank) && int.TryParse(parts[2], out int score))
                    {
                        // Oyuncu nesnesini oluþtur ve listeye ekle
                        PlayerRanking player = new PlayerRanking(rank, parts[1], score);
                        players.Add(player);
                    }
                }
            }

            return players;
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            MainMenuVisible();
            TxtRead();
        }
        private void playButton_Click(object sender, EventArgs e)
        {

            random = new Random();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = second;
            PlayVisible();
            timer.Start();
            timer.Tick += Timer_Tick;
            sizeMatrix = 20;
            matrix = new int[sizeMatrix, sizeMatrix];
            label3.Text = timer.Interval.ToString();
            Initialize();

        }
        private void PlayVisible()
        {
            this.KeyPreview = true;
            pictureBox1.Visible = true;
            scoreText.Visible = true;
            label1.Visible = true;
            label3.Visible = true;

            playButton.Visible = false;
            difficultyButton.Visible = false;
            exitButton.Visible = false;
            label2.Visible = false;
        }

        private void MainMenuVisible()
        {


            //timer.Stop();
            pictureBox1.Visible = false;
            scoreText.Visible = false;
            label1.Visible = false;
            label3.Visible = false;

            playButton.Visible = true;
            difficultyButton.Visible = true;
            exitButton.Visible = true;
            label2.Visible = true;
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
                //Thread.Sleep(1000);
                MainMenuVisible();
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
            second = 2000; // 2 saniye
            label2.Text = second.ToString();
            DifficultyVisible();
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            second = 1000; // 1 saniye
            label2.Text = second.ToString();
            DifficultyVisible();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            second = 500; // 0.5 saniye
            label2.Text = second.ToString();
            DifficultyVisible();

        }

        private void expertButton_Click(object sender, EventArgs e)
        {
            second = 250; // 0.25 saniye
            label2.Text = second.ToString();
            DifficultyVisible();

        }
        private void DifficultyVisible()
        {
            easyButton.Visible = false;
            mediumButton.Visible = false;
            hardButton.Visible = false;
            expertButton.Visible = false;
        }
    }
}