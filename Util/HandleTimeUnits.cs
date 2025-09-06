namespace TimeElapsingConsolePlugin.Util
{
	public class HandleTimeUnits
	{
		public static string SwitchUnits(string Type)
		{
			switch (Type.ToLower())
			{
				case "milliseconds":
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
			return Type;
		}
	}
}