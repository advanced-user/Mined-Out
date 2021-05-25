
namespace WindowsFormsApp1
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NewGameButton = new System.Windows.Forms.Button();
			this.PreservationButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NewGameButton
			// 
			this.NewGameButton.Location = new System.Drawing.Point(35, 30);
			this.NewGameButton.Name = "NewGameButton";
			this.NewGameButton.Size = new System.Drawing.Size(448, 65);
			this.NewGameButton.TabIndex = 0;
			this.NewGameButton.Text = "Новая игра";
			this.NewGameButton.UseVisualStyleBackColor = true;
			this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
			// 
			// PreservationButton
			// 
			this.PreservationButton.Location = new System.Drawing.Point(35, 135);
			this.PreservationButton.Name = "PreservationButton";
			this.PreservationButton.Size = new System.Drawing.Size(448, 65);
			this.PreservationButton.TabIndex = 1;
			this.PreservationButton.Text = "Загрузить сохранения";
			this.PreservationButton.UseVisualStyleBackColor = true;
			this.PreservationButton.Click += new System.EventHandler(this.PreservationButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(35, 241);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(448, 65);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Выход";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 357);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.PreservationButton);
			this.Controls.Add(this.NewGameButton);
			this.Name = "MainForm";
			this.Text = "Mined-Out";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button NewGameButton;
		private System.Windows.Forms.Button PreservationButton;
		private System.Windows.Forms.Button ExitButton;
	}
}

