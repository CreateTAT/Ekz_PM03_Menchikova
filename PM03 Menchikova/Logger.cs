using System;

public class Logger
{
	namespace Courses
    public static class Logger // имя своё
	{
		public static void WriteLog(string message)
		{
			string logPath = ConfigurationManager.AppSettings["logPath"];

			using (StreamWriter writer = new StreamWriter(logPath, true))
			{
				writer.WriteLine($"{DateTime.Now} : {message}");
			}
}
