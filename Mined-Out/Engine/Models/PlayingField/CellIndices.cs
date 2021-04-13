namespace Engine.Models
{
	public struct CellIndices
	{
		public int I { get; set; }
		public int J { get; set; }

		public CellIndices(int i, int j)
		{
			I = i;
			J = j;
		}
	}
}
