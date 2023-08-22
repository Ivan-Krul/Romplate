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
			menuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			templateToolStripMenuItem = new ToolStripMenuItem();
			weekToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			weekToolStripMenuItem1 = new ToolStripMenuItem();
			templateToolStripMenuItem1 = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			openFileDialog = new OpenFileDialog();
			saveFileDialog = new SaveFileDialog();
			tableLayoutPanel1 = new TableLayoutPanel();
			button6 = new Button();
			button5 = new Button();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)numericUpDownWeekDays).BeginInit();
			menuStrip.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
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
			checkBox1.Enabled = false;
			checkBox1.Location = new Point(315, 39);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(54, 19);
			checkBox1.TabIndex = 6;
			checkBox1.Text = "Done";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// menuStrip
			// 
			menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(625, 24);
			menuStrip.TabIndex = 7;
			menuStrip.Text = "menuStrip1";
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
			// templateToolStripMenuItem
			// 
			templateToolStripMenuItem.Name = "templateToolStripMenuItem";
			templateToolStripMenuItem.Size = new Size(122, 22);
			templateToolStripMenuItem.Text = "Template";
			// 
			// weekToolStripMenuItem
			// 
			weekToolStripMenuItem.Name = "weekToolStripMenuItem";
			weekToolStripMenuItem.Size = new Size(122, 22);
			weekToolStripMenuItem.Text = "Week";
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
			// weekToolStripMenuItem1
			// 
			weekToolStripMenuItem1.Name = "weekToolStripMenuItem1";
			weekToolStripMenuItem1.Size = new Size(122, 22);
			weekToolStripMenuItem1.Text = "Week";
			// 
			// templateToolStripMenuItem1
			// 
			templateToolStripMenuItem1.Name = "templateToolStripMenuItem1";
			templateToolStripMenuItem1.Size = new Size(122, 22);
			templateToolStripMenuItem1.Text = "Template";
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
			// openFileDialog
			// 
			openFileDialog.FileName = "openFileDialog1";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(button6, 1, 2);
			tableLayoutPanel1.Controls.Add(button5, 0, 2);
			tableLayoutPanel1.Controls.Add(button4, 1, 1);
			tableLayoutPanel1.Controls.Add(button3, 0, 1);
			tableLayoutPanel1.Controls.Add(button2, 1, 0);
			tableLayoutPanel1.Controls.Add(button1, 0, 0);
			tableLayoutPanel1.Location = new Point(315, 200);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.Size = new Size(298, 158);
			tableLayoutPanel1.TabIndex = 8;
			// 
			// button6
			// 
			button6.Location = new Point(152, 107);
			button6.Name = "button6";
			button6.Size = new Size(143, 46);
			button6.TabIndex = 5;
			button6.Text = "Delete Homework";
			button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(3, 107);
			button5.Name = "button5";
			button5.Size = new Size(143, 46);
			button5.TabIndex = 4;
			button5.Text = "Delete Lesson";
			button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(152, 55);
			button4.Name = "button4";
			button4.Size = new Size(143, 46);
			button4.TabIndex = 3;
			button4.Text = "Modify Homework";
			button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(3, 55);
			button3.Name = "button3";
			button3.Size = new Size(143, 46);
			button3.TabIndex = 2;
			button3.Text = "Modify Lesson";
			button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(152, 3);
			button2.Name = "button2";
			button2.Size = new Size(143, 46);
			button2.TabIndex = 1;
			button2.Text = "Create Homework";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(3, 3);
			button1.Name = "button1";
			button1.Size = new Size(143, 46);
			button1.TabIndex = 0;
			button1.Text = "Create Lesson";
			button1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(625, 415);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(checkBox1);
			Controls.Add(labelNotation);
			Controls.Add(textBoxNotation);
			Controls.Add(listBoxHomeworks);
			Controls.Add(labelDayWeek);
			Controls.Add(numericUpDownWeekDays);
			Controls.Add(listBoxLessons);
			Controls.Add(menuStrip);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip;
			MinimumSize = new Size(196, 96);
			Name = "MainForm";
			Text = "Romplate";
			((System.ComponentModel.ISupportInitialize)numericUpDownWeekDays).EndInit();
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
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
		private MenuStrip menuStrip;
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
		private OpenFileDialog openFileDialog;
		private SaveFileDialog saveFileDialog;
		private TableLayoutPanel tableLayoutPanel1;
		private Button button6;
		private Button button5;
		private Button button4;
		private Button button3;
		private Button button2;
		private Button button1;
	}
}