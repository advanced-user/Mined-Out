namespace Engine.Models
{
    public class Bomb
    {
        public CellIndices CellIndices { get; set; }

        public Bomb(int i, int j)
        {
            CellIndices = new CellIndices(i, j);
        }
    }
}