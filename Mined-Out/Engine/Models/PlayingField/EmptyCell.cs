namespace Engine.Models
{
	public abstract class EmptyCell
	{
		public Size Size { get; set; }
		public Coordinates Coordinates { get; set; }

		public EmptyCell(int size, double x, double y)
		{
			Size = new Size(size, size);
			Coordinates = new Coordinates(x, y);
		}
	}
}
