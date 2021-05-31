using Engine.Models;
using Engine.Models.Player;
using System.Drawing;


namespace GUI
{
	public class Block
	{
		public int Top { get; set; }
		public int Left { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public object Value { get; set; }
		public bool IsBlownUp { get; set; }
		public int NumberOfBombs { get; set; }


		public Block(int top, int left, int width, int height, int numberOfBombs, object value)
		{
			Top = top;
			Left = left;
			Width = width;
			Height = height;
			NumberOfBombs = numberOfBombs;
			Value = value;
		}

		public void Draw(Graphics graphics, bool isLoose)
		{
			if(Value is Barrier)
			{
				SolidBrush b = new SolidBrush(Color.Black);
				Pen p = new Pen(Color.Black);
				graphics.DrawRectangle(p, Left, Top, Width, Height);
				graphics.FillRectangle(b, Left, Top, Width, Height);
			}
			else if(Value is Player)
			{
				Pen p = new Pen(Color.White);
				graphics.DrawRectangle(p, Left, Top, Width, Height);
				Font font = new Font("Arial", 14, FontStyle.Regular);
				graphics.DrawString(NumberOfBombs.ToString(), font, Brushes.Green, Left, Top);
			}
			else if(Value is PlayerFootprint)
			{
				Pen p = new Pen(Color.Black);
				graphics.DrawRectangle(p, Left, Top, Width, Height);
				Image image = Image.FromFile("img/Footprint.png");
				graphics.DrawImage(image, Left, Top);
			}
			else if(Value is Bomb && isLoose)
			{
				Pen p = new Pen(Color.Black);
				graphics.DrawRectangle(p, Left, Top, Width, Height);

				Image image = Image.FromFile("img/bomb.png");
				graphics.DrawImage(image, Left, Top);
			}
			else if(Value is Engine.Models.GameObjects.DetonatedBomb)
			{
				Pen p = new Pen(Color.Black);
				graphics.DrawRectangle(p, Left, Top, Width, Height);

				Image image = Image.FromFile("img/boom.png");
				graphics.DrawImage(image, Left, Top);
			}
			else if(Value is Engine.Models.GameObjects.Flag)
			{
				Pen p = new Pen(Color.Black);
				graphics.DrawRectangle(p, Left, Top, Width, Height);

				Image image = Image.FromFile("img/flag.png");
				graphics.DrawImage(image, Left, Top);
			}
			else
			{
				SolidBrush b = new SolidBrush(Color.White);
				Pen p = new Pen(Color.Black);
				graphics.DrawRectangle(p, Left, Top, Width, Height);
				graphics.FillRectangle(b, Left, Top, Width, Height);
			}
		}
	}
}
