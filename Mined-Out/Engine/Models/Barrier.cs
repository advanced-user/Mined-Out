namespace Engine.Models
{
    public class Barrier
    {
        public CellIndices CellIndices { get; set; }

        public Barrier(int i, int j)
        {
            CellIndices = new CellIndices(i, j);
        }
    }
}