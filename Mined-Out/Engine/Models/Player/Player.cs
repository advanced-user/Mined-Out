namespace Engine.Models
{
    public class Player
    {
        public CellIndices CellIndices { get; set; }
        public int NumberOfBombs { get; set; }

        public Player(int i, int j)
        {
            CellIndices = new CellIndices(i, j);
        }
    }
}