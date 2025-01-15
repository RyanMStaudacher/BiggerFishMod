using HarmonyLib;

namespace BiggerFishMod
{
#if SUBNAUTICA
    [HarmonyPatch(typeof(Creature), nameof(Creature.InitializeOnce))]
    internal class CreatureValuesPatch
    {
        [HarmonyPostfix]
        public static void InitializeCreatureBaseValues(Creature __instance)
        {
            if (__instance is Biter biter)
            {
                MyModOptions.biterBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Biter Values", "Biter Base Health", biter.liveMixin.health);
                MyModOptions.biterBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Biter Values", "Biter Base Max Acceleration", biter.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.biterBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Biter Values", "Biter Base Up Rotation Speed", biter.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.biterBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Biter Values", "Biter Base Forward Rotation Speed", biter.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.biterBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Biter Values", "Biter Base Traits Animator Speed", biter.GetComponent<Biter>().traitsAnimator.speed);
            }

            if (__instance is Bladderfish bladderFish)
            {
                MyModOptions.bladderFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Base Health", bladderFish.liveMixin.health);
                MyModOptions.bladderFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Base Max Acceleration", bladderFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.bladderFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Base Up Rotation Speed", bladderFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.bladderFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Base Forward Rotation Speed", bladderFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.bladderFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Base Traits Animator Speed", bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed);
            }

            if (__instance is Bleeder bleeder)
            {
                MyModOptions.bleederBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Base Health", bleeder.liveMixin.health);
                MyModOptions.bleederBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Base Max Acceleration", bleeder.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.bleederBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Base Up Rotation Speed", bleeder.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.bleederBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Base Forward Rotation Speed", bleeder.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.bleederBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Base Traits Animator Speed", bleeder.GetComponent<Bleeder>().traitsAnimator.speed);
            }

            if (__instance is BoneShark boneShark)
            {
                MyModOptions.boneSharkBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Base Health", boneShark.liveMixin.health);
                MyModOptions.boneSharkBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Base Max Acceleration", boneShark.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.boneSharkBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Base Up Rotation Speed", boneShark.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.boneSharkBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Base Forward Rotation Speed", boneShark.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.boneSharkBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Base Traits Animator Speed", boneShark.GetComponent<BoneShark>().traitsAnimator.speed);
            }

            if (__instance is Boomerang boomerang)
            {
                MyModOptions.boomerangBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Base Health", boomerang.liveMixin.health);
                MyModOptions.boomerangBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Base Max Acceleration", boomerang.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.boomerangBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Base Up Rotation Speed", boomerang.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.boomerangBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Base Forward Rotation Speed", boomerang.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.boomerangBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang", "Boomerang Base Traits Animator Speed", boomerang.GetComponent<Boomerang>().traitsAnimator.speed);
            }

            if (__instance is CaveCrawler caveCrawler)
            {
                MyModOptions.caveCrawlerBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Base Health", caveCrawler.liveMixin.health);
                MyModOptions.caveCrawlerBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Base Max Acceleration", caveCrawler.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.caveCrawlerBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Base Up Rotation Speed", caveCrawler.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.caveCrawlerBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Base Forward Rotation Speed", caveCrawler.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.caveCrawlerBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Base Traits Animator Speed", caveCrawler.GetComponent<CaveCrawler>().traitsAnimator.speed);
            }

            if (__instance is CrabSnake crabSnake)
            {
                MyModOptions.crabSnakeBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Base Health", crabSnake.liveMixin.health);
                MyModOptions.crabSnakeBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Base Max Acceleration", crabSnake.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.crabSnakeBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Base Up Rotation Speed", crabSnake.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.crabSnakeBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Base Forward Rotation Speed", crabSnake.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.crabSnakeBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Base Traits Animator Speed", crabSnake.GetComponent<CrabSnake>().traitsAnimator.speed);
            }

            if (__instance is CrabSquid crabSquid)
            {
                MyModOptions.crabSquidBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Base Health", crabSquid.liveMixin.health);
                MyModOptions.crabSquidBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Base Max Acceleration", crabSquid.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.crabSquidBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Base Up Rotation Speed", crabSquid.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.crabSquidBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Base Forward Rotation Speed", crabSquid.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.crabSquidBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Base Traits Animator Speed", crabSquid.GetComponent<CrabSquid>().traitsAnimator.speed);
            }

            if (__instance is Crash crashFish)
            {
                MyModOptions.crashFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Base Health", crashFish.liveMixin.health);
                MyModOptions.crashFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Base Max Acceleration", crashFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.crashFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Base Up Rotation Speed", crashFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.crashFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Base Forward Rotation Speed", crashFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.crashFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Base Traits Animator Speed", crashFish.GetComponent<Crash>().traitsAnimator.speed);
            }

            if (__instance is CuteFish cuddleFish)
            {
                MyModOptions.cuddleFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Base Health", cuddleFish.liveMixin.health);
                MyModOptions.cuddleFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Base Max Acceleration", cuddleFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.cuddleFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Base Up Rotation Speed", cuddleFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.cuddleFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Base Forward Rotation Speed", cuddleFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.cuddleFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Base Traits Animator Speed", cuddleFish.GetComponent<CuteFish>().traitsAnimator.speed);
            }

            if (__instance is Eyeye eyeye)
            {
                MyModOptions.eyeyeBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Base Health", eyeye.liveMixin.health);
                MyModOptions.eyeyeBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Base Max Acceleration", eyeye.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.eyeyeBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Base Up Rotation Speed", eyeye.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.eyeyeBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Base Forward Rotation Speed", eyeye.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.eyeyeBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Base Traits Animator Speed", eyeye.GetComponent<Eyeye>().traitsAnimator.speed);
            }

            if (__instance is Garryfish garryFish)
            {
                MyModOptions.garryFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Base Health", garryFish.liveMixin.health);
                MyModOptions.garryFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Base Max Acceleration", garryFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.garryFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Base Up Rotation Speed", garryFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.garryFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Base Forward Rotation Speed", garryFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.garryFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Base Traits Animator Speed", garryFish.GetComponent<Garryfish>().traitsAnimator.speed);
            }

            if (__instance is GasoPod gasopod)
            {
                MyModOptions.gasopodBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Base Health", gasopod.liveMixin.health);
                MyModOptions.gasopodBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Base Max Acceleration", gasopod.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.gasopodBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Base Up Rotation Speed", gasopod.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.gasopodBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Base Forward Rotation Speed", gasopod.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.gasopodBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Base Traits Animator Speed", gasopod.GetComponent<GasoPod>().traitsAnimator.speed);
            }

            if (__instance is GhostLeviatanVoid voidGhostLeviathan)
            {
                MyModOptions.voidGhostLeviathanBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Base Health", voidGhostLeviathan.liveMixin.health);
                MyModOptions.voidGhostLeviathanBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Base Max Acceleration", voidGhostLeviathan.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.voidGhostLeviathanBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Base Up Rotation Speed", voidGhostLeviathan.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.voidGhostLeviathanBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Base Forward Rotation Speed", voidGhostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.voidGhostLeviathanBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Base Traits Animator Speed", voidGhostLeviathan.GetComponent<GhostLeviatanVoid>().traitsAnimator.speed);
            }

            if (__instance is GhostLeviathan ghostLeviathan)
            {
                MyModOptions.ghostLeviathanBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Base Health", ghostLeviathan.liveMixin.health);
                MyModOptions.ghostLeviathanBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Base Max Acceleration", ghostLeviathan.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.ghostLeviathanBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Base Up Rotation Speed", ghostLeviathan.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.ghostLeviathanBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Base Forward Rotation Speed", ghostLeviathan.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.ghostLeviathanBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Base Traits Animator Speed", ghostLeviathan.GetComponent<GhostLeviathan>().traitsAnimator.speed);
            }

            if (__instance is GhostRay ghostRay)
            {
                MyModOptions.ghostRayBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Base Health", ghostRay.liveMixin.health);
                MyModOptions.ghostRayBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Base Max Acceleration", ghostRay.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.ghostRayBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Base Up Rotation Speed", ghostRay.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.ghostRayBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Base Forward Rotation Speed", ghostRay.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.ghostRayBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Base Traits Animator Speed", ghostRay.GetComponent<GhostRay>().traitsAnimator.speed);
            }

            if (__instance is Holefish holeFish)
            {
                MyModOptions.holeFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Holefish Values", "Holefish Base Health", holeFish.liveMixin.health);
                MyModOptions.holeFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Holefish Values", "Holefish Base Max Acceleration", holeFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.holeFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Holefish Values", "Holefish Base Up Rotation Speed", holeFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.holeFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Holefish Values", "Holefish Base Forward Rotation Speed", holeFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.holeFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Holefish Values", "Holefish Base Traits Animator Speed", holeFish.GetComponent<Holefish>().traitsAnimator.speed);
            }

            if (__instance is Hoopfish hoopFish)
            {
                MyModOptions.hoopFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Health", hoopFish.liveMixin.health);
                MyModOptions.hoopFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Max Acceleration", hoopFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.hoopFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Up Rotation Speed", hoopFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.hoopFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Forward Rotation Speed", hoopFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.hoopFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Traits Animator Speed", hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed);
            }

            if (__instance is Hoverfish hoverFish)
            {
                MyModOptions.hoverFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Hoverfish Values", "Hoverfish Base Health", hoverFish.liveMixin.health);
                MyModOptions.hoverFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Hoverfish Values", "Hoverfish Base Max Acceleration", hoverFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.hoverFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Hoverfish Values", "Hoverfish Base Up Rotation Speed", hoverFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.hoverFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Hoverfish Values", "Hoverfish Base Forward Rotation Speed", hoverFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.hoverFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Hoverfish Values", "Hoverfish Base Traits Animator Speed", hoverFish.GetComponent<Hoverfish>().traitsAnimator.speed);
            }

            if (__instance is Jellyray jellyRay)
            {
                MyModOptions.jellyRayBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Base Health", jellyRay.liveMixin.health);
                MyModOptions.jellyRayBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Base Max Acceleration", jellyRay.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.jellyRayBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Base Up Rotation Speed", jellyRay.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.jellyRayBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Base Forward Rotation Speed", jellyRay.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.jellyRayBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Base Traits Animator Speed", jellyRay.GetComponent<Jellyray>().traitsAnimator.speed);
            }

            if (__instance is Jumper jumper)
            {
                MyModOptions.jumperBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Base Health", jumper.liveMixin.health);
                MyModOptions.jumperBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Base Max Acceleration", jumper.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.jumperBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Base Up Rotation Speed", jumper.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.jumperBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Base Forward Rotation Speed", jumper.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.jumperBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Base Traits Animator Speed", jumper.GetComponent<Jumper>().traitsAnimator.speed);
            }

            if (__instance is LavaLarva lavaLarva)
            {
                MyModOptions.lavaLarvaBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Base Health", lavaLarva.liveMixin.health);
                MyModOptions.lavaLarvaBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Base Max Acceleration", lavaLarva.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.lavaLarvaBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Base Up Rotation Speed", lavaLarva.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.lavaLarvaBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Base Forward Rotation Speed", lavaLarva.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.lavaLarvaBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Base Traits Animator Speed", lavaLarva.GetComponent<LavaLarva>().traitsAnimator.speed);
            }

            if (__instance is LavaLizard lavaLizard)
            {
                MyModOptions.lavaLizardBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Base Health", lavaLizard.liveMixin.health);
                MyModOptions.lavaLizardBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Base Max Acceleration", lavaLizard.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.lavaLizardBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Base Up Rotation Speed", lavaLizard.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.lavaLizardBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Base Forward Rotation Speed", lavaLizard.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.lavaLizardBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Base Traits Animator Speed", lavaLizard.GetComponent<LavaLizard>().traitsAnimator.speed);
            }

            if (__instance is Mesmer mesmer)
            {
                MyModOptions.mesmerBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Base Health", mesmer.liveMixin.health);
                MyModOptions.mesmerBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Base Max Acceleration", mesmer.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.mesmerBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Base Up Rotation Speed", mesmer.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.mesmerBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Base Forward Rotation Speed", mesmer.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.mesmerBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Base Traits Animator Speed", mesmer.GetComponent<Mesmer>().traitsAnimator.speed);
            }

            if (__instance is OculusFish oculusFish)
            {
                MyModOptions.oculusFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Base Health", oculusFish.liveMixin.health);
                MyModOptions.oculusFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Base Max Acceleration", oculusFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.oculusFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Base Up Rotation Speed", oculusFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.oculusFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Base Forward Rotation Speed", oculusFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.oculusFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Base Traits Animator Speed", oculusFish.GetComponent<OculusFish>().traitsAnimator.speed);
            }

            if (__instance is Peeper peeper)
            {
                MyModOptions.peeperBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Base Health", peeper.liveMixin.health);
                MyModOptions.peeperBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Base Max Acceleration", peeper.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.peeperBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Base Up Rotation Speed", peeper.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.peeperBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Base Forward Rotation Speed", peeper.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.peeperBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Base Traits Animator Speed", peeper.GetComponent<Peeper>().traitsAnimator.speed);
            }

            if (__instance is RabbitRay rabbitRay)
            {
                MyModOptions.rabbitRayBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Base Health", rabbitRay.liveMixin.health);
                MyModOptions.rabbitRayBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Base Max Acceleration", rabbitRay.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.rabbitRayBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Base Up Rotation Speed", rabbitRay.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.rabbitRayBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Base Forward Rotation Speed", rabbitRay.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.rabbitRayBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Base Traits Animator Speed", rabbitRay.GetComponent<RabbitRay>().traitsAnimator.speed);
            }

            if (__instance is ReaperLeviathan reaperLeviathan)
            {
                MyModOptions.reaperLeviathanBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Base Health", reaperLeviathan.liveMixin.health);
                MyModOptions.reaperLeviathanBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Base Max Acceleration", reaperLeviathan.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.reaperLeviathanBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Base Up Rotation Speed", reaperLeviathan.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.reaperLeviathanBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Base Forward Rotation Speed", reaperLeviathan.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.reaperLeviathanBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Base Traits Animator Speed", reaperLeviathan.GetComponent<ReaperLeviathan>().traitsAnimator.speed);
            }

            if (__instance is Reefback reefback)
            {
                MyModOptions.reefbackBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Base Health", reefback.liveMixin.health);
                MyModOptions.reefbackBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Base Max Acceleration", reefback.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.reefbackBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Base Up Rotation Speed", reefback.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.reefbackBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Base Forward Rotation Speed", reefback.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.reefbackBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Base Traits Animator Speed", reefback.GetComponent<Reefback>().traitsAnimator.speed);
            }

            if (__instance is Reginald reginald)
            {
                MyModOptions.reginaldBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Base Health", reginald.liveMixin.health);
                MyModOptions.reginaldBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Base Max Acceleration", reginald.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.reginaldBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Base Up Rotation Speed", reginald.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.reginaldBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Base Forward Rotation Speed", reginald.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.reginaldBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Base Traits Animator Speed", reginald.GetComponent<Reginald>().traitsAnimator.speed);
            }

            if (__instance is SandShark sandShark)
            {
                MyModOptions.sandSharkBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Base Health", sandShark.liveMixin.health);
                MyModOptions.sandSharkBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Base Max Acceleration", sandShark.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.sandSharkBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Base Up Rotation Speed", sandShark.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.sandSharkBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Base Forward Rotation Speed", sandShark.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.sandSharkBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Base Traits Animator Speed", sandShark.GetComponent<SandShark>().traitsAnimator.speed);
            }

            if (__instance is SeaDragon seaDragon)
            {
                MyModOptions.seaDragonBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Base Health", seaDragon.liveMixin.health);
                MyModOptions.seaDragonBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Base Max Acceleration", seaDragon.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.seaDragonBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Base Up Rotation Speed", seaDragon.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.seaDragonBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Base Forward Rotation Speed", seaDragon.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.seaDragonBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Base Traits Animator Speed", seaDragon.GetComponent<SeaDragon>().traitsAnimator.speed);
            }

            if (__instance is SeaEmperorBaby seaEmporerBaby)
            {
                MyModOptions.seaEmperorBabyBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Base Health", seaEmporerBaby.liveMixin.health);
                MyModOptions.seaEmperorBabyBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Base Max Acceleration", seaEmporerBaby.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.seaEmperorBabyBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Base Up Rotation Speed", seaEmporerBaby.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.seaEmperorBabyBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Base Forward Rotation Speed", seaEmporerBaby.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.seaEmperorBabyBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Base Traits Animator Speed", seaEmporerBaby.GetComponent<SeaEmperorBaby>().traitsAnimator.speed);
            }

            if (__instance is SeaEmperorJuvenile seaEmporerJuvenile)
            {
                MyModOptions.seaEmperorJuvenileBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Base Health", seaEmporerJuvenile.liveMixin.health);
                MyModOptions.seaEmperorJuvenileBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Base Max Acceleration", seaEmporerJuvenile.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.seaEmperorJuvenileBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Base Up Rotation Speed", seaEmporerJuvenile.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.seaEmperorJuvenileBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Base Forward Rotation Speed", seaEmporerJuvenile.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.seaEmperorJuvenileBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Base Traits Animator Speed", seaEmporerJuvenile.GetComponent<SeaEmperorJuvenile>().traitsAnimator.speed);
            }

            if (__instance is SeaTreader seaTreader)
            {
                MyModOptions.seaTreaderBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Base Health", seaTreader.liveMixin.health);
                MyModOptions.seaTreaderBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Base Max Acceleration", seaTreader.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.seaTreaderBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Base Up Rotation Speed", seaTreader.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.seaTreaderBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Base Forward Rotation Speed", seaTreader.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.seaTreaderBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Base Traits Animator Speed", seaTreader.GetComponent<SeaTreader>().traitsAnimator.speed);
            }

            if (__instance is Shocker shocker)
            {
                MyModOptions.shockerBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Shocker Values", "Shocker Base Health", shocker.liveMixin.health);
                MyModOptions.shockerBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Shocker Values", "Shocker Base Max Acceleration", shocker.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.shockerBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Shocker Values", "Shocker Base Up Rotation Speed", shocker.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.shockerBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Shocker Values", "Shocker Base Forward Rotation Speed", shocker.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.shockerBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Shocker Values", "Shocker Base Traits Animator Speed", shocker.GetComponent<Shocker>().traitsAnimator.speed);
            }

            if (__instance is Spadefish spadeFish)
            {
                MyModOptions.spadeFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Spadefish Values", "Spadefish Base Health", spadeFish.liveMixin.health);
                MyModOptions.spadeFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Spadefish Values", "Spadefish Base Max Acceleration", spadeFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.spadeFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Spadefish Values", "Spadefish Base Up Rotation Speed", spadeFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.spadeFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Spadefish Values", "Spadefish Base Forward Rotation Speed", spadeFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.spadeFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Spadefish Values", "Spadefish Base Traits Animator Speed", spadeFish.GetComponent<Spadefish>().traitsAnimator.speed);
            }

            if (__instance is SpineEel spineEel)
            {
                MyModOptions.spineEelBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Base Health", spineEel.liveMixin.health);
                MyModOptions.spineEelBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Base Max Acceleration", spineEel.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.spineEelBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Base Up Rotation Speed", spineEel.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.spineEelBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Base Forward Rotation Speed", spineEel.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.spineEelBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Base Traits Animator Speed", spineEel.GetComponent<SpineEel>().traitsAnimator.speed);
            }

            if (__instance is Stalker stalker)
            {
                MyModOptions.stalkerBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Base Health", stalker.liveMixin.health);
                MyModOptions.stalkerBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Base Max Acceleration", stalker.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.stalkerBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Base Up Rotation Speed", stalker.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.stalkerBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Base Forward Rotation Speed", stalker.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.stalkerBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Base Traits Animator Speed", stalker.GetComponent<Stalker>().traitsAnimator.speed);
            }

            if (__instance is Warper warper)
            {
                MyModOptions.warperBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Warper Values", "Warper Base Health", warper.liveMixin.health);
                MyModOptions.warperBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Warper Values", "Warper Base Max Acceleration", warper.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.warperBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Warper Values", "Warper Base Up Rotation Speed", warper.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.warperBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Warper Values", "Warper Base Forward Rotation Speed", warper.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.warperBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Warper Values", "Warper Base Traits Animator Speed", warper.GetComponent<Warper>().traitsAnimator.speed);
            }
        }
    }
#endif

#if SUBNAUTICAZERO
    [HarmonyPatch(typeof(Creature), nameof(Creature.InitializeOnce))]
    internal class CreatureValuesPatch
    {
        [HarmonyPostfix]
        public static void InitializeCreatureBaseValues(Creature __instance)
        {
            #region Passive Fish
            if (__instance is ArcticPeeper arcticPeeper)
            {
                MyModOptions.arcticPeeperBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Peeper Values", "Arctic Peeper Base Health", arcticPeeper.liveMixin.health);
                MyModOptions.arcticPeeperBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Peeper Values", "Arctic Peeper Base Max Acceleration", arcticPeeper.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.arcticPeeperBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Peeper Values", "Arctic Peeper Base Up Rotation Speed", arcticPeeper.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.arcticPeeperBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Peeper Values", "Arctic Peeper Base Forward Rotation Speed", arcticPeeper.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.arcticPeeperBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Peeper Values", "Arctic Peeper Base Traits Animator Speed", arcticPeeper.GetComponent<ArcticPeeper>().traitsAnimator.speed);
            }

            if (__instance is ArrowRay arrowRay)
            {
                MyModOptions.arrowRayBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Arrow Ray Values", "Arrow Ray Base Health", arrowRay.liveMixin.health);
                MyModOptions.arrowRayBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Arrow Ray Values", "Arrow Ray Base Max Acceleration", arrowRay.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.arrowRayBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Arrow Ray Values", "Arrow Ray Base Up Rotation Speed", arrowRay.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.arrowRayBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Arrow Ray Values", "Arrow Ray Base Forward Rotation Speed", arrowRay.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.arrowRayBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Arrow Ray Values", "Arrow Ray Base Traits Animator Speed", arrowRay.GetComponent<ArrowRay>().traitsAnimator.speed);
            }

            if (__instance is Boomerang boomerang)
            {
                MyModOptions.boomerangBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Base Health", boomerang.liveMixin.health);
                MyModOptions.boomerangBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Base Max Acceleration", boomerang.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.boomerangBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Base Up Rotation Speed", boomerang.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.boomerangBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Base Forward Rotation Speed", boomerang.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.boomerangBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Base Traits Animator Speed", boomerang.GetComponent<Boomerang>().traitsAnimator.speed);
            }

            if (__instance is Bladderfish bladderFish)
            {
                MyModOptions.bladderFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("BladderFish Values", "BladderFish Base Health", bladderFish.liveMixin.health);
                MyModOptions.bladderFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("BladderFish Values", "BladderFish Base Max Acceleration", bladderFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.bladderFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("BladderFish Values", "BladderFish Base Up Rotation Speed", bladderFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.bladderFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("BladderFish Values", "BladderFish Base Forward Rotation Speed", bladderFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.bladderFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("BladderFish Values", "BladderFish Base Traits Animator Speed", bladderFish.GetComponent<Bladderfish>().traitsAnimator.speed);
            }

            if (__instance is Hoopfish hoopFish)
            {
                MyModOptions.hoopFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Health", hoopFish.liveMixin.health);
                MyModOptions.hoopFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Max Acceleration", hoopFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.hoopFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Up Rotation Speed", hoopFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.hoopFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Forward Rotation Speed", hoopFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.hoopFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Base Traits Animator Speed", hoopFish.GetComponent<Hoopfish>().traitsAnimator.speed);
            }

            if (__instance is DiscusFish discusFish)
            {
                MyModOptions.discusFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Discusfish Values", "Discusfish Base Health", discusFish.liveMixin.health);
                MyModOptions.discusFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Discusfish Values", "Discusfish Base Max Acceleration", discusFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.discusFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Discusfish Values", "Discusfish Base Up Rotation Speed", discusFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.discusFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Discusfish Values", "Discusfish Base Forward Rotation Speed", discusFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.discusFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Discusfish Values", "Discusfish Base Traits Animator Speed", discusFish.GetComponent<DiscusFish>().traitsAnimator.speed);
            }

            if (__instance is FeatherFish featherFish)
            {
                MyModOptions.featherFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Featherfish Values", "Featherfish Base Health", featherFish.liveMixin.health);
                MyModOptions.featherFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Featherfish Values", "Featherfish Base Max Acceleration", featherFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.featherFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Featherfish Values", "Featherfish Base Up Rotation Speed", featherFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.featherFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Featherfish Values", "Featherfish Base Forward Rotation Speed", featherFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.featherFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Featherfish Values", "Featherfish Base Traits Animator Speed", featherFish.GetComponent<FeatherFish>().traitsAnimator.speed);
            }

            if (__instance is NootFish nootFish)
            {
                MyModOptions.nootFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Nootfish Values", "Nootfish Base Health", nootFish.liveMixin.health);
                MyModOptions.nootFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Nootfish Values", "Nootfish Base Max Acceleration", nootFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.nootFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Nootfish Values", "Nootfish Base Up Rotation Speed", nootFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.nootFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Nootfish Values", "Nootfish Base Forward Rotation Speed", nootFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.nootFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Nootfish Values", "Nootfish Base Traits Animator Speed", nootFish.GetComponent<NootFish>().traitsAnimator.speed);
            }

            if (__instance is SpinnerFish spinnerFish)
            {
                MyModOptions.spinnerFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Spinnerfish Values", "Spinnerfish Base Health", spinnerFish.liveMixin.health);
                MyModOptions.spinnerFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Spinnerfish Values", "Spinnerfish Base Max Acceleration", spinnerFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.spinnerFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Spinnerfish Values", "Spinnerfish Base Up Rotation Speed", spinnerFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.spinnerFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Spinnerfish Values", "Spinnerfish Base Forward Rotation Speed", spinnerFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.spinnerFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Spinnerfish Values", "Spinnerfish Base Traits Animator Speed", spinnerFish.GetComponent<SpinnerFish>().traitsAnimator.speed);
            }

            if (__instance is ArcticRay arcticRay)
            {
                MyModOptions.arcticRayBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Ray Values", "Arctic Ray Base Health", arcticRay.liveMixin.health);
                MyModOptions.arcticRayBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Ray Values", "Arctic Ray Base Max Acceleration", arcticRay.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.arcticRayBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Ray Values", "Arctic Ray Base Up Rotation Speed", arcticRay.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.arcticRayBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Ray Values", "Arctic Ray Base Forward Rotation Speed", arcticRay.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.arcticRayBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Arctic Ray Values", "Arctic Ray Base Traits Animator Speed", arcticRay.GetComponent<ArcticRay>().traitsAnimator.speed);
            }

            if (__instance is Jellyfish jellyFish)
            {
                MyModOptions.jellyFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Eye Jelly Values", "Eye Jelly Base Health", jellyFish.liveMixin.health);
                MyModOptions.jellyFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Eye Jelly Values", "Eye Jelly Base Max Acceleration", jellyFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.jellyFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Eye Jelly Values", "Eye Jelly Base Up Rotation Speed", jellyFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.jellyFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Eye Jelly Values", "Eye Jelly Base Forward Rotation Speed", jellyFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.jellyFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Eye Jelly Values", "Eye Jelly Base Traits Animator Speed", jellyFish.GetComponent<Jellyfish>().traitsAnimator.speed);
            }

            if (__instance is TitanHolefish titanHoleFish)
            {
                MyModOptions.titanHoleFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Titan Hole Fish Values", "Titan Hole Fish Base Health", titanHoleFish.liveMixin.health);
                MyModOptions.titanHoleFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Titan Hole Fish Values", "Titan Hole Fish Base Max Acceleration", titanHoleFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.titanHoleFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Titan Hole Fish Values", "Titan Hole Fish Base Up Rotation Speed", titanHoleFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.titanHoleFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Titan Hole Fish Values", "Titan Hole Fish Base Forward Rotation Speed", titanHoleFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.titanHoleFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Titan Hole Fish Values", "Titan Hole Fish Base Traits Animator Speed", titanHoleFish.GetComponent<TitanHolefish>().traitsAnimator.speed);
            }

            if (__instance is GlowWhale glowWhale)
            {
                MyModOptions.glowWhaleBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Glow Whale Values", "Glow Whale Base Health", glowWhale.liveMixin.health);
                MyModOptions.glowWhaleBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Glow Whale Values", "Glow Whale Base Max Acceleration", glowWhale.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.glowWhaleBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Glow Whale Values", "Glow Whale Base Up Rotation Speed", glowWhale.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.glowWhaleBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Glow Whale Values", "Glow Whale Base Forward Rotation Speed", glowWhale.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.glowWhaleBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Glow Whale Values", "Glow Whale Base Traits Animator Speed", glowWhale.GetComponent<GlowWhale>().traitsAnimator.speed);
            }

            if (__instance is Pinnacarid pinnacarid)
            {
                MyModOptions.pinnacaridBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Pinnacarid Values", "Pinnacarid Base Health", pinnacarid.liveMixin.health);
                MyModOptions.pinnacaridBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Pinnacarid Values", "Pinnacarid Base Max Acceleration", pinnacarid.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.pinnacaridBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Pinnacarid Values", "Pinnacarid Base Up Rotation Speed", pinnacarid.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.pinnacaridBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Pinnacarid Values", "Pinnacarid Base Forward Rotation Speed", pinnacarid.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.pinnacaridBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Pinnacarid Values", "Pinnacarid Base Traits Animator Speed", pinnacarid.GetComponent<Pinnacarid>().traitsAnimator.speed);
            }

            if (__instance is Triops triops)
            {
                MyModOptions.triopsBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Triops Values", "Triops Base Health", triops.liveMixin.health);
                MyModOptions.triopsBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Triops Values", "Triops Base Max Acceleration", triops.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.triopsBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Triops Values", "Triops Base Up Rotation Speed", triops.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.triopsBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Triops Values", "Triops Base Forward Rotation Speed", triops.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.triopsBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Triops Values", "Triops Base Traits Animator Speed", triops.GetComponent<Triops>().traitsAnimator.speed);
            }

            if (__instance is Trivalve trivalve)
            {
                MyModOptions.trivalveBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Trivalve Values", "Trivalve Base Health", trivalve.liveMixin.health);
                MyModOptions.trivalveBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Trivalve Values", "Trivalve Base Max Acceleration", trivalve.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.trivalveBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Trivalve Values", "Trivalve Base Up Rotation Speed", trivalve.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.trivalveBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Trivalve Values", "Trivalve Base Forward Rotation Speed", trivalve.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.trivalveBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Trivalve Values", "Trivalve Base Traits Animator Speed", trivalve.GetComponent<Trivalve>().traitsAnimator.speed);
            }

            if (__instance is SymbioteFish symbioteFish)
            {
                MyModOptions.symbioteFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Symbiotefish Values", "Symbiotefish Base Health", symbioteFish.liveMixin.health);
                MyModOptions.symbioteFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Symbiotefish Values", "Symbiotefish Base Max Acceleration", symbioteFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.symbioteFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Symbiotefish Values", "Symbiotefish Base Up Rotation Speed", symbioteFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.symbioteFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Symbiotefish Values", "Symbiotefish Base Forward Rotation Speed", symbioteFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.symbioteFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Symbiotefish Values", "Symbiotefish Base Traits Animator Speed", symbioteFish.GetComponent<SymbioteFish>().traitsAnimator.speed);
            }

            if (__instance is RockGrub rockGrub)
            {
                MyModOptions.rockGrubBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Base Health", rockGrub.liveMixin.health);
                MyModOptions.rockGrubBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Base Max Acceleration", rockGrub.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.rockGrubBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Base Up Rotation Speed", rockGrub.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.rockGrubBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Base Forward Rotation Speed", rockGrub.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.rockGrubBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Base Traits Animator Speed", rockGrub.GetComponent<RockGrub>().traitsAnimator.speed);
            }
            #endregion

            #region Aggressive Fish
            if (__instance is Crash crashFish)
            {
                MyModOptions.crashFishBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Crashfish Values", "Crashfish Base Health", crashFish.liveMixin.health);
                MyModOptions.crashFishBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Crashfish Values", "Crashfish Base Max Acceleration", crashFish.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.crashFishBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crashfish Values", "Crashfish Base Up Rotation Speed", crashFish.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.crashFishBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crashfish Values", "Crashfish Base Forward Rotation Speed", crashFish.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.crashFishBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Crashfish Values", "Crashfish Base Traits Animator Speed", crashFish.GetComponent<Crash>().traitsAnimator.speed);
            }

            if (__instance is Brinewing brineWing)
            {
                MyModOptions.brineWingBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Brinewing Values", "Brinewing Base Health", brineWing.liveMixin.health);
                MyModOptions.brineWingBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Brinewing Values", "Brinewing Base Max Acceleration", brineWing.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.brineWingBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Brinewing Values", "Brinewing Base Up Rotation Speed", brineWing.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.brineWingBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Brinewing Values", "Brinewing Base Forward Rotation Speed", brineWing.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.brineWingBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Brinewing Values", "Brinewing Base Traits Animator Speed", brineWing.GetComponent<Brinewing>().traitsAnimator.speed);
            }

            if (__instance is LilyPaddler lilyPaddler)
            {
                MyModOptions.lilyPaddlerBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Lily Paddler Values", "Lily Paddler Base Health", lilyPaddler.liveMixin.health);
                MyModOptions.lilyPaddlerBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Lily Paddler Values", "Lily Paddler Base Max Acceleration", lilyPaddler.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.lilyPaddlerBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Lily Paddler Values", "Lily Paddler Base Up Rotation Speed", lilyPaddler.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.lilyPaddlerBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Lily Paddler Values", "Lily Paddler Base Forward Rotation Speed", lilyPaddler.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.lilyPaddlerBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Lily Paddler Values", "Lily Paddler Base Traits Animator Speed", lilyPaddler.GetComponent<LilyPaddler>().traitsAnimator.speed);
            }

            if (__instance is Cryptosuchus cryptosuchus)
            {
                MyModOptions.cryptosuchusBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Cryptosuchus Values", "Cryptosuchus Base Health", cryptosuchus.liveMixin.health);
                MyModOptions.cryptosuchusBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Cryptosuchus Values", "Cryptosuchus Base Max Acceleration", cryptosuchus.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.cryptosuchusBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Cryptosuchus Values", "Cryptosuchus Base Up Rotation Speed", cryptosuchus.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.cryptosuchusBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Cryptosuchus Values", "Cryptosuchus Base Forward Rotation Speed", cryptosuchus.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.cryptosuchusBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Cryptosuchus Values", "Cryptosuchus Base Traits Animator Speed", cryptosuchus.GetComponent<Cryptosuchus>().traitsAnimator.speed);
            }

            if (__instance is BruteShark bruteShark)
            {
                MyModOptions.bruteSharkBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Brute Shark Values", "Brute Shark Base Health", bruteShark.liveMixin.health);
                MyModOptions.bruteSharkBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Brute Shark Values", "Brute Shark Base Max Acceleration", bruteShark.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.bruteSharkBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Brute Shark Values", "Brute Shark Base Up Rotation Speed", bruteShark.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.bruteSharkBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Brute Shark Values", "Brute Shark Base Forward Rotation Speed", bruteShark.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.bruteSharkBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Brute Shark Values", "Brute Shark Base Traits Animator Speed", bruteShark.GetComponent<BruteShark>().traitsAnimator.speed);
            }

            if (__instance is SquidShark squidShark)
            {
                MyModOptions.squidSharkBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Squid Shark Values", "Squid Shark Base Health", squidShark.liveMixin.health);
                MyModOptions.squidSharkBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Squid Shark Values", "Squid Shark Base Max Acceleration", squidShark.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.squidSharkBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Squid Shark Values", "Squid Shark Base Up Rotation Speed", squidShark.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.squidSharkBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Squid Shark Values", "Squid Shark Base Forward Rotation Speed", squidShark.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.squidSharkBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Squid Shark Values", "Squid Shark Base Traits Animator Speed", squidShark.GetComponent<SquidShark>().traitsAnimator.speed);
            }

            if (__instance is Chelicerate chelicerate)
            {
                MyModOptions.chelicerateBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Chelicerate Values", "Chelicerate Base Health", chelicerate.liveMixin.health);
                MyModOptions.chelicerateBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Chelicerate Values", "Chelicerate Base Max Acceleration", chelicerate.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.chelicerateBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Chelicerate Values", "Chelicerate Base Up Rotation Speed", chelicerate.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.chelicerateBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Chelicerate Values", "Chelicerate Base Forward Rotation Speed", chelicerate.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.chelicerateBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Chelicerate Values", "Chelicerate Base Traits Animator Speed", chelicerate.GetComponent<Chelicerate>().traitsAnimator.speed);
            }

            if (__instance is ShadowLeviathan shadowLeviathan)
            {
                MyModOptions.shadowLeviathanBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Shadow Leviathan Values", "Shadow Leviathan Base Health", shadowLeviathan.liveMixin.health);
                MyModOptions.shadowLeviathanBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Shadow Leviathan Values", "Shadow Leviathan Base Max Acceleration", shadowLeviathan.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.shadowLeviathanBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Shadow Leviathan Values", "Shadow Leviathan Base Up Rotation Speed", shadowLeviathan.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.shadowLeviathanBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Shadow Leviathan Values", "Shadow Leviathan Base Forward Rotation Speed", shadowLeviathan.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.shadowLeviathanBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Shadow Leviathan Values", "Shadow Leviathan Base Traits Animator Speed", shadowLeviathan.GetComponent<ShadowLeviathan>().traitsAnimator.speed);
            }

            if (__instance is VoidLeviathan voidLeviathan)
            {
                MyModOptions.voidLeviathanBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Void Leviathan Values", "Void Leviathan Base Health", voidLeviathan.liveMixin.health);
                MyModOptions.voidLeviathanBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Void Leviathan Values", "Void Leviathan Base Max Acceleration", voidLeviathan.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.voidLeviathanBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Void Leviathan Values", "Void Leviathan Base Up Rotation Speed", voidLeviathan.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.voidLeviathanBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Void Leviathan Values", "Void Leviathan Base Forward Rotation Speed", voidLeviathan.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.voidLeviathanBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Void Leviathan Values", "Void Leviathan Base Traits Animator Speed", voidLeviathan.GetComponent<VoidLeviathan>().traitsAnimator.speed);
            }
            #endregion

            #region Not Fish
            if (__instance is Skyray skyRay)
            {
                MyModOptions.skyRayBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Sky Ray Values", "Sky Ray Base Health", skyRay.liveMixin.health);
                MyModOptions.skyRayBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Sky Ray Values", "Sky Ray Base Max Acceleration", skyRay.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.skyRayBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sky Ray Values", "Sky Ray Base Up Rotation Speed", skyRay.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.skyRayBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sky Ray Values", "Sky Ray Base Forward Rotation Speed", skyRay.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.skyRayBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sky Ray Values", "Sky Ray Base Traits Animator Speed", skyRay.GetComponent<Skyray>().traitsAnimator.speed);
            }

            if (__instance is PenguinBaby pengling)
            {
                MyModOptions.penglingBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Pengling Values", "Pengling Base Health", pengling.liveMixin.health);
                MyModOptions.penglingBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Pengling Values", "Pengling Base Max Acceleration", pengling.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.penglingBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Pengling Values", "Pengling Base Up Rotation Speed", pengling.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.penglingBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Pengling Values", "Pengling Base Forward Rotation Speed", pengling.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.penglingBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Pengling Values", "Pengling Base Traits Animator Speed", pengling.GetComponent<PenguinBaby>().traitsAnimator.speed);
            }

            if (__instance is Penguin pengwing)
            {
                MyModOptions.pengwingBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Pengwing Values", "Pengwing Base Health", pengwing.liveMixin.health);
                MyModOptions.pengwingBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Pengwing Values", "Pengwing Base Max Acceleration", pengwing.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.pengwingBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Pengwing Values", "Pengwing Base Up Rotation Speed", pengwing.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.pengwingBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Pengwing Values", "Pengwing Base Forward Rotation Speed", pengwing.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.pengwingBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Pengwing Values", "Pengwing Base Traits Animator Speed", pengwing.GetComponent<Penguin>().traitsAnimator.speed);
            }

            if (__instance is SeaMonkeyBaby seaMonkeyBaby)
            {
                MyModOptions.seaMonkeyBabyBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Baby Values", "Sea Monkey Baby Base Health", seaMonkeyBaby.liveMixin.health);
                MyModOptions.seaMonkeyBabyBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Baby Values", "Sea Monkey Baby Base Max Acceleration", seaMonkeyBaby.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.seaMonkeyBabyBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Baby Values", "Sea Monkey Baby Base Up Rotation Speed", seaMonkeyBaby.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.seaMonkeyBabyBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Baby Values", "Sea Monkey Baby Base Forward Rotation Speed", seaMonkeyBaby.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.seaMonkeyBabyBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Baby Values", "Sea Monkey Baby Base Traits Animator Speed", seaMonkeyBaby.GetComponent<SeaMonkeyBaby>().traitsAnimator.speed);
            }

            if (__instance is SeaMonkey seaMonkey)
            {
                MyModOptions.seaMonkeyBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Values", "Sea Monkey Base Health", seaMonkey.liveMixin.health);
                MyModOptions.seaMonkeyBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Values", "Sea Monkey Base Max Acceleration", seaMonkey.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.seaMonkeyBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Values", "Sea Monkey Base Up Rotation Speed", seaMonkey.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.seaMonkeyBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Values", "Sea Monkey Base Forward Rotation Speed", seaMonkey.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.seaMonkeyBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Sea Monkey Values", "Sea Monkey Base Traits Animator Speed", seaMonkey.GetComponent<SeaMonkey>().traitsAnimator.speed);
            }

            if (__instance is SnowStalkerBaby snowStalkerBaby)
            {
                MyModOptions.snowStalkerBabyBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Baby Values", "Snow Stalker Baby Base Health", snowStalkerBaby.liveMixin.health);
                MyModOptions.snowStalkerBabyBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Baby Values", "Snow Stalker Baby Base Max Acceleration", snowStalkerBaby.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.snowStalkerBabyBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Baby Values", "Snow Stalker Baby Base Up Rotation Speed", snowStalkerBaby.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.snowStalkerBabyBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Baby Values", "Snow Stalker Baby Base Forward Rotation Speed", snowStalkerBaby.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.snowStalkerBabyBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Baby Values", "Snow Stalker Baby Base Traits Animator Speed", snowStalkerBaby.GetComponent<SnowStalkerBaby>().traitsAnimator.speed);
            }

            if (__instance is SnowStalker snowStalker)
            {
                MyModOptions.snowStalkerBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Values", "Snow Stalker Base Health", snowStalker.liveMixin.health);
                MyModOptions.snowStalkerBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Values", "Snow Stalker Base Max Acceleration", snowStalker.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.snowStalkerBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Values", "Snow Stalker Base Up Rotation Speed", snowStalker.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.snowStalkerBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Values", "Snow Stalker Base Forward Rotation Speed", snowStalker.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.snowStalkerBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Snow Stalker Values", "Snow Stalker Base Traits Animator Speed", snowStalker.GetComponent<SnowStalker>().traitsAnimator.speed);
            }

            if (__instance is RockPuncher rockPuncher)
            {
                MyModOptions.rockPuncherBaseHealth = ModPlugin.biggerFishSettingsConfig.Bind("Rock Puncher Values", "Rock Puncher Base Health", rockPuncher.liveMixin.health);
                MyModOptions.rockPuncherBaseMaxAcceleration = ModPlugin.biggerFishSettingsConfig.Bind("Rock Puncher Values", "Rock Puncher Base Max Acceleration", rockPuncher.GetComponent<Locomotion>().maxAcceleration);
                MyModOptions.rockPuncherBaseUpRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Rock Puncher Values", "Rock Puncher Base Up Rotation Speed", rockPuncher.GetComponent<Locomotion>().upRotationSpeed);
                MyModOptions.rockPuncherBaseForwardRotationSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Rock Puncher Values", "Rock Puncher Base Forward Rotation Speed", rockPuncher.GetComponent<Locomotion>().forwardRotationSpeed);
                MyModOptions.rockPuncherBaseTraitsAnimatorSpeed = ModPlugin.biggerFishSettingsConfig.Bind("Rock Puncher Values", "Rock Puncher Base Traits Animator Speed", rockPuncher.GetComponent<RockPuncher>().traitsAnimator.speed);
            }
            #endregion
        }
    }
#endif
}
