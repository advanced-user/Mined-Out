using Engine.Models;
using System;
using System.Threading;

namespace Mined_Out
{
	public class PlayerController
	{
		public Game Game { get; set; }

		public PlayerController(Game game)
		{
			Game = game;
        }

		public void HandlingKeystrokes()
		{
            Field.DrawField(Game, " ");

            while (!Game.IsLoosing)
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
                if(Game.IsWinning)
				{
                    Thread.Sleep(2000);
                    Game.LoadLevel();
				}
            }
        }
	}
}
