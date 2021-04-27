using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

				}
				else
					Console.WriteLine("Некорректный ввод");
			}
		}
	}
}
