namespace Engine.Models
{
    public struct FieldSize
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public FieldSize(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}