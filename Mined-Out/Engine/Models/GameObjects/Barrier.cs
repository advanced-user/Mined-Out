namespace Engine.Models
{
	public class Barrier : GameObject
	{
        public Barrier(int size, string img, double x, double y, int i, int j)
            : base(size, img, x, y, i, j)
        {
            I = i;
            J = j;
            Img = img;
            Coordinates = new Coordinates(x, y);
            Size = new Size(size, size);
        }
    }
}
