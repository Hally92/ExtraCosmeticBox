using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace ExtraCosmeticBoxMod
{
    [BepInPlugin("com.HalHally.extra_cosmeticbox", "Extra Cosmetic Box", "1.0.7")]
    [BepInDependency("REPOLib", BepInDependency.DependencyFlags.SoftDependency)]
    public class ExtraCosmeticBoxPlugin : BaseUnityPlugin
    {
        public static ConfigEntry<int> ExtraRolls;
        internal static new BepInEx.Logging.ManualLogSource Logger;

        private void Awake()
        {
            Logger = base.Logger;
            ExtraRolls = Config.Bind(
                "Cosmetic Box",
                "Additional Cosmetic Rolls",
                2,
                new ConfigDescription("Adds extra cosmetic box roll attempts.", new AcceptableValueRange<int>(0, 10))
            );
            var harmony = new Harmony("com.HalHally.extra_cosmeticbox");
            harmony.PatchAll();
            Logger.LogInfo("ExtraCosmeticBox patch applied.");
        }
    }

    [HarmonyPatch(typeof(ValuableDirector), "CosmeticWorldObjectLevelLoopsClampedGet")]
    public static class HalHally_ExtraCosmeticBox_LoopPatch
    {
        [HarmonyPostfix]
        static void Postfix(ref int __result)
        {
            __result += ExtraCosmeticBoxPlugin.ExtraRolls.Value;
            ExtraCosmeticBoxPlugin.Logger.LogInfo($"Added {ExtraCosmeticBoxPlugin.ExtraRolls.Value} extra cosmetic rolls.");
        }
    }
}
