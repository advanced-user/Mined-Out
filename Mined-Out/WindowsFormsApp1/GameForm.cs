using Engine.Data;
using Engine.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

			Blocks = new Block[Game.PlayingField.FieldSize.Width, Game.PlayingField.FieldSize.Height];
			int bw = 25;
			int bh = 25;
			for (int x = 0; x < Game.PlayingField.FieldSize.Width; x++)
			{
				for (int y = 0; y < Game.PlayingField.FieldSize.Height; y++)
				{
					int left = x * bw + (panel1.Width - bw * Game.PlayingField.FieldSize.Width) / 2;
					int top = (y + 2) * bh;
					int width = bw - 2;
					int height = bh - 2;

					Blocks[x, y] = new Block(top, left,width, height, 0, Game.PlayingField[y, x].Value);
				}
			}
		}

		public GameForm(Save save)
		{
			InitializeComponent();

			Game = new Game();

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
			Game.Score = (int)save.Scores;

			timeCounter.Text = save.Time.ToString();
			Score.Text = Game.Score.ToString();
			Level.Text = Game.Level.ToString();
			NumberOfMoves.Text = Game.NumberOfMoves.ToString();

			Blocks = new Block[Game.PlayingField.FieldSize.Width, Game.PlayingField.FieldSize.Height];
			int bw = 25;
			int bh = 25;
			for (int x = 0; x < Game.PlayingField.FieldSize.Width; x++)
			{
				for (int y = 0; y < Game.PlayingField.FieldSize.Height; y++)
				{
					int left = x * bw + (panel1.Width - bw * Game.PlayingField.FieldSize.Width) / 2;
					int top = (y + 2) * bh;
					int w = bw - 2;
					int h = bh - 2;

					Blocks[x, y] = new Block(top, left, w, h, 0, Game.PlayingField[y, x].Value);
				}
			}
		}

		private void GameForm_KeyDown(object sender, KeyEventArgs e)
		{
			int number = 0;
			if(!Game.IsLoosing)
			{
				switch (e.KeyCode)
				{
					case Keys.Up:
						number = Convert.ToInt32(NumberOfMoves.Text);
						number++;
						NumberOfMoves.Text = number.ToString();
						Game.PlayerMovement("up");
						UpdateCells();
						panel1.Invalidate();
						break;
					case Keys.Down:
						number = Convert.ToInt32(NumberOfMoves.Text);
						number++;
						NumberOfMoves.Text = number.ToString();
						Game.PlayerMovement("down");
						UpdateCells();
						panel1.Invalidate();
						break;
					case Keys.Left:
						number = Convert.ToInt32(NumberOfMoves.Text);
						number++;
						NumberOfMoves.Text = number.ToString();
						Game.PlayerMovement("left");
						UpdateCells();
						panel1.Invalidate();
						break;
					case Keys.Right:
						number = Convert.ToInt32(NumberOfMoves.Text);
						number++;
						NumberOfMoves.Text = number.ToString();
						Game.PlayerMovement("right");
						UpdateCells();
						panel1.Invalidate();
						break;
					case Keys.S:
						Game.TimeCounter = new TimeCounter(Convert.ToInt32(timeCounter.Text));
						Game.SaveTheGame();
						break;
				}

				if (Game.IsWinning)
				{
					Game.CalculatePlayerPoints(Convert.ToInt32(timeCounter.Text));
					Game.LoadLevel();
					Blocks = new Block[Game.PlayingField.FieldSize.Width, Game.PlayingField.FieldSize.Height];
					int bw = 25;
					int bh = 25;
					for (int x = 0; x < Game.PlayingField.FieldSize.Width; x++)
					{
						for (int y = 0; y < Game.PlayingField.FieldSize.Height; y++)
						{
							int left = x * bw + (panel1.Width - bw * Game.PlayingField.FieldSize.Width) / 2;
							int top = (y + 2) * bh;
							int width = bw - 2;
							int height = bh - 2;

							Blocks[x, y] = new Block(top, left, width, height, 0, Game.PlayingField[y, x].Value);
						}
					}
					timeCounter.Text = "0";
					Score.Text = Game.Score.ToString();
					Level.Text = Game.Level.ToString();
				}
				else if (Game.IsLoosing)
				{
					panel1.Enabled = false;
					timer1.Enabled = false;
					label5.Visible = true;
				}

				UpdateCells();
				panel1.Invalidate();
			}
		
		}

		private void UpdateCells()
		{
			for(int i = 0; i < Blocks.GetLength(0); i++)
			{
				for(int j = 0; j < Blocks.GetLength(1); j++)
				{
					Blocks[i, j].Value = Game.PlayingField[j, i].Value;
					Blocks[i, j].NumberOfBombs = Game.PlayingField.Player.NumberOfBombs;
				}
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int time = Convert.ToInt32(timeCounter.Text);
			time++;
			timeCounter.Text = time.ToString();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			for (int x = 0; x < Game.PlayingField.FieldSize.Width; x++)
			{
				for (int y = 0; y < Game.PlayingField.FieldSize.Height; y++)
				{
					Blocks[x, y].Draw(e.Graphics, Game.IsLoosing);
				}
			}
		}

		private void panel1_MouseClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				for (int i = 0; i < Blocks.GetLength(0); i++)
				{
					for (int j = 0; j < Blocks.GetLength(1); j++)
					{
						if (Blocks[i, j].Left <= e.Location.X && Blocks[i, j].Left + Blocks[i, j].Height >= e.Location.X
							&& Blocks[i, j].Top <= e.Location.Y && Blocks[i, j].Top + Blocks[i, j].Height >= e.Location.Y)
						{
							if (!(Game.PlayingField[j, i].Value is Engine.Models.Player.Player)
								&& !(Game.PlayingField[j, i].Value is Engine.Models.Barrier)
								&& !(Game.PlayingField[j, i].Value is Engine.Models.Player.PlayerFootprint)
								&& !(Game.PlayingField[j, i].Value is Engine.Models.GameObjects.Flag))
							{
								Engine.Models.GameObjects.Flag flag = new Engine.Models.GameObjects.Flag(25, "b", Game.PlayingField.Cells[i, j].Coordinates.X, Game.PlayingField.Cells[j, i].Coordinates.Y, j, i);
								Game.PlayingField[j, i].Value = flag;
							}
							else if (Game.PlayingField[j, i].Value is Engine.Models.GameObjects.Flag)
							{
								Game.PlayingField[j, i].Value = null;
							}
						}
					}
				}
			}
			else if(e.Button == MouseButtons.Left)
			{
				for (int i = 0; i < Blocks.GetLength(0); i++)
				{
					for (int j = 0; j < Blocks.GetLength(1); j++)
					{
						if (Blocks[i, j].Left <= e.Location.X && Blocks[i, j].Left + Blocks[i, j].Height >= e.Location.X
							&& Blocks[i, j].Top <= e.Location.Y && Blocks[i, j].Top + Blocks[i, j].Height >= e.Location.Y)
						{
							int I = j;
							int J = i;

							if(I >= 1 && I < Game.PlayingField.Cells.GetLength(0)-1 
								&& J >= 1 && J < Game.PlayingField.Cells.GetLength(1)-1)
							{
								if(Game.PlayingField[I - 1, J].Value is Engine.Models.Player.PlayerFootprint
									|| Game.PlayingField[I, J - 1].Value is Engine.Models.Player.PlayerFootprint
									|| Game.PlayingField[I + 1, J].Value is Engine.Models.Player.PlayerFootprint
									|| Game.PlayingField[I, J + 1].Value is Engine.Models.Player.PlayerFootprint
									|| Game.PlayingField[I - 1, J].Value is Engine.Models.Player.Player
									|| Game.PlayingField[I, J - 1].Value is Engine.Models.Player.Player
									|| Game.PlayingField[I + 1, J].Value is Engine.Models.Player.Player
									|| Game.PlayingField[I, J + 1].Value is Engine.Models.Player.Player)
								{
									for (int g = 0; g < Game.PlayingField.Cells.GetLength(0); g++)
									{
										for (int k = 0; k < Game.PlayingField.Cells.GetLength(0); k++)
										{
											if(Game.PlayingField[g, k].Value is Engine.Models.Player.Player)
											{
												Engine.Models.Player.PlayerFootprint playerFootprint = new Engine.Models.Player.PlayerFootprint(25, ".", Game.PlayingField.Cells[g, k].Coordinates.X, Game.PlayingField.Cells[g, k].Coordinates.Y, g, k);
												Game.PlayingField[g, k].Value = playerFootprint;

												Game.Move(I, J);
											}
										}
									}
								}
							}
						}
					}
				}
			}

			UpdateCells();
			panel1.Invalidate();
		}
	}
}
