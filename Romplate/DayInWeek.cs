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
//		private List<int> nameIndexes;
		public string Notation { get; set; }
		public int Count { get; set; }

		public DayInWeek()
		{
			lessons = new List<Lesson>();
			Notation = "";
			Count = 0;
		}

		public DayInWeek(List<Lesson> lessons)
		{
			this.lessons = lessons;
			Notation = "";
			Count = this.lessons.Count;
		}

		public void CreateLesson()
		{
			lessons.Add(new Lesson());
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

		public void ModifyLesson(int id, Lesson lesson)
		{
			lessons[id] = lesson;
		}
	}
}
