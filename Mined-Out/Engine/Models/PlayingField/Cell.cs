namespace Engine.Models
{
    public struct Cell
    {
        public Coordinates Coordinates { get; set; }
        public double Width { get; set; }
        public  double Height { get; set; }

        public Cell(double x, double y, double width, double height)
        {
            Coordinates = new Coordinates(x, y);
            Width = width;
            Height = height;
        }
    }
}