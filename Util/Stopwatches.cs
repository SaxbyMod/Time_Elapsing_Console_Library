using System;
using System.Diagnostics;

namespace TimeElapsingConsolePlugin.Util
{
	public class Stopwatches
	{
		public static TimeSpan HandleStopwatch(string Action, Stopwatch timer)
		{
			TimeSpan span = new TimeSpan();
			switch (Action)
			{
				case "Stop":
					timer.Stop();
					break;
				case "Start":
					timer.Start();
					break;
				case "Reset":
					timer.Reset();
					break;
				case "Restart":
					timer.Restart();
					break;
				case "Elapsed":
					span = timer.Elapsed;
					return span;
			}
			return span;
		}

		public static int GetTimeFromType(string Type, TimeSpan span)
		{
			Type = HandleTimeUnits.SwitchUnits(Type);
			switch (Type)
			{
				case "ms":
					return (int)span.TotalMilliseconds;
				case "s":
					return (int)span.TotalSeconds;
				case "m":
					return (int)span.TotalMinutes;
				case "h":
					return (int)span.TotalHours;
				case "d":
					return (int)span.TotalDays;
				case "t":
					return (int)span.Ticks;
			}
			return 0;
		}
	}
}