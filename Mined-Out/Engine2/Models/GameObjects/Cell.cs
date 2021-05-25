namespace Engine.Models
{
    public class Cell : EmptyCell
	{
        public object Value { get; set; }

        public Cell(object value, double x, double y, int size) : base(size, x, y) 
        {
            Value = value;
            Coordinates = new Coordinates(x, y);
            Size = new Size(size, size);
        }
    }
}