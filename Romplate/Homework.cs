using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	internal class Homework
	{
		public string HomeworkInstance { get; set; }
		public bool IsDone { get; private set; }

		public Homework()
		{
			HomeworkInstance = "";
			IsDone = false;
		}

		public void MarkDone()
		{
			IsDone = true;
		}
	}
}
