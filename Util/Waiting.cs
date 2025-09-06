using System;
using System.Threading.Tasks;

namespace TimeElapsingConsolePlugin.Util
{
	public class Waiting
	{
		public static bool isLoaded;
		public static async Task WaitType(int X, string Type)
		{
			Type = HandleTimeUnits.SwitchUnits(Type);
			switch (Type)
			{
				case "ms":
					WaitMilliseconds(X);
					isLoaded = true;
					break;
				case "s":
					WaitSeconds(X);
					isLoaded = true;
					break;
				case "m":
					WaitMinutes(X);
					isLoaded = true;
					break;
				case "h":
					WaitHours(X);
					isLoaded = true;
					break;
				case "d":
					WaitDays(X);
					isLoaded = true;
					break;
				case "t":
					WaitTicks(X);
					isLoaded = true;
					break;
			}
		}

		public static async Task WaitMilliseconds(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromMilliseconds(waitingTime);
			await Task.Delay(wait);
		}
		public static async Task WaitSeconds(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromSeconds(waitingTime);
			await Task.Delay(wait);
		}
		public static async Task WaitMinutes(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromMinutes(waitingTime);
			await Task.Delay(wait);
		}
		public static async Task WaitHours(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromHours(waitingTime);
			await Task.Delay(wait);
		}
		public static async Task WaitDays(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromDays(waitingTime);
			await Task.Delay(wait);
		}
		public static async Task WaitTicks(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromTicks(waitingTime);
			await Task.Delay(wait);
		}
		
		public static void MarkLoaded()
		{
			isLoaded = true;
		}
	}
}