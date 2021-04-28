using Engine.Models;
using Mined_Out.Views;
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
            var menu = new Menu(Game);
            menu.ShowMenu();

            var field = new Field(Game);
            field.DrawField(" ");

            if (Game.TimeCounter == null)
                field.StartTimer(0);
            else
                field.StartTimer(Game.TimeCounter.AmountOfTime);

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
                    case ConsoleKey.S:
                        Game.SaveTheGame();
                        break;
                }

                field.RedrawField();

                if(Game.IsWinning)
				{
                    Game.LoadLevel();
				}
                else if(Game.IsLoosing)
				{
					Console.WriteLine("Если хотети начать заново, нажмите: y");

                    bool isRestart = false;

                    while(!isRestart)
					{
                        var k = Console.ReadKey().Key;
                        if (k == ConsoleKey.Y)
						{
                            Game.LoadLevel();
                            isRestart = true;
                        }
					}
				}
            }
        }
	}
}
