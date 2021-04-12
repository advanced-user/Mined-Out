namespace Engine.Models
{
    public class Barrier
    {
        public Coordinates Coordinates { get; set; }

        public Barrier(double x, double y)
        {
            Coordinates = new Coordinates(x ,y);
        }
    }
}