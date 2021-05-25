using Engine.Data;
using GUI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class MainForm : Form
	{
		private readonly List<Save> Saves;

		public MainForm()
		{
			InitializeComponent();

			Saves = new List<Save>();

			LoadingDataAsync();
		}

		private async void LoadingDataAsync()
		{
			await Task.Run(() => LoadingData());
		}

		private void LoadingData()
		{
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				var saves = db.Saves.Include(s => s.PlayerFootprints)
					.Include(s => s.Players)
					.Include(s => s.Bombs)
					.Include(s => s.Barriers);

				foreach (var save in saves)
				{
					Save s = new Save();

					s.Players = save.Players;
					s.PlayerFootprints = save.PlayerFootprints;
					s.Bombs = save.Bombs;
					s.Barriers = save.Barriers;
					s.FieldWidth = save.FieldWidth;
					s.FieldHeight = save.FieldHeight;
					s.FieldCellSize = save.FieldCellSize;
					s.Level = save.Level;
					s.NumberOfMoves = save.NumberOfMoves;
					s.Scores = save.Scores;
					s.Time = save.Time;


					Saves.Add(s);
				}
			}
		}

		private void NewGameButton_Click(object sender, EventArgs e)
		{
			GameForm gameForm = new GameForm();
			gameForm.ShowDialog();
		}

		private void PreservationButton_Click(object sender, EventArgs e)
		{
			PreservationForm preservationForm = new PreservationForm(Saves);
			preservationForm.ShowDialog();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
