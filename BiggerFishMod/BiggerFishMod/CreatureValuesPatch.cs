using HarmonyLib;

namespace BiggerFishMod
{
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
}
