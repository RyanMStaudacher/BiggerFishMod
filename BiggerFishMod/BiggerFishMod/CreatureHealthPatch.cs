using HarmonyLib;

namespace BiggerFishMod
{
#if SUBNAUTICA
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    internal class CreatureHealthPatch
    {
        [HarmonyPostfix]
        public static void OnEnablePostfix(Creature __instance)
        {
            if (__instance is Biter biter)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    biter.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    biter.liveMixin.health *= MyModOptions.biterHealth.Value;
                }
            }

            if (__instance is Bladderfish bladderFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bladderFish.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    bladderFish.liveMixin.health *= MyModOptions.bladderFishHealth.Value;
                }
            }

            if (__instance is Bleeder bleeder)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bleeder.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    bleeder.liveMixin.health *= MyModOptions.bleederHealth.Value;
                }
            }

            if (__instance is BoneShark boneShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boneShark.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    boneShark.liveMixin.health *= MyModOptions.boneSharkHealth.Value;
                }
            }

            if (__instance is Boomerang boomerang)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boomerang.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    boomerang.liveMixin.health *= MyModOptions.boomerangHealth.Value;
                }
            }

            if (__instance is CaveCrawler caveCrawler)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    caveCrawler.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    caveCrawler.liveMixin.health *= MyModOptions.caveCrawlerHealth.Value;
                }
            }

            if (__instance is CrabSnake crabSnake)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crabSnake.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    crabSnake.liveMixin.health *= MyModOptions.crabSnakeHealth.Value;
                }
            }

            if (__instance is CrabSquid crabSquid)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crabSquid.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    crabSquid.liveMixin.health *= MyModOptions.crabSquidHealth.Value;
                }
            }

            if (__instance is Crash crashFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crashFish.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    crashFish.liveMixin.health *= MyModOptions.crashFishHealth.Value;
                }
            }

            if (__instance is CuteFish cuddleFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    cuddleFish.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    cuddleFish.liveMixin.health *= MyModOptions.cuddleFishHealth.Value;
                }
            }

            if (__instance is Eyeye eyeye)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    eyeye.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    eyeye.liveMixin.health *= MyModOptions.eyeyeHealth.Value;
                }
            }

            if (__instance is Garryfish garryFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    garryFish.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    garryFish.liveMixin.health *= MyModOptions.garryFishHealth.Value;
                }
            }

            if (__instance is GasoPod gasopod)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    gasopod.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    gasopod.liveMixin.health *= MyModOptions.gasopodHealth.Value;
                }
            }

            if (__instance is GhostLeviatanVoid voidGhostLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    voidGhostLeviathan.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    voidGhostLeviathan.liveMixin.health *= MyModOptions.voidGhostLeviathanHealth.Value;
                }
            }

            if (__instance is GhostLeviathan ghostLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    ghostLeviathan.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    ghostLeviathan.liveMixin.health *= MyModOptions.ghostLeviathanHealth.Value;
                }
            }

            if (__instance is GhostRay ghostRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    ghostRay.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    ghostRay.liveMixin.health *= MyModOptions.ghostRayHealth.Value;
                }
            }

            if (__instance is Holefish holeFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    holeFish.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    holeFish.liveMixin.health *= MyModOptions.holeFishHealth.Value;
                }
            }

            if (__instance is Hoopfish hoopFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoopFish.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    hoopFish.liveMixin.health *= MyModOptions.hoopFishHealth.Value;
                }
            }

            if (__instance is Hoverfish hoverFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoverFish.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    hoverFish.liveMixin.health *= MyModOptions.hoverFishHealth.Value;
                }
            }

            if (__instance is Jellyray jellyRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    jellyRay.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    jellyRay.liveMixin.health *= MyModOptions.jellyRayHealth.Value;
                }
            }

            if (__instance is Jumper jumper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    jumper.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    jumper.liveMixin.health *= MyModOptions.jumperHealth.Value;
                }
            }

            if (__instance is LavaLarva lavaLarva)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lavaLarva.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    lavaLarva.liveMixin.health *= MyModOptions.lavaLarvaHealth.Value;
                }
            }

            if (__instance is LavaLizard lavaLizard)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lavaLizard.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    lavaLizard.liveMixin.health *= MyModOptions.lavaLizardHealth.Value;
                }
            }

            if (__instance is Mesmer mesmer)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    mesmer.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    mesmer.liveMixin.health *= MyModOptions.mesmerHealth.Value;
                }
            }

            if (__instance is OculusFish oculus)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    oculus.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    oculus.liveMixin.health *= MyModOptions.oculusFishHealth.Value;
                }
            }

            if (__instance is Peeper peeper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    peeper.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    peeper.liveMixin.health *= MyModOptions.peeperHealth.Value;
                }
            }

            if (__instance is RabbitRay rabbitRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rabbitRay.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    rabbitRay.liveMixin.health *= MyModOptions.rabbitRayHealth.Value;
                }
            }

            if (__instance is ReaperLeviathan reaperLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    reaperLeviathan.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    reaperLeviathan.liveMixin.health *= MyModOptions.reaperLeviathanHealth.Value;
                }
            }

            if (__instance is Reefback reefback)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    reefback.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    reefback.liveMixin.health *= MyModOptions.reefbackHealth.Value;
                }
            }

            if (__instance is Reginald reginald)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    reginald.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    reginald.liveMixin.health *= MyModOptions.reginaldHealth.Value;
                }
            }

            if (__instance is SandShark sandShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sandShark.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    sandShark.liveMixin.health *= MyModOptions.sandSharkHealth.Value;
                }
            }

            if (__instance is SeaDragon seaDragon)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaDragon.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaDragon.liveMixin.health *= MyModOptions.seaDragonHealth.Value;
                }
            }

            if (__instance is SeaEmperorBaby seaEmporerBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaEmporerBaby.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaEmporerBaby.liveMixin.health *= MyModOptions.seaEmporerBabyHealth.Value;
                }
            }

            if (__instance is SeaEmperorJuvenile seaEmporerJuvenile)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaEmporerJuvenile.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaEmporerJuvenile.liveMixin.health *= MyModOptions.seaEmporerJuvenileHealth.Value;
                }
            }

            if (__instance is SeaTreader seaTreader)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaTreader.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaTreader.liveMixin.health *= MyModOptions.seaTreaderHealth.Value;
                }
            }

            if (__instance is Shocker shocker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    shocker.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    shocker.liveMixin.health *= MyModOptions.shockerHealth.Value;
                }
            }

            if (__instance is Spadefish spadeFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    spadeFish.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    spadeFish.liveMixin.health *= MyModOptions.spadeFishHealth.Value;
                }
            }

            if (__instance is SpineEel spineEel)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    spineEel.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    spineEel.liveMixin.health *= MyModOptions.spineEelHealth.Value;
                }
            }

            if (__instance is Stalker stalker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    stalker.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    stalker.liveMixin.health *= MyModOptions.stalkerHealth.Value;
                }
            }

            if (__instance is Warper warper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    warper.liveMixin.health *= MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    warper.liveMixin.health *= MyModOptions.biterHealth.Value;
                }
            }
        }
    }
#endif

#if SUBNAUTICAZERO
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    public class CreatureHealthPatch
    {
        [HarmonyPostfix]
        public static void OnEnableHealthPostfix(Creature __instance)
        {
            #region Passive Fish
            if (__instance is ArcticPeeper arcticPeeper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arcticPeeper.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    arcticPeeper.liveMixin.health = MyModOptions.peeperHealth.Value;
                }
            }

            if (__instance is ArrowRay arrowRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arrowRay.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    arrowRay.liveMixin.health = MyModOptions.arrowRayHealth.Value;
                }
            }

            if (__instance is Boomerang boomerang)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boomerang.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    boomerang.liveMixin.health = MyModOptions.boomerangHealth.Value;
                }
            }

            if (__instance is Bladderfish bladderFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bladderFish.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    bladderFish.liveMixin.health = MyModOptions.bladderFishHealth.Value;
                }
            }

            if (__instance is Hoopfish hoopFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoopFish.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    hoopFish.liveMixin.health = MyModOptions.hoopFishHealth.Value;
                }
            }

            if (__instance is DiscusFish discusFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    discusFish.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    discusFish.liveMixin.health = MyModOptions.discusFishHealth.Value;
                }
            }

            if (__instance is FeatherFish featherFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    featherFish.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    featherFish.liveMixin.health = MyModOptions.featherFishHealth.Value;
                }
            }

            if (__instance is NootFish nootFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    nootFish.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    nootFish.liveMixin.health = MyModOptions.nootFishHealth.Value;
                }
            }

            // Reference to spine fish not working atm.
            //if (__instance is SpineFish spineFish)
            //{
            //    float sizeScale = 4.0f;
            //    float locomotionScale = 4.0f;

            //    spineFish.SetScale(sizeScale);

            //    spineFish.GetComponent<Locomotion>().maxVelocity /= locomotionScale;
            //    spineFish.GetComponent<Locomotion>().maxAcceleration /= locomotionScale;
            //    spineFish.GetComponent<Locomotion>().forwardRotationSpeed /= locomotionScale;
            //    spineFish.GetComponent<Locomotion>().upRotationSpeed /= locomotionScale;
            //}

            if (__instance is SpinnerFish spinnerFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    spinnerFish.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    spinnerFish.liveMixin.health = MyModOptions.spinnerFishHealth.Value;
                }
            }

            if (__instance is ArcticRay arcticRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arcticRay.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    arcticRay.liveMixin.health = MyModOptions.arcticRayHealth.Value;
                }
            }

            if (__instance is Jellyfish eyeJelly)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    eyeJelly.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    eyeJelly.liveMixin.health = MyModOptions.jellyFishHealth.Value;
                }
            }

            if (__instance is TitanHolefish titanHolefish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    titanHolefish.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    titanHolefish.liveMixin.health = MyModOptions.titanHoleFishHealth.Value;
                }
            }

            if (__instance is GlowWhale glowWhale)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    glowWhale.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    glowWhale.liveMixin.health = MyModOptions.glowWhaleHealth.Value;
                }
            }

            if (__instance is Pinnacarid pinnacarid)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pinnacarid.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    pinnacarid.liveMixin.health = MyModOptions.pinnacaridHealth.Value;
                }
            }

            if (__instance is Triops triops)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    triops.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    triops.liveMixin.health = MyModOptions.triopsHealth.Value;
                }
            }

            if (__instance is Trivalve trivalve)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    trivalve.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    trivalve.liveMixin.health = MyModOptions.trivalveHealth.Value;
                }
            }

            if (__instance is SymbioteFish symbioteFish)
            {
                if(MyModOptions.proportionalToggle.Value == true)
                {
                    symbioteFish.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    symbioteFish.liveMixin.health = MyModOptions.symbioteFishHealth.Value;
                }
            }

            if (__instance is RockGrub rockGrub)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rockGrub.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    rockGrub.liveMixin.health = MyModOptions.rockGrubHealth.Value;
                }
            }
            #endregion

            #region Aggressive Fish
            if (__instance is Crash crashFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crashFish.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    crashFish.liveMixin.health = MyModOptions.crashFishHealth.Value;
                }
            }

            if (__instance is Brinewing brinewing)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    brinewing.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    brinewing.liveMixin.health = MyModOptions.brineWingHealth.Value;
                }
            }

            if (__instance is LilyPaddler lilyPaddler)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lilyPaddler.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    lilyPaddler.liveMixin.health = MyModOptions.lilyPaddlerHealth.Value;
                }
            }

            if (__instance is Cryptosuchus cryptosuchus)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    cryptosuchus.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    cryptosuchus.liveMixin.health = MyModOptions.cryptosuchusHealth.Value;
                }
            }

            if (__instance is BruteShark bruteShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bruteShark.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    bruteShark.liveMixin.health = MyModOptions.bruteSharkHealth.Value;
                }
            }

            if (__instance is SquidShark squidShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    squidShark.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    squidShark.liveMixin.health = MyModOptions.squidSharkHealth.Value;
                }
            }

            if (__instance is Chelicerate chelicerate)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    chelicerate.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    chelicerate.liveMixin.health = MyModOptions.chelicerateHealth.Value;
                }
            }

            if (__instance is ShadowLeviathan shadowLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    shadowLeviathan.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    shadowLeviathan.liveMixin.health = MyModOptions.shadowLeviathanHealth.Value;
                }
            }

            if (__instance is VoidLeviathan voidLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    voidLeviathan.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    voidLeviathan.liveMixin.health = MyModOptions.voidLeviathanHealth.Value;
                }
            }
            #endregion

            #region Not Fish
            if (__instance is Skyray skyray)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    skyray.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    skyray.liveMixin.health = MyModOptions.skyRayHealth.Value;
                }
            }

            if (__instance is PenguinBaby pengling)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pengling.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    pengling.liveMixin.health = MyModOptions.penglingHealth.Value;
                }
            }

            if (__instance is Penguin pengwing)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pengwing.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    pengwing.liveMixin.health = MyModOptions.pengwingHealth.Value;
                }
            }

            if (__instance is SeaMonkeyBaby seaMonkeyBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaMonkeyBaby.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaMonkeyBaby.liveMixin.health = MyModOptions.seaMonkeyBabyHealth.Value;
                }
            }

            if (__instance is SeaMonkey seaMonkey)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaMonkey.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaMonkey.liveMixin.health = MyModOptions.seaMonkeyHealth.Value;
                }
            }

            if (__instance is SnowStalkerBaby snowStalkerBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    snowStalkerBaby.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    snowStalkerBaby.liveMixin.health = MyModOptions.snowStalkerBabyHealth.Value;
                }
            }

            if (__instance is SnowStalker snowStalker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    snowStalker.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    snowStalker.liveMixin.health = MyModOptions.snowStalkerHealth.Value;
                }
            }

            if (__instance is RockPuncher rockPuncher)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rockPuncher.liveMixin.health = MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    rockPuncher.liveMixin.health = MyModOptions.rockPuncherHealth.Value;
                }
            }
            #endregion
        }
    }
#endif
}