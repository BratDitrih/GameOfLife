using System.Transactions;

namespace GameOfLifeController
{
    public class GameOfLIfeController
    {
        private bool[,] _currentGeneration;
        private int _width, _height;
        private int _density;

        public GameOfLIfeController(int width, int height, int density)
        {
            _currentGeneration = new bool[width, height];
            _width = width;
            _height = height;
            _density = density;

            FillCurrentGeneration();
        }

        public bool[,] GetCurrentGeneration()
        {
            var field = CopyCurrentGeneration();
            CalculateNextGeneration();
            return field;
        }

        public void AddCell(int x, int y)
        {
            if (IsCellInsideField(x, y))
            {
                _currentGeneration[x, y] = true;
            }
        }

        public void RemoveCell(int x, int y)
        {
            if (IsCellInsideField(x, y))
            {
                _currentGeneration[x, y] = false;
            }
        }

        private void FillCurrentGeneration()
        {
            Random random = new Random();

            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    _currentGeneration[x, y] = random.Next(0,_density + 1) == 0;
                }
            }
        }

        private void CalculateNextGeneration()
        {
            var nextGeneration = new bool[_width, _height];

            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    int neighborsCount = CalculateNeighbors(x, y);
                    bool cellIsAlive = _currentGeneration[x, y];

                    if (!cellIsAlive && neighborsCount == 3)
                    {
                        nextGeneration[x, y] = true;
                    }
                    else if (cellIsAlive && (neighborsCount < 2 || neighborsCount > 3))
                    {
                        nextGeneration[x, y] = false;
                    }
                    else
                    {
                        nextGeneration[x, y] = _currentGeneration[x, y];
                    }
                }
            }
            _currentGeneration = nextGeneration;
        }

        private int CalculateNeighbors(int x, int y)
        {
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;

                    int column = (x + i + _width) % _width;
                    int row = (y + j + _height) % _height;

                    if (_currentGeneration[column, row]) count++;
                }
            }
            return count;
        }

        private bool[,] CopyCurrentGeneration()
        {
            var copiedField = new bool[_width, _height];

            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    copiedField[x, y] = _currentGeneration[x, y];
                }
            }
            return copiedField;
        }

        private bool IsCellInsideField(int x, int y)
        {
            if (x >= 0 && x < _currentGeneration.GetLength(0) &&
                y >= 0 && y < _currentGeneration.GetLength(1)) return true;
            return false;
        }
    }
}