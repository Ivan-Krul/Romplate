﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	/* 
	 * Definition:
	 *		&Str(string)
	 *		{
	 *			string.Count > c
	 *			->
	 *				string[c]
	 *			<-
	 *		}
	 * Structure:
	 *		&Str(Path to Template)
	 *		&Str(Name)
	 *		7 > d
	 *		->
	 *			GetDay(c).Count > h
	 *			->
	 *				&Str(GetDay(c).GetHomework(h).HomeworkInstance)
	 *				&Str(GetDay(c).GetHomework(h).IsDone
	 *			<-
	 *			&Str(GetDay(c).Notation)
	 *		<-
	 */
	internal class FileManagerContentPage
	{
		public static Template TemplateInstance { get; set; }

		public static void Save(string path, string pathToTemplate, ContentPage contentPage)
		{
			using (FileStream file = new FileStream(path, FileMode.Create))
			{
				using (BinaryWriter writer = new BinaryWriter(file))
				{

					for (int d = 0; d < Template.DaysInWeek; d++)
					{
						TemplateInstance.CurrentDay = d;
						writer.Write(TemplateInstance.Count);
						for (int l = 0; l < TemplateInstance.Count; l++)
						{
							writer.Write(TemplateInstance.GetName(l));
							writer.Write(TemplateInstance.GetLink(l));
						}
					}

					writer.Write(contentPage.Name);
					for(int d = 0; d < Template.DaysInWeek; d++)
					{
						writer.Write(contentPage.GetDay(d).Count);
						for (int h = 0; h < contentPage.GetDay(d).Count; h++)
						{
							writer.Write(contentPage.GetDay(d).GetHomework(h).HomeworkInstance);
							writer.Write(contentPage.GetDay(d).GetHomework(h).IsDone);
						}
						writer.Write(contentPage.GetDay(d).Notation);
					}

					writer.Close();
				}
				file.Close();
			}
		}

		public static ContentPage Load(string path)
		{
			ContentPage contentPage = new ContentPage();
			TemplateInstance = new Template();

			using (FileStream file = new FileStream(path, FileMode.Open))
			{
				using (BinaryReader reader = new BinaryReader(file))
				{
					for (int d = 0; d < Template.DaysInWeek; d++)
					{
						TemplateInstance.CurrentDay = d;
						int lessonCount = reader.ReadInt32();

						for (int l = 0; l < lessonCount; l++)
						{
							TemplateInstance.CreateLesson();
							TemplateInstance.SetName(l, reader.ReadString());
							TemplateInstance.SetLink(l, reader.ReadString());
						}
					}

					contentPage.Name = reader.ReadString();
					for(int d = 0; d < Template.DaysInWeek; d++)
					{
						var day = contentPage.GetDay(d);
						int homeworkCount = reader.ReadInt32();
						for (int h = 0; h < homeworkCount; h++) 
						{
							day.CreateHomework();
							var homework = day.GetHomework(h);
							homework.HomeworkInstance = reader.ReadString();

							if (reader.ReadBoolean())
								homework.MarkDone();

							day.ModifyHomework(h, homework);
						}
						day.Notation = reader.ReadString();
						contentPage.SetDay(d, day);
					}

					reader.Close();
				}
				file.Close();
			}
			return contentPage;
		}
	}
}
