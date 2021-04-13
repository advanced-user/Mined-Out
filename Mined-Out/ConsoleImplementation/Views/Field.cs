using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mined_Out
{
	public static class Field
	{
        public static void DrawField(Game game)
        {
            for (int i = 0; i < game.PlayingField.Cells.GetLength(0); i++)
            {
                for (int j = 0; j < game.PlayingField.Cells.GetLength(1); j++)
                {
                    if (game.PlayingField.Cells[i, j].Value is Barrier)
                        Console.Write("#");
                    else if (game.PlayingField.Cells[i, j].Value is Bomb)
                        Console.Write("b");
                    else if (game.PlayingField.Cells[i, j].Value is Player)
                        Console.Write("@");
                    else if (game.PlayingField.Cells[i, j].Value is PlayerFootprint)
                        Console.Write(".");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        public static void RedrawField(Game game)
		{
            Console.Clear();
            DrawField(game);
		}
    }
}
