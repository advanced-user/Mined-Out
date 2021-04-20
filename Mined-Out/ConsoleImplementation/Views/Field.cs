using Engine.Models;
using System;

namespace Mined_Out
{
	public static class Field
	{
        public static void DrawField(Game game, string bomb)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Уровень: " + game.Level);
            for (int i = 0; i < game.PlayingField.Cells.GetLength(0); i++)
            {
                for (int j = 0; j < game.PlayingField.Cells.GetLength(1); j++)
                {
                    if (game.PlayingField.Cells[i, j].Value is Barrier)
                        Console.Write("#");
                    else if (game.PlayingField.Cells[i, j].Value is Bomb)
                        Console.Write(bomb);
                    else if (game.PlayingField.Cells[i, j].Value is Player)
                        Console.Write(game.PlayingField.Player.NumberOfBombs);
                    else if (game.PlayingField.Cells[i, j].Value is PlayerFootprint)
                        Console.Write(".");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            if(game.IsWinning)
				Console.WriteLine("Вы выиграли ");
            else if(game.IsLoosing)
				Console.WriteLine("Вы проиграли ");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }

        public static void RedrawField(Game game)
		{
            Console.Clear();

            if (game.IsLoosing)
                DrawField(game, "b");
            else
                DrawField(game, " ");
		}
    }
}
