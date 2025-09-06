using System;
using System.Threading.Tasks;

namespace TimeElapsingConsolePlugin.Util
{
	[Obsolete]
	public class Waiting
	{
		[Obsolete]
		public static async Task WaitType(int X, string Type)
		{
			Type = HandleTimeUnits.SwitchUnits(Type);
			switch (Type)
			{
				case "ms":
					await WaitMilliseconds(X);
					break;
				case "s":
					await WaitSeconds(X);
					break;
				case "m":
					await WaitMinutes(X);
					break;
				case "h":
					await WaitHours(X);
					break;
				case "d":
					await WaitDays(X);
					break;
				case "t":
					await WaitTicks(X);
					break;
			}
		}
		
		[Obsolete]
		public static void WaitTypeSync(int X, string Type)
		{
			Type = HandleTimeUnits.SwitchUnits(Type);
			switch (Type)
			{
				case "ms":
					System.Threading.Thread.Sleep(X);
					break;
				case "s":
					System.Threading.Thread.Sleep(X * 1000);
					break;
				case "m":
					System.Threading.Thread.Sleep(X * 60 * 1000);
					break;
				case "h":
					System.Threading.Thread.Sleep(X * 60 * 60 * 1000);
					break;
				case "d":
					System.Threading.Thread.Sleep(X * 24 * 60 * 60 * 1000);
					break;
				case "t":
					System.Threading.Thread.Sleep((int)(X / TimeSpan.TicksPerMillisecond));
					break;
			}
		}

		[Obsolete]
		public static async Task WaitMilliseconds(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromMilliseconds(waitingTime);
			await Task.Delay(wait);
		}
		[Obsolete]
		public static async Task WaitSeconds(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromSeconds(waitingTime);
			await Task.Delay(wait);
		}
		[Obsolete]
		public static async Task WaitMinutes(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromMinutes(waitingTime);
			await Task.Delay(wait);
		}
		[Obsolete]
		public static async Task WaitHours(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromHours(waitingTime);
			await Task.Delay(wait);
		}
		[Obsolete]
		public static async Task WaitDays(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromDays(waitingTime);
			await Task.Delay(wait);
		}
		[Obsolete]
		public static async Task WaitTicks(int waitingTime)
		{
			TimeSpan wait = TimeSpan.FromTicks(waitingTime);
			await Task.Delay(wait);
		}
	}
}