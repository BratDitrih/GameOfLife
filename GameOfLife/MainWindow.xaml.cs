using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using GameOfLifeController;

namespace GameOfLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameOfLIfeController GameController;
        private DispatcherTimer _timer = new DispatcherTimer();
        public int Resolution { get; set; } = 1;
        public int Density { get; set; } = 1;
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawNextGeneration()
        {
            DrawingImage drawingImage = null;
            Thread newThread = new Thread(
                () =>
                {
                    drawingImage = CreateImage();
                });
            newThread.Start();
            newThread.Join();

            Image image = new Image();
            image.Source = drawingImage;
            image.Stretch = Stretch.None;
            image.HorizontalAlignment = HorizontalAlignment.Left;
            image.VerticalAlignment = VerticalAlignment.Top;

            ImageBorder.Child = image;
            ImageBorder.AllowDrop = false;
        }

        private DrawingImage CreateImage()
        {
            var field = GameController.GetCurrentGeneration();

            GeometryGroup geometryGroup = new GeometryGroup();
            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y])
                    {
                        RectangleGeometry rectangle = new RectangleGeometry(new Rect(
                            new Point(x * Resolution, y * Resolution),
                            new Size(Resolution, Resolution)
                            ));
                        geometryGroup.Children.Add(rectangle);
                    }
                }
            }

            GeometryDrawing geometryDrawing = new GeometryDrawing(
                Brushes.Green,
                new Pen(Brushes.Black, 1),
                geometryGroup
                );

            DrawingImage drawingImage = new DrawingImage(geometryDrawing);

            drawingImage.Freeze();

            return drawingImage;
        }

        [Obsolete]
        private void OldMethod()
        {
            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext context = drawingVisual.RenderOpen())
            {
                for (int i = 0; i < ImageWidth; i++)
                {
                    for (int j = 0; j < ImageHeight; j++)
                    {
                        context.DrawRectangle(
                            Brushes.Green,
                            new Pen(Brushes.Black, 1),
                            new Rect(i, j, Resolution, Resolution)
                            );
                    }
                }
                context.DrawRectangle(
                    Brushes.Green,
                    new Pen(Brushes.Black, 1),
                    new Rect(0, 0, Resolution, Resolution)
                    );
            }
            RenderTargetBitmap bmp = new RenderTargetBitmap(ImageWidth, ImageHeight, ImageWidth, ImageHeight, PixelFormats.Pbgra32);
            bmp.Render(drawingVisual);
            //GameField.Source = bmp;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            ImageWidth = (int)ImageBorder.ActualWidth / Resolution;
            ImageHeight = (int)ImageBorder.ActualHeight / Resolution;
            GameController = new GameOfLIfeController(ImageWidth, ImageHeight, (int)DensitySlider.Minimum + (int)DensitySlider.Maximum - Density);
            _timer.Tick += Timer_Tick;
            _timer.Interval = new TimeSpan(40);
            _timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            DrawNextGeneration();
        }
    }
}
