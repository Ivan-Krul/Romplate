using Romplate;
using System.Diagnostics;

internal static class FormModifyLessonHelpers
{
	public static bool IsClosed { get; set; } = false;
	public static Homework TransferedHomework { get; set; }
	public static string Name { get; set; }
	public static string Link { get; set; }
}