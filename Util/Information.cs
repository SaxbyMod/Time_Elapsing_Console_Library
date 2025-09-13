using System.Diagnostics;
using System.Threading;

namespace TimeElapsingConsolePlugin.Util
{
	public class Information
	{
		public CancellationTokenSource Run { get; set; }
		public string WhatDoWeAwait { get; set; }
		public string Type { get; set; }
		public string ModName { get; set; }
		public readonly Stopwatch watch;

		public Information(string whatDoWeAwait, string type, string modName)
		{
			Run = new CancellationTokenSource();
			WhatDoWeAwait = whatDoWeAwait;
			Type = HandleTimeUnits.SwitchUnits(type);
			ModName = modName;
			watch = new Stopwatch();
			Stopwatches.HandleStopwatch("Start", watch);
		}
	}
}