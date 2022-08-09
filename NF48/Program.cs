using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NF48
{
	internal class Program
	{
		public static void Main()
		{
			var logSource = "DummyEventSourceName";
			var logName = $"{logSource}";
			//int[] eventTypes = { 1,
			// 2,
			// 4,
			// 8,
			// 0x10 };
			//
			///*Create an EventLog instance and assign its source.*/
			//CreateEventSourceIfNotExist(logSource, logName);
			//using (var myLog = new EventLog())
			//{
			//	myLog.Source = logSource;
			//
			//	//foreach (var iLogType in eventTypes)
			//	//{
			//	//WriteLog(myLog, "Try write log.", (EventLogEntryType)iLogType);
			//	//Console.WriteLine($"Writing to event log successfully. LogType:{(EventLogEntryType)iLogType}");
			//	//}
			//
			//	WriteLog(myLog, "Try write log.", EventLogEntryType.Information);
			//	Console.WriteLine($"Writing to event log successfully. LogType:{EventLogEntryType.Information}");
			//}

			DeleteEventSource(logSource, logName);

			Console.ReadKey();
		}
		static bool WriteLog(EventLog eventLog, string message, EventLogEntryType type)
		{
			try
			{
				eventLog.WriteEntry($"{message} Type:{type}", type);
			}
			catch (Exception e)
			{
				Console.WriteLine(new string('=', Console.WindowWidth / 2));
				Console.WriteLine($"Failed Log Type: {type}");
				Console.WriteLine(e.ToString());
			}

			return true;
		}
		static bool CreateEventSourceIfNotExist(string logSource, string logName)
		{
			try
			{
				// Create the source, if it does not already exist.
				if (!EventLog.SourceExists(logSource))
				{
					//An event log source should not be created and immediately used.
					//There is a latency time to enable the source, it should be created
					//prior to executing the application that uses the source.
					//Execute this sample a second time to use the new source.
					Console.WriteLine("Source Not Exist, try create one");
					Console.ReadKey();
					EventLog.CreateEventSource(logSource, logName);
					Console.WriteLine($"CreatedEventSource {logName}");
					Console.WriteLine("Exiting, execute the application a second time to use the source.");
					// The source is created.  Exit the application to allow it to be registered.

				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				Console.ReadKey();
				return false;
			}
			return true;
		}
		static void DeleteEventSource(string logSource, string logName)
		{
			try
			{
				if (EventLog.SourceExists(logSource))
				{
					EventLog.DeleteEventSource(logSource);
					//EventLog.Delete(logName);
					Console.WriteLine("Delete event log successfully.");
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Not found source: " + logSource);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}
	}
}
