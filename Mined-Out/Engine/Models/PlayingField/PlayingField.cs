using System;

namespace Engine.Models
{
    public class PlayingField
    {
        public Cell[,] Cells { get; set; }
        public Player Player { get; set; }
        public  Size FieldSize { get; set; }
        public int CellSize { get; set; }

        public PlayingField(int numberOfBombs, int width, int height, int cellSize)
        {
            FieldSize = new Size(width, height);
            CellSize = cellSize;

            FieldGeneration(numberOfBombs);
        }
        
        private void FieldGeneration(int numberOfBombs)
        {
            GenerateCells();
            GenerationOfBarriers();
            GenerateBombes(numberOfBombs);
            GeneratePlayer();
        }

        private void GenerateCells()
        {
            int width = (int)FieldSize.Width / CellSize;
            int height = (int)FieldSize.Height / CellSize;

            Cells = new Cell[width, height];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int x = width * j;
                    int y = height * i;

                    Cell cell = new Cell(null, x, y, CellSize);
                    Cells[i, j] = cell;
                }
            }
        }
        
        private void GenerationOfBarriers()
        {
            int indexX = (int)(FieldSize.Width / 2);
            StartAndFinishBarriers(indexX, 0);

            for (int i = 1; i < FieldSize.Height - 1; i++)
            {
                Barrier barrier1 = new Barrier(Cells[0, i].Coordinates.X, Cells[0, i].Coordinates.Y);
                Cells[i, 0].Value = barrier1;
                
                Barrier barrier2 = new Barrier(Cells[0, i].Coordinates.X, Cells[0, i].Coordinates.Y);
                Cells[i, Cells.GetLength(1) - 1].Value = barrier2;
                
            }
            
            StartAndFinishBarriers(indexX, Cells.GetLength(1) - 1);
        }

        private void StartAndFinishBarriers(int indexX, int indexY)
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                if (i != indexX - 1 && i != indexX && i != indexX + 1)
                {
                    Barrier barrier = new Barrier(Cells[0, i].Coordinates.X, Cells[0, i].Coordinates.Y);
                    Cells[indexY, i].Value = barrier;
                }
            }
        }

        private void GenerateBombes(int numberOfBombs)
        {
            for (int i = 0; i < numberOfBombs; i++)
            {
                Random rnd = new Random();

                int x = rnd.Next(1, Cells.GetLength(1) - 1);
                int y = rnd.Next(2, Cells.GetLength(0) - 2);

                Bomb bomb = new Bomb(Cells[y,x].Coordinates.X, Cells[y,x].Coordinates.Y);
                Cells[y,x].Value = bomb;
            }
        }

        private void GeneratePlayer()
        {
            int indexX = Cells.GetLength(1) / 2;
            int indexY = Cells.GetLength(0) - 1;

            Player = new Player(Cells[indexY, indexX].Coordinates.X, Cells[indexY, indexX].Coordinates.Y);
            Cells[indexY, indexX].Value = Player;
        }
    }
}