using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romplate
{
	public partial class FormRenameContentPage : Form
	{
		private void changeTheme()
		{
			BackColor = SystemColors.WindowText;
			ForeColor = SystemColors.Window;
			textBoxNewName.BackColor = SystemColors.WindowText;
			textBoxNewName.ForeColor = SystemColors.Window;
			buttonCancel.BackColor = SystemColors.WindowText;
			buttonCancel.ForeColor = SystemColors.Window;
			buttonApply.BackColor = SystemColors.WindowText;
			buttonApply.ForeColor = SystemColors.Window;
		}

		public FormRenameContentPage()
		{
			InitializeComponent();
			textBoxNewName.Text = FormRenameContentPageHelpers.Name;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			FormRenameContentPageHelpers.Name = textBoxNewName.Text;
			Close();
		}
	}
}
