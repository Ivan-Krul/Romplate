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
