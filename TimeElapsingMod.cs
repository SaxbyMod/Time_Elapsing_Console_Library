using BepInEx;
using BepInEx.Logging;
using TimeElapsingConsolePlugin.Util;
using System.Threading.Tasks;

namespace TimeElapsingConsolePlugin
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class TimeElapsingMod : BaseUnityPlugin
    {
        public const string PluginGuid = "creator.BepInEx.TimeElapsingMod";
        public const string PluginName = "Time Elapsing Mod";
        public const string PluginVersion = "1.0.0";

        // Define a Manual Log Source
        public static ManualLogSource Log = new ManualLogSource(PluginName);

        public void Awake()
        {
	        Log.LogMessage("Testing the TimeElapsingConsolePlugin.");
	        Init();
        }
        
        public static async Task Init()
        {
	        await Logging.AppendWait(() => HandleTimeUnits.isLoaded, "Handler for Conversions", "ms");
	        await Logging.AppendWait(() => Waiting.isLoaded, "Handler for Waiting", "t");
	        await Logging.AppendWait(() => Logging.isLoaded, "Handler for Logging", "s");
        }
    }
}