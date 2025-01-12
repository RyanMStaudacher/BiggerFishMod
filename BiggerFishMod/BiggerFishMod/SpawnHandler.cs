using System.Collections.Generic;
using UnityEngine;
using HarmonyLib;

namespace BiggerFishMod
{
#if SUBNAUTICA
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    internal class SpawnHandler
    {
        public static List<GameObject> totalBiters = new List<GameObject>();
        public static List<GameObject> totalBladderFish = new List<GameObject>();
        public static List<GameObject> totalBleeders = new List<GameObject>();
        public static List<GameObject> totalBoneSharks = new List<GameObject>();
        public static List<GameObject> totalBoomerangs = new List<GameObject>();
        public static List<GameObject> totalCaveCrawlers = new List<GameObject>();
        public static List<GameObject> totalCrabSnakes = new List<GameObject>();
        public static List<GameObject> totalCrabSquids = new List<GameObject>();
        public static List<GameObject> totalCrashFish = new List<GameObject>();
        public static List<GameObject> totalCuddleFish = new List<GameObject>();
        public static List<GameObject> totalEyeyes = new List<GameObject>();
        public static List<GameObject> totalGarryFish = new List<GameObject>();
        public static List<GameObject> totalGasopods = new List<GameObject>();
        public static List<GameObject> totalVoidGhostLeviathans = new List<GameObject>();
        public static List<GameObject> totalGhostLeviathans = new List<GameObject>();
        public static List<GameObject> totalGhostRays = new List<GameObject>();
        public static List<GameObject> totalHoleFish = new List<GameObject>();
        public static List<GameObject> totalHoopFish = new List<GameObject>();
        public static List<GameObject> totalHoverFish = new List<GameObject>();
        public static List<GameObject> totalJellyRays = new List<GameObject>();
        public static List<GameObject> totalJumpers = new List<GameObject>();
        public static List<GameObject> totalLavaLarvas = new List<GameObject>();
        public static List<GameObject> totalLavaLizards = new List<GameObject>();
        public static List<GameObject> totalMesmers = new List<GameObject>();
        public static List<GameObject> totalOculusFish = new List<GameObject>();
        public static List<GameObject> totalPeepers = new List<GameObject>();
        public static List<GameObject> totalRabbitRays = new List<GameObject>();
        public static List<GameObject> totalReaperLeviathans = new List<GameObject>();
        public static List<GameObject> totalReefbacks = new List<GameObject>();
        public static List<GameObject> totalReginalds = new List<GameObject>();
        public static List<GameObject> totalSandSharks = new List<GameObject>();
        public static List<GameObject> totalSeaDragons = new List<GameObject>();
        public static List<GameObject> totalSeaEmporerBabies = new List<GameObject>();
        public static List<GameObject> totalSeaEmporerJuveniles = new List<GameObject>();
        public static List<GameObject> totalSeaTreaders = new List<GameObject>();
        public static List<GameObject> totalShockers = new List<GameObject>();
        public static List<GameObject> totalSpadeFish = new List<GameObject>();
        public static List<GameObject> totalSpineEels = new List<GameObject>();
        public static List<GameObject> totalStalkers = new List<GameObject>();
        public static List<GameObject> totalWarpers = new List<GameObject>();
        public static float maxBiters = 4;
        public static float maxBladderFish = 4;
        public static float maxBleeders = 4;
        public static float maxBoneSharks = 4;
        public static float maxBoomerangs = 4;
        public static float maxCaveCrawlers = 4;
        public static float maxCrabSnakes = 4;
        public static float maxCrabSquids = 4;
        public static float maxCrashFish = 4;
        public static float maxCuddleFish = 4;
        public static float maxEyeyes = 4;
        public static float maxGarryFish = 4;
        public static float maxGasopods = 4;
        public static float maxVoidGhostLeviathans = 4;
        public static float maxGhostLeviathans = 4;
        public static float maxGhostRays = 4;
        public static float maxHoleFish = 4;
        public static float maxHoopFish = 4;
        public static float maxHoverFish = 4;
        public static float maxJellyRays = 4;
        public static float maxJumpers = 4;
        public static float maxLavaLarvas = 4;
        public static float maxLavaLizards = 4;
        public static float maxMesmers = 4;
        public static float maxOculusFish = 4;
        public static float maxPeepers = 4;
        public static float maxRabbitRays = 4;
        public static float maxReaperLeviathans = 4;
        public static float maxReefbacks = 4;
        public static float maxReginalds = 4;
        public static float maxSandSharks = 4;
        public static float maxSeaDragons = 4;
        public static float maxSeaEmporerBabies = 4;
        public static float maxSeaEmporerJuveniles = 4;
        public static float maxSeaTreaders = 4;
        public static float maxShockers = 4;
        public static float maxSpadeFish = 4;
        public static float maxSpineEels = 4;
        public static float maxStalkers = 4;
        public static float maxWarpers = 4;

        [HarmonyPostfix]
        public static void OnEnablePostfix(Creature __instance)
        {
            if(MyModOptions.proportionalToggle.Value)
            {
                maxBiters = MyModOptions.proportionalCreatureLimit.Value;
                maxBladderFish = MyModOptions.proportionalCreatureLimit.Value;
                maxBleeders = MyModOptions.proportionalCreatureLimit.Value;
                maxBoneSharks = MyModOptions.proportionalCreatureLimit.Value;
                maxBoomerangs = MyModOptions.proportionalCreatureLimit.Value;
                maxCaveCrawlers = MyModOptions.proportionalCreatureLimit.Value;
                maxCrabSnakes = MyModOptions.proportionalCreatureLimit.Value;
                maxCrabSquids = MyModOptions.proportionalCreatureLimit.Value;
                maxCrashFish = MyModOptions.proportionalCreatureLimit.Value;
                maxCuddleFish = MyModOptions.proportionalCreatureLimit.Value;
                maxEyeyes = MyModOptions.proportionalCreatureLimit.Value;
                maxGarryFish = MyModOptions.proportionalCreatureLimit.Value;
                maxGasopods = MyModOptions.proportionalCreatureLimit.Value;
                maxVoidGhostLeviathans = MyModOptions.proportionalCreatureLimit.Value;
                maxGhostLeviathans = MyModOptions.proportionalCreatureLimit.Value;
                maxGhostRays = MyModOptions.proportionalCreatureLimit.Value;
                maxHoleFish = MyModOptions.proportionalCreatureLimit.Value;
                maxHoopFish = MyModOptions.proportionalCreatureLimit.Value;
                maxHoverFish = MyModOptions.proportionalCreatureLimit.Value;
                maxJellyRays = MyModOptions.proportionalCreatureLimit.Value;
                maxJumpers = MyModOptions.proportionalCreatureLimit.Value;
                maxLavaLarvas = MyModOptions.proportionalCreatureLimit.Value;
                maxLavaLizards = MyModOptions.proportionalCreatureLimit.Value;
                maxMesmers = MyModOptions.proportionalCreatureLimit.Value;
                maxOculusFish = MyModOptions.proportionalCreatureLimit.Value;
                maxPeepers = MyModOptions.proportionalCreatureLimit.Value;
                maxRabbitRays = MyModOptions.proportionalCreatureLimit.Value;
                maxReaperLeviathans = MyModOptions.proportionalCreatureLimit.Value;
                maxReefbacks = MyModOptions.proportionalCreatureLimit.Value;
                maxReginalds = MyModOptions.proportionalCreatureLimit.Value;
                maxSandSharks = MyModOptions.proportionalCreatureLimit.Value;
                maxSeaDragons = MyModOptions.proportionalCreatureLimit.Value;
                maxSeaEmporerBabies = MyModOptions.proportionalCreatureLimit.Value;
                maxSeaEmporerJuveniles = MyModOptions.proportionalCreatureLimit.Value;
                maxSeaTreaders = MyModOptions.proportionalCreatureLimit.Value;
                maxShockers = MyModOptions.proportionalCreatureLimit.Value;
                maxSpadeFish = MyModOptions.proportionalCreatureLimit.Value;
                maxSpineEels = MyModOptions.proportionalCreatureLimit.Value;
                maxStalkers = MyModOptions.proportionalCreatureLimit.Value;
                maxWarpers = MyModOptions.proportionalCreatureLimit.Value;
            }
            else
            {
                maxBiters = MyModOptions.biterLimit.Value;
                maxBladderFish = MyModOptions.bladderFishLimit.Value;
                maxBleeders = MyModOptions.bleederLimit.Value;
                maxBoneSharks = MyModOptions.boneSharkLimit.Value;
                maxBoomerangs = MyModOptions.boomerangLimit.Value;
                maxCaveCrawlers = MyModOptions.caveCrawlerLimit.Value;
                maxCrabSnakes = MyModOptions.crabSnakeLimit.Value;
                maxCrabSquids = MyModOptions.crabSquidLimit.Value;
                maxCrashFish = MyModOptions.crashFishLimit.Value;
                maxCuddleFish = MyModOptions.cuddleFishLimit.Value;
                maxEyeyes = MyModOptions.eyeyeLimit.Value;
                maxGarryFish = MyModOptions.garryFishLimit.Value;
                maxGasopods = MyModOptions.gasopodLimit.Value;
                maxVoidGhostLeviathans = MyModOptions.voidGhostLeviathanLimit.Value;
                maxGhostLeviathans = MyModOptions.ghostLeviathanLimit.Value;
                maxGhostRays = MyModOptions.ghostRayLimit.Value;
                maxHoleFish = MyModOptions.holeFishLimit.Value;
                maxHoopFish = MyModOptions.hoopFishLimit.Value;
                maxHoverFish = MyModOptions.hoverFishLimit.Value;
                maxJellyRays = MyModOptions.jellyRayLimit.Value;
                maxJumpers = MyModOptions.jumperLimit.Value;
                maxLavaLarvas = MyModOptions.lavaLarvaLimit.Value;
                maxLavaLizards = MyModOptions.lavaLizardLimit.Value;
                maxMesmers = MyModOptions.mesmerLimit.Value;
                maxOculusFish = MyModOptions.oculusFishLimit.Value;
                maxPeepers = MyModOptions.peeperLimit.Value;
                maxRabbitRays = MyModOptions.rabbitRayLimit.Value;
                maxReaperLeviathans = MyModOptions.reaperLeviathanLimit.Value;
                maxReefbacks = MyModOptions.reefbackLimit.Value;
                maxReginalds = MyModOptions.reginaldLimit.Value;
                maxSandSharks = MyModOptions.sandSharkLimit.Value;
                maxSeaDragons = MyModOptions.seaDragonLimit.Value;
                maxSeaEmporerBabies = MyModOptions.seaEmporerBabyLimit.Value;
                maxSeaEmporerJuveniles = MyModOptions.seaEmporerJuvenileLimit.Value;
                maxSeaTreaders = MyModOptions.seaTreaderLimit.Value;
                maxShockers = MyModOptions.shockerLimit.Value;
                maxSpadeFish = MyModOptions.spadeFishLimit.Value;
                maxSpineEels = MyModOptions.spineEelLimit.Value;
                maxStalkers = MyModOptions.stalkerLimit.Value;
                maxWarpers = MyModOptions.warperLimit.Value;
            }
        }
    }
#endif

#if SUBNAUTICAZERO
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    internal class SpawnHandler
    {
        public static List<GameObject> totalArcticPeepers = new List<GameObject>();
        public static List<GameObject> totalArrowRays = new List<GameObject>();
        public static List<GameObject> totalBoomerangs = new List<GameObject>();
        public static List<GameObject> totalBladderFish = new List<GameObject>();
        public static List<GameObject> totalHoopFish = new List<GameObject>();
        public static List<GameObject> totalDiscusFish = new List<GameObject>();
        public static List<GameObject> totalFeatherFish = new List<GameObject>();
        public static List<GameObject> totalNootFish = new List<GameObject>();
        //public static List<GameObject> totalSpineFish = new List<GameObject>(); Can't find reference to spine fish???
        public static List<GameObject> totalSpinnerFish = new List<GameObject>();
        public static List<GameObject> totalArcticRays = new List<GameObject>();
        public static List<GameObject> totalJellyfish = new List<GameObject>();
        public static List<GameObject> totalTitanHolefish = new List<GameObject>();
        public static List<GameObject> totalGlowWhales = new List<GameObject>();
        public static List<GameObject> totalPinnacarids = new List<GameObject>();
        public static List<GameObject> totalTriops = new List<GameObject>();
        public static List<GameObject> totalTrivalves = new List<GameObject>();
        public static List<GameObject> totalSymbioteFish = new List<GameObject>();
        public static List<GameObject> totalRockGrubs = new List<GameObject>();
        public static List<GameObject> totalCrashFish = new List<GameObject>();
        public static List<GameObject> totalBrineWings = new List<GameObject>();
        public static List<GameObject> totalLilyPaddlers = new List<GameObject>();
        public static List<GameObject> totalCryptosuchus = new List<GameObject>();
        public static List<GameObject> totalBruteSharks = new List<GameObject>();
        public static List<GameObject> totalSquidSharks = new List<GameObject>();
        public static List<GameObject> totalChelicerates = new List<GameObject>();
        public static List<GameObject> totalShadowLeviathans = new List<GameObject>();
        public static List<GameObject> totalVoidLeviathans = new List<GameObject>();
        public static List<GameObject> totalSkyRays = new List<GameObject>();
        public static List<GameObject> totalPenglings = new List<GameObject>();
        public static List<GameObject> totalPengwings = new List<GameObject>();
        public static List<GameObject> totalSeaMonkeyBabies = new List<GameObject>();
        public static List<GameObject> totalSeaMonkeys = new List<GameObject>();
        public static List<GameObject> totalSnowStalkerBabies = new List<GameObject>();
        public static List<GameObject> totalSnowStalkers = new List<GameObject>();
        public static List<GameObject> totalRockPunchers = new List<GameObject>();
        public static float maxArcticPeepers = 4;
        public static float maxArrowRays = 4;
        public static float maxBoomerangs = 4;
        public static float maxBladderFish = 4;
        public static float maxHoopFish = 4;
        public static float maxDiscusFish = 4;
        public static float maxFeatherFish = 4;
        public static float maxNootFish = 4;
        //public static float maxSpineFish = 4; Can't find reference to spine fish???
        public static float maxSpinnerFish = 4;
        public static float maxArcticRays = 4;
        public static float maxJellyFish = 4;
        public static float maxTitanHolefish = 4;
        public static float maxGlowWhales = 4;
        public static float maxPinnacarids = 4;
        public static float maxTriops = 4;
        public static float maxTrivalves = 4;
        public static float maxSymbioteFish = 4;
        public static float maxRockGrubs = 4;
        public static float maxCrashFish = 4;
        public static float maxBrineWings = 4;
        public static float maxLilyPaddlers = 4;
        public static float maxCryptosuchus = 4;
        public static float maxBruteSharks = 4;
        public static float maxSquidSharks = 4;
        public static float maxChelicerates = 4;
        public static float maxShadowLeviathans = 4;
        public static float maxVoidLeviathans = 4;
        public static float maxSkyRays = 4;
        public static float maxPenglings = 4;
        public static float maxPengwings = 4;
        public static float maxSeaMonkeyBabies = 4;
        public static float maxSeaMonkeys = 4;
        public static float maxSnowStalkerBabies = 4;
        public static float maxSnowStalkers = 4;
        public static float maxRockPunchers = 4;

        [HarmonyPostfix]
        public static void OnEnablePostfix(Creature __instance)
        {
            if (MyModOptions.proportionalToggle.Value)
            {
                maxArcticPeepers = MyModOptions.proportionalCreatureLimit.Value;
                maxArrowRays = MyModOptions.proportionalCreatureLimit.Value;
                maxBoomerangs = MyModOptions.proportionalCreatureLimit.Value;
                maxBladderFish = MyModOptions.proportionalCreatureLimit.Value;
                maxHoopFish = MyModOptions.proportionalCreatureLimit.Value;
                maxDiscusFish = MyModOptions.proportionalCreatureLimit.Value;
                maxFeatherFish = MyModOptions.proportionalCreatureLimit.Value;
                maxNootFish = MyModOptions.proportionalCreatureLimit.Value;
                maxSpinnerFish = MyModOptions.proportionalCreatureLimit.Value;
                maxArcticRays = MyModOptions.proportionalCreatureLimit.Value;
                maxJellyFish = MyModOptions.proportionalCreatureLimit.Value;
                maxTitanHolefish = MyModOptions.proportionalCreatureLimit.Value;
                maxGlowWhales = MyModOptions.proportionalCreatureLimit.Value;
                maxPinnacarids = MyModOptions.proportionalCreatureLimit.Value;
                maxTriops = MyModOptions.proportionalCreatureLimit.Value;
                maxTrivalves = MyModOptions.proportionalCreatureLimit.Value;
                maxSymbioteFish = MyModOptions.proportionalCreatureLimit.Value;
                maxRockGrubs = MyModOptions.proportionalCreatureLimit.Value;
                maxCrashFish = MyModOptions.proportionalCreatureLimit.Value;
                maxBrineWings = MyModOptions.proportionalCreatureLimit.Value;
                maxCryptosuchus = MyModOptions.proportionalCreatureLimit.Value;
                maxBruteSharks = MyModOptions.proportionalCreatureLimit.Value;
                maxSquidSharks = MyModOptions.proportionalCreatureLimit.Value;
                maxChelicerates = MyModOptions.proportionalCreatureLimit.Value;
                maxShadowLeviathans = MyModOptions.proportionalCreatureLimit.Value;
                maxVoidLeviathans = MyModOptions.proportionalCreatureLimit.Value;
                maxSkyRays = MyModOptions.proportionalCreatureLimit.Value;
                maxPenglings = MyModOptions.proportionalCreatureLimit.Value;
                maxPengwings = MyModOptions.proportionalCreatureLimit.Value;
                maxSeaMonkeyBabies = MyModOptions.proportionalCreatureLimit.Value;
                maxSeaMonkeys = MyModOptions.proportionalCreatureLimit.Value;
                maxSnowStalkerBabies = MyModOptions.proportionalCreatureLimit.Value;
                maxSnowStalkers = MyModOptions.proportionalCreatureLimit.Value;
                maxRockPunchers = MyModOptions.proportionalCreatureLimit.Value;
                maxLilyPaddlers = MyModOptions.proportionalCreatureLimit.Value;
            }
            else
            {
                maxArcticPeepers = MyModOptions.peeperLimit.Value;
                maxArrowRays = MyModOptions.arrowRayLimit.Value;
                maxBoomerangs = MyModOptions.boomerangLimit.Value;
                maxBladderFish = MyModOptions.bladderFishLimit.Value;
                maxHoopFish = MyModOptions.hoopFishLimit.Value;
                maxDiscusFish = MyModOptions.discusFishLimit.Value;
                maxFeatherFish = MyModOptions.featherFishLimit.Value;
                maxNootFish = MyModOptions.nootFishLimit.Value;
                maxSpinnerFish = MyModOptions.spinnerFishLimit.Value;
                maxArcticRays = MyModOptions.arcticRayLimit.Value;
                maxJellyFish = MyModOptions.jellyFishLimit.Value;
                maxTitanHolefish = MyModOptions.titanHoleFishLimit.Value;
                maxGlowWhales = MyModOptions.glowWhaleLimit.Value;
                maxPinnacarids = MyModOptions.pinnacaridLimit.Value;
                maxTriops = MyModOptions.triopsLimit.Value;
                maxTrivalves = MyModOptions.trivalveLimit.Value;
                maxSymbioteFish = MyModOptions.symbioteFishLimit.Value;
                maxRockGrubs = MyModOptions.rockGrubLimit.Value;
                maxCrashFish = MyModOptions.crashFishLimit.Value;
                maxBrineWings = MyModOptions.brineWingLimit.Value;
                maxCryptosuchus = MyModOptions.cryptosuchusLimit.Value;
                maxBruteSharks = MyModOptions.bruteSharkLimit.Value;
                maxSquidSharks = MyModOptions.squidSharkLimit.Value;
                maxChelicerates = MyModOptions.chelicerateLimit.Value;
                maxShadowLeviathans = MyModOptions.shadowLeviathanLimit.Value;
                maxVoidLeviathans = MyModOptions.voidLeviathanLimit.Value;
                maxSkyRays = MyModOptions.skyRayLimit.Value;
                maxPenglings = MyModOptions.penglingLimit.Value;
                maxPengwings = MyModOptions.pengwingLimit.Value;
                maxSeaMonkeyBabies = MyModOptions.seaMonkeyBabyLimit.Value;
                maxSeaMonkeys = MyModOptions.seaMonkeyLimit.Value;
                maxSnowStalkerBabies = MyModOptions.snowStalkerBabyLimit.Value;
                maxSnowStalkers = MyModOptions.snowStalkerLimit.Value;
                maxRockPunchers = MyModOptions.rockPuncherLimit.Value;
                maxLilyPaddlers = MyModOptions.lilyPaddlerLimit.Value;
            }
        }
    }
#endif
}
