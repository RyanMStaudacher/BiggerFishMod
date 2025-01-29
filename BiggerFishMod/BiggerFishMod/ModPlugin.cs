using System.IO;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

namespace BiggerFishMod
{
#if SUBNAUTICA
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    [BepInDependency("com.snmodding.nautilus")]

    public class ModPlugin : BaseUnityPlugin
    {
        private const string MyGuid = "com.lazybriefcase.biggerfish";
        private const string PluginName = "Bigger Fish";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGuid);

        public static ConfigFile biggerFishSettingsConfig = new ConfigFile(Path.Combine(Paths.ConfigPath, "BiggerFishSettings.cfg"), true);

        public static ManualLogSource Log;

        public void Awake()
        {
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " " + "loaded.");
            Log = Logger;

            //MyModOptions.randomizeAllToggle = biggerFishSettingsConfig.Bind("Randomize All", "Randomize All", false, "Randomizes scale, slowness, and health values for all creatures.");
            MyModOptions.removeFishSchools = biggerFishSettingsConfig.Bind("Misc. Options", "Remove Fish Schools", false, "When enabled, removes the schools of smaller fish.");
            MyModOptions.proportionalToggle = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional", false, "If enabled, all creatures will use the same values.");
            MyModOptions.proportionalScale = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional Scale", 1.0f, "The scale value all creatures will use when Proportional Toggle is enabled.");
            MyModOptions.proportionalSlowness = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional Slowness", 1.0f, "The value at which all creatures will be slowed down to when Proportional Toggle is enabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.proportionalHealth = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional Health", 1.0f, "All creatures health will be multiplied by this value when Proportional Toggle is enabled.");
            MyModOptions.proportionalCreatureLimit = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional Creature Limit", 50.0f, "Limits the amount of active creatures(per each creature) to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.biterExclude = biggerFishSettingsConfig.Bind("Biter Values", "Biter Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.biterScale = biggerFishSettingsConfig.Bind("Biter Values", "Biter Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.biterSlowness = biggerFishSettingsConfig.Bind("Biter Values", "Biter Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.biterHealth = biggerFishSettingsConfig.Bind("Biter Values", "Biter Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.biterLimit = biggerFishSettingsConfig.Bind("Biter Values", "Biter Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.bladderFishExclude = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.bladderFishScale = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.bladderFishSlowness = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.bladderFishHealth = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.bladderFishLimit = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.bladderFishRandomize = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Randomize", false, "Randomize this creature's values.");
            MyModOptions.bladderFishRandomizeMin = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Randomize Min", 1f, "The minimum amount the randomization can be set to.");
            MyModOptions.bladderFishRandomizeMax = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Randomize Max", 50f, "The maximum amount the randomization can be set to.");

            MyModOptions.bleederExclude = biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.bleederScale = biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.bleederSlowness = biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.bleederHealth = biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.bleederLimit = biggerFishSettingsConfig.Bind("Bleeder Values", "Bleeder Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.boneSharkExclude = biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.boneSharkScale = biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.boneSharkSlowness = biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.boneSharkHealth = biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.boneSharkLimit = biggerFishSettingsConfig.Bind("Bone Shark Values", "Bone Shark Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.boomerangExclude = biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.boomerangScale = biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.boomerangHealth = biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.boomerangSlowness = biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.boomerangLimit = biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.caveCrawlerExclude = biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.caveCrawlerScale = biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.caveCrawlerSlowness = biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.caveCrawlerHealth = biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.caveCrawlerLimit = biggerFishSettingsConfig.Bind("Cave Crawler Values", "Cave Crawler Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.crabSnakeExclude = biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.crabSnakeScale = biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.crabSnakeSlowness = biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.crabSnakeHealth = biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.crabSnakeLimit = biggerFishSettingsConfig.Bind("Crab Snake Values", "Crab Snake Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.crabSquidExclude = biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.crabSquidScale = biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.crabSquidSlowness = biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.crabSquidHealth = biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.crabSquidLimit = biggerFishSettingsConfig.Bind("Crab Squid Values", "Crab Squid Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.crashFishExclude = biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.crashFishScale = biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.crashFishSlowness = biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.crashFishHealth = biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.crashFishLimit = biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.cuddleFishExclude = biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.cuddleFishScale = biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.cuddleFishSlowness = biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.cuddleFishHealth = biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.cuddleFishLimit = biggerFishSettingsConfig.Bind("Cuddlefish Values", "Cuddlefish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.eyeyeExclude = biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.eyeyeScale = biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.eyeyeSlowness = biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.eyeyeHealth = biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.eyeyeLimit = biggerFishSettingsConfig.Bind("Eyeye Values", "Eyeye Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.garryFishExclude = biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.garryFishScale = biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.garryFishSlowness = biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.garryFishHealth = biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.garryFishLimit = biggerFishSettingsConfig.Bind("Garry Fish Values", "Garry Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.gasopodExclude = biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.gasopodScale = biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.gasopodSlowness = biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.gasopodHealth = biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.gasopodLimit = biggerFishSettingsConfig.Bind("Gasopod Values", "Gasopod Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.ghostLeviathanExclude = biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.ghostLeviathanScale = biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.ghostLeviathanSlowness = biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.ghostLeviathanHealth = biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.ghostLeviathanLimit = biggerFishSettingsConfig.Bind("Ghost Leviathan Values", "Ghost Leviathan Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.voidGhostLeviathanExclude = biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.voidGhostLeviathanScale = biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.voidGhostLeviathanSlowness = biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.voidGhostLeviathanHealth = biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.voidGhostLeviathanLimit = biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Values", "Ghost Leviathan(Void) Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.ghostRayExclude = biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.ghostRayScale = biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.ghostRaySlowness = biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.ghostRayHealth = biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.ghostRayLimit = biggerFishSettingsConfig.Bind("Ghost Ray Values", "Ghost Ray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.holeFishExclude = biggerFishSettingsConfig.Bind("Hole Fish Values", "Hole Fish Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.holeFishScale = biggerFishSettingsConfig.Bind("Hole Fish Values", "Hole Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.holeFishSlowness = biggerFishSettingsConfig.Bind("Hole Fish Values", "Hole Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.holeFishHealth = biggerFishSettingsConfig.Bind("Hole Fish Values", "Hole Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.holeFishLimit = biggerFishSettingsConfig.Bind("Hole Fish Values", "Hole Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.hoopFishExclude = biggerFishSettingsConfig.Bind("Hoop Fish Values", "Hoop Fish Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.hoopFishScale = biggerFishSettingsConfig.Bind("Hoop Fish Values", "Hoop Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.hoopFishSlowness = biggerFishSettingsConfig.Bind("Hoop Fish Values", "Hoop Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.hoopFishHealth = biggerFishSettingsConfig.Bind("Hoop Fish Values", "Hoop Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.hoopFishLimit = biggerFishSettingsConfig.Bind("Hoop Fish Values", "Hoop Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.hoverFishExclude = biggerFishSettingsConfig.Bind("Hover Fish Values", "Hover Fish Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.hoverFishScale = biggerFishSettingsConfig.Bind("Hover Fish Values", "Hover Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.hoverFishSlowness = biggerFishSettingsConfig.Bind("Hover Fish Values", "Hover Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.hoverFishHealth = biggerFishSettingsConfig.Bind("Hover Fish Values", "Hover Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.hoverFishLimit = biggerFishSettingsConfig.Bind("Hover Fish Values", "Hover Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.jellyRayExclude = biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.jellyRayScale = biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.jellyRaySlowness = biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.jellyRayHealth = biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.jellyRayLimit = biggerFishSettingsConfig.Bind("Jellyray Values", "Jellyray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.jumperExclude = biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.jumperScale = biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.jumperSlowness = biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.jumperHealth = biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.jumperLimit = biggerFishSettingsConfig.Bind("Shuttlebug Values", "Shuttlebug Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.lavaLarvaExclude = biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.lavaLarvaScale = biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.lavaLarvaSlowness = biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.lavaLarvaHealth = biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.lavaLarvaLimit = biggerFishSettingsConfig.Bind("Lava Larva Values", "Lava Larva Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.lavaLizardExclude = biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.lavaLizardScale = biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.lavaLizardSlowness = biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.lavaLizardHealth = biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.lavaLizardLimit = biggerFishSettingsConfig.Bind("Lava Lizard Values", "Lava Lizard Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.mesmerExclude = biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.mesmerScale = biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.mesmerSlowness = biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.mesmerHealth = biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.mesmerLimit = biggerFishSettingsConfig.Bind("Mesmer Values", "Mesmer Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.oculusFishExclude = biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.oculusFishScale = biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.oculusFishSlowness = biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.oculusFishHealth = biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.oculusFishLimit = biggerFishSettingsConfig.Bind("Oculus Fish Values", "Oculus Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.peeperExclude = biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.peeperScale = biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.peeperSlowness = biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.peeperHealth = biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.peeperLimit = biggerFishSettingsConfig.Bind("Peeper Values", "Peeper Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.rabbitRayExclude = biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.rabbitRayScale = biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.rabbitRaySlowness = biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.rabbitRayHealth = biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.rabbitRayLimit = biggerFishSettingsConfig.Bind("Rabbit Ray Values", "Rabbit Ray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.reaperLeviathanExclude = biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.reaperLeviathanScale = biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.reaperLeviathanSlowness = biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.reaperLeviathanHealth = biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.reaperLeviathanLimit = biggerFishSettingsConfig.Bind("Reaper Leviathan Values", "Reaper Leviathan Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.reefbackExclude = biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.reefbackScale = biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.reefbackSlowness = biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.reefbackHealth = biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.reefbackLimit = biggerFishSettingsConfig.Bind("Reefback Values", "Reefback Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.reginaldExclude = biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.reginaldScale = biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.reginaldSlowness = biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.reginaldHealth = biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.reginaldLimit = biggerFishSettingsConfig.Bind("Reginald Values", "Reginald Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            //MyModOptions.rockGrubExclude = biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            //MyModOptions.rockGrubScale = biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            //MyModOptions.rockGrubSlowness = biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            //MyModOptions.rockGrubHealth = biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Health", 1.0f, "The value to multiply this creature's health by.");
            //MyModOptions.rockGrubLimit = biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.sandSharkExclude = biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.sandSharkScale = biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.sandSharkSlowness = biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.sandSharkHealth = biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.sandSharkLimit = biggerFishSettingsConfig.Bind("Sand Shark Values", "Sand Shark Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.seaDragonExclude = biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.seaDragonScale = biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaDragonSlowness = biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaDragonHealth = biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaDragonLimit = biggerFishSettingsConfig.Bind("Sea Dragon Values", "Sea Dragon Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.seaEmperorBabyExclude = biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.seaEmperorBabyScale = biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaEmperorBabySlowness = biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaEmperorBabyHealth = biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaEmperorBabyLimit = biggerFishSettingsConfig.Bind("Sea Emperor Baby Values", "Sea Emperor Baby Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.seaEmperorJuvenileExclude = biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.seaEmperorJuvenileScale = biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaEmperorJuvenileSlowness = biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaEmperorJuvenileHealth = biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaEmperorJuvenileLimit = biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Values", "Sea Emperor Juvenile Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.seaTreaderExclude = biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.seaTreaderScale = biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaTreaderSlowness = biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaTreaderHealth = biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaTreaderLimit = biggerFishSettingsConfig.Bind("Sea Treader Values", "Sea Treader Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.shockerExclude = biggerFishSettingsConfig.Bind("Ampeel Values", "Ampeel Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.shockerScale = biggerFishSettingsConfig.Bind("Ampeel Values", "Ampeel Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.shockerSlowness = biggerFishSettingsConfig.Bind("Ampeel Values", "Ampeel Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.shockerHealth = biggerFishSettingsConfig.Bind("Ampeel Values", "Ampeel Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.shockerLimit = biggerFishSettingsConfig.Bind("Ampeel Values", "Ampeel Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.skyRayExclude = biggerFishSettingsConfig.Bind("Skyray Values", "Skyray Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.skyRayScale = biggerFishSettingsConfig.Bind("Skyray Values", "Skyray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.skyRaySlowness = biggerFishSettingsConfig.Bind("Skyray Values", "Skyray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.skyRayHealth = biggerFishSettingsConfig.Bind("Skyray Values", "Skyray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.skyRayLimit = biggerFishSettingsConfig.Bind("Skyray Values", "Skyray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.spadeFishExclude = biggerFishSettingsConfig.Bind("Spade Fish Values", "Spade Fish Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.spadeFishScale = biggerFishSettingsConfig.Bind("Spade Fish Values", "Spade Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.spadeFishSlowness = biggerFishSettingsConfig.Bind("Spade Fish Values", "Spade Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.spadeFishHealth = biggerFishSettingsConfig.Bind("Spade Fish Values", "Spade Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.spadeFishLimit = biggerFishSettingsConfig.Bind("Spade Fish Values", "Spade Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.spineEelExclude = biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.spineEelScale = biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.spineEelSlowness = biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.spineEelHealth = biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.spineEelLimit = biggerFishSettingsConfig.Bind("River Prowler Values", "River Prowler Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.stalkerExclude = biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.stalkerScale = biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.stalkerSlowness = biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.stalkerHealth = biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.stalkerLimit = biggerFishSettingsConfig.Bind("Stalker Values", "Stalker Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.warperExclude = biggerFishSettingsConfig.Bind("Warper Values", "Warper Exclude From Proportional", false, "Exclude this creature from the proportional toggle.");
            MyModOptions.warperScale = biggerFishSettingsConfig.Bind("Warper Values", "Warper Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.warperSlowness = biggerFishSettingsConfig.Bind("Warper Values", "Warper Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.warperHealth = biggerFishSettingsConfig.Bind("Warper Values", "Warper Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.warperLimit = biggerFishSettingsConfig.Bind("Warper Values", "Warper Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            new MyModOptions();
        }
    }
#endif

#if SUBNAUTICAZERO
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    [BepInDependency("com.snmodding.nautilus")]

    public class ModPlugin : BaseUnityPlugin
    {
        private const string MyGuid = "com.lazybriefcase.biggerfish";
        private const string PluginName = "BiggerFish";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGuid);

        public static ConfigFile biggerFishSettingsConfig = new ConfigFile(Path.Combine(Paths.ConfigPath, "BiggerFishSettings.cfg"), true);

        public static ManualLogSource Log;

        public void Awake()
        {
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " " + "loaded.");
            Log = Logger;

            MyModOptions.removeFishSchools = biggerFishSettingsConfig.Bind("Misc. Settings", "Remove Fish Schools", false, "When enabled, removes the schools of smaller fish.");
            MyModOptions.proportionalToggle = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional", false, "If enabled, all creatures will use the same values.");
            MyModOptions.proportionalScale = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional Scale", 1.0f, "The scale value all creatures will use when Proportional Toggle is enabled.");
            MyModOptions.proportionalSlowness = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional Slowness", 1.0f, "The value at which all creatures will be slowed down to when Proportional Toggle is enabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.proportionalHealth = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional Health", 1.0f, "All creatures health will be multiplied by this value when Proportional Toggle is enabled.");
            MyModOptions.proportionalCreatureLimit = biggerFishSettingsConfig.Bind("Proportional Values", "Proportional Creature Limit", 50.0f, "Limits the amount of active creatures(per each creature) to this value (Bigger creatures can create lots of clutter, this helps with that).");
           
            MyModOptions.arcticPeeperScale = biggerFishSettingsConfig.Bind("Arctic Peeper Values", "Arctic Peeper Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.arcticPeeperSlowness = biggerFishSettingsConfig.Bind("Arctic Peeper Values", "Arctic Peeper Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.arcticPeeperLimit = biggerFishSettingsConfig.Bind("Arctic Peeper Values", "Arctic Peeper Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.arcticPeeperHealth = biggerFishSettingsConfig.Bind("Arctic Peeper Values", "Arctic Peeper Health", 1.0f, "The value to multiply this creature's health by.");
            
            MyModOptions.arrowRayScale = biggerFishSettingsConfig.Bind("Arrow Ray Values", "Arrow Ray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.arrowRaySlowness = biggerFishSettingsConfig.Bind("Arrow Ray Values", "Arrow Ray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.arrowRayHealth = biggerFishSettingsConfig.Bind("Arrow Ray Values", "Arrow Ray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.arrowRayLimit = biggerFishSettingsConfig.Bind("Arrow Ray Values", "Arrow Ray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.boomerangScale = biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.boomerangSlowness = biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.boomerangHealth = biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.boomerangLimit = biggerFishSettingsConfig.Bind("Boomerang Values", "Boomerang Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.bladderFishScale = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.bladderFishSlowness = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.bladderFishHealth = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.bladderFishLimit = biggerFishSettingsConfig.Bind("Bladderfish Values", "Bladderfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.hoopFishScale = biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.hoopFishSlowness = biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.hoopFishHealth = biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.hoopFishLimit = biggerFishSettingsConfig.Bind("Hoopfish Values", "Hoopfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.discusFishScale = biggerFishSettingsConfig.Bind("Discusfish Values", "Discusfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.discusFishSlowness = biggerFishSettingsConfig.Bind("Discusfish Values", "Discusfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.discusFishHealth = biggerFishSettingsConfig.Bind("Discusfish Values", "Discusfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.discusFishLimit = biggerFishSettingsConfig.Bind("Discusfish Values", "Discusfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.featherFishScale = biggerFishSettingsConfig.Bind("Featherfish Values", "Featherfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.featherFishSlowness = biggerFishSettingsConfig.Bind("Featherfish Values", "Featherfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.featherFishHealth = biggerFishSettingsConfig.Bind("Featherfish Values", "Featherfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.featherFishLimit = biggerFishSettingsConfig.Bind("Featherfish Values", "Featherfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.nootFishScale = biggerFishSettingsConfig.Bind("Nootfish Values", "Nootfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.nootFishSlowness = biggerFishSettingsConfig.Bind("Nootfish Values", "Nootfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.nootFishHealth = biggerFishSettingsConfig.Bind("Nootfish Values", "Nootfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.nootFishLimit = biggerFishSettingsConfig.Bind("Nootfish Values", "Nootfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.spinnerFishScale = biggerFishSettingsConfig.Bind("Spinnerfish Values", "Spinnerfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.spinnerFishSlowness = biggerFishSettingsConfig.Bind("Spinnerfish Values", "Spinnerfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.spinnerFishHealth = biggerFishSettingsConfig.Bind("Spinnerfish Values", "Spinnerfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.spinnerFishLimit = biggerFishSettingsConfig.Bind("Spinnerfish Values", "Spinnerfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.arcticRayScale = biggerFishSettingsConfig.Bind("Arctic Ray Values", "Arctic Ray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.arcticRaySlowness = biggerFishSettingsConfig.Bind("Arctic Ray Values", "Arctic Ray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.arcticRayHealth = biggerFishSettingsConfig.Bind("Arctic Ray Values", "Arctic Ray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.arcticRayLimit = biggerFishSettingsConfig.Bind("Arctic Ray Values", "Arctic Ray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.jellyFishScale = biggerFishSettingsConfig.Bind("Eye Jelly Values", "Eye Jelly Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.jellyFishSlowness = biggerFishSettingsConfig.Bind("Eye Jelly Values", "Eye Jelly Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.jellyFishHealth = biggerFishSettingsConfig.Bind("Eye Jelly Values", "Eye Jelly Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.jellyFishLimit = biggerFishSettingsConfig.Bind("Eye Jelly Values", "Eye Jelly Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.titanHoleFishScale = biggerFishSettingsConfig.Bind("Titan Hole Fish Values", "Titan Hole Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.titanHoleFishSlowness = biggerFishSettingsConfig.Bind("Titan Hole Fish Values", "Titan Hole Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.titanHoleFishHealth = biggerFishSettingsConfig.Bind("Titan Hole Fish Values", "Titan Hole Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.titanHoleFishLimit = biggerFishSettingsConfig.Bind("Titan Hole Fish Values", "Titan Hole Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.glowWhaleScale = biggerFishSettingsConfig.Bind("Glow Whale Values", "Glow Whale Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.glowWhaleSlowness = biggerFishSettingsConfig.Bind("Glow Whale Values", "Glow Whale Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.glowWhaleHealth = biggerFishSettingsConfig.Bind("Glow Whale Values", "Glow Whale Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.glowWhaleLimit = biggerFishSettingsConfig.Bind("Glow Whale Values", "Glow Whale Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.pinnacaridScale = biggerFishSettingsConfig.Bind("Pinnacarid Values", "Pinnacarid Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.pinnacaridSlowness = biggerFishSettingsConfig.Bind("Pinnacarid Values", "Pinnacarid Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.pinnacaridHealth = biggerFishSettingsConfig.Bind("Pinnacarid Values", "Pinnacarid Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.pinnacaridLimit = biggerFishSettingsConfig.Bind("Pinnacarid Values", "Pinnacarid Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.triopsScale = biggerFishSettingsConfig.Bind("Triops Values", "Triops Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.triopsSlowness = biggerFishSettingsConfig.Bind("Triops Values", "Triops Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.triopsHealth = biggerFishSettingsConfig.Bind("Triops Values", "Triops Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.triopsLimit = biggerFishSettingsConfig.Bind("Triops Values", "Triops Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.trivalveScale = biggerFishSettingsConfig.Bind("Trivalve Values", "Trivalve Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.trivalveSlowness = biggerFishSettingsConfig.Bind("Trivalve Values", "Trivalve Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.trivalveHealth = biggerFishSettingsConfig.Bind("Trivalve Values", "Trivalve Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.trivalveLimit = biggerFishSettingsConfig.Bind("Trivalve Values", "Trivalve Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.symbioteFishScale = biggerFishSettingsConfig.Bind("Symbiotefish Values", "Symbiotefish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.symbioteFishSlowness = biggerFishSettingsConfig.Bind("Symbiotefish Values", "Symbiotefish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.symbioteFishHealth = biggerFishSettingsConfig.Bind("Symbiotefish Values", "Symbiotefish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.symbioteFishLimit = biggerFishSettingsConfig.Bind("Symbiotefish Values", "Symbiotefish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.rockGrubScale = biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.rockGrubSlowness = biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.rockGrubHealth = biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.rockGrubLimit = biggerFishSettingsConfig.Bind("Rock Grub Values", "Rock Grub Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.crashFishScale = biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.crashFishSlowness = biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.crashFishHealth = biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.crashFishLimit = biggerFishSettingsConfig.Bind("Crash Fish Values", "Crash Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.brineWingScale = biggerFishSettingsConfig.Bind("Brinewing Values", "Brinewing Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.brineWingSlowness = biggerFishSettingsConfig.Bind("Brinewing Values", "Brinewing Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.brineWingHealth = biggerFishSettingsConfig.Bind("Brinewing Values", "Brinewing Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.brineWingLimit = biggerFishSettingsConfig.Bind("Brinewing Values", "Brinewing Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.lilyPaddlerScale = biggerFishSettingsConfig.Bind("Lily Paddler Values", "Lily Paddler Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.lilyPaddlerSlowness = biggerFishSettingsConfig.Bind("Lily Paddler Values", "Lily Paddler Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.lilyPaddlerHealth = biggerFishSettingsConfig.Bind("Lily Paddler Values", "Lily Paddler Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.lilyPaddlerLimit = biggerFishSettingsConfig.Bind("Lily Paddler Values", "Lily Paddler Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.cryptosuchusScale = biggerFishSettingsConfig.Bind("Cryptosuchus Values", "Cryptosuchus Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.cryptosuchusSlowness = biggerFishSettingsConfig.Bind("Cryptosuchus Values", "Cryptosuchus Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.cryptosuchusHealth = biggerFishSettingsConfig.Bind("Cryptosuchus Values", "Cryptosuchus Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.cryptosuchusLimit = biggerFishSettingsConfig.Bind("Cryptosuchus Values", "Cryptosuchus Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.bruteSharkScale = biggerFishSettingsConfig.Bind("Brute Shark Values", "Brute Shark Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.bruteSharkSlowness = biggerFishSettingsConfig.Bind("Brute Shark Values", "Brute Shark Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.bruteSharkHealth = biggerFishSettingsConfig.Bind("Brute Shark Values", "Brute Shark Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.bruteSharkLimit = biggerFishSettingsConfig.Bind("Brute Shark Values", "Brute Shark Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.squidSharkScale = biggerFishSettingsConfig.Bind("Squid Shark Values", "Squid Shark Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.squidSharkSlowness = biggerFishSettingsConfig.Bind("Squid Shark Values", "Squid Shark Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.squidSharkHealth = biggerFishSettingsConfig.Bind("Squid Shark Values", "Squid Shark Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.squidSharkLimit = biggerFishSettingsConfig.Bind("Squid Shark Values", "Squid Shark Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.chelicerateScale = biggerFishSettingsConfig.Bind("Chelicerate Values", "Chelicerate Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.chelicerateSlowness = biggerFishSettingsConfig.Bind("Chelicerate Values", "Chelicerate Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.chelicerateHealth = biggerFishSettingsConfig.Bind("Chelicerate Values", "Chelicerate Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.chelicerateLimit = biggerFishSettingsConfig.Bind("Chelicerate Values", "Chelicerate Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.shadowLeviathanScale = biggerFishSettingsConfig.Bind("Shadow Leviathan Values", "Shadow Leviathan Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.shadowLeviathanSlowness = biggerFishSettingsConfig.Bind("Shadow Leviathan Values", "Shadow Leviathan Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.shadowLeviathanHealth = biggerFishSettingsConfig.Bind("Shadow Leviathan Values", "Shadow Leviathan Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.shadowLeviathanLimit = biggerFishSettingsConfig.Bind("Shadow Leviathan Values", "Shadow Leviathan Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.voidLeviathanScale = biggerFishSettingsConfig.Bind("Void Leviathan Values", "Void Leviathan Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.voidLeviathanSlowness = biggerFishSettingsConfig.Bind("Void Leviathan Values", "Void Leviathan Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.voidLeviathanHealth = biggerFishSettingsConfig.Bind("Void Leviathan Values", "Void Leviathan Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.voidLeviathanLimit = biggerFishSettingsConfig.Bind("Void Leviathan Values", "Void Leviathan Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.skyRayScale = biggerFishSettingsConfig.Bind("Skyray Values", "Skyray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.skyRaySlowness = biggerFishSettingsConfig.Bind("Skyray Values", "Skyray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.skyRayHealth = biggerFishSettingsConfig.Bind("Skyray Values", "Skyray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.skyRayLimit = biggerFishSettingsConfig.Bind("Skyray Values", "Skyray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.penglingScale = biggerFishSettingsConfig.Bind("Pengling Values", "Pengling Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.penglingSlowness = biggerFishSettingsConfig.Bind("Pengling Values", "Pengling Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.penglingHealth = biggerFishSettingsConfig.Bind("Pengling Values", "Pengling Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.penglingLimit = biggerFishSettingsConfig.Bind("Pengling Values", "Pengling Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.pengwingScale = biggerFishSettingsConfig.Bind("Pengwing Values", "Pengwing Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.pengwingSlowness = biggerFishSettingsConfig.Bind("Pengwing Values", "Pengwing Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.pengwingHealth = biggerFishSettingsConfig.Bind("Pengwing Values", "Pengwing Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.pengwingLimit = biggerFishSettingsConfig.Bind("Pengwing Values", "Pengwing Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.seaMonkeyBabyScale = biggerFishSettingsConfig.Bind("Sea Monkey Baby Values", "Sea Monkey Baby Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaMonkeyBabySlowness = biggerFishSettingsConfig.Bind("Sea Monkey Baby Values", "Sea Monkey Baby Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaMonkeyBabyHealth = biggerFishSettingsConfig.Bind("Sea Monkey Baby Values", "Sea Monkey Baby Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaMonkeyBabyLimit = biggerFishSettingsConfig.Bind("Sea Monkey Baby Values", "Sea Monkey Baby Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.seaMonkeyScale = biggerFishSettingsConfig.Bind("Sea Monkey Values", "Sea Monkey Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaMonkeySlowness = biggerFishSettingsConfig.Bind("Sea Monkey Values", "Sea Monkey Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaMonkeyHealth = biggerFishSettingsConfig.Bind("Sea Monkey Values", "Sea Monkey Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaMonkeyLimit = biggerFishSettingsConfig.Bind("Sea Monkey Values", "Sea Monkey Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.snowStalkerBabyScale = biggerFishSettingsConfig.Bind("Snow Stalker Baby Values", "Snow Stalker Baby Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.snowStalkerBabySlowness = biggerFishSettingsConfig.Bind("Snow Stalker Baby Values", "Snow Stalker Baby Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.snowStalkerBabyHealth = biggerFishSettingsConfig.Bind("Snow Stalker Baby Values", "Snow Stalker Baby Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.snowStalkerBabyLimit = biggerFishSettingsConfig.Bind("Snow Stalker Baby Values", "Snow Stalker Baby Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.snowStalkerScale = biggerFishSettingsConfig.Bind("Snow Stalker Values", "Snow Stalker Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.snowStalkerSlowness = biggerFishSettingsConfig.Bind("Snow Stalker Values", "Snow Stalker Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.snowStalkerHealth = biggerFishSettingsConfig.Bind("Snow Stalker Values", "Snow Stalker Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.snowStalkerLimit = biggerFishSettingsConfig.Bind("Snow Stalker Values", "Snow Stalker Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.rockPuncherScale = biggerFishSettingsConfig.Bind("Rock Puncher Values", "Rock Puncher Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.rockPuncherSlowness = biggerFishSettingsConfig.Bind("Rock Puncher Values", "Rock Puncher Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.rockPuncherHealth = biggerFishSettingsConfig.Bind("Rock Puncher Values", "Rock Puncher Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.rockPuncherLimit = biggerFishSettingsConfig.Bind("Rock Puncher Values", "Rock Puncher Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.smallVentGardenScale = biggerFishSettingsConfig.Bind("Small Ventgarden Values", "Small Ventgarden Scale", 1.0f, "The scale value for juvenile Ventgardens. This may break Ventgarden functionality.");
            MyModOptions.largeVentGardenScale = biggerFishSettingsConfig.Bind("Large Ventgarden Values", "Large Ventgarden Scale", 1.0f, "The scale value for mature Ventgardens. This may break Ventgarden functionality.");

            new MyModOptions();
        }
    }
#endif
}
