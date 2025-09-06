using System.Threading.Tasks;
using AnsiConsolePlugin.Util;
using System;

namespace TimeElapsingConsolePlugin.Util
{
	public class Logging
	{
		public static bool isLoaded;
		public static async Task AppendWait(Func<bool> refClass, string WhatDoWeAwait, string Type)
		{
			isLoaded = false;
			Console.Write("");
			int AwaitedTime = 0;
			Type = HandleTimeUnits.SwitchUnits(Type);
			while (!refClass()) // Make it so this will see if the Class is loaded or not, the class being the one passed in.
			{
				await Waiting.WaitType(1, Type);
				LogMessage(AwaitedTime, WhatDoWeAwait, Type);
				AwaitedTime++;
			}
			Console.Write("\r" + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityBold") + "Finished loading " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityUnderlined") + WhatDoWeAwait.ToLower() + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityBold") + " time taken to load: " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityUnderlined") + AwaitedTime + Type + ANSICodeLists.ResetColor + "   ");
		}
		
		public static void LogMessage(int Time, string WhatDoWeAwait, string Type)
		{
			Type = HandleTimeUnits.SwitchUnits(Type);
			int Col = Console.CursorLeft;
			int Row = Console.CursorTop;
			Console.Write("\r" + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityBold") + "Awaiting time for " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityUnderlined") + WhatDoWeAwait.ToLower() + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityBold") + " time spent waiting: " + ANSICodeLists.ResetColor + GetColorFromTypeFunctions.GetColorFromString("Yellow", "HighIntensityUnderlined") + Time + Type + ANSICodeLists.ResetColor + "   ");
			Console.SetCursorPosition(Col, Row);
			MarkLoaded();
		}
		
		public static void MarkLoaded()
		{
			isLoaded = true;
		}
	}
}