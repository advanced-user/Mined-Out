namespace Engine.Models.Player
{
    public class Player : EmptyCell
    {
        public int I { get; set; }
        public int J { get; set; }
        public string Img { get; set; }
        public int NumberOfBombs { get; set; }
        public Player(int numberOfBombs, string img, double x, double y, int i, int j, int size)
            : base(size, x, y)
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
