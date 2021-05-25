using System.Drawing;


namespace GUI
{
	public class Block
	{
		public int Top { get; set; }
		public int Left { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public Color Color { get; set; }

		public Block(int top, int left, int width, int height, Color color)
		{
			Top = top;
			Left = left;
			Width = width;
			Height = height;
			Color = color;
		}

		public void Draw(Graphics graphics)
		{
			SolidBrush b = new SolidBrush(Color);
			Pen p = new Pen(Color.Black);
			graphics.DrawRectangle(p, Left, Top, Width, Height);
			graphics.FillRectangle(b, Left, Top, Width, Height);
		}
	}
}
