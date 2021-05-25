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
	public partial class PreservationForm : Form
	{
		public PreservationForm()
		{
			InitializeComponent();

			//using (ApplicationDbContext db = new ApplicationDbContext())
			//{
			//	Console.WriteLine("№" + '\t' + "Score" + '\t' + "Level");

			//	var saves = db.Saves.Include(s => s.PlayerFootprints)
			//		.Include(s => s.Players)
			//		.Include(s => s.Bombs)
			//		.Include(s => s.Barriers);

			//	int i = 1;

			//	foreach (var save in saves)
			//	{
			//		dataGridView1.Rows[i].Cells[0] = i + 1;
			//		dataGridView1.Rows[i].Cells[1] = save.Scores;
			//		dataGridView1.Rows[i].Cells[2] = save.Level;

			//		i++;
			//	}
			//}
		}
	}
}
