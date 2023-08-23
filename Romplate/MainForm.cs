using System.Diagnostics;
using System.Windows.Forms;

namespace Romplate
{
	public partial class MainForm : Form
	{
		private Week currentWeek;
		private Template currentTemplate;

		private void updateListBox()
		{
			var day = currentWeek.GetDay(currentTemplate.CurrentDay);
			listBoxLessons.Items.Clear();
			for (int i = 0; i < day.Count; i++)
			{
				listBoxLessons.Items.Add(currentTemplate.GetName(day.GetLessonNameID(i)));
			}
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
				textBoxHomework.Text = currentWeek.GetDay(currentTemplate.CurrentDay).GetLesson(choice).Homework;
				buttonGoToMeet.Enabled = currentWeek.GetDay(currentTemplate.CurrentDay).GetLesson(choice).Link != string.Empty;
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
			currentWeek = new Week();
			currentTemplate = new Template();
			currentTemplate.AddName("New Lesson");

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
			textBoxNotation.Text = currentWeek.GetDay(currentTemplate.CurrentDay).Notation;
		}

		private void buttonCreateLesson_Click(object sender, EventArgs e)
		{
			var day = currentWeek.GetDay(currentTemplate.CurrentDay);
			day.CreateLesson();
			currentWeek.SetDay(currentTemplate.CurrentDay, day);
			updateListBox();
		}

		private void buttonDeleteLesson_Click(object sender, EventArgs e)
		{
			var day = currentWeek.GetDay(currentTemplate.CurrentDay);
			var choice = listBoxLessons.SelectedIndex;
			if (choice != -1)
			{
				day.DeleteLesson(choice);
				currentWeek.SetDay(currentTemplate.CurrentDay, day);
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

			var day = currentWeek.GetDay(currentTemplate.CurrentDay);
			var lesson = day.GetLesson(choice);

			textBoxHomework.Text = lesson.Homework;
			checkBoxIsDone.Checked = lesson.IsDone;
			updateCheckBox(true);
		}

		private void checkBoxIsDone_CheckedChanged(object sender, EventArgs e)
		{
			var choice = listBoxLessons.SelectedIndex;
			if (choice == -1)
				return;

			var day = currentWeek.GetDay(currentTemplate.CurrentDay);
			var lesson = day.GetLesson(choice);

			lesson.MarkDone();
			updateCheckBox(true);
		}

		private void textBoxNotation_TextChanged(object sender, EventArgs e)
		{
			var day = currentWeek.GetDay(currentTemplate.CurrentDay);
			day.Notation = textBoxNotation.Text;
			currentWeek.SetDay(currentTemplate.CurrentDay, day);
		}

		private void handleClosingFormClosingEventHandler()
		{
			var day = currentWeek.GetDay(currentTemplate.CurrentDay);
			var lesson = FormModifyLessonHelpers.TransferedLesson;
			var index = currentTemplate.GetIndex(FormModifyLessonHelpers.Name);
			if (index == -1)
			{
				currentTemplate.AddName(FormModifyLessonHelpers.Name);
				index = currentTemplate.GetIndex(FormModifyLessonHelpers.Name);
			}
			day.ModifyLesson(listBoxLessons.SelectedIndex, index, lesson);
			updateListBox();
			updateCheckBox(true);
			turnAdditionalButtons();
			textBoxHomework.Text = lesson.Homework;
		}

		private void buttonModifyLesson_Click(object sender, EventArgs e)
		{
			var day = currentWeek.GetDay(currentTemplate.CurrentDay);
			var lesson = day.GetLesson(listBoxLessons.SelectedIndex);
			FormModifyLessonHelpers.TransferedLesson = lesson;
			FormModifyLessonHelpers.Name = currentTemplate.GetName(day.GetLessonNameID(listBoxLessons.SelectedIndex));
			FormModifyLesson formModifyLesson = new FormModifyLesson();
			formModifyLesson.ShowDialog();

			while (!FormModifyLessonHelpers.IsClosed) ;

			handleClosingFormClosingEventHandler();

		}

		private void buttonGoToMeet_Click(object sender, EventArgs e)
		{
			if (listBoxLessons.SelectedIndex == -1)
				return;

			var day = currentWeek.GetDay(currentTemplate.CurrentDay);
			var lesson = day.GetLesson(listBoxLessons.SelectedIndex);

			Process.Start("cmd.exe", "/c \"start " + lesson.Link + "\"");
		}
	}
}