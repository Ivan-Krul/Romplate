using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	internal class Lesson
	{
		public string Homework { get; set; }
		public string Link { get; set; }
		public bool IsDone { get; private set; }

		public Lesson()
		{
			Homework = "";
			Link = "";
			IsDone = false;
		}

		public void MarkDone()
		{
			IsDone = true;
		}
	}
}
