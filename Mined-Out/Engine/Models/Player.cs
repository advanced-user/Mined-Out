namespace Engine.Models
{
    public class Player
    {
        public Coordinates Coordinates { get; set; }

        public Player(double x, double y)
        {
            Coordinates = new Coordinates(x, y);
        }
    }
}