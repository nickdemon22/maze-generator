using System;
using System.Drawing;
using System.Collections.Generic;

namespace MazeGenerator
{
    public enum CellState
    {
        Wall,
        Path,
        Start,
        Exit
    }

    public class Maze
    {
        private CellState[,] grid;
        private Random random;
        private int width;
        private int height;

        public CellState[,] Grid => grid;
        public int Width => width;
        public int Height => height;

        public Maze(int width, int height, int seed, string difficulty)
        {
            // Делаем размеры нечетными для алгоритма
            this.width = width % 2 == 0 ? width + 1 : width;
            this.height = height % 2 == 0 ? height + 1 : height;
            this.random = new Random(seed);

            InitializeGrid();
            GenerateMaze(difficulty);
            SetStartAndExit();
        }

        private void InitializeGrid()
        {
            grid = new CellState[width, height];

            // Заполняем все стенами
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = CellState.Wall;
                }
            }
        }

        private void GenerateMaze(string difficulty)
        {
            // Choose start coordinates
            int startX = 1;
            int startY = 1;

            // search algoritm
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(startX, startY));
            grid[startX, startY] = CellState.Path;

            Point[] directions = new Point[]
            {
                new Point(0, -2),
                new Point(2, 0),
                new Point(0, 2),
                new Point(-2, 0)
            };

            while (stack.Count > 0)
            {
                Point current = stack.Peek();

                // contain
                List<Point> availableDirections = new List<Point>();

                foreach (var dir in directions)
                {
                    int newX = current.X + dir.X;
                    int newY = current.Y + dir.Y;

                    if (newX > 0 && newX < width - 1 &&
                        newY > 0 && newY < height - 1 &&
                        grid[newX, newY] == CellState.Wall)
                    {
                        availableDirections.Add(dir);
                    }
                }

                if (availableDirections.Count > 0)
                {
                    // random angle
                    Point dir = availableDirections[random.Next(availableDirections.Count)];

                    int newX = current.X + dir.X;
                    int newY = current.Y + dir.Y;

                    // way
                    grid[current.X + dir.X / 2, current.Y + dir.Y / 2] = CellState.Path;
                    grid[newX, newY] = CellState.Path;

                    stack.Push(new Point(newX, newY));
                }
                else
                {
                    // go back
                    stack.Pop();
                }
            }

            ApplyDifficulty(difficulty);
        }

        private void ApplyDifficulty(string difficulty)
        {
            int additionalWalls = 0;

            switch (difficulty)
            {
                case "Легко":
                    additionalWalls = (int)(width * height * 0.01);
                    break;
                case "Средне":
                    additionalWalls = (int)(width * height * 0.03);
                    break;
                case "Сложно":
                    additionalWalls = (int)(width * height * 0.05);
                    break;
            }

            // randomize
            for (int i = 0; i < additionalWalls; i++)
            {
                int x = random.Next(1, width - 1);
                int y = random.Next(1, height - 1);

                if (grid[x, y] == CellState.Path)
                {
                    grid[x, y] = CellState.Wall;
                }
            }
        }

        private void SetStartAndExit()
        {
            for (int x = 1; x < width; x++)
            {
                for (int y = 1; y < height; y++)
                {
                    if (grid[x, y] == CellState.Path)
                    {
                        grid[x, y] = CellState.Start;
                        goto exitSearch;
                    }
                }
            }

        exitSearch:
            for (int x = width - 2; x > 0; x--)
            {
                for (int y = height - 2; y > 0; y--)
                {
                    if (grid[x, y] == CellState.Path)
                    {
                        grid[x, y] = CellState.Exit;
                        return;
                    }
                }
            }
        }
    }
}