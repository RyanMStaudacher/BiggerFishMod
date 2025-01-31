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
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.biterExclude.Value == false)
                {
                    biter.liveMixin.health = MyModOptions.biterBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    biter.liveMixin.health = MyModOptions.biterBaseHealth.Value * MyModOptions.biterHealth.Value;
                }
            }

            else if (__instance is Bladderfish bladderFish)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.bladderFishExclude.Value == false)
                {
                    bladderFish.liveMixin.health = MyModOptions.bladderFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    bladderFish.liveMixin.health = MyModOptions.bladderFishBaseHealth.Value * MyModOptions.bladderFishHealth.Value;
                }
            }

            else if (__instance is Bleeder bleeder)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.bleederExclude.Value == false)
                {
                    bleeder.liveMixin.health = MyModOptions.bleederBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    bleeder.liveMixin.health = MyModOptions.bleederBaseHealth.Value * MyModOptions.bleederHealth.Value;
                }
            }

            else if (__instance is BoneShark boneShark)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.boneSharkExclude.Value == false)
                {
                    boneShark.liveMixin.health = MyModOptions.boneSharkBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    boneShark.liveMixin.health = MyModOptions.boneSharkBaseHealth.Value * MyModOptions.boneSharkHealth.Value;
                }
            }

            else if (__instance is Boomerang boomerang)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.boomerangExclude.Value == false)
                {
                    boomerang.liveMixin.health = MyModOptions.boomerangBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    boomerang.liveMixin.health = MyModOptions.boomerangBaseHealth.Value * MyModOptions.boomerangHealth.Value;
                }
            }

            else if (__instance is CaveCrawler caveCrawler)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.caveCrawlerExclude.Value == false)
                {
                    caveCrawler.liveMixin.health = MyModOptions.caveCrawlerBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    caveCrawler.liveMixin.health = MyModOptions.caveCrawlerBaseHealth.Value * MyModOptions.caveCrawlerHealth.Value;
                }
            }

            else if (__instance is CrabSnake crabSnake)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.crabSnakeExclude.Value == false)
                {
                    crabSnake.liveMixin.health = MyModOptions.crabSnakeBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    crabSnake.liveMixin.health = MyModOptions.crabSnakeBaseHealth.Value * MyModOptions.crabSnakeHealth.Value;
                }
            }

            else if (__instance is CrabSquid crabSquid)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.crabSquidExclude.Value == false)
                {
                    crabSquid.liveMixin.health = MyModOptions.crabSquidBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    crabSquid.liveMixin.health = MyModOptions.crabSquidBaseHealth.Value * MyModOptions.crabSquidHealth.Value;
                }
            }

            else if (__instance is Crash crashFish)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.crashFishExclude.Value == false)
                {
                    crashFish.liveMixin.health = MyModOptions.crashFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    crashFish.liveMixin.health = MyModOptions.crashFishBaseHealth.Value * MyModOptions.crashFishHealth.Value;
                }
            }

            else if (__instance is CuteFish cuddleFish)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.cuddleFishExclude.Value == false)
                {
                    cuddleFish.liveMixin.health = MyModOptions.cuddleFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    cuddleFish.liveMixin.health = MyModOptions.cuddleFishBaseHealth.Value * MyModOptions.cuddleFishHealth.Value;
                }
            }

            else if (__instance is Eyeye eyeye)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.eyeyeExclude.Value == false)
                {
                    eyeye.liveMixin.health = MyModOptions.eyeyeBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    eyeye.liveMixin.health = MyModOptions.eyeyeBaseHealth.Value * MyModOptions.eyeyeHealth.Value;
                }
            }

            else if (__instance is Garryfish garryFish)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.garryFishExclude.Value == false)
                {
                    garryFish.liveMixin.health = MyModOptions.garryFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    garryFish.liveMixin.health = MyModOptions.garryFishBaseHealth.Value * MyModOptions.garryFishHealth.Value;
                }
            }

            else if (__instance is GasoPod gasopod)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.gasopodExclude.Value == false)
                {
                    gasopod.liveMixin.health = MyModOptions.gasopodBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    gasopod.liveMixin.health = MyModOptions.gasopodBaseHealth.Value * MyModOptions.gasopodHealth.Value;
                }
            }

            else if (__instance is GhostLeviatanVoid voidGhostLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.voidGhostLeviathanExclude.Value == false)
                {
                    voidGhostLeviathan.liveMixin.health = MyModOptions.voidGhostLeviathanBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    voidGhostLeviathan.liveMixin.health = MyModOptions.voidGhostLeviathanBaseHealth.Value * MyModOptions.voidGhostLeviathanHealth.Value;
                }
            }

            else if (__instance is GhostLeviathan ghostLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.ghostLeviathanExclude.Value == false)
                {
                    ghostLeviathan.liveMixin.health = MyModOptions.ghostLeviathanBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    ghostLeviathan.liveMixin.health = MyModOptions.ghostLeviathanBaseHealth.Value * MyModOptions.ghostLeviathanHealth.Value;
                }
            }

            else if (__instance is GhostRay ghostRay)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.ghostRayExclude.Value == false)
                {
                    ghostRay.liveMixin.health = MyModOptions.ghostRayBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    ghostRay.liveMixin.health = MyModOptions.ghostRayBaseHealth.Value * MyModOptions.ghostRayHealth.Value;
                }
            }

            else if (__instance is Holefish holeFish)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.holeFishExclude.Value == false)
                {
                    holeFish.liveMixin.health = MyModOptions.holeFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    holeFish.liveMixin.health = MyModOptions.holeFishBaseHealth.Value * MyModOptions.holeFishHealth.Value;
                }
            }

            else if (__instance is Hoopfish hoopFish)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.hoopFishExclude.Value == false)
                {
                    hoopFish.liveMixin.health = MyModOptions.hoopFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    hoopFish.liveMixin.health = MyModOptions.hoopFishBaseHealth.Value * MyModOptions.hoopFishHealth.Value;
                }
            }

            else if (__instance is Hoverfish hoverFish)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.hoverFishExclude.Value == false)
                {
                    hoverFish.liveMixin.health = MyModOptions.hoverFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    hoverFish.liveMixin.health = MyModOptions.hoverFishBaseHealth.Value * MyModOptions.hoverFishHealth.Value;
                }
            }

            else if (__instance is Jellyray jellyRay)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.jellyRayExclude.Value == false)
                {
                    jellyRay.liveMixin.health = MyModOptions.jellyRayBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    jellyRay.liveMixin.health = MyModOptions.jellyRayBaseHealth.Value * MyModOptions.jellyRayHealth.Value;
                }
            }

            else if (__instance is Jumper jumper)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.jumperExclude.Value == false)
                {
                    jumper.liveMixin.health = MyModOptions.jumperBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    jumper.liveMixin.health = MyModOptions.jumperBaseHealth.Value * MyModOptions.jumperHealth.Value;
                }
            }

            else if (__instance is LavaLarva lavaLarva)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.lavaLarvaExclude.Value == false)
                {
                    lavaLarva.liveMixin.health = MyModOptions.lavaLarvaBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    lavaLarva.liveMixin.health = MyModOptions.lavaLarvaBaseHealth.Value * MyModOptions.lavaLarvaHealth.Value;
                }
            }

            else if (__instance is LavaLizard lavaLizard)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.lavaLizardExclude.Value == false)
                {
                    lavaLizard.liveMixin.health = MyModOptions.lavaLizardBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    lavaLizard.liveMixin.health = MyModOptions.lavaLizardBaseHealth.Value * MyModOptions.lavaLizardHealth.Value;
                }
            }

            else if (__instance is Mesmer mesmer)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.mesmerExclude.Value == false)
                {
                    mesmer.liveMixin.health = MyModOptions.mesmerBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    mesmer.liveMixin.health = MyModOptions.mesmerBaseHealth.Value * MyModOptions.mesmerHealth.Value;
                }
            }

            else if (__instance is OculusFish oculusFish)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.oculusFishExclude.Value == false)
                {
                    oculusFish.liveMixin.health = MyModOptions.oculusFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    oculusFish.liveMixin.health = MyModOptions.oculusFishBaseHealth.Value * MyModOptions.oculusFishHealth.Value;
                }
            }

            else if (__instance is Peeper peeper)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.peeperExclude.Value == false)
                {
                    peeper.liveMixin.health = MyModOptions.peeperBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    peeper.liveMixin.health = MyModOptions.peeperBaseHealth.Value * MyModOptions.peeperHealth.Value;
                }
            }

            else if (__instance is RabbitRay rabbitRay)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.rabbitRayExclude.Value == false)
                {
                    rabbitRay.liveMixin.health = MyModOptions.rabbitRayBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    rabbitRay.liveMixin.health = MyModOptions.rabbitRayBaseHealth.Value * MyModOptions.rabbitRayHealth.Value;
                }
            }

            else if (__instance is ReaperLeviathan reaperLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.reaperLeviathanExclude.Value == false)
                {
                    reaperLeviathan.liveMixin.health = MyModOptions.reaperLeviathanBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    reaperLeviathan.liveMixin.health = MyModOptions.reaperLeviathanBaseHealth.Value * MyModOptions.reaperLeviathanHealth.Value;
                }
            }

            else if (__instance is Reefback reefback)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.reefbackExclude.Value == false)
                {
                    reefback.liveMixin.health = MyModOptions.reefbackBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    reefback.liveMixin.health = MyModOptions.reefbackBaseHealth.Value * MyModOptions.reefbackHealth.Value;
                }
            }

            else if (__instance is Reginald reginald)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.reginaldExclude.Value == false)
                {
                    reginald.liveMixin.health = MyModOptions.reginaldBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    reginald.liveMixin.health = MyModOptions.reginaldBaseHealth.Value * MyModOptions.reginaldHealth.Value;
                }
            }

            //else if (__instance is RockGrub rockGrub)
            //{
            //    if (MyModOptions.proportionalToggle.Value == true && MyModOptions.rockGrubExclude.Value == false)
            //    {
            //        rockGrub.liveMixin.health = MyModOptions.rockGrubBaseHealth.Value * MyModOptions.proportionalHealth.Value;
            //    }
            //    else
            //    {
            //        rockGrub.liveMixin.health = MyModOptions.rockGrubBaseHealth.Value * MyModOptions.rockGrubHealth.Value;
            //    }
            //}

            else if (__instance is SandShark sandShark)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.sandSharkExclude.Value == false)
                {
                    sandShark.liveMixin.health = MyModOptions.sandSharkBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    sandShark.liveMixin.health = MyModOptions.sandSharkBaseHealth.Value * MyModOptions.sandSharkHealth.Value;
                }
            }

            else if (__instance is SeaDragon seaDragon)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.seaDragonExclude.Value == false)
                {
                    seaDragon.liveMixin.health = MyModOptions.seaDragonBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaDragon.liveMixin.health = MyModOptions.seaDragonBaseHealth.Value * MyModOptions.seaDragonHealth.Value;
                }
            }

            else if (__instance is SeaEmperorBaby seaEmperorBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.seaEmperorBabyExclude.Value == false)
                {
                    seaEmperorBaby.liveMixin.health = MyModOptions.seaEmperorBabyBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaEmperorBaby.liveMixin.health = MyModOptions.seaEmperorBabyBaseHealth.Value * MyModOptions.seaEmperorBabyHealth.Value;
                }
            }

            else if (__instance is SeaEmperorJuvenile seaEmperorJuvenile)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.seaEmperorJuvenileExclude.Value == false)
                {
                    seaEmperorJuvenile.liveMixin.health = MyModOptions.seaEmperorJuvenileBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaEmperorJuvenile.liveMixin.health = MyModOptions.seaEmperorJuvenileBaseHealth.Value * MyModOptions.seaEmperorJuvenileHealth.Value;
                }
            }

            else if (__instance is SeaTreader seaTreader)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.seaTreaderExclude.Value == false)
                {
                    seaTreader.liveMixin.health = MyModOptions.seaTreaderBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaTreader.liveMixin.health = MyModOptions.seaTreaderBaseHealth.Value * MyModOptions.seaTreaderHealth.Value;
                }
            }

            else if (__instance is Shocker shocker)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.shockerExclude.Value == false)
                {
                    shocker.liveMixin.health = MyModOptions.shockerBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    shocker.liveMixin.health = MyModOptions.shockerBaseHealth.Value * MyModOptions.shockerHealth.Value;
                }
            }

            else if (__instance is Skyray skyRay)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.skyRayExclude.Value == false)
                {
                    skyRay.liveMixin.health = MyModOptions.skyRayBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    skyRay.liveMixin.health = MyModOptions.skyRayBaseHealth.Value * MyModOptions.skyRayHealth.Value;
                }
            }

            else if (__instance is Spadefish spadeFish)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.spadeFishExclude.Value == false)
                {
                    spadeFish.liveMixin.health = MyModOptions.spadeFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    spadeFish.liveMixin.health = MyModOptions.spadeFishBaseHealth.Value * MyModOptions.spadeFishHealth.Value;
                }
            }

            else if (__instance is SpineEel spineEel)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.spineEelExclude.Value == false)
                {
                    spineEel.liveMixin.health = MyModOptions.spineEelBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    spineEel.liveMixin.health = MyModOptions.spineEelBaseHealth.Value * MyModOptions.spineEelHealth.Value;
                }
            }

            else if (__instance is Stalker stalker)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.stalkerExclude.Value == false)
                {
                    stalker.liveMixin.health = MyModOptions.stalkerBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    stalker.liveMixin.health = MyModOptions.stalkerBaseHealth.Value * MyModOptions.stalkerHealth.Value;
                }
            }

            else if (__instance is Warper warper)
            {
                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.warperExclude.Value == false)
                {
                    warper.liveMixin.health = MyModOptions.warperBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    warper.liveMixin.health = MyModOptions.warperBaseHealth.Value * MyModOptions.warperHealth.Value;
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
                    arcticPeeper.liveMixin.health = MyModOptions.arcticPeeperBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    arcticPeeper.liveMixin.health = MyModOptions.arcticPeeperBaseHealth.Value * MyModOptions.arcticPeeperHealth.Value;
                }
            }

            else if (__instance is ArrowRay arrowRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arrowRay.liveMixin.health = MyModOptions.arrowRayBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    arrowRay.liveMixin.health = MyModOptions.arrowRayBaseHealth.Value * MyModOptions.arrowRayHealth.Value;
                }
            }

            else if (__instance is Boomerang boomerang)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boomerang.liveMixin.health = MyModOptions.boomerangBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    boomerang.liveMixin.health = MyModOptions.boomerangBaseHealth.Value * MyModOptions.boomerangHealth.Value;
                }
            }

            else if (__instance is Bladderfish bladderFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bladderFish.liveMixin.health = MyModOptions.bladderFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    bladderFish.liveMixin.health = MyModOptions.bladderFishBaseHealth.Value * MyModOptions.bladderFishHealth.Value;
                }
            }

            else if (__instance is Hoopfish hoopFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoopFish.liveMixin.health = MyModOptions.hoopFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    hoopFish.liveMixin.health = MyModOptions.hoopFishBaseHealth.Value * MyModOptions.hoopFishHealth.Value;
                }
            }

            else if (__instance is DiscusFish discusFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    discusFish.liveMixin.health = MyModOptions.discusFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    discusFish.liveMixin.health = MyModOptions.discusFishBaseHealth.Value * MyModOptions.discusFishHealth.Value;
                }
            }

            else if (__instance is FeatherFish featherFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    featherFish.liveMixin.health = MyModOptions.featherFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    featherFish.liveMixin.health = MyModOptions.featherFishBaseHealth.Value * MyModOptions.featherFishHealth.Value;
                }
            }

            else if (__instance is NootFish nootFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    nootFish.liveMixin.health = MyModOptions.nootFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    nootFish.liveMixin.health = MyModOptions.nootFishBaseHealth.Value * MyModOptions.nootFishHealth.Value;
                }
            }

            else if (__instance is SpinnerFish spinnerFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    spinnerFish.liveMixin.health = MyModOptions.spinnerFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    spinnerFish.liveMixin.health = MyModOptions.spinnerFishBaseHealth.Value * MyModOptions.spinnerFishHealth.Value;
                }
            }

            else if (__instance is ArcticRay arcticRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arcticRay.liveMixin.health = MyModOptions.arcticRayBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    arcticRay.liveMixin.health = MyModOptions.arcticRayBaseHealth.Value * MyModOptions.arcticRayHealth.Value;
                }
            }

            else if (__instance is Jellyfish jellyFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    jellyFish.liveMixin.health = MyModOptions.jellyFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    jellyFish.liveMixin.health = MyModOptions.jellyFishBaseHealth.Value * MyModOptions.jellyFishHealth.Value;
                }
            }

            else if (__instance is TitanHolefish titanHoleFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    titanHoleFish.liveMixin.health = MyModOptions.titanHoleFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    titanHoleFish.liveMixin.health = MyModOptions.titanHoleFishBaseHealth.Value * MyModOptions.titanHoleFishHealth.Value;
                }
            }

            else if (__instance is GlowWhale glowWhale)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    glowWhale.liveMixin.health = MyModOptions.glowWhaleBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    glowWhale.liveMixin.health = MyModOptions.glowWhaleBaseHealth.Value * MyModOptions.glowWhaleHealth.Value;
                }
            }

            else if (__instance is Pinnacarid pinnacarid)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pinnacarid.liveMixin.health = MyModOptions.pinnacaridBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    pinnacarid.liveMixin.health = MyModOptions.pinnacaridBaseHealth.Value * MyModOptions.pinnacaridHealth.Value;
                }
            }

            else if (__instance is Triops triops)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    triops.liveMixin.health = MyModOptions.triopsBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    triops.liveMixin.health = MyModOptions.triopsBaseHealth.Value * MyModOptions.triopsHealth.Value;
                }
            }

            else if (__instance is Trivalve trivalve)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    trivalve.liveMixin.health = MyModOptions.trivalveBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    trivalve.liveMixin.health = MyModOptions.trivalveBaseHealth.Value * MyModOptions.trivalveHealth.Value;
                }
            }

            else if (__instance is SymbioteFish symbioteFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    symbioteFish.liveMixin.health = MyModOptions.symbioteFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    symbioteFish.liveMixin.health = MyModOptions.symbioteFishBaseHealth.Value * MyModOptions.symbioteFishHealth.Value;
                }
            }

            else if (__instance is RockGrub rockGrub)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rockGrub.liveMixin.health = MyModOptions.rockGrubBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    rockGrub.liveMixin.health = MyModOptions.rockGrubBaseHealth.Value * MyModOptions.rockGrubHealth.Value;
                }
            }
            #endregion

            #region Aggressive Fish
            else if (__instance is Crash crashFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crashFish.liveMixin.health = MyModOptions.crashFishBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    crashFish.liveMixin.health = MyModOptions.crashFishBaseHealth.Value * MyModOptions.crashFishHealth.Value;
                }
            }

            else if (__instance is Brinewing brineWing)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    brineWing.liveMixin.health = MyModOptions.brineWingBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    brineWing.liveMixin.health = MyModOptions.brineWingBaseHealth.Value * MyModOptions.brineWingHealth.Value;
                }
            }

            else if (__instance is LilyPaddler lilyPaddler)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lilyPaddler.liveMixin.health = MyModOptions.lilyPaddlerBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    lilyPaddler.liveMixin.health = MyModOptions.lilyPaddlerBaseHealth.Value * MyModOptions.lilyPaddlerHealth.Value;
                }
            }

            else if (__instance is Cryptosuchus cryptosuchus)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    cryptosuchus.liveMixin.health = MyModOptions.cryptosuchusBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    cryptosuchus.liveMixin.health = MyModOptions.cryptosuchusBaseHealth.Value * MyModOptions.cryptosuchusHealth.Value;
                }
            }

            else if (__instance is BruteShark bruteShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bruteShark.liveMixin.health = MyModOptions.bruteSharkBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    bruteShark.liveMixin.health = MyModOptions.bruteSharkBaseHealth.Value * MyModOptions.bruteSharkHealth.Value;
                }
            }

            else if (__instance is SquidShark squidShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    squidShark.liveMixin.health = MyModOptions.squidSharkBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    squidShark.liveMixin.health = MyModOptions.squidSharkBaseHealth.Value * MyModOptions.squidSharkHealth.Value;
                }
            }

            else if (__instance is Chelicerate chelicerate)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    chelicerate.liveMixin.health = MyModOptions.chelicerateBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    chelicerate.liveMixin.health = MyModOptions.chelicerateBaseHealth.Value * MyModOptions.chelicerateHealth.Value;
                }
            }

            else if (__instance is ShadowLeviathan shadowLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    shadowLeviathan.liveMixin.health = MyModOptions.shadowLeviathanBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    shadowLeviathan.liveMixin.health = MyModOptions.shadowLeviathanBaseHealth.Value * MyModOptions.shadowLeviathanHealth.Value;
                }
            }

            else if (__instance is VoidLeviathan voidLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    voidLeviathan.liveMixin.health = MyModOptions.voidLeviathanBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    voidLeviathan.liveMixin.health = MyModOptions.voidLeviathanBaseHealth.Value * MyModOptions.voidLeviathanHealth.Value;
                }
            }
            #endregion

            #region Not Fish
            else if (__instance is Skyray skyRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    skyRay.liveMixin.health = MyModOptions.skyRayBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    skyRay.liveMixin.health = MyModOptions.skyRayBaseHealth.Value * MyModOptions.skyRayHealth.Value;
                }
            }

            else if (__instance is PenguinBaby pengling)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pengling.liveMixin.health = MyModOptions.penglingBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    pengling.liveMixin.health = MyModOptions.penglingBaseHealth.Value * MyModOptions.penglingHealth.Value;
                }
            }

            else if (__instance is Penguin pengwing)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pengwing.liveMixin.health = MyModOptions.pengwingBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    pengwing.liveMixin.health = MyModOptions.pengwingBaseHealth.Value * MyModOptions.pengwingHealth.Value;
                }
            }

            else if (__instance is SeaMonkeyBaby seaMonkeyBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaMonkeyBaby.liveMixin.health = MyModOptions.seaMonkeyBabyBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaMonkeyBaby.liveMixin.health = MyModOptions.seaMonkeyBabyBaseHealth.Value * MyModOptions.seaMonkeyBabyHealth.Value;
                }
            }

            else if (__instance is SeaMonkey seaMonkey)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaMonkey.liveMixin.health = MyModOptions.seaMonkeyBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    seaMonkey.liveMixin.health = MyModOptions.seaMonkeyBaseHealth.Value * MyModOptions.seaMonkeyHealth.Value;
                }
            }

            else if (__instance is SnowStalkerBaby snowStalkerBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    snowStalkerBaby.liveMixin.health = MyModOptions.snowStalkerBabyBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    snowStalkerBaby.liveMixin.health = MyModOptions.snowStalkerBabyBaseHealth.Value * MyModOptions.snowStalkerBabyHealth.Value;
                }
            }

            else if (__instance is SnowStalker snowStalker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    snowStalker.liveMixin.health = MyModOptions.snowStalkerBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    snowStalker.liveMixin.health = MyModOptions.snowStalkerBaseHealth.Value * MyModOptions.snowStalkerHealth.Value;
                }
            }

            else if (__instance is RockPuncher rockPuncher)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rockPuncher.liveMixin.health = MyModOptions.rockPuncherBaseHealth.Value * MyModOptions.proportionalHealth.Value;
                }
                else
                {
                    rockPuncher.liveMixin.health = MyModOptions.rockPuncherBaseHealth.Value * MyModOptions.rockPuncherHealth.Value;
                }
            }
            #endregion
        }
    }
#endif
}