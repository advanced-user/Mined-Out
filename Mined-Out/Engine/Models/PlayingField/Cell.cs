namespace Engine.Models
{
    public struct Cell
    {
        public readonly Size Size;
        public Coordinates Coordinates;
        public object Value;

        public Cell(object value,double x, double y, int size)
        {
            Value = value;
            Coordinates = new Coordinates(x, y);
            Size = new Size(size, size);
        }
    }
}