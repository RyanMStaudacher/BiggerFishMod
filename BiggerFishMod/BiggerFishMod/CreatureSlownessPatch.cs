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
