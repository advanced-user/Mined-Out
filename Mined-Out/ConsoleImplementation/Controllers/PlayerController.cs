using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mined_Out
{
	public class PlayerController
	{
		public Game Game { get; set; }

		public PlayerController(Game game)
		{
			Game = game;
			HandlingKeystrokes();
		}

		public void HandlingKeystrokes()
		{
            Field.DrawField(Game);

            while (true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        Game.PlayerMovement("up");
                        break;
                    case ConsoleKey.DownArrow:
                        Game.PlayerMovement("down");
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.PlayerMovement("left");
                        break;
                    case ConsoleKey.RightArrow:
                        Game.PlayerMovement("right");
                        break;
                }

                Field.RedrawField(Game);
            }
        }
	}
}
