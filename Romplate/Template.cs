using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	internal class Template
	{
		public struct LessonBunch
		{
			public string Name;
			public string Link;
		}
		private List<LessonBunch>[] NameIndexes;

		public const int DaysInWeek = 7;

		public int Count { get; private set; }
		private int currentDay = 0;
		public int CurrentDay
		{
			set
			{
				currentDay = value;	
				calculateCount();
			}
			get
			{
				return currentDay;
			}
		}

		private void calculateCount()
		{
			Count = NameIndexes[currentDay].Count;
		}

		public Template() {
			NameIndexes = new List<LessonBunch>[DaysInWeek];
			for(int i = 0; i < DaysInWeek; i++)
			{
				NameIndexes[i] = new List<LessonBunch>();
			}

			CurrentDay = 0;
		}

		public Template(List<LessonBunch>[] nameIndexes)
		{
			NameIndexes = nameIndexes;
			CurrentDay = 0;
		}

		public void CreateLesson()
		{
			NameIndexes[currentDay].Add(new LessonBunch { Name = "New Lesson" });
			calculateCount();
		}

		public void DeleteLesson(int index)
		{
			NameIndexes[currentDay].RemoveAt(index);
			calculateCount();
		}

		public string GetName(int index)
		{
			return NameIndexes[currentDay][index].Name;
		}

		public string GetLink(int index)
		{
			return NameIndexes[currentDay][index].Link;
		}

		public void SetName(int index, string name)
		{
			var lesson = NameIndexes[currentDay][index];
			lesson.Name = name;
			NameIndexes[CurrentDay][index] = lesson;
			calculateCount();
		}

		public void SetLink(int index, string link)
		{
			var lesson = NameIndexes[currentDay][index];
			lesson.Link = link;
			NameIndexes[CurrentDay][index] = lesson;
			calculateCount();
		}

		internal bool IsEmpty()
		{
			bool isEmpty = true;
			foreach(var lesson in NameIndexes)
			{
				if(!(isEmpty = lesson.Count == 0))
					break;
			}
			
			return isEmpty;
		}
	}
}
