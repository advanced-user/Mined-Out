namespace Engine.Models
{
	public class Barrier : EmptyCell
	{
        public int I { get; set; }
        public int J { get; set; }
        public string Img { get; set; }
        public Barrier(int size, string img, double x, double y, int i, int j)
            : base(size, x, y)
        {
            I = i;
            J = j;
            Img = img;
            Coordinates = new Coordinates(x, y);
            Size = new Size(size, size);
        }
    }
}
