using Engine.Models;
using System;
using System.Diagnostics;
using System.Threading;

namespace Mined_Out
{
	public class Field
	{
        private Game Game;
        private bool _isRedrawing;

		public Field(Game game)
		{
            Game = game;
            _isRedrawing = false;
        }

        public void DrawField(string bomb)
        {
            _isRedrawing = true;
            //Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Уровень: " + Game.Level);
            Console.WriteLine("Счет: " + Game.Score);
            for (int i = 0; i < Game.PlayingField.Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Game.PlayingField.Cells.GetLength(1); j++)
                {
                    if (Game.PlayingField.Cells[i, j].Value is Engine.Models.Barrier)
                        Console.Write("#");
                    else if (Game.PlayingField.Cells[i, j].Value is Bomb)
                        Console.Write(bomb);
                    else if (Game.PlayingField.Cells[i, j].Value is Player)
                        Console.Write(Game.PlayingField.Player.NumberOfBombs);
                    else if (Game.PlayingField.Cells[i, j].Value is PlayerFootprint)
                        Console.Write(".");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
			Console.WriteLine();

			Console.WriteLine();
			Console.WriteLine("Количество ходов: " + Game.NumberOfMoves);
			
			Console.WriteLine();

            if(Game.IsLoosing)
				Console.WriteLine("Вы проиграли ");

            Console.BackgroundColor = ConsoleColor.DarkGreen;

            _isRedrawing = false;
        }

        public void RedrawField()
		{
            if(!_isRedrawing)
			{
                if (Game.IsLoosing)
                    DrawField("b");
                else
                    DrawField(" ");
            }
		}

        public void StartTimer(int time)
		{
            Game.TimeCounter = new TimeCounter(time);
            Thread TimeThread = new Thread(new ThreadStart(Time));
            Game.TimeCounter.StartStopwatch();
            TimeThread.Start();
        }

        private void Time()
        {
            while (!Game.IsWinning && !Game.IsLoosing)
            {
                if(!_isRedrawing)
				{
                    try
					{
                        _isRedrawing = true;
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine("Время прохождения уровня: " + Game.TimeCounter.AmountOfTime);
                        _isRedrawing = false;
                    }
                    catch
					{
					}

                }
                Thread.Sleep(100);
            }
        }
    }
}
