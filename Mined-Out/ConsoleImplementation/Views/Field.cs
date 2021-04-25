﻿using Engine.Models;
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
            Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Уровень: " + Game.Level);
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
            if(Game.TimeCounter != null)
                Console.WriteLine("Время прохождения уровня в секундах: " + Game.TimeCounter.AmountOfTime);
            Console.WriteLine();

            if (Game.IsWinning)
				Console.WriteLine("Вы выиграли ");
            else if(Game.IsLoosing)
				Console.WriteLine("Вы проиграли ");

            Console.BackgroundColor = ConsoleColor.DarkGreen;

            _isRedrawing = false;
        }

        public void RedrawField()
		{
            Console.Clear();

            if(!_isRedrawing)
			{
                if (Game.IsLoosing)
                    DrawField("*");
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
                    RedrawField();
                Thread.Sleep(500);
            }
        }
    }
}
