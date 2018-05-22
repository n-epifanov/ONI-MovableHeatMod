# ONI-MovableHeatMod
Mod for Oxygen not Included.
It sets Overheat Temperature to 1000 C for all Liquid and Gas pumps, Thermo Regulator and Thermo Aquatuner.
This allows to move heat at a wider range of temperatures.

If you have [EasySteamTurbineMod](https://github.com/nicktime/ONI-EasySteamTurbineMod) installed
you could also dump excess heat into Steam Turbine.

![Conditioner under Turbine](https://github.com/nicktime/ONI-MovableHeatMod/raw/master/doc/conditioner_under_turbine.png "Conditioner under Turbine")

You can enable and disable the mod without any problem: all affected buildings (built/planned/etc) will change their properties as expected.

Installation
------------
* Install ModLoader https://github.com/javisar/ONI-Modloader/#installation
* Put [MovableHeatMod.dll](https://github.com/nicktime/ONI-MovableHeatMod/releases/latest) into `Mods` dir

Removing
--------
Just remove `MovableHeatMod.dll` from `Mods` dir.

Building
--------
### Requirements
* .NET Framework 3.5
* Visual Studio 2017

### Guide
* Do the "Installation" part of https://github.com/javisar/ONI-Modloader
* Copy the following files from ONI's `OxygenNotIncluded_Data\Managed` folder to this mod's `\lib\`:
   * `Assembly-CSharp.dll`
   * `Assembly-CSharp-firstpass.dll`
   * `Assembly-UnityScript-firstpass.dll`
   * `UnityEngine.dll`
   * `UnityEngine.UI.dll`
* Build the solution (.dll will get copied to ONI `Mods` dir)
