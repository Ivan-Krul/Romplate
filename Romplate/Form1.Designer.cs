namespace Romplate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			listBoxLessons = new ListBox();
			numericUpDownWeekDays = new NumericUpDown();
			labelDayWeek = new Label();
			listBoxHomeworks = new ListBox();
			textBoxNotation = new TextBox();
			labelNotation = new Label();
			checkBox1 = new CheckBox();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			templateToolStripMenuItem = new ToolStripMenuItem();
			weekToolStripMenuItem = new ToolStripMenuItem();
			weekToolStripMenuItem1 = new ToolStripMenuItem();
			templateToolStripMenuItem1 = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)numericUpDownWeekDays).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// listBoxLessons
			// 
			listBoxLessons.FormattingEnabled = true;
			listBoxLessons.ItemHeight = 15;
			listBoxLessons.Location = new Point(11, 39);
			listBoxLessons.Name = "listBoxLessons";
			listBoxLessons.Size = new Size(119, 319);
			listBoxLessons.TabIndex = 0;
			// 
			// numericUpDownWeekDays
			// 
			numericUpDownWeekDays.Location = new Point(11, 379);
			numericUpDownWeekDays.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
			numericUpDownWeekDays.Name = "numericUpDownWeekDays";
			numericUpDownWeekDays.Size = new Size(82, 23);
			numericUpDownWeekDays.TabIndex = 1;
			// 
			// labelDayWeek
			// 
			labelDayWeek.AutoSize = true;
			labelDayWeek.Location = new Point(11, 361);
			labelDayWeek.Name = "labelDayWeek";
			labelDayWeek.Size = new Size(69, 15);
			labelDayWeek.TabIndex = 2;
			labelDayWeek.Text = "day in week";
			// 
			// listBoxHomeworks
			// 
			listBoxHomeworks.FormattingEnabled = true;
			listBoxHomeworks.ItemHeight = 15;
			listBoxHomeworks.Location = new Point(136, 39);
			listBoxHomeworks.MultiColumn = true;
			listBoxHomeworks.Name = "listBoxHomeworks";
			listBoxHomeworks.Size = new Size(173, 319);
			listBoxHomeworks.TabIndex = 3;
			// 
			// textBoxNotation
			// 
			textBoxNotation.Enabled = false;
			textBoxNotation.Location = new Point(427, 57);
			textBoxNotation.Multiline = true;
			textBoxNotation.Name = "textBoxNotation";
			textBoxNotation.Size = new Size(186, 137);
			textBoxNotation.TabIndex = 4;
			// 
			// labelNotation
			// 
			labelNotation.AutoSize = true;
			labelNotation.Location = new Point(427, 39);
			labelNotation.Name = "labelNotation";
			labelNotation.Size = new Size(54, 15);
			labelNotation.TabIndex = 5;
			labelNotation.Text = "Notation";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(315, 39);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(54, 19);
			checkBox1.TabIndex = 6;
			checkBox1.Text = "Done";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(625, 24);
			menuStrip1.TabIndex = 7;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, openToolStripMenuItem, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { templateToolStripMenuItem, weekToolStripMenuItem });
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.Size = new Size(180, 22);
			newToolStripMenuItem.Text = "New";
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(180, 22);
			saveToolStripMenuItem.Text = "Open";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { weekToolStripMenuItem1, templateToolStripMenuItem1 });
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(180, 22);
			openToolStripMenuItem.Text = "Save";
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(180, 22);
			exitToolStripMenuItem.Text = "Exit";
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(52, 20);
			aboutToolStripMenuItem.Text = "About";
			// 
			// templateToolStripMenuItem
			// 
			templateToolStripMenuItem.Name = "templateToolStripMenuItem";
			templateToolStripMenuItem.Size = new Size(180, 22);
			templateToolStripMenuItem.Text = "Template";
			// 
			// weekToolStripMenuItem
			// 
			weekToolStripMenuItem.Name = "weekToolStripMenuItem";
			weekToolStripMenuItem.Size = new Size(180, 22);
			weekToolStripMenuItem.Text = "Week";
			// 
			// weekToolStripMenuItem1
			// 
			weekToolStripMenuItem1.Name = "weekToolStripMenuItem1";
			weekToolStripMenuItem1.Size = new Size(180, 22);
			weekToolStripMenuItem1.Text = "Week";
			// 
			// templateToolStripMenuItem1
			// 
			templateToolStripMenuItem1.Name = "templateToolStripMenuItem1";
			templateToolStripMenuItem1.Size = new Size(180, 22);
			templateToolStripMenuItem1.Text = "Template";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(625, 415);
			Controls.Add(checkBox1);
			Controls.Add(labelNotation);
			Controls.Add(textBoxNotation);
			Controls.Add(listBoxHomeworks);
			Controls.Add(labelDayWeek);
			Controls.Add(numericUpDownWeekDays);
			Controls.Add(listBoxLessons);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			MinimumSize = new Size(196, 96);
			Name = "MainForm";
			Text = "Romplate";
			((System.ComponentModel.ISupportInitialize)numericUpDownWeekDays).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBoxLessons;
		private NumericUpDown numericUpDownWeekDays;
		private Label labelDayWeek;
		private ListBox listBoxHomeworks;
		private TextBox textBoxNotation;
		private Label labelNotation;
		private CheckBox checkBox1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private ToolStripMenuItem templateToolStripMenuItem;
		private ToolStripMenuItem weekToolStripMenuItem;
		private ToolStripMenuItem weekToolStripMenuItem1;
		private ToolStripMenuItem templateToolStripMenuItem1;
	}
}