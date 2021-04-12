namespace Engine.Models
{
    public class Bomb
    {
        public Coordinates Coordinates { get; set; }

        public Bomb(double x, double y)
        {
            Coordinates = new Coordinates(x, y);
        }
    }
}