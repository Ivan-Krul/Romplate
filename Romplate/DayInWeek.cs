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
		private List<Homework> homeworks;
//		private List<int> nameIndexes;
		public string Notation { get; set; }
		public int Count { get; set; }

		public DayInWeek()
		{
			homeworks = new List<Homework>();
			Notation = "";
			Count = 0;
		}

		public DayInWeek(List<Homework> lessons)
		{
			this.homeworks = lessons;
			Notation = "";
			Count = this.homeworks.Count;
		}

		public void CreateHomework()
		{
			homeworks.Add(new Homework());
			Count = this.homeworks.Count;
		}

		public void DeleteHomework(int id)
		{
			homeworks.RemoveAt(id);
			Count = this.homeworks.Count;
		}

		public Homework GetHomework(int id)
		{
			return homeworks[id];
		}

		public void ModifyHomework(int id, Homework lesson)
		{
			homeworks[id] = lesson;
		}
	}
}
