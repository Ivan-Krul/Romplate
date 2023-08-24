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
	public partial class FormModifyLesson : Form
	{
		public FormModifyLesson()
		{
			InitializeComponent();

			textBoxHomework.Text = FormModifyLessonHelpers.TransferedHomework.HomeworkInstance;
			textBoxLink.Text = FormModifyLessonHelpers.Link;
			textBoxName.Text = FormModifyLessonHelpers.Name;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			FormModifyLessonHelpers.TransferedHomework.HomeworkInstance = textBoxHomework.Text;
			FormModifyLessonHelpers.Link = textBoxLink.Text;
			FormModifyLessonHelpers.Name = textBoxName.Text;
			Close();
		}
	}
}

