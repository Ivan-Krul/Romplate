using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	internal class DayInWeek
	{
		private List<Lesson> lessons;
		private List<int> nameIndexes;
		public string Notation { get; set; }
		public int Count { get; set; }

		public DayInWeek()
		{
			lessons = new List<Lesson>();
			nameIndexes = new List<int>();
			Notation = "";
			Count = 0;
		}

		public DayInWeek(List<Lesson> lessons, List<int> nameIndexes)
		{
			this.lessons = lessons;
			this.nameIndexes = nameIndexes;
			Notation = "";
			Count = this.lessons.Count;
		}

		public void CreateLesson()
		{
			lessons.Add(new Lesson());
			nameIndexes.Add(0);
			Count = this.lessons.Count;
		}

		public void DeleteLesson(int id)
		{
			lessons.RemoveAt(id);
			Count = this.lessons.Count;
		}

		public Lesson GetLesson(int id)
		{
			return lessons[id];
		}

		public int GetLessonNameID(int id)
		{
			return nameIndexes[id];
		}

		public void ModifyLesson(int id, Lesson lesson)
		{
			lessons[id] = lesson;
		}

		public void ModifyLesson(int id, int nameIndex)
		{
			nameIndexes[id] = nameIndex;
		}

		public void ModifyLesson(int id, int nameIndex, Lesson lesson)
		{
			lessons[id] = lesson;
			nameIndexes[id] = nameIndex;
		}
	}
}
