using System;
using Engine.Models;

namespace Mined_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            ShowField(game);

            Console.ReadLine();
        }

        static void ShowField(Game game)
        {
            for (int i = 0; i < game.PlayingField.Cells.GetLength(0); i++)
            {
                for (int j = 0; j < game.PlayingField.Cells.GetLength(1); j++)
                {
                    if (game.PlayingField.Cells[i, j].Value is Barrier)
                        Console.Write("#");
                    else if(game.PlayingField.Cells[i, j].Value is Bomb)
                        Console.Write("b");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}