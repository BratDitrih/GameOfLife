using GameOfLifeController;

namespace GameOfLife__WinForms_
{
    public partial class Form1 : Form
    {
        private GameOfLIfeController _gameOfLifeController;
        private Graphics _graphics;
        private int _resolution;
        private int _density;
        private int _height;
        private int _width;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _resolution = ResolutionTrackBar.Value;
            _density = DensityTrackBar.Minimum + DensityTrackBar.Maximum - DensityTrackBar.Value;
            _width = GameFieldImage.Width / _resolution;
            _height = GameFieldImage.Height / _resolution;

            _gameOfLifeController = new GameOfLIfeController(_width, _height, _density);
            Timer.Interval = 40;
            Timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void DrawNextGeneration()
        {
            var field = _gameOfLifeController.GetCurrentGeneration();
            GameFieldImage.Image = new Bitmap(GameFieldImage.Width, GameFieldImage.Height);
            _graphics = Graphics.FromImage(GameFieldImage.Image);

            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    if (field[x, y])
                    {
                        _graphics.FillRectangle(Brushes.Green, x * _resolution, y * _resolution, _resolution, _resolution);
                    }
                }
            }
        }

        private void GameFieldImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Timer.Enabled) return;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        _gameOfLifeController.AddCell(e.X / _resolution, e.Y / _resolution);
                    }
                    break;
                case MouseButtons.Right:
                    {
                        _gameOfLifeController.RemoveCell(e.X / _resolution, e.Y / _resolution);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}