namespace Engine.Models.Player
{
    public class Player : GameObject
    {
        public int NumberOfBombs { get; set; }
        public Player(int numberOfBombs, string img, double x, double y, int i, int j, int size)
            : base(size, img, x, y, i, j)
        {
            I = i;
            J = j;
            Img = img;
            NumberOfBombs = numberOfBombs;
			Coordinates = new Coordinates(x, y);
			Size = new Size(size, size);
        }
    }
}
