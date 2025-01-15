using HarmonyLib;

namespace BiggerFishMod
{
#if SUBNAUTICA
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    internal class OnEnableHandleSpawnPatch
    {
        [HarmonyPostfix]
        public static void OnEnablePostfixSpawn(Creature __instance)
        {
            if(__instance is Biter biter)
            {
                if(SpawnHandler.totalBiters.Count < SpawnHandler.maxBiters)
                {
                    SpawnHandler.totalBiters.Add(biter.gameObject);
                }
                else if(SpawnHandler.totalBiters.Count >= SpawnHandler.maxBiters)
                {
                    biter.gameObject.SetActive(false);
                }
            }

            if (__instance is Bladderfish bladderFish)
            {
                if (SpawnHandler.totalBladderFish.Count < SpawnHandler.maxBladderFish)
                {
                    SpawnHandler.totalBladderFish.Add(bladderFish.gameObject);
                }
                else if (SpawnHandler.totalBladderFish.Count >= SpawnHandler.maxBladderFish)
                {
                    bladderFish.gameObject.SetActive(false);
                }
            }

            if (__instance is Bleeder bleeder)
            {
                if (SpawnHandler.totalBleeders.Count < SpawnHandler.maxBleeders)
                {
                    SpawnHandler.totalBleeders.Add(bleeder.gameObject);
                }
                else if (SpawnHandler.totalBleeders.Count >= SpawnHandler.maxBleeders)
                {
                    bleeder.gameObject.SetActive(false);
                }
            }

            if (__instance is BoneShark boneShark)
            {
                if (SpawnHandler.totalBoneSharks.Count < SpawnHandler.maxBoneSharks)
                {
                    SpawnHandler.totalBoneSharks.Add(boneShark.gameObject);
                }
                else if (SpawnHandler.totalBoneSharks.Count >= SpawnHandler.maxBoneSharks)
                {
                    boneShark.gameObject.SetActive(false);
                }
            }

            if (__instance is Boomerang boomerang)
            {
                if (SpawnHandler.totalBoomerangs.Count < SpawnHandler.maxBoomerangs)
                {
                    SpawnHandler.totalBoomerangs.Add(boomerang.gameObject);
                }
                else if (SpawnHandler.totalBoomerangs.Count >= SpawnHandler.maxBoomerangs)
                {
                    boomerang.gameObject.SetActive(false);
                }
            }

            if (__instance is CaveCrawler caveCrawler)
            {
                if (SpawnHandler.totalCaveCrawlers.Count < SpawnHandler.maxCaveCrawlers)
                {
                    SpawnHandler.totalCaveCrawlers.Add(caveCrawler.gameObject);
                }
                else if (SpawnHandler.totalCaveCrawlers.Count >= SpawnHandler.maxCaveCrawlers)
                {
                    caveCrawler.gameObject.SetActive(false);
                }
            }

            if (__instance is CrabSnake crabSnake)
            {
                if (SpawnHandler.totalCrabSnakes.Count < SpawnHandler.maxCrabSnakes)
                {
                    SpawnHandler.totalCrabSnakes.Add(crabSnake.gameObject);
                }
                else if (SpawnHandler.totalCrabSnakes.Count >= SpawnHandler.maxCrabSnakes)
                {
                    crabSnake.gameObject.SetActive(false);
                }
            }

            if (__instance is CrabSquid crabSquid)
            {
                if (SpawnHandler.totalCrabSquids.Count < SpawnHandler.maxCrabSquids)
                {
                    SpawnHandler.totalCrabSquids.Add(crabSquid.gameObject);
                }
                else if (SpawnHandler.totalCrabSquids.Count >= SpawnHandler.maxCrabSquids)
                {
                    crabSquid.gameObject.SetActive(false);
                }
            }

            if (__instance is Crash crashFish)
            {
                if (SpawnHandler.totalCrashFish.Count < SpawnHandler.maxCrashFish)
                {
                    SpawnHandler.totalCrashFish.Add(crashFish.gameObject);
                }
                else if (SpawnHandler.totalCrashFish.Count >= SpawnHandler.maxCrashFish)
                {
                    crashFish.gameObject.SetActive(false);
                }
            }

            if (__instance is CuteFish cuddleFish)
            {
                if (SpawnHandler.totalCuddleFish.Count < SpawnHandler.maxCuddleFish)
                {
                    SpawnHandler.totalCuddleFish.Add(cuddleFish.gameObject);
                }
                else if (SpawnHandler.totalCuddleFish.Count >= SpawnHandler.maxCuddleFish)
                {
                    cuddleFish.gameObject.SetActive(false);
                }
            }

            if (__instance is Eyeye eyeye)
            {
                if (SpawnHandler.totalEyeyes.Count < SpawnHandler.maxEyeyes)
                {
                    SpawnHandler.totalEyeyes.Add(eyeye.gameObject);
                }
                else if (SpawnHandler.totalEyeyes.Count >= SpawnHandler.maxEyeyes)
                {
                    eyeye.gameObject.SetActive(false);
                }
            }

            if (__instance is Garryfish garryFish)
            {
                if (SpawnHandler.totalGarryFish.Count < SpawnHandler.maxGarryFish)
                {
                    SpawnHandler.totalGarryFish.Add(garryFish.gameObject);
                }
                else if (SpawnHandler.totalGarryFish.Count >= SpawnHandler.maxGarryFish)
                {
                    garryFish.gameObject.SetActive(false);
                }
            }

            if (__instance is GasoPod gasopod)
            {
                if (SpawnHandler.totalGasopods.Count < SpawnHandler.maxGasopods)
                {
                    SpawnHandler.totalGasopods.Add(gasopod.gameObject);
                }
                else if (SpawnHandler.totalGasopods.Count >= SpawnHandler.maxGasopods)
                {
                    gasopod.gameObject.SetActive(false);
                }
            }

            if (__instance is GhostLeviatanVoid voidGhostLeviathan)
            {
                if (SpawnHandler.totalVoidGhostLeviathans.Count < SpawnHandler.maxVoidGhostLeviathans)
                {
                    SpawnHandler.totalVoidGhostLeviathans.Add(voidGhostLeviathan.gameObject);
                }
                else if (SpawnHandler.totalVoidGhostLeviathans.Count >= SpawnHandler.maxVoidGhostLeviathans)
                {
                    voidGhostLeviathan.gameObject.SetActive(false);
                }
            }

            if (__instance is GhostLeviathan ghostLeviathan)
            {
                if (SpawnHandler.totalGhostLeviathans.Count < SpawnHandler.maxGhostLeviathans)
                {
                    SpawnHandler.totalGhostLeviathans.Add(ghostLeviathan.gameObject);
                }
                else if (SpawnHandler.totalGhostLeviathans.Count >= SpawnHandler.maxGhostLeviathans)
                {
                    ghostLeviathan.gameObject.SetActive(false);
                }
            }

            if (__instance is GhostRay ghostRay)
            {
                if (SpawnHandler.totalGhostRays.Count < SpawnHandler.maxGhostRays)
                {
                    SpawnHandler.totalGhostRays.Add(ghostRay.gameObject);
                }
                else if (SpawnHandler.totalGhostRays.Count >= SpawnHandler.maxGhostRays)
                {
                    ghostRay.gameObject.SetActive(false);
                }
            }

            if (__instance is Holefish holeFish)
            {
                if (SpawnHandler.totalHoleFish.Count < SpawnHandler.maxHoleFish)
                {
                    SpawnHandler.totalHoleFish.Add(holeFish.gameObject);
                }
                else if (SpawnHandler.totalHoleFish.Count >= SpawnHandler.maxHoleFish)
                {
                    holeFish.gameObject.SetActive(false);
                }
            }

            if (__instance is Hoopfish hoopFish)
            {
                if (SpawnHandler.totalHoopFish.Count < SpawnHandler.maxHoopFish)
                {
                    SpawnHandler.totalHoopFish.Add(hoopFish.gameObject);
                }
                else if (SpawnHandler.totalHoopFish.Count >= SpawnHandler.maxHoopFish)
                {
                    hoopFish.gameObject.SetActive(false);
                }
            }

            if (__instance is Hoverfish hoverFish)
            {
                if (SpawnHandler.totalHoverFish.Count < SpawnHandler.maxHoverFish)
                {
                    SpawnHandler.totalHoverFish.Add(hoverFish.gameObject);
                }
                else if (SpawnHandler.totalHoverFish.Count >= SpawnHandler.maxHoverFish)
                {
                    hoverFish.gameObject.SetActive(false);
                }
            }

            if (__instance is Jellyray jellyRay)
            {
                if (SpawnHandler.totalJellyRays.Count < SpawnHandler.maxJellyRays)
                {
                    SpawnHandler.totalJellyRays.Add(jellyRay.gameObject);
                }
                else if (SpawnHandler.totalJellyRays.Count >= SpawnHandler.maxJellyRays)
                {
                    jellyRay.gameObject.SetActive(false);
                }
            }

            if (__instance is Jumper jumper)
            {
                if (SpawnHandler.totalJumpers.Count < SpawnHandler.maxJumpers)
                {
                    SpawnHandler.totalJumpers.Add(jumper.gameObject);
                }
                else if (SpawnHandler.totalJumpers.Count >= SpawnHandler.maxJumpers)
                {
                    jumper.gameObject.SetActive(false);
                }
            }

            if (__instance is LavaLarva lavaLarva)
            {
                if (SpawnHandler.totalLavaLarvas.Count < SpawnHandler.maxLavaLarvas)
                {
                    SpawnHandler.totalLavaLarvas.Add(lavaLarva.gameObject);
                }
                else if (SpawnHandler.totalLavaLarvas.Count >= SpawnHandler.maxLavaLarvas)
                {
                    lavaLarva.gameObject.SetActive(false);
                }
            }

            if (__instance is LavaLizard lavaLizard)
            {
                if (SpawnHandler.totalLavaLizards.Count < SpawnHandler.maxLavaLizards)
                {
                    SpawnHandler.totalLavaLizards.Add(lavaLizard.gameObject);
                }
                else if (SpawnHandler.totalLavaLizards.Count >= SpawnHandler.maxLavaLizards)
                {
                    lavaLizard.gameObject.SetActive(false);
                }
            }

            if (__instance is Mesmer mesmer)
            {
                if (SpawnHandler.totalMesmers.Count < SpawnHandler.maxMesmers)
                {
                    SpawnHandler.totalMesmers.Add(mesmer.gameObject);
                }
                else if (SpawnHandler.totalMesmers.Count >= SpawnHandler.maxMesmers)
                {
                    mesmer.gameObject.SetActive(false);
                }
            }

            if (__instance is OculusFish oculus)
            {
                if (SpawnHandler.totalOculusFish.Count < SpawnHandler.maxOculusFish)
                {
                    SpawnHandler.totalOculusFish.Add(oculus.gameObject);
                }
                else if (SpawnHandler.totalOculusFish.Count >= SpawnHandler.maxOculusFish)
                {
                    oculus.gameObject.SetActive(false);
                }
            }

            if (__instance is Peeper peeper)
            {
                if (SpawnHandler.totalPeepers.Count < SpawnHandler.maxPeepers)
                {
                    SpawnHandler.totalPeepers.Add(peeper.gameObject);
                }
                else if (SpawnHandler.totalPeepers.Count >= SpawnHandler.maxPeepers)
                {
                    peeper.gameObject.SetActive(false);
                }
            }

            if (__instance is RabbitRay rabbitRay)
            {
                if (SpawnHandler.totalRabbitRays.Count < SpawnHandler.maxRabbitRays)
                {
                    SpawnHandler.totalRabbitRays.Add(rabbitRay.gameObject);
                }
                else if (SpawnHandler.totalRabbitRays.Count >= SpawnHandler.maxRabbitRays)
                {
                    rabbitRay.gameObject.SetActive(false);
                }
            }

            if (__instance is ReaperLeviathan reaperLeviathan)
            {
                if (SpawnHandler.totalReaperLeviathans.Count < SpawnHandler.maxReaperLeviathans)
                {
                    SpawnHandler.totalReaperLeviathans.Add(reaperLeviathan.gameObject);
                }
                else if (SpawnHandler.totalReaperLeviathans.Count >= SpawnHandler.maxReaperLeviathans)
                {
                    reaperLeviathan.gameObject.SetActive(false);
                }
            }

            if (__instance is Reefback reefback)
            {
                if (SpawnHandler.totalReefbacks.Count < SpawnHandler.maxReefbacks)
                {
                    SpawnHandler.totalReefbacks.Add(reefback.gameObject);
                }
                else if (SpawnHandler.totalReefbacks.Count >= SpawnHandler.maxReefbacks)
                {
                    reefback.gameObject.SetActive(false);
                }
            }

            if (__instance is Reginald reginald)
            {
                if (SpawnHandler.totalReginalds.Count < SpawnHandler.maxReginalds)
                {
                    SpawnHandler.totalReginalds.Add(reginald.gameObject);
                }
                else if (SpawnHandler.totalReginalds.Count >= SpawnHandler.maxReginalds)
                {
                    reginald.gameObject.SetActive(false);
                }
            }

            if (__instance is SandShark sandShark)
            {
                if (SpawnHandler.totalSandSharks.Count < SpawnHandler.maxSandSharks)
                {
                    SpawnHandler.totalSandSharks.Add(sandShark.gameObject);
                }
                else if (SpawnHandler.totalSandSharks.Count >= SpawnHandler.maxSandSharks)
                {
                    sandShark.gameObject.SetActive(false);
                }
            }

            if (__instance is SeaDragon seaDragon)
            {
                if (SpawnHandler.totalSeaDragons.Count < SpawnHandler.maxSeaDragons)
                {
                    SpawnHandler.totalSeaDragons.Add(seaDragon.gameObject);
                }
                else if (SpawnHandler.totalSeaDragons.Count >= SpawnHandler.maxSeaDragons)
                {
                    seaDragon.gameObject.SetActive(false);
                }
            }

            if (__instance is SeaEmperorBaby seaEmperorBaby)
            {
                if (SpawnHandler.totalSeaEmperorBabies.Count < SpawnHandler.maxSeaEmperorBabies)
                {
                    SpawnHandler.totalSeaEmperorBabies.Add(seaEmperorBaby.gameObject);
                }
                else if (SpawnHandler.totalSeaEmperorBabies.Count >= SpawnHandler.maxSeaEmperorBabies)
                {
                    seaEmperorBaby.gameObject.SetActive(false);
                }
            }

            if (__instance is SeaEmperorJuvenile seaEmperorJuvenile)
            {
                if (SpawnHandler.totalSeaEmperorJuveniles.Count < SpawnHandler.maxSeaEmperorJuveniles)
                {
                    SpawnHandler.totalSeaEmperorJuveniles.Add(seaEmperorJuvenile.gameObject);
                }
                else if (SpawnHandler.totalSeaEmperorJuveniles.Count >= SpawnHandler.maxSeaEmperorJuveniles)
                {
                    seaEmperorJuvenile.gameObject.SetActive(false);
                }
            }

            if (__instance is SeaTreader seaTreader)
            {
                if (SpawnHandler.totalSeaTreaders.Count < SpawnHandler.maxSeaTreaders)
                {
                    SpawnHandler.totalSeaTreaders.Add(seaTreader.gameObject);
                }
                else if (SpawnHandler.totalSeaTreaders.Count >= SpawnHandler.maxSeaTreaders)
                {
                    seaTreader.gameObject.SetActive(false);
                }
            }

            if (__instance is Shocker shocker)
            {
                if (SpawnHandler.totalShockers.Count < SpawnHandler.maxShockers)
                {
                    SpawnHandler.totalShockers.Add(shocker.gameObject);
                }
                else if (SpawnHandler.totalShockers.Count >= SpawnHandler.maxShockers)
                {
                    shocker.gameObject.SetActive(false);
                }
            }

            if (__instance is Spadefish spadeFish)
            {
                if (SpawnHandler.totalSpadeFish.Count < SpawnHandler.maxSpadeFish)
                {
                    SpawnHandler.totalSpadeFish.Add(spadeFish.gameObject);
                }
                else if (SpawnHandler.totalSpadeFish.Count >= SpawnHandler.maxSpadeFish)
                {
                    spadeFish.gameObject.SetActive(false);
                }
            }

            if (__instance is SpineEel spineEel)
            {
                if (SpawnHandler.totalSpineEels.Count < SpawnHandler.maxSpineEels)
                {
                    SpawnHandler.totalSpineEels.Add(spineEel.gameObject);
                }
                else if (SpawnHandler.totalSpineEels.Count >= SpawnHandler.maxSpineEels)
                {
                    spineEel.gameObject.SetActive(false);
                }
            }

            if (__instance is Stalker stalker)
            {
                if (SpawnHandler.totalStalkers.Count < SpawnHandler.maxStalkers)
                {
                    SpawnHandler.totalStalkers.Add(stalker.gameObject);
                }
                else if (SpawnHandler.totalStalkers.Count >= SpawnHandler.maxStalkers)
                {
                    stalker.gameObject.SetActive(false);
                }
            }

            if (__instance is Warper warper)
            {
                if (SpawnHandler.totalWarpers.Count < SpawnHandler.maxWarpers)
                {
                    SpawnHandler.totalWarpers.Add(warper.gameObject);
                }
                else if (SpawnHandler.totalWarpers.Count >= SpawnHandler.maxWarpers)
                {
                    warper.gameObject.SetActive(false);
                }
            }
        }
    }
#endif

#if SUBNAUTICAZERO
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    internal class OnEnableHandleSpawnPatch
    {
        [HarmonyPostfix]
        public static void OnEnablePostfix(Creature __instance)
        {
            #region Passive Fish
            if (__instance is ArcticPeeper arcticPeeper)
            {
                if (SpawnHandler.totalArcticPeepers.Count < SpawnHandler.maxArcticPeepers)
                {
                    SpawnHandler.totalArcticPeepers.Add(arcticPeeper.gameObject);
                }
                else if (SpawnHandler.totalArcticPeepers.Count >= SpawnHandler.maxArcticPeepers)
                {
                    arcticPeeper.gameObject.SetActive(false);
                }
            }

            if (__instance is ArrowRay arrowRay)
            {
                if (SpawnHandler.totalArrowRays.Count < SpawnHandler.maxArrowRays)
                {
                    SpawnHandler.totalArrowRays.Add(arrowRay.gameObject);
                }
                else if (SpawnHandler.totalArrowRays.Count >= SpawnHandler.maxArrowRays)
                {
                    arrowRay.gameObject.SetActive(false);
                }
            }

            if (__instance is Boomerang boomerang)
            {
                if (SpawnHandler.totalBoomerangs.Count < SpawnHandler.maxBoomerangs)
                {
                    SpawnHandler.totalBoomerangs.Add(boomerang.gameObject);
                }
                else if (SpawnHandler.totalBoomerangs.Count >= SpawnHandler.maxBoomerangs)
                {
                    boomerang.gameObject.SetActive(false);
                }
            }

            if (__instance is Bladderfish bladderFish)
            {
                if (SpawnHandler.totalBladderFish.Count < SpawnHandler.maxBladderFish)
                {
                    SpawnHandler.totalBladderFish.Add(bladderFish.gameObject);
                }
                else if (SpawnHandler.totalBladderFish.Count >= SpawnHandler.maxBladderFish)
                {
                    bladderFish.gameObject.SetActive(false);
                }
            }

            if (__instance is Hoopfish hoopFish)
            {
                if (SpawnHandler.totalHoopFish.Count < SpawnHandler.maxHoopFish)
                {
                    SpawnHandler.totalHoopFish.Add(hoopFish.gameObject);
                }
                else if (SpawnHandler.totalHoopFish.Count >= SpawnHandler.maxHoopFish)
                {
                    hoopFish.gameObject.SetActive(false);
                } 
            }

            if (__instance is DiscusFish discusFish)
            {
                if (SpawnHandler.totalDiscusFish.Count < SpawnHandler.maxDiscusFish)
                {
                    SpawnHandler.totalDiscusFish.Add(discusFish.gameObject);
                }
                else if (SpawnHandler.totalDiscusFish.Count >= SpawnHandler.maxDiscusFish)
                {
                    discusFish.gameObject.SetActive(false);
                }
            }

            if (__instance is FeatherFish featherFish)
            {
                if (SpawnHandler.totalFeatherFish.Count < SpawnHandler.maxFeatherFish)
                {
                    SpawnHandler.totalFeatherFish.Add(featherFish.gameObject);
                }
                else if (SpawnHandler.totalFeatherFish.Count >= SpawnHandler.maxFeatherFish)
                {
                    featherFish.gameObject.SetActive(false);
                }
            }

            if (__instance is NootFish nootFish)
            {
                if (SpawnHandler.totalNootFish.Count < SpawnHandler.maxNootFish)
                {
                    SpawnHandler.totalNootFish.Add(nootFish.gameObject);
                }
                else if (SpawnHandler.totalNootFish.Count >= SpawnHandler.maxNootFish)
                {
                    nootFish.gameObject.SetActive(false);
                }
            }

            // Reference to spine fish doesn't exist? Will enable once I figure out how to reference spine fish.
            //if (__instance is SpineFish spineFish)
            //{
            //    if (SpawnHandler.totalSpinFish.Count < SpawnHandler.maxSpineFish)
            //    {
            //        SpawnHandler.totalSpinFish.Add(spineFish.gameObject);
            //    }
            //    else if (SpawnHandler.totalSpinFish.Count >= SpawnHandler.maxSpineFish)
            //    {
            //        spineFish.gameObject.SetActive(false);
            //    }
            //}

            if (__instance is SpinnerFish spinnerFish)
            {
                if (SpawnHandler.totalSpinnerFish.Count < SpawnHandler.maxSpinnerFish)
                {
                    SpawnHandler.totalSpinnerFish.Add(spinnerFish.gameObject);
                }
                else if (SpawnHandler.totalSpinnerFish.Count >= SpawnHandler.maxSpinnerFish)
                {
                    spinnerFish.gameObject.SetActive(false);
                }
            }

            if (__instance is ArcticRay arcticRay)
            {
                if (SpawnHandler.totalArcticRays.Count < SpawnHandler.maxArcticRays)
                {
                    SpawnHandler.totalArcticRays.Add(arcticRay.gameObject);
                }
                else if (SpawnHandler.totalArcticRays.Count >= SpawnHandler.maxArcticRays)
                {
                    arcticRay.gameObject.SetActive(false);
                }
            }

            if (__instance is Jellyfish eyeJelly)
            {
                if (SpawnHandler.totalJellyfish.Count < SpawnHandler.maxJellyFish)
                {
                    SpawnHandler.totalJellyfish.Add(eyeJelly.gameObject);
                }
                else if (SpawnHandler.totalJellyfish.Count >= SpawnHandler.maxJellyFish)
                {
                    eyeJelly.gameObject.SetActive(false);
                }
            }

            if (__instance is TitanHolefish titanHolefish)
            {
                if (SpawnHandler.totalTitanHolefish.Count < SpawnHandler.maxTitanHolefish)
                {
                    SpawnHandler.totalTitanHolefish.Add(titanHolefish.gameObject);
                }
                else if (SpawnHandler.totalTitanHolefish.Count >= SpawnHandler.maxTitanHolefish)
                {
                    titanHolefish.gameObject.SetActive(false);
                }
            }

            if (__instance is GlowWhale glowWhale)
            {
                if (SpawnHandler.totalGlowWhales.Count < SpawnHandler.maxGlowWhales)
                {
                    SpawnHandler.totalGlowWhales.Add(glowWhale.gameObject);
                }
                else if (SpawnHandler.totalGlowWhales.Count >= SpawnHandler.maxGlowWhales)
                {
                    glowWhale.gameObject.SetActive(false);
                }
            }

            if (__instance is Pinnacarid pinnacarid)
            {
                if (SpawnHandler.totalPinnacarids.Count < SpawnHandler.maxPinnacarids)
                {
                    SpawnHandler.totalPinnacarids.Add(pinnacarid.gameObject);
                }
                else if (SpawnHandler.totalPinnacarids.Count >= SpawnHandler.maxPinnacarids)
                {
                    pinnacarid.gameObject.SetActive(false);
                }
            }

            if (__instance is Triops triops)
            {
                if (SpawnHandler.totalTriops.Count < SpawnHandler.maxTriops)
                {
                    SpawnHandler.totalTriops.Add(triops.gameObject);
                }
                else if (SpawnHandler.totalTriops.Count >= SpawnHandler.maxTriops)
                {
                    triops.gameObject.SetActive(false);
                }
            }

            if (__instance is Trivalve trivalve)
            {
                if (SpawnHandler.totalTrivalves.Count < SpawnHandler.maxTrivalves)
                {
                    SpawnHandler.totalTrivalves.Add(trivalve.gameObject);
                }
                else if (SpawnHandler.totalTrivalves.Count >= SpawnHandler.maxTrivalves)
                {
                    trivalve.gameObject.SetActive(false);
                }
            }

            if (__instance is SymbioteFish symbioteFish)
            {
                if (SpawnHandler.totalSymbioteFish.Count < SpawnHandler.maxSymbioteFish)
                {
                    SpawnHandler.totalSymbioteFish.Add(symbioteFish.gameObject);
                }
                else if (SpawnHandler.totalSymbioteFish.Count >= SpawnHandler.maxSymbioteFish)
                {
                    symbioteFish.gameObject.SetActive(false);
                }
            }

            if (__instance is RockGrub rockGrub)
            {
                if (SpawnHandler.totalRockGrubs.Count < SpawnHandler.maxRockGrubs)
                {
                    SpawnHandler.totalRockGrubs.Add(rockGrub.gameObject);
                }
                else if (SpawnHandler.totalRockGrubs.Count >= SpawnHandler.maxRockGrubs)
                {
                    rockGrub.gameObject.SetActive(false);
                }
            }
            #endregion

            #region Aggressive Fish
            if (__instance is Crash crashFish)
            {
                if (SpawnHandler.totalCrashFish.Count < SpawnHandler.maxCrashFish)
                {
                    SpawnHandler.totalCrashFish.Add(crashFish.gameObject);
                }
                else if (SpawnHandler.totalCrashFish.Count >= SpawnHandler.maxCrashFish)
                {
                    crashFish.gameObject.SetActive(false);
                }
            }

            if (__instance is Brinewing brinewing)
            {
                if (SpawnHandler.totalBrineWings.Count < SpawnHandler.maxBrineWings)
                {
                    SpawnHandler.totalBrineWings.Add(brinewing.gameObject);
                }
                else if (SpawnHandler.totalBrineWings.Count >= SpawnHandler.maxBrineWings)
                {
                    brinewing.gameObject.SetActive(false);
                }
            }

            if (__instance is LilyPaddler lilyPaddler)
            {
                if (SpawnHandler.totalLilyPaddlers.Count < SpawnHandler.maxLilyPaddlers)
                {
                    SpawnHandler.totalLilyPaddlers.Add(lilyPaddler.gameObject);
                }
                else if (SpawnHandler.totalLilyPaddlers.Count >= SpawnHandler.maxLilyPaddlers)
                {
                    lilyPaddler.gameObject.SetActive(false);
                }
            }

            if (__instance is Cryptosuchus cryptosuchus)
            {
                if (SpawnHandler.totalCryptosuchus.Count < SpawnHandler.maxCryptosuchus)
                {
                    SpawnHandler.totalCryptosuchus.Add(cryptosuchus.gameObject);
                }
                else if (SpawnHandler.totalCryptosuchus.Count >= SpawnHandler.maxCryptosuchus)
                {
                    cryptosuchus.gameObject.SetActive(false);
                }
            }

            if (__instance is BruteShark bruteShark)
            {
                if (SpawnHandler.totalBruteSharks.Count < SpawnHandler.maxBruteSharks)
                {
                    SpawnHandler.totalBruteSharks.Add(bruteShark.gameObject);
                }
                else if (SpawnHandler.totalBruteSharks.Count >= SpawnHandler.maxBruteSharks)
                {
                    bruteShark.gameObject.SetActive(false);
                }
            }

            if (__instance is SquidShark squidShark)
            {
                if (SpawnHandler.totalSquidSharks.Count < SpawnHandler.maxSquidSharks)
                {
                    SpawnHandler.totalSquidSharks.Add(squidShark.gameObject);
                }
                else if (SpawnHandler.totalSquidSharks.Count >= SpawnHandler.maxSquidSharks)
                {
                    squidShark.gameObject.SetActive(false);
                }
            }

            if (__instance is Chelicerate chelicerate)
            {
                if (SpawnHandler.totalChelicerates.Count < SpawnHandler.maxChelicerates)
                {
                    SpawnHandler.totalChelicerates.Add(chelicerate.gameObject);
                }
                else if (SpawnHandler.totalChelicerates.Count >= SpawnHandler.maxChelicerates)
                {
                    chelicerate.gameObject.SetActive(false);
                }
            }

            if (__instance is ShadowLeviathan shadowLeviathan)
            {
                if (SpawnHandler.totalShadowLeviathans.Count < SpawnHandler.maxShadowLeviathans)
                {
                    SpawnHandler.totalShadowLeviathans.Add(shadowLeviathan.gameObject);
                }
                else if (SpawnHandler.totalShadowLeviathans.Count >= SpawnHandler.maxShadowLeviathans)
                {
                    shadowLeviathan.gameObject.SetActive(false);
                }
            }

            if (__instance is VoidLeviathan voidLeviathan)
            {
                if (SpawnHandler.totalVoidLeviathans.Count < SpawnHandler.maxVoidLeviathans)
                {
                    SpawnHandler.totalVoidLeviathans.Add(voidLeviathan.gameObject);
                }
                else if (SpawnHandler.totalVoidLeviathans.Count >= SpawnHandler.maxVoidLeviathans)
                {
                    voidLeviathan.gameObject.SetActive(false);
                }
            }
            #endregion

            #region Not Fish
            if (__instance is Skyray skyray)
            {
                if (SpawnHandler.totalSkyRays.Count < SpawnHandler.maxSkyRays)
                {
                    SpawnHandler.totalSkyRays.Add(skyray.gameObject);
                }
                else if (SpawnHandler.totalSkyRays.Count >= SpawnHandler.maxSkyRays)
                {
                    skyray.gameObject.SetActive(false);
                }
            }

            if (__instance is PenguinBaby pengling)
            {
                if (SpawnHandler.totalPenglings.Count < SpawnHandler.maxPenglings)
                {
                    SpawnHandler.totalPenglings.Add(pengling.gameObject);
                }
                else if (SpawnHandler.totalPenglings.Count >= SpawnHandler.maxPenglings)
                {
                    pengling.gameObject.SetActive(false);
                }
            }

            if (__instance is Penguin pengwing)
            {
                if (SpawnHandler.totalPengwings.Count < SpawnHandler.maxPengwings)
                {
                    SpawnHandler.totalPengwings.Add(pengwing.gameObject);
                }
                else if (SpawnHandler.totalPengwings.Count >= SpawnHandler.maxPengwings)
                {
                    pengwing.gameObject.SetActive(false);
                }
            }

            if (__instance is SeaMonkeyBaby seaMonkeyBaby)
            {
                if (SpawnHandler.totalSeaMonkeyBabies.Count < SpawnHandler.maxSeaMonkeyBabies)
                {
                    SpawnHandler.totalSeaMonkeyBabies.Add(seaMonkeyBaby.gameObject);
                }
                else if (SpawnHandler.totalSeaMonkeyBabies.Count >= SpawnHandler.maxSeaMonkeyBabies)
                {
                    seaMonkeyBaby.gameObject.SetActive(false);
                }
            }

            if (__instance is SeaMonkey seaMonkey)
            {
                if (SpawnHandler.totalSeaMonkeys.Count < SpawnHandler.maxSeaMonkeys)
                {
                    SpawnHandler.totalSeaMonkeys.Add(seaMonkey.gameObject);
                }
                else if (SpawnHandler.totalSeaMonkeys.Count >= SpawnHandler.maxSeaMonkeys)
                {
                    seaMonkey.gameObject.SetActive(false);
                }
            }

            if (__instance is SnowStalkerBaby snowStalkerBaby)
            {
                if (SpawnHandler.totalSnowStalkerBabies.Count < SpawnHandler.maxSnowStalkerBabies)
                {
                    SpawnHandler.totalSnowStalkerBabies.Add(snowStalkerBaby.gameObject);
                }
                else if (SpawnHandler.totalSnowStalkerBabies.Count >= SpawnHandler.maxSnowStalkerBabies)
                {
                    snowStalkerBaby.gameObject.SetActive(false);
                }
            }

            if (__instance is SnowStalker snowStalker)
            {
                if (SpawnHandler.totalSnowStalkers.Count < SpawnHandler.maxSnowStalkers)
                {
                    SpawnHandler.totalSnowStalkers.Add(snowStalker.gameObject);
                }
                else if (SpawnHandler.totalSnowStalkers.Count >= SpawnHandler.maxSnowStalkers)
                {
                    snowStalker.gameObject.SetActive(false);
                }
            }

            if (__instance is RockPuncher rockPuncher)
            {
                if (SpawnHandler.totalRockPunchers.Count < SpawnHandler.maxRockPunchers)
                {
                    SpawnHandler.totalRockPunchers.Add(rockPuncher.gameObject);
                }
                else if (SpawnHandler.totalRockPunchers.Count >= SpawnHandler.maxRockPunchers)
                {
                    rockPuncher.gameObject.SetActive(false);
                }
            }
            #endregion
        }
    }
#endif
}
