using Romplate;
using System.Diagnostics;

internal static class FormModifyLessonHelpers
{
	public static bool IsClosed { get; set; } = false;
	public static Lesson TransferedLesson { get; set; }
	public static string Name { get; set; }
	public static string Link { get; set; }
}