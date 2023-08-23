﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	internal class ContentPage
	{
		private DayInWeek[] days;

		public ContentPage()
		{
			days = new DayInWeek[7];
			for(int i = 0; i < days.Length; i++)
			{
				days[i] = new DayInWeek();
			}

		}

		public ContentPage(DayInWeek[] days)
		{
			this.days = days;
		}

		public DayInWeek GetDay(int day)
		{
			return days[day];
		}

		public void SetDay(int day, DayInWeek dayInstance)
		{
			days[day] = dayInstance;
		}
	}
}