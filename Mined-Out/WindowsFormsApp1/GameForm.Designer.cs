
namespace GUI
{
	partial class GameForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.NumberOfMoves = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timeCounter = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.NumberOfMoves);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.timeCounter);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 450);
			this.panel1.TabIndex = 0;
			// 
			// NumberOfMoves
			// 
			this.NumberOfMoves.AutoSize = true;
			this.NumberOfMoves.Location = new System.Drawing.Point(147, 410);
			this.NumberOfMoves.Name = "NumberOfMoves";
			this.NumberOfMoves.Size = new System.Drawing.Size(13, 15);
			this.NumberOfMoves.TabIndex = 4;
			this.NumberOfMoves.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 410);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Количество ходов:";
			// 
			// timeCounter
			// 
			this.timeCounter.AutoSize = true;
			this.timeCounter.Location = new System.Drawing.Point(147, 382);
			this.timeCounter.Name = "timeCounter";
			this.timeCounter.Size = new System.Drawing.Size(13, 15);
			this.timeCounter.TabIndex = 2;
			this.timeCounter.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 382);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Время игры:";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "GameForm";
			this.Text = "Mined-Out";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label NumberOfMoves;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label timeCounter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
	}
}