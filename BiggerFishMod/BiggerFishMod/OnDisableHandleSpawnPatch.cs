using HarmonyLib;

namespace BiggerFishMod
{
#if SUBNAUTICA
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnDisable))]
    internal class OnDisableHandleSpawnPatch
    {
        [HarmonyPostfix]
        public static void OnDisablePostfix(Creature __instance)
        {
            if (__instance is Biter biter)
            {
                SpawnHandler.totalBiters.Remove(biter.gameObject);
            }

            else if (__instance is Bladderfish bladderFish)
            {
                SpawnHandler.totalBladderFish.Remove(bladderFish.gameObject);
            }

            else if (__instance is Bleeder bleeder)
            {
                SpawnHandler.totalBleeders.Remove(bleeder.gameObject);
            }

            else if (__instance is BoneShark boneShark)
            {
                SpawnHandler.totalBoneSharks.Remove(boneShark.gameObject);
            }

            else if (__instance is Boomerang boomerang)
            {
                SpawnHandler.totalBoomerangs.Remove(boomerang.gameObject);
            }

            else if (__instance is CaveCrawler caveCrawler)
            {
                SpawnHandler.totalCaveCrawlers.Remove(caveCrawler.gameObject);
            }

            else if (__instance is CrabSnake crabSnake)
            {
                SpawnHandler.totalCrabSnakes.Remove(crabSnake.gameObject);
            }

            else if (__instance is CrabSquid crabSquid)
            {
                SpawnHandler.totalCrabSquids.Remove(crabSquid.gameObject);
            }

            else if (__instance is Crash crashFish)
            {
                SpawnHandler.totalCrashFish.Remove(crashFish.gameObject);
            }

            else if (__instance is CuteFish cuddleFish)
            {
                SpawnHandler.totalCuddleFish.Remove(cuddleFish.gameObject);
            }

            else if (__instance is Eyeye eyeye)
            {
                SpawnHandler.totalEyeyes.Remove(eyeye.gameObject);
            }

            else if (__instance is Garryfish garryFish)
            {
                SpawnHandler.totalGarryFish.Remove(garryFish.gameObject);
            }

            else if (__instance is GasoPod gasopod)
            {
                SpawnHandler.totalGasopods.Remove(gasopod.gameObject);
            }

            else if (__instance is GhostLeviatanVoid voidGhostLeviathan)
            {
                SpawnHandler.totalVoidGhostLeviathans.Remove(voidGhostLeviathan.gameObject);
            }

            else if (__instance is GhostLeviathan ghostLeviathan)
            {
                SpawnHandler.totalGhostLeviathans.Remove(ghostLeviathan.gameObject);
            }

            else if (__instance is GhostRay ghostRay)
            {
                SpawnHandler.totalGhostRays.Remove(ghostRay.gameObject);
            }

            else if (__instance is Holefish holeFish)
            {
                SpawnHandler.totalHoleFish.Remove(holeFish.gameObject);
            }

            else if (__instance is Hoopfish hoopFish)
            {
                SpawnHandler.totalHoopFish.Remove(hoopFish.gameObject);
            }

            else if (__instance is Hoverfish hoverFish)
            {
                SpawnHandler.totalHoverFish.Remove(hoverFish.gameObject);
            }

            else if (__instance is Jellyray jellyRay)
            {
                SpawnHandler.totalJellyRays.Remove(jellyRay.gameObject);
            }

            else if (__instance is Jumper jumper)
            {
                SpawnHandler.totalJumpers.Remove(jumper.gameObject);
            }

            else if (__instance is LavaLarva lavaLarva)
            {
                SpawnHandler.totalLavaLarvas.Remove(lavaLarva.gameObject);
            }

            else if (__instance is LavaLizard lavaLizard)
            {
                SpawnHandler.totalLavaLizards.Remove(lavaLizard.gameObject);
            }

            else if (__instance is Mesmer mesmer)
            {
                SpawnHandler.totalMesmers.Remove(mesmer.gameObject);
            }

            else if (__instance is OculusFish oculus)
            {
                SpawnHandler.totalOculusFish.Remove(oculus.gameObject);
            }

            else if (__instance is Peeper peeper)
            {
                SpawnHandler.totalPeepers.Remove(peeper.gameObject);
            }

            else if (__instance is RabbitRay rabbitRay)
            {
                SpawnHandler.totalRabbitRays.Remove(rabbitRay.gameObject);
            }

            else if (__instance is ReaperLeviathan reaperLeviathan)
            {
                SpawnHandler.totalReaperLeviathans.Remove(reaperLeviathan.gameObject);
            }

            else if (__instance is Reefback reefback)
            {
                SpawnHandler.totalReefbacks.Remove(reefback.gameObject);
            }

            else if (__instance is Reginald reginald)
            {
                SpawnHandler.totalReginalds.Remove(reginald.gameObject);
            }

            //else if (__instance is RockGrub rockGrub)
            //{
            //    SpawnHandler.totalRockGrubs.Remove(rockGrub.gameObject);
            //}

            else if (__instance is SandShark sandShark)
            {
                SpawnHandler.totalSandSharks.Remove(sandShark.gameObject);
            }

            else if (__instance is SeaDragon seaDragon)
            {
                SpawnHandler.totalSeaDragons.Remove(seaDragon.gameObject);
            }

            else if (__instance is SeaEmperorBaby seaEmporerBaby)
            {
                SpawnHandler.totalSeaEmperorBabies.Remove(seaEmporerBaby.gameObject);
            }

            else if (__instance is SeaEmperorJuvenile seaEmporerJuvenile)
            {
                SpawnHandler.totalSeaEmperorJuveniles.Remove(seaEmporerJuvenile.gameObject);
            }

            else if (__instance is SeaTreader seaTreader)
            {
                SpawnHandler.totalSeaTreaders.Remove(seaTreader.gameObject);
            }

            else if (__instance is Shocker shocker)
            {
                SpawnHandler.totalShockers.Remove(shocker.gameObject);
            }

            else if (__instance is Skyray skyRay)
            {
                SpawnHandler.totalShockers.Remove(skyRay.gameObject);
            }

            else if (__instance is Spadefish spadeFish)
            {
                SpawnHandler.totalSpadeFish.Remove(spadeFish.gameObject);
            }

            else if (__instance is SpineEel spineEel)
            {
                SpawnHandler.totalSpineEels.Remove(spineEel.gameObject);
            }

            else if (__instance is Stalker stalker)
            {
                SpawnHandler.totalStalkers.Remove(stalker.gameObject);
            }

            else if (__instance is Warper warper)
            {
                SpawnHandler.totalWarpers.Remove(warper.gameObject);
            }
        }
    }
#endif

#if SUBNAUTICAZERO
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnDisable))]
    internal class OnDisableHandleSpawnPatch
    {
        [HarmonyPostfix]
        public static void OnDisablePostfix(Creature __instance)
        {
            #region Passive Fish
            if (__instance is ArcticPeeper arcticPeeper)
            {
                SpawnHandler.totalArcticPeepers.Remove(arcticPeeper.gameObject);
            }

            else if (__instance is ArrowRay arrowRay)
            {
                SpawnHandler.totalArrowRays.Remove(arrowRay.gameObject);
            }

            else if (__instance is Boomerang boomerang)
            {
                SpawnHandler.totalBoomerangs.Remove(boomerang.gameObject);
            }

            else if (__instance is Bladderfish bladderFish)
            {
                SpawnHandler.totalBladderFish.Remove(bladderFish.gameObject);
            }

            else if (__instance is Hoopfish hoopFish)
            {
                SpawnHandler.totalHoopFish.Remove(hoopFish.gameObject);
            }

            else if (__instance is DiscusFish discusFish)
            {
                SpawnHandler.totalDiscusFish.Remove(discusFish.gameObject);
            }

            else if (__instance is FeatherFish featherFish)
            {
                SpawnHandler.totalFeatherFish.Remove(featherFish.gameObject);
            }

            else if (__instance is NootFish nootFish)
            {
                SpawnHandler.totalNootFish.Remove(nootFish.gameObject);
            }

            else if (__instance is SpinnerFish spinnerFish)
            {
                SpawnHandler.totalSpinnerFish.Remove(spinnerFish.gameObject);
            }

            else if (__instance is ArcticRay arcticRay)
            {
                SpawnHandler.totalArcticRays.Remove(arcticRay.gameObject);
            }

            else if (__instance is Jellyfish eyeJelly)
            {
                SpawnHandler.totalJellyfish.Remove(eyeJelly.gameObject);
            }

            else if (__instance is TitanHolefish titanHolefish)
            {
                SpawnHandler.totalTitanHolefish.Remove(titanHolefish.gameObject);
            }

            else if (__instance is GlowWhale glowWhale)
            {
                SpawnHandler.totalGlowWhales.Remove(glowWhale.gameObject);
            }

            else if (__instance is Pinnacarid pinnacarid)
            {
                SpawnHandler.totalPinnacarids.Remove(pinnacarid.gameObject);
            }

            else if (__instance is Triops triops)
            {
                SpawnHandler.totalTriops.Remove(triops.gameObject);
            }

            else if (__instance is Trivalve trivalve)
            {
                SpawnHandler.totalTrivalves.Remove(trivalve.gameObject);
            }

            else if (__instance is SymbioteFish symbioteFish)
            {
                SpawnHandler.totalSymbioteFish.Remove(symbioteFish.gameObject);
            }

            else if (__instance is RockGrub rockGrub)
            {
                SpawnHandler.totalRockGrubs.Remove(rockGrub.gameObject);
            }
            #endregion

            #region Aggressive Fish
            else if (__instance is Crash crashFish)
            {
                SpawnHandler.totalCrashFish.Remove(crashFish.gameObject);
            }

            else if (__instance is Brinewing brinewing)
            {
                SpawnHandler.totalBrineWings.Remove(brinewing.gameObject);
            }

            else if (__instance is LilyPaddler lilyPaddler)
            {
                SpawnHandler.totalLilyPaddlers.Remove(lilyPaddler.gameObject);
            }

            else if (__instance is Cryptosuchus cryptosuchus)
            {
                SpawnHandler.totalCryptosuchus.Remove(cryptosuchus.gameObject);
            }

            else if (__instance is BruteShark bruteShark)
            {
                SpawnHandler.totalBruteSharks.Remove(bruteShark.gameObject);
            }

            else if (__instance is SquidShark squidShark)
            {
                SpawnHandler.totalSquidSharks.Remove(squidShark.gameObject);
            }

            else if (__instance is Chelicerate chelicerate)
            {
                SpawnHandler.totalChelicerates.Remove(chelicerate.gameObject);
            }

            else if (__instance is ShadowLeviathan shadowLeviathan)
            {
                SpawnHandler.totalShadowLeviathans.Remove(shadowLeviathan.gameObject);
            }

            else if (__instance is VoidLeviathan voidLeviathan)
            {
                SpawnHandler.totalVoidLeviathans.Remove(voidLeviathan.gameObject);
            }
            #endregion

            #region Not Fish
            else if (__instance is Skyray skyray)
            {
                SpawnHandler.totalSkyRays.Remove(skyray.gameObject);
            }

            else if (__instance is PenguinBaby pengling)
            {
                SpawnHandler.totalPenglings.Remove(pengling.gameObject);
            }

            else if (__instance is Penguin pengwing)
            {
                SpawnHandler.totalPengwings.Remove(pengwing.gameObject);
            }

            else if (__instance is SeaMonkeyBaby seaMonkeyBaby)
            {
                SpawnHandler.totalSeaMonkeyBabies.Remove(seaMonkeyBaby.gameObject);
            }

            else if (__instance is SeaMonkey seaMonkey)
            {
                SpawnHandler.totalSeaMonkeys.Remove(seaMonkey.gameObject);
            }

            else if (__instance is SnowStalkerBaby snowStalkerBaby)
            {
                SpawnHandler.totalSnowStalkerBabies.Remove(snowStalkerBaby.gameObject);
            }

            else if (__instance is SnowStalker snowStalker)
            {
                SpawnHandler.totalSnowStalkers.Remove(snowStalker.gameObject);
            }

            else if (__instance is RockPuncher rockPuncher)
            {
                SpawnHandler.totalRockPunchers.Remove(rockPuncher.gameObject);
            }
            #endregion
        }
    }
#endif
}
