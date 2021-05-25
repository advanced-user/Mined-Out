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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void FirstLevelButton_Click(object sender, EventArgs e)
		{
			
		}

		private void PreservationButton_Click(object sender, EventArgs e)
		{
			PreservationForm preservationForm = new PreservationForm();
			preservationForm.ShowDialog();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
