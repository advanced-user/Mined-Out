using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class GameForm : Form
	{
		public Game Game { get; set; }
		public Block[,] Blocks { get; set; }

		public GameForm()
		{
			InitializeComponent();
			Game = new Game();

			Blocks = new Block[Game.PlayingField.FieldSize.Height, Game.PlayingField.FieldSize.Width];
		}

		public GameForm(Save save)
		{
			InitializeComponent();
		}

		private void GameForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
				case Keys.Up:
					Game.PlayerMovement("up");
					break;
				case Keys.Down:
					Game.PlayerMovement("down");
					break;
				case Keys.Left:
					Game.PlayerMovement("left");
					break;
				case Keys.Right:
					Game.PlayerMovement("right");
					break;
				case Keys.S:
					Game.SaveTheGame();
					break;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int time = Convert.ToInt32(timeCounter.Text);
			time++;
			timeCounter.Text = time.ToString();
		}
	}
}
