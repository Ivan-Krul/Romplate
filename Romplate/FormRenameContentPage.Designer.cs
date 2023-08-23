namespace Romplate
{
	partial class FormRenameContentPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRenameContentPage));
			tableLayoutPanel1 = new TableLayoutPanel();
			buttonCancel = new Button();
			buttonApply = new Button();
			tableLayoutPanel2 = new TableLayoutPanel();
			labelNewName = new Label();
			textBoxNewName = new TextBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(buttonCancel, 0, 0);
			tableLayoutPanel1.Controls.Add(buttonApply, 1, 0);
			tableLayoutPanel1.Location = new Point(3, 64);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(219, 31);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// buttonCancel
			// 
			buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonCancel.Location = new Point(3, 3);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(103, 25);
			buttonCancel.TabIndex = 0;
			buttonCancel.Text = "Cancel";
			buttonCancel.UseVisualStyleBackColor = true;
			buttonCancel.Click += buttonCancel_Click;
			// 
			// buttonApply
			// 
			buttonApply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			buttonApply.Location = new Point(112, 3);
			buttonApply.Name = "buttonApply";
			buttonApply.Size = new Size(104, 25);
			buttonApply.TabIndex = 1;
			buttonApply.Text = "Apply";
			buttonApply.UseVisualStyleBackColor = true;
			buttonApply.Click += buttonApply_Click;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(labelNewName, 0, 0);
			tableLayoutPanel2.Controls.Add(textBoxNewName, 0, 1);
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(219, 55);
			tableLayoutPanel2.TabIndex = 1;
			// 
			// labelNewName
			// 
			labelNewName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelNewName.AutoSize = true;
			labelNewName.Location = new Point(3, 0);
			labelNewName.Name = "labelNewName";
			labelNewName.Size = new Size(213, 28);
			labelNewName.TabIndex = 0;
			labelNewName.Text = "New name for Content Page";
			// 
			// textBoxNewName
			// 
			textBoxNewName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBoxNewName.Location = new Point(3, 31);
			textBoxNewName.Name = "textBoxNewName";
			textBoxNewName.Size = new Size(213, 23);
			textBoxNewName.TabIndex = 1;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 1);
			tableLayoutPanel3.Location = new Point(12, 12);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
			tableLayoutPanel3.Size = new Size(225, 98);
			tableLayoutPanel3.TabIndex = 2;
			// 
			// FormRenameContentPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(249, 122);
			Controls.Add(tableLayoutPanel3);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(265, 161);
			Name = "FormRenameContentPage";
			Text = "Rename Content Page";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private Button buttonCancel;
		private Button buttonApply;
		private Label labelNewName;
		private TextBox textBoxNewName;
	}
}