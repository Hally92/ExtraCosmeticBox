using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using Photon.Pun;

namespace ExtraCosmeticBoxMod
{
    [BepInPlugin("com.HalHally.extra_cosmeticbox", "Extra Cosmetic Box", "1.1.0")]
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

    [HarmonyPatch(typeof(CosmeticWorldObject), "ExtractRPC")]
    public static class HalHally_ExtraCosmeticBox_ExtractRPCPatch
    {
        [HarmonyPrefix]
        static void Prefix(CosmeticWorldObject __instance)
        {
            if (PhotonNetwork.IsConnected && !PhotonNetwork.IsMasterClient)
            {
                Traverse.Create(__instance).Field("inExtraction").SetValue(true);
            }
        }
    }
}
