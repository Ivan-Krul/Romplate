namespace Romplate
{
	partial class FormModifyLesson
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyLesson));
			textBoxName = new TextBox();
			label1 = new Label();
			label2 = new Label();
			textBoxHomework = new TextBox();
			textBoxLink = new TextBox();
			labelLink = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			buttonApply = new Button();
			buttonCancel = new Button();
			tableLayoutPanel2 = new TableLayoutPanel();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// textBoxName
			// 
			textBoxName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBoxName.Location = new Point(3, 23);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(290, 23);
			textBoxName.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 1;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 48);
			label2.Name = "label2";
			label2.Size = new Size(66, 15);
			label2.TabIndex = 3;
			label2.Text = "Homework";
			// 
			// textBoxHomework
			// 
			textBoxHomework.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxHomework.Location = new Point(3, 71);
			textBoxHomework.Multiline = true;
			textBoxHomework.Name = "textBoxHomework";
			textBoxHomework.Size = new Size(290, 77);
			textBoxHomework.TabIndex = 2;
			// 
			// textBoxLink
			// 
			textBoxLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxLink.Location = new Point(3, 174);
			textBoxLink.Multiline = true;
			textBoxLink.Name = "textBoxLink";
			textBoxLink.Size = new Size(290, 77);
			textBoxLink.TabIndex = 4;
			// 
			// labelLink
			// 
			labelLink.AutoSize = true;
			labelLink.Location = new Point(3, 151);
			labelLink.Name = "labelLink";
			labelLink.Size = new Size(82, 15);
			labelLink.TabIndex = 5;
			labelLink.Text = "Link to a meet";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(buttonApply, 1, 0);
			tableLayoutPanel1.Controls.Add(buttonCancel, 0, 0);
			tableLayoutPanel1.Location = new Point(3, 257);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(290, 42);
			tableLayoutPanel1.TabIndex = 6;
			// 
			// buttonApply
			// 
			buttonApply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonApply.Location = new Point(148, 3);
			buttonApply.Name = "buttonApply";
			buttonApply.Size = new Size(139, 36);
			buttonApply.TabIndex = 1;
			buttonApply.Text = "Apply";
			buttonApply.UseVisualStyleBackColor = true;
			buttonApply.Click += buttonApply_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonCancel.Location = new Point(3, 3);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(139, 36);
			buttonCancel.TabIndex = 0;
			buttonCancel.Text = "Cancel";
			buttonCancel.UseVisualStyleBackColor = true;
			buttonCancel.Click += buttonCancel_Click;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(label1, 0, 0);
			tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 6);
			tableLayoutPanel2.Controls.Add(textBoxName, 0, 1);
			tableLayoutPanel2.Controls.Add(textBoxLink, 0, 5);
			tableLayoutPanel2.Controls.Add(labelLink, 0, 4);
			tableLayoutPanel2.Controls.Add(label2, 0, 2);
			tableLayoutPanel2.Controls.Add(textBoxHomework, 0, 3);
			tableLayoutPanel2.Location = new Point(12, 12);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 7;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
			tableLayoutPanel2.Size = new Size(296, 302);
			tableLayoutPanel2.TabIndex = 7;
			// 
			// FormModifyLesson
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(320, 326);
			Controls.Add(tableLayoutPanel2);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormModifyLesson";
			Text = "Modify Lesson";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TextBox textBoxName;
		private Label label1;
		private Label label2;
		private TextBox textBoxHomework;
		private TextBox textBoxLink;
		private Label labelLink;
		private TableLayoutPanel tableLayoutPanel1;
		private Button buttonCancel;
		private Button buttonApply;
		private TableLayoutPanel tableLayoutPanel2;
	}
}