using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	/* 
	 * Definition:
	 * &Str(string)
	 *	{
	 *		string.Count > c
	 *		->
	 *			string[c]
	 *		<-
	 *	}
	 * Structure:
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
		public static void Save(string path, ContentPage contentPage)
		{
			if (File.Exists(path))
			{
				var res = MessageBox.Show("Do you want to override the file?", "Override?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (res.ToString() == "No")
					return;

				File.Delete(path);
			}

			using (FileStream file = new FileStream(path, FileMode.Create))
			{
				using (BinaryWriter writer = new BinaryWriter(file))
				{
					writer.Write(contentPage.Name);
					for(int d = 0; d < 7; d++)
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
			var contentPage = new ContentPage();

			using (FileStream file = new FileStream(path, FileMode.Open))
			{
				using (BinaryReader reader = new BinaryReader(file))
				{
					contentPage.Name = reader.ReadString();
					for(int d = 0; d < 7; d++)
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
