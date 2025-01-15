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
                    biter.GetComponent<Locomotion>().maxAcceleration = MyModOptions.biterBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    biter.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.biterBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    biter.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.biterBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    biter.GetComponent<Biter>().traitsAnimator.speed = MyModOptions.biterBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    biter.GetComponent<Locomotion>().maxAcceleration = MyModOptions.biterBaseMaxAcceleration.Value / MyModOptions.biterSlowness.Value;
                    biter.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.biterBaseForwardRotationSpeed.Value / MyModOptions.biterSlowness.Value;
                    biter.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.biterBaseUpRotationSpeed.Value / MyModOptions.biterSlowness.Value;
                    biter.GetComponent<Biter>().traitsAnimator.speed = MyModOptions.biterBaseTraitsAnimatorSpeed.Value / MyModOptions.biterSlowness.Value;
                }
            }

            if (__instance is Bladderfish bladderFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bladderFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.bladderFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.bladderFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.bladderFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed = MyModOptions.bladderFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    bladderFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.bladderFishBaseMaxAcceleration.Value / MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.bladderFishBaseForwardRotationSpeed.Value / MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.bladderFishBaseUpRotationSpeed.Value / MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed = MyModOptions.bladderFishBaseTraitsAnimatorSpeed.Value / MyModOptions.bladderFishSlowness.Value;
                }
            }

            if (__instance is Bleeder bleeder)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bleeder.GetComponent<Locomotion>().maxAcceleration = MyModOptions.bleederBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    bleeder.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.bleederBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    bleeder.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.bleederBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    bleeder.GetComponent<Bleeder>().traitsAnimator.speed = MyModOptions.bleederBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    bleeder.GetComponent<Locomotion>().maxAcceleration = MyModOptions.bladderFishBaseMaxAcceleration.Value / MyModOptions.bleederSlowness.Value;
                    bleeder.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.bladderFishBaseForwardRotationSpeed.Value / MyModOptions.bleederSlowness.Value;
                    bleeder.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.bladderFishBaseUpRotationSpeed.Value / MyModOptions.bleederSlowness.Value;
                    bleeder.GetComponent<Bleeder>().traitsAnimator.speed = MyModOptions.bladderFishBaseTraitsAnimatorSpeed.Value / MyModOptions.bleederSlowness.Value;
                }
            }

            if (__instance is BoneShark boneShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boneShark.GetComponent<Locomotion>().maxAcceleration = MyModOptions.boneSharkBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    boneShark.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.boneSharkBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    boneShark.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.boneSharkBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    boneShark.GetComponent<BoneShark>().traitsAnimator.speed = MyModOptions.boneSharkBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    boneShark.GetComponent<Locomotion>().maxAcceleration = MyModOptions.boneSharkBaseMaxAcceleration.Value / MyModOptions.boneSharkSlowness.Value;
                    boneShark.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.boneSharkBaseForwardRotationSpeed.Value / MyModOptions.boneSharkSlowness.Value;
                    boneShark.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.boneSharkBaseUpRotationSpeed.Value / MyModOptions.boneSharkSlowness.Value;
                    boneShark.GetComponent<BoneShark>().traitsAnimator.speed = MyModOptions.boneSharkBaseTraitsAnimatorSpeed.Value / MyModOptions.boneSharkSlowness.Value;
                }
            }

            if (__instance is Boomerang boomerang)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boomerang.GetComponent<Locomotion>().maxAcceleration = MyModOptions.boomerangBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.boomerangBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.boomerangBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Boomerang>().traitsAnimator.speed = MyModOptions.boomerangBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    boomerang.GetComponent<Locomotion>().maxAcceleration = MyModOptions.boomerangBaseMaxAcceleration.Value / MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.boomerangBaseForwardRotationSpeed.Value / MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.boomerangBaseUpRotationSpeed.Value / MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Boomerang>().traitsAnimator.speed = MyModOptions.boomerangBaseTraitsAnimatorSpeed.Value / MyModOptions.boomerangSlowness.Value;
                }
            }

            if (__instance is CaveCrawler caveCrawler)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    caveCrawler.GetComponent<Locomotion>().maxAcceleration = MyModOptions.caveCrawlerBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    caveCrawler.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.caveCrawlerBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    caveCrawler.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.caveCrawlerBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    caveCrawler.GetComponent<CaveCrawler>().traitsAnimator.speed = MyModOptions.caveCrawlerBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    caveCrawler.GetComponent<Locomotion>().maxAcceleration = MyModOptions.caveCrawlerBaseMaxAcceleration.Value / MyModOptions.caveCrawlerSlowness.Value;
                    caveCrawler.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.caveCrawlerBaseForwardRotationSpeed.Value / MyModOptions.caveCrawlerSlowness.Value;
                    caveCrawler.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.caveCrawlerBaseUpRotationSpeed.Value / MyModOptions.caveCrawlerSlowness.Value;
                    caveCrawler.GetComponent<CaveCrawler>().traitsAnimator.speed = MyModOptions.caveCrawlerBaseTraitsAnimatorSpeed.Value / MyModOptions.caveCrawlerSlowness.Value;
                }
            }

            if (__instance is CrabSnake crabSnake)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crabSnake.GetComponent<Locomotion>().maxAcceleration = MyModOptions.crabSnakeBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    crabSnake.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.crabSnakeBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    crabSnake.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.crabSnakeBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    crabSnake.GetComponent<CrabSnake>().traitsAnimator.speed = MyModOptions.crabSnakeBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    crabSnake.GetComponent<Locomotion>().maxAcceleration = MyModOptions.crabSnakeBaseMaxAcceleration.Value / MyModOptions.crabSnakeSlowness.Value;
                    crabSnake.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.crabSnakeBaseForwardRotationSpeed.Value / MyModOptions.crabSnakeSlowness.Value;
                    crabSnake.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.crabSnakeBaseUpRotationSpeed.Value / MyModOptions.crabSnakeSlowness.Value;
                    crabSnake.GetComponent<CrabSnake>().traitsAnimator.speed = MyModOptions.crabSnakeBaseTraitsAnimatorSpeed.Value / MyModOptions.crabSnakeSlowness.Value;
                }
            }

            if (__instance is CrabSquid crabSquid)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crabSquid.GetComponent<Locomotion>().maxAcceleration = MyModOptions.crabSquidBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    crabSquid.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.crabSquidBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    crabSquid.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.crabSquidBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    crabSquid.GetComponent<CrabSquid>().traitsAnimator.speed = MyModOptions.crabSquidBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    crabSquid.GetComponent<Locomotion>().maxAcceleration = MyModOptions.crabSquidBaseMaxAcceleration.Value / MyModOptions.crabSquidSlowness.Value;
                    crabSquid.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.crabSquidBaseForwardRotationSpeed.Value / MyModOptions.crabSquidSlowness.Value;
                    crabSquid.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.crabSquidBaseUpRotationSpeed.Value / MyModOptions.crabSquidSlowness.Value;
                    crabSquid.GetComponent<CrabSquid>().traitsAnimator.speed = MyModOptions.crabSquidBaseTraitsAnimatorSpeed.Value / MyModOptions.crabSquidSlowness.Value;
                }
            }

            if (__instance is Crash crashFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crashFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.crashFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.crashFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.crashFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Crash>().traitsAnimator.speed = MyModOptions.crashFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    crashFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.crashFishBaseMaxAcceleration.Value / MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.crashFishBaseForwardRotationSpeed.Value / MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.crashFishBaseUpRotationSpeed.Value / MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Crash>().traitsAnimator.speed = MyModOptions.crashFishBaseTraitsAnimatorSpeed.Value / MyModOptions.crashFishSlowness.Value;
                }
            }

            if (__instance is CuteFish cuddleFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    cuddleFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.cuddleFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    cuddleFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.cuddleFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    cuddleFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.cuddleFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    cuddleFish.GetComponent<CuteFish>().traitsAnimator.speed = MyModOptions.cuddleFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    cuddleFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.cuddleFishBaseMaxAcceleration.Value / MyModOptions.cuddleFishSlowness.Value;
                    cuddleFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.cuddleFishBaseForwardRotationSpeed.Value / MyModOptions.cuddleFishSlowness.Value;
                    cuddleFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.cuddleFishBaseUpRotationSpeed.Value / MyModOptions.cuddleFishSlowness.Value;
                    cuddleFish.GetComponent<CuteFish>().traitsAnimator.speed = MyModOptions.cuddleFishBaseTraitsAnimatorSpeed.Value / MyModOptions.cuddleFishSlowness.Value;
                }
            }

            if (__instance is Eyeye eyeye)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    eyeye.GetComponent<Locomotion>().maxAcceleration = MyModOptions.eyeyeBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    eyeye.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.eyeyeBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    eyeye.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.eyeyeBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    eyeye.GetComponent<Eyeye>().traitsAnimator.speed = MyModOptions.eyeyeBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    eyeye.GetComponent<Locomotion>().maxAcceleration = MyModOptions.eyeyeBaseMaxAcceleration.Value / MyModOptions.eyeyeSlowness.Value;
                    eyeye.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.eyeyeBaseForwardRotationSpeed.Value / MyModOptions.eyeyeSlowness.Value;
                    eyeye.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.eyeyeBaseUpRotationSpeed.Value / MyModOptions.eyeyeSlowness.Value;
                    eyeye.GetComponent<Eyeye>().traitsAnimator.speed = MyModOptions.eyeyeBaseTraitsAnimatorSpeed.Value / MyModOptions.eyeyeSlowness.Value;
                }
            }

            if (__instance is Garryfish garryFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    garryFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.garryFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    garryFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.garryFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    garryFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.garryFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    garryFish.GetComponent<Garryfish>().traitsAnimator.speed = MyModOptions.garryFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    garryFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.garryFishBaseMaxAcceleration.Value / MyModOptions.garryFishSlowness.Value;
                    garryFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.garryFishBaseForwardRotationSpeed.Value / MyModOptions.garryFishSlowness.Value;
                    garryFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.garryFishBaseUpRotationSpeed.Value / MyModOptions.garryFishSlowness.Value;
                    garryFish.GetComponent<Garryfish>().traitsAnimator.speed = MyModOptions.garryFishBaseTraitsAnimatorSpeed.Value / MyModOptions.garryFishSlowness.Value;
                }
            }

            if (__instance is GasoPod gasopod)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    gasopod.GetComponent<Locomotion>().maxAcceleration = MyModOptions.gasopodBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    gasopod.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.gasopodBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    gasopod.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.gasopodBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    gasopod.GetComponent<GasoPod>().traitsAnimator.speed = MyModOptions.gasopodBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    gasopod.GetComponent<Locomotion>().maxAcceleration = MyModOptions.gasopodBaseMaxAcceleration.Value / MyModOptions.gasopodSlowness.Value;
                    gasopod.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.gasopodBaseForwardRotationSpeed.Value / MyModOptions.gasopodSlowness.Value;
                    gasopod.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.gasopodBaseUpRotationSpeed.Value / MyModOptions.gasopodSlowness.Value;
                    gasopod.GetComponent<GasoPod>().traitsAnimator.speed = MyModOptions.gasopodBaseTraitsAnimatorSpeed.Value / MyModOptions.gasopodSlowness.Value;
                }
            }

            if (__instance is GhostLeviatanVoid voidGhostLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    voidGhostLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.voidGhostLeviathanBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    voidGhostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.voidGhostLeviathanBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    voidGhostLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.voidGhostLeviathanBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    voidGhostLeviathan.GetComponent<GhostLeviatanVoid>().traitsAnimator.speed = MyModOptions.voidGhostLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    voidGhostLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.voidGhostLeviathanBaseMaxAcceleration.Value / MyModOptions.voidGhostLeviathanSlowness.Value;
                    voidGhostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.voidGhostLeviathanBaseForwardRotationSpeed.Value / MyModOptions.voidGhostLeviathanSlowness.Value;
                    voidGhostLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.voidGhostLeviathanBaseUpRotationSpeed.Value / MyModOptions.voidGhostLeviathanSlowness.Value;
                    voidGhostLeviathan.GetComponent<GhostLeviatanVoid>().traitsAnimator.speed = MyModOptions.voidGhostLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.voidGhostLeviathanSlowness.Value;
                }
            }

            if (__instance is GhostLeviathan ghostLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    ghostLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.ghostLeviathanBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    ghostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.ghostLeviathanBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    ghostLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.ghostLeviathanBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    ghostLeviathan.GetComponent<GhostLeviathan>().traitsAnimator.speed = MyModOptions.ghostLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    ghostLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.ghostLeviathanBaseMaxAcceleration.Value / MyModOptions.ghostLeviathanSlowness.Value;
                    ghostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.ghostLeviathanBaseForwardRotationSpeed.Value / MyModOptions.ghostLeviathanSlowness.Value;
                    ghostLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.ghostLeviathanBaseUpRotationSpeed.Value / MyModOptions.ghostLeviathanSlowness.Value;
                    ghostLeviathan.GetComponent<GhostLeviathan>().traitsAnimator.speed = MyModOptions.ghostLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.ghostLeviathanSlowness.Value;
                }
            }

            if (__instance is GhostRay ghostRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    ghostRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.ghostRayBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    ghostRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.ghostRayBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    ghostRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.ghostRayBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    ghostRay.GetComponent<GhostRay>().traitsAnimator.speed = MyModOptions.ghostRayBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    ghostRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.ghostRayBaseMaxAcceleration.Value / MyModOptions.ghostRaySlowness.Value;
                    ghostRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.ghostRayBaseForwardRotationSpeed.Value / MyModOptions.ghostRaySlowness.Value;
                    ghostRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.ghostRayBaseUpRotationSpeed.Value / MyModOptions.ghostRaySlowness.Value;
                    ghostRay.GetComponent<GhostRay>().traitsAnimator.speed = MyModOptions.ghostRayBaseTraitsAnimatorSpeed.Value / MyModOptions.ghostRaySlowness.Value;
                }
            }

            if (__instance is Holefish holeFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    holeFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.holeFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    holeFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.holeFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    holeFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.holeFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    holeFish.GetComponent<Holefish>().traitsAnimator.speed = MyModOptions.holeFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    holeFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.holeFishBaseMaxAcceleration.Value / MyModOptions.holeFishSlowness.Value;
                    holeFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.holeFishBaseForwardRotationSpeed.Value / MyModOptions.holeFishSlowness.Value;
                    holeFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.holeFishBaseUpRotationSpeed.Value / MyModOptions.holeFishSlowness.Value;
                    holeFish.GetComponent<Holefish>().traitsAnimator.speed = MyModOptions.holeFishBaseTraitsAnimatorSpeed.Value / MyModOptions.holeFishSlowness.Value;
                }
            }

            if (__instance is Hoopfish hoopFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoopFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.hoopFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.hoopFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.hoopFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed = MyModOptions.hoopFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    hoopFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.hoopFishBaseMaxAcceleration.Value / MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.hoopFishBaseForwardRotationSpeed.Value / MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.hoopFishBaseUpRotationSpeed.Value / MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed = MyModOptions.hoopFishBaseTraitsAnimatorSpeed.Value / MyModOptions.hoopFishSlowness.Value;
                }
            }

            if (__instance is Hoverfish hoverFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoverFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.hoverFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    hoverFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.hoverFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    hoverFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.hoverFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    hoverFish.GetComponent<Hoverfish>().traitsAnimator.speed = MyModOptions.hoverFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    hoverFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.hoverFishBaseMaxAcceleration.Value / MyModOptions.hoverFishSlowness.Value;
                    hoverFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.hoverFishBaseForwardRotationSpeed.Value / MyModOptions.hoverFishSlowness.Value;
                    hoverFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.hoverFishBaseUpRotationSpeed.Value / MyModOptions.hoverFishSlowness.Value;
                    hoverFish.GetComponent<Hoverfish>().traitsAnimator.speed = MyModOptions.hoverFishBaseTraitsAnimatorSpeed.Value / MyModOptions.hoverFishSlowness.Value;
                }
            }

            if (__instance is Jellyray jellyRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    jellyRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.jellyRayBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    jellyRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.jellyRayBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    jellyRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.jellyRayBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    jellyRay.GetComponent<Jellyray>().traitsAnimator.speed = MyModOptions.jellyRayBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    jellyRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.jellyRayBaseMaxAcceleration.Value / MyModOptions.jellyRaySlowness.Value;
                    jellyRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.jellyRayBaseForwardRotationSpeed.Value / MyModOptions.jellyRaySlowness.Value;
                    jellyRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.jellyRayBaseUpRotationSpeed.Value / MyModOptions.jellyRaySlowness.Value;
                    jellyRay.GetComponent<Jellyray>().traitsAnimator.speed = MyModOptions.jellyRayBaseTraitsAnimatorSpeed.Value / MyModOptions.jellyRaySlowness.Value;
                }
            }

            if (__instance is Jumper jumper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    jumper.GetComponent<Locomotion>().maxAcceleration = MyModOptions.jumperBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    jumper.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.jumperBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    jumper.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.jumperBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    jumper.GetComponent<Jumper>().traitsAnimator.speed = MyModOptions.jumperBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    jumper.GetComponent<Locomotion>().maxAcceleration = MyModOptions.jumperBaseMaxAcceleration.Value / MyModOptions.jumperSlowness.Value;
                    jumper.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.jumperBaseForwardRotationSpeed.Value / MyModOptions.jumperSlowness.Value;
                    jumper.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.jumperBaseUpRotationSpeed.Value / MyModOptions.jumperSlowness.Value;
                    jumper.GetComponent<Jumper>().traitsAnimator.speed = MyModOptions.jumperBaseTraitsAnimatorSpeed.Value / MyModOptions.jumperSlowness.Value;
                }
            }

            if (__instance is LavaLarva lavaLarva)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lavaLarva.GetComponent<Locomotion>().maxAcceleration = MyModOptions.lavaLarvaBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    lavaLarva.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.lavaLarvaBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    lavaLarva.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.lavaLarvaBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    lavaLarva.GetComponent<LavaLarva>().traitsAnimator.speed = MyModOptions.lavaLarvaBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    lavaLarva.GetComponent<Locomotion>().maxAcceleration = MyModOptions.lavaLarvaBaseMaxAcceleration.Value / MyModOptions.lavaLarvaSlowness.Value;
                    lavaLarva.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.lavaLarvaBaseForwardRotationSpeed.Value / MyModOptions.lavaLarvaSlowness.Value;
                    lavaLarva.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.lavaLarvaBaseUpRotationSpeed.Value / MyModOptions.lavaLarvaSlowness.Value;
                    lavaLarva.GetComponent<LavaLarva>().traitsAnimator.speed = MyModOptions.lavaLarvaBaseTraitsAnimatorSpeed.Value / MyModOptions.lavaLarvaSlowness.Value;
                }
            }

            if (__instance is LavaLizard lavaLizard)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lavaLizard.GetComponent<Locomotion>().maxAcceleration = MyModOptions.lavaLizardBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    lavaLizard.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.lavaLizardBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    lavaLizard.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.lavaLizardBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    lavaLizard.GetComponent<LavaLizard>().traitsAnimator.speed = MyModOptions.lavaLizardBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    lavaLizard.GetComponent<Locomotion>().maxAcceleration = MyModOptions.lavaLizardBaseMaxAcceleration.Value / MyModOptions.lavaLizardSlowness.Value;
                    lavaLizard.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.lavaLizardBaseForwardRotationSpeed.Value / MyModOptions.lavaLizardSlowness.Value;
                    lavaLizard.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.lavaLizardBaseUpRotationSpeed.Value / MyModOptions.lavaLizardSlowness.Value;
                    lavaLizard.GetComponent<LavaLizard>().traitsAnimator.speed = MyModOptions.lavaLizardBaseTraitsAnimatorSpeed.Value / MyModOptions.lavaLizardSlowness.Value;
                }
            }

            if (__instance is Mesmer mesmer)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    mesmer.GetComponent<Locomotion>().maxAcceleration = MyModOptions.mesmerBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    mesmer.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.mesmerBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    mesmer.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.mesmerBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    mesmer.GetComponent<Mesmer>().traitsAnimator.speed = MyModOptions.mesmerBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    mesmer.GetComponent<Locomotion>().maxAcceleration = MyModOptions.mesmerBaseMaxAcceleration.Value / MyModOptions.mesmerSlowness.Value;
                    mesmer.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.mesmerBaseForwardRotationSpeed.Value / MyModOptions.mesmerSlowness.Value;
                    mesmer.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.mesmerBaseUpRotationSpeed.Value / MyModOptions.mesmerSlowness.Value;
                    mesmer.GetComponent<Mesmer>().traitsAnimator.speed = MyModOptions.mesmerBaseTraitsAnimatorSpeed.Value / MyModOptions.mesmerSlowness.Value;
                }
            }

            if (__instance is OculusFish oculusFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    oculusFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.oculusFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    oculusFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.oculusFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    oculusFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.oculusFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    oculusFish.GetComponent<OculusFish>().traitsAnimator.speed = MyModOptions.oculusFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    oculusFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.oculusFishBaseMaxAcceleration.Value / MyModOptions.oculusFishSlowness.Value;
                    oculusFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.oculusFishBaseForwardRotationSpeed.Value / MyModOptions.oculusFishSlowness.Value;
                    oculusFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.oculusFishBaseUpRotationSpeed.Value / MyModOptions.oculusFishSlowness.Value;
                    oculusFish.GetComponent<OculusFish>().traitsAnimator.speed = MyModOptions.oculusFishBaseTraitsAnimatorSpeed.Value / MyModOptions.oculusFishSlowness.Value;
                }
            }

            if (__instance is Peeper peeper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    peeper.GetComponent<Locomotion>().maxAcceleration = MyModOptions.peeperBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    peeper.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.peeperBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    peeper.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.peeperBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    peeper.GetComponent<Peeper>().traitsAnimator.speed = MyModOptions.peeperBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    peeper.GetComponent<Locomotion>().maxAcceleration = MyModOptions.peeperBaseMaxAcceleration.Value / MyModOptions.peeperSlowness.Value;
                    peeper.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.peeperBaseForwardRotationSpeed.Value / MyModOptions.peeperSlowness.Value;
                    peeper.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.peeperBaseUpRotationSpeed.Value / MyModOptions.peeperSlowness.Value;
                    peeper.GetComponent<Peeper>().traitsAnimator.speed = MyModOptions.peeperBaseTraitsAnimatorSpeed.Value / MyModOptions.peeperSlowness.Value;
                }
            }

            if (__instance is RabbitRay rabbitRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rabbitRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.rabbitRayBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    rabbitRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.rabbitRayBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    rabbitRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.rabbitRayBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    rabbitRay.GetComponent<RabbitRay>().traitsAnimator.speed = MyModOptions.rabbitRayBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    rabbitRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.rabbitRayBaseMaxAcceleration.Value / MyModOptions.rabbitRaySlowness.Value;
                    rabbitRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.rabbitRayBaseForwardRotationSpeed.Value / MyModOptions.rabbitRaySlowness.Value;
                    rabbitRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.rabbitRayBaseUpRotationSpeed.Value / MyModOptions.rabbitRaySlowness.Value;
                    rabbitRay.GetComponent<RabbitRay>().traitsAnimator.speed = MyModOptions.rabbitRayBaseTraitsAnimatorSpeed.Value / MyModOptions.rabbitRaySlowness.Value;
                }
            }

            if (__instance is ReaperLeviathan reaperLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    reaperLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.reaperLeviathanBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    reaperLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.reaperLeviathanBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    reaperLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.reaperLeviathanBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    reaperLeviathan.GetComponent<ReaperLeviathan>().traitsAnimator.speed = MyModOptions.reaperLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    reaperLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.reaperLeviathanBaseMaxAcceleration.Value / MyModOptions.reaperLeviathanSlowness.Value;
                    reaperLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.reaperLeviathanBaseForwardRotationSpeed.Value / MyModOptions.reaperLeviathanSlowness.Value;
                    reaperLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.reaperLeviathanBaseUpRotationSpeed.Value / MyModOptions.reaperLeviathanSlowness.Value;
                    reaperLeviathan.GetComponent<ReaperLeviathan>().traitsAnimator.speed = MyModOptions.reaperLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.reaperLeviathanSlowness.Value;
                }
            }

            if (__instance is Reefback reefback)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    reefback.GetComponent<Locomotion>().maxAcceleration = MyModOptions.reefbackBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    reefback.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.reefbackBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    reefback.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.reefbackBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    reefback.GetComponent<Reefback>().traitsAnimator.speed = MyModOptions.reefbackBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    reefback.GetComponent<Locomotion>().maxAcceleration = MyModOptions.reefbackBaseMaxAcceleration.Value / MyModOptions.reefbackSlowness.Value;
                    reefback.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.reefbackBaseForwardRotationSpeed.Value / MyModOptions.reefbackSlowness.Value;
                    reefback.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.reefbackBaseUpRotationSpeed.Value / MyModOptions.reefbackSlowness.Value;
                    reefback.GetComponent<Reefback>().traitsAnimator.speed = MyModOptions.reefbackBaseTraitsAnimatorSpeed.Value / MyModOptions.reefbackSlowness.Value;
                }
            }

            if (__instance is Reginald reginald)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    reginald.GetComponent<Locomotion>().maxAcceleration = MyModOptions.reginaldBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    reginald.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.reginaldBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    reginald.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.reginaldBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    reginald.GetComponent<Reginald>().traitsAnimator.speed = MyModOptions.reginaldBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    reginald.GetComponent<Locomotion>().maxAcceleration = MyModOptions.reginaldBaseMaxAcceleration.Value / MyModOptions.reginaldSlowness.Value;
                    reginald.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.reginaldBaseForwardRotationSpeed.Value / MyModOptions.reginaldSlowness.Value;
                    reginald.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.reginaldBaseUpRotationSpeed.Value / MyModOptions.reginaldSlowness.Value;
                    reginald.GetComponent<Reginald>().traitsAnimator.speed = MyModOptions.reginaldBaseTraitsAnimatorSpeed.Value / MyModOptions.reginaldSlowness.Value;
                }
            }

            if (__instance is SandShark sandShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sandShark.GetComponent<Locomotion>().maxAcceleration = MyModOptions.sandSharkBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    sandShark.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.sandSharkBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    sandShark.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.sandSharkBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    sandShark.GetComponent<SandShark>().traitsAnimator.speed = MyModOptions.sandSharkBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    sandShark.GetComponent<Locomotion>().maxAcceleration = MyModOptions.sandSharkBaseMaxAcceleration.Value / MyModOptions.sandSharkSlowness.Value;
                    sandShark.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.sandSharkBaseForwardRotationSpeed.Value / MyModOptions.sandSharkSlowness.Value;
                    sandShark.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.sandSharkBaseUpRotationSpeed.Value / MyModOptions.sandSharkSlowness.Value;
                    sandShark.GetComponent<SandShark>().traitsAnimator.speed = MyModOptions.sandSharkBaseTraitsAnimatorSpeed.Value / MyModOptions.sandSharkSlowness.Value;
                }
            }

            if (__instance is SeaDragon seaDragon)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaDragon.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaDragonBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    seaDragon.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaDragonBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaDragon.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaDragonBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaDragon.GetComponent<SeaDragon>().traitsAnimator.speed = MyModOptions.seaDragonBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaDragon.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaDragonBaseMaxAcceleration.Value / MyModOptions.seaDragonSlowness.Value;
                    seaDragon.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaDragonBaseForwardRotationSpeed.Value / MyModOptions.seaDragonSlowness.Value;
                    seaDragon.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaDragonBaseUpRotationSpeed.Value / MyModOptions.seaDragonSlowness.Value;
                    seaDragon.GetComponent<SeaDragon>().traitsAnimator.speed = MyModOptions.seaDragonBaseTraitsAnimatorSpeed.Value / MyModOptions.seaDragonSlowness.Value;
                }
            }

            if (__instance is SeaEmperorBaby seaEmperorBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaEmperorBaby.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaEmperorBabyBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    seaEmperorBaby.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaEmperorBabyBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaEmperorBaby.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaEmperorBabyBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaEmperorBaby.GetComponent<SeaEmperorBaby>().traitsAnimator.speed = MyModOptions.seaEmperorBabyBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaEmperorBaby.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaEmperorBabyBaseMaxAcceleration.Value / MyModOptions.seaEmperorBabySlowness.Value;
                    seaEmperorBaby.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaEmperorBabyBaseForwardRotationSpeed.Value / MyModOptions.seaEmperorBabySlowness.Value;
                    seaEmperorBaby.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaEmperorBabyBaseUpRotationSpeed.Value / MyModOptions.seaEmperorBabySlowness.Value;
                    seaEmperorBaby.GetComponent<SeaEmperorBaby>().traitsAnimator.speed = MyModOptions.seaEmperorBabyBaseTraitsAnimatorSpeed.Value / MyModOptions.seaEmperorBabySlowness.Value;
                }
            }

            if (__instance is SeaEmperorJuvenile seaEmperorJuvenile)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaEmperorJuvenile.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaEmperorJuvenileBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    seaEmperorJuvenile.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaEmperorJuvenileBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaEmperorJuvenile.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaEmperorJuvenileBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaEmperorJuvenile.GetComponent<SeaEmperorJuvenile>().traitsAnimator.speed = MyModOptions.seaEmperorJuvenileBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaEmperorJuvenile.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaEmperorJuvenileBaseMaxAcceleration.Value / MyModOptions.seaEmperorJuvenileSlowness.Value;
                    seaEmperorJuvenile.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaEmperorJuvenileBaseForwardRotationSpeed.Value / MyModOptions.seaEmperorJuvenileSlowness.Value;
                    seaEmperorJuvenile.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaEmperorJuvenileBaseUpRotationSpeed.Value / MyModOptions.seaEmperorJuvenileSlowness.Value;
                    seaEmperorJuvenile.GetComponent<SeaEmperorJuvenile>().traitsAnimator.speed = MyModOptions.seaEmperorJuvenileBaseTraitsAnimatorSpeed.Value / MyModOptions.seaEmperorJuvenileSlowness.Value;
                }
            }

            if (__instance is SeaTreader seaTreader)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaTreader.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaTreaderBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    seaTreader.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaTreaderBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaTreader.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaTreaderBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaTreader.GetComponent<SeaTreader>().traitsAnimator.speed = MyModOptions.seaTreaderBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaTreader.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaTreaderBaseMaxAcceleration.Value / MyModOptions.seaTreaderSlowness.Value;
                    seaTreader.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaTreaderBaseForwardRotationSpeed.Value / MyModOptions.seaTreaderSlowness.Value;
                    seaTreader.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaTreaderBaseUpRotationSpeed.Value / MyModOptions.seaTreaderSlowness.Value;
                    seaTreader.GetComponent<SeaTreader>().traitsAnimator.speed = MyModOptions.seaTreaderBaseTraitsAnimatorSpeed.Value / MyModOptions.seaTreaderSlowness.Value;
                }
            }

            if (__instance is Shocker shocker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    shocker.GetComponent<Locomotion>().maxAcceleration = MyModOptions.shockerBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    shocker.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.shockerBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    shocker.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.shockerBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    shocker.GetComponent<Shocker>().traitsAnimator.speed = MyModOptions.shockerBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    shocker.GetComponent<Locomotion>().maxAcceleration = MyModOptions.shockerBaseMaxAcceleration.Value / MyModOptions.shockerSlowness.Value;
                    shocker.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.shockerBaseForwardRotationSpeed.Value / MyModOptions.shockerSlowness.Value;
                    shocker.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.shockerBaseUpRotationSpeed.Value / MyModOptions.shockerSlowness.Value;
                    shocker.GetComponent<Shocker>().traitsAnimator.speed = MyModOptions.shockerBaseTraitsAnimatorSpeed.Value / MyModOptions.shockerSlowness.Value;
                }
            }

            if (__instance is Spadefish spadeFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    spadeFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.spadeFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    spadeFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.spadeFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    spadeFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.spadeFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    spadeFish.GetComponent<Spadefish>().traitsAnimator.speed = MyModOptions.spadeFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    spadeFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.spadeFishBaseMaxAcceleration.Value / MyModOptions.spadeFishSlowness.Value;
                    spadeFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.spadeFishBaseForwardRotationSpeed.Value / MyModOptions.spadeFishSlowness.Value;
                    spadeFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.spadeFishBaseUpRotationSpeed.Value / MyModOptions.spadeFishSlowness.Value;
                    spadeFish.GetComponent<Spadefish>().traitsAnimator.speed = MyModOptions.spadeFishBaseTraitsAnimatorSpeed.Value / MyModOptions.spadeFishSlowness.Value;
                }
            }

            if (__instance is SpineEel spineEel)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    spineEel.GetComponent<Locomotion>().maxAcceleration = MyModOptions.spineEelBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    spineEel.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.spineEelBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    spineEel.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.spineEelBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    spineEel.GetComponent<SpineEel>().traitsAnimator.speed = MyModOptions.spineEelBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    spineEel.GetComponent<Locomotion>().maxAcceleration = MyModOptions.spineEelBaseMaxAcceleration.Value / MyModOptions.spineEelSlowness.Value;
                    spineEel.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.spineEelBaseForwardRotationSpeed.Value / MyModOptions.spineEelSlowness.Value;
                    spineEel.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.spineEelBaseUpRotationSpeed.Value / MyModOptions.spineEelSlowness.Value;
                    spineEel.GetComponent<SpineEel>().traitsAnimator.speed = MyModOptions.spineEelBaseTraitsAnimatorSpeed.Value / MyModOptions.spineEelSlowness.Value;
                }
            }

            if (__instance is Stalker stalker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    stalker.GetComponent<Locomotion>().maxAcceleration = MyModOptions.stalkerBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    stalker.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.stalkerBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    stalker.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.stalkerBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    stalker.GetComponent<Stalker>().traitsAnimator.speed = MyModOptions.stalkerBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    stalker.GetComponent<Locomotion>().maxAcceleration = MyModOptions.stalkerBaseMaxAcceleration.Value / MyModOptions.stalkerSlowness.Value;
                    stalker.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.stalkerBaseForwardRotationSpeed.Value / MyModOptions.stalkerSlowness.Value;
                    stalker.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.stalkerBaseUpRotationSpeed.Value / MyModOptions.stalkerSlowness.Value;
                    stalker.GetComponent<Stalker>().traitsAnimator.speed = MyModOptions.stalkerBaseTraitsAnimatorSpeed.Value / MyModOptions.stalkerSlowness.Value;
                }
            }

            if (__instance is Warper warper)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    warper.GetComponent<Locomotion>().maxAcceleration = MyModOptions.warperBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    warper.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.warperBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    warper.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.warperBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    warper.GetComponent<Warper>().traitsAnimator.speed = MyModOptions.warperBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    warper.GetComponent<Locomotion>().maxAcceleration = MyModOptions.warperBaseMaxAcceleration.Value / MyModOptions.warperSlowness.Value;
                    warper.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.warperBaseForwardRotationSpeed.Value / MyModOptions.warperSlowness.Value;
                    warper.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.warperBaseUpRotationSpeed.Value / MyModOptions.warperSlowness.Value;
                    warper.GetComponent<Warper>().traitsAnimator.speed = MyModOptions.warperBaseTraitsAnimatorSpeed.Value / MyModOptions.warperSlowness.Value;
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
                    arcticPeeper.GetComponent<Locomotion>().maxAcceleration = MyModOptions.arcticPeeperBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    arcticPeeper.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.arcticPeeperBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    arcticPeeper.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.arcticPeeperBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    arcticPeeper.GetComponent<ArcticPeeper>().traitsAnimator.speed = MyModOptions.arcticPeeperBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    arcticPeeper.GetComponent<Locomotion>().maxAcceleration = MyModOptions.arcticPeeperBaseMaxAcceleration.Value / MyModOptions.arcticPeeperSlowness.Value;
                    arcticPeeper.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.arcticPeeperBaseUpRotationSpeed.Value / MyModOptions.arcticPeeperSlowness.Value;
                    arcticPeeper.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.arcticPeeperBaseForwardRotationSpeed.Value / MyModOptions.arcticPeeperSlowness.Value;
                    arcticPeeper.GetComponent<ArcticPeeper>().traitsAnimator.speed = MyModOptions.arcticPeeperBaseTraitsAnimatorSpeed.Value / MyModOptions.arcticPeeperSlowness.Value;
                }
            }

            if (__instance is ArrowRay arrowRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arrowRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.arrowRayBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    arrowRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.arrowRayBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    arrowRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.arrowRayBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    arrowRay.GetComponent<ArrowRay>().traitsAnimator.speed = MyModOptions.arrowRayBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    arrowRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.arrowRayBaseMaxAcceleration.Value / MyModOptions.arrowRaySlowness.Value;
                    arrowRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.arrowRayBaseUpRotationSpeed.Value / MyModOptions.arrowRaySlowness.Value;
                    arrowRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.arrowRayBaseForwardRotationSpeed.Value / MyModOptions.arrowRaySlowness.Value;
                    arrowRay.GetComponent<ArrowRay>().traitsAnimator.speed = MyModOptions.arrowRayBaseTraitsAnimatorSpeed.Value / MyModOptions.arrowRaySlowness.Value;
                }
            }

            if (__instance is Boomerang boomerang)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    boomerang.GetComponent<Locomotion>().maxAcceleration = MyModOptions.boomerangBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.boomerangBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.boomerangBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    boomerang.GetComponent<Boomerang>().traitsAnimator.speed = MyModOptions.boomerangBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    boomerang.GetComponent<Locomotion>().maxAcceleration = MyModOptions.boomerangBaseMaxAcceleration.Value / MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.boomerangBaseUpRotationSpeed.Value / MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.boomerangBaseForwardRotationSpeed.Value / MyModOptions.boomerangSlowness.Value;
                    boomerang.GetComponent<Boomerang>().traitsAnimator.speed = MyModOptions.boomerangBaseTraitsAnimatorSpeed.Value / MyModOptions.boomerangSlowness.Value;
                }
            }

            if (__instance is Bladderfish bladderFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bladderFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.bladderFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.bladderFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.bladderFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed = MyModOptions.bladderFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    bladderFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.bladderFishBaseMaxAcceleration.Value / MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.bladderFishBaseUpRotationSpeed.Value / MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.bladderFishBaseForwardRotationSpeed.Value / MyModOptions.bladderFishSlowness.Value;
                    bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed = MyModOptions.bladderFishBaseTraitsAnimatorSpeed.Value / MyModOptions.bladderFishSlowness.Value;
                }
            }

            if (__instance is Hoopfish hoopFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    hoopFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.hoopFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.hoopFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.hoopFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed = MyModOptions.hoopFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    hoopFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.hoopFishBaseMaxAcceleration.Value / MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.hoopFishBaseUpRotationSpeed.Value / MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.hoopFishBaseForwardRotationSpeed.Value / MyModOptions.hoopFishSlowness.Value;
                    hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed = MyModOptions.hoopFishBaseTraitsAnimatorSpeed.Value / MyModOptions.hoopFishSlowness.Value;
                }
            }

            if (__instance is DiscusFish discusFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    discusFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.discusFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    discusFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.discusFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    discusFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.discusFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    discusFish.GetComponent<DiscusFish>().traitsAnimator.speed = MyModOptions.discusFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    discusFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.discusFishBaseMaxAcceleration.Value / MyModOptions.discusFishSlowness.Value;
                    discusFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.discusFishBaseUpRotationSpeed.Value / MyModOptions.discusFishSlowness.Value;
                    discusFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.discusFishBaseForwardRotationSpeed.Value / MyModOptions.discusFishSlowness.Value;
                    discusFish.GetComponent<DiscusFish>().traitsAnimator.speed = MyModOptions.discusFishBaseTraitsAnimatorSpeed.Value / MyModOptions.discusFishSlowness.Value;
                }
            }

            if (__instance is FeatherFish featherFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    featherFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.featherFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    featherFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.featherFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    featherFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.featherFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    featherFish.GetComponent<FeatherFish>().traitsAnimator.speed = MyModOptions.featherFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    featherFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.featherFishBaseMaxAcceleration.Value / MyModOptions.featherFishSlowness.Value;
                    featherFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.featherFishBaseUpRotationSpeed.Value / MyModOptions.featherFishSlowness.Value;
                    featherFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.featherFishBaseForwardRotationSpeed.Value / MyModOptions.featherFishSlowness.Value;
                    featherFish.GetComponent<FeatherFish>().traitsAnimator.speed = MyModOptions.featherFishBaseTraitsAnimatorSpeed.Value / MyModOptions.featherFishSlowness.Value;
                }
            }

            if (__instance is NootFish nootFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    nootFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.nootFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    nootFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.nootFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    nootFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.nootFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    nootFish.GetComponent<NootFish>().traitsAnimator.speed = MyModOptions.nootFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    nootFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.nootFishBaseMaxAcceleration.Value / MyModOptions.nootFishSlowness.Value;
                    nootFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.nootFishBaseUpRotationSpeed.Value / MyModOptions.nootFishSlowness.Value;
                    nootFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.nootFishBaseForwardRotationSpeed.Value / MyModOptions.nootFishSlowness.Value;
                    nootFish.GetComponent<NootFish>().traitsAnimator.speed = MyModOptions.nootFishBaseTraitsAnimatorSpeed.Value / MyModOptions.nootFishSlowness.Value;
                }
            }

            if (__instance is SpinnerFish spinnerFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    spinnerFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.spinnerFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    spinnerFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.spinnerFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    spinnerFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.spinnerFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    spinnerFish.GetComponent<SpinnerFish>().traitsAnimator.speed = MyModOptions.spinnerFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    spinnerFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.spinnerFishBaseMaxAcceleration.Value / MyModOptions.spinnerFishSlowness.Value;
                    spinnerFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.spinnerFishBaseUpRotationSpeed.Value / MyModOptions.spinnerFishSlowness.Value;
                    spinnerFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.spinnerFishBaseForwardRotationSpeed.Value / MyModOptions.spinnerFishSlowness.Value;
                    spinnerFish.GetComponent<SpinnerFish>().traitsAnimator.speed = MyModOptions.spinnerFishBaseTraitsAnimatorSpeed.Value / MyModOptions.spinnerFishSlowness.Value;
                }
            }

            if (__instance is ArcticRay arcticRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    arcticRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.arcticRayBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    arcticRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.arcticRayBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    arcticRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.arcticRayBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    arcticRay.GetComponent<ArcticRay>().traitsAnimator.speed = MyModOptions.arcticRayBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    arcticRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.arcticRayBaseMaxAcceleration.Value / MyModOptions.arcticRaySlowness.Value;
                    arcticRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.arcticRayBaseUpRotationSpeed.Value / MyModOptions.arcticRaySlowness.Value;
                    arcticRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.arcticRayBaseForwardRotationSpeed.Value / MyModOptions.arcticRaySlowness.Value;
                    arcticRay.GetComponent<ArcticRay>().traitsAnimator.speed = MyModOptions.arcticRayBaseTraitsAnimatorSpeed.Value / MyModOptions.arcticRaySlowness.Value;
                }
            }

            if (__instance is Jellyfish jellyFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    jellyFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.jellyFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    jellyFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.jellyFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    jellyFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.jellyFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    jellyFish.GetComponent<Jellyfish>().traitsAnimator.speed = MyModOptions.jellyFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    jellyFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.jellyFishBaseMaxAcceleration.Value / MyModOptions.jellyFishSlowness.Value;
                    jellyFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.jellyFishBaseUpRotationSpeed.Value / MyModOptions.jellyFishSlowness.Value;
                    jellyFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.jellyFishBaseForwardRotationSpeed.Value / MyModOptions.jellyFishSlowness.Value;
                    jellyFish.GetComponent<Jellyfish>().traitsAnimator.speed = MyModOptions.jellyFishBaseTraitsAnimatorSpeed.Value / MyModOptions.jellyFishSlowness.Value;
                }
            }

            if (__instance is TitanHolefish titanHoleFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    titanHoleFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.titanHoleFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    titanHoleFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.titanHoleFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    titanHoleFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.titanHoleFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    titanHoleFish.GetComponent<TitanHolefish>().traitsAnimator.speed = MyModOptions.titanHoleFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    titanHoleFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.titanHoleFishBaseMaxAcceleration.Value / MyModOptions.titanHoleFishSlowness.Value;
                    titanHoleFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.titanHoleFishBaseUpRotationSpeed.Value / MyModOptions.titanHoleFishSlowness.Value;
                    titanHoleFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.titanHoleFishBaseForwardRotationSpeed.Value / MyModOptions.titanHoleFishSlowness.Value;
                    titanHoleFish.GetComponent<TitanHolefish>().traitsAnimator.speed = MyModOptions.titanHoleFishBaseTraitsAnimatorSpeed.Value / MyModOptions.titanHoleFishSlowness.Value;
                }
            }

            if (__instance is GlowWhale glowWhale)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    glowWhale.GetComponent<Locomotion>().maxAcceleration = MyModOptions.glowWhaleBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    glowWhale.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.glowWhaleBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    glowWhale.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.glowWhaleBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    glowWhale.GetComponent<GlowWhale>().traitsAnimator.speed = MyModOptions.glowWhaleBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    glowWhale.GetComponent<Locomotion>().maxAcceleration = MyModOptions.glowWhaleBaseMaxAcceleration.Value / MyModOptions.glowWhaleSlowness.Value;
                    glowWhale.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.glowWhaleBaseUpRotationSpeed.Value / MyModOptions.glowWhaleSlowness.Value;
                    glowWhale.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.glowWhaleBaseForwardRotationSpeed.Value / MyModOptions.glowWhaleSlowness.Value;
                    glowWhale.GetComponent<GlowWhale>().traitsAnimator.speed = MyModOptions.glowWhaleBaseTraitsAnimatorSpeed.Value / MyModOptions.glowWhaleSlowness.Value;
                }
            }

            if (__instance is Pinnacarid pinnacarid)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pinnacarid.GetComponent<Locomotion>().maxAcceleration = MyModOptions.pinnacaridBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    pinnacarid.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.pinnacaridBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    pinnacarid.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.pinnacaridBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    pinnacarid.GetComponent<Pinnacarid>().traitsAnimator.speed = MyModOptions.pinnacaridBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    pinnacarid.GetComponent<Locomotion>().maxAcceleration = MyModOptions.pinnacaridBaseMaxAcceleration.Value / MyModOptions.pinnacaridSlowness.Value;
                    pinnacarid.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.pinnacaridBaseUpRotationSpeed.Value / MyModOptions.pinnacaridSlowness.Value;
                    pinnacarid.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.pinnacaridBaseForwardRotationSpeed.Value / MyModOptions.pinnacaridSlowness.Value;
                    pinnacarid.GetComponent<Pinnacarid>().traitsAnimator.speed = MyModOptions.pinnacaridBaseTraitsAnimatorSpeed.Value / MyModOptions.pinnacaridSlowness.Value;
                }
            }

            if (__instance is Triops triops)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    triops.GetComponent<Locomotion>().maxAcceleration = MyModOptions.triopsBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    triops.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.triopsBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    triops.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.triopsBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    triops.GetComponent<Triops>().traitsAnimator.speed = MyModOptions.triopsBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    triops.GetComponent<Locomotion>().maxAcceleration = MyModOptions.triopsBaseMaxAcceleration.Value / MyModOptions.triopsSlowness.Value;
                    triops.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.triopsBaseUpRotationSpeed.Value / MyModOptions.triopsSlowness.Value;
                    triops.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.triopsBaseForwardRotationSpeed.Value / MyModOptions.triopsSlowness.Value;
                    triops.GetComponent<Triops>().traitsAnimator.speed = MyModOptions.triopsBaseTraitsAnimatorSpeed.Value / MyModOptions.triopsSlowness.Value;
                }
            }

            if (__instance is Trivalve trivalve)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    trivalve.GetComponent<Locomotion>().maxAcceleration = MyModOptions.trivalveBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    trivalve.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.trivalveBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    trivalve.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.trivalveBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    trivalve.GetComponent<Trivalve>().traitsAnimator.speed = MyModOptions.trivalveBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    trivalve.GetComponent<Locomotion>().maxAcceleration = MyModOptions.trivalveBaseMaxAcceleration.Value / MyModOptions.trivalveSlowness.Value;
                    trivalve.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.trivalveBaseUpRotationSpeed.Value / MyModOptions.trivalveSlowness.Value;
                    trivalve.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.trivalveBaseForwardRotationSpeed.Value / MyModOptions.trivalveSlowness.Value;
                    trivalve.GetComponent<Trivalve>().traitsAnimator.speed = MyModOptions.trivalveBaseTraitsAnimatorSpeed.Value / MyModOptions.trivalveSlowness.Value;
                }
            }

            if (__instance is SymbioteFish symbioteFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    symbioteFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.symbioteFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    symbioteFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.symbioteFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    symbioteFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.symbioteFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    symbioteFish.GetComponent<SymbioteFish>().traitsAnimator.speed = MyModOptions.symbioteFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    symbioteFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.symbioteFishBaseMaxAcceleration.Value / MyModOptions.symbioteFishSlowness.Value;
                    symbioteFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.symbioteFishBaseUpRotationSpeed.Value / MyModOptions.symbioteFishSlowness.Value;
                    symbioteFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.symbioteFishBaseForwardRotationSpeed.Value / MyModOptions.symbioteFishSlowness.Value;
                    symbioteFish.GetComponent<SymbioteFish>().traitsAnimator.speed = MyModOptions.symbioteFishBaseTraitsAnimatorSpeed.Value / MyModOptions.symbioteFishSlowness.Value;
                }
            }

            if (__instance is RockGrub rockGrub)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rockGrub.GetComponent<Locomotion>().maxAcceleration = MyModOptions.rockGrubBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    rockGrub.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.rockGrubBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    rockGrub.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.rockGrubBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    rockGrub.GetComponent<RockGrub>().traitsAnimator.speed = MyModOptions.rockGrubBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    rockGrub.GetComponent<Locomotion>().maxAcceleration = MyModOptions.rockGrubBaseMaxAcceleration.Value / MyModOptions.rockGrubSlowness.Value;
                    rockGrub.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.rockGrubBaseUpRotationSpeed.Value / MyModOptions.rockGrubSlowness.Value;
                    rockGrub.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.rockGrubBaseForwardRotationSpeed.Value / MyModOptions.rockGrubSlowness.Value;
                    rockGrub.GetComponent<RockGrub>().traitsAnimator.speed = MyModOptions.rockGrubBaseTraitsAnimatorSpeed.Value / MyModOptions.rockGrubSlowness.Value;
                }
            }
            #endregion

            #region Aggressive Fish
            if (__instance is Crash crashFish)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    crashFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.crashFishBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.crashFishBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.crashFishBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    crashFish.GetComponent<Crash>().traitsAnimator.speed = MyModOptions.crashFishBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    crashFish.GetComponent<Locomotion>().maxAcceleration = MyModOptions.crashFishBaseMaxAcceleration.Value / MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.crashFishBaseUpRotationSpeed.Value / MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.crashFishBaseForwardRotationSpeed.Value / MyModOptions.crashFishSlowness.Value;
                    crashFish.GetComponent<Crash>().traitsAnimator.speed = MyModOptions.crashFishBaseTraitsAnimatorSpeed.Value / MyModOptions.crashFishSlowness.Value;
                }
            }

            if (__instance is Brinewing brineWing)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    brineWing.GetComponent<Locomotion>().maxAcceleration = MyModOptions.brineWingBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    brineWing.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.brineWingBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    brineWing.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.brineWingBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    brineWing.GetComponent<Brinewing>().traitsAnimator.speed = MyModOptions.brineWingBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    brineWing.GetComponent<Locomotion>().maxAcceleration = MyModOptions.brineWingBaseMaxAcceleration.Value / MyModOptions.brineWingSlowness.Value;
                    brineWing.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.brineWingBaseUpRotationSpeed.Value / MyModOptions.brineWingSlowness.Value;
                    brineWing.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.brineWingBaseForwardRotationSpeed.Value / MyModOptions.brineWingSlowness.Value;
                    brineWing.GetComponent<Brinewing>().traitsAnimator.speed = MyModOptions.brineWingBaseTraitsAnimatorSpeed.Value / MyModOptions.brineWingSlowness.Value;
                }
            }

            if (__instance is LilyPaddler lilyPaddler)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    lilyPaddler.GetComponent<Locomotion>().maxAcceleration = MyModOptions.lilyPaddlerBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    lilyPaddler.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.lilyPaddlerBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    lilyPaddler.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.lilyPaddlerBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    lilyPaddler.GetComponent<LilyPaddler>().traitsAnimator.speed = MyModOptions.lilyPaddlerBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    lilyPaddler.GetComponent<Locomotion>().maxAcceleration = MyModOptions.lilyPaddlerBaseMaxAcceleration.Value / MyModOptions.lilyPaddlerSlowness.Value;
                    lilyPaddler.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.lilyPaddlerBaseUpRotationSpeed.Value / MyModOptions.lilyPaddlerSlowness.Value;
                    lilyPaddler.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.lilyPaddlerBaseForwardRotationSpeed.Value / MyModOptions.lilyPaddlerSlowness.Value;
                    lilyPaddler.GetComponent<LilyPaddler>().traitsAnimator.speed = MyModOptions.lilyPaddlerBaseTraitsAnimatorSpeed.Value / MyModOptions.lilyPaddlerSlowness.Value;
                }
            }

            if (__instance is Cryptosuchus cryptosuchus)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    cryptosuchus.GetComponent<Locomotion>().maxAcceleration = MyModOptions.cryptosuchusBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    cryptosuchus.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.cryptosuchusBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    cryptosuchus.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.cryptosuchusBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    cryptosuchus.GetComponent<Cryptosuchus>().traitsAnimator.speed = MyModOptions.cryptosuchusBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    cryptosuchus.GetComponent<Locomotion>().maxAcceleration = MyModOptions.cryptosuchusBaseMaxAcceleration.Value / MyModOptions.cryptosuchusSlowness.Value;
                    cryptosuchus.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.cryptosuchusBaseUpRotationSpeed.Value / MyModOptions.cryptosuchusSlowness.Value;
                    cryptosuchus.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.cryptosuchusBaseForwardRotationSpeed.Value / MyModOptions.cryptosuchusSlowness.Value;
                    cryptosuchus.GetComponent<Cryptosuchus>().traitsAnimator.speed = MyModOptions.cryptosuchusBaseTraitsAnimatorSpeed.Value / MyModOptions.cryptosuchusSlowness.Value;
                }
            }

            if (__instance is BruteShark bruteShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    bruteShark.GetComponent<Locomotion>().maxAcceleration = MyModOptions.bruteSharkBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    bruteShark.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.bruteSharkBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    bruteShark.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.bruteSharkBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    bruteShark.GetComponent<BruteShark>().traitsAnimator.speed = MyModOptions.bruteSharkBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    bruteShark.GetComponent<Locomotion>().maxAcceleration = MyModOptions.bruteSharkBaseMaxAcceleration.Value / MyModOptions.bruteSharkSlowness.Value;
                    bruteShark.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.bruteSharkBaseUpRotationSpeed.Value / MyModOptions.bruteSharkSlowness.Value;
                    bruteShark.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.bruteSharkBaseForwardRotationSpeed.Value / MyModOptions.bruteSharkSlowness.Value;
                    bruteShark.GetComponent<BruteShark>().traitsAnimator.speed = MyModOptions.bruteSharkBaseTraitsAnimatorSpeed.Value / MyModOptions.bruteSharkSlowness.Value;
                }
            }

            if (__instance is SquidShark squidShark)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    squidShark.GetComponent<Locomotion>().maxAcceleration = MyModOptions.squidSharkBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    squidShark.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.squidSharkBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    squidShark.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.squidSharkBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    squidShark.GetComponent<SquidShark>().traitsAnimator.speed = MyModOptions.squidSharkBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    squidShark.GetComponent<Locomotion>().maxAcceleration = MyModOptions.squidSharkBaseMaxAcceleration.Value / MyModOptions.squidSharkSlowness.Value;
                    squidShark.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.squidSharkBaseUpRotationSpeed.Value / MyModOptions.squidSharkSlowness.Value;
                    squidShark.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.squidSharkBaseForwardRotationSpeed.Value / MyModOptions.squidSharkSlowness.Value;
                    squidShark.GetComponent<SquidShark>().traitsAnimator.speed = MyModOptions.squidSharkBaseTraitsAnimatorSpeed.Value / MyModOptions.squidSharkSlowness.Value;
                }
            }

            if (__instance is Chelicerate chelicerate)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    chelicerate.GetComponent<Locomotion>().maxAcceleration = MyModOptions.chelicerateBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    chelicerate.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.chelicerateBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    chelicerate.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.chelicerateBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    chelicerate.GetComponent<Chelicerate>().traitsAnimator.speed = MyModOptions.chelicerateBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    chelicerate.GetComponent<Locomotion>().maxAcceleration = MyModOptions.chelicerateBaseMaxAcceleration.Value / MyModOptions.chelicerateSlowness.Value;
                    chelicerate.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.chelicerateBaseUpRotationSpeed.Value / MyModOptions.chelicerateSlowness.Value;
                    chelicerate.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.chelicerateBaseForwardRotationSpeed.Value / MyModOptions.chelicerateSlowness.Value;
                    chelicerate.GetComponent<Chelicerate>().traitsAnimator.speed = MyModOptions.chelicerateBaseTraitsAnimatorSpeed.Value / MyModOptions.chelicerateSlowness.Value;
                }
            }

            if (__instance is ShadowLeviathan shadowLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    shadowLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.shadowLeviathanBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    shadowLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.shadowLeviathanBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    shadowLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.shadowLeviathanBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    shadowLeviathan.GetComponent<ShadowLeviathan>().traitsAnimator.speed = MyModOptions.shadowLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    shadowLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.shadowLeviathanBaseMaxAcceleration.Value / MyModOptions.shadowLeviathanSlowness.Value;
                    shadowLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.shadowLeviathanBaseUpRotationSpeed.Value / MyModOptions.shadowLeviathanSlowness.Value;
                    shadowLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.shadowLeviathanBaseForwardRotationSpeed.Value / MyModOptions.shadowLeviathanSlowness.Value;
                    shadowLeviathan.GetComponent<ShadowLeviathan>().traitsAnimator.speed = MyModOptions.shadowLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.shadowLeviathanSlowness.Value;
                }
            }

            if (__instance is VoidLeviathan voidLeviathan)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    voidLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.voidLeviathanBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    voidLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.voidLeviathanBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    voidLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.voidLeviathanBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    voidLeviathan.GetComponent<VoidLeviathan>().traitsAnimator.speed = MyModOptions.voidLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    voidLeviathan.GetComponent<Locomotion>().maxAcceleration = MyModOptions.voidLeviathanBaseMaxAcceleration.Value / MyModOptions.voidLeviathanSlowness.Value;
                    voidLeviathan.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.voidLeviathanBaseUpRotationSpeed.Value / MyModOptions.voidLeviathanSlowness.Value;
                    voidLeviathan.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.voidLeviathanBaseForwardRotationSpeed.Value / MyModOptions.voidLeviathanSlowness.Value;
                    voidLeviathan.GetComponent<VoidLeviathan>().traitsAnimator.speed = MyModOptions.voidLeviathanBaseTraitsAnimatorSpeed.Value / MyModOptions.voidLeviathanSlowness.Value;
                }
            }
            #endregion

            #region Not Fish
            if (__instance is Skyray skyRay)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    skyRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.skyRayBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    skyRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.skyRayBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    skyRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.skyRayBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    skyRay.GetComponent<Skyray>().traitsAnimator.speed = MyModOptions.skyRayBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    skyRay.GetComponent<Locomotion>().maxAcceleration = MyModOptions.skyRayBaseMaxAcceleration.Value / MyModOptions.skyRaySlowness.Value;
                    skyRay.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.skyRayBaseUpRotationSpeed.Value / MyModOptions.skyRaySlowness.Value;
                    skyRay.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.skyRayBaseForwardRotationSpeed.Value / MyModOptions.skyRaySlowness.Value;
                    skyRay.GetComponent<Skyray>().traitsAnimator.speed = MyModOptions.skyRayBaseTraitsAnimatorSpeed.Value / MyModOptions.skyRaySlowness.Value;
                }
            }

            if (__instance is PenguinBaby pengling)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pengling.GetComponent<Locomotion>().maxAcceleration = MyModOptions.penglingBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    pengling.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.penglingBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    pengling.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.penglingBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    pengling.GetComponent<PenguinBaby>().traitsAnimator.speed = MyModOptions.penglingBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    pengling.GetComponent<Locomotion>().maxAcceleration = MyModOptions.penglingBaseMaxAcceleration.Value / MyModOptions.penglingSlowness.Value;
                    pengling.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.penglingBaseUpRotationSpeed.Value / MyModOptions.penglingSlowness.Value;
                    pengling.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.penglingBaseForwardRotationSpeed.Value / MyModOptions.penglingSlowness.Value;
                    pengling.GetComponent<PenguinBaby>().traitsAnimator.speed = MyModOptions.penglingBaseTraitsAnimatorSpeed.Value / MyModOptions.penglingSlowness.Value;
                }
            }

            if (__instance is Penguin pengwing)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    pengwing.GetComponent<Locomotion>().maxAcceleration = MyModOptions.pengwingBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    pengwing.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.pengwingBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    pengwing.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.pengwingBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    pengwing.GetComponent<Penguin>().traitsAnimator.speed = MyModOptions.pengwingBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    pengwing.GetComponent<Locomotion>().maxAcceleration = MyModOptions.pengwingBaseMaxAcceleration.Value / MyModOptions.pengwingSlowness.Value;
                    pengwing.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.pengwingBaseUpRotationSpeed.Value / MyModOptions.pengwingSlowness.Value;
                    pengwing.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.pengwingBaseForwardRotationSpeed.Value / MyModOptions.pengwingSlowness.Value;
                    pengwing.GetComponent<Penguin>().traitsAnimator.speed = MyModOptions.pengwingBaseTraitsAnimatorSpeed.Value / MyModOptions.pengwingSlowness.Value;
                }
            }

            if (__instance is SeaMonkeyBaby seaMonkeyBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaMonkeyBaby.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaMonkeyBabyBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    seaMonkeyBaby.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaMonkeyBabyBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaMonkeyBaby.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaMonkeyBabyBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaMonkeyBaby.GetComponent<SeaMonkeyBaby>().traitsAnimator.speed = MyModOptions.seaMonkeyBabyBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaMonkeyBaby.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaMonkeyBabyBaseMaxAcceleration.Value / MyModOptions.seaMonkeyBabySlowness.Value;
                    seaMonkeyBaby.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaMonkeyBabyBaseUpRotationSpeed.Value / MyModOptions.seaMonkeyBabySlowness.Value;
                    seaMonkeyBaby.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaMonkeyBabyBaseForwardRotationSpeed.Value / MyModOptions.seaMonkeyBabySlowness.Value;
                    seaMonkeyBaby.GetComponent<SeaMonkeyBaby>().traitsAnimator.speed = MyModOptions.seaMonkeyBabyBaseTraitsAnimatorSpeed.Value / MyModOptions.seaMonkeyBabySlowness.Value;
                }
            }

            if (__instance is SeaMonkey seaMonkey)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    seaMonkey.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaMonkeyBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    seaMonkey.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaMonkeyBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaMonkey.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaMonkeyBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    seaMonkey.GetComponent<SeaMonkey>().traitsAnimator.speed = MyModOptions.seaMonkeyBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    seaMonkey.GetComponent<Locomotion>().maxAcceleration = MyModOptions.seaMonkeyBaseMaxAcceleration.Value / MyModOptions.seaMonkeySlowness.Value;
                    seaMonkey.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.seaMonkeyBaseUpRotationSpeed.Value / MyModOptions.seaMonkeySlowness.Value;
                    seaMonkey.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.seaMonkeyBaseForwardRotationSpeed.Value / MyModOptions.seaMonkeySlowness.Value;
                    seaMonkey.GetComponent<SeaMonkey>().traitsAnimator.speed = MyModOptions.seaMonkeyBaseTraitsAnimatorSpeed.Value / MyModOptions.seaMonkeySlowness.Value;
                }
            }

            if (__instance is SnowStalkerBaby snowStalkerBaby)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    snowStalkerBaby.GetComponent<Locomotion>().maxAcceleration = MyModOptions.snowStalkerBabyBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    snowStalkerBaby.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.snowStalkerBabyBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    snowStalkerBaby.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.snowStalkerBabyBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    snowStalkerBaby.GetComponent<SnowStalkerBaby>().traitsAnimator.speed = MyModOptions.snowStalkerBabyBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    snowStalkerBaby.GetComponent<Locomotion>().maxAcceleration = MyModOptions.snowStalkerBabyBaseMaxAcceleration.Value / MyModOptions.snowStalkerBabySlowness.Value;
                    snowStalkerBaby.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.snowStalkerBabyBaseUpRotationSpeed.Value / MyModOptions.snowStalkerBabySlowness.Value;
                    snowStalkerBaby.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.snowStalkerBabyBaseForwardRotationSpeed.Value / MyModOptions.snowStalkerBabySlowness.Value;
                    snowStalkerBaby.GetComponent<SnowStalkerBaby>().traitsAnimator.speed = MyModOptions.snowStalkerBabyBaseTraitsAnimatorSpeed.Value / MyModOptions.snowStalkerBabySlowness.Value;
                }
            }

            if (__instance is SnowStalker snowStalker)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    snowStalker.GetComponent<Locomotion>().maxAcceleration = MyModOptions.snowStalkerBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    snowStalker.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.snowStalkerBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    snowStalker.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.snowStalkerBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    snowStalker.GetComponent<SnowStalker>().traitsAnimator.speed = MyModOptions.snowStalkerBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    snowStalker.GetComponent<Locomotion>().maxAcceleration = MyModOptions.snowStalkerBaseMaxAcceleration.Value / MyModOptions.snowStalkerSlowness.Value;
                    snowStalker.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.snowStalkerBaseUpRotationSpeed.Value / MyModOptions.snowStalkerSlowness.Value;
                    snowStalker.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.snowStalkerBaseForwardRotationSpeed.Value / MyModOptions.snowStalkerSlowness.Value;
                    snowStalker.GetComponent<SnowStalker>().traitsAnimator.speed = MyModOptions.snowStalkerBaseTraitsAnimatorSpeed.Value / MyModOptions.snowStalkerSlowness.Value;
                }
            }

            if (__instance is RockPuncher rockPuncher)
            {
                if (MyModOptions.proportionalToggle.Value == true)
                {
                    rockPuncher.GetComponent<Locomotion>().maxAcceleration = MyModOptions.rockPuncherBaseMaxAcceleration.Value / MyModOptions.proportionalSlowness.Value;
                    rockPuncher.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.rockPuncherBaseUpRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    rockPuncher.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.rockPuncherBaseForwardRotationSpeed.Value / MyModOptions.proportionalSlowness.Value;
                    rockPuncher.GetComponent<RockPuncher>().traitsAnimator.speed = MyModOptions.rockPuncherBaseTraitsAnimatorSpeed.Value / MyModOptions.proportionalSlowness.Value;
                }
                else
                {
                    rockPuncher.GetComponent<Locomotion>().maxAcceleration = MyModOptions.rockPuncherBaseMaxAcceleration.Value / MyModOptions.rockPuncherSlowness.Value;
                    rockPuncher.GetComponent<Locomotion>().upRotationSpeed = MyModOptions.rockPuncherBaseUpRotationSpeed.Value / MyModOptions.rockPuncherSlowness.Value;
                    rockPuncher.GetComponent<Locomotion>().forwardRotationSpeed = MyModOptions.rockPuncherBaseForwardRotationSpeed.Value / MyModOptions.rockPuncherSlowness.Value;
                    rockPuncher.GetComponent<RockPuncher>().traitsAnimator.speed = MyModOptions.rockPuncherBaseTraitsAnimatorSpeed.Value / MyModOptions.rockPuncherSlowness.Value;
                }
            }
            #endregion
        }
    }
#endif
}
