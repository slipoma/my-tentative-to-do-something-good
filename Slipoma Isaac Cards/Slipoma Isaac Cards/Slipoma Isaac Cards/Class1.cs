using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using SlipomaIsaacCards.Cards;


namespace SlipomaIsaacCards

{
    [BepInDependency("com.willis.rounds.unbound",BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.modding.utils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]

    [BepInPlugin(ModId, ModName, Version)]

    [BepInProcess("Rounds.exe")]
    public class SlipomaIsaacCards : BaseUnityPlugin
    
    {
 private const string ModId = "com.slipoma.rounds.SlipomaIsaacCards";
    private const string ModName = "SlipomaIsaacCards";
    private const string Version = "0.0.1";
    public const string ModInitials = "SIC";

        public static SlipomaIsaacCards instance { get; private set; }

        void Awake()
    { 
            var harmony = new Harmony(ModId);
        harmony.PatchAll();
    }
    void Start()
    {
            instance = this;
            CustomCard.BuildCard<EvasiveManeuvers>();
        }
  }
}
    