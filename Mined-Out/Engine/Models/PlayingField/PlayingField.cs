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
            StartAndFinish(indexX, 0);

            for (int i = 1; i < FieldSize.Height - 1; i++)
            {
                Barrier barrier1 = new Barrier(Cells[0, i].Coordinates.X, Cells[0, i].Coordinates.Y);
                Cells[i, 0].Value = barrier1;
                
                Barrier barrier2 = new Barrier(Cells[0, i].Coordinates.X, Cells[0, i].Coordinates.Y);
                Cells[i, Cells.GetLength(1) - 1].Value = barrier2;
                
            }
            
            StartAndFinish(indexX, Cells.GetLength(1) - 1);
        }

        private void StartAndFinish(int indexX, int indexY)
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
    }
}