using Engine.Models;
using System;
using System.Collections.Generic;

namespace Engine.Math
{
	public class Graph
	{
		public Node[,] Field { get; set; }
		public Player Player { get; set; }

		public Graph(Cell[,] field, Player player)
		{
			Player = player;
			FillGraph(field);
		}

		private void FillGraph(Cell[,] field)
		{
			Field = new Node[field.GetLength(0), field.GetLength(1)];

			for(int i = 0; i < field.GetLength(0); i++)
			{
				Node node = new Node();
				node.I = 0;
				node.J = i;
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
					node.I = i;
					node.J = j;

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
				node.I = field.GetLength(1) - 1;
				node.J = i;

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
		}

		public bool IsValid()
		{
			List<Node> nodes = new List<Node>();
			nodes.Add(Field[Player.I, Player.J]);


			for (int i = 0; i < nodes.Count;)
			{
				if (nodes[i].I - 1 >= 0)
				{
					if (Field[nodes[i].I - 1, nodes[i].J].IsEmpty && !Field[nodes[i].I - 1, nodes[i].J].IsMarked)
					{
						Field[nodes[i].I - 1, nodes[i].J].IsMarked = true;
						nodes.Add(Field[nodes[i].I - 1, nodes[i].J]);
					}
				}
				if (nodes[i].I + 1 < Field.GetLength(0))
				{
					if (Field[nodes[i].I + 1, nodes[i].J].IsEmpty && !Field[nodes[i].I + 1, nodes[i].J].IsMarked)
					{
						Field[nodes[i].I + 1, nodes[i].J].IsMarked = true;
						nodes.Add(Field[nodes[i].I - 1, nodes[i].J]);
					}
				}
				if (nodes[i].J - 1 > 0)
				{
					if (Field[nodes[i].I, nodes[i].J - 1].IsEmpty && !Field[nodes[i].I, nodes[i].J - 1].IsMarked)
					{
						Field[nodes[i].I, nodes[i].J - 1].IsMarked = true;
						nodes.Add(Field[nodes[i].I, nodes[i].J - 1]);
					}
				}
				if (nodes[i].J + 1 < Field.GetLength(1))
				{
					if (Field[nodes[i].I, nodes[i].J + 1].IsEmpty && !Field[nodes[i].I, nodes[i].J + 1].IsMarked)
					{
						Field[nodes[i].I, nodes[i].J + 1].IsMarked = true;
						nodes.Add(Field[nodes[i].I, nodes[i].J + 1]);
					}
				}

				nodes.Remove(nodes[i]);
			}
			
			

			for(int i = 0; i < Field.GetLength(1); i++)
			{
				if (Field[0, i].IsFinish && Field[0, i].IsMarked)
					return true;
			}

			return false;
		}

		private void Show()
		{
			for (int i = 0; i < Field.GetLength(0); i++)
			{
				for (int j = 0; j < Field.GetLength(1); j++)
				{
					if (Field[i, j].IsFinish)
					{
						Console.Write("F");
					}
					else if (Field[i, j].IsEmpty)
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
