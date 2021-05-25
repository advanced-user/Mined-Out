using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
	public abstract class GameObject : EmptyCell
	{
		public int I { get; set; }
		public int J { get; set; }
		public string Img { get; set; }
		public GameObject(int size, string img, double x, double y, int i, int j) : base(size, x, y)
		{
			I = i;
			J = j;
			Img = img;
			Coordinates = new Coordinates(x, y);
			Size = new Size(size, size);
		}
	}
}
