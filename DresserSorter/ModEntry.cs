using HarmonyLib;
using StardewModdingAPI;
using StardewValley.Objects;

namespace DresserSorter
{
    internal sealed class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            SortingMethods.config = Helper.ReadConfig<ModConfig>();
            SortingMethods.monitor = Monitor;
            SortingMethods.modHelper = helper;
            var harmony = new Harmony(ModManifest.UniqueID);

            // this mod only patch one method for the sorting logic
            harmony.Patch(
                AccessTools.Method(typeof(StorageFurniture), nameof(StorageFurniture.SortItems)),
                prefix: new HarmonyMethod(typeof(SortingMethods), nameof(SortingMethods.SortOverride))
            );

            //Helper.Events.GameLoop.GameLaunched += GameLoop_GameLaunched;
        }


        /*
        private void GameLoop_GameLaunched(object? sender, StardewModdingAPI.Events.GameLaunchedEventArgs e)
        {
            // Support for Generic Mod Connfig Menu may be added in the future. or not.
        }
        */
    }
}