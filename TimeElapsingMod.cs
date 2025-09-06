using BepInEx;
using BepInEx.Logging;

namespace TimeElapsingConsolePlugin
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class TimeElapsingMod : BaseUnityPlugin
    {
        public const string PluginGuid = "creator.BepInEx.TimeElapsingMod";
        public const string PluginName = "Time Elapsing Mod";
        public const string PluginVersion = "1.1.0";

        // Define a Manual Log Source
        public static ManualLogSource Log = new ManualLogSource(PluginName);

        public void Awake()
        {
	        Logger.LogMessage("Setting Sail! Too lazy to readd the old tests plus they weren't needed so have this instead as proof its loaded.");
        }
    }
}