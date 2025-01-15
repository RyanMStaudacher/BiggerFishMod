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
            MyModOptions.removeFishSchools = biggerFishSettingsConfig.Bind("Remove Fish Schools", "Remove Fish Schools", false, "When enabled, removes the schools of smaller fish.");
            MyModOptions.proportionalToggle = biggerFishSettingsConfig.Bind("Proportional", "Proportional", false, "If enabled, all creatures will use the same values.");
            MyModOptions.proportionalScale = biggerFishSettingsConfig.Bind("Proportional Scale", "Proportional Scale", 1.0f, "The scale value all creatures will use when Proportional Toggle is enabled.");
            MyModOptions.proportionalSlowness = biggerFishSettingsConfig.Bind("Proportional Slowness", "Proportional Slowness", 1.0f, "The value at which all creatures will be slowed down to when Proportional Toggle is enabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.proportionalHealth = biggerFishSettingsConfig.Bind("Proportional Health", "Proportional Health", 1.0f, "All creatures health will be multiplied by this value when Proportional Toggle is enabled.");
            MyModOptions.proportionalCreatureLimit = biggerFishSettingsConfig.Bind("Proportional Creature Limit", "Proportional Creature Limit", 50.0f, "Limits the amount of active creatures(per each creature) to this value (Bigger creatures can create lots of clutter, this helps with that).");

            MyModOptions.biterScale = biggerFishSettingsConfig.Bind("Biter Scale", "Biter Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.biterSlowness = biggerFishSettingsConfig.Bind("Biter Slowness", "Biter Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.biterHealth = biggerFishSettingsConfig.Bind("Biter Health", "Biter Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.biterLimit = biggerFishSettingsConfig.Bind("Biter Limit", "Biter Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.bladderFishScale = biggerFishSettingsConfig.Bind("Bladderfish Scale", "Bladderfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.bladderFishSlowness = biggerFishSettingsConfig.Bind("Bladderfish Slowness", "Bladderfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.bladderFishHealth = biggerFishSettingsConfig.Bind("Bladderfish Health", "Bladderfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.bladderFishLimit = biggerFishSettingsConfig.Bind("Bladderfish Limit", "Bladderfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
           
            MyModOptions.bleederScale = biggerFishSettingsConfig.Bind("Bleeder Scale", "Bleeder Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.bleederSlowness = biggerFishSettingsConfig.Bind("Bleeder Slowness", "Bleeder Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.bleederHealth = biggerFishSettingsConfig.Bind("Bleeder Health", "Bleeder Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.bleederLimit = biggerFishSettingsConfig.Bind("Bleeder Limit", "Bleeder Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.boneSharkScale = biggerFishSettingsConfig.Bind("Bone Shark Scale", "Bone Shark Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.boneSharkSlowness = biggerFishSettingsConfig.Bind("Bone Shark Slowness", "Bone Shark Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.boneSharkHealth = biggerFishSettingsConfig.Bind("Bone Shark Health", "Bone Shark Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.boneSharkLimit = biggerFishSettingsConfig.Bind("Bone Shark Limit", "Bone Shark Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.boomerangScale = biggerFishSettingsConfig.Bind("Boomerang Scale", "Boomerang Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.boomerangHealth = biggerFishSettingsConfig.Bind("Boomerang Health", "Boomerang Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.boomerangSlowness = biggerFishSettingsConfig.Bind("Boomerang Slowness", "Boomerang Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.boomerangLimit = biggerFishSettingsConfig.Bind("Boomerang Limit", "Boomerang Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.caveCrawlerScale = biggerFishSettingsConfig.Bind("Cave Crawler Scale", "Cave Crawler Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.caveCrawlerSlowness = biggerFishSettingsConfig.Bind("Cave Crawler Slowness", "Cave Crawler Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.caveCrawlerHealth = biggerFishSettingsConfig.Bind("Cave Crawler Health", "Cave Crawler Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.caveCrawlerLimit = biggerFishSettingsConfig.Bind("Cave Crawler Limit", "Cave Crawler Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.crabSnakeScale = biggerFishSettingsConfig.Bind("Crab Snake Scale", "Crab Snake Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.crabSnakeSlowness = biggerFishSettingsConfig.Bind("Crab Snake Slowness", "Crab Snake Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.crabSnakeHealth = biggerFishSettingsConfig.Bind("Crab Snake Health", "Crab Snake Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.crabSnakeLimit = biggerFishSettingsConfig.Bind("Crab Snake Limit", "Crab Snake Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.crabSquidScale = biggerFishSettingsConfig.Bind("Crab Squid Scale", "Crab Squid Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.crabSquidSlowness = biggerFishSettingsConfig.Bind("Crab Squid Slowness", "Crab Squid Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.crabSquidHealth = biggerFishSettingsConfig.Bind("Crab Squid Health", "Crab Squid Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.crabSquidLimit = biggerFishSettingsConfig.Bind("Crab Squid Limit", "Crab Squid Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.crashFishScale = biggerFishSettingsConfig.Bind("Crash Fish Scale", "Crash Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.crashFishSlowness = biggerFishSettingsConfig.Bind("Crash Fish Slowness", "Crash Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.crashFishHealth = biggerFishSettingsConfig.Bind("Crash Fish Health", "Crash Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.crashFishLimit = biggerFishSettingsConfig.Bind("Crash Fish Limit", "Crash Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.cuddleFishScale = biggerFishSettingsConfig.Bind("Cuddlefish Scale", "Cuddlefish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.cuddleFishSlowness = biggerFishSettingsConfig.Bind("Cuddlefish Slowness", "Cuddlefish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.cuddleFishHealth = biggerFishSettingsConfig.Bind("Cuddlefish Health", "Cuddlefish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.cuddleFishLimit = biggerFishSettingsConfig.Bind("Cuddlefish Limit", "Cuddlefish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.eyeyeScale = biggerFishSettingsConfig.Bind("Eyeye Scale", "Eyeye Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.eyeyeSlowness = biggerFishSettingsConfig.Bind("Eyeye Slowness", "Eyeye Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.eyeyeHealth = biggerFishSettingsConfig.Bind("Eyeye Health", "Eyeye Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.eyeyeLimit = biggerFishSettingsConfig.Bind("Eyeye Limit", "Eyeye Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.garryFishScale = biggerFishSettingsConfig.Bind("Garry Fish Scale", "Garry Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.garryFishSlowness = biggerFishSettingsConfig.Bind("Garry Fish Slowness", "Garry Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.garryFishHealth = biggerFishSettingsConfig.Bind("Garry Fish Health", "Garry Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.garryFishLimit = biggerFishSettingsConfig.Bind("Garry Fish Limit", "Garry Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.gasopodScale = biggerFishSettingsConfig.Bind("Gasopod Scale", "Gasopod Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.gasopodSlowness = biggerFishSettingsConfig.Bind("Gasopod Slowness", "Gasopod Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.gasopodHealth = biggerFishSettingsConfig.Bind("Gasopod Health", "Gasopod Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.gasopodLimit = biggerFishSettingsConfig.Bind("Gasopod Limit", "Gasopod Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.ghostLeviathanScale = biggerFishSettingsConfig.Bind("Ghost Leviathan Scale", "Ghost Leviathan Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.ghostLeviathanSlowness = biggerFishSettingsConfig.Bind("Ghost Leviathan Slowness", "Ghost Leviathan Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.ghostLeviathanHealth = biggerFishSettingsConfig.Bind("Ghost Leviathan Health", "Ghost Leviathan Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.ghostLeviathanLimit = biggerFishSettingsConfig.Bind("Ghost Leviathan Limit", "Ghost Leviathan Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.voidGhostLeviathanScale = biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Scale", "Ghost Leviathan(Void) Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.voidGhostLeviathanSlowness = biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Slowness", "Ghost Leviathan(Void) Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.voidGhostLeviathanHealth = biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Health", "Ghost Leviathan(Void) Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.voidGhostLeviathanLimit = biggerFishSettingsConfig.Bind("Ghost Leviathan(Void) Limit", "Ghost Leviathan(Void) Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.ghostRayScale = biggerFishSettingsConfig.Bind("Ghost Ray Scale", "Ghost Ray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.ghostRaySlowness = biggerFishSettingsConfig.Bind("Ghost Ray Slowness", "Ghost Ray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.ghostRayHealth = biggerFishSettingsConfig.Bind("Ghost Ray Health", "Ghost Ray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.ghostRayLimit = biggerFishSettingsConfig.Bind("Ghost Ray Limit", "Ghost Ray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.holeFishScale = biggerFishSettingsConfig.Bind("Hole Fish Scale", "Hole Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.holeFishSlowness = biggerFishSettingsConfig.Bind("Hole Fish Slowness", "Hole Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.holeFishHealth = biggerFishSettingsConfig.Bind("Hole Fish Health", "Hole Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.holeFishLimit = biggerFishSettingsConfig.Bind("Hole Fish Limit", "Hole Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.hoopFishScale = biggerFishSettingsConfig.Bind("Hoop Fish Scale", "Hoop Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.hoopFishSlowness = biggerFishSettingsConfig.Bind("Hoop Fish Slowness", "Hoop Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.hoopFishHealth = biggerFishSettingsConfig.Bind("Hoop Fish Health", "Hoop Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.hoopFishLimit = biggerFishSettingsConfig.Bind("Hoop Fish Limit", "Hoop Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.hoverFishScale = biggerFishSettingsConfig.Bind("Hover Fish Scale", "Hover Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.hoverFishSlowness = biggerFishSettingsConfig.Bind("Hover Fish Slowness", "Hover Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.hoverFishHealth = biggerFishSettingsConfig.Bind("Hover Fish Health", "Hover Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.hoverFishLimit = biggerFishSettingsConfig.Bind("Hover Fish Limit", "Hover Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.jellyRayScale = biggerFishSettingsConfig.Bind("Jellyray Scale", "Jellyray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.jellyRaySlowness = biggerFishSettingsConfig.Bind("Jellyray Slowness", "Jellyray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.jellyRayHealth = biggerFishSettingsConfig.Bind("Jellyray Health", "Jellyray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.jellyRayLimit = biggerFishSettingsConfig.Bind("Jellyray Limit", "Jellyray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.jumperScale = biggerFishSettingsConfig.Bind("Shuttlebug Scale", "Shuttlebug Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.jumperSlowness = biggerFishSettingsConfig.Bind("Shuttlebug Slowness", "Shuttlebug Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.jumperHealth = biggerFishSettingsConfig.Bind("Shuttlebug Health", "Shuttlebug Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.jumperLimit = biggerFishSettingsConfig.Bind("Shuttlebug Limit", "Shuttlebug Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.lavaLarvaScale = biggerFishSettingsConfig.Bind("Lava Larva Scale", "Lava Larva Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.lavaLarvaSlowness = biggerFishSettingsConfig.Bind("Lava Larva Slowness", "Lava Larva Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.lavaLarvaHealth = biggerFishSettingsConfig.Bind("Lava Larva Health", "Lava Larva Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.lavaLarvaLimit = biggerFishSettingsConfig.Bind("Lava Larva Limit", "Lava Larva Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
           
            MyModOptions.lavaLizardScale = biggerFishSettingsConfig.Bind("Lava Lizard Scale", "Lava Lizard Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.lavaLizardSlowness = biggerFishSettingsConfig.Bind("Lava Lizard Slowness", "Lava Lizard Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.lavaLizardHealth = biggerFishSettingsConfig.Bind("Lava Lizard Health", "Lava Lizard Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.lavaLizardLimit = biggerFishSettingsConfig.Bind("Lava Lizard Limit", "Lava Lizard Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.mesmerScale = biggerFishSettingsConfig.Bind("Mesmer Scale", "Mesmer Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.mesmerSlowness = biggerFishSettingsConfig.Bind("Mesmer Slowness", "Mesmer Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.mesmerHealth = biggerFishSettingsConfig.Bind("Mesmer Health", "Mesmer Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.mesmerLimit = biggerFishSettingsConfig.Bind("Mesmer Limit", "Mesmer Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.oculusFishScale = biggerFishSettingsConfig.Bind("Oculus Fish Scale", "Oculus Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.oculusFishSlowness = biggerFishSettingsConfig.Bind("Oculus Fish Slowness", "Oculus Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.oculusFishHealth = biggerFishSettingsConfig.Bind("Oculus Fish Health", "Oculus Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.oculusFishLimit = biggerFishSettingsConfig.Bind("Oculus Fish Limit", "Oculus Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.peeperScale = biggerFishSettingsConfig.Bind("Peeper Scale", "Peeper Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.peeperSlowness = biggerFishSettingsConfig.Bind("Peeper Slowness", "Peeper Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.peeperHealth = biggerFishSettingsConfig.Bind("Peeper Health", "Peeper Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.peeperLimit = biggerFishSettingsConfig.Bind("Peeper Limit", "Peeper Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.rabbitRayScale = biggerFishSettingsConfig.Bind("Rabbit Ray Scale", "Rabbit Ray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.rabbitRaySlowness = biggerFishSettingsConfig.Bind("Rabbit Ray Slowness", "Rabbit Ray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.rabbitRayHealth = biggerFishSettingsConfig.Bind("Rabbit Ray Health", "Rabbit Ray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.rabbitRayLimit = biggerFishSettingsConfig.Bind("Rabbit Ray Limit", "Rabbit Ray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
           
            MyModOptions.reaperLeviathanScale = biggerFishSettingsConfig.Bind("Reaper Leviathan Scale", "Reaper Leviathan Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.reaperLeviathanSlowness = biggerFishSettingsConfig.Bind("Reaper Leviathan Slowness", "Reaper Leviathan Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.reaperLeviathanHealth = biggerFishSettingsConfig.Bind("Reaper Leviathan Health", "Reaper Leviathan Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.reaperLeviathanLimit = biggerFishSettingsConfig.Bind("Reaper Leviathan Limit", "Reaper Leviathan Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.reefbackScale = biggerFishSettingsConfig.Bind("Reefback Scale", "Reefback Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.reefbackSlowness = biggerFishSettingsConfig.Bind("Reefback Slowness", "Reefback Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.reefbackHealth = biggerFishSettingsConfig.Bind("Reefback Health", "Reefback Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.reefbackLimit = biggerFishSettingsConfig.Bind("Reefback Limit", "Reefback Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.reginaldScale = biggerFishSettingsConfig.Bind("Reginald Scale", "Reginald Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.reginaldSlowness = biggerFishSettingsConfig.Bind("Reginald Slowness", "Reginald Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.reginaldHealth = biggerFishSettingsConfig.Bind("Reginald Health", "Reginald Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.reginaldLimit = biggerFishSettingsConfig.Bind("Reginald Limit", "Reginald Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.sandSharkScale = biggerFishSettingsConfig.Bind("Sand Shark Scale", "Sand Shark Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.sandSharkSlowness = biggerFishSettingsConfig.Bind("Sand Shark Slowness", "Sand Shark Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.sandSharkHealth = biggerFishSettingsConfig.Bind("Sand Shark Health", "Sand Shark Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.sandSharkLimit = biggerFishSettingsConfig.Bind("Sand Shark Limit", "Sand Shark Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.seaDragonScale = biggerFishSettingsConfig.Bind("Sea Dragon Scale", "Sea Dragon Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaDragonSlowness = biggerFishSettingsConfig.Bind("Sea Dragon Slowness", "Sea Dragon Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaDragonHealth = biggerFishSettingsConfig.Bind("Sea Dragon Health", "Sea Dragon Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaDragonLimit = biggerFishSettingsConfig.Bind("Sea Dragon Limit", "Sea Dragon Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.seaEmperorBabyScale = biggerFishSettingsConfig.Bind("Sea Emperor Baby Scale", "Sea Emperor Baby Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaEmperorBabySlowness = biggerFishSettingsConfig.Bind("Sea Emperor Baby Slowness", "Sea Emperor Baby Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaEmperorBabyHealth = biggerFishSettingsConfig.Bind("Sea Emperor Baby Health", "Sea Emperor Baby Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaEmperorBabyLimit = biggerFishSettingsConfig.Bind("Sea Emperor Baby Limit", "Sea Emperor Baby Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.seaEmperorJuvenileScale = biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Scale", "Sea Emperor Juvenile Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaEmperorJuvenileSlowness = biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Slowness", "Sea Emperor Juvenile Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaEmperorJuvenileHealth = biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Health", "Sea Emperor Juvenile Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaEmperorJuvenileLimit = biggerFishSettingsConfig.Bind("Sea Emperor Juvenile Limit", "Sea Emperor Juvenile Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.seaTreaderScale = biggerFishSettingsConfig.Bind("Sea Treader Scale", "Sea Treader Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaTreaderSlowness = biggerFishSettingsConfig.Bind("Sea Treader Slowness", "Sea Treader Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaTreaderHealth = biggerFishSettingsConfig.Bind("Sea Treader Health", "Sea Treader Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaTreaderHealth = biggerFishSettingsConfig.Bind("Sea Treader Health", "Sea Treader Health", 1.0f, "The value to multiply this creature's health by."); MyModOptions.seaTreaderLimit = biggerFishSettingsConfig.Bind("Sea Treader Limit", "Sea Treader Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.shockerScale = biggerFishSettingsConfig.Bind("Ampeel Scale", "Ampeel Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.shockerSlowness = biggerFishSettingsConfig.Bind("Ampeel Slowness", "Ampeel Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.shockerHealth = biggerFishSettingsConfig.Bind("Ampeel Health", "Ampeel Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.shockerLimit = biggerFishSettingsConfig.Bind("Ampeel Limit", "Ampeel Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.spadeFishScale = biggerFishSettingsConfig.Bind("Spade Fish Scale", "Spade Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.spadeFishSlowness = biggerFishSettingsConfig.Bind("Spade Fish Slowness", "Spade Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.spadeFishHealth = biggerFishSettingsConfig.Bind("Spade Fish Health", "Spade Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.spadeFishLimit = biggerFishSettingsConfig.Bind("Spade Fish Limit", "Spade Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.spineEelScale = biggerFishSettingsConfig.Bind("River Prowler Scale", "River Prowler Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.spineEelSlowness = biggerFishSettingsConfig.Bind("River Prowler Slowness", "River Prowler Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.spineEelHealth = biggerFishSettingsConfig.Bind("River Prowler Health", "River Prowler Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.spineEelLimit = biggerFishSettingsConfig.Bind("River Prowler Limit", "River Prowler Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            
            MyModOptions.stalkerScale = biggerFishSettingsConfig.Bind("Stalker Scale", "Stalker Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.stalkerSlowness = biggerFishSettingsConfig.Bind("Stalker Slowness", "Stalker Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.stalkerHealth = biggerFishSettingsConfig.Bind("Stalker Health", "Stalker Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.stalkerLimit = biggerFishSettingsConfig.Bind("Stalker Limit", "Stalker Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
           
            MyModOptions.warperScale = biggerFishSettingsConfig.Bind("Warper Scale", "Warper Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.warperSlowness = biggerFishSettingsConfig.Bind("Warper Slowness", "Warper Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.warperHealth = biggerFishSettingsConfig.Bind("Warper Health", "Warper Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.warperLimit = biggerFishSettingsConfig.Bind("Warper Limit", "Warper Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");

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

            MyModOptions.removeFishSchools = biggerFishSettingsConfig.Bind("Remove Fish Schools", "Remove Fish Schools", false, "When enabled, removes the schools of smaller fish.");
            MyModOptions.proportionalToggle = biggerFishSettingsConfig.Bind("Proportional", "Proportional", false, "If enabled, all creatures will use the same values.");
            MyModOptions.proportionalScale = biggerFishSettingsConfig.Bind("Proportional Scale", "Proportional Scale", 1.0f, "The scale value all creatures will use when Proportional Toggle is enabled.");
            MyModOptions.proportionalSlowness = biggerFishSettingsConfig.Bind("Proportional Slowness", "Proportional Slowness", 1.0f, "The value at which all creatures will be slowed down to when Proportional Toggle is enabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.proportionalHealth = biggerFishSettingsConfig.Bind("Proportional Health", "Proportional Health", 1.0f, "All creatures health will be multiplied by this value when Proportional Toggle is enabled.");
            MyModOptions.proportionalCreatureLimit = biggerFishSettingsConfig.Bind("Proportional Creature Limit", "Proportional Creature Limit", 50.0f, "Limits the amount of active creatures(per each creature) to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.peeperScale = biggerFishSettingsConfig.Bind("Arctic Peeper Scale", "Arctic Peeper Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.peeperSlowness = biggerFishSettingsConfig.Bind("Arctic Peeper Slowness", "Arctic Peeper Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.peeperLimit = biggerFishSettingsConfig.Bind("Arctic Peeper Limit", "Arctic Peeper Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.peeperHealth = biggerFishSettingsConfig.Bind("Arctic Peeper Health", "Arctic Peeper Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.arrowRayScale = biggerFishSettingsConfig.Bind("Arrow Ray Scale", "Arrow Ray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.arrowRaySlowness = biggerFishSettingsConfig.Bind("Arrow Ray Slowness", "Arrow Ray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.arrowRayHealth = biggerFishSettingsConfig.Bind("Arrow Ray Health", "Arrow Ray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.arrowRayLimit = biggerFishSettingsConfig.Bind("Arrow Ray Limit", "Arrow Ray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.boomerangScale = biggerFishSettingsConfig.Bind("Boomerang Scale", "Boomerang Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.boomerangSlowness = biggerFishSettingsConfig.Bind("Boomerang Slowness", "Boomerang Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.boomerangHealth = biggerFishSettingsConfig.Bind("Boomerang Health", "Boomerang Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.boomerangLimit = biggerFishSettingsConfig.Bind("Boomerang Limit", "Boomerang Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.bladderFishScale = biggerFishSettingsConfig.Bind("Bladderfish Scale", "Bladderfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.bladderFishSlowness = biggerFishSettingsConfig.Bind("Bladderfish Slowness", "Bladderfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.bladderFishHealth = biggerFishSettingsConfig.Bind("Bladderfish Health", "Bladderfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.bladderFishLimit = biggerFishSettingsConfig.Bind("Bladderfish Limit", "Bladderfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.hoopFishScale = biggerFishSettingsConfig.Bind("Hoopfish Scale", "Hoopfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.hoopFishSlowness = biggerFishSettingsConfig.Bind("Hoopfish Slowness", "Hoopfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.hoopFishHealth = biggerFishSettingsConfig.Bind("Hoopfish Health", "Hoopfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.hoopFishLimit = biggerFishSettingsConfig.Bind("Hoopfish Limit", "Hoopfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.discusFishScale = biggerFishSettingsConfig.Bind("Discusfish Scale", "Discusfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.discusFishSlowness = biggerFishSettingsConfig.Bind("Discusfish Slowness", "Discusfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.discusFishHealth = biggerFishSettingsConfig.Bind("Discusfish Health", "Discusfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.discusFishLimit = biggerFishSettingsConfig.Bind("Discusfish Limit", "Discusfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.featherFishScale = biggerFishSettingsConfig.Bind("Featherfish Scale", "Featherfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.featherFishSlowness = biggerFishSettingsConfig.Bind("Featherfish Slowness", "Featherfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.featherFishHealth = biggerFishSettingsConfig.Bind("Featherfish Health", "Featherfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.featherFishLimit = biggerFishSettingsConfig.Bind("Featherfish Limit", "Featherfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.nootFishScale = biggerFishSettingsConfig.Bind("Nootfish Scale", "Nootfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.nootFishSlowness = biggerFishSettingsConfig.Bind("Nootfish Slowness", "Nootfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.nootFishHealth = biggerFishSettingsConfig.Bind("Nootfish Health", "Nootfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.nootFishLimit = biggerFishSettingsConfig.Bind("Nootfish Limit", "Nootfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            //MyModOptions.spineFishScale = biggerFishSettingsConfig.Bind("spineFish Scale", "spineFish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            //MyModOptions.spineFishSlowness = biggerFishSettingsConfig.Bind("spineFish Slowness", "spineFish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            //MyModOptions.spineFishLimit = biggerFishSettingsConfig.Bind("Spine Fish Limit", "Spine Fish Limit", 1.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.spinnerFishScale = biggerFishSettingsConfig.Bind("Spinnerfish Scale", "Spinnerfish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.spinnerFishSlowness = biggerFishSettingsConfig.Bind("Spinnerfish Slowness", "Spinnerfish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.spinnerFishHealth = biggerFishSettingsConfig.Bind("Spinnerfish Health", "Spinnerfish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.spinnerFishLimit = biggerFishSettingsConfig.Bind("Spinnerfish Limit", "Spinnerfish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.arcticRayScale = biggerFishSettingsConfig.Bind("Arctic Ray Scale", "Arctic Ray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.arcticRaySlowness = biggerFishSettingsConfig.Bind("Arctic Ray Slowness", "Arctic Ray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.arcticRayHealth = biggerFishSettingsConfig.Bind("Arctic Ray Health", "Arctic Ray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.arcticRayLimit = biggerFishSettingsConfig.Bind("Arctic Ray Limit", "Arctic Ray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.jellyFishScale = biggerFishSettingsConfig.Bind("Eye Jelly Scale", "Eye Jelly Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.jellyFishSlowness = biggerFishSettingsConfig.Bind("Eye Jelly Slowness", "Eye Jelly Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.jellyFishHealth = biggerFishSettingsConfig.Bind("Eye Jelly Health", "Eye Jelly Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.jellyFishLimit = biggerFishSettingsConfig.Bind("Eye Jelly Limit", "Eye Jelly Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.titanHoleFishScale = biggerFishSettingsConfig.Bind("Titan Hole Fish Scale", "Titan Hole Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.titanHoleFishSlowness = biggerFishSettingsConfig.Bind("Titan Hole Fish Slowness", "Titan Hole Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.titanHoleFishHealth = biggerFishSettingsConfig.Bind("Titan Hole Fish Health", "Titan Hole Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.titanHoleFishLimit = biggerFishSettingsConfig.Bind("Titan Hole Fish Limit", "Titan Hole Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.glowWhaleScale = biggerFishSettingsConfig.Bind("Glow Whale Scale", "Glow Whale Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.glowWhaleSlowness = biggerFishSettingsConfig.Bind("Glow Whale Slowness", "Glow Whale Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.glowWhaleHealth = biggerFishSettingsConfig.Bind("Glow Whale Health", "Glow Whale Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.glowWhaleLimit = biggerFishSettingsConfig.Bind("Glow Whale Limit", "Glow Whale Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.pinnacaridScale = biggerFishSettingsConfig.Bind("Pinnacarid Scale", "Pinnacarid Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.pinnacaridSlowness = biggerFishSettingsConfig.Bind("Pinnacarid Slowness", "Pinnacarid Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.pinnacaridHealth = biggerFishSettingsConfig.Bind("Pinnacarid Health", "Pinnacarid Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.pinnacaridLimit = biggerFishSettingsConfig.Bind("Pinnacarid Limit", "Pinnacarid Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.triopsScale = biggerFishSettingsConfig.Bind("Triops Scale", "Triops Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.triopsSlowness = biggerFishSettingsConfig.Bind("Triops Slowness", "Triops Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.triopsHealth = biggerFishSettingsConfig.Bind("Triops Health", "Triops Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.triopsLimit = biggerFishSettingsConfig.Bind("Triops Limit", "Triops Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.trivalveScale = biggerFishSettingsConfig.Bind("Trivalve Scale", "Trivalve Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.trivalveSlowness = biggerFishSettingsConfig.Bind("Trivalve Slowness", "Trivalve Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.trivalveHealth = biggerFishSettingsConfig.Bind("Trivalve Health", "Trivalve Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.trivalveLimit = biggerFishSettingsConfig.Bind("Trivalve Limit", "Trivalve Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.symbioteFishScale = biggerFishSettingsConfig.Bind("Symbiotefish Scale", "Symbiotefish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.symbioteFishSlowness = biggerFishSettingsConfig.Bind("Symbiotefish Slowness", "Symbiotefish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.symbioteFishHealth = biggerFishSettingsConfig.Bind("Symbiotefish Health", "Symbiotefish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.symbioteFishLimit = biggerFishSettingsConfig.Bind("Symbiotefish Limit", "Symbiotefish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.rockGrubScale = biggerFishSettingsConfig.Bind("Rock Grub Scale", "Rock Grub Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.rockGrubSlowness = biggerFishSettingsConfig.Bind("Rock Grub Slowness", "Rock Grub Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.rockGrubHealth = biggerFishSettingsConfig.Bind("Rock Grub Health", "Rock Grub Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.rockGrubLimit = biggerFishSettingsConfig.Bind("Rock Grub Limit", "Rock Grub Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.crashFishScale = biggerFishSettingsConfig.Bind("Crash Fish Scale", "Crash Fish Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.crashFishSlowness = biggerFishSettingsConfig.Bind("Crash Fish Slowness", "Crash Fish Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.crashFishHealth = biggerFishSettingsConfig.Bind("Crash Fish Health", "Crash Fish Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.crashFishLimit = biggerFishSettingsConfig.Bind("Crash Fish Limit", "Crash Fish Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.brineWingScale = biggerFishSettingsConfig.Bind("Brinewing Scale", "Brinewing Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.brineWingSlowness = biggerFishSettingsConfig.Bind("Brinewing Slowness", "Brinewing Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.brineWingHealth = biggerFishSettingsConfig.Bind("Brinewing Health", "Brinewing Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.brineWingLimit = biggerFishSettingsConfig.Bind("Brinewing Limit", "Brinewing Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.lilyPaddlerScale = biggerFishSettingsConfig.Bind("Lily Paddler Scale", "Lily Paddler Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.lilyPaddlerSlowness = biggerFishSettingsConfig.Bind("Lily Paddler Slowness", "Lily Paddler Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.lilyPaddlerHealth = biggerFishSettingsConfig.Bind("Lily Paddler Health", "Lily Paddler Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.lilyPaddlerLimit = biggerFishSettingsConfig.Bind("Lily Paddler Limit", "Lily Paddler Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.cryptosuchusScale = biggerFishSettingsConfig.Bind("Cryptosuchus Scale", "Cryptosuchus Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.cryptosuchusSlowness = biggerFishSettingsConfig.Bind("Cryptosuchus Slowness", "Cryptosuchus Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.cryptosuchusHealth = biggerFishSettingsConfig.Bind("Cryptosuchus Health", "Cryptosuchus Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.cryptosuchusLimit = biggerFishSettingsConfig.Bind("Cryptosuchus Limit", "Cryptosuchus Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.bruteSharkScale = biggerFishSettingsConfig.Bind("Brute Shark Scale", "Brute Shark Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.bruteSharkSlowness = biggerFishSettingsConfig.Bind("Brute Shark Slowness", "Brute Shark Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.bruteSharkHealth = biggerFishSettingsConfig.Bind("Brute Shark Health", "Brute Shark Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.bruteSharkLimit = biggerFishSettingsConfig.Bind("Brute Shark Limit", "Brute Shark Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.squidSharkScale = biggerFishSettingsConfig.Bind("Squid Shark Scale", "Squid Shark Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.squidSharkSlowness = biggerFishSettingsConfig.Bind("Squid Shark Slowness", "Squid Shark Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.squidSharkHealth = biggerFishSettingsConfig.Bind("Squid Shark Health", "Squid Shark Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.squidSharkLimit = biggerFishSettingsConfig.Bind("Squid Shark Limit", "Squid Shark Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.chelicerateScale = biggerFishSettingsConfig.Bind("Chelicerate Scale", "Chelicerate Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.chelicerateSlowness = biggerFishSettingsConfig.Bind("Chelicerate Slowness", "Chelicerate Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.chelicerateHealth = biggerFishSettingsConfig.Bind("Chelicerate Health", "Chelicerate Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.chelicerateLimit = biggerFishSettingsConfig.Bind("Chelicerate Limit", "Chelicerate Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.shadowLeviathanScale = biggerFishSettingsConfig.Bind("Shadow Leviathan Scale", "Shadow Leviathan Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.shadowLeviathanSlowness = biggerFishSettingsConfig.Bind("Shadow Leviathan Slowness", "Shadow Leviathan Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.shadowLeviathanHealth = biggerFishSettingsConfig.Bind("Shadow Leviathan Health", "Shadow Leviathan Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.shadowLeviathanLimit = biggerFishSettingsConfig.Bind("Shadow Leviathan Limit", "Shadow Leviathan Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.voidLeviathanScale = biggerFishSettingsConfig.Bind("Void Leviathan Scale", "Void Leviathan Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.voidLeviathanSlowness = biggerFishSettingsConfig.Bind("Void Leviathan Slowness", "Void Leviathan Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.voidLeviathanHealth = biggerFishSettingsConfig.Bind("Void Leviathan Health", "Void Leviathan Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.voidLeviathanLimit = biggerFishSettingsConfig.Bind("Void Leviathan Limit", "Void Leviathan Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.skyRayScale = biggerFishSettingsConfig.Bind("Skyray Scale", "Skyray Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.skyRaySlowness = biggerFishSettingsConfig.Bind("Skyray Slowness", "Skyray Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.skyRayHealth = biggerFishSettingsConfig.Bind("Skyray Health", "Skyray Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.skyRayLimit = biggerFishSettingsConfig.Bind("Skyray Limit", "Skyray Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.penglingScale = biggerFishSettingsConfig.Bind("Pengling Scale", "Pengling Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.penglingSlowness = biggerFishSettingsConfig.Bind("Pengling Slowness", "Pengling Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.penglingHealth = biggerFishSettingsConfig.Bind("Pengling Health", "Pengling Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.penglingLimit = biggerFishSettingsConfig.Bind("Pengling Limit", "Pengling Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.pengwingScale = biggerFishSettingsConfig.Bind("Pengwing Scale", "Pengwing Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.pengwingSlowness = biggerFishSettingsConfig.Bind("Pengwing Slowness", "Pengwing Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.pengwingHealth = biggerFishSettingsConfig.Bind("Pengwing Health", "Pengwing Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.pengwingLimit = biggerFishSettingsConfig.Bind("Pengwing Limit", "Pengwing Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.seaMonkeyBabyScale = biggerFishSettingsConfig.Bind("Sea Monkey Baby Scale", "Sea Monkey Baby Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaMonkeyBabySlowness = biggerFishSettingsConfig.Bind("Sea Monkey Baby Slowness", "Sea Monkey Baby Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaMonkeyBabyHealth = biggerFishSettingsConfig.Bind("Sea Monkey Baby Health", "Sea Monkey Baby Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaMonkeyBabyLimit = biggerFishSettingsConfig.Bind("Sea Monkey Baby Limit", "Sea Monkey Baby Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.seaMonkeyScale = biggerFishSettingsConfig.Bind("Sea Monkey Scale", "Sea Monkey Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.seaMonkeySlowness = biggerFishSettingsConfig.Bind("Sea Monkey Slowness", "Sea Monkey Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.seaMonkeyHealth = biggerFishSettingsConfig.Bind("Sea Monkey Health", "Sea Monkey Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.seaMonkeyLimit = biggerFishSettingsConfig.Bind("Sea Monkey Limit", "Sea Monkey Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.snowStalkerBabyScale = biggerFishSettingsConfig.Bind("Snow Stalker Baby Scale", "Snow Stalker Baby Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.snowStalkerBabySlowness = biggerFishSettingsConfig.Bind("Snow Stalker Baby Slowness", "Snow Stalker Baby Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.snowStalkerBabyHealth = biggerFishSettingsConfig.Bind("Snow Stalker Baby Health", "Snow Stalker Baby Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.snowStalkerBabyLimit = biggerFishSettingsConfig.Bind("Snow Stalker Baby Limit", "Snow Stalker Baby Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.snowStalkerScale = biggerFishSettingsConfig.Bind("Snow Stalker Scale", "Snow Stalker Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.snowStalkerSlowness = biggerFishSettingsConfig.Bind("Snow Stalker Slowness", "Snow Stalker Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.snowStalkerHealth = biggerFishSettingsConfig.Bind("Snow Stalker Health", "Snow Stalker Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.snowStalkerLimit = biggerFishSettingsConfig.Bind("Snow Stalker Limit", "Snow Stalker Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.rockPuncherScale = biggerFishSettingsConfig.Bind("Rock Puncher Scale", "Rock Puncher Scale", 1.0f, "The scale value this creature will use when Proportional Toggle is disabled.");
            MyModOptions.rockPuncherSlowness = biggerFishSettingsConfig.Bind("Rock Puncher Slowness", "Rock Puncher Slowness", 1.0f, "The value at which this this creature will be slowed down to when Proportional Toggle is disabled (So bigger creatures don't move so quickly). Higher number = slower.");
            MyModOptions.rockPuncherHealth = biggerFishSettingsConfig.Bind("Rock Puncher Health", "Rock Puncher Health", 1.0f, "The value to multiply this creature's health by.");
            MyModOptions.rockPuncherLimit = biggerFishSettingsConfig.Bind("Rock Puncher Limit", "Rock Puncher Limit", 50.0f, "Limits the amount of active creatures to this value (Bigger creatures can create lots of clutter, this helps with that).");
            MyModOptions.smallVentGardenScale = biggerFishSettingsConfig.Bind("Small Ventgarden Scale", "Small Ventgarden Scale", 1.0f, "The scale value for juvenile Ventgardens. This may break Ventgarden functionality.");
            MyModOptions.largeVentGardenScale = biggerFishSettingsConfig.Bind("Large Ventgarden Scale", "Large Ventgarden Scale", 1.0f, "The scale value for mature Ventgardens. This may break Ventgarden functionality.");

            new MyModOptions();
        }
    }
#endif
}
