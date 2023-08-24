using System.Diagnostics;
using System.Windows.Forms;

namespace Romplate
{
	public partial class MainForm : Form
	{
		private ContentPage currentContent;
		private Template currentTemplate;

		private void updateListBox()
		{
			var day = currentContent.GetDay(currentTemplate.CurrentDay);
			listBoxLessons.Items.Clear();
			for (int i = 0; i < day.Count; i++)
			{
				listBoxLessons.Items.Add(currentTemplate.GetName(i));
			}

			labelContentName.Text = currentContent.Name;
		}

		private void turnAdditionalButtons()
		{
			var choice = listBoxLessons.SelectedIndex;
			buttonDeleteLesson.Enabled = choice != -1;
			buttonModifyLesson.Enabled = choice != -1;
			buttonGoToMeet.Enabled = choice != -1;
			textBoxNotation.Enabled = choice != -1;
			if (choice != -1)
			{
				textBoxHomework.Text = currentContent.GetDay(currentTemplate.CurrentDay).GetHomework(choice).HomeworkInstance;
				buttonGoToMeet.Enabled = currentTemplate.GetLink(choice) != string.Empty;
			}
			else
				textBoxHomework.Text = "";

			updateCheckBox(false);
		}

		private void updateCheckBox(bool isChoosed)
		{
			checkBoxIsDone.Enabled = checkBoxIsDone.Checked == false && isChoosed;
		}

		public MainForm()
		{
			currentContent = new ContentPage();
			currentTemplate = new Template();

			InitializeComponent();

			buttonDeleteLesson.Enabled = false;
			buttonModifyLesson.Enabled = false;
			buttonGoToMeet.Enabled = false;
			updateCheckBox(false);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void numericUpDownWeekDays_ValueChanged(object sender, EventArgs e)
		{
			currentTemplate.CurrentDay = (int)numericUpDownWeekDays.Value - 1;
			switch (currentTemplate.CurrentDay)
			{
				case 0:
					labelDayWeek.Text = "Monday";
					break;
				case 1:
					labelDayWeek.Text = "Tuesday";
					break;
				case 2:
					labelDayWeek.Text = "Wednesday";
					break;
				case 3:
					labelDayWeek.Text = "Thursday";
					break;
				case 4:
					labelDayWeek.Text = "Friday";
					break;
				case 5:
					labelDayWeek.Text = "Saturday";
					break;
				case 6:
					labelDayWeek.Text = "Sunday";
					break;
			}
			updateListBox();
			turnAdditionalButtons();
			textBoxNotation.Text = currentContent.GetDay(currentTemplate.CurrentDay).Notation;
		}

		private void buttonCreateLesson_Click(object sender, EventArgs e)
		{
			var day = currentContent.GetDay(currentTemplate.CurrentDay);
			day.CreateHomework();
			currentContent.SetDay(currentTemplate.CurrentDay, day);

			currentTemplate.CreateLesson();
			updateListBox();
			turnAdditionalButtons();
		}

		private void buttonDeleteLesson_Click(object sender, EventArgs e)
		{
			var day = currentContent.GetDay(currentTemplate.CurrentDay);
			var choice = listBoxLessons.SelectedIndex;
			if (choice != -1)
			{
				day.DeleteHomework(choice);
				currentTemplate.DeleteLesson(choice);
				currentContent.SetDay(currentTemplate.CurrentDay, day);
			}

			updateListBox();

			if (choice != -1)
				listBoxLessons.SelectedIndex = choice - 1;
			turnAdditionalButtons();
		}

		private void listBoxLessons_SelectedIndexChanged(object sender, EventArgs e)
		{
			turnAdditionalButtons();
			updateCheckBox(false);
			var choice = listBoxLessons.SelectedIndex;
			if (choice == -1)
				return;

			var day = currentContent.GetDay(currentTemplate.CurrentDay);
			var homework = day.GetHomework(choice);

			textBoxHomework.Text = homework.HomeworkInstance;
			checkBoxIsDone.Checked = homework.IsDone;
			updateCheckBox(true);
		}

		private void checkBoxIsDone_CheckedChanged(object sender, EventArgs e)
		{
			var choice = listBoxLessons.SelectedIndex;
			if (choice == -1)
				return;

			var day = currentContent.GetDay(currentTemplate.CurrentDay);
			var lesson = day.GetHomework(choice);

			lesson.MarkDone();
			updateCheckBox(true);
		}

		private void textBoxNotation_TextChanged(object sender, EventArgs e)
		{
			var day = currentContent.GetDay(currentTemplate.CurrentDay);
			day.Notation = textBoxNotation.Text;
			currentContent.SetDay(currentTemplate.CurrentDay, day);
		}

		private void handleClosingFormClosingEventHandler()
		{
			var day = currentContent.GetDay(currentTemplate.CurrentDay);
			var homework = FormModifyLessonHelpers.TransferedHomework;
			var index = listBoxLessons.SelectedIndex;
			currentTemplate.SetName(index, FormModifyLessonHelpers.Name);
			currentTemplate.SetLink(index, FormModifyLessonHelpers.Link);
			day.ModifyHomework(index, homework);
			updateListBox();
			updateCheckBox(true);
			turnAdditionalButtons();
			textBoxHomework.Text = homework.HomeworkInstance;
		}

		private void buttonModifyLesson_Click(object sender, EventArgs e)
		{
			var day = currentContent.GetDay(currentTemplate.CurrentDay);
			var homework = day.GetHomework(listBoxLessons.SelectedIndex);
			var index = listBoxLessons.SelectedIndex;
			FormModifyLessonHelpers.TransferedHomework = homework;
			FormModifyLessonHelpers.Name = currentTemplate.GetName(index);
			FormModifyLessonHelpers.Link = currentTemplate.GetLink(index);
			FormModifyLesson formModifyLesson = new FormModifyLesson();
			formModifyLesson.FormClosing += FormModifyLesson_FormClosing;
			formModifyLesson.ShowDialog();
		}

		private void FormModifyLesson_FormClosing(object? sender, FormClosingEventArgs e)
		{
			handleClosingFormClosingEventHandler();
		}

		private void buttonGoToMeet_Click(object sender, EventArgs e)
		{
			if (listBoxLessons.SelectedIndex == -1)
				return;

			Process.Start("cmd.exe", "/c \"start " + currentTemplate.GetLink(listBoxLessons.SelectedIndex) + "\"");
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var dialogAbout = new AboutBox();

			dialogAbout.ShowDialog();
		}

		private void menuItemNewContentPage_Click(object sender, EventArgs e)
		{
			if (currentContent.IsEmpty())
				return;

			var res = MessageBox.Show("Do you want to reset content\n(erase only homeworks)?", "Reset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res.ToString() != "Yes")
				return;

			var curDay = currentTemplate.CurrentDay;

			currentContent = new ContentPage();

			for (int i = 0; i < Template.DaysInWeek; i++)
			{
				currentTemplate.CurrentDay = i;
				var day = new DayInWeek(currentTemplate.Count);
				currentContent.SetDay(currentTemplate.CurrentDay, day);
			}
			currentTemplate.CurrentDay = curDay;
		}

		private void templateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (currentTemplate.IsEmpty())
				return;

			var res = MessageBox.Show("Do you want to reset whole template\n(erase all data)?", "Reset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res.ToString() != "Yes")
				return;

			currentTemplate = new Template();
			currentContent = new ContentPage();
			turnAdditionalButtons();
			updateListBox();
			updateCheckBox(false);
		}

		private void menuItemOpenContentPage_Click(object sender, EventArgs e)
		{
			openFileDialog.AddExtension = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.DefaultExt = "rmcp";
			openFileDialog.FileName = currentContent.Name;
			openFileDialog.Filter = "Rompacter Content Page files (*.rmcp)|*.rmcp|All files (*.*)|*.*";
			openFileDialog.Title = "Open Content Page";
			openFileDialog.FileOk += OpenFileDialogOpenContentPage_FileOk;

			openFileDialog.ShowDialog();
		}

		private void OpenFileDialogOpenContentPage_FileOk(object? sender, System.ComponentModel.CancelEventArgs e)
		{
			currentContent = FileManagerContentPage.Load(openFileDialog.FileName);
		}

		private void menuItemRename_Click(object sender, EventArgs e)
		{
			FormRenameContentPageHelpers.Name = currentContent.Name;
			var form = new FormRenameContentPage();
			form.FormClosing += FormRenameContentPage_FormClosing;
			form.ShowDialog();
		}

		private void FormRenameContentPage_FormClosing(object? sender, FormClosingEventArgs e)
		{
			currentContent.Name = FormRenameContentPageHelpers.Name;
			updateListBox();
		}

		private void menuItemSaveContentPage_Click(object sender, EventArgs e)
		{
			saveFileDialog.AddExtension = true;
			saveFileDialog.CheckPathExists = true;
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.DefaultExt = "rmcp";
			saveFileDialog.FileName = currentContent.Name;
			saveFileDialog.Filter = "Rompacter Content Page files (*.rmcp)|*.rmcp|All files (*.*)|*.*";
			saveFileDialog.Title = "Save Content Page";
			saveFileDialog.FileOk += OpenFileDialogSaveContentPage_FileOk;

			saveFileDialog.ShowDialog();
		}

		private void OpenFileDialogSaveContentPage_FileOk(object? sender, System.ComponentModel.CancelEventArgs e)
		{
			FileManagerContentPage.Save(saveFileDialog.FileName, currentContent);
		}

		private void menuItemSaveTemplate_Click(object sender, EventArgs e)
		{
			saveFileDialog.AddExtension = true;
			saveFileDialog.CheckPathExists = true;
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.DefaultExt = "rmtp";
			saveFileDialog.FileName = currentContent.Name;
			saveFileDialog.Filter = "Rompacter Template files (*.rmtp)|*.rmtp|All files (*.*)|*.*";
			saveFileDialog.Title = "Save Template";
			saveFileDialog.FileOk += OpenFileDialogSaveTemplate_FileOk;

			saveFileDialog.ShowDialog();
		}

		private void OpenFileDialogSaveTemplate_FileOk(object? sender, System.ComponentModel.CancelEventArgs e)
		{
			FileManagerTemplate.Save(saveFileDialog.FileName, currentTemplate);
		}

		private void menuItemOpenTemplate_Click(object sender, EventArgs e)
		{
			openFileDialog.AddExtension = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.DefaultExt = "rmtp";
			openFileDialog.FileName = currentContent.Name;
			openFileDialog.Filter = "Rompacter Template files (*.rmtp)|*.rmtp|All files (*.*)|*.*";
			openFileDialog.Title = "Open Template";
			openFileDialog.FileOk += OpenFileDialogOpenTemplate_FileOk;

			openFileDialog.ShowDialog();
		}

		private void OpenFileDialogOpenTemplate_FileOk(object? sender, System.ComponentModel.CancelEventArgs e)
		{
			currentTemplate = FileManagerTemplate.Load(openFileDialog.FileName);
			currentContent = new ContentPage();
		}
	}
}