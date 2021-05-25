﻿using Engine.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class PreservationForm : Form
	{
		public List<Save> Saves { get; set; }

		public PreservationForm(List<Save> saves)
		{
			InitializeComponent();

			Saves = saves;
			ShowData();
		}

		private void ShowData()
		{
			foreach (var save in Saves)
			{
				dataGridView.Rows.Add(save.Id, save.Level, save.Score);
			}
		}

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			int rowsCount = dataGridView.Rows.Count;
			for (int i = 0; i < rowsCount - 1; i++)
			{
				dataGridView.Rows.Remove(dataGridView.Rows[0]);
			}

			ShowData();
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			try
			{
				int number = Convert.ToInt32(Input.Text);
			}
			catch (Exception)
			{
				MessageBox.Show(
					"Неверный ввод",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1,
					MessageBoxOptions.DefaultDesktopOnly);
			}
		}
	}
}
