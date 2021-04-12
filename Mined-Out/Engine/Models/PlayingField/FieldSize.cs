namespace Engine.Models
{
    public struct FieldSize
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public FieldSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}