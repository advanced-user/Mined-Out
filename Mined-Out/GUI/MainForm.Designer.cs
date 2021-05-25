
namespace GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.FirstLevelButton = new System.Windows.Forms.Button();
			this.PreservationButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.BestScore = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// FirstLevelButton
			// 
			this.FirstLevelButton.Location = new System.Drawing.Point(105, 170);
			this.FirstLevelButton.Name = "FirstLevelButton";
			this.FirstLevelButton.Size = new System.Drawing.Size(472, 74);
			this.FirstLevelButton.TabIndex = 0;
			this.FirstLevelButton.Text = "Начать игру с первого уровня";
			this.FirstLevelButton.UseVisualStyleBackColor = true;
			this.FirstLevelButton.Click += new System.EventHandler(this.FirstLevelButton_Click);
			// 
			// PreservationButton
			// 
			this.PreservationButton.Location = new System.Drawing.Point(105, 281);
			this.PreservationButton.Name = "PreservationButton";
			this.PreservationButton.Size = new System.Drawing.Size(472, 75);
			this.PreservationButton.TabIndex = 1;
			this.PreservationButton.Text = "Загрузить сохранения";
			this.PreservationButton.UseVisualStyleBackColor = true;
			this.PreservationButton.Click += new System.EventHandler(this.PreservationButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(105, 398);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(472, 70);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Выход";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(102, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Рекорд: ";
			// 
			// BestScore
			// 
			this.BestScore.AutoSize = true;
			this.BestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BestScore.Location = new System.Drawing.Point(176, 81);
			this.BestScore.Name = "BestScore";
			this.BestScore.Size = new System.Drawing.Size(0, 18);
			this.BestScore.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 521);
			this.Controls.Add(this.BestScore);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.PreservationButton);
			this.Controls.Add(this.FirstLevelButton);
			this.Name = "MainForm";
			this.Text = "Mined-Out";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button FirstLevelButton;
		private System.Windows.Forms.Button PreservationButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label BestScore;
	}
}

