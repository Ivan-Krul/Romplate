using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romplate
{
	internal class UserProfile
	{
		private static string AppDataFolderPath { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		public static string AuthorFolderAppData { get; } = "Ivan-Krul";
		public static string ProjectFolderAppData { get; } = "Romplate";
		private static void CheckForExistingAuthorFolder()
		{
			if (!Directory.Exists(AppDataFolderPath + "\\" + AuthorFolderAppData))
				Directory.CreateDirectory(AppDataFolderPath + "\\" + AuthorFolderAppData);
		}
		private static void CheckForExistingProjectFolder()
		{
			if (!Directory.Exists(AppDataFolderPath + "\\" + AuthorFolderAppData + "\\" + ProjectFolderAppData))
				Directory.CreateDirectory(AppDataFolderPath + "\\" + AuthorFolderAppData + "\\" + ProjectFolderAppData);
		}
		private static void CheckForExistingProfile()
		{
			if(!File.Exists(AppDataFolderPath + "\\" + AuthorFolderAppData + "\\" + ProjectFolderAppData + "\\" + "Profile.txt"))
			{
				FileStream file = new FileStream(AppDataFolderPath + "\\" + AuthorFolderAppData + "\\" + ProjectFolderAppData + "\\" + "Profile.txt", FileMode.OpenOrCreate);
				StreamWriter writer = new StreamWriter(file);

				writer.WriteLine("# ColorTheme");
				writer.WriteLine("DarkMode");

				writer.Close();
				file.Close();
			}
		}
		public static void Initialise()
		{
			CheckForExistingAuthorFolder();
			CheckForExistingProjectFolder();
			CheckForExistingProfile();

			FileStream file = new FileStream(AppDataFolderPath + "\\" + AuthorFolderAppData + "\\" + ProjectFolderAppData + "\\" + "Profile.txt", FileMode.Open);
			StreamReader reader = new StreamReader(file);

			int readIndex = 0;

			while(!reader.EndOfStream)
			{
				string line = reader.ReadLine();
				if (line[0] == '#')
					continue;
				switch(readIndex)
				{
					case 0:
						IsDarkTheme = line == "DarkMode";
						break;
					default:
						break;
				}
			}

			reader.Close();
			file.Close();

		}

		public static void Reinitialise()
		{
			CheckForExistingAuthorFolder();
			CheckForExistingProjectFolder();
			CheckForExistingProfile();

			FileStream file = new FileStream(AppDataFolderPath + "\\" + AuthorFolderAppData + "\\" + ProjectFolderAppData + "\\" + "Profile.txt", FileMode.Create);
			StreamWriter writer = new StreamWriter(file);

			writer.Write(IsDarkTheme ? "DarkMode" : "LightMode");

			writer.Close();
			file.Close();
		}

		public static bool IsDarkTheme { get; set; }
	}
}
