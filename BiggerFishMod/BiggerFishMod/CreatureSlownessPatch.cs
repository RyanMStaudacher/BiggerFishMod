using HarmonyLib;
using static VFXParticlesPool;

namespace BiggerFishMod
{
#if SUBNAUTICA
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    internal class CreatureSlownessPatch
    {
        [HarmonyPostfix]
        public static void OnEnablePostfix(Creature __instance)
        {
            if (__instance is Biter biter)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    biter.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    biter.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    biter.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    biter.GetComponent<Biter>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    biter.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.biterSlowness.Value;
                    biter.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.biterSlowness.Value;
                    biter.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.biterSlowness.Value;
                    biter.GetComponent<Biter>().traitsAnimator.speed /= MyModOptions.biterSlowness.Value;
                }
            }

            if (__instance is Bladderfish bladderFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bladderFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    bladderFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed /= MyModOptions.bladderFishSlowness.Value;
                }
            }

            if (__instance is Bleeder bleeder)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bleeder.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    bleeder.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    bleeder.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    bleeder.GetComponent<Bleeder>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    bleeder.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.bleederSlowness.Value;
                    bleeder.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.bleederSlowness.Value;
                    bleeder.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.bleederSlowness.Value;
                    bleeder.GetComponent<Bleeder>().traitsAnimator.speed /= MyModOptions.bleederSlowness.Value;
                }
            }

            if (__instance is BoneShark boneShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boneShark.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    boneShark.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    boneShark.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    boneShark.GetComponent<BoneShark>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    boneShark.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.boneSharkSlowness.Value;
                    boneShark.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.boneSharkSlowness.Value;
                    boneShark.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.boneSharkSlowness.Value;
                    boneShark.GetComponent<BoneShark>().traitsAnimator.speed /= MyModOptions.boneSharkSlowness.Value;
                }
            }

            if (__instance is Boomerang boomerang)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boomerang.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Boomerang>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    boomerang.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Boomerang>().traitsAnimator.speed /= MyModOptions.boomerangSlowness.Value;
                }
            }

            if (__instance is CaveCrawler caveCrawler)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    caveCrawler.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    caveCrawler.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    caveCrawler.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    caveCrawler.GetComponent<CaveCrawler>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    caveCrawler.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.caveCrawlerSlowness.Value;
                    caveCrawler.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.caveCrawlerSlowness.Value;
                    caveCrawler.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.caveCrawlerSlowness.Value;
                    caveCrawler.GetComponent<CaveCrawler>().traitsAnimator.speed /= MyModOptions.caveCrawlerSlowness.Value;
                }
            }

            if (__instance is CrabSnake crabSnake)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crabSnake.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    crabSnake.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    crabSnake.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    crabSnake.GetComponent<CrabSnake>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    crabSnake.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.crabSnakeSlowness.Value;
                    crabSnake.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.crabSnakeSlowness.Value;
                    crabSnake.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.crabSnakeSlowness.Value;
                    crabSnake.GetComponent<CrabSnake>().traitsAnimator.speed /= MyModOptions.crabSnakeSlowness.Value;
                }
            }

            if (__instance is CrabSquid crabSquid)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crabSquid.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    crabSquid.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    crabSquid.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    crabSquid.GetComponent<CrabSquid>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    crabSquid.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.crabSquidSlowness.Value;
                    crabSquid.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.crabSquidSlowness.Value;
                    crabSquid.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.crabSquidSlowness.Value;
                    crabSquid.GetComponent<CrabSquid>().traitsAnimator.speed /= MyModOptions.crabSquidSlowness.Value;
                }
            }

            if (__instance is Crash crashFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crashFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Crash>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    crashFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Crash>().traitsAnimator.speed /= MyModOptions.crashFishSlowness.Value;
                }
            }

            if (__instance is CuteFish cuddleFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    cuddleFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    cuddleFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    cuddleFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    cuddleFish.GetComponent<CuteFish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    cuddleFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.cuddleFishSlowness.Value;
                    cuddleFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.cuddleFishSlowness.Value;
                    cuddleFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.cuddleFishSlowness.Value;
                    cuddleFish.GetComponent<CuteFish>().traitsAnimator.speed /= MyModOptions.cuddleFishSlowness.Value;
                }
            }

            if (__instance is Eyeye eyeye)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    eyeye.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    eyeye.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    eyeye.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    eyeye.GetComponent<Eyeye>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    eyeye.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.eyeyeSlowness.Value;
                    eyeye.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.eyeyeSlowness.Value;
                    eyeye.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.eyeyeSlowness.Value;
                    eyeye.GetComponent<Eyeye>().traitsAnimator.speed /= MyModOptions.eyeyeSlowness.Value;
                }
            }

            if (__instance is Garryfish garryFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    garryFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    garryFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    garryFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    garryFish.GetComponent<Garryfish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    garryFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.garryFishSlowness.Value;
                    garryFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.garryFishSlowness.Value;
                    garryFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.garryFishSlowness.Value;
                    garryFish.GetComponent<Garryfish>().traitsAnimator.speed /= MyModOptions.garryFishSlowness.Value;
                }
            }

            if (__instance is GasoPod gasopod)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    gasopod.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    gasopod.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    gasopod.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    gasopod.GetComponent<GasoPod>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    gasopod.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.gasopodSlowness.Value;
                    gasopod.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.gasopodSlowness.Value;
                    gasopod.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.gasopodSlowness.Value;
                    gasopod.GetComponent<GasoPod>().traitsAnimator.speed /= MyModOptions.gasopodSlowness.Value;
                }
            }

            if (__instance is GhostLeviatanVoid voidGhostLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    voidGhostLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    voidGhostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    voidGhostLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    voidGhostLeviathan.GetComponent<GhostLeviatanVoid>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    voidGhostLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.voidGhostLeviathanSlowness.Value;
                    voidGhostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.voidGhostLeviathanSlowness.Value;
                    voidGhostLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.voidGhostLeviathanSlowness.Value;
                    voidGhostLeviathan.GetComponent<GhostLeviatanVoid>().traitsAnimator.speed /= MyModOptions.voidGhostLeviathanSlowness.Value;
                }
            }

            if (__instance is GhostLeviathan ghostLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    ghostLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    ghostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    ghostLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    ghostLeviathan.GetComponent<GhostLeviathan>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    ghostLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.ghostLeviathanSlowness.Value;
                    ghostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.ghostLeviathanSlowness.Value;
                    ghostLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.ghostLeviathanSlowness.Value;
                    ghostLeviathan.GetComponent<GhostLeviathan>().traitsAnimator.speed /= MyModOptions.ghostLeviathanSlowness.Value;
                }
            }

            if (__instance is GhostRay ghostRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    ghostRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    ghostRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    ghostRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    ghostRay.GetComponent<GhostRay>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    ghostRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.ghostRaySlowness.Value;
                    ghostRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.ghostRaySlowness.Value;
                    ghostRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.ghostRaySlowness.Value;
                    ghostRay.GetComponent<GhostRay>().traitsAnimator.speed /= MyModOptions.ghostRaySlowness.Value;
                }
            }

            if (__instance is Holefish holeFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    holeFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    holeFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    holeFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    holeFish.GetComponent<Holefish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    holeFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.holeFishSlowness.Value;
                    holeFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.holeFishSlowness.Value;
                    holeFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.holeFishSlowness.Value;
                    holeFish.GetComponent<Holefish>().traitsAnimator.speed /= MyModOptions.holeFishSlowness.Value;
                }
            }

            if (__instance is Hoopfish hoopFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoopFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    hoopFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed /= MyModOptions.hoopFishSlowness.Value;
                }
            }

            if (__instance is Hoverfish hoverFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoverFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    hoverFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    hoverFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    hoverFish.GetComponent<Hoverfish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    hoverFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.hoverFishSlowness.Value;
                    hoverFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.hoverFishSlowness.Value;
                    hoverFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.hoverFishSlowness.Value;
                    hoverFish.GetComponent<Hoverfish>().traitsAnimator.speed /= MyModOptions.hoverFishSlowness.Value;
                }
            }

            if (__instance is Jellyray jellyRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    jellyRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    jellyRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    jellyRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    jellyRay.GetComponent<Jellyray>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    jellyRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.jellyRaySlowness.Value;
                    jellyRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.jellyRaySlowness.Value;
                    jellyRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.jellyRaySlowness.Value;
                    jellyRay.GetComponent<Jellyray>().traitsAnimator.speed /= MyModOptions.jellyRaySlowness.Value;
                }
            }

            if (__instance is Jumper jumper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    jumper.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    jumper.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    jumper.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    jumper.GetComponent<Jumper>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    jumper.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.jumperSlowness.Value;
                    jumper.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.jumperSlowness.Value;
                    jumper.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.jumperSlowness.Value;
                    jumper.GetComponent<Jumper>().traitsAnimator.speed /= MyModOptions.jumperSlowness.Value;
                }
            }

            if (__instance is LavaLarva lavaLarva)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lavaLarva.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    lavaLarva.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    lavaLarva.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    lavaLarva.GetComponent<LavaLarva>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    lavaLarva.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.lavaLarvaSlowness.Value;
                    lavaLarva.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.lavaLarvaSlowness.Value;
                    lavaLarva.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.lavaLarvaSlowness.Value;
                    lavaLarva.GetComponent<LavaLarva>().traitsAnimator.speed /= MyModOptions.lavaLarvaSlowness.Value;
                }
            }

            if (__instance is LavaLizard lavaLizard)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lavaLizard.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    lavaLizard.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    lavaLizard.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    lavaLizard.GetComponent<LavaLizard>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    lavaLizard.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.lavaLizardSlowness.Value;
                    lavaLizard.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.lavaLizardSlowness.Value;
                    lavaLizard.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.lavaLizardSlowness.Value;
                    lavaLizard.GetComponent<LavaLizard>().traitsAnimator.speed /= MyModOptions.lavaLizardSlowness.Value;
                }
            }

            if (__instance is Mesmer mesmer)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    mesmer.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    mesmer.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    mesmer.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    mesmer.GetComponent<Mesmer>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    mesmer.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.mesmerSlowness.Value;
                    mesmer.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.mesmerSlowness.Value;
                    mesmer.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.mesmerSlowness.Value;
                    mesmer.GetComponent<Mesmer>().traitsAnimator.speed /= MyModOptions.mesmerSlowness.Value;
                }
            }

            if (__instance is OculusFish oculus)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    oculus.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    oculus.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    oculus.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    oculus.GetComponent<OculusFish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    oculus.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.oculusFishSlowness.Value;
                    oculus.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.oculusFishSlowness.Value;
                    oculus.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.oculusFishSlowness.Value;
                    oculus.GetComponent<OculusFish>().traitsAnimator.speed /= MyModOptions.oculusFishSlowness.Value;
                }
            }

            if (__instance is Peeper peeper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    peeper.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    peeper.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    peeper.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    peeper.GetComponent<Peeper>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    peeper.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.peeperSlowness.Value;
                    peeper.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.peeperSlowness.Value;
                    peeper.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.peeperSlowness.Value;
                    peeper.GetComponent<Peeper>().traitsAnimator.speed /= MyModOptions.peeperSlowness.Value;
                }
            }

            if (__instance is RabbitRay rabbitRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rabbitRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    rabbitRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    rabbitRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    rabbitRay.GetComponent<RabbitRay>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    rabbitRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.rabbitRaySlowness.Value;
                    rabbitRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.rabbitRaySlowness.Value;
                    rabbitRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.rabbitRaySlowness.Value;
                    rabbitRay.GetComponent<RabbitRay>().traitsAnimator.speed /= MyModOptions.rabbitRaySlowness.Value;
                }
            }

            if (__instance is ReaperLeviathan reaperLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    reaperLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    reaperLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    reaperLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    reaperLeviathan.GetComponent<ReaperLeviathan>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    reaperLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.reaperLeviathanSlowness.Value;
                    reaperLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.reaperLeviathanSlowness.Value;
                    reaperLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.reaperLeviathanSlowness.Value;
                    reaperLeviathan.GetComponent<ReaperLeviathan>().traitsAnimator.speed /= MyModOptions.reaperLeviathanSlowness.Value;
                }
            }

            if (__instance is Reefback reefback)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    reefback.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    reefback.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    reefback.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    reefback.GetComponent<Reefback>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    reefback.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.reefbackSlowness.Value;
                    reefback.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.reefbackSlowness.Value;
                    reefback.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.reefbackSlowness.Value;
                    reefback.GetComponent<Reefback>().traitsAnimator.speed /= MyModOptions.reefbackSlowness.Value;
                }
            }

            if (__instance is Reginald reginald)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    reginald.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    reginald.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    reginald.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    reginald.GetComponent<Reginald>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    reginald.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.reginaldSlowness.Value;
                    reginald.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.reginaldSlowness.Value;
                    reginald.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.reginaldSlowness.Value;
                    reginald.GetComponent<Reginald>().traitsAnimator.speed /= MyModOptions.reginaldSlowness.Value;
                }
            }

            if (__instance is SandShark sandShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sandShark.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    sandShark.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    sandShark.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    sandShark.GetComponent<SandShark>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    sandShark.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.sandSharkSlowness.Value;
                    sandShark.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.sandSharkSlowness.Value;
                    sandShark.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.sandSharkSlowness.Value;
                    sandShark.GetComponent<SandShark>().traitsAnimator.speed /= MyModOptions.sandSharkSlowness.Value;
                }
            }

            if (__instance is SeaDragon seaDragon)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaDragon.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    seaDragon.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaDragon.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaDragon.GetComponent<SeaDragon>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaDragon.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.seaDragonSlowness.Value;
                    seaDragon.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.seaDragonSlowness.Value;
                    seaDragon.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.seaDragonSlowness.Value;
                    seaDragon.GetComponent<SeaDragon>().traitsAnimator.speed /= MyModOptions.seaDragonSlowness.Value;
                }
            }

            if (__instance is SeaEmperorBaby seaEmporerBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaEmporerBaby.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    seaEmporerBaby.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaEmporerBaby.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaEmporerBaby.GetComponent<SeaEmperorBaby>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaEmporerBaby.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.seaEmporerBabySlowness.Value;
                    seaEmporerBaby.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.seaEmporerBabySlowness.Value;
                    seaEmporerBaby.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.seaEmporerBabySlowness.Value;
                    seaEmporerBaby.GetComponent<SeaEmperorBaby>().traitsAnimator.speed /= MyModOptions.seaEmporerBabySlowness.Value;
                }
            }

            if (__instance is SeaEmperorJuvenile seaEmporerJuvenile)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaEmporerJuvenile.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    seaEmporerJuvenile.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaEmporerJuvenile.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaEmporerJuvenile.GetComponent<SeaEmperorJuvenile>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaEmporerJuvenile.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.seaEmporerJuvenileSlowness.Value;
                    seaEmporerJuvenile.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.seaEmporerJuvenileSlowness.Value;
                    seaEmporerJuvenile.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.seaEmporerJuvenileSlowness.Value;
                    seaEmporerJuvenile.GetComponent<SeaEmperorJuvenile>().traitsAnimator.speed /= MyModOptions.seaEmporerJuvenileSlowness.Value;
                }
            }

            if (__instance is SeaTreader seaTreader)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaTreader.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    seaTreader.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaTreader.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaTreader.GetComponent<SeaTreader>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaTreader.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.seaTreaderSlowness.Value;
                    seaTreader.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.seaTreaderSlowness.Value;
                    seaTreader.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.seaTreaderSlowness.Value;
                    seaTreader.GetComponent<SeaTreader>().traitsAnimator.speed /= MyModOptions.seaTreaderSlowness.Value;
                }
            }

            if (__instance is Shocker shocker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    shocker.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    shocker.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    shocker.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    shocker.GetComponent<Shocker>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    shocker.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.shockerSlowness.Value;
                    shocker.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.shockerSlowness.Value;
                    shocker.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.shockerSlowness.Value;
                    shocker.GetComponent<Shocker>().traitsAnimator.speed /= MyModOptions.shockerSlowness.Value;
                }
            }

            if (__instance is Spadefish spadeFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    spadeFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    spadeFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    spadeFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    spadeFish.GetComponent<Spadefish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    spadeFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.spadeFishSlowness.Value;
                    spadeFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.spadeFishSlowness.Value;
                    spadeFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.spadeFishSlowness.Value;
                    spadeFish.GetComponent<Spadefish>().traitsAnimator.speed /= MyModOptions.spadeFishSlowness.Value;
                }
            }

            if (__instance is SpineEel spineEel)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    spineEel.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    spineEel.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    spineEel.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    spineEel.GetComponent<SpineEel>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    spineEel.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.spineEelSlowness.Value;
                    spineEel.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.spineEelSlowness.Value;
                    spineEel.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.spineEelSlowness.Value;
                    spineEel.GetComponent<SpineEel>().traitsAnimator.speed /= MyModOptions.spineEelSlowness.Value;
                }
            }

            if (__instance is Stalker stalker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    stalker.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    stalker.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    stalker.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    stalker.GetComponent<Stalker>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    stalker.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.stalkerSlowness.Value;
                    stalker.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.stalkerSlowness.Value;
                    stalker.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.stalkerSlowness.Value;
                    stalker.GetComponent<Stalker>().traitsAnimator.speed /= MyModOptions.stalkerSlowness.Value;
                }
            }

            if (__instance is Warper warper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    warper.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    warper.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    warper.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    warper.GetComponent<Warper>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    warper.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.warperSlowness.Value;
                    warper.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.warperSlowness.Value;
                    warper.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.warperSlowness.Value;
                    warper.GetComponent<Warper>().traitsAnimator.speed /= MyModOptions.warperSlowness.Value;
                }
            }
        }
    }
#endif

#if SUBNAUTICAZERO
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    public class CreatureSlownessPatch
    {
        [HarmonyPostfix]
        public static void OnEnableSlownessPostfix(Creature __instance)
        {
            #region Passive Fish
            if (__instance is ArcticPeeper arcticPeeper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arcticPeeper.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    arcticPeeper.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    arcticPeeper.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    arcticPeeper.GetComponent<ArcticPeeper>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //arcticPeeper.GetComponent<Locomotion>().maxVelocity /= MyModOptions.peeperSlowness.Value;
                    arcticPeeper.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.peeperSlowness.Value;
                    arcticPeeper.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.peeperSlowness.Value;
                    arcticPeeper.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.peeperSlowness.Value;
                    arcticPeeper.GetComponent<ArcticPeeper>().traitsAnimator.speed /= MyModOptions.peeperSlowness.Value;
                }
            }

            if (__instance is ArrowRay arrowRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arrowRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    arrowRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    arrowRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    arrowRay.GetComponent<ArrowRay>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //arrowRay.GetComponent<Locomotion>().maxVelocity /= MyModOptions.arrowRaySlowness.Value;
                    arrowRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.arrowRaySlowness.Value;
                    arrowRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.arrowRaySlowness.Value;
                    arrowRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.arrowRaySlowness.Value;
                    arrowRay.GetComponent<ArrowRay>().traitsAnimator.speed /= MyModOptions.arrowRaySlowness.Value;
                }
            }

            if (__instance is Boomerang boomerang)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boomerang.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Boomerang>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //boomerang.GetComponent<Locomotion>().maxVelocity /= MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Boomerang>().traitsAnimator.speed /= MyModOptions.boomerangSlowness.Value;
                }
            }

            if (__instance is Bladderfish bladderFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bladderFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //bladderFish.GetComponent<Locomotion>().maxVelocity /= MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed /= MyModOptions.bladderFishSlowness.Value;
                }
            }

            if (__instance is Hoopfish hoopFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoopFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //hoopFish.GetComponent<Locomotion>().maxVelocity /= MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed /= MyModOptions.hoopFishSlowness.Value;
                }
            }

            if (__instance is DiscusFish discusFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    discusFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    discusFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    discusFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    discusFish.GetComponent<DiscusFish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //discusFish.GetComponent<Locomotion>().maxVelocity /= MyModOptions.discusFishSlowness.Value;
                    discusFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.discusFishSlowness.Value;
                    discusFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.discusFishSlowness.Value;
                    discusFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.discusFishSlowness.Value;
                    discusFish.GetComponent<DiscusFish>().traitsAnimator.speed /= MyModOptions.discusFishSlowness.Value;
                }
            }

            if (__instance is FeatherFish featherFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    featherFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    featherFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    featherFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    featherFish.GetComponent<FeatherFish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //featherFish.GetComponent<Locomotion>().maxVelocity /= MyModOptions.featherFishSlowness.Value;
                    featherFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.featherFishSlowness.Value;
                    featherFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.featherFishSlowness.Value;
                    featherFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.featherFishSlowness.Value;
                    featherFish.GetComponent<FeatherFish>().traitsAnimator.speed /= MyModOptions.featherFishSlowness.Value;
                }
            }

            if (__instance is NootFish nootFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    nootFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    nootFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    nootFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    nootFish.GetComponent<NootFish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //nootFish.GetComponent<Locomotion>().maxVelocity /= MyModOptions.nootFishSlowness.Value;
                    nootFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.nootFishSlowness.Value;
                    nootFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.nootFishSlowness.Value;
                    nootFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.nootFishSlowness.Value;
                    nootFish.GetComponent<NootFish>().traitsAnimator.speed /= MyModOptions.nootFishSlowness.Value;
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
                    spinnerFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    spinnerFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    spinnerFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    spinnerFish.GetComponent<SpinnerFish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //spinnerFish.GetComponent<Locomotion>().maxVelocity /= MyModOptions.spinnerFishSlowness.Value;
                    spinnerFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.spinnerFishSlowness.Value;
                    spinnerFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.spinnerFishSlowness.Value;
                    spinnerFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.spinnerFishSlowness.Value;
                    spinnerFish.GetComponent<SpinnerFish>().traitsAnimator.speed /= MyModOptions.spinnerFishSlowness.Value;
                }
            }

            if (__instance is ArcticRay arcticRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arcticRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    arcticRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    arcticRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    arcticRay.GetComponent<ArcticRay>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //arcticRay.GetComponent<Locomotion>().maxVelocity /= MyModOptions.arcticRaySlowness.Value;
                    arcticRay.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.arcticRaySlowness.Value;
                    arcticRay.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.arcticRaySlowness.Value;
                    arcticRay.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.arcticRaySlowness.Value;
                    arcticRay.GetComponent<ArcticRay>().traitsAnimator.speed /= MyModOptions.arcticRaySlowness.Value;
                }
            }

            if (__instance is Jellyfish eyeJelly)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    eyeJelly.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    eyeJelly.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    eyeJelly.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    eyeJelly.GetComponent<Jellyfish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //eyeJelly.GetComponent<Locomotion>().maxVelocity /= MyModOptions.jellyFishSlowness.Value;
                    eyeJelly.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.jellyFishSlowness.Value;
                    eyeJelly.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.jellyFishSlowness.Value;
                    eyeJelly.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.jellyFishSlowness.Value;
                    eyeJelly.GetComponent<Jellyfish>().traitsAnimator.speed /= MyModOptions.jellyFishSlowness.Value;
                }
            }

            if (__instance is TitanHolefish titanHolefish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    titanHolefish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    titanHolefish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    titanHolefish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    titanHolefish.GetComponent<TitanHolefish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //titanHolefish.GetComponent<Locomotion>().maxVelocity /= MyModOptions.titanHoleFishSlowness.Value;
                    titanHolefish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.titanHoleFishSlowness.Value;
                    titanHolefish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.titanHoleFishSlowness.Value;
                    titanHolefish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.titanHoleFishSlowness.Value;
                    titanHolefish.GetComponent<TitanHolefish>().traitsAnimator.speed /= MyModOptions.titanHoleFishSlowness.Value;
                }
            }

            if (__instance is GlowWhale glowWhale)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    glowWhale.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    glowWhale.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    glowWhale.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    glowWhale.GetComponent<GlowWhale>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //glowWhale.GetComponent<Locomotion>().maxVelocity /= MyModOptions.glowWhaleSlowness.Value;
                    glowWhale.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.glowWhaleSlowness.Value;
                    glowWhale.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.glowWhaleSlowness.Value;
                    glowWhale.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.glowWhaleSlowness.Value;
                    glowWhale.GetComponent<GlowWhale>().traitsAnimator.speed /= MyModOptions.glowWhaleSlowness.Value;
                }
            }

            if (__instance is Pinnacarid pinnacarid)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pinnacarid.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    pinnacarid.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    pinnacarid.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    pinnacarid.GetComponent<Pinnacarid>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //pinnacarid.GetComponent<Locomotion>().maxVelocity /= MyModOptions.pinnacaridSlowness.Value;
                    pinnacarid.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.pinnacaridSlowness.Value;
                    pinnacarid.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.pinnacaridSlowness.Value;
                    pinnacarid.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.pinnacaridSlowness.Value;
                    pinnacarid.GetComponent<Pinnacarid>().traitsAnimator.speed /= MyModOptions.pinnacaridSlowness.Value;
                }
            }

            if (__instance is Triops triops)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    triops.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    triops.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    triops.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    triops.GetComponent<Triops>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //triops.GetComponent<Locomotion>().maxVelocity /= MyModOptions.triopsSlowness.Value;
                    triops.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.triopsSlowness.Value;
                    triops.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.triopsSlowness.Value;
                    triops.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.triopsSlowness.Value;
                    triops.GetComponent<Triops>().traitsAnimator.speed /= MyModOptions.triopsSlowness.Value;
                }
            }

            if (__instance is Trivalve trivalve)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    trivalve.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    trivalve.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    trivalve.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    trivalve.GetComponent<Trivalve>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //trivalve.GetComponent<Locomotion>().maxVelocity /= MyModOptions.trivalveSlowness.Value;
                    trivalve.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.trivalveSlowness.Value;
                    trivalve.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.trivalveSlowness.Value;
                    trivalve.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.trivalveSlowness.Value;
                    trivalve.GetComponent<Trivalve>().traitsAnimator.speed /= MyModOptions.trivalveSlowness.Value;
                }
            }

            if (__instance is SymbioteFish symbioteFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    symbioteFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    symbioteFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    symbioteFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    symbioteFish.GetComponent<SymbioteFish>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //symbioteFish.GetComponent<Locomotion>().maxVelocity /= MyModOptions.symbioteFishSlowness.Value;
                    symbioteFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.symbioteFishSlowness.Value;
                    symbioteFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.symbioteFishSlowness.Value;
                    symbioteFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.symbioteFishSlowness.Value;
                    symbioteFish.GetComponent<SymbioteFish>().traitsAnimator.speed /= MyModOptions.symbioteFishSlowness.Value;
                }
            }

            if (__instance is RockGrub rockGrub)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rockGrub.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    rockGrub.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    rockGrub.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    rockGrub.GetComponent<RockGrub>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //rockGrub.GetComponent<Locomotion>().maxVelocity /= MyModOptions.rockGrubSlowness.Value;
                    rockGrub.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.rockGrubSlowness.Value;
                    rockGrub.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.rockGrubSlowness.Value;
                    rockGrub.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.rockGrubSlowness.Value;
                    rockGrub.GetComponent<RockGrub>().traitsAnimator.speed /= MyModOptions.rockGrubSlowness.Value;
                }
            }
            #endregion

            #region Aggressive Fish
            if (__instance is Crash crashFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crashFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Crash>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //crashFish.GetComponent<Locomotion>().maxVelocity /= MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Crash>().traitsAnimator.speed /= MyModOptions.crashFishSlowness.Value;
                }
            }

            if (__instance is Brinewing brinewing)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    brinewing.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    brinewing.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    brinewing.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    brinewing.GetComponent<Brinewing>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //brinewing.GetComponent<Locomotion>().maxVelocity /= MyModOptions.brineWingSlowness.Value;
                    brinewing.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.brineWingSlowness.Value;
                    brinewing.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.brineWingSlowness.Value;
                    brinewing.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.brineWingSlowness.Value;
                    brinewing.GetComponent<Brinewing>().traitsAnimator.speed /= MyModOptions.brineWingSlowness.Value;
                }
            }

            if (__instance is LilyPaddler lilyPaddler)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lilyPaddler.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    lilyPaddler.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    lilyPaddler.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    lilyPaddler.GetComponent<LilyPaddler>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //lilyPaddler.GetComponent<Locomotion>().maxVelocity /= MyModOptions.lilyPaddlerSlowness.Value;
                    lilyPaddler.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.lilyPaddlerSlowness.Value;
                    lilyPaddler.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.lilyPaddlerSlowness.Value;
                    lilyPaddler.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.lilyPaddlerSlowness.Value;
                    lilyPaddler.GetComponent<LilyPaddler>().traitsAnimator.speed /= MyModOptions.lilyPaddlerSlowness.Value;
                }
            }

            if (__instance is Cryptosuchus cryptosuchus)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    cryptosuchus.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    cryptosuchus.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    cryptosuchus.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    cryptosuchus.GetComponent<Cryptosuchus>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //cryptosuchus.GetComponent<Locomotion>().maxVelocity /= MyModOptions.cryptosuchusSlowness.Value;
                    cryptosuchus.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.cryptosuchusSlowness.Value;
                    cryptosuchus.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.cryptosuchusSlowness.Value;
                    cryptosuchus.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.cryptosuchusSlowness.Value;
                    cryptosuchus.GetComponent<Cryptosuchus>().traitsAnimator.speed /= MyModOptions.cryptosuchusSlowness.Value;
                }
            }

            if (__instance is BruteShark bruteShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bruteShark.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    bruteShark.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    bruteShark.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    bruteShark.GetComponent<BruteShark>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //bruteShark.GetComponent<Locomotion>().maxVelocity /= MyModOptions.bruteSharkSlowness.Value;
                    bruteShark.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.bruteSharkSlowness.Value;
                    bruteShark.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.bruteSharkSlowness.Value;
                    bruteShark.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.bruteSharkSlowness.Value;
                    bruteShark.GetComponent<BruteShark>().traitsAnimator.speed /= MyModOptions.bruteSharkSlowness.Value;
                }
            }

            if (__instance is SquidShark squidShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    squidShark.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    squidShark.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    squidShark.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    squidShark.GetComponent<SquidShark>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //squidShark.GetComponent<Locomotion>().maxVelocity /= MyModOptions.squidSharkSlowness.Value;
                    squidShark.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.squidSharkSlowness.Value;
                    squidShark.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.squidSharkSlowness.Value;
                    squidShark.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.squidSharkSlowness.Value;
                    squidShark.GetComponent<SquidShark>().traitsAnimator.speed /= MyModOptions.squidSharkSlowness.Value;
                }
            }

            if (__instance is Chelicerate chelicerate)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    chelicerate.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    chelicerate.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    chelicerate.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    chelicerate.GetComponent<Chelicerate>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //chelicerate.GetComponent<Locomotion>().maxVelocity /= MyModOptions.chelicerateSlowness.Value;
                    chelicerate.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.chelicerateSlowness.Value;
                    chelicerate.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.chelicerateSlowness.Value;
                    chelicerate.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.chelicerateSlowness.Value;
                    chelicerate.GetComponent<Chelicerate>().traitsAnimator.speed /= MyModOptions.chelicerateSlowness.Value;
                }
            }

            if (__instance is ShadowLeviathan shadowLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    shadowLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    shadowLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    shadowLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    shadowLeviathan.GetComponent<ShadowLeviathan>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //shadowLeviathan.GetComponent<Locomotion>().maxVelocity /= MyModOptions.shadowLeviathanSlowness.Value;
                    shadowLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.shadowLeviathanSlowness.Value;
                    shadowLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.shadowLeviathanSlowness.Value;
                    shadowLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.shadowLeviathanSlowness.Value;
                    shadowLeviathan.GetComponent<ShadowLeviathan>().traitsAnimator.speed /= MyModOptions.shadowLeviathanSlowness.Value;
                }
            }

            if (__instance is VoidLeviathan voidLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    voidLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    voidLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    voidLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    voidLeviathan.GetComponent<VoidLeviathan>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //voidLeviathan.GetComponent<Locomotion>().maxVelocity /= MyModOptions.voidLeviathanSlowness.Value;
                    voidLeviathan.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.voidLeviathanSlowness.Value;
                    voidLeviathan.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.voidLeviathanSlowness.Value;
                    voidLeviathan.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.voidLeviathanSlowness.Value;
                    voidLeviathan.GetComponent<VoidLeviathan>().traitsAnimator.speed /= MyModOptions.voidLeviathanSlowness.Value;
                }
            }
            #endregion

            #region Not Fish
            if (__instance is Skyray skyray)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    skyray.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    skyray.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    skyray.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    skyray.GetComponent<Skyray>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //skyray.GetComponent<Locomotion>().maxVelocity /= MyModOptions.skyRaySlowness.Value;
                    skyray.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.skyRaySlowness.Value;
                    skyray.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.skyRaySlowness.Value;
                    skyray.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.skyRaySlowness.Value;
                    skyray.GetComponent<Skyray>().traitsAnimator.speed /= MyModOptions.skyRaySlowness.Value;
                }
            }

            if (__instance is PenguinBaby pengling)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pengling.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    pengling.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    pengling.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    pengling.GetComponent<PenguinBaby>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //pengling.GetComponent<Locomotion>().maxVelocity /= MyModOptions.penglingSlowness.Value;
                    pengling.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.penglingSlowness.Value;
                    pengling.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.penglingSlowness.Value;
                    pengling.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.penglingSlowness.Value;
                    pengling.GetComponent<PenguinBaby>().traitsAnimator.speed /= MyModOptions.penglingSlowness.Value;
                }
            }

            if (__instance is Penguin pengwing)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pengwing.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    pengwing.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    pengwing.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    pengwing.GetComponent<Penguin>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //pengwing.GetComponent<Locomotion>().maxVelocity /= MyModOptions.pengwingSlowness.Value;
                    pengwing.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.pengwingSlowness.Value;
                    pengwing.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.pengwingSlowness.Value;
                    pengwing.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.pengwingSlowness.Value;
                    pengwing.GetComponent<Penguin>().traitsAnimator.speed /= MyModOptions.pengwingSlowness.Value;
                }
            }

            if (__instance is SeaMonkeyBaby seaMonkeyBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaMonkeyBaby.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    seaMonkeyBaby.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaMonkeyBaby.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaMonkeyBaby.GetComponent<SeaMonkeyBaby>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //seaMonkeyBaby.GetComponent<Locomotion>().maxVelocity /= MyModOptions.seaMonkeyBabySlowness.Value;
                    seaMonkeyBaby.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.seaMonkeyBabySlowness.Value;
                    seaMonkeyBaby.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.seaMonkeyBabySlowness.Value;
                    seaMonkeyBaby.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.seaMonkeyBabySlowness.Value;
                    seaMonkeyBaby.GetComponent<SeaMonkeyBaby>().traitsAnimator.speed /= MyModOptions.seaMonkeyBabySlowness.Value;
                }
            }

            if (__instance is SeaMonkey seaMonkey)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaMonkey.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    seaMonkey.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaMonkey.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    seaMonkey.GetComponent<SeaMonkey>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //seaMonkey.GetComponent<Locomotion>().maxVelocity /= MyModOptions.seaMonkeySlowness.Value;
                    seaMonkey.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.seaMonkeySlowness.Value;
                    seaMonkey.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.seaMonkeySlowness.Value;
                    seaMonkey.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.seaMonkeySlowness.Value;
                    seaMonkey.GetComponent<SeaMonkey>().traitsAnimator.speed /= MyModOptions.seaMonkeySlowness.Value;
                }
            }

            if (__instance is SnowStalkerBaby snowStalkerBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    snowStalkerBaby.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    snowStalkerBaby.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    snowStalkerBaby.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    snowStalkerBaby.GetComponent<SnowStalkerBaby>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //snowStalkerBaby.GetComponent<Locomotion>().maxVelocity /= MyModOptions.snowStalkerBabySlowness.Value;
                    snowStalkerBaby.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.snowStalkerBabySlowness.Value;
                    snowStalkerBaby.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.snowStalkerBabySlowness.Value;
                    snowStalkerBaby.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.snowStalkerBabySlowness.Value;
                    snowStalkerBaby.GetComponent<SnowStalkerBaby>().traitsAnimator.speed /= MyModOptions.snowStalkerBabySlowness.Value;
                }
            }

            if (__instance is SnowStalker snowStalker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    snowStalker.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    snowStalker.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    snowStalker.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    snowStalker.GetComponent<SnowStalker>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //snowStalker.GetComponent<Locomotion>().maxVelocity /= MyModOptions.snowStalkerSlowness.Value;
                    snowStalker.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.snowStalkerSlowness.Value;
                    snowStalker.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.snowStalkerSlowness.Value;
                    snowStalker.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.snowStalkerSlowness.Value;
                    snowStalker.GetComponent<SnowStalker>().traitsAnimator.speed /= MyModOptions.snowStalkerSlowness.Value;
                }
            }

            if (__instance is RockPuncher rockPuncher)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rockPuncher.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.proportionalSlowness.Value;
                    rockPuncher.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    rockPuncher.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.proportionalSlowness.Value;
                    rockPuncher.GetComponent<RockPuncher>().traitsAnimator.speed /= MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    //rockPuncher.GetComponent<Locomotion>().maxVelocity /= MyModOptions.rockPuncherSlowness.Value;
                    rockPuncher.GetComponent<Locomotion>().maxAcceleration /= MyModOptions.rockPuncherSlowness.Value;
                    rockPuncher.GetComponent<Locomotion>().forwardRotationSpeed /= MyModOptions.rockPuncherSlowness.Value;
                    rockPuncher.GetComponent<Locomotion>().upRotationSpeed /= MyModOptions.rockPuncherSlowness.Value;
                    rockPuncher.GetComponent<RockPuncher>().traitsAnimator.speed /= MyModOptions.rockPuncherSlowness.Value;
                }
            }
            #endregion
        }
    }
#endif
}
