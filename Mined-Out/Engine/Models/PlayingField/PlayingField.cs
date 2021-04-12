namespace Engine.Models
{
    public class PlayingField
    {
        public Cell[,] Cells { get; set; }
        public Player Player { get; set; }
        public Bomb[] Bombs { get; set; }
        public Barrier[] Barriers { get; set; }
        public  Size FieldSize { get; set; }
        public int CellSize { get; set; }

        public PlayingField(Player player,int numberOfBombs, int width, int height, int cellSize)
        {
            FieldSize = new Size(width, height);
            CellSize = cellSize;
            Player = player;
            Bombs = new Bomb[numberOfBombs];
            Barriers = new Barrier[(int)CountTheNumberOfBarriers()];
            
            GenerateCells();
            FieldGeneration(numberOfBombs);
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
        
        private double CountTheNumberOfBarriers()
        {
            return 2 * FieldSize.Height + 2 * FieldSize.Width - 10;
        }
        
        private void FieldGeneration(int numberOfBombs)
        {
            GenerationOfBarriers();
        }

        private void GenerationOfBarriers()
        {
            double coordinateX = FieldSize.Width / 2;

            for (int i = 0; i < FieldSize.Width; i++)
            {
                if (i != coordinateX - 1 && i != coordinateX && i != coordinateX + 1)
                {
                    Barrier barrier = new Barrier(i, 0);
                    
                }
            }

            for (int i = 1; i < FieldSize.Height - 1; i++)
            {
                
            }
        }
    }
}