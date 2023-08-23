using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	internal class Template
	{
		private List<string>[] Indexs;

		public int Count { get; private set; }
		public int CurrentDay { get; set; }

		public Template() {
			Indexs = new List<string>[7];
			for(int i = 0; i < 7; i++)
			{
				Indexs[i] = new List<string>();
				Indexs[i].Add("New Lesson");
			}
			CurrentDay = 0;

		}

		public Template(List<string>[] indexs)
		{
			Indexs = indexs;
		}

		public string GetName(int index)
		{
			return Indexs[CurrentDay][index];
		}

		public int GetIndex(string name)
		{
			return Indexs[CurrentDay].IndexOf(name);
		}

		public void AddName(string name)
		{
			Indexs[CurrentDay].Add(name);
			Count = Indexs[CurrentDay].Count;
		}

		public void DeleteName(string name)
		{
			Indexs[CurrentDay].Remove(name);
		}
		
		public void DeleteName(int index)
		{
			Indexs[CurrentDay].RemoveAt(index);
		}
	}
}
