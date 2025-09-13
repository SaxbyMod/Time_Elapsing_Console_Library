using System.Threading.Tasks;
using AnsiConsolePlugin.Util;
using System;
using System.Threading;

namespace TimeElapsingConsolePlugin.Util
{
	public class Logging
	{
		public static Information StartWaitTime(string WhatDoWeAwait, string Type, string ModName)
		{
			var Info = new Information(WhatDoWeAwait, Type, ModName);
			Info.Run?.Cancel();
			Info.Run = new CancellationTokenSource();
			Stopwatches.HandleStopwatch("Reset", Info.watch);
			Stopwatches.HandleStopwatch("Start", Info.watch);
			Task.Run(async () =>
				{
					while (!Info.Run.IsCancellationRequested)
					{
						int AwaitedTime = Stopwatches.GetTimeFromType(Info.Type, Stopwatches.HandleStopwatch("Elapsed", Info.watch));
						LogMessage(AwaitedTime, Info);
						await Task.Delay(100, Info.Run.Token);
					}
				}
			);
			return Info;
		}
		public static void StopWaitTime (Information Info)
		{
			if (Info.Run == null)
			{
				return;
			}
			Info.Run.Cancel();
			Stopwatches.HandleStopwatch("Stop", Info.watch);
			int AwaitedTime = Stopwatches.GetTimeFromType(Info.Type, Stopwatches.HandleStopwatch("Elapsed", Info.watch));
			Console.WriteLine("[Time Elapsing Console Library - " + Info.ModName + "]: " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityBold") + "Finished loading " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityUnderlined") + Info.WhatDoWeAwait.ToLower() + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityBold") + " time taken to load: " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityUnderlined") + AwaitedTime + Info.Type + ANSICodeLists.ResetColor + "   ");
		}
		
		public static void LogMessage(int Time, Information Info)
		{
			int height = Console.CursorTop;
			int column = Console.CursorLeft;
			Console.Write("[Time Elapsing Console Library - " + Info.ModName + "]: " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityBold") + "Awaiting time for " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityUnderlined") + Info.WhatDoWeAwait.ToLower() + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityBold") + " time spent waiting: " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityUnderlined") + Time + Info.Type + ANSICodeLists.ResetColor);
			Console.SetCursorPosition(column, height);
		}
	}
}