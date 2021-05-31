
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.timeCounter = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NumberOfMoves = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Level = new System.Windows.Forms.Label();
			this.Score = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
			// timeCounter
			// 
			this.timeCounter.AutoSize = true;
			this.timeCounter.Location = new System.Drawing.Point(147, 382);
			this.timeCounter.Name = "timeCounter";
			this.timeCounter.Size = new System.Drawing.Size(13, 15);
			this.timeCounter.TabIndex = 2;
			this.timeCounter.Text = "0";
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
			// NumberOfMoves
			// 
			this.NumberOfMoves.AutoSize = true;
			this.NumberOfMoves.Location = new System.Drawing.Point(147, 410);
			this.NumberOfMoves.Name = "NumberOfMoves";
			this.NumberOfMoves.Size = new System.Drawing.Size(13, 15);
			this.NumberOfMoves.TabIndex = 4;
			this.NumberOfMoves.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Уровень:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Счет:";
			// 
			// Level
			// 
			this.Level.AutoSize = true;
			this.Level.Location = new System.Drawing.Point(88, 5);
			this.Level.Name = "Level";
			this.Level.Size = new System.Drawing.Size(13, 15);
			this.Level.TabIndex = 7;
			this.Level.Text = "1";
			// 
			// Score
			// 
			this.Score.AutoSize = true;
			this.Score.Location = new System.Drawing.Point(88, 33);
			this.Score.Name = "Score";
			this.Score.Size = new System.Drawing.Size(13, 15);
			this.Score.TabIndex = 8;
			this.Score.Text = "0";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.Score);
			this.panel1.Controls.Add(this.Level);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.NumberOfMoves);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.timeCounter);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 450);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(316, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 32);
			this.label5.TabIndex = 9;
			this.label5.Text = "Game over ";
			this.label5.Visible = false;
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
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label timeCounter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label NumberOfMoves;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Level;
		private System.Windows.Forms.Label Score;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
	}
}