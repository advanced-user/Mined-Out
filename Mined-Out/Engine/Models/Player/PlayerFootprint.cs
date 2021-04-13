namespace Engine.Models
{
	public class PlayerFootprint
	{
        public CellIndices CellIndices { get; set; }

        public PlayerFootprint(int i, int j)
        {
            CellIndices = new CellIndices(i, j);
        }
    }
}
