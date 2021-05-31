using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.GameObjects
{
    public class Flag : GameObject
    {
        public Flag(int size, string img, double x, double y, int i, int j)
            : base(size, img, x, y, i, j)
        {
            I = i;
            J = j;
            Img = img;
            Coordinates = new Coordinates(x, y);
            Size = new Size(size, size);
        }
    }
}
