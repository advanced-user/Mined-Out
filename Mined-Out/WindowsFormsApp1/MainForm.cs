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
		private readonly List<GUI.Save> Saves;

		public MainForm()
		{
			InitializeComponent();

			Saves = new List<GUI.Save>();

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

				int i = 1;

				foreach (var save in saves)
				{
					GUI.Save s = new GUI.Save(i, save.Level, save.Scores);
					Saves.Add(s);
					i++;
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
