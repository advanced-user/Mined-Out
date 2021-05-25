
namespace GUI
{
	partial class PreservationForm
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Input = new System.Windows.Forms.TextBox();
			this.StartButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Level,
            this.Score});
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 25;
			this.dataGridView.Size = new System.Drawing.Size(343, 450);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// Number
			// 
			this.Number.HeaderText = "№";
			this.Number.Name = "Number";
			// 
			// Level
			// 
			this.Level.HeaderText = "Level";
			this.Level.Name = "Level";
			// 
			// Score
			// 
			this.Score.HeaderText = "Score";
			this.Score.Name = "Score";
			// 
			// RefreshButton
			// 
			this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.RefreshButton.Location = new System.Drawing.Point(343, 412);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(267, 38);
			this.RefreshButton.TabIndex = 1;
			this.RefreshButton.Text = "Обновить";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(369, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Номер сохранения";
			// 
			// Input
			// 
			this.Input.Location = new System.Drawing.Point(487, 24);
			this.Input.Name = "Input";
			this.Input.Size = new System.Drawing.Size(111, 23);
			this.Input.TabIndex = 3;
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(343, 69);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(267, 38);
			this.StartButton.TabIndex = 4;
			this.StartButton.Text = "Загрузить";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// PreservationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 450);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.Input);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.dataGridView);
			this.Name = "PreservationForm";
			this.Text = "Mined-Out";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Level;
		private System.Windows.Forms.DataGridViewTextBoxColumn Score;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Input;
		private System.Windows.Forms.Button StartButton;
	}
}