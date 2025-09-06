# Time Elapsing Console Plugin

This mod essentially enables the ability show Elapsed Time in a nice way within BepInEx.

## Functions;

This mod Includes 3 Nifty functions for fetching a ANSI Code Color.

* WaitType; This function waits for a set amount of time determined by an Integer, and a string which associates with a value.
* AppendWait: Logs the elapsed time spent loading whatever needed to be loaded, it takes a Func<bool> to handle when to stop, a Integer for the time, a String for the type, and lastly a String for what is being waited for.
* SwitchToUnits: Takes a time Unit and converts it into a simplified string.

## Defining The Function Variables;

This is what Type is defined at in all 3 functions:

|     Unit      | Simplified |  Elongated  |
|:-------------:|:----------:|:-----------:|
| Milli-seconds |     ms     | millisecond |
|    Seconds    |     s      |   second    |
|    Minutes    |     m      |   minute    |
|     Hours     |     h      |    hour     |
|     Days      |     d      |     day     |
|     Ticks     |     t      |    ticks    |

## Maintaining and or Updating/Porting:

Send a PR to the repository if you would like to update the mod in any way shape or form.

Porting is allowed as long as proper and full credits are instated and the provided License is KEPT.

If you would like this mod/lib added into your community shoot me a message over on Discord at `@thincreator3483`

Also while im at it, if anything here is inaccurate and or needs changes lemme know ^^

## Credits:

As of 1.0.0

* Creator - All of the Plugins code, as well as everything else associated with the mod.