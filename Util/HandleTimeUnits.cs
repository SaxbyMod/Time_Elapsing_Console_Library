namespace TimeElapsingConsolePlugin.Util
{
	public class HandleTimeUnits
	{
		public static bool isLoaded;
		public static string SwitchUnits(string Type)
		{
			switch (Type.ToLower())
			{
				case "millseconds":
					return "ms";
				case "seconds":
					return "s";
				case "minutes":
					return "m";
				case "hours":
					return "h";
				case "days":
					return "d";
				case "ticks":
					return "t";
			}
			isLoaded = true;
			return Type;
		}
	}
}