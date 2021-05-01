using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Math
{
	public class Graph
	{
		public Node[,] Field { get; set; }

		public Graph(Cell[,] field)
		{
			FillGraph(field);
		}

		private void FillGraph(Cell[,] field)
		{
			Field = new Node[field.GetLength(0), field.GetLength(1)];

			for(int i = 0; i < field.GetLength(0); i++)
			{
				Node node = new Node();
				if(!(field[0, i].Value is Bomb) && !(field[0, i].Value is Barrier))
				{
					node.IsEmpty = true;
					node.IsFinish = true;
					node.IsMarked = false;
				}
				else
				{
					node.IsMarked = false;
					node.IsFinish = false;
					node.IsEmpty = false;
				}

				Field[0, i] = node;
			}

			for(int i = 1; i < field.GetLength(0) - 1; i++)
			{
				for (int j = 0; j < field.GetLength(1); j++)
				{
					Node node = new Node();

					if (!(field[i, j].Value is Bomb) && !(field[i, j].Value is Barrier))
					{
						node.IsEmpty = true;
						node.IsMarked = false;
						node.IsFinish = false;
					}
					else
					{
						node.IsEmpty = false;
						node.IsFinish = false;
						node.IsMarked = false;
					}
					Field[i, j] = node;
				}
			}

			for(int i = 0; i < field.GetLength(0); i++)
			{
				Node node = new Node();

				if (field[field.GetLength(1)-1, i].Value is Player)
				{
					node.IsMarked = true;
					node.IsEmpty = true;
					node.IsFinish = false;
				}
				else if(!(field[field.GetLength(1) - 1, i].Value is Barrier) && !(field[field.GetLength(1) - 1, i].Value is Bomb))
				{
					node.IsFinish = false;
					node.IsEmpty = true;
					node.IsMarked = false;
				}
				else
				{
					node.IsFinish = false;
					node.IsEmpty = false;
					node.IsMarked = false;
				}

				Field[field.GetLength(0) - 1,i] = node;
			}

			for(int i = 0; i < Field.GetLength(0); i++)
			{
				for(int j = 0; j < Field.GetLength(1); j++)
				{
					if(Field[i, j].IsFinish)
					{
						Console.Write("F");
					}
					else if(Field[i, j].IsEmpty)
					{
						Console.Write("0");
					}
					else
					{
						Console.Write("1");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
