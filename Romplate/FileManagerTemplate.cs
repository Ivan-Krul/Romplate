using System;
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
	 *Structure:
	 *		7 > d
	 *		->
	 *			Count > l
	 *			->
	 *				&Str(GetName(l))
	 *				&Str(GetLink(l))
	 *			<-
	 *		<-
	 */
	internal class FileManagerTemplate
	{
		public static void Save(string path, Template template)
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
					for(int d = 0; d < Template.DaysInWeek; d++)
					{
						template.CurrentDay = d;
						writer.Write(template.Count);
						for(int l = 0; l < template.Count; l++)
						{
							writer.Write(template.GetName(l));
							writer.Write(template.GetLink(l));
						}
					}
					writer.Close();
				}
				file.Close();
			}
		}
		public static Template Load(string path)
		{
			var template = new Template();

			using (FileStream file = new FileStream(path, FileMode.Open))
			{
				using (BinaryReader reader = new BinaryReader(file))
				{
					for(int d = 0; d < Template.DaysInWeek; d++)
					{
						int lessonCount = reader.ReadInt32();
						for(int l = 0; l <  lessonCount; l++)
						{
							template.CreateLesson();
							template.SetName(l, reader.ReadString());
							template.SetName(l, reader.ReadString());
						}
					}
					reader.Close();
				}
				file.Close();
			}

			return template;
		}
	}
}
