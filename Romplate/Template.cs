using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	//internal class Template
	//{
	//	private List<string>[] Indexs;
	//
	//	public int Count { get; private set; }
	//	public int CurrentDay { get; set; }
	//
	//	public Template()
	//	{
	//		Indexs = new List<string>[7];
	//		for (int i = 0; i < 7; i++)
	//		{
	//			Indexs[i] = new List<string>();
	//			Indexs[i].Add("New Lesson");
	//		}
	//		CurrentDay = 0;
	//
	//	}
	//
	//	public Template(List<string>[] indexs)
	//	{
	//		Indexs = indexs;
	//	}
	//
	//	public string GetName(int index)
	//	{
	//		return Indexs[CurrentDay][index];
	//	}
	//
	//	public int GetIndex(string name)
	//	{
	//		return Indexs[CurrentDay].IndexOf(name);
	//	}
	//
	//	public void AddName(string name)
	//	{
	//		Indexs[CurrentDay].Add(name);
	//		Count = Indexs[CurrentDay].Count;
	//	}
	//
	//	public void DeleteName(string name)
	//	{
	//		Indexs[CurrentDay].Remove(name);
	//	}
	//
	//	public void DeleteName(int index)
	//	{
	//		Indexs[CurrentDay].RemoveAt(index);
	//	}
	//}

	internal class Template
	{
		public struct LessonBunch
		{
			public string Name;
			public string Link;
		}
		private List<LessonBunch>[] NameIndexes;

		public int Count { get; private set; }
		private int currentDay = 9;
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
			NameIndexes = new List<LessonBunch>[7];
			for(int i = 0; i < 7; i++)
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
	}
}
