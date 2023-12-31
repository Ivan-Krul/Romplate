﻿namespace Romplate
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
			textBoxNotation = new TextBox();
			labelNotation = new Label();
			checkBoxIsDone = new CheckBox();
			menuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			menuItemNewContentPage = new ToolStripMenuItem();
			templateToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			menuItemOpenContentPage = new ToolStripMenuItem();
			menuItemOpenTemplate = new ToolStripMenuItem();
			menuItemRename = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			menuItemSaveContentPage = new ToolStripMenuItem();
			menuItemSaveTemplate = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			viewToolStripMenuItem = new ToolStripMenuItem();
			menuItemChangeTheme = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			openFileDialog = new OpenFileDialog();
			saveFileDialog = new SaveFileDialog();
			tableLayoutPanelInteractors = new TableLayoutPanel();
			buttonGoToMeet = new Button();
			buttonDeleteLesson = new Button();
			buttonModifyLesson = new Button();
			buttonCreateLesson = new Button();
			labelHomeworkSign = new Label();
			textBoxHomework = new TextBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			comboBoxWeekDays = new ComboBox();
			labelContentName = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			menuStrip.SuspendLayout();
			tableLayoutPanelInteractors.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// listBoxLessons
			// 
			listBoxLessons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			listBoxLessons.FormattingEnabled = true;
			listBoxLessons.ItemHeight = 15;
			listBoxLessons.Location = new Point(3, 31);
			listBoxLessons.Name = "listBoxLessons";
			listBoxLessons.Size = new Size(190, 319);
			listBoxLessons.TabIndex = 0;
			listBoxLessons.SelectedIndexChanged += listBoxLessons_SelectedIndexChanged;
			// 
			// textBoxNotation
			// 
			textBoxNotation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxNotation.Enabled = false;
			textBoxNotation.Location = new Point(271, 20);
			textBoxNotation.Multiline = true;
			textBoxNotation.Name = "textBoxNotation";
			textBoxNotation.Size = new Size(156, 194);
			textBoxNotation.TabIndex = 4;
			textBoxNotation.TextChanged += textBoxNotation_TextChanged;
			// 
			// labelNotation
			// 
			labelNotation.AutoSize = true;
			labelNotation.Location = new Point(271, 0);
			labelNotation.Name = "labelNotation";
			labelNotation.Size = new Size(54, 15);
			labelNotation.TabIndex = 5;
			labelNotation.Text = "Notation";
			// 
			// checkBoxIsDone
			// 
			checkBoxIsDone.AutoSize = true;
			checkBoxIsDone.Enabled = false;
			checkBoxIsDone.Location = new Point(3, 169);
			checkBoxIsDone.Name = "checkBoxIsDone";
			checkBoxIsDone.Size = new Size(54, 19);
			checkBoxIsDone.TabIndex = 6;
			checkBoxIsDone.Text = "Done";
			checkBoxIsDone.UseVisualStyleBackColor = true;
			checkBoxIsDone.CheckedChanged += checkBoxIsDone_CheckedChanged;
			// 
			// menuStrip
			// 
			menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, aboutToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(655, 24);
			menuStrip.TabIndex = 7;
			menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, menuItemRename, openToolStripMenuItem, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.BackColor = SystemColors.Control;
			newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemNewContentPage, templateToolStripMenuItem });
			newToolStripMenuItem.ForeColor = SystemColors.ControlText;
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.Size = new Size(192, 22);
			newToolStripMenuItem.Text = "New";
			// 
			// menuItemNewContentPage
			// 
			menuItemNewContentPage.Name = "menuItemNewContentPage";
			menuItemNewContentPage.Size = new Size(180, 22);
			menuItemNewContentPage.Text = "Content Page";
			menuItemNewContentPage.Click += menuItemNewContentPage_Click;
			// 
			// templateToolStripMenuItem
			// 
			templateToolStripMenuItem.Name = "templateToolStripMenuItem";
			templateToolStripMenuItem.Size = new Size(180, 22);
			templateToolStripMenuItem.Text = "Template";
			templateToolStripMenuItem.Click += templateToolStripMenuItem_Click;
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemOpenContentPage, menuItemOpenTemplate });
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(192, 22);
			saveToolStripMenuItem.Text = "Open";
			// 
			// menuItemOpenContentPage
			// 
			menuItemOpenContentPage.Name = "menuItemOpenContentPage";
			menuItemOpenContentPage.Size = new Size(146, 22);
			menuItemOpenContentPage.Text = "Content Page";
			menuItemOpenContentPage.Click += menuItemOpenContentPage_Click;
			// 
			// menuItemOpenTemplate
			// 
			menuItemOpenTemplate.Name = "menuItemOpenTemplate";
			menuItemOpenTemplate.Size = new Size(146, 22);
			menuItemOpenTemplate.Text = "Template";
			menuItemOpenTemplate.Click += menuItemOpenTemplate_Click;
			// 
			// menuItemRename
			// 
			menuItemRename.Name = "menuItemRename";
			menuItemRename.Size = new Size(192, 22);
			menuItemRename.Text = "Rename Content Page";
			menuItemRename.Click += menuItemRename_Click;
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemSaveContentPage, menuItemSaveTemplate });
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(192, 22);
			openToolStripMenuItem.Text = "Save";
			// 
			// menuItemSaveContentPage
			// 
			menuItemSaveContentPage.Name = "menuItemSaveContentPage";
			menuItemSaveContentPage.Size = new Size(146, 22);
			menuItemSaveContentPage.Text = "Content Page";
			menuItemSaveContentPage.Click += menuItemSaveContentPage_Click;
			// 
			// menuItemSaveTemplate
			// 
			menuItemSaveTemplate.Name = "menuItemSaveTemplate";
			menuItemSaveTemplate.Size = new Size(146, 22);
			menuItemSaveTemplate.Text = "Template";
			menuItemSaveTemplate.Click += menuItemSaveTemplate_Click;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(192, 22);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// viewToolStripMenuItem
			// 
			viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemChangeTheme });
			viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			viewToolStripMenuItem.Size = new Size(44, 20);
			viewToolStripMenuItem.Text = "View";
			// 
			// menuItemChangeTheme
			// 
			menuItemChangeTheme.Name = "menuItemChangeTheme";
			menuItemChangeTheme.Size = new Size(154, 22);
			menuItemChangeTheme.Text = "Change Theme";
			menuItemChangeTheme.Click += changeThemeToolStripMenuItem_Click;
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(52, 20);
			aboutToolStripMenuItem.Text = "About";
			aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
			// 
			// openFileDialog
			// 
			openFileDialog.FileName = "openFileDialog1";
			// 
			// tableLayoutPanelInteractors
			// 
			tableLayoutPanelInteractors.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanelInteractors.ColumnCount = 1;
			tableLayoutPanelInteractors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelInteractors.Controls.Add(buttonGoToMeet, 0, 3);
			tableLayoutPanelInteractors.Controls.Add(buttonDeleteLesson, 0, 2);
			tableLayoutPanelInteractors.Controls.Add(buttonModifyLesson, 0, 1);
			tableLayoutPanelInteractors.Controls.Add(buttonCreateLesson, 0, 0);
			tableLayoutPanelInteractors.Location = new Point(210, 263);
			tableLayoutPanelInteractors.Name = "tableLayoutPanelInteractors";
			tableLayoutPanelInteractors.RowCount = 4;
			tableLayoutPanelInteractors.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanelInteractors.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanelInteractors.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanelInteractors.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanelInteractors.Size = new Size(433, 156);
			tableLayoutPanelInteractors.TabIndex = 8;
			// 
			// buttonGoToMeet
			// 
			buttonGoToMeet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonGoToMeet.Location = new Point(3, 120);
			buttonGoToMeet.Name = "buttonGoToMeet";
			buttonGoToMeet.Size = new Size(427, 33);
			buttonGoToMeet.TabIndex = 5;
			buttonGoToMeet.Text = "Go to meet";
			buttonGoToMeet.UseVisualStyleBackColor = true;
			buttonGoToMeet.Click += buttonGoToMeet_Click;
			// 
			// buttonDeleteLesson
			// 
			buttonDeleteLesson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonDeleteLesson.Location = new Point(3, 81);
			buttonDeleteLesson.Name = "buttonDeleteLesson";
			buttonDeleteLesson.Size = new Size(427, 33);
			buttonDeleteLesson.TabIndex = 4;
			buttonDeleteLesson.Text = "Delete Lesson";
			buttonDeleteLesson.UseVisualStyleBackColor = true;
			buttonDeleteLesson.Click += buttonDeleteLesson_Click;
			// 
			// buttonModifyLesson
			// 
			buttonModifyLesson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonModifyLesson.Location = new Point(3, 42);
			buttonModifyLesson.Name = "buttonModifyLesson";
			buttonModifyLesson.Size = new Size(427, 33);
			buttonModifyLesson.TabIndex = 2;
			buttonModifyLesson.Text = "Modify Lesson";
			buttonModifyLesson.UseVisualStyleBackColor = true;
			buttonModifyLesson.Click += buttonModifyLesson_Click;
			// 
			// buttonCreateLesson
			// 
			buttonCreateLesson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonCreateLesson.ForeColor = SystemColors.ControlText;
			buttonCreateLesson.Location = new Point(3, 3);
			buttonCreateLesson.Name = "buttonCreateLesson";
			buttonCreateLesson.Size = new Size(427, 33);
			buttonCreateLesson.TabIndex = 0;
			buttonCreateLesson.Text = "Create Lesson";
			buttonCreateLesson.UseVisualStyleBackColor = true;
			buttonCreateLesson.Click += buttonCreateLesson_Click;
			// 
			// labelHomeworkSign
			// 
			labelHomeworkSign.AutoSize = true;
			labelHomeworkSign.Location = new Point(3, 0);
			labelHomeworkSign.Name = "labelHomeworkSign";
			labelHomeworkSign.Size = new Size(66, 15);
			labelHomeworkSign.TabIndex = 9;
			labelHomeworkSign.Text = "Homework";
			// 
			// textBoxHomework
			// 
			textBoxHomework.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxHomework.Enabled = false;
			textBoxHomework.Location = new Point(3, 3);
			textBoxHomework.Multiline = true;
			textBoxHomework.Name = "textBoxHomework";
			textBoxHomework.ReadOnly = true;
			textBoxHomework.Size = new Size(256, 160);
			textBoxHomework.TabIndex = 10;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(comboBoxWeekDays, 0, 2);
			tableLayoutPanel1.Controls.Add(listBoxLessons, 0, 1);
			tableLayoutPanel1.Controls.Add(labelContentName, 0, 0);
			tableLayoutPanel1.Location = new Point(4, 37);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(200, 382);
			tableLayoutPanel1.TabIndex = 11;
			// 
			// comboBoxWeekDays
			// 
			comboBoxWeekDays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			comboBoxWeekDays.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxWeekDays.FormattingEnabled = true;
			comboBoxWeekDays.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
			comboBoxWeekDays.Location = new Point(3, 357);
			comboBoxWeekDays.Name = "comboBoxWeekDays";
			comboBoxWeekDays.Size = new Size(194, 23);
			comboBoxWeekDays.TabIndex = 14;
			comboBoxWeekDays.SelectedIndexChanged += comboBoxWeekDays_SelectedIndexChanged;
			// 
			// labelContentName
			// 
			labelContentName.AutoSize = true;
			labelContentName.Location = new Point(3, 0);
			labelContentName.Name = "labelContentName";
			labelContentName.Size = new Size(106, 15);
			labelContentName.TabIndex = 3;
			labelContentName.Text = "New Content Page";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(checkBoxIsDone, 0, 1);
			tableLayoutPanel2.Controls.Add(textBoxHomework, 0, 0);
			tableLayoutPanel2.Location = new Point(3, 20);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			tableLayoutPanel2.Size = new Size(262, 194);
			tableLayoutPanel2.TabIndex = 12;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
			tableLayoutPanel3.Controls.Add(labelHomeworkSign, 0, 0);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 1);
			tableLayoutPanel3.Controls.Add(labelNotation, 1, 0);
			tableLayoutPanel3.Controls.Add(textBoxNotation, 1, 1);
			tableLayoutPanel3.Location = new Point(210, 40);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Size = new Size(430, 217);
			tableLayoutPanel3.TabIndex = 13;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(655, 431);
			Controls.Add(tableLayoutPanel3);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(tableLayoutPanelInteractors);
			Controls.Add(menuStrip);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip;
			MinimumSize = new Size(405, 396);
			Name = "MainForm";
			Text = "Romplate";
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			tableLayoutPanelInteractors.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBoxLessons;
		private TextBox textBoxNotation;
		private Label labelNotation;
		private CheckBox checkBoxIsDone;
		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private ToolStripMenuItem templateToolStripMenuItem;
		private ToolStripMenuItem menuItemNewContentPage;
		private ToolStripMenuItem menuItemSaveContentPage;
		private ToolStripMenuItem menuItemSaveTemplate;
		private OpenFileDialog openFileDialog;
		private SaveFileDialog saveFileDialog;
		private TableLayoutPanel tableLayoutPanelInteractors;
		private Button buttonDeleteLesson;
		private Button buttonModifyLesson;
		private Button buttonCreateLesson;
		private Button buttonGoToMeet;
		private Label labelHomeworkSign;
		private TextBox textBoxHomework;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private ToolStripMenuItem menuItemOpenContentPage;
		private ToolStripMenuItem menuItemOpenTemplate;
		private Label labelContentName;
		private ToolStripMenuItem menuItemRename;
		private ToolStripMenuItem viewToolStripMenuItem;
		private ToolStripMenuItem menuItemChangeTheme;
		private ComboBox comboBoxWeekDays;
	}
}