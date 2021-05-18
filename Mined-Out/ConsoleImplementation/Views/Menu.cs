using Engine.Data;
using Engine.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mined_Out.Views
{
	public class Menu
	{
		public Game Game { get; set; }

		public Menu(Game game)
		{
			Game = game;
		}

		public void ShowMenu()
		{
			Console.Clear();
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				List<BestScore> score = db.BestScore.ToList();
				if (score.Count == 0)
				{
					score = new List<BestScore>();
					var bestScore = new BestScore();
					bestScore.Score = 0;
					score.Add(bestScore);
					db.BestScore.AddRange(score);
					db.SaveChanges();
				}
					
				Console.WriteLine("Рекорд: " + db.BestScore.ToList()[0].Score);
				Console.WriteLine();
				Console.WriteLine();
			}

			Console.WriteLine("Начать игру с первого уровня: 1");
			Console.WriteLine("Загрузить сохранения: 2");
			
			bool incorrectInput = true;
			char input;

			while (incorrectInput)
			{
				input = Console.ReadLine()[0];

				if (input == '1')
				{
					incorrectInput = false;
				}	
				else if(input == '2')
				{
					incorrectInput = false;

					LoadSave();
				}
				else
					Console.WriteLine("Некорректный ввод");
			}
		}

		public void LoadSave()
		{
			Console.Clear();
			Console.WriteLine("Чтобы вернуться, нажмите клавишу R");
			Console.WriteLine("Чтобы загрузить игру, выберите номер сохраненной игры: ");

			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				Console.WriteLine("№" + '\t' + "Score" + '\t' + "Level");

				var saves = db.Saves.Include(s => s.PlayerFootprints)
					.Include(s => s.Players)
					.Include(s => s.Bombs)
					.Include(s => s.Barriers);

				int i = 1;

				foreach (var save in saves)
				{
					Console.WriteLine($"{i}\t{save.Scores}\t{save.Level}");
					i++;
				}
				Console.WriteLine();

				bool isNotCorrect = true;

				while (isNotCorrect)
				{
					var input = Console.ReadLine();
					if (input == "R")
					{
						Console.Clear();
						ShowMenu();

						return;
					}
					try
					{
						int number = Convert.ToInt32(input);

						if (number > 0 && number < i)
						{
							isNotCorrect = false;
							int index = 1;
							foreach (var save in saves)
							{
								if (index == number)
								{
									var dataPlayer = save.Players[0];
									var dataPlayerFootprints = save.PlayerFootprints;
									var dataBombs = save.Bombs;
									var dataBarriers = save.Barriers;
									var width = save.FieldWidth;
									var height = save.FieldHeight;
									var fieldCellSize = save.FieldCellSize;

									Engine.Models.Player.Player player = new Engine.Models.Player.Player(dataPlayer.NumberOfBombs, "#", 0, 0, dataPlayer.I, dataPlayer.J, 1);
									List<Engine.Models.Player.PlayerFootprint> playerFootprints = new List<Engine.Models.Player.PlayerFootprint>();
									List<Engine.Models.Bomb> bombs = new List<Engine.Models.Bomb>();
									List<Engine.Models.Barrier> barriers = new List<Engine.Models.Barrier>();

									foreach (var item in dataPlayerFootprints)
									{
										Engine.Models.Player.PlayerFootprint playerFootprint = new Engine.Models.Player.PlayerFootprint(1, "#", 0, 0, item.I, item.J);
										playerFootprints.Add(playerFootprint);
									}

									foreach (var item in dataBombs)
									{
										Engine.Models.Bomb bomb = new Engine.Models.Bomb(1, "#", 0, 0, item.I, item.J);
										bombs.Add(bomb);
									}

									foreach (var item in dataBarriers)
									{
										Engine.Models.Barrier barrier = new Engine.Models.Barrier(1, "#", 0, 0, item.I, item.J);
										barriers.Add(barrier);
									}

									Game.PlayingField = new PlayingField(player, playerFootprints, bombs, barriers, width, height, fieldCellSize);

									Game.Level = save.Level;
									Game.NumberOfMoves = save.NumberOfMoves;
									Game.TimeCounter = new TimeCounter(save.Time);
									Game.Score = (int)save.Scores;

									break;
								}

								index++;
							}
						}
						else
						{
							Console.WriteLine("Неверный номер");
						}
					}
					catch (Exception)
					{
						Console.WriteLine("Неверный формат ввода");
					}
				}
			}
		}
	}
}
