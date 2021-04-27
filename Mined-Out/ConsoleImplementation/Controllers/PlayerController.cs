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
            var field = new Field(Game);
            field.DrawField(" ");
            field.StartTimer(0);

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

                field.RedrawField();

                if(Game.IsWinning)
				{
                    Thread.Sleep(2000);
                    Game.LoadLevel();
				}
                else if(Game.IsLoosing)
				{

				}
            }
        }
	}
}
