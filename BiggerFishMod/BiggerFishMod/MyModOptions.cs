﻿using BepInEx.Configuration;
using Nautilus.Handlers;
using Nautilus.Options;
using System.Collections.Generic;
using System.Linq;

namespace BiggerFishMod
{
#if SUBNAUTICA
    public class MyModOptions : ModOptions
    {
        #region Config Entries
        public static ConfigEntry<bool> removeFishSchools;
        public static ConfigEntry<bool> proportionalToggle;
        public static ConfigEntry<float> proportionalScale;
        public static ConfigEntry<float> proportionalSlowness;
        public static ConfigEntry<float> proportionalHealth;
        public static ConfigEntry<float> proportionalCreatureLimit;
        public static ConfigEntry<bool> proportionalRandomize;
        public static ConfigEntry<float> proportionalRandomizeMin;
        public static ConfigEntry<float> proportionalRandomizeMax;

        public static ConfigEntry<bool> biterExclude;
        public static ConfigEntry<float> biterScale;
        public static ConfigEntry<float> biterSlowness;
        public static ConfigEntry<float> biterHealth;
        public static ConfigEntry<float> biterLimit;
        public static ConfigEntry<bool> biterRandomize;
        public static ConfigEntry<float> biterRandomizeMin;
        public static ConfigEntry<float> biterRandomizeMax;
        public static ConfigEntry<float> biterBaseHealth;
        public static ConfigEntry<float> biterBaseMaxAcceleration;
        public static ConfigEntry<float> biterBaseForwardRotationSpeed;
        public static ConfigEntry<float> biterBaseUpRotationSpeed;
        public static ConfigEntry<float> biterBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> bladderFishExclude;
        public static ConfigEntry<float> bladderFishScale;
        public static ConfigEntry<float> bladderFishSlowness;
        public static ConfigEntry<float> bladderFishHealth;
        public static ConfigEntry<float> bladderFishLimit;
        public static ConfigEntry<bool> bladderFishRandomize;
        public static ConfigEntry<float> bladderFishRandomizeMin;
        public static ConfigEntry<float> bladderFishRandomizeMax;
        public static ConfigEntry<float> bladderFishBaseHealth;
        public static ConfigEntry<float> bladderFishBaseMaxAcceleration;
        public static ConfigEntry<float> bladderFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> bladderFishBaseUpRotationSpeed;
        public static ConfigEntry<float> bladderFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> bleederExclude;
        public static ConfigEntry<float> bleederScale;
        public static ConfigEntry<float> bleederSlowness;
        public static ConfigEntry<float> bleederHealth;
        public static ConfigEntry<float> bleederLimit;
        public static ConfigEntry<bool> bleederRandomize;
        public static ConfigEntry<float> bleederRandomizeMin;
        public static ConfigEntry<float> bleederRandomizeMax;
        public static ConfigEntry<float> bleederBaseHealth;
        public static ConfigEntry<float> bleederBaseMaxAcceleration;
        public static ConfigEntry<float> bleederBaseForwardRotationSpeed;
        public static ConfigEntry<float> bleederBaseUpRotationSpeed;
        public static ConfigEntry<float> bleederBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> boneSharkExclude;
        public static ConfigEntry<float> boneSharkScale;
        public static ConfigEntry<float> boneSharkSlowness;
        public static ConfigEntry<float> boneSharkHealth;
        public static ConfigEntry<float> boneSharkLimit;
        public static ConfigEntry<bool> boneSharkRandomize;
        public static ConfigEntry<float> boneSharkRandomizeMin;
        public static ConfigEntry<float> boneSharkRandomizeMax;
        public static ConfigEntry<float> boneSharkBaseHealth;
        public static ConfigEntry<float> boneSharkBaseMaxAcceleration;
        public static ConfigEntry<float> boneSharkBaseForwardRotationSpeed;
        public static ConfigEntry<float> boneSharkBaseUpRotationSpeed;
        public static ConfigEntry<float> boneSharkBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> boomerangExclude;
        public static ConfigEntry<float> boomerangScale;
        public static ConfigEntry<float> boomerangSlowness;
        public static ConfigEntry<float> boomerangHealth;
        public static ConfigEntry<float> boomerangLimit;
        public static ConfigEntry<bool> boomerangRandomize;
        public static ConfigEntry<float> boomerangRandomizeMin;
        public static ConfigEntry<float> boomerangRandomizeMax;
        public static ConfigEntry<float> boomerangBaseHealth;
        public static ConfigEntry<float> boomerangBaseMaxAcceleration;
        public static ConfigEntry<float> boomerangBaseForwardRotationSpeed;
        public static ConfigEntry<float> boomerangBaseUpRotationSpeed;
        public static ConfigEntry<float> boomerangBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> caveCrawlerExclude;
        public static ConfigEntry<float> caveCrawlerScale;
        public static ConfigEntry<float> caveCrawlerSlowness;
        public static ConfigEntry<float> caveCrawlerHealth;
        public static ConfigEntry<float> caveCrawlerLimit;
        public static ConfigEntry<bool> caveCrawlerRandomize;
        public static ConfigEntry<float> caveCrawlerRandomizeMin;
        public static ConfigEntry<float> caveCrawlerRandomizeMax;
        public static ConfigEntry<float> caveCrawlerBaseHealth;
        public static ConfigEntry<float> caveCrawlerBaseMaxAcceleration;
        public static ConfigEntry<float> caveCrawlerBaseForwardRotationSpeed;
        public static ConfigEntry<float> caveCrawlerBaseUpRotationSpeed;
        public static ConfigEntry<float> caveCrawlerBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> crabSnakeExclude;
        public static ConfigEntry<float> crabSnakeScale;
        public static ConfigEntry<float> crabSnakeSlowness;
        public static ConfigEntry<float> crabSnakeHealth;
        public static ConfigEntry<float> crabSnakeLimit;
        public static ConfigEntry<bool> crabSnakeRandomize;
        public static ConfigEntry<float> crabSnakeRandomizeMin;
        public static ConfigEntry<float> crabSnakeRandomizeMax;
        public static ConfigEntry<float> crabSnakeBaseHealth;
        public static ConfigEntry<float> crabSnakeBaseMaxAcceleration;
        public static ConfigEntry<float> crabSnakeBaseForwardRotationSpeed;
        public static ConfigEntry<float> crabSnakeBaseUpRotationSpeed;
        public static ConfigEntry<float> crabSnakeBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> crabSquidExclude;
        public static ConfigEntry<float> crabSquidScale;
        public static ConfigEntry<float> crabSquidSlowness;
        public static ConfigEntry<float> crabSquidHealth;
        public static ConfigEntry<float> crabSquidLimit;
        public static ConfigEntry<bool> crabSquidRandomize;
        public static ConfigEntry<float> crabSquidRandomizeMin;
        public static ConfigEntry<float> crabSquidRandomizeMax;
        public static ConfigEntry<float> crabSquidBaseHealth;
        public static ConfigEntry<float> crabSquidBaseMaxAcceleration;
        public static ConfigEntry<float> crabSquidBaseForwardRotationSpeed;
        public static ConfigEntry<float> crabSquidBaseUpRotationSpeed;
        public static ConfigEntry<float> crabSquidBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> crashFishExclude;
        public static ConfigEntry<float> crashFishScale;
        public static ConfigEntry<float> crashFishSlowness;
        public static ConfigEntry<float> crashFishHealth;
        public static ConfigEntry<float> crashFishLimit;
        public static ConfigEntry<bool> crashFishRandomize;
        public static ConfigEntry<float> crashFishRandomizeMin;
        public static ConfigEntry<float> crashFishRandomizeMax;
        public static ConfigEntry<float> crashFishBaseHealth;
        public static ConfigEntry<float> crashFishBaseMaxAcceleration;
        public static ConfigEntry<float> crashFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> crashFishBaseUpRotationSpeed;
        public static ConfigEntry<float> crashFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> cuddleFishExclude;
        public static ConfigEntry<float> cuddleFishScale;
        public static ConfigEntry<float> cuddleFishSlowness;
        public static ConfigEntry<float> cuddleFishHealth;
        public static ConfigEntry<float> cuddleFishLimit;
        public static ConfigEntry<bool> cuddleFishRandomize;
        public static ConfigEntry<float> cuddleFishRandomizeMin;
        public static ConfigEntry<float> cuddleFishRandomizeMax;
        public static ConfigEntry<float> cuddleFishBaseHealth;
        public static ConfigEntry<float> cuddleFishBaseMaxAcceleration;
        public static ConfigEntry<float> cuddleFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> cuddleFishBaseUpRotationSpeed;
        public static ConfigEntry<float> cuddleFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> eyeyeExclude;
        public static ConfigEntry<float> eyeyeScale;
        public static ConfigEntry<float> eyeyeSlowness;
        public static ConfigEntry<float> eyeyeHealth;
        public static ConfigEntry<float> eyeyeLimit;
        public static ConfigEntry<bool> eyeyeRandomize;
        public static ConfigEntry<float> eyeyeRandomizeMin;
        public static ConfigEntry<float> eyeyeRandomizeMax;
        public static ConfigEntry<float> eyeyeBaseHealth;
        public static ConfigEntry<float> eyeyeBaseMaxAcceleration;
        public static ConfigEntry<float> eyeyeBaseForwardRotationSpeed;
        public static ConfigEntry<float> eyeyeBaseUpRotationSpeed;
        public static ConfigEntry<float> eyeyeBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> garryFishExclude;
        public static ConfigEntry<float> garryFishScale;
        public static ConfigEntry<float> garryFishSlowness;
        public static ConfigEntry<float> garryFishHealth;
        public static ConfigEntry<float> garryFishLimit;
        public static ConfigEntry<bool> garryFishRandomize;
        public static ConfigEntry<float> garryFishRandomizeMin;
        public static ConfigEntry<float> garryFishRandomizeMax;
        public static ConfigEntry<float> garryFishBaseHealth;
        public static ConfigEntry<float> garryFishBaseMaxAcceleration;
        public static ConfigEntry<float> garryFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> garryFishBaseUpRotationSpeed;
        public static ConfigEntry<float> garryFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> gasopodExclude;
        public static ConfigEntry<float> gasopodScale;
        public static ConfigEntry<float> gasopodSlowness;
        public static ConfigEntry<float> gasopodHealth;
        public static ConfigEntry<float> gasopodLimit;
        public static ConfigEntry<bool> gasopodRandomize;
        public static ConfigEntry<float> gasopodRandomizeMin;
        public static ConfigEntry<float> gasopodRandomizeMax;
        public static ConfigEntry<float> gasopodBaseHealth;
        public static ConfigEntry<float> gasopodBaseMaxAcceleration;
        public static ConfigEntry<float> gasopodBaseForwardRotationSpeed;
        public static ConfigEntry<float> gasopodBaseUpRotationSpeed;
        public static ConfigEntry<float> gasopodBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> voidGhostLeviathanExclude;
        public static ConfigEntry<float> voidGhostLeviathanScale;
        public static ConfigEntry<float> voidGhostLeviathanSlowness;
        public static ConfigEntry<float> voidGhostLeviathanHealth;
        public static ConfigEntry<float> voidGhostLeviathanLimit;
        public static ConfigEntry<bool> voidGhostLeviathanRandomize;
        public static ConfigEntry<float> voidGhostLeviathanRandomizeMin;
        public static ConfigEntry<float> voidGhostLeviathanRandomizeMax;
        public static ConfigEntry<float> voidGhostLeviathanBaseHealth;
        public static ConfigEntry<float> voidGhostLeviathanBaseMaxAcceleration;
        public static ConfigEntry<float> voidGhostLeviathanBaseForwardRotationSpeed;
        public static ConfigEntry<float> voidGhostLeviathanBaseUpRotationSpeed;
        public static ConfigEntry<float> voidGhostLeviathanBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> ghostLeviathanExclude;
        public static ConfigEntry<float> ghostLeviathanScale;
        public static ConfigEntry<float> ghostLeviathanSlowness;
        public static ConfigEntry<float> ghostLeviathanHealth;
        public static ConfigEntry<float> ghostLeviathanLimit;
        public static ConfigEntry<bool> ghostLeviathanRandomize;
        public static ConfigEntry<float> ghostLeviathanRandomizeMin;
        public static ConfigEntry<float> ghostLeviathanRandomizeMax;
        public static ConfigEntry<float> ghostLeviathanBaseHealth;
        public static ConfigEntry<float> ghostLeviathanBaseMaxAcceleration;
        public static ConfigEntry<float> ghostLeviathanBaseForwardRotationSpeed;
        public static ConfigEntry<float> ghostLeviathanBaseUpRotationSpeed;
        public static ConfigEntry<float> ghostLeviathanBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> ghostRayExclude;
        public static ConfigEntry<float> ghostRayScale;
        public static ConfigEntry<float> ghostRaySlowness;
        public static ConfigEntry<float> ghostRayHealth;
        public static ConfigEntry<float> ghostRayLimit;
        public static ConfigEntry<bool> ghostRayRandomize;
        public static ConfigEntry<float> ghostRayRandomizeMin;
        public static ConfigEntry<float> ghostRayRandomizeMax;
        public static ConfigEntry<float> ghostRayBaseHealth;
        public static ConfigEntry<float> ghostRayBaseMaxAcceleration;
        public static ConfigEntry<float> ghostRayBaseForwardRotationSpeed;
        public static ConfigEntry<float> ghostRayBaseUpRotationSpeed;
        public static ConfigEntry<float> ghostRayBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> holeFishExclude;
        public static ConfigEntry<float> holeFishScale;
        public static ConfigEntry<float> holeFishSlowness;
        public static ConfigEntry<float> holeFishHealth;
        public static ConfigEntry<float> holeFishLimit;
        public static ConfigEntry<bool> holeFishRandomize;
        public static ConfigEntry<float> holeFishRandomizeMin;
        public static ConfigEntry<float> holeFishRandomizeMax;
        public static ConfigEntry<float> holeFishBaseHealth;
        public static ConfigEntry<float> holeFishBaseMaxAcceleration;
        public static ConfigEntry<float> holeFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> holeFishBaseUpRotationSpeed;
        public static ConfigEntry<float> holeFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> hoopFishExclude;
        public static ConfigEntry<float> hoopFishScale;
        public static ConfigEntry<float> hoopFishSlowness;
        public static ConfigEntry<float> hoopFishHealth;
        public static ConfigEntry<float> hoopFishLimit;
        public static ConfigEntry<bool> hoopFishRandomize;
        public static ConfigEntry<float> hoopFishRandomizeMin;
        public static ConfigEntry<float> hoopFishRandomizeMax;
        public static ConfigEntry<float> hoopFishBaseHealth;
        public static ConfigEntry<float> hoopFishBaseMaxAcceleration;
        public static ConfigEntry<float> hoopFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> hoopFishBaseUpRotationSpeed;
        public static ConfigEntry<float> hoopFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> hoverFishExclude;
        public static ConfigEntry<float> hoverFishScale;
        public static ConfigEntry<float> hoverFishSlowness;
        public static ConfigEntry<float> hoverFishHealth;
        public static ConfigEntry<float> hoverFishLimit;
        public static ConfigEntry<bool> hoverFishRandomize;
        public static ConfigEntry<float> hoverFishRandomizeMin;
        public static ConfigEntry<float> hoverFishRandomizeMax;
        public static ConfigEntry<float> hoverFishBaseHealth;
        public static ConfigEntry<float> hoverFishBaseMaxAcceleration;
        public static ConfigEntry<float> hoverFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> hoverFishBaseUpRotationSpeed;
        public static ConfigEntry<float> hoverFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> jellyRayExclude;
        public static ConfigEntry<float> jellyRayScale;
        public static ConfigEntry<float> jellyRaySlowness;
        public static ConfigEntry<float> jellyRayHealth;
        public static ConfigEntry<float> jellyRayLimit;
        public static ConfigEntry<bool> jellyRayRandomize;
        public static ConfigEntry<float> jellyRayRandomizeMin;
        public static ConfigEntry<float> jellyRayRandomizeMax;
        public static ConfigEntry<float> jellyRayBaseHealth;
        public static ConfigEntry<float> jellyRayBaseMaxAcceleration;
        public static ConfigEntry<float> jellyRayBaseForwardRotationSpeed;
        public static ConfigEntry<float> jellyRayBaseUpRotationSpeed;
        public static ConfigEntry<float> jellyRayBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> jumperExclude;
        public static ConfigEntry<float> jumperScale;
        public static ConfigEntry<float> jumperSlowness;
        public static ConfigEntry<float> jumperHealth;
        public static ConfigEntry<float> jumperLimit;
        public static ConfigEntry<bool> jumperRandomize;
        public static ConfigEntry<float> jumperRandomizeMin;
        public static ConfigEntry<float> jumperRandomizeMax;
        public static ConfigEntry<float> jumperBaseHealth;
        public static ConfigEntry<float> jumperBaseMaxAcceleration;
        public static ConfigEntry<float> jumperBaseForwardRotationSpeed;
        public static ConfigEntry<float> jumperBaseUpRotationSpeed;
        public static ConfigEntry<float> jumperBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> lavaLarvaExclude;
        public static ConfigEntry<float> lavaLarvaScale;
        public static ConfigEntry<float> lavaLarvaSlowness;
        public static ConfigEntry<float> lavaLarvaHealth;
        public static ConfigEntry<float> lavaLarvaLimit;
        public static ConfigEntry<bool> lavaLarvaRandomize;
        public static ConfigEntry<float> lavaLarvaRandomizeMin;
        public static ConfigEntry<float> lavaLarvaRandomizeMax;
        public static ConfigEntry<float> lavaLarvaBaseHealth;
        public static ConfigEntry<float> lavaLarvaBaseMaxAcceleration;
        public static ConfigEntry<float> lavaLarvaBaseForwardRotationSpeed;
        public static ConfigEntry<float> lavaLarvaBaseUpRotationSpeed;
        public static ConfigEntry<float> lavaLarvaBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> lavaLizardExclude;
        public static ConfigEntry<float> lavaLizardScale;
        public static ConfigEntry<float> lavaLizardSlowness;
        public static ConfigEntry<float> lavaLizardHealth;
        public static ConfigEntry<float> lavaLizardLimit;
        public static ConfigEntry<bool> lavaLizardRandomize;
        public static ConfigEntry<float> lavaLizardRandomizeMin;
        public static ConfigEntry<float> lavaLizardRandomizeMax;
        public static ConfigEntry<float> lavaLizardBaseHealth;
        public static ConfigEntry<float> lavaLizardBaseMaxAcceleration;
        public static ConfigEntry<float> lavaLizardBaseForwardRotationSpeed;
        public static ConfigEntry<float> lavaLizardBaseUpRotationSpeed;
        public static ConfigEntry<float> lavaLizardBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> mesmerExclude;
        public static ConfigEntry<float> mesmerScale;
        public static ConfigEntry<float> mesmerSlowness;
        public static ConfigEntry<float> mesmerHealth;
        public static ConfigEntry<float> mesmerLimit;
        public static ConfigEntry<bool> mesmerRandomize;
        public static ConfigEntry<float> mesmerRandomizeMin;
        public static ConfigEntry<float> mesmerRandomizeMax;
        public static ConfigEntry<float> mesmerBaseHealth;
        public static ConfigEntry<float> mesmerBaseMaxAcceleration;
        public static ConfigEntry<float> mesmerBaseForwardRotationSpeed;
        public static ConfigEntry<float> mesmerBaseUpRotationSpeed;
        public static ConfigEntry<float> mesmerBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> oculusFishExclude;
        public static ConfigEntry<float> oculusFishScale;
        public static ConfigEntry<float> oculusFishSlowness;
        public static ConfigEntry<float> oculusFishHealth;
        public static ConfigEntry<float> oculusFishLimit;
        public static ConfigEntry<bool> oculusFishRandomize;
        public static ConfigEntry<float> oculusFishRandomizeMin;
        public static ConfigEntry<float> oculusFishRandomizeMax;
        public static ConfigEntry<float> oculusFishBaseHealth;
        public static ConfigEntry<float> oculusFishBaseMaxAcceleration;
        public static ConfigEntry<float> oculusFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> oculusFishBaseUpRotationSpeed;
        public static ConfigEntry<float> oculusFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> peeperExclude;
        public static ConfigEntry<float> peeperScale;
        public static ConfigEntry<float> peeperSlowness;
        public static ConfigEntry<float> peeperHealth;
        public static ConfigEntry<float> peeperLimit;
        public static ConfigEntry<bool> peeperRandomize;
        public static ConfigEntry<float> peeperRandomizeMin;
        public static ConfigEntry<float> peeperRandomizeMax;
        public static ConfigEntry<float> peeperBaseHealth;
        public static ConfigEntry<float> peeperBaseMaxAcceleration;
        public static ConfigEntry<float> peeperBaseForwardRotationSpeed;
        public static ConfigEntry<float> peeperBaseUpRotationSpeed;
        public static ConfigEntry<float> peeperBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> rabbitRayExclude;
        public static ConfigEntry<float> rabbitRayScale;
        public static ConfigEntry<float> rabbitRaySlowness;
        public static ConfigEntry<float> rabbitRayHealth;
        public static ConfigEntry<float> rabbitRayLimit;
        public static ConfigEntry<bool> rabbitRayRandomize;
        public static ConfigEntry<float> rabbitRayRandomizeMin;
        public static ConfigEntry<float> rabbitRayRandomizeMax;
        public static ConfigEntry<float> rabbitRayBaseHealth;
        public static ConfigEntry<float> rabbitRayBaseMaxAcceleration;
        public static ConfigEntry<float> rabbitRayBaseForwardRotationSpeed;
        public static ConfigEntry<float> rabbitRayBaseUpRotationSpeed;
        public static ConfigEntry<float> rabbitRayBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> reaperLeviathanExclude;
        public static ConfigEntry<float> reaperLeviathanScale;
        public static ConfigEntry<float> reaperLeviathanSlowness;
        public static ConfigEntry<float> reaperLeviathanHealth;
        public static ConfigEntry<float> reaperLeviathanLimit;
        public static ConfigEntry<bool> reaperLeviathanRandomize;
        public static ConfigEntry<float> reaperLeviathanRandomizeMin;
        public static ConfigEntry<float> reaperLeviathanRandomizeMax;
        public static ConfigEntry<float> reaperLeviathanBaseHealth;
        public static ConfigEntry<float> reaperLeviathanBaseMaxAcceleration;
        public static ConfigEntry<float> reaperLeviathanBaseForwardRotationSpeed;
        public static ConfigEntry<float> reaperLeviathanBaseUpRotationSpeed;
        public static ConfigEntry<float> reaperLeviathanBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> reefbackExclude;
        public static ConfigEntry<float> reefbackScale;
        public static ConfigEntry<float> reefbackSlowness;
        public static ConfigEntry<float> reefbackHealth;
        public static ConfigEntry<float> reefbackLimit;
        public static ConfigEntry<bool> reefbackRandomize;
        public static ConfigEntry<float> reefbackRandomizeMin;
        public static ConfigEntry<float> reefbackRandomizeMax;
        public static ConfigEntry<float> reefbackBaseHealth;
        public static ConfigEntry<float> reefbackBaseMaxAcceleration;
        public static ConfigEntry<float> reefbackBaseForwardRotationSpeed;
        public static ConfigEntry<float> reefbackBaseUpRotationSpeed;
        public static ConfigEntry<float> reefbackBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> reginaldExclude;
        public static ConfigEntry<float> reginaldScale;
        public static ConfigEntry<float> reginaldSlowness;
        public static ConfigEntry<float> reginaldHealth;
        public static ConfigEntry<float> reginaldLimit;
        public static ConfigEntry<bool> reginaldRandomize;
        public static ConfigEntry<float> reginaldRandomizeMin;
        public static ConfigEntry<float> reginaldRandomizeMax;
        public static ConfigEntry<float> reginaldBaseHealth;
        public static ConfigEntry<float> reginaldBaseMaxAcceleration;
        public static ConfigEntry<float> reginaldBaseForwardRotationSpeed;
        public static ConfigEntry<float> reginaldBaseUpRotationSpeed;
        public static ConfigEntry<float> reginaldBaseTraitsAnimatorSpeed;

        //public static ConfigEntry<bool> rockGrubExclude;
        //public static ConfigEntry<float> rockGrubScale;
        //public static ConfigEntry<float> rockGrubSlowness;
        //public static ConfigEntry<float> rockGrubHealth;
        //public static ConfigEntry<float> rockGrubLimit;
        //public static ConfigEntry<float> rockGrubBaseHealth;
        //public static ConfigEntry<float> rockGrubBaseMaxAcceleration;
        //public static ConfigEntry<float> rockGrubBaseForwardRotationSpeed;
        //public static ConfigEntry<float> rockGrubBaseUpRotationSpeed;
        //public static ConfigEntry<float> rockGrubBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> sandSharkExclude;
        public static ConfigEntry<float> sandSharkScale;
        public static ConfigEntry<float> sandSharkSlowness;
        public static ConfigEntry<float> sandSharkHealth;
        public static ConfigEntry<float> sandSharkLimit;
        public static ConfigEntry<bool> sandSharkRandomize;
        public static ConfigEntry<float> sandSharkRandomizeMin;
        public static ConfigEntry<float> sandSharkRandomizeMax;
        public static ConfigEntry<float> sandSharkBaseHealth;
        public static ConfigEntry<float> sandSharkBaseMaxAcceleration;
        public static ConfigEntry<float> sandSharkBaseForwardRotationSpeed;
        public static ConfigEntry<float> sandSharkBaseUpRotationSpeed;
        public static ConfigEntry<float> sandSharkBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> seaDragonExclude;
        public static ConfigEntry<float> seaDragonScale;
        public static ConfigEntry<float> seaDragonSlowness;
        public static ConfigEntry<float> seaDragonHealth;
        public static ConfigEntry<float> seaDragonLimit;
        public static ConfigEntry<bool> seaDragonRandomize;
        public static ConfigEntry<float> seaDragonRandomizeMin;
        public static ConfigEntry<float> seaDragonRandomizeMax;
        public static ConfigEntry<float> seaDragonBaseHealth;
        public static ConfigEntry<float> seaDragonBaseMaxAcceleration;
        public static ConfigEntry<float> seaDragonBaseForwardRotationSpeed;
        public static ConfigEntry<float> seaDragonBaseUpRotationSpeed;
        public static ConfigEntry<float> seaDragonBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> seaEmperorBabyExclude;
        public static ConfigEntry<float> seaEmperorBabyScale;
        public static ConfigEntry<float> seaEmperorBabySlowness;
        public static ConfigEntry<float> seaEmperorBabyHealth;
        public static ConfigEntry<float> seaEmperorBabyLimit;
        public static ConfigEntry<bool> seaEmperorBabyRandomize;
        public static ConfigEntry<float> seaEmperorBabyRandomizeMin;
        public static ConfigEntry<float> seaEmperorBabyRandomizeMax;
        public static ConfigEntry<float> seaEmperorBabyBaseHealth;
        public static ConfigEntry<float> seaEmperorBabyBaseMaxAcceleration;
        public static ConfigEntry<float> seaEmperorBabyBaseForwardRotationSpeed;
        public static ConfigEntry<float> seaEmperorBabyBaseUpRotationSpeed;
        public static ConfigEntry<float> seaEmperorBabyBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> seaEmperorJuvenileExclude;
        public static ConfigEntry<float> seaEmperorJuvenileScale;
        public static ConfigEntry<float> seaEmperorJuvenileSlowness;
        public static ConfigEntry<float> seaEmperorJuvenileHealth;
        public static ConfigEntry<float> seaEmperorJuvenileLimit;
        public static ConfigEntry<bool> seaEmperorJuvenileRandomize;
        public static ConfigEntry<float> seaEmperorJuvenileRandomizeMin;
        public static ConfigEntry<float> seaEmperorJuvenileRandomizeMax;
        public static ConfigEntry<float> seaEmperorJuvenileBaseHealth;
        public static ConfigEntry<float> seaEmperorJuvenileBaseMaxAcceleration;
        public static ConfigEntry<float> seaEmperorJuvenileBaseForwardRotationSpeed;
        public static ConfigEntry<float> seaEmperorJuvenileBaseUpRotationSpeed;
        public static ConfigEntry<float> seaEmperorJuvenileBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> seaTreaderExclude;
        public static ConfigEntry<float> seaTreaderScale;
        public static ConfigEntry<float> seaTreaderSlowness;
        public static ConfigEntry<float> seaTreaderHealth;
        public static ConfigEntry<float> seaTreaderLimit;
        public static ConfigEntry<bool> seaTreaderRandomize;
        public static ConfigEntry<float> seaTreaderRandomizeMin;
        public static ConfigEntry<float> seaTreaderRandomizeMax;
        public static ConfigEntry<float> seaTreaderBaseHealth;
        public static ConfigEntry<float> seaTreaderBaseMaxAcceleration;
        public static ConfigEntry<float> seaTreaderBaseForwardRotationSpeed;
        public static ConfigEntry<float> seaTreaderBaseUpRotationSpeed;
        public static ConfigEntry<float> seaTreaderBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> shockerExclude;
        public static ConfigEntry<float> shockerScale;
        public static ConfigEntry<float> shockerSlowness;
        public static ConfigEntry<float> shockerHealth;
        public static ConfigEntry<float> shockerLimit;
        public static ConfigEntry<bool> shockerRandomize;
        public static ConfigEntry<float> shockerRandomizeMin;
        public static ConfigEntry<float> shockerRandomizeMax;
        public static ConfigEntry<float> shockerBaseHealth;
        public static ConfigEntry<float> shockerBaseMaxAcceleration;
        public static ConfigEntry<float> shockerBaseForwardRotationSpeed;
        public static ConfigEntry<float> shockerBaseUpRotationSpeed;
        public static ConfigEntry<float> shockerBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> skyRayExclude;
        public static ConfigEntry<float> skyRayScale;
        public static ConfigEntry<float> skyRaySlowness;
        public static ConfigEntry<float> skyRayHealth;
        public static ConfigEntry<float> skyRayLimit;
        public static ConfigEntry<bool> skyRayRandomize;
        public static ConfigEntry<float> skyRayRandomizeMin;
        public static ConfigEntry<float> skyRayRandomizeMax;
        public static ConfigEntry<float> skyRayBaseHealth;
        public static ConfigEntry<float> skyRayBaseMaxAcceleration;
        public static ConfigEntry<float> skyRayBaseForwardRotationSpeed;
        public static ConfigEntry<float> skyRayBaseUpRotationSpeed;
        public static ConfigEntry<float> skyRayBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> spadeFishExclude;
        public static ConfigEntry<float> spadeFishScale;
        public static ConfigEntry<float> spadeFishSlowness;
        public static ConfigEntry<float> spadeFishHealth;
        public static ConfigEntry<float> spadeFishLimit;
        public static ConfigEntry<bool> spadeFishRandomize;
        public static ConfigEntry<float> spadeFishRandomizeMin;
        public static ConfigEntry<float> spadeFishRandomizeMax;
        public static ConfigEntry<float> spadeFishBaseHealth;
        public static ConfigEntry<float> spadeFishBaseMaxAcceleration;
        public static ConfigEntry<float> spadeFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> spadeFishBaseUpRotationSpeed;
        public static ConfigEntry<float> spadeFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> spineEelExclude;
        public static ConfigEntry<float> spineEelScale;
        public static ConfigEntry<float> spineEelSlowness;
        public static ConfigEntry<float> spineEelHealth;
        public static ConfigEntry<float> spineEelLimit;
        public static ConfigEntry<bool> spineEelRandomize;
        public static ConfigEntry<float> spineEelRandomizeMin;
        public static ConfigEntry<float> spineEelRandomizeMax;
        public static ConfigEntry<float> spineEelBaseHealth;
        public static ConfigEntry<float> spineEelBaseMaxAcceleration;
        public static ConfigEntry<float> spineEelBaseForwardRotationSpeed;
        public static ConfigEntry<float> spineEelBaseUpRotationSpeed;
        public static ConfigEntry<float> spineEelBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> stalkerExclude;
        public static ConfigEntry<float> stalkerScale;
        public static ConfigEntry<float> stalkerSlowness;
        public static ConfigEntry<float> stalkerHealth;
        public static ConfigEntry<float> stalkerLimit;
        public static ConfigEntry<bool> stalkerRandomize;
        public static ConfigEntry<float> stalkerRandomizeMin;
        public static ConfigEntry<float> stalkerRandomizeMax;
        public static ConfigEntry<float> stalkerBaseHealth;
        public static ConfigEntry<float> stalkerBaseMaxAcceleration;
        public static ConfigEntry<float> stalkerBaseForwardRotationSpeed;
        public static ConfigEntry<float> stalkerBaseUpRotationSpeed;
        public static ConfigEntry<float> stalkerBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> warperExclude;
        public static ConfigEntry<float> warperScale;
        public static ConfigEntry<float> warperSlowness;
        public static ConfigEntry<float> warperHealth;
        public static ConfigEntry<float> warperLimit;
        public static ConfigEntry<bool> warperRandomize;
        public static ConfigEntry<float> warperRandomizeMin;
        public static ConfigEntry<float> warperRandomizeMax;
        public static ConfigEntry<float> warperBaseHealth;
        public static ConfigEntry<float> warperBaseMaxAcceleration;
        public static ConfigEntry<float> warperBaseForwardRotationSpeed;
        public static ConfigEntry<float> warperBaseUpRotationSpeed;
        public static ConfigEntry<float> warperBaseTraitsAnimatorSpeed;
        #endregion

        List<OptionItem> miscOptions = new List<OptionItem>();
        List<OptionItem> proportionalOptions = new List<OptionItem>();
        List<OptionItem> ampeelOptions = new List<OptionItem>();
        List<OptionItem> biterOptions = new List<OptionItem>();
        List<OptionItem> bladderFishOptions = new List<OptionItem>();
        List<OptionItem> bleederOptions = new List<OptionItem>();
        List<OptionItem> boneSharkOptions = new List<OptionItem>();
        List<OptionItem> boomerangOptions = new List<OptionItem>();
        List<OptionItem> caveCrawlerOptions = new List<OptionItem>();
        List<OptionItem> crabSnakeOptions = new List<OptionItem>();
        List<OptionItem> crabSquidOptions = new List<OptionItem>();
        List<OptionItem> crashFishOptions = new List<OptionItem>();
        List<OptionItem> cuddleFishOptions = new List<OptionItem>();
        List<OptionItem> eyeyeOptions = new List<OptionItem>();
        List<OptionItem> garryFishOptions = new List<OptionItem>();
        List<OptionItem> gasopodOptions = new List<OptionItem>();
        List<OptionItem> ghostLeviathanOptions = new List<OptionItem>();
        List<OptionItem> voidGhostLeviathanOptions = new List<OptionItem>();
        List<OptionItem> ghostRayOptions = new List<OptionItem>();
        List<OptionItem> holeFishOptions = new List<OptionItem>();
        List<OptionItem> hoopFishOptions = new List<OptionItem>();
        List<OptionItem> hoverFishOptions = new List<OptionItem>();
        List<OptionItem> jellyRayOptions = new List<OptionItem>();
        List<OptionItem> jumperOptions = new List<OptionItem>();
        List<OptionItem> lavaLarvaOptions = new List<OptionItem>();
        List<OptionItem> lavaLizardOptions = new List<OptionItem>();
        List<OptionItem> mesmerOptions = new List<OptionItem>();
        List<OptionItem> oculusFishOptions = new List<OptionItem>();
        List<OptionItem> peeperOptions = new List<OptionItem>();
        List<OptionItem> rabbitRayOptions = new List<OptionItem>();
        List<OptionItem> reaperLeviathanOptions = new List<OptionItem>();
        List<OptionItem> reefbackOptions = new List<OptionItem>();
        List<OptionItem> reginaldOptions = new List<OptionItem>();
        List<OptionItem> sandSharkOptions = new List<OptionItem>();
        List<OptionItem> seaDragonOptions = new List<OptionItem>();
        List<OptionItem> seaEmperorBabyOptions = new List<OptionItem>();
        List<OptionItem> seaEmperorJuvenileOptions = new List<OptionItem>();
        List<OptionItem> seaTreaderOptions = new List<OptionItem>();
        List<OptionItem> skyRayOptions = new List<OptionItem>();
        List<OptionItem> spadeFishOptions = new List<OptionItem>();
        List<OptionItem> spineEelOptions = new List<OptionItem>();
        List<OptionItem> stalkerOptions = new List<OptionItem>();
        List<OptionItem> warperOptions = new List<OptionItem>();

        public MyModOptions() : base("Bigger Fish")
        {
            ModToggleOption removeFishSchoolsOption = removeFishSchools.ToModToggleOption();
            removeFishSchoolsOption.OnChanged += ToggleOptionsChanged;
            AddItem(removeFishSchoolsOption);

            ModToggleOption proportionalOption = proportionalToggle.ToModToggleOption();
            proportionalOption.OnChanged += ToggleOptionsChanged;
            AddItem(proportionalOption);

            ModSliderOption proportionalScaleOption = proportionalScale.ToModSliderOption(1, 50);
            proportionalScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalScaleOption);

            ModSliderOption proportionalSlownessOption = proportionalSlowness.ToModSliderOption(1, 100);
            proportionalSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalSlownessOption);

            ModSliderOption proportionalHealthOption = proportionalHealth.ToModSliderOption(1, 100);
            proportionalHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalHealthOption);

            ModSliderOption proportionalCreatureLimitOption = proportionalCreatureLimit.ToModSliderOption(0, 50);
            proportionalCreatureLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalCreatureLimitOption);

            ModToggleOption proportionalRandomizeOption = proportionalRandomize.ToModToggleOption();
            proportionalRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(proportionalRandomizeOption);

            ModSliderOption proportionalRandomizeMinOption = proportionalRandomizeMin.ToModSliderOption(1, 50);
            proportionalRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalRandomizeMinOption);

            ModSliderOption proportionalRandomizeMaxOption = proportionalRandomizeMax.ToModSliderOption(1, 50);
            proportionalRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalRandomizeMaxOption);





            ModToggleOption shockerExcludeOption = shockerExclude.ToModToggleOption();
            shockerExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(shockerExcludeOption);

            ModSliderOption shockerScaleOption = shockerScale.ToModSliderOption(1, 50);
            shockerScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(shockerScaleOption);

            ModSliderOption shockerSlownessOption = shockerSlowness.ToModSliderOption(1, 100);
            shockerSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(shockerSlownessOption);

            ModSliderOption shockerHealthOption = shockerHealth.ToModSliderOption(1, 100);
            shockerHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(shockerHealthOption);

            ModSliderOption shockerLimitOption = shockerLimit.ToModSliderOption(0, 50);
            shockerLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(shockerLimitOption);

            ModToggleOption shockerRandomizeOption = shockerRandomize.ToModToggleOption();
            shockerRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(shockerRandomizeOption);

            ModSliderOption shockerRandomizeMinOption = shockerRandomizeMin.ToModSliderOption(1, 50);
            shockerRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(shockerRandomizeMinOption);

            ModSliderOption shockerRandomizeMaxOption = shockerRandomizeMax.ToModSliderOption(1, 50);
            shockerRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(shockerRandomizeMaxOption);





            ModToggleOption biterExcludeOption = biterExclude.ToModToggleOption();
            biterExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(biterExcludeOption);

            ModSliderOption biterScaleOption = biterScale.ToModSliderOption(1, 50);
            biterScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(biterScaleOption);

            ModSliderOption biterSlownessOption = biterSlowness.ToModSliderOption(1, 100);
            biterSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(biterSlownessOption);

            ModSliderOption biterHealthOption = biterHealth.ToModSliderOption(1, 100);
            biterHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(biterHealthOption);

            ModSliderOption biterLimitOption = biterLimit.ToModSliderOption(0, 50);
            biterLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(biterLimitOption);

            ModToggleOption biterRandomizeOption = biterRandomize.ToModToggleOption();
            biterRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(biterRandomizeOption);

            ModSliderOption biterRandomizeMinOption = biterRandomizeMin.ToModSliderOption(1, 50);
            biterRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(biterRandomizeMinOption);

            ModSliderOption biterRandomizeMaxOption = biterRandomizeMax.ToModSliderOption(1, 50);
            biterRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(biterRandomizeMaxOption);





            ModToggleOption bladderFishExcludeOption = bladderFishExclude.ToModToggleOption();
            bladderFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(bladderFishExcludeOption);

            ModSliderOption bladderFishScaleOption = bladderFishScale.ToModSliderOption(1, 50);
            bladderFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishScaleOption);

            ModSliderOption bladderFishSlownessOption = bladderFishSlowness.ToModSliderOption(1, 100);
            bladderFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishSlownessOption);

            ModSliderOption bladderFishHealthOption = bladderFishHealth.ToModSliderOption(1, 100);
            bladderFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishHealthOption);

            ModSliderOption bladderFishLimitOption = bladderFishLimit.ToModSliderOption(0, 50);
            bladderFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishLimitOption);

            ModToggleOption bladderFishRandomizeOption = bladderFishRandomize.ToModToggleOption();
            bladderFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(bladderFishRandomizeOption);

            ModSliderOption bladderFishRandomizeMinOption = bladderFishRandomizeMin.ToModSliderOption(1, 50);
            bladderFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishRandomizeMinOption);

            ModSliderOption bladderFishRandomizeMaxOption = bladderFishRandomizeMax.ToModSliderOption(1, 50);
            bladderFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishRandomizeMaxOption);





            ModToggleOption bleederExcludeOption = bleederExclude.ToModToggleOption();
            bleederExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(bleederExcludeOption);

            ModSliderOption bleederScaleOption = bleederScale.ToModSliderOption(1, 50);
            bleederScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(bleederScaleOption);

            ModSliderOption bleederSlownessOption = bleederSlowness.ToModSliderOption(1, 100);
            bleederSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(bleederSlownessOption);

            ModSliderOption bleederHealthOption = bleederHealth.ToModSliderOption(1, 100);
            bleederHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(bleederHealthOption);

            ModSliderOption bleederLimitOption = bleederLimit.ToModSliderOption(0, 50);
            bleederLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(bleederLimitOption);

            ModToggleOption bleederRandomizeOption = bleederRandomize.ToModToggleOption();
            bleederRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(bleederRandomizeOption);

            ModSliderOption bleederRandomizeMinOption = bleederRandomizeMin.ToModSliderOption(1, 50);
            bleederRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(bleederRandomizeMinOption);

            ModSliderOption bleederRandomizeMaxOption = bleederRandomizeMax.ToModSliderOption(1, 50);
            bleederRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(bleederRandomizeMaxOption);





            ModToggleOption boneSharkExcludeOption = boneSharkExclude.ToModToggleOption();
            boneSharkExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(boneSharkExcludeOption);

            ModSliderOption boneSharkScaleOption = boneSharkScale.ToModSliderOption(1, 50);
            boneSharkScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkScaleOption);

            ModSliderOption boneSharkSlownessOption = boneSharkSlowness.ToModSliderOption(1, 100);
            boneSharkSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkSlownessOption);

            ModSliderOption boneSharkHealthOption = boneSharkHealth.ToModSliderOption(1, 100);
            boneSharkHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkHealthOption);

            ModSliderOption boneSharkLimitOption = boneSharkLimit.ToModSliderOption(1, 50);
            boneSharkLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkLimitOption);

            ModToggleOption boneSharkRandomizeOption = boneSharkRandomize.ToModToggleOption();
            boneSharkRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(boneSharkRandomizeOption);

            ModSliderOption boneSharkRandomizeMinOption = boneSharkRandomizeMin.ToModSliderOption(1, 50);
            boneSharkRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkRandomizeMinOption);

            ModSliderOption boneSharkRandomizeMaxOption = boneSharkRandomizeMax.ToModSliderOption(1, 50);
            boneSharkRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkRandomizeMaxOption);





            ModToggleOption boomerangExcludeOption = boomerangExclude.ToModToggleOption();
            boomerangExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(boomerangExcludeOption);

            ModSliderOption boomerangScaleOption = boomerangScale.ToModSliderOption(1, 50);
            boomerangScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangScaleOption);

            ModSliderOption boomerangSlownessOption = boomerangSlowness.ToModSliderOption(1, 100);
            boomerangSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangSlownessOption);

            ModSliderOption boomerangHealthOption = boomerangHealth.ToModSliderOption(1, 100);
            boomerangHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangHealthOption);

            ModSliderOption boomerangLimitOption = boomerangLimit.ToModSliderOption(0, 50);
            boomerangLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangLimitOption);

            ModToggleOption boomerangRandomizeOption = boomerangRandomize.ToModToggleOption();
            boomerangRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(boomerangRandomizeOption);

            ModSliderOption boomerangRandomizeMinOption = boomerangRandomizeMin.ToModSliderOption(1, 50);
            boomerangRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangRandomizeMinOption);

            ModSliderOption boomerangRandomizeMaxOption = boomerangRandomizeMax.ToModSliderOption(1, 50);
            boomerangRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangRandomizeMaxOption);





            ModToggleOption caveCrawlerExcludeOption = caveCrawlerExclude.ToModToggleOption();
            caveCrawlerExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(caveCrawlerExcludeOption);

            ModSliderOption caveCrawlerScaleOption = caveCrawlerScale.ToModSliderOption(1, 50);
            caveCrawlerScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(caveCrawlerScaleOption);

            ModSliderOption caveCrawlerSlownessOption = caveCrawlerSlowness.ToModSliderOption(1, 100);
            caveCrawlerSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(caveCrawlerSlownessOption);

            ModSliderOption caveCrawlerHealthOption = caveCrawlerHealth.ToModSliderOption(1, 100);
            caveCrawlerHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(caveCrawlerHealthOption);

            ModSliderOption caveCrawlerLimitOption = caveCrawlerLimit.ToModSliderOption(0, 50);
            caveCrawlerLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(caveCrawlerLimitOption);

            ModToggleOption caveCrawlerRandomizeOption = caveCrawlerRandomize.ToModToggleOption();
            caveCrawlerRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(caveCrawlerRandomizeOption);

            ModSliderOption caveCrawlerRandomizeMinOption = caveCrawlerRandomizeMin.ToModSliderOption(1, 50);
            caveCrawlerRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(caveCrawlerRandomizeMinOption);

            ModSliderOption caveCrawlerRandomizeMaxOption = caveCrawlerRandomizeMax.ToModSliderOption(1, 50);
            caveCrawlerRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(caveCrawlerRandomizeMaxOption);





            ModToggleOption crabSnakeExcludeOption = crabSnakeExclude.ToModToggleOption();
            crabSnakeExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(crabSnakeExcludeOption);

            ModSliderOption crabSnakeScaleOption = crabSnakeScale.ToModSliderOption(1, 50);
            crabSnakeScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSnakeScaleOption);

            ModSliderOption crabSnakeSlownessOption = crabSnakeSlowness.ToModSliderOption(1, 100);
            crabSnakeSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSnakeSlownessOption);

            ModSliderOption crabSnakeHealthOption = crabSnakeHealth.ToModSliderOption(1, 100);
            crabSnakeHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSnakeHealthOption);

            ModSliderOption crabSnakeLimitOption = crabSnakeLimit.ToModSliderOption(0, 50);
            crabSnakeLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSnakeLimitOption);

            ModToggleOption crabSnakeRandomizeOption = crabSnakeRandomize.ToModToggleOption();
            crabSnakeRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(crabSnakeRandomizeOption);

            ModSliderOption crabSnakeRandomizeMinOption = crabSnakeRandomizeMin.ToModSliderOption(1, 50);
            crabSnakeRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSnakeRandomizeMinOption);

            ModSliderOption crabSnakeRandomizeMaxOption = crabSnakeRandomizeMax.ToModSliderOption(1, 50);
            crabSnakeRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSnakeRandomizeMaxOption);





            ModToggleOption crabSquidExcludeOption = crabSquidExclude.ToModToggleOption();
            crabSquidExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(crabSquidExcludeOption);

            ModSliderOption crabSquidScaleOption = crabSquidScale.ToModSliderOption(1, 50);
            crabSquidScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSquidScaleOption);

            ModSliderOption crabSquidSlownessOption = crabSquidSlowness.ToModSliderOption(1, 100);
            crabSquidSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSquidSlownessOption);

            ModSliderOption crabSquidHealthOption = crabSquidHealth.ToModSliderOption(1, 100);
            crabSquidHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSquidHealthOption);

            ModSliderOption crabSquidLimitOption = crabSquidLimit.ToModSliderOption(0, 50);
            crabSquidLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSquidLimitOption);

            ModToggleOption crabSquidRandomizeOption = crabSquidRandomize.ToModToggleOption();
            crabSquidRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(crabSquidRandomizeOption);

            ModSliderOption crabSquidRandomizeMinOption = crabSquidRandomizeMin.ToModSliderOption(1, 50);
            crabSquidRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSquidRandomizeMinOption);

            ModSliderOption crabSquidRandomizeMaxOption = crabSquidRandomizeMax.ToModSliderOption(1, 50);
            crabSquidRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(crabSquidRandomizeMaxOption);





            ModToggleOption crashFishExcludeOption = crashFishExclude.ToModToggleOption();
            crashFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(crashFishExcludeOption);

            ModSliderOption crashFishScaleOption = crashFishScale.ToModSliderOption(1, 50);
            crashFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishScaleOption);

            ModSliderOption crashFishSlownessOption = crashFishSlowness.ToModSliderOption(1, 100);
            crashFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishSlownessOption);

            ModSliderOption crashFishHealthOption = crashFishHealth.ToModSliderOption(1, 100);
            crashFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishHealthOption);

            ModSliderOption crashFishLimitOption = crashFishLimit.ToModSliderOption(0, 50);
            crashFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishLimitOption);

            ModToggleOption crashFishRandomizeOption = crashFishRandomize.ToModToggleOption();
            crashFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(crashFishRandomizeOption);

            ModSliderOption crashFishRandomizeMinOption = crashFishRandomizeMin.ToModSliderOption(1, 50);
            crashFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishRandomizeMinOption);

            ModSliderOption crashFishRandomizeMaxOption = crashFishRandomizeMax.ToModSliderOption(1, 50);
            crashFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishRandomizeMaxOption);





            ModToggleOption cuddleFishExcludeOption = cuddleFishExclude.ToModToggleOption();
            cuddleFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(cuddleFishExcludeOption);

            ModSliderOption cuddleFishScaleOption = cuddleFishScale.ToModSliderOption(1, 50);
            cuddleFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(cuddleFishScaleOption);

            ModSliderOption cuddleFishSlownessOption = cuddleFishSlowness.ToModSliderOption(1, 100);
            cuddleFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(cuddleFishSlownessOption);

            ModSliderOption cuddleFishHealthOption = cuddleFishHealth.ToModSliderOption(1, 100);
            cuddleFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(cuddleFishHealthOption);

            ModSliderOption cuddleFishLimitOption = cuddleFishLimit.ToModSliderOption(0, 50);
            cuddleFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(cuddleFishLimitOption);

            ModToggleOption cuddleFishRandomizeOption = cuddleFishRandomize.ToModToggleOption();
            cuddleFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(cuddleFishRandomizeOption);

            ModSliderOption cuddleFishRandomizeMinOption = cuddleFishRandomizeMin.ToModSliderOption(1, 50);
            cuddleFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(cuddleFishRandomizeMinOption);

            ModSliderOption cuddleFishRandomizeMaxOption = cuddleFishRandomizeMax.ToModSliderOption(1, 50);
            cuddleFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(cuddleFishRandomizeMaxOption);





            ModToggleOption eyeyeExcludeOption = eyeyeExclude.ToModToggleOption();
            eyeyeExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(eyeyeExcludeOption);

            ModSliderOption eyeyeScaleOption = eyeyeScale.ToModSliderOption(1, 50);
            eyeyeScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(eyeyeScaleOption);

            ModSliderOption eyeyeSlownessOption = eyeyeSlowness.ToModSliderOption(1, 100);
            eyeyeSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(eyeyeSlownessOption);

            ModSliderOption eyeyeHealthOption = eyeyeHealth.ToModSliderOption(1, 100);
            eyeyeHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(eyeyeHealthOption);

            ModSliderOption eyeyeLimitOption = eyeyeLimit.ToModSliderOption(0, 50);
            eyeyeLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(eyeyeLimitOption);

            ModToggleOption eyeyeRandomizeOption = eyeyeRandomize.ToModToggleOption();
            eyeyeRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(eyeyeRandomizeOption);

            ModSliderOption eyeyeRandomizeMinOption = eyeyeRandomizeMin.ToModSliderOption(1, 50);
            eyeyeRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(eyeyeRandomizeMinOption);

            ModSliderOption eyeyeRandomizeMaxOption = eyeyeRandomizeMax.ToModSliderOption(1, 50);
            eyeyeRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(eyeyeRandomizeMaxOption);





            ModToggleOption garryFishExcludeOption = garryFishExclude.ToModToggleOption();
            garryFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(garryFishExcludeOption);

            ModSliderOption garryFishScaleOption = garryFishScale.ToModSliderOption(1, 50);
            garryFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(garryFishScaleOption);

            ModSliderOption garryFishSlownessOption = garryFishSlowness.ToModSliderOption(1, 100);
            garryFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(garryFishSlownessOption);

            ModSliderOption garryFishHealthOption = garryFishHealth.ToModSliderOption(1, 100);
            garryFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(garryFishHealthOption);

            ModSliderOption garryFishLimitOption = garryFishLimit.ToModSliderOption(0, 50);
            garryFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(garryFishLimitOption);

            ModToggleOption garryFishRandomizeOption = garryFishRandomize.ToModToggleOption();
            garryFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(garryFishRandomizeOption);

            ModSliderOption garryFishRandomizeMinOption = garryFishRandomizeMin.ToModSliderOption(1, 50);
            garryFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(garryFishRandomizeMinOption);

            ModSliderOption garryFishRandomizeMaxOption = garryFishRandomizeMax.ToModSliderOption(1, 50);
            garryFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(garryFishRandomizeMaxOption);





            ModToggleOption gasopodExcludeOption = gasopodExclude.ToModToggleOption();
            gasopodExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(gasopodExcludeOption);

            ModSliderOption gasopodScaleOption = gasopodScale.ToModSliderOption(1, 50);
            gasopodScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(gasopodScaleOption);

            ModSliderOption gasopodSlownessOption = gasopodSlowness.ToModSliderOption(1, 100);
            gasopodSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(gasopodSlownessOption);

            ModSliderOption gasopodHealthOption = gasopodHealth.ToModSliderOption(1, 100);
            gasopodHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(gasopodHealthOption);

            ModSliderOption gasopodLimitOption = gasopodLimit.ToModSliderOption(0, 50);
            gasopodLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(gasopodLimitOption);

            ModToggleOption gasopodRandomizeOption = gasopodRandomize.ToModToggleOption();
            gasopodRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(gasopodRandomizeOption);

            ModSliderOption gasopodRandomizeMinOption = gasopodRandomizeMin.ToModSliderOption(1, 50);
            gasopodRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(gasopodRandomizeMinOption);

            ModSliderOption gasopodRandomizeMaxOption = gasopodRandomizeMax.ToModSliderOption(1, 50);
            gasopodRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(gasopodRandomizeMaxOption);





            ModToggleOption ghostLeviathanExcludeOption = ghostLeviathanExclude.ToModToggleOption();
            ghostLeviathanExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(ghostLeviathanExcludeOption);

            ModSliderOption ghostLeviathanScaleOption = ghostLeviathanScale.ToModSliderOption(1, 50);
            ghostLeviathanScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostLeviathanScaleOption);

            ModSliderOption ghostLeviathanSlownessOption = ghostLeviathanSlowness.ToModSliderOption(1, 100);
            ghostLeviathanSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostLeviathanSlownessOption);

            ModSliderOption ghostLeviathanHealthOption = ghostLeviathanHealth.ToModSliderOption(1, 100);
            ghostLeviathanHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostLeviathanHealthOption);

            ModSliderOption ghostLeviathanLimitOption = ghostLeviathanLimit.ToModSliderOption(0, 50);
            ghostLeviathanLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostLeviathanLimitOption);

            ModToggleOption ghostLeviathanRandomizeOption = ghostLeviathanRandomize.ToModToggleOption();
            ghostLeviathanRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(ghostLeviathanRandomizeOption);

            ModSliderOption ghostLeviathanRandomizeMinOption = ghostLeviathanRandomizeMin.ToModSliderOption(1, 50);
            ghostLeviathanRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostLeviathanRandomizeMinOption);

            ModSliderOption ghostLeviathanRandomizeMaxOption = ghostLeviathanRandomizeMax.ToModSliderOption(1, 50);
            ghostLeviathanRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostLeviathanRandomizeMaxOption);





            ModToggleOption voidGhostLeviathanExcludeOption = voidGhostLeviathanExclude.ToModToggleOption();
            voidGhostLeviathanExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(voidGhostLeviathanExcludeOption);

            ModSliderOption voidGhostLeviathanScaleOption = voidGhostLeviathanScale.ToModSliderOption(1, 50);
            voidGhostLeviathanScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(voidGhostLeviathanScaleOption);

            ModSliderOption voidGhostLeviathanSlownessOption = voidGhostLeviathanSlowness.ToModSliderOption(1, 100);
            voidGhostLeviathanSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(voidGhostLeviathanSlownessOption);

            ModSliderOption voidGhostLeviathanHealthOption = voidGhostLeviathanHealth.ToModSliderOption(1, 100);
            voidGhostLeviathanHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(voidGhostLeviathanHealthOption);

            ModSliderOption voidGhostLeviathanLimitOption = voidGhostLeviathanLimit.ToModSliderOption(0, 50);
            voidGhostLeviathanLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(voidGhostLeviathanLimitOption);

            ModToggleOption voidGhostLeviathanRandomizeOption = voidGhostLeviathanRandomize.ToModToggleOption();
            voidGhostLeviathanRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(voidGhostLeviathanRandomizeOption);

            ModSliderOption voidGhostLeviathanRandomizeMinOption = voidGhostLeviathanRandomizeMin.ToModSliderOption(1, 50);
            voidGhostLeviathanRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(voidGhostLeviathanRandomizeMinOption);

            ModSliderOption voidGhostLeviathanRandomizeMaxOption = voidGhostLeviathanRandomizeMax.ToModSliderOption(1, 50);
            voidGhostLeviathanRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(voidGhostLeviathanRandomizeMaxOption);





            ModToggleOption ghostRayExcludeOption = ghostRayExclude.ToModToggleOption();
            ghostRayExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(ghostRayExcludeOption);

            ModSliderOption ghostRayScaleOption = ghostRayScale.ToModSliderOption(1, 50);
            ghostRayScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostRayScaleOption);

            ModSliderOption ghostRaySlownessOption = ghostRaySlowness.ToModSliderOption(1, 100);
            ghostRaySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostRaySlownessOption);

            ModSliderOption ghostRayHealthOption = ghostRayHealth.ToModSliderOption(1, 100);
            ghostRayHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostRayHealthOption);

            ModSliderOption ghostRayLimitOption = ghostRayLimit.ToModSliderOption(0, 50);
            ghostRayLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostRayLimitOption);

            ModToggleOption ghostRayRandomizeOption = ghostRayRandomize.ToModToggleOption();
            ghostRayRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(ghostRayRandomizeOption);

            ModSliderOption ghostRayRandomizeMinOption = ghostRayRandomizeMin.ToModSliderOption(1, 50);
            ghostRayRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostRayRandomizeMinOption);

            ModSliderOption ghostRayRandomizeMaxOption = ghostRayRandomizeMax.ToModSliderOption(1, 50);
            ghostRayRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(ghostRayRandomizeMaxOption);





            ModToggleOption holeFishExcludeOption = holeFishExclude.ToModToggleOption();
            holeFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(holeFishExcludeOption);

            ModSliderOption holeFishScaleOption = holeFishScale.ToModSliderOption(1, 50);
            holeFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(holeFishScaleOption);

            ModSliderOption holeFishSlownessOption = holeFishSlowness.ToModSliderOption(1, 100);
            holeFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(holeFishSlownessOption);

            ModSliderOption holeFishHealthOption = holeFishHealth.ToModSliderOption(1, 100);
            holeFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(holeFishHealthOption);

            ModSliderOption holeFishLimitOption = holeFishLimit.ToModSliderOption(0, 50);
            holeFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(holeFishLimitOption);

            ModToggleOption holeFishRandomizeOption = holeFishRandomize.ToModToggleOption();
            holeFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(holeFishRandomizeOption);

            ModSliderOption holeFishRandomizeMinOption = holeFishRandomizeMin.ToModSliderOption(1, 50);
            holeFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(holeFishRandomizeMinOption);

            ModSliderOption holeFishRandomizeMaxOption = holeFishRandomizeMax.ToModSliderOption(1, 50);
            holeFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(holeFishRandomizeMaxOption);





            ModToggleOption hoopFishExcludeOption = hoopFishExclude.ToModToggleOption();
            hoopFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(hoopFishExcludeOption);

            ModSliderOption hoopFishScaleOption = hoopFishScale.ToModSliderOption(1, 50);
            hoopFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishScaleOption);

            ModSliderOption hoopFishSlownessOption = hoopFishSlowness.ToModSliderOption(1, 100);
            hoopFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishSlownessOption);

            ModSliderOption hoopFishHealthOption = hoopFishHealth.ToModSliderOption(1, 100);
            hoopFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishHealthOption);

            ModSliderOption hoopFishLimitOption = hoopFishLimit.ToModSliderOption(0, 50);
            hoopFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishLimitOption);

            ModToggleOption hoopFishRandomizeOption = hoopFishRandomize.ToModToggleOption();
            hoopFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(hoopFishRandomizeOption);

            ModSliderOption hoopFishRandomizeMinOption = hoopFishRandomizeMin.ToModSliderOption(1, 50);
            hoopFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishRandomizeMinOption);

            ModSliderOption hoopFishRandomizeMaxOption = hoopFishRandomizeMax.ToModSliderOption(1, 50);
            hoopFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishRandomizeMaxOption);





            ModToggleOption hoverFishExcludeOption = hoverFishExclude.ToModToggleOption();
            hoverFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(hoverFishExcludeOption);

            ModSliderOption hoverFishScaleOption = hoverFishScale.ToModSliderOption(1, 50);
            hoverFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(hoverFishScaleOption);

            ModSliderOption hoverFishSlownessOption = hoverFishSlowness.ToModSliderOption(1, 100);
            hoverFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(hoverFishSlownessOption);

            ModSliderOption hoverFishHealthOption = hoverFishHealth.ToModSliderOption(1, 100);
            hoverFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(hoverFishHealthOption);

            ModSliderOption hoverFishLimitOption = hoverFishLimit.ToModSliderOption(0, 50);
            hoverFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(hoverFishLimitOption);

            ModToggleOption hoverFishRandomizeOption = hoverFishRandomize.ToModToggleOption();
            hoverFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(hoverFishRandomizeOption);

            ModSliderOption hoverFishRandomizeMinOption = hoverFishRandomizeMin.ToModSliderOption(1, 50);
            hoverFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(hoverFishRandomizeMinOption);

            ModSliderOption hoverFishRandomizeMaxOption = hoverFishRandomizeMax.ToModSliderOption(1, 50);
            hoverFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(hoverFishRandomizeMaxOption);





            ModToggleOption jellyRayExcludeOption = jellyRayExclude.ToModToggleOption();
            jellyRayExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(jellyRayExcludeOption);

            ModSliderOption jellyRayScaleOption = jellyRayScale.ToModSliderOption(1, 50);
            jellyRayScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyRayScaleOption);

            ModSliderOption jellyRaySlownessOption = jellyRaySlowness.ToModSliderOption(1, 100);
            jellyRaySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyRaySlownessOption);

            ModSliderOption jellyRayHealthOption = jellyRayHealth.ToModSliderOption(1, 100);
            jellyRayHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyRayHealthOption);

            ModSliderOption jellyRayLimitOption = jellyRayLimit.ToModSliderOption(0, 50);
            jellyRayLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyRayLimitOption);

            ModToggleOption jellyRayRandomizeOption = jellyRayRandomize.ToModToggleOption();
            jellyRayRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(jellyRayRandomizeOption);

            ModSliderOption jellyRayRandomizeMinOption = jellyRayRandomizeMin.ToModSliderOption(1, 50);
            jellyRayRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyRayRandomizeMinOption);

            ModSliderOption jellyRayRandomizeMaxOption = jellyRayRandomizeMax.ToModSliderOption(1, 50);
            jellyRayRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyRayRandomizeMaxOption);





            ModToggleOption lavaLarvaExcludeOption = lavaLarvaExclude.ToModToggleOption();
            lavaLarvaExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(lavaLarvaExcludeOption);

            ModSliderOption lavaLarvaScaleOption = lavaLarvaScale.ToModSliderOption(1, 50);
            lavaLarvaScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLarvaScaleOption);

            ModSliderOption lavaLarvaSlownessOption = lavaLarvaSlowness.ToModSliderOption(1, 100);
            lavaLarvaSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLarvaSlownessOption);

            ModSliderOption lavaLarvaHealthOption = lavaLarvaHealth.ToModSliderOption(1, 100);
            lavaLarvaHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLarvaHealthOption);

            ModSliderOption lavaLarvaLimitOption = lavaLarvaLimit.ToModSliderOption(0, 50);
            lavaLarvaLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLarvaLimitOption);

            ModToggleOption lavaLarvaRandomizeOption = lavaLarvaRandomize.ToModToggleOption();
            lavaLarvaRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(lavaLarvaRandomizeOption);

            ModSliderOption lavaLarvaRandomizeMinOption = lavaLarvaRandomizeMin.ToModSliderOption(1, 50);
            lavaLarvaRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLarvaRandomizeMinOption);

            ModSliderOption lavaLarvaRandomizeMaxOption = lavaLarvaRandomizeMax.ToModSliderOption(1, 50);
            lavaLarvaRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLarvaRandomizeMaxOption);





            ModToggleOption lavaLizardExcludeOption = lavaLizardExclude.ToModToggleOption();
            lavaLizardExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(lavaLizardExcludeOption);

            ModSliderOption lavaLizardScaleOption = lavaLizardScale.ToModSliderOption(1, 50);
            lavaLizardScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLizardScaleOption);

            ModSliderOption lavaLizardSlownessOption = lavaLizardSlowness.ToModSliderOption(1, 100);
            lavaLizardSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLizardSlownessOption);

            ModSliderOption lavaLizardHealthOption = lavaLizardHealth.ToModSliderOption(1, 100);
            lavaLizardHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLizardHealthOption);

            ModSliderOption lavaLizardLimitOption = lavaLizardLimit.ToModSliderOption(0, 50);
            lavaLizardLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLizardLimitOption);

            ModToggleOption lavaLizardRandomizeOption = lavaLizardRandomize.ToModToggleOption();
            lavaLizardRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(lavaLizardRandomizeOption);

            ModSliderOption lavaLizardRandomizeMinOption = lavaLizardRandomizeMin.ToModSliderOption(1, 50);
            lavaLizardRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLizardRandomizeMinOption);

            ModSliderOption lavaLizardRandomizeMaxOption = lavaLizardRandomizeMax.ToModSliderOption(1, 50);
            lavaLizardRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(lavaLizardRandomizeMaxOption);





            ModToggleOption mesmerExcludeOption = mesmerExclude.ToModToggleOption();
            mesmerExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(mesmerExcludeOption);

            ModSliderOption mesmerScaleOption = mesmerScale.ToModSliderOption(1, 50);
            mesmerScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(mesmerScaleOption);

            ModSliderOption mesmerSlownessOption = mesmerSlowness.ToModSliderOption(1, 100);
            mesmerSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(mesmerSlownessOption);

            ModSliderOption mesmerHealthOption = mesmerHealth.ToModSliderOption(1, 100);
            mesmerHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(mesmerHealthOption);

            ModSliderOption mesmerLimitOption = mesmerLimit.ToModSliderOption(0, 50);
            mesmerLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(mesmerLimitOption);

            ModToggleOption mesmerRandomizeOption = mesmerRandomize.ToModToggleOption();
            mesmerRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(mesmerRandomizeOption);

            ModSliderOption mesmerRandomizeMinOption = mesmerRandomizeMin.ToModSliderOption(1, 50);
            mesmerRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(mesmerRandomizeMinOption);

            ModSliderOption mesmerRandomizeMaxOption = mesmerRandomizeMax.ToModSliderOption(1, 50);
            mesmerRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(mesmerRandomizeMaxOption);





            ModToggleOption oculusFishExcludeOption = oculusFishExclude.ToModToggleOption();
            oculusFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(oculusFishExcludeOption);

            ModSliderOption oculusFishScaleOption = oculusFishScale.ToModSliderOption(1, 50);
            oculusFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(oculusFishScaleOption);

            ModSliderOption oculusFishSlownessOption = oculusFishSlowness.ToModSliderOption(1, 100);
            oculusFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(oculusFishSlownessOption);

            ModSliderOption oculusFishHealthOption = oculusFishHealth.ToModSliderOption(1, 100);
            oculusFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(oculusFishHealthOption);

            ModSliderOption oculusFishLimitOption = oculusFishLimit.ToModSliderOption(0, 50);
            oculusFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(oculusFishLimitOption);

            ModToggleOption oculusFishRandomizeOption = oculusFishRandomize.ToModToggleOption();
            oculusFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(oculusFishRandomizeOption);

            ModSliderOption oculusFishRandomizeMinOption = oculusFishRandomizeMin.ToModSliderOption(1, 50);
            oculusFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(oculusFishRandomizeMinOption);

            ModSliderOption oculusFishRandomizeMaxOption = oculusFishRandomizeMax.ToModSliderOption(1, 50);
            oculusFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(oculusFishRandomizeMaxOption);





            ModToggleOption peeperExcludeOption = peeperExclude.ToModToggleOption();
            peeperExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(peeperExcludeOption);

            ModSliderOption peeperScaleOption = peeperScale.ToModSliderOption(1, 50);
            peeperScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperScaleOption);

            ModSliderOption peeperSlownessOption = peeperSlowness.ToModSliderOption(1, 100);
            peeperSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperSlownessOption);

            ModSliderOption peeperHealthOption = peeperHealth.ToModSliderOption(1, 100);
            peeperHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperHealthOption);

            ModSliderOption peeperLimitOption = peeperLimit.ToModSliderOption(0, 50);
            peeperLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperLimitOption);

            ModToggleOption peeperRandomizeOption = peeperRandomize.ToModToggleOption();
            peeperRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(peeperRandomizeOption);

            ModSliderOption peeperRandomizeMinOption = peeperRandomizeMin.ToModSliderOption(1, 50);
            peeperRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperRandomizeMinOption);

            ModSliderOption peeperRandomizeMaxOption = peeperRandomizeMax.ToModSliderOption(1, 50);
            peeperRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperRandomizeMaxOption);





            ModToggleOption rabbitRayExcludeOption = rabbitRayExclude.ToModToggleOption();
            rabbitRayExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(rabbitRayExcludeOption);

            ModSliderOption rabbitRayScaleOption = rabbitRayScale.ToModSliderOption(1, 50);
            rabbitRayScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(rabbitRayScaleOption);

            ModSliderOption rabbitRaySlownessOption = rabbitRaySlowness.ToModSliderOption(1, 100);
            rabbitRaySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(rabbitRaySlownessOption);

            ModSliderOption rabbitRayHealthOption = rabbitRayHealth.ToModSliderOption(1, 100);
            rabbitRayHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(rabbitRayHealthOption);

            ModSliderOption rabbitRayLimitOption = rabbitRayLimit.ToModSliderOption(0, 50);
            rabbitRayLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(rabbitRayLimitOption);

            ModToggleOption rabbitRayRandomizeOption = rabbitRayRandomize.ToModToggleOption();
            rabbitRayRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(rabbitRayRandomizeOption);

            ModSliderOption rabbitRayRandomizeMinOption = rabbitRayRandomizeMin.ToModSliderOption(1, 50);
            rabbitRayRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(rabbitRayRandomizeMinOption);

            ModSliderOption rabbitRayRandomizeMaxOption = rabbitRayRandomizeMax.ToModSliderOption(1, 50);
            rabbitRayRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(rabbitRayRandomizeMaxOption);





            ModToggleOption reaperLeviathanExcludeOption = reaperLeviathanExclude.ToModToggleOption();
            reaperLeviathanExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(reaperLeviathanExcludeOption);

            ModSliderOption reaperLeviathanScaleOption = reaperLeviathanScale.ToModSliderOption(1, 50);
            reaperLeviathanScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(reaperLeviathanScaleOption);

            ModSliderOption reaperLeviathanSlownessOption = reaperLeviathanSlowness.ToModSliderOption(1, 100);
            reaperLeviathanSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(reaperLeviathanSlownessOption);

            ModSliderOption reaperLeviathanHealthOption = reaperLeviathanHealth.ToModSliderOption(1, 100);
            reaperLeviathanHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(reaperLeviathanHealthOption);

            ModSliderOption reaperLeviathanLimitOption = reaperLeviathanLimit.ToModSliderOption(0, 50);
            reaperLeviathanLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(reaperLeviathanLimitOption);

            ModToggleOption reaperLeviathanRandomizeOption = reaperLeviathanRandomize.ToModToggleOption();
            reaperLeviathanRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(reaperLeviathanRandomizeOption);

            ModSliderOption reaperLeviathanRandomizeMinOption = reaperLeviathanRandomizeMin.ToModSliderOption(1, 50);
            reaperLeviathanRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(reaperLeviathanRandomizeMinOption);

            ModSliderOption reaperLeviathanRandomizeMaxOption = reaperLeviathanRandomizeMax.ToModSliderOption(1, 50);
            reaperLeviathanRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(reaperLeviathanRandomizeMaxOption);





            ModToggleOption reefbackExcludeOption = reefbackExclude.ToModToggleOption();
            reefbackExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(reefbackExcludeOption);

            ModSliderOption reefbackScaleOption = reefbackScale.ToModSliderOption(1, 50);
            reefbackScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(reefbackScaleOption);

            ModSliderOption reefbackSlownessOption = reefbackSlowness.ToModSliderOption(1, 100);
            reefbackSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(reefbackSlownessOption);

            ModSliderOption reefbackHealthOption = reefbackHealth.ToModSliderOption(1, 100);
            reefbackHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(reefbackHealthOption);

            ModSliderOption reefbackLimitOption = reefbackLimit.ToModSliderOption(0, 50);
            reefbackLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(reefbackLimitOption);

            ModToggleOption reefbackRandomizeOption = reefbackRandomize.ToModToggleOption();
            reefbackRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(reefbackRandomizeOption);

            ModSliderOption reefbackRandomizeMinOption = reefbackRandomizeMin.ToModSliderOption(1, 50);
            reefbackRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(reefbackRandomizeMinOption);

            ModSliderOption reefbackRandomizeMaxOption = reefbackRandomizeMax.ToModSliderOption(1, 50);
            reefbackRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(reefbackRandomizeMaxOption);





            ModToggleOption reginaldExcludeOption = reginaldExclude.ToModToggleOption();
            reginaldExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(reginaldExcludeOption);

            ModSliderOption reginaldScaleOption = reginaldScale.ToModSliderOption(1, 50);
            reginaldScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(reginaldScaleOption);

            ModSliderOption reginaldSlownessOption = reginaldSlowness.ToModSliderOption(1, 100);
            reginaldSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(reginaldSlownessOption);

            ModSliderOption reginaldHealthOption = reginaldHealth.ToModSliderOption(1, 100);
            reginaldHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(reginaldHealthOption);

            ModSliderOption reginaldLimitOption = reginaldLimit.ToModSliderOption(0, 50);
            reginaldLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(reginaldLimitOption);

            ModToggleOption reginaldRandomizeOption = reginaldRandomize.ToModToggleOption();
            reginaldRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(reginaldRandomizeOption);

            ModSliderOption reginaldRandomizeMinOption = reginaldRandomizeMin.ToModSliderOption(1, 50);
            reginaldRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(reginaldRandomizeMinOption);

            ModSliderOption reginaldRandomizeMaxOption = reginaldRandomizeMax.ToModSliderOption(1, 50);
            reginaldRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(reginaldRandomizeMaxOption);





            //ModToggleOption rockGrubExcludeOption = rockGrubExclude.ToModToggleOption();
            //rockGrubExcludeOption.OnChanged += ToggleOptionsChanged;
            //AddItem(rockGrubExcludeOption);

            //ModSliderOption rockGrubScaleOption = rockGrubScale.ToModSliderOption(1, 50);
            //rockGrubScaleOption.OnChanged += SliderOptionsChanged;
            //AddItem(rockGrubScaleOption);

            //ModSliderOption rockGrubSlownessOption = rockGrubSlowness.ToModSliderOption(1, 100);
            //rockGrubSlownessOption.OnChanged += SliderOptionsChanged;
            //AddItem(rockGrubSlownessOption);

            //ModSliderOption rockGrubHealthOption = rockGrubHealth.ToModSliderOption(1, 100);
            //rockGrubHealthOption.OnChanged += SliderOptionsChanged;
            //AddItem(rockGrubHealthOption);

            //ModSliderOption rockGrubLimitOption = rockGrubLimit.ToModSliderOption(0, 50);
            //rockGrubLimitOption.OnChanged += SliderOptionsChanged;
            //AddItem(rockGrubLimitOption);





            ModToggleOption spineEelExcludeOption = spineEelExclude.ToModToggleOption();
            spineEelExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(spineEelExcludeOption);

            ModSliderOption spineEelScaleOption = spineEelScale.ToModSliderOption(1, 50);
            spineEelScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(spineEelScaleOption);

            ModSliderOption spineEelSlownessOption = spineEelSlowness.ToModSliderOption(1, 100);
            spineEelSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(spineEelSlownessOption);

            ModSliderOption spineEelHealthOption = spineEelHealth.ToModSliderOption(1, 100);
            spineEelHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(spineEelHealthOption);

            ModSliderOption spineEelLimitOption = spineEelLimit.ToModSliderOption(0, 50);
            spineEelLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(spineEelLimitOption);

            ModToggleOption spineEelRandomizeOption = spineEelRandomize.ToModToggleOption();
            spineEelRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(spineEelRandomizeOption);

            ModSliderOption spineEelRandomizeMinOption = spineEelRandomizeMin.ToModSliderOption(1, 50);
            spineEelRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(spineEelRandomizeMinOption);

            ModSliderOption spineEelRandomizeMaxOption = spineEelRandomizeMax.ToModSliderOption(1, 50);
            spineEelRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(spineEelRandomizeMaxOption);





            ModToggleOption sandSharkExcludeOption = sandSharkExclude.ToModToggleOption();
            sandSharkExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(sandSharkExcludeOption);

            ModSliderOption sandSharkScaleOption = sandSharkScale.ToModSliderOption(1, 50);
            sandSharkScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(sandSharkScaleOption);

            ModSliderOption sandSharkSlownessOption = sandSharkSlowness.ToModSliderOption(1, 100);
            sandSharkSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(sandSharkSlownessOption);

            ModSliderOption sandSharkHealthOption = sandSharkHealth.ToModSliderOption(1, 100);
            sandSharkHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(sandSharkHealthOption);

            ModSliderOption sandSharkLimitOption = sandSharkLimit.ToModSliderOption(0, 50);
            sandSharkLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(sandSharkLimitOption);

            ModToggleOption sandSharkRandomizeOption = sandSharkRandomize.ToModToggleOption();
            sandSharkRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(sandSharkRandomizeOption);

            ModSliderOption sandSharkRandomizeMinOption = sandSharkRandomizeMin.ToModSliderOption(1, 50);
            sandSharkRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(sandSharkRandomizeMinOption);

            ModSliderOption sandSharkRandomizeMaxOption = sandSharkRandomizeMax.ToModSliderOption(1, 50);
            sandSharkRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(sandSharkRandomizeMaxOption);





            ModToggleOption seaDragonExcludeOption = seaDragonExclude.ToModToggleOption();
            seaDragonExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaDragonExcludeOption);

            ModSliderOption seaDragonScaleOption = seaDragonScale.ToModSliderOption(1, 50);
            seaDragonScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(seaDragonScaleOption);

            ModSliderOption seaDragonSlownessOption = seaDragonSlowness.ToModSliderOption(1, 100);
            seaDragonSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(seaDragonSlownessOption);

            ModSliderOption seaDragonHealthOption = seaDragonHealth.ToModSliderOption(1, 100);
            seaDragonHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(seaDragonHealthOption);

            ModSliderOption seaDragonLimitOption = seaDragonLimit.ToModSliderOption(0, 50);
            seaDragonLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(seaDragonLimitOption);

            ModToggleOption seaDragonRandomizeOption = seaDragonRandomize.ToModToggleOption();
            seaDragonRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaDragonRandomizeOption);

            ModSliderOption seaDragonRandomizeMinOption = seaDragonRandomizeMin.ToModSliderOption(1, 50);
            seaDragonRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(seaDragonRandomizeMinOption);

            ModSliderOption seaDragonRandomizeMaxOption = seaDragonRandomizeMax.ToModSliderOption(1, 50);
            seaDragonRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(seaDragonRandomizeMaxOption);





            ModToggleOption seaEmperorBabyExcludeOption = seaEmperorBabyExclude.ToModToggleOption();
            seaEmperorBabyExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaEmperorBabyExcludeOption);

            ModSliderOption seaEmperorBabyScaleOption = seaEmperorBabyScale.ToModSliderOption(1, 50);
            seaEmperorBabyScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorBabyScaleOption);

            ModSliderOption seaEmperorBabySlownessOption = seaEmperorBabySlowness.ToModSliderOption(1, 100);
            seaEmperorBabySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorBabySlownessOption);

            ModSliderOption seaEmperorBabyHealthOption = seaEmperorBabyHealth.ToModSliderOption(1, 100);
            seaEmperorBabyHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorBabyHealthOption);

            ModSliderOption seaEmperorBabyLimitOption = seaEmperorBabyLimit.ToModSliderOption(0, 50);
            seaEmperorBabyLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorBabyLimitOption);

            ModToggleOption seaEmperorBabyRandomizeOption = seaEmperorBabyRandomize.ToModToggleOption();
            seaEmperorBabyRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaEmperorBabyRandomizeOption);

            ModSliderOption seaEmperorBabyRandomizeMinOption = seaEmperorBabyRandomizeMin.ToModSliderOption(1, 50);
            seaEmperorBabyRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorBabyRandomizeMinOption);

            ModSliderOption seaEmperorBabyRandomizeMaxOption = seaEmperorBabyRandomizeMax.ToModSliderOption(1, 50);
            seaEmperorBabyRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorBabyRandomizeMaxOption);





            ModToggleOption seaEmperorJuvenileExcludeOption = seaEmperorJuvenileExclude.ToModToggleOption();
            seaEmperorJuvenileExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaEmperorJuvenileExcludeOption);

            ModSliderOption seaEmperorJuvenileScaleOption = seaEmperorJuvenileScale.ToModSliderOption(1, 50);
            seaEmperorJuvenileScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorJuvenileScaleOption);

            ModSliderOption seaEmperorJuvenileSlownessOption = seaEmperorJuvenileSlowness.ToModSliderOption(1, 100);
            seaEmperorJuvenileSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorJuvenileSlownessOption);

            ModSliderOption seaEmperorJuvenileHealthOption = seaEmperorJuvenileHealth.ToModSliderOption(1, 100);
            seaEmperorJuvenileHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorJuvenileHealthOption);

            ModSliderOption seaEmperorJuvenileLimitOption = seaEmperorJuvenileLimit.ToModSliderOption(0, 50);
            seaEmperorJuvenileLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorJuvenileLimitOption);

            ModToggleOption seaEmperorJuvenileRandomizeOption = seaEmperorJuvenileRandomize.ToModToggleOption();
            seaEmperorJuvenileRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaEmperorJuvenileRandomizeOption);

            ModSliderOption seaEmperorJuvenileRandomizeMinOption = seaEmperorJuvenileRandomizeMin.ToModSliderOption(1, 50);
            seaEmperorJuvenileRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorJuvenileRandomizeMinOption);

            ModSliderOption seaEmperorJuvenileRandomizeMaxOption = seaEmperorJuvenileRandomizeMax.ToModSliderOption(1, 50);
            seaEmperorJuvenileRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmperorJuvenileRandomizeMaxOption);





            ModToggleOption seaTreaderExcludeOption = seaTreaderExclude.ToModToggleOption();
            seaTreaderExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaTreaderExcludeOption);

            ModSliderOption seaTreaderScaleOption = seaTreaderScale.ToModSliderOption(1, 50);
            seaTreaderScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(seaTreaderScaleOption);

            ModSliderOption seaTreaderSlownessOption = seaTreaderSlowness.ToModSliderOption(1, 100);
            seaTreaderSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(seaTreaderSlownessOption);

            ModSliderOption seaTreaderHealthOption = seaTreaderHealth.ToModSliderOption(1, 100);
            seaTreaderHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(seaTreaderHealthOption);

            ModSliderOption seaTreaderLimitOption = seaTreaderLimit.ToModSliderOption(0, 50);
            seaTreaderLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(seaTreaderLimitOption);

            ModToggleOption seaTreaderRandomizeOption = seaTreaderRandomize.ToModToggleOption();
            seaTreaderRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaTreaderRandomizeOption);

            ModSliderOption seaTreaderRandomizeMinOption = seaTreaderRandomizeMin.ToModSliderOption(1, 50);
            seaTreaderRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(seaTreaderRandomizeMinOption);

            ModSliderOption seaTreaderRandomizeMaxOption = seaTreaderRandomizeMax.ToModSliderOption(1, 50);
            seaTreaderRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(seaTreaderRandomizeMaxOption);





            ModToggleOption jumperExcludeOption = jumperExclude.ToModToggleOption();
            jumperExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(jumperExcludeOption);

            ModSliderOption jumperScaleOption = jumperScale.ToModSliderOption(1, 50);
            jumperScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(jumperScaleOption);

            ModSliderOption jumperSlownessOption = jumperSlowness.ToModSliderOption(1, 100);
            jumperSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(jumperSlownessOption);

            ModSliderOption jumperHealthOption = jumperHealth.ToModSliderOption(1, 100);
            jumperHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(jumperHealthOption);

            ModSliderOption jumperLimitOption = jumperLimit.ToModSliderOption(0, 50);
            jumperLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(jumperLimitOption);

            ModToggleOption jumperRandomizeOption = jumperRandomize.ToModToggleOption();
            jumperRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(jumperRandomizeOption);

            ModSliderOption jumperRandomizeMinOption = jumperRandomizeMin.ToModSliderOption(1, 50);
            jumperRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(jumperRandomizeMinOption);

            ModSliderOption jumperRandomizeMaxOption = jumperRandomizeMax.ToModSliderOption(1, 50);
            jumperRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(jumperRandomizeMaxOption);





            ModToggleOption skyRayExcludeOption = skyRayExclude.ToModToggleOption();
            skyRayExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(skyRayExcludeOption);

            ModSliderOption skyRayScaleOption = skyRayScale.ToModSliderOption(1, 50);
            skyRayScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayScaleOption);

            ModSliderOption skyRaySlownessOption = skyRaySlowness.ToModSliderOption(1, 100);
            skyRaySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRaySlownessOption);

            ModSliderOption skyRayHealthOption = skyRayHealth.ToModSliderOption(1, 100);
            skyRayHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayHealthOption);

            ModSliderOption skyRayLimitOption = skyRayLimit.ToModSliderOption(0, 50);
            skyRayLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayLimitOption);

            ModToggleOption skyRayRandomizeOption = skyRayRandomize.ToModToggleOption();
            skyRayRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(skyRayRandomizeOption);

            ModSliderOption skyRayRandomizeMinOption = skyRayRandomizeMin.ToModSliderOption(1, 50);
            skyRayRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayRandomizeMinOption);

            ModSliderOption skyRayRandomizeMaxOption = skyRayRandomizeMax.ToModSliderOption(1, 50);
            skyRayRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayRandomizeMaxOption);





            ModToggleOption spadeFishExcludeOption = spadeFishExclude.ToModToggleOption();
            spadeFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(spadeFishExcludeOption);

            ModSliderOption spadeFishScaleOption = spadeFishScale.ToModSliderOption(1, 50);
            spadeFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(spadeFishScaleOption);

            ModSliderOption spadeFishSlownessOption = spadeFishSlowness.ToModSliderOption(1, 100);
            spadeFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(spadeFishSlownessOption);

            ModSliderOption spadeFishHealthOption = spadeFishHealth.ToModSliderOption(1, 100);
            spadeFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(spadeFishHealthOption);

            ModSliderOption spadeFishLimitOption = spadeFishLimit.ToModSliderOption(0, 50);
            spadeFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(spadeFishLimitOption);

            ModToggleOption spadeFishRandomizeOption = spadeFishRandomize.ToModToggleOption();
            spadeFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(spadeFishRandomizeOption);

            ModSliderOption spadeFishRandomizeMinOption = spadeFishRandomizeMin.ToModSliderOption(1, 50);
            spadeFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(spadeFishRandomizeMinOption);

            ModSliderOption spadeFishRandomizeMaxOption = spadeFishRandomizeMax.ToModSliderOption(1, 50);
            spadeFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(spadeFishRandomizeMaxOption);





            ModToggleOption stalkerExcludeOption = stalkerExclude.ToModToggleOption();
            stalkerExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(stalkerExcludeOption);

            ModSliderOption stalkerScaleOption = stalkerScale.ToModSliderOption(1, 50);
            stalkerScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(stalkerScaleOption);

            ModSliderOption stalkerSlownessOption = stalkerSlowness.ToModSliderOption(1, 100);
            stalkerSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(stalkerSlownessOption);

            ModSliderOption stalkerHealthOption = stalkerHealth.ToModSliderOption(1, 100);
            stalkerHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(stalkerHealthOption);
            
            ModSliderOption stalkerLimitOption = stalkerLimit.ToModSliderOption(0, 50);
            stalkerLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(stalkerLimitOption);

            ModToggleOption stalkerRandomizeOption = stalkerRandomize.ToModToggleOption();
            stalkerRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(stalkerRandomizeOption);

            ModSliderOption stalkerRandomizeMinOption = stalkerRandomizeMin.ToModSliderOption(1, 50);
            stalkerRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(stalkerRandomizeMinOption);

            ModSliderOption stalkerRandomizeMaxOption = stalkerRandomizeMax.ToModSliderOption(1, 50);
            stalkerRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(stalkerRandomizeMaxOption);





            ModToggleOption warperExcludeOption = warperExclude.ToModToggleOption();
            warperExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(warperExcludeOption);

            ModSliderOption warperScaleOption = warperScale.ToModSliderOption(1, 50);
            warperScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(warperScaleOption);

            ModSliderOption warperSlownessOption = warperSlowness.ToModSliderOption(1, 100);
            warperSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(warperSlownessOption);

            ModSliderOption warperHealthOption = warperHealth.ToModSliderOption(1, 100);
            warperHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(warperHealthOption);

            ModSliderOption warperLimitOption = warperLimit.ToModSliderOption(0, 50);
            warperLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(warperLimitOption);

            ModToggleOption warperRandomizeOption = warperRandomize.ToModToggleOption();
            warperRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(warperRandomizeOption);

            ModSliderOption warperRandomizeMinOption = warperRandomizeMin.ToModSliderOption(1, 50);
            warperRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(warperRandomizeMinOption);

            ModSliderOption warperRandomizeMaxOption = warperRandomizeMax.ToModSliderOption(1, 50);
            warperRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(warperRandomizeMaxOption);





            OptionsPanelHandler.RegisterModOptions(this);
        }

        public override void BuildModOptions(uGUI_TabbedControlsPanel panel, int modsTabIndex, IReadOnlyCollection<OptionItem> options)
        {
            HashSet<OptionItem> optionItemsHash = options.ToHashSet<OptionItem>();

            int p = panel.AddTab("Bigger Fish");

            foreach (OptionItem option in optionItemsHash)
            {
                if (option.Id.Contains("Misc. Options") && !miscOptions.Contains(option))
                {
                    miscOptions.Add(option);
                }
                else if (option.Id.Contains("Proportional Values") && !proportionalOptions.Contains(option))
                {
                    proportionalOptions.Add(option);
                }
                else if (option.Id.Contains("Ampeel Values") && !ampeelOptions.Contains(option))
                {
                    ampeelOptions.Add(option);
                }
                else if (option.Id.Contains("Biter Values") && !biterOptions.Contains(option))
                {
                    biterOptions.Add(option);
                }
                else if (option.Id.Contains("Bladderfish Values") && !bladderFishOptions.Contains(option))
                {
                    bladderFishOptions.Add(option);
                }
                else if (option.Id.Contains("Bleeder Values") && !bleederOptions.Contains(option))
                {
                    bleederOptions.Add(option);
                }
                else if (option.Id.Contains("Bone Shark Values") && !boneSharkOptions.Contains(option))
                {
                    boneSharkOptions.Add(option);
                }
                else if (option.Id.Contains("Boomerang Values") && !boomerangOptions.Contains(option))
                {
                    boomerangOptions.Add(option);
                }
                else if (option.Id.Contains("Cave Crawler Values") && !caveCrawlerOptions.Contains(option))
                {
                    caveCrawlerOptions.Add(option);
                }
                else if (option.Id.Contains("Crab Snake Values") && !crabSnakeOptions.Contains(option))
                {
                    crabSnakeOptions.Add(option);
                }
                else if (option.Id.Contains("Crab Squid Values") && !crabSquidOptions.Contains(option))
                {
                    crabSquidOptions.Add(option);
                }
                else if (option.Id.Contains("Crash Fish Values") && !crashFishOptions.Contains(option))
                {
                    crashFishOptions.Add(option);
                }
                else if (option.Id.Contains("Cuddlefish Values") && !cuddleFishOptions.Contains(option))
                {
                    cuddleFishOptions.Add(option);
                }
                else if (option.Id.Contains("Eyeye Values") && !eyeyeOptions.Contains(option))
                {
                    eyeyeOptions.Add(option);
                }
                else if (option.Id.Contains("Garry Fish Values") && !garryFishOptions.Contains(option))
                {
                    garryFishOptions.Add(option);
                }
                else if (option.Id.Contains("Gasopod Values") && !gasopodOptions.Contains(option))
                {
                    gasopodOptions.Add(option);
                }
                else if (option.Id.Contains("Ghost Leviathan Values") && !ghostLeviathanOptions.Contains(option))
                {
                    ghostLeviathanOptions.Add(option);
                }
                else if (option.Id.Contains("Ghost Leviathan(Void) Values") && !voidGhostLeviathanOptions.Contains(option))
                {
                    voidGhostLeviathanOptions.Add(option);
                }
                else if (option.Id.Contains("Ghost Ray Values") && !ghostRayOptions.Contains(option))
                {
                    ghostRayOptions.Add(option);
                }
                else if (option.Id.Contains("Hole Fish Values") && !holeFishOptions.Contains(option))
                {
                    holeFishOptions.Add(option);
                }
                else if (option.Id.Contains("Hoop Fish Values") && !hoopFishOptions.Contains(option))
                {
                    hoopFishOptions.Add(option);
                }
                else if (option.Id.Contains("Hover Fish Values") && !hoverFishOptions.Contains(option))
                {
                    hoverFishOptions.Add(option);
                }
                else if (option.Id.Contains("Jellyray Values") && !jellyRayOptions.Contains(option))
                {
                    jellyRayOptions.Add(option);
                }
                else if (option.Id.Contains("Shuttlebug Values") && !jumperOptions.Contains(option))
                {
                    jumperOptions.Add(option);
                }
                else if (option.Id.Contains("Lava Larva Values") && !lavaLarvaOptions.Contains(option))
                {
                    lavaLarvaOptions.Add(option);
                }
                else if (option.Id.Contains("Lava Lizard Values") && !lavaLizardOptions.Contains(option))
                {
                    lavaLizardOptions.Add(option);
                }
                else if (option.Id.Contains("Mesmer Values") && !mesmerOptions.Contains(option))
                {
                    mesmerOptions.Add(option);
                }
                else if (option.Id.Contains("Oculus Fish Values") && !oculusFishOptions.Contains(option))
                {
                    oculusFishOptions.Add(option);
                }
                else if (option.Id.Contains("Peeper Values") && !peeperOptions.Contains(option))
                {
                    peeperOptions.Add(option);
                }
                else if (option.Id.Contains("Rabbit Ray Values") && !rabbitRayOptions.Contains(option))
                {
                    rabbitRayOptions.Add(option);
                }
                else if (option.Id.Contains("Reaper Leviathan Values") && !reaperLeviathanOptions.Contains(option))
                {
                    reaperLeviathanOptions.Add(option);
                }
                else if (option.Id.Contains("Reefback Values") && !reefbackOptions.Contains(option))
                {
                    reefbackOptions.Add(option);
                }
                else if (option.Id.Contains("Reginald Values") && !reginaldOptions.Contains(option))
                {
                    reginaldOptions.Add(option);
                }
                else if (option.Id.Contains("Sand Shark Values") && !sandSharkOptions.Contains(option))
                {
                    sandSharkOptions.Add(option);
                }
                else if (option.Id.Contains("Sea Dragon Values") && !seaDragonOptions.Contains(option))
                {
                    seaDragonOptions.Add(option);
                }
                else if (option.Id.Contains("Sea Emperor Baby Values") && !seaEmperorBabyOptions.Contains(option))
                {
                    seaEmperorBabyOptions.Add(option);
                }
                else if (option.Id.Contains("Sea Emperor Juvenile Values") && !seaEmperorJuvenileOptions.Contains(option))
                {
                    seaEmperorJuvenileOptions.Add(option);
                }
                else if (option.Id.Contains("Sea Treader Values") && !seaTreaderOptions.Contains(option))
                {
                    seaTreaderOptions.Add(option);
                }
                else if (option.Id.Contains("Skyray Values") && !skyRayOptions.Contains(option))
                {
                    skyRayOptions.Add(option);
                }
                else if (option.Id.Contains("Spade Fish Values") && !spadeFishOptions.Contains(option))
                {
                    spadeFishOptions.Add(option);
                }
                else if (option.Id.Contains("River Prowler Values") && !spineEelOptions.Contains(option))
                {
                    spineEelOptions.Add(option);
                }
                else if (option.Id.Contains("Stalker Values") && !stalkerOptions.Contains(option))
                {
                    stalkerOptions.Add(option);
                }
                else if (option.Id.Contains("Warper Values") && !warperOptions.Contains(option))
                {
                    warperOptions.Add(option);
                }
            }
            panel.AddHeading(p, "~~~Misc. Options~~~");
            foreach (OptionItem option in miscOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Proportional Options~~~");
            foreach (OptionItem option in proportionalOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Ampeel Options~~~");
            foreach (OptionItem option in ampeelOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Biter Options~~~");
            foreach (OptionItem option in biterOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Bladderfish Options~~~");
            foreach (OptionItem option in bladderFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Bleeder Options~~~");
            foreach (OptionItem option in bleederOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Bone Shark Options~~~");
            foreach (OptionItem option in boneSharkOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Boomerang Options~~~");
            foreach (OptionItem option in boomerangOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Cave Crawler Options~~~");
            foreach (OptionItem option in caveCrawlerOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Crab Snake Options~~~");
            foreach (OptionItem option in crabSnakeOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Crab Squid Options~~~");
            foreach (OptionItem option in crabSquidOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Crash Fish Options~~~");
            foreach (OptionItem option in crashFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Cuddlefish Options~~~");
            foreach (OptionItem option in cuddleFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Eyeye Options~~~");
            foreach (OptionItem option in eyeyeOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Garry Fish Options~~~");
            foreach (OptionItem option in garryFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Gasopod Options~~~");
            foreach (OptionItem option in gasopodOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Ghost Leviathan Options~~~");
            foreach (OptionItem option in ghostLeviathanOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Ghost Leviathan(Void) Options~~~");
            foreach (OptionItem option in voidGhostLeviathanOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Ghost Ray Options~~~");
            foreach (OptionItem option in ghostRayOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Hole Fish Options~~~");
            foreach (OptionItem option in holeFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Hoop Fish Options~~~");
            foreach (OptionItem option in hoopFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Hover Fish Options~~~");
            foreach (OptionItem option in hoverFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Jellyray Options~~~");
            foreach (OptionItem option in jellyRayOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Shuttlebug Options~~~");
            foreach (OptionItem option in jumperOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Lava Larva Options~~~");
            foreach (OptionItem option in lavaLarvaOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Lava Lizard Options~~~");
            foreach (OptionItem option in lavaLizardOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Mesmer Options~~~");
            foreach (OptionItem option in mesmerOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Oculus Fish Options~~~");
            foreach (OptionItem option in oculusFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Peeper Options~~~");
            foreach (OptionItem option in peeperOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Rabbit Ray Options~~~");
            foreach (OptionItem option in rabbitRayOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Reaper Leviathan Options~~~");
            foreach (OptionItem option in reaperLeviathanOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Reefback Options~~~");
            foreach (OptionItem option in reefbackOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Reginald Options~~~");
            foreach (OptionItem option in reginaldOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Sand Shark Options~~~");
            foreach (OptionItem option in sandSharkOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Sea Dragon Options~~~");
            foreach (OptionItem option in seaDragonOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Sea Emperor Baby Options~~~");
            foreach (OptionItem option in seaEmperorBabyOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Sea Emperor Juvenile Options~~~");
            foreach (OptionItem option in seaEmperorJuvenileOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Sea Treader Options~~~");
            foreach (OptionItem option in seaTreaderOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Skyray Options~~~");
            foreach (OptionItem option in skyRayOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Spade Fish Options~~~");
            foreach (OptionItem option in spadeFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~River Prowler Options~~~");
            foreach (OptionItem option in spineEelOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Stalker Options~~~");
            foreach (OptionItem option in stalkerOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Warper Options~~~");
            foreach (OptionItem option in warperOptions)
            {
                option.AddToPanel(panel, p);
            }
        }

        #region OnChangedFunctions
        public void ToggleOptionsChanged(object sender, ToggleChangedEventArgs e)
        {
            switch (e.Id)
            {
                case "Proportional":
                    proportionalToggle.Value = e.Value;
                    break;
                case "Proportional Randomize":
                    proportionalRandomize.Value = e.Value;
                    break;
                case "Remove Fish Schools":
                    removeFishSchools.Value = e.Value;
                    break;
                case "Biter Exclude":
                    biterExclude.Value = e.Value;
                    break;
                case "Biter Randomize":
                    biterRandomize.Value = e.Value;
                    break;
                case "Bladderfish Exlude":
                    bladderFishExclude.Value = e.Value;
                    break;
                case "Bladderfish Randomize":
                    bladderFishRandomize.Value = e.Value;
                    break;
                case "Bleeder Exclude":
                    bleederExclude.Value = e.Value;
                    break;
                case "Bleeder Randomize":
                    bleederRandomize.Value = e.Value;
                    break;
                case "Bone Shark Exclude":
                    boneSharkExclude.Value = e.Value;
                    break;
                case "Bone Shark Randomize":
                    boneSharkRandomize.Value = e.Value;
                    break;
                case "Boomerang Exclude":
                    boomerangExclude.Value = e.Value;
                    break;
                case "Boomerang Randomize":
                    boomerangRandomize.Value = e.Value;
                    break;
                case "Cave Crawler Exclude":
                    caveCrawlerExclude.Value = e.Value;
                    break;
                case "Cave Crawler Randomize":
                    caveCrawlerRandomize.Value = e.Value;
                    break;
                case "Crab Snake Exclude":
                    crabSnakeExclude.Value = e.Value;
                    break;
                case "Crab Snake Randomize":
                    crabSnakeRandomize.Value = e.Value;
                    break;
                case "Crab Squid Exclude":
                    crabSquidExclude.Value = e.Value;
                    break;
                case "Crab Squid Randomize":
                    crabSquidRandomize.Value = e.Value;
                    break;
                case "Crashfish Exclude":
                    crashFishExclude.Value = e.Value;
                    break;
                case "Crashfish Randomize":
                    crashFishRandomize.Value = e.Value;
                    break;
                case "Cuddlefish Exclude":
                    cuddleFishExclude.Value = e.Value;
                    break;
                case "Cuddlefish Randomize":
                    cuddleFishRandomize.Value = e.Value;
                    break;
                case "Eyeye Exclude":
                    eyeyeExclude.Value = e.Value;
                    break;
                case "Eyeye Randomize":
                    eyeyeRandomize.Value = e.Value;
                    break;
                case "Garryfish Exclude":
                    garryFishExclude.Value = e.Value;
                    break;
                case "Garryfish Randomize":
                    garryFishRandomize.Value = e.Value;
                    break;
                case "Gasopod Exclude":
                    gasopodExclude.Value = e.Value;
                    break;
                case "Gasopod Randomize":
                    gasopodRandomize.Value = e.Value;
                    break;
                case "Ghost Leviathan Exclude":
                    ghostLeviathanExclude.Value = e.Value;
                    break;
                case "Ghost Leviathan Randomize":
                    ghostLeviathanRandomize.Value = e.Value;
                    break;
                case "Ghost Leviathan(Void) Exclude":
                    voidGhostLeviathanExclude.Value = e.Value;
                    break;
                case "Ghost Leviathan(Void) Randomize":
                    voidGhostLeviathanRandomize.Value = e.Value;
                    break;
                case "Ghost Ray Exclude":
                    ghostRayExclude.Value = e.Value;
                    break;
                case "Ghost Ray Randomize":
                    ghostRayRandomize.Value = e.Value;
                    break;
                case "Holefish Exclude":
                    holeFishExclude.Value = e.Value;
                    break;
                case "Holefish Randomize":
                    holeFishRandomize.Value = e.Value;
                    break;
                case "Hoopfish Exclude":
                    hoopFishExclude.Value = e.Value;
                    break;
                case "Hoopfish Randomize":
                    hoopFishRandomize.Value = e.Value;
                    break;
                case "Hoverfish Exclude":
                    hoverFishExclude.Value = e.Value;
                    break;
                case "Hoverfish Randomize":
                    hoverFishRandomize.Value = e.Value;
                    break;
                case "Jelly Ray Exclude":
                    jellyRayExclude.Value = e.Value;
                    break;
                case "Jellyray Randomize":
                    jellyRayRandomize.Value = e.Value;
                    break;
                case "Jumper Exclude":
                    jumperExclude.Value = e.Value;
                    break;
                case "Jumper Randomize":
                    jumperRandomize.Value = e.Value;
                    break;
                case "Lava Larva Exclude":
                    lavaLarvaExclude.Value = e.Value;
                    break;
                case "Lava Larva Randomize":
                    lavaLarvaRandomize.Value = e.Value;
                    break;
                case "Lava Lizard Exclude":
                    lavaLizardExclude.Value = e.Value;
                    break;
                case "Lava Lizard Randomize":
                    lavaLizardRandomize.Value = e.Value;
                    break;
                case "Mesmer Exclude":
                    mesmerExclude.Value = e.Value;
                    break;
                case "Mesmer Randomize":
                    mesmerRandomize.Value = e.Value;
                    break;
                case "Oculus Exclude":
                    oculusFishExclude.Value = e.Value;
                    break;
                case "Oculus Randomize":
                    oculusFishRandomize.Value = e.Value;
                    break;
                case "Peeper Exclude":
                    peeperExclude.Value = e.Value;
                    break;
                case "Peeper Randomize":
                    peeperRandomize.Value = e.Value;
                    break;
                case "Rabbit Ray Exclude":
                    rabbitRayExclude.Value = e.Value;
                    break;
                case "Rabbit Ray Randomize":
                    rabbitRayRandomize.Value = e.Value;
                    break;
                case "Reaper Leviathan Exclude":
                    reaperLeviathanExclude.Value = e.Value;
                    break;
                case "Reaper Leviathan Randomize":
                    reaperLeviathanRandomize.Value = e.Value;
                    break;
                case "Reefback Exclude":
                    reefbackExclude.Value = e.Value;
                    break;
                case "Reefback Randomize":
                    reefbackRandomize.Value = e.Value;
                    break;
                case "Reginald Exclude":
                    reginaldExclude.Value = e.Value;
                    break;
                case "Reginald Randomize":
                    reginaldRandomize.Value = e.Value;
                    break;
                case "Sand Shark Exclude":
                    sandSharkExclude.Value = e.Value;
                    break;
                case "Sand Shark Randomize":
                    sandSharkRandomize.Value = e.Value;
                    break;
                case "Sea Dragon Exclude":
                    seaDragonExclude.Value = e.Value;
                    break;
                case "Sea Dragon Randomize":
                    seaDragonRandomize.Value = e.Value;
                    break;
                case "Sea Emperor Baby Exclude":
                    seaEmperorBabyExclude.Value = e.Value;
                    break;
                case "Sea Emperor Baby Randomize":
                    seaEmperorBabyRandomize.Value = e.Value;
                    break;
                case "Sea Emperor Juvenile Exclude":
                    seaEmperorJuvenileExclude.Value = e.Value;
                    break;
                case "Sea Emperor Juvenile Randomize":
                    seaEmperorJuvenileRandomize.Value = e.Value;
                    break;
                case "Sea Treader Exclude":
                    seaTreaderExclude.Value = e.Value;
                    break;
                case "Sea Treader Randomize":
                    seaTreaderRandomize.Value = e.Value;
                    break;
                case "Ampeel Exclude":
                    shockerExclude.Value = e.Value;
                    break;
                case "Ampeel Randomize":
                    shockerRandomize.Value = e.Value;
                    break;
                case "Skyray Exclude":
                    skyRayExclude.Value = e.Value;
                    break;
                case "Skyray Randomize":
                    skyRayRandomize.Value = e.Value;
                    break;
                case "Spadefish Exclude":
                    spadeFishExclude.Value = e.Value;
                    break;
                case "Spadefish Randomize":
                    spadeFishRandomize.Value = e.Value;
                    break;
                case "Spine Eel Exclude":
                    spineEelExclude.Value = e.Value;
                    break;
                case "Spine Eel Randomize":
                    spineEelRandomize.Value = e.Value;
                    break;
                case "Stalker Exclude":
                    stalkerExclude.Value = e.Value;
                    break;
                case "Stalker Randomize":
                    stalkerRandomize.Value = e.Value;
                    break;
                case "Warper Exclude":
                    warperExclude.Value = e.Value;
                    break;
                case "Warper Randomize":
                    warperRandomize.Value = e.Value;
                    break;
            }
        }

        private void SliderOptionsChanged(object sender, SliderChangedEventArgs e)
        {
            switch (e.Id)
            {
                case "Proportional Scale":
                    proportionalScale.Value = e.Value;
                    break;
                case "Proportional Slowness":
                    proportionalSlowness.Value = e.Value;
                    break;
                case "Proportional Health":
                    proportionalHealth.Value = e.Value;
                    break;
                case "Proportional Creature Limit":
                    proportionalCreatureLimit.Value = e.Value;
                    break;
                case "Proportional Randomize Min":
                    proportionalRandomizeMin.Value = e.Value;
                    break;
                case "Proportional Randomize Max":
                    proportionalRandomizeMax.Value = e.Value;
                    break;

                case "Biter Scale":
                    biterScale.Value = e.Value;
                    break;
                case "Biter Slowness":
                    biterSlowness.Value = e.Value;
                    break;
                case "Biter Health":
                    biterHealth.Value = e.Value;
                    break;
                case "Biter Limit":
                    biterLimit.Value = e.Value;
                    break;
                case "Biter Randomize Min":
                    biterRandomizeMin.Value = e.Value;
                    break;
                case "Biter Randomize Max":
                    biterRandomizeMax.Value = e.Value;
                    break;

                case "Bladderfish Scale":
                    bladderFishScale.Value = e.Value;
                    break;
                case "Bladderfish Slowness":
                    bladderFishSlowness.Value = e.Value;
                    break;
                case "Bladderfish Health":
                    bladderFishHealth.Value = e.Value;
                    break;
                case "Bladderfish Limit":
                    bladderFishLimit.Value = e.Value;
                    break;
                case "Bladderfish Randomize Min":
                    bladderFishRandomizeMin.Value = e.Value;
                    break;
                case "Bladderfish Randomize Max":
                    bladderFishRandomizeMax.Value = e.Value;
                    break;

                case "Bleeder Scale":
                    bleederScale.Value = e.Value;
                    break;
                case "Bleeder Slowness":
                    bleederSlowness.Value = e.Value;
                    break;
                case "Bleeder Health":
                    bleederHealth.Value = e.Value;
                    break;
                case "Bleeder Limit":
                    bleederLimit.Value = e.Value;
                    break;
                case "Bleeder Randomize Min":
                    bleederRandomizeMin.Value = e.Value;
                    break;
                case "Bleeder Randomize Max":
                    bleederRandomizeMax.Value = e.Value;
                    break;

                case "Bone Shark Scale":
                    boneSharkScale.Value = e.Value;
                    break;
                case "Bone Shark Slowness":
                    boneSharkSlowness.Value = e.Value;
                    break;
                case "Bone Shark Health":
                    boneSharkHealth.Value = e.Value;
                    break;
                case "Bone Shark Limit":
                    boneSharkLimit.Value = e.Value;
                    break;
                case "Bone Shark Randomize Min":
                    boneSharkRandomizeMin.Value = e.Value;
                    break;
                case "Bone Shark Randomize Max":
                    boneSharkRandomizeMax.Value = e.Value;
                    break;

                case "Boomerang Scale":
                    boomerangScale.Value = e.Value;
                    break;
                case "Boomerang Slowness":
                    boomerangSlowness.Value = e.Value;
                    break;
                case "Boomerang Health":
                    boomerangHealth.Value = e.Value;
                    break;
                case "Boomerang Limit":
                    boomerangLimit.Value = e.Value;
                    break;
                case "Boomerang Randomize Min":
                    boomerangRandomizeMin.Value = e.Value;
                    break;
                case "Boomerang Randomize Max":
                    boomerangRandomizeMax.Value = e.Value;
                    break;

                case "Cave Crawler Scale":
                    caveCrawlerScale.Value = e.Value;
                    break;
                case "Cave Crawler Slowness":
                    caveCrawlerSlowness.Value = e.Value;
                    break;
                case "Cave Crawler Health":
                    caveCrawlerHealth.Value = e.Value;
                    break;
                case "Cave Crawler Limit":
                    caveCrawlerLimit.Value = e.Value;
                    break;
                case "Cave Crawler Randomize Min":
                    caveCrawlerRandomizeMin.Value = e.Value;
                    break;
                case "Cave Crawler Randomize Max":
                    caveCrawlerRandomizeMax.Value = e.Value;
                    break;

                case "Crab Snake Scale":
                    crabSnakeScale.Value = e.Value;
                    break;
                case "Crab Snake Slowness":
                    crabSnakeSlowness.Value = e.Value;
                    break;
                case "Crab Snake Health":
                    crabSnakeHealth.Value = e.Value;
                    break;
                case "Crab Snake Limit":
                    crabSnakeLimit.Value = e.Value;
                    break;
                case "Crab Snake Randomize Min":
                    crabSnakeRandomizeMin.Value = e.Value;
                    break;
                case "Crab Snake Randomize Max":
                    crabSnakeRandomizeMax.Value = e.Value;
                    break;

                case "Crab Squid Scale":
                    crabSquidScale.Value = e.Value;
                    break;
                case "Crab Squid Slowness":
                    crabSquidSlowness.Value = e.Value;
                    break;
                case "Crab Squid Health":
                    crabSquidHealth.Value = e.Value;
                    break;
                case "Crab Squid Limit":
                    crabSquidLimit.Value = e.Value;
                    break;
                case "Crab Squid Randomize Min":
                    crabSquidRandomizeMin.Value = e.Value;
                    break;
                case "Crab Squid Randomize Max":
                    crabSquidRandomizeMax.Value = e.Value;
                    break;

                case "Crash Fish Scale":
                    crashFishScale.Value = e.Value;
                    break;
                case "Crash Fish Slowness":
                    crashFishSlowness.Value = e.Value;
                    break;
                case "Crash Fish Health":
                    crashFishHealth.Value = e.Value;
                    break;
                case "Crash Fish Limit":
                    crashFishLimit.Value = e.Value;
                    break;
                case "Crash Fish Randomize Min":
                    crashFishRandomizeMin.Value = e.Value;
                    break;
                case "Crash Fish Randomize Max":
                    crashFishRandomizeMax.Value = e.Value;
                    break;

                case "Cuddlefish Scale":
                    cuddleFishScale.Value = e.Value;
                    break;
                case "Cuddlefish Slowness":
                    cuddleFishSlowness.Value = e.Value;
                    break;
                case "Cuddlefish Health":
                    cuddleFishHealth.Value = e.Value;
                    break;
                case "Cuddlefish Limit":
                    cuddleFishLimit.Value = e.Value;
                    break;
                case "Cuddlefish Randomize Min":
                    cuddleFishRandomizeMin.Value = e.Value;
                    break;
                case "Cuddlefish Randomize Max":
                    cuddleFishRandomizeMax.Value = e.Value;
                    break;

                case "Eyeye Scale":
                    eyeyeScale.Value = e.Value;
                    break;
                case "Eyeye Slowness":
                    eyeyeSlowness.Value = e.Value;
                    break;
                case "Eyeye Health":
                    eyeyeHealth.Value = e.Value;
                    break;
                case "Eyeye Limit":
                    eyeyeLimit.Value = e.Value;
                    break;
                case "Eyeye Randomize Min":
                    eyeyeRandomizeMin.Value = e.Value;
                    break;
                case "Eyeye Randomize Max":
                    eyeyeRandomizeMax.Value = e.Value;
                    break;

                case "Garry Fish Scale":
                    garryFishScale.Value = e.Value;
                    break;
                case "Garry Fish Slowness":
                    garryFishSlowness.Value = e.Value;
                    break;
                case "Garry Fish Health":
                    garryFishHealth.Value = e.Value;
                    break;
                case "Garry Fish Limit":
                    garryFishLimit.Value = e.Value;
                    break;
                case "Garry Fish Randomize Min":
                    garryFishRandomizeMin.Value = e.Value;
                    break;
                case "Garry Fish Randomize Max":
                    garryFishRandomizeMax.Value = e.Value;
                    break;

                case "Gasopod Scale":
                    gasopodScale.Value = e.Value;
                    break;
                case "Gasopod Slowness":
                    gasopodSlowness.Value = e.Value;
                    break;
                case "Gasopod Health":
                    gasopodHealth.Value = e.Value;
                    break;
                case "Gasopod Limit":
                    gasopodLimit.Value = e.Value;
                    break;
                case "Gasopod Randomize Min":
                    gasopodRandomizeMin.Value = e.Value;
                    break;
                case "Gasopod Randomize Max":
                    gasopodRandomizeMax.Value = e.Value;

                    break;
                case "Ghost Leviathan Scale(Void)":
                    voidGhostLeviathanScale.Value = e.Value;
                    break;
                case "Ghost Leviathan Slowness(Void)":
                    voidGhostLeviathanSlowness.Value = e.Value;
                    break;
                case "Ghost Leviathan Health(Void)":
                    voidGhostLeviathanHealth.Value = e.Value;
                    break;
                case "Ghost Leviathan Limit(Void)":
                    voidGhostLeviathanLimit.Value = e.Value;
                    break;
                case "Ghost Leviathan(Void) Randomize Min":
                    voidGhostLeviathanRandomizeMin.Value = e.Value;
                    break;
                case "Ghost Leviathan(Void) Randomize Max":
                    voidGhostLeviathanRandomizeMax.Value = e.Value;
                    break;

                case "Ghost Leviathan Scale":
                    ghostLeviathanScale.Value = e.Value;
                    break;
                case "Ghost Leviathan Slowness":
                    ghostLeviathanSlowness.Value = e.Value;
                    break;
                case "Ghost Leviathan Health":
                    ghostLeviathanHealth.Value = e.Value;
                    break;
                case "Ghost Leviathan Limit":
                    ghostLeviathanLimit.Value = e.Value;
                    break;
                case "Ghost Leviathan Randomize Min":
                    ghostLeviathanRandomizeMin.Value = e.Value;
                    break;
                case "Ghost Leviathan Randomize Max":
                    ghostLeviathanRandomizeMax.Value = e.Value;
                    break;

                case "Ghost Ray Scale":
                    ghostRayScale.Value = e.Value;
                    break;
                case "Ghost Ray Slowness":
                    ghostRaySlowness.Value = e.Value;
                    break;
                case "Ghost Ray Health":
                    ghostRayHealth.Value = e.Value;
                    break;
                case "Ghost Ray Limit":
                    ghostRayLimit.Value = e.Value;
                    break;
                case "Ghost Ray Randomize Min":
                    ghostRayRandomizeMin.Value = e.Value;
                    break;
                case "Ghost Ray Randomize Max":
                    ghostRayRandomizeMax.Value = e.Value;
                    break;

                case "Holefish Scale":
                    holeFishScale.Value = e.Value;
                    break;
                case "Holefish Slowness":
                    holeFishSlowness.Value = e.Value;
                    break;
                case "Holefish Health":
                    holeFishHealth.Value = e.Value;
                    break;
                case "Holefish Limit":
                    holeFishLimit.Value = e.Value;
                    break;
                case "Holefish Randomize Min":
                    holeFishRandomizeMin.Value = e.Value;
                    break;
                case "Holefish Randomize Max":
                    holeFishRandomizeMax.Value = e.Value;
                    break;

                case "Hoopfish Scale":
                    hoopFishScale.Value = e.Value;
                    break;
                case "Hoopfish Slowness":
                    hoopFishSlowness.Value = e.Value;
                    break;
                case "Hoopfish Health":
                    hoopFishHealth.Value = e.Value;
                    break;
                case "Hoopfish Limit":
                    hoopFishLimit.Value = e.Value;
                    break;
                case "Hoopfish Randomize Min":
                    hoopFishRandomizeMin.Value = e.Value;
                    break;
                case "Hoopfish Randomize Max":
                    hoopFishRandomizeMax.Value = e.Value;
                    break;

                case "Hoverfish Scale":
                    hoverFishScale.Value = e.Value;
                    break;
                case "Hoverfish Slowness":
                    hoverFishSlowness.Value = e.Value;
                    break;
                case "Hoverfish Health":
                    hoverFishHealth.Value = e.Value;
                    break;
                case "Hoverfish Limit":
                    hoverFishLimit.Value = e.Value;
                    break;
                case "Hoverfish Randomize Min":
                    hoverFishRandomizeMin.Value = e.Value;
                    break;
                case "Hoverfish Randomize Max":
                    hoverFishRandomizeMax.Value = e.Value;

                    break;
                case "Jellyray Scale":
                    jellyRayScale.Value = e.Value;
                    break;
                case "Jellyray Slowness":
                    jellyRaySlowness.Value = e.Value;
                    break;
                case "Jellyray Health":
                    jellyRayHealth.Value = e.Value;
                    break;
                case "Jellyray Limit":
                    jellyRayLimit.Value = e.Value;
                    break;
                case "Jellyray Randomize Min":
                    jellyRayRandomizeMin.Value = e.Value;
                    break;
                case "Jellyray Randomize Max":
                    jellyRayRandomizeMax.Value = e.Value;

                    break;
                case "Jumper Scale":
                    jumperScale.Value = e.Value;
                    break;
                case "Jumper Slowness":
                    jumperSlowness.Value = e.Value;
                    break;
                case "Jumper Health":
                    jumperHealth.Value = e.Value;
                    break;
                case "Jumper Limit":
                    jumperLimit.Value = e.Value;
                    break;
                case "Jumper Randomize Min":
                    jumperRandomizeMin.Value = e.Value;
                    break;
                case "Jumper Randomize Max":
                    jumperRandomizeMax.Value = e.Value;

                    break;
                case "Lava Larva Scale":
                    lavaLarvaScale.Value = e.Value;
                    break;
                case "Lava Larva Slowness":
                    lavaLarvaSlowness.Value = e.Value;
                    break;
                case "Lava Larva Health":
                    lavaLarvaHealth.Value = e.Value;
                    break;
                case "Lava Larva Limit":
                    lavaLarvaLimit.Value = e.Value;
                    break;
                case "Lava Larva Randomize Min":
                    lavaLarvaRandomizeMin.Value = e.Value;
                    break;
                case "Lava Larva Randomize Max":
                    lavaLarvaRandomizeMax.Value = e.Value;
                    break;

                case "Lava Lizard Scale":
                    lavaLizardScale.Value = e.Value;
                    break;
                case "Lava Lizard Slowness":
                    lavaLizardSlowness.Value = e.Value;
                    break;
                case "Lava Lizard Health":
                    lavaLizardHealth.Value = e.Value;
                    break;
                case "Lava Lizard Limit":
                    lavaLizardLimit.Value = e.Value;
                    break;
                case "Lava Lizard Randomize Min":
                    lavaLizardRandomizeMin.Value = e.Value;
                    break;
                case "Lava Lizard Randomize Max":
                    lavaLizardRandomizeMax.Value = e.Value;
                    break;

                case "Mesmer Scale":
                    mesmerScale.Value = e.Value;
                    break;
                case "Mesmer Slowness":
                    mesmerSlowness.Value = e.Value;
                    break;
                case "Mesmer Health":
                    mesmerHealth.Value = e.Value;
                    break;
                case "Mesmer Limit":
                    mesmerLimit.Value = e.Value;
                    break;
                case "Mesmer Randomize Min":
                    mesmerRandomizeMin.Value = e.Value;
                    break;
                case "Mesmer Randomize Max":
                    mesmerRandomizeMax.Value = e.Value;
                    break;

                case "Oculus Scale":
                    oculusFishScale.Value = e.Value;
                    break;
                case "Oculus Slowness":
                    oculusFishSlowness.Value = e.Value;
                    break;
                case "Oculus Health":
                    oculusFishHealth.Value = e.Value;
                    break;
                case "Oculus Limit":
                    oculusFishLimit.Value = e.Value;
                    break;
                case "Oculus Randomize Min":
                    oculusFishRandomizeMin.Value = e.Value;
                    break;
                case "Oculus Randomize Max":
                    oculusFishRandomizeMax.Value = e.Value;
                    break;

                case "Peeper Scale":
                    peeperScale.Value = e.Value;
                    break;
                case "Peeper Slowness":
                    peeperSlowness.Value = e.Value;
                    break;
                case "Peeper Health":
                    peeperHealth.Value = e.Value;
                    break;
                case "Peeper Limit":
                    peeperLimit.Value = e.Value;
                    break;
                case "Peeper Randomize Min":
                    peeperRandomizeMin.Value = e.Value;
                    break;
                case "Peeper Randomize Max":
                    peeperRandomizeMax.Value = e.Value;

                    break;
                case "Rabbit Ray Scale":
                    rabbitRayScale.Value = e.Value;
                    break;
                case "Rabbit Ray Slowness":
                    rabbitRaySlowness.Value = e.Value;
                    break;
                case "Rabbit Ray Health":
                    rabbitRayHealth.Value = e.Value;
                    break;
                case "Rabbit Ray Limit":
                    rabbitRayLimit.Value = e.Value;
                    break;
                case "Rabbit Ray Randomize Min":
                    rabbitRayRandomizeMin.Value = e.Value;
                    break;
                case "Rabbit Ray Randomize Max":
                    rabbitRayRandomizeMax.Value = e.Value;

                    break;
                case "Reaper Leviathan Scale":
                    reaperLeviathanScale.Value = e.Value;
                    break;
                case "Reaper Leviathan Slowness":
                    reaperLeviathanSlowness.Value = e.Value;
                    break;
                case "Reaper Leviathan Health":
                    reaperLeviathanHealth.Value = e.Value;
                    break;
                case "Reaper Leviathan Limit":
                    reaperLeviathanLimit.Value = e.Value;
                    break;
                case "Reaper Leviathan Randomize Min":
                    reaperLeviathanRandomizeMin.Value = e.Value;
                    break;
                case "Reaper Leviathan Randomize Max":
                    reaperLeviathanRandomizeMax.Value = e.Value;

                    break;
                case "Reefback Scale":
                    reefbackScale.Value = e.Value;
                    break;
                case "Reefback Slowness":
                    reefbackSlowness.Value = e.Value;
                    break;
                case "Reefback Health":
                    reefbackHealth.Value = e.Value;
                    break;
                case "Reefback Limit":
                    reefbackLimit.Value = e.Value;
                    break;
                case "Reefback Randomize Min":
                    reefbackRandomizeMin.Value = e.Value;
                    break;
                case "Reefback Randomize Max":
                    reefbackRandomizeMax.Value = e.Value;

                    break;
                case "Reginald Scale":
                    reginaldScale.Value = e.Value;
                    break;
                case "Reginald Slowness":
                    reginaldSlowness.Value = e.Value;
                    break;
                case "Reginald Health":
                    reginaldHealth.Value = e.Value;
                    break;
                case "Reginald Limit":
                    reginaldLimit.Value = e.Value;
                    break;
                case "Reginald Randomize Min":
                    reginaldRandomizeMin.Value = e.Value;
                    break;
                case "Reginald Randomize Max":
                    reginaldRandomizeMax.Value = e.Value;
                    break;

                //case "Rock Grub Scale":
                //    rockGrubScale.Value = e.Value;
                //    break;
                //case "Rock Grub Slowness":
                //    rockGrubSlowness.Value = e.Value;
                //    break;
                //case "Rock Grub Health":
                //    rockGrubHealth.Value = e.Value;
                //    break;
                //case "Rock Grub Limit":
                //    rockGrubLimit.Value = e.Value;
                //    break;

                case "Sand Shark Scale":
                    sandSharkScale.Value = e.Value;
                    break;
                case "Sand Shark Slowness":
                    sandSharkSlowness.Value = e.Value;
                    break;
                case "Sand Shark Health":
                    sandSharkHealth.Value = e.Value;
                    break;
                case "Sand Shark Limit":
                    sandSharkLimit.Value = e.Value;
                    break;
                case "Sand Shark Randomize Min":
                    sandSharkRandomizeMin.Value = e.Value;
                    break;
                case "Sand Shark Randomize Max":
                    sandSharkRandomizeMax.Value = e.Value;
                    break;

                case "Sea Dragon Scale":
                    seaDragonScale.Value = e.Value;
                    break;
                case "Sea Dragon Slowness":
                    seaDragonSlowness.Value = e.Value;
                    break;
                case "Sea Dragon Health":
                    seaDragonHealth.Value = e.Value;
                    break;
                case "Sea Dragon Limit":
                    seaDragonLimit.Value = e.Value;
                    break;
                case "Sea Dragon Randomize Min":
                    seaDragonRandomizeMin.Value = e.Value;
                    break;
                case "Sea Dragon Randomize Max":
                    seaDragonRandomizeMax.Value = e.Value;
                    break;

                case "Sea Emperor Baby Scale":
                    seaEmperorBabyScale.Value = e.Value;
                    break;
                case "Sea Emperor Baby Slowness":
                    seaEmperorBabySlowness.Value = e.Value;
                    break;
                case "Sea Emperor Baby Health":
                    seaEmperorBabyHealth.Value = e.Value;
                    break;
                case "Sea Emperor Baby Limit":
                    seaEmperorBabyLimit.Value = e.Value;
                    break;
                case "Sea Emperor Baby Randomize Min":
                    seaEmperorBabyRandomizeMin.Value = e.Value;
                    break;
                case "Sea Emperor Baby Randomize Max":
                    seaEmperorBabyRandomizeMax.Value = e.Value;
                    break;

                case "Sea Emperor Juvenile Scale":
                    seaEmperorJuvenileScale.Value = e.Value;
                    break;
                case "Sea Emperor Juvenile Slowness":
                    seaEmperorJuvenileSlowness.Value = e.Value;
                    break;
                case "Sea Emperor Juvenile Health":
                    seaEmperorJuvenileHealth.Value = e.Value;
                    break;
                case "Sea Emperor Juvenile Limit":
                    seaEmperorJuvenileLimit.Value = e.Value;
                    break;
                case "Sea Emperor Juvenile Randomize Min":
                    seaEmperorJuvenileRandomizeMin.Value = e.Value;
                    break;
                case "Sea Emperor Juvenile Randomize Max":
                    seaEmperorJuvenileRandomizeMax.Value = e.Value;
                    break;

                case "Sea Treader Scale":
                    seaTreaderScale.Value = e.Value;
                    break;
                case "Sea Treader Slowness":
                    seaTreaderSlowness.Value = e.Value;
                    break;
                case "Sea Treader Health":
                    seaTreaderHealth.Value = e.Value;
                    break;
                case "Sea Treader Limit":
                    seaTreaderLimit.Value = e.Value;
                    break;
                case "Sea Treader Randomize Min":
                    seaTreaderRandomizeMin.Value = e.Value;
                    break;
                case "Sea Treader Randomize Max":
                    seaTreaderRandomizeMax.Value = e.Value;
                    break;

                case "Shocker Scale":
                    shockerScale.Value = e.Value;
                    break;
                case "Shocker Slowness":
                    shockerSlowness.Value = e.Value;
                    break;
                case "Shocker Health":
                    shockerHealth.Value = e.Value;
                    break;
                case "Shocker Limit":
                    shockerLimit.Value = e.Value;
                    break;
                case "Shocker Randomize Min":
                    shockerRandomizeMin.Value = e.Value;
                    break;
                case "Shocker Randomize Max":
                    shockerRandomizeMax.Value = e.Value;
                    break;

                case "Skyray Scale":
                    skyRayScale.Value = e.Value;
                    break;
                case "Skyray Slowness":
                    skyRaySlowness.Value = e.Value;
                    break;
                case "Skyray Health":
                    skyRayHealth.Value = e.Value;
                    break;
                case "Skyray Limit":
                    skyRayLimit.Value = e.Value;
                    break;
                case "Skyray Randomize Min":
                    skyRayRandomizeMin.Value = e.Value;
                    break;
                case "Skyray Randomize Max":
                    skyRayRandomizeMax.Value = e.Value;
                    break;

                case "Spadefish Scale":
                    spadeFishScale.Value = e.Value;
                    break;
                case "Spadefish Slowness":
                    spadeFishSlowness.Value = e.Value;
                    break;
                case "Spadefish Health":
                    spadeFishHealth.Value = e.Value;
                    break;
                case "Spadefish Limit":
                    spadeFishLimit.Value = e.Value;
                    break;
                case "Spadefish Randomize Min":
                    spadeFishRandomizeMin.Value = e.Value;
                    break;
                case "Spadefish Randomize Max":
                    spadeFishRandomizeMax.Value = e.Value;
                    break;

                case "Spine Eel Scale":
                    spineEelScale.Value = e.Value;
                    break;
                case "Spine Eel Slowness":
                    spineEelSlowness.Value = e.Value;
                    break;
                case "Spine Eel Health":
                    spineEelHealth.Value = e.Value;
                    break;
                case "Spine Eel Limit":
                    spineEelLimit.Value = e.Value;
                    break;
                case "Spine Eel Randomize Min":
                    spineEelRandomizeMin.Value = e.Value;
                    break;
                case "Spine Eel Randomize Max":
                    spineEelRandomizeMax.Value = e.Value;
                    break;

                case "Stalker Scale":
                    stalkerScale.Value = e.Value;
                    break;
                case "Stalker Slowness":
                    stalkerSlowness.Value = e.Value;
                    break;
                case "Stalker Health":
                    stalkerHealth.Value = e.Value;
                    break;
                case "Stalker Limit":
                    stalkerLimit.Value = e.Value;
                    break;
                case "Stalker Randomize Min":
                    stalkerRandomizeMin.Value = e.Value;
                    break;
                case "Stalker Randomize Max":
                    stalkerRandomizeMax.Value = e.Value;
                    break;

                case "Warper Scale":
                    warperScale.Value = e.Value;
                    break;
                case "Warper Slowness":
                    warperSlowness.Value = e.Value;
                    break;
                case "Warper Health":
                    warperHealth.Value = e.Value;
                    break;
                case "Warper Limit":
                    warperLimit.Value = e.Value;
                    break;
                case "Warper Randomize Min":
                    warperRandomizeMin.Value = e.Value;
                    break;
                case "Warper Randomize Max":
                    warperRandomizeMax.Value = e.Value;
                    break;
                    #endregion
            }
        }
    }
#endif

#if SUBNAUTICAZERO
    public class MyModOptions : ModOptions
    {
        #region Config Entries
        public static ConfigEntry<bool> removeFishSchools;
        public static ConfigEntry<bool> proportionalToggle;
        public static ConfigEntry<float> proportionalScale;
        public static ConfigEntry<float> proportionalSlowness;
        public static ConfigEntry<float> proportionalHealth;
        public static ConfigEntry<float> proportionalCreatureLimit;
        public static ConfigEntry<bool> proportionalRandomize;
        public static ConfigEntry<float> proportionalRandomizeMin;
        public static ConfigEntry<float> proportionalRandomizeMax;

        public static ConfigEntry<bool> arcticPeeperExclude;
        public static ConfigEntry<float> arcticPeeperScale;
        public static ConfigEntry<float> arcticPeeperSlowness;
        public static ConfigEntry<float> arcticPeeperHealth;
        public static ConfigEntry<float> arcticPeeperLimit;
        public static ConfigEntry<bool> arcticPeeperRandomize;
        public static ConfigEntry<float> arcticPeeperRandomizeMin;
        public static ConfigEntry<float> arcticPeeperRandomizeMax;
        public static ConfigEntry<float> arcticPeeperBaseHealth;
        public static ConfigEntry<float> arcticPeeperBaseMaxAcceleration;
        public static ConfigEntry<float> arcticPeeperBaseForwardRotationSpeed;
        public static ConfigEntry<float> arcticPeeperBaseUpRotationSpeed;
        public static ConfigEntry<float> arcticPeeperBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> arrowRayExclude;
        public static ConfigEntry<float> arrowRayScale;
        public static ConfigEntry<float> arrowRaySlowness;
        public static ConfigEntry<float> arrowRayHealth;
        public static ConfigEntry<float> arrowRayLimit;
        public static ConfigEntry<bool> arrowRayRandomize;
        public static ConfigEntry<float> arrowRayRandomizeMin;
        public static ConfigEntry<float> arrowRayRandomizeMax;
        public static ConfigEntry<float> arrowRayBaseHealth;
        public static ConfigEntry<float> arrowRayBaseMaxAcceleration;
        public static ConfigEntry<float> arrowRayBaseForwardRotationSpeed;
        public static ConfigEntry<float> arrowRayBaseUpRotationSpeed;
        public static ConfigEntry<float> arrowRayBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> boomerangExclude;
        public static ConfigEntry<float> boomerangScale;
        public static ConfigEntry<float> boomerangSlowness;
        public static ConfigEntry<float> boomerangHealth;
        public static ConfigEntry<float> boomerangLimit;
        public static ConfigEntry<bool> boomerangRandomize;
        public static ConfigEntry<float> boomerangRandomizeMin;
        public static ConfigEntry<float> boomerangRandomizeMax;
        public static ConfigEntry<float> boomerangBaseHealth;
        public static ConfigEntry<float> boomerangBaseMaxAcceleration;
        public static ConfigEntry<float> boomerangBaseForwardRotationSpeed;
        public static ConfigEntry<float> boomerangBaseUpRotationSpeed;
        public static ConfigEntry<float> boomerangBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> bladderFishExclude;
        public static ConfigEntry<float> bladderFishScale;
        public static ConfigEntry<float> bladderFishSlowness;
        public static ConfigEntry<float> bladderFishHealth;
        public static ConfigEntry<float> bladderFishLimit;
        public static ConfigEntry<bool> bladderFishRandomize;
        public static ConfigEntry<float> bladderFishRandomizeMin;
        public static ConfigEntry<float> bladderFishRandomizeMax;
        public static ConfigEntry<float> bladderFishBaseHealth;
        public static ConfigEntry<float> bladderFishBaseMaxAcceleration;
        public static ConfigEntry<float> bladderFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> bladderFishBaseUpRotationSpeed;
        public static ConfigEntry<float> bladderFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> hoopFishExclude;
        public static ConfigEntry<float> hoopFishScale;
        public static ConfigEntry<float> hoopFishSlowness;
        public static ConfigEntry<float> hoopFishHealth;
        public static ConfigEntry<float> hoopFishLimit;
        public static ConfigEntry<bool> hoopFishRandomize;
        public static ConfigEntry<float> hoopFishRandomizeMin;
        public static ConfigEntry<float> hoopFishRandomizeMax;
        public static ConfigEntry<float> hoopFishBaseHealth;
        public static ConfigEntry<float> hoopFishBaseMaxAcceleration;
        public static ConfigEntry<float> hoopFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> hoopFishBaseUpRotationSpeed;
        public static ConfigEntry<float> hoopFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> discusFishExclude;
        public static ConfigEntry<float> discusFishScale;
        public static ConfigEntry<float> discusFishSlowness;
        public static ConfigEntry<float> discusFishHealth;
        public static ConfigEntry<float> discusFishLimit;
        public static ConfigEntry<bool> discusFishRandomize;
        public static ConfigEntry<float> discusFishRandomizeMin;
        public static ConfigEntry<float> discusFishRandomizeMax;
        public static ConfigEntry<float> discusFishBaseHealth;
        public static ConfigEntry<float> discusFishBaseMaxAcceleration;
        public static ConfigEntry<float> discusFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> discusFishBaseUpRotationSpeed;
        public static ConfigEntry<float> discusFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> featherFishExclude;
        public static ConfigEntry<float> featherFishScale;
        public static ConfigEntry<float> featherFishSlowness;
        public static ConfigEntry<float> featherFishHealth;
        public static ConfigEntry<float> featherFishLimit;
        public static ConfigEntry<bool> featherFishRandomize;
        public static ConfigEntry<float> featherFishRandomizeMin;
        public static ConfigEntry<float> featherFishRandomizeMax;
        public static ConfigEntry<float> featherFishBaseHealth;
        public static ConfigEntry<float> featherFishBaseMaxAcceleration;
        public static ConfigEntry<float> featherFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> featherFishBaseUpRotationSpeed;
        public static ConfigEntry<float> featherFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> nootFishExclude;
        public static ConfigEntry<float> nootFishScale;
        public static ConfigEntry<float> nootFishSlowness;
        public static ConfigEntry<float> nootFishHealth;
        public static ConfigEntry<float> nootFishLimit;
        public static ConfigEntry<bool> nootFishRandomize;
        public static ConfigEntry<float> nootFishRandomizeMin;
        public static ConfigEntry<float> nootFishRandomizeMax;
        public static ConfigEntry<float> nootFishBaseHealth;
        public static ConfigEntry<float> nootFishBaseMaxAcceleration;
        public static ConfigEntry<float> nootFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> nootFishBaseUpRotationSpeed;
        public static ConfigEntry<float> nootFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> spinnerFishExclude;
        public static ConfigEntry<float> spinnerFishScale;
        public static ConfigEntry<float> spinnerFishSlowness;
        public static ConfigEntry<float> spinnerFishHealth;
        public static ConfigEntry<float> spinnerFishLimit;
        public static ConfigEntry<bool> spinnerFishRandomize;
        public static ConfigEntry<float> spinnerFishRandomizeMin;
        public static ConfigEntry<float> spinnerFishRandomizeMax;
        public static ConfigEntry<float> spinnerFishBaseHealth;
        public static ConfigEntry<float> spinnerFishBaseMaxAcceleration;
        public static ConfigEntry<float> spinnerFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> spinnerFishBaseUpRotationSpeed;
        public static ConfigEntry<float> spinnerFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> arcticRayExclude;
        public static ConfigEntry<float> arcticRayScale;
        public static ConfigEntry<float> arcticRaySlowness;
        public static ConfigEntry<float> arcticRayHealth;
        public static ConfigEntry<float> arcticRayLimit;
        public static ConfigEntry<bool> arcticRayRandomize;
        public static ConfigEntry<float> arcticRayRandomizeMin;
        public static ConfigEntry<float> arcticRayRandomizeMax;
        public static ConfigEntry<float> arcticRayBaseHealth;
        public static ConfigEntry<float> arcticRayBaseMaxAcceleration;
        public static ConfigEntry<float> arcticRayBaseForwardRotationSpeed;
        public static ConfigEntry<float> arcticRayBaseUpRotationSpeed;
        public static ConfigEntry<float> arcticRayBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> jellyFishExclude;
        public static ConfigEntry<float> jellyFishScale;
        public static ConfigEntry<float> jellyFishSlowness;
        public static ConfigEntry<float> jellyFishHealth;
        public static ConfigEntry<float> jellyFishLimit;
        public static ConfigEntry<bool> jellyFishRandomize;
        public static ConfigEntry<float> jellyFishRandomizeMin;
        public static ConfigEntry<float> jellyFishRandomizeMax;
        public static ConfigEntry<float> jellyFishBaseHealth;
        public static ConfigEntry<float> jellyFishBaseMaxAcceleration;
        public static ConfigEntry<float> jellyFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> jellyFishBaseUpRotationSpeed;
        public static ConfigEntry<float> jellyFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> titanHoleFishExclude;
        public static ConfigEntry<float> titanHoleFishScale;
        public static ConfigEntry<float> titanHoleFishSlowness;
        public static ConfigEntry<float> titanHoleFishHealth;
        public static ConfigEntry<float> titanHoleFishLimit;
        public static ConfigEntry<bool> titanHoleFishRandomize;
        public static ConfigEntry<float> titanHoleFishRandomizeMin;
        public static ConfigEntry<float> titanHoleFishRandomizeMax;
        public static ConfigEntry<float> titanHoleFishBaseHealth;
        public static ConfigEntry<float> titanHoleFishBaseMaxAcceleration;
        public static ConfigEntry<float> titanHoleFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> titanHoleFishBaseUpRotationSpeed;
        public static ConfigEntry<float> titanHoleFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> glowWhaleExclude;
        public static ConfigEntry<float> glowWhaleScale;
        public static ConfigEntry<float> glowWhaleSlowness;
        public static ConfigEntry<float> glowWhaleHealth;
        public static ConfigEntry<float> glowWhaleLimit;
        public static ConfigEntry<bool> glowWhaleRandomize;
        public static ConfigEntry<float> glowWhaleRandomizeMin;
        public static ConfigEntry<float> glowWhaleRandomizeMax;
        public static ConfigEntry<float> glowWhaleBaseHealth;
        public static ConfigEntry<float> glowWhaleBaseMaxAcceleration;
        public static ConfigEntry<float> glowWhaleBaseForwardRotationSpeed;
        public static ConfigEntry<float> glowWhaleBaseUpRotationSpeed;
        public static ConfigEntry<float> glowWhaleBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> pinnacaridExclude;
        public static ConfigEntry<float> pinnacaridScale;
        public static ConfigEntry<float> pinnacaridSlowness;
        public static ConfigEntry<float> pinnacaridHealth;
        public static ConfigEntry<float> pinnacaridLimit;
        public static ConfigEntry<bool> pinnacaridRandomize;
        public static ConfigEntry<float> pinnacaridRandomizeMin;
        public static ConfigEntry<float> pinnacaridRandomizeMax;
        public static ConfigEntry<float> pinnacaridBaseHealth;
        public static ConfigEntry<float> pinnacaridBaseMaxAcceleration;
        public static ConfigEntry<float> pinnacaridBaseForwardRotationSpeed;
        public static ConfigEntry<float> pinnacaridBaseUpRotationSpeed;
        public static ConfigEntry<float> pinnacaridBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> triopsExclude;
        public static ConfigEntry<float> triopsScale;
        public static ConfigEntry<float> triopsSlowness;
        public static ConfigEntry<float> triopsHealth;
        public static ConfigEntry<float> triopsLimit;
        public static ConfigEntry<bool> triopsRandomize;
        public static ConfigEntry<float> triopsRandomizeMin;
        public static ConfigEntry<float> triopsRandomizeMax;
        public static ConfigEntry<float> triopsBaseHealth;
        public static ConfigEntry<float> triopsBaseMaxAcceleration;
        public static ConfigEntry<float> triopsBaseForwardRotationSpeed;
        public static ConfigEntry<float> triopsBaseUpRotationSpeed;
        public static ConfigEntry<float> triopsBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> trivalveExclude;
        public static ConfigEntry<float> trivalveScale;
        public static ConfigEntry<float> trivalveSlowness;
        public static ConfigEntry<float> trivalveHealth;
        public static ConfigEntry<float> trivalveLimit;
        public static ConfigEntry<bool> trivalveRandomize;
        public static ConfigEntry<float> trivalveRandomizeMin;
        public static ConfigEntry<float> trivalveRandomizeMax;
        public static ConfigEntry<float> trivalveBaseHealth;
        public static ConfigEntry<float> trivalveBaseMaxAcceleration;
        public static ConfigEntry<float> trivalveBaseForwardRotationSpeed;
        public static ConfigEntry<float> trivalveBaseUpRotationSpeed;
        public static ConfigEntry<float> trivalveBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> symbioteFishExclude;
        public static ConfigEntry<float> symbioteFishScale;
        public static ConfigEntry<float> symbioteFishSlowness;
        public static ConfigEntry<float> symbioteFishHealth;
        public static ConfigEntry<float> symbioteFishLimit;
        public static ConfigEntry<bool> symbioteFishRandomize;
        public static ConfigEntry<float> symbioteFishRandomizeMin;
        public static ConfigEntry<float> symbioteFishRandomizeMax;
        public static ConfigEntry<float> symbioteFishBaseHealth;
        public static ConfigEntry<float> symbioteFishBaseMaxAcceleration;
        public static ConfigEntry<float> symbioteFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> symbioteFishBaseUpRotationSpeed;
        public static ConfigEntry<float> symbioteFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> rockGrubExclude;
        public static ConfigEntry<float> rockGrubScale;
        public static ConfigEntry<float> rockGrubSlowness;
        public static ConfigEntry<float> rockGrubHealth;
        public static ConfigEntry<float> rockGrubLimit;
        public static ConfigEntry<bool> rockGrubRandomize;
        public static ConfigEntry<float> rockGrubRandomizeMin;
        public static ConfigEntry<float> rockGrubRandomizeMax;
        public static ConfigEntry<float> rockGrubBaseHealth;
        public static ConfigEntry<float> rockGrubBaseMaxAcceleration;
        public static ConfigEntry<float> rockGrubBaseForwardRotationSpeed;
        public static ConfigEntry<float> rockGrubBaseUpRotationSpeed;
        public static ConfigEntry<float> rockGrubBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> crashFishExclude;
        public static ConfigEntry<float> crashFishScale;
        public static ConfigEntry<float> crashFishSlowness;
        public static ConfigEntry<float> crashFishHealth;
        public static ConfigEntry<float> crashFishLimit;
        public static ConfigEntry<bool> crashFishRandomize;
        public static ConfigEntry<float> crashFishRandomizeMin;
        public static ConfigEntry<float> crashFishRandomizeMax;
        public static ConfigEntry<float> crashFishBaseHealth;
        public static ConfigEntry<float> crashFishBaseMaxAcceleration;
        public static ConfigEntry<float> crashFishBaseForwardRotationSpeed;
        public static ConfigEntry<float> crashFishBaseUpRotationSpeed;
        public static ConfigEntry<float> crashFishBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> brineWingExclude;
        public static ConfigEntry<float> brineWingScale;
        public static ConfigEntry<float> brineWingSlowness;
        public static ConfigEntry<float> brineWingHealth;
        public static ConfigEntry<float> brineWingLimit;
        public static ConfigEntry<bool> brineWingRandomize;
        public static ConfigEntry<float> brineWingRandomizeMin;
        public static ConfigEntry<float> brineWingRandomizeMax;
        public static ConfigEntry<float> brineWingBaseHealth;
        public static ConfigEntry<float> brineWingBaseMaxAcceleration;
        public static ConfigEntry<float> brineWingBaseForwardRotationSpeed;
        public static ConfigEntry<float> brineWingBaseUpRotationSpeed;
        public static ConfigEntry<float> brineWingBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> lilyPaddlerExclude;
        public static ConfigEntry<float> lilyPaddlerScale;
        public static ConfigEntry<float> lilyPaddlerSlowness;
        public static ConfigEntry<float> lilyPaddlerHealth;
        public static ConfigEntry<float> lilyPaddlerLimit;
        public static ConfigEntry<bool> lilyPaddlerRandomize;
        public static ConfigEntry<float> lilyPaddlerRandomizeMin;
        public static ConfigEntry<float> lilyPaddlerRandomizeMax;
        public static ConfigEntry<float> lilyPaddlerBaseHealth;
        public static ConfigEntry<float> lilyPaddlerBaseMaxAcceleration;
        public static ConfigEntry<float> lilyPaddlerBaseForwardRotationSpeed;
        public static ConfigEntry<float> lilyPaddlerBaseUpRotationSpeed;
        public static ConfigEntry<float> lilyPaddlerBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> cryptosuchusExclude;
        public static ConfigEntry<float> cryptosuchusScale;
        public static ConfigEntry<float> cryptosuchusSlowness;
        public static ConfigEntry<float> cryptosuchusHealth;
        public static ConfigEntry<float> cryptosuchusLimit;
        public static ConfigEntry<bool> cryptosuchusRandomize;
        public static ConfigEntry<float> cryptosuchusRandomizeMin;
        public static ConfigEntry<float> cryptosuchusRandomizeMax;
        public static ConfigEntry<float> cryptosuchusBaseHealth;
        public static ConfigEntry<float> cryptosuchusBaseMaxAcceleration;
        public static ConfigEntry<float> cryptosuchusBaseForwardRotationSpeed;
        public static ConfigEntry<float> cryptosuchusBaseUpRotationSpeed;
        public static ConfigEntry<float> cryptosuchusBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> bruteSharkExclude;
        public static ConfigEntry<float> bruteSharkScale;
        public static ConfigEntry<float> bruteSharkSlowness;
        public static ConfigEntry<float> bruteSharkHealth;
        public static ConfigEntry<float> bruteSharkBaseHealth;
        public static ConfigEntry<float> bruteSharkLimit;
        public static ConfigEntry<bool> bruteSharkRandomize;
        public static ConfigEntry<float> bruteSharkRandomizeMin;
        public static ConfigEntry<float> bruteSharkRandomizeMax;
        public static ConfigEntry<float> bruteSharkBaseMaxAcceleration;
        public static ConfigEntry<float> bruteSharkBaseForwardRotationSpeed;
        public static ConfigEntry<float> bruteSharkBaseUpRotationSpeed;
        public static ConfigEntry<float> bruteSharkBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> squidSharkExclude;
        public static ConfigEntry<float> squidSharkScale;
        public static ConfigEntry<float> squidSharkSlowness;
        public static ConfigEntry<float> squidSharkHealth;
        public static ConfigEntry<float> squidSharkLimit;
        public static ConfigEntry<bool> squidSharkRandomize;
        public static ConfigEntry<float> squidSharkRandomizeMin;
        public static ConfigEntry<float> squidSharkRandomizeMax;
        public static ConfigEntry<float> squidSharkBaseHealth;
        public static ConfigEntry<float> squidSharkBaseMaxAcceleration;
        public static ConfigEntry<float> squidSharkBaseForwardRotationSpeed;
        public static ConfigEntry<float> squidSharkBaseUpRotationSpeed;
        public static ConfigEntry<float> squidSharkBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> chelicerateExclude;
        public static ConfigEntry<float> chelicerateScale;
        public static ConfigEntry<float> chelicerateSlowness;
        public static ConfigEntry<float> chelicerateHealth;
        public static ConfigEntry<float> chelicerateLimit;
        public static ConfigEntry<bool> chelicerateRandomize;
        public static ConfigEntry<float> chelicerateRandomizeMin;
        public static ConfigEntry<float> chelicerateRandomizeMax;
        public static ConfigEntry<float> chelicerateBaseHealth;
        public static ConfigEntry<float> chelicerateBaseMaxAcceleration;
        public static ConfigEntry<float> chelicerateBaseForwardRotationSpeed;
        public static ConfigEntry<float> chelicerateBaseUpRotationSpeed;
        public static ConfigEntry<float> chelicerateBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> shadowLeviathanExclude;
        public static ConfigEntry<float> shadowLeviathanScale;
        public static ConfigEntry<float> shadowLeviathanSlowness;
        public static ConfigEntry<float> shadowLeviathanHealth;
        public static ConfigEntry<float> shadowLeviathanLimit;
        public static ConfigEntry<bool> shadowLeviathanRandomize;
        public static ConfigEntry<float> shadowLeviathanRandomizeMin;
        public static ConfigEntry<float> shadowLeviathanRandomizeMax;
        public static ConfigEntry<float> shadowLeviathanBaseHealth;
        public static ConfigEntry<float> shadowLeviathanBaseMaxAcceleration;
        public static ConfigEntry<float> shadowLeviathanBaseForwardRotationSpeed;
        public static ConfigEntry<float> shadowLeviathanBaseUpRotationSpeed;
        public static ConfigEntry<float> shadowLeviathanBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> voidLeviathanExclude;
        public static ConfigEntry<float> voidLeviathanScale;
        public static ConfigEntry<float> voidLeviathanSlowness;
        public static ConfigEntry<float> voidLeviathanHealth;
        public static ConfigEntry<float> voidLeviathanLimit;
        public static ConfigEntry<bool> voidLeviathanRandomize;
        public static ConfigEntry<float> voidLeviathanRandomizeMin;
        public static ConfigEntry<float> voidLeviathanRandomizeMax;
        public static ConfigEntry<float> voidLeviathanBaseHealth;
        public static ConfigEntry<float> voidLeviathanBaseMaxAcceleration;
        public static ConfigEntry<float> voidLeviathanBaseForwardRotationSpeed;
        public static ConfigEntry<float> voidLeviathanBaseUpRotationSpeed;
        public static ConfigEntry<float> voidLeviathanBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> skyRayExclude;
        public static ConfigEntry<float> skyRayScale;
        public static ConfigEntry<float> skyRaySlowness;
        public static ConfigEntry<float> skyRayHealth;
        public static ConfigEntry<float> skyRayLimit;
        public static ConfigEntry<bool> skyRayRandomize;
        public static ConfigEntry<float> skyRayRandomizeMin;
        public static ConfigEntry<float> skyRayRandomizeMax;
        public static ConfigEntry<float> skyRayBaseHealth;
        public static ConfigEntry<float> skyRayBaseMaxAcceleration;
        public static ConfigEntry<float> skyRayBaseForwardRotationSpeed;
        public static ConfigEntry<float> skyRayBaseUpRotationSpeed;
        public static ConfigEntry<float> skyRayBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> penglingExclude;
        public static ConfigEntry<float> penglingScale;
        public static ConfigEntry<float> penglingSlowness;
        public static ConfigEntry<float> penglingHealth;
        public static ConfigEntry<float> penglingLimit;
        public static ConfigEntry<bool> penglingRandomize;
        public static ConfigEntry<float> penglingRandomizeMin;
        public static ConfigEntry<float> penglingRandomizeMax;
        public static ConfigEntry<float> penglingBaseHealth;
        public static ConfigEntry<float> penglingBaseMaxAcceleration;
        public static ConfigEntry<float> penglingBaseForwardRotationSpeed;
        public static ConfigEntry<float> penglingBaseUpRotationSpeed;
        public static ConfigEntry<float> penglingBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> pengwingExclude;
        public static ConfigEntry<float> pengwingScale;
        public static ConfigEntry<float> pengwingSlowness;
        public static ConfigEntry<float> pengwingHealth;
        public static ConfigEntry<float> pengwingLimit;
        public static ConfigEntry<bool> pengwingRandomize;
        public static ConfigEntry<float> pengwingRandomizeMin;
        public static ConfigEntry<float> pengwingRandomizeMax;
        public static ConfigEntry<float> pengwingBaseHealth;
        public static ConfigEntry<float> pengwingBaseMaxAcceleration;
        public static ConfigEntry<float> pengwingBaseForwardRotationSpeed;
        public static ConfigEntry<float> pengwingBaseUpRotationSpeed;
        public static ConfigEntry<float> pengwingBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> seaMonkeyBabyExclude;
        public static ConfigEntry<float> seaMonkeyBabyScale;
        public static ConfigEntry<float> seaMonkeyBabySlowness;
        public static ConfigEntry<float> seaMonkeyBabyHealth;
        public static ConfigEntry<float> seaMonkeyBabyLimit;
        public static ConfigEntry<bool> seaMonkeyBabyRandomize;
        public static ConfigEntry<float> seaMonkeyBabyRandomizeMin;
        public static ConfigEntry<float> seaMonkeyBabyRandomizeMax;
        public static ConfigEntry<float> seaMonkeyBabyBaseHealth;
        public static ConfigEntry<float> seaMonkeyBabyBaseMaxAcceleration;
        public static ConfigEntry<float> seaMonkeyBabyBaseForwardRotationSpeed;
        public static ConfigEntry<float> seaMonkeyBabyBaseUpRotationSpeed;
        public static ConfigEntry<float> seaMonkeyBabyBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> seaMonkeyExclude;
        public static ConfigEntry<float> seaMonkeyScale;
        public static ConfigEntry<float> seaMonkeySlowness;
        public static ConfigEntry<float> seaMonkeyHealth;
        public static ConfigEntry<float> seaMonkeyLimit;
        public static ConfigEntry<bool> seaMonkeyRandomize;
        public static ConfigEntry<float> seaMonkeyRandomizeMin;
        public static ConfigEntry<float> seaMonkeyRandomizeMax;
        public static ConfigEntry<float> seaMonkeyBaseHealth;
        public static ConfigEntry<float> seaMonkeyBaseMaxAcceleration;
        public static ConfigEntry<float> seaMonkeyBaseForwardRotationSpeed;
        public static ConfigEntry<float> seaMonkeyBaseUpRotationSpeed;
        public static ConfigEntry<float> seaMonkeyBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> snowStalkerBabyExclude;
        public static ConfigEntry<float> snowStalkerBabyScale;
        public static ConfigEntry<float> snowStalkerBabySlowness;
        public static ConfigEntry<float> snowStalkerBabyHealth;
        public static ConfigEntry<float> snowStalkerBabyLimit;
        public static ConfigEntry<bool> snowStalkerBabyRandomize;
        public static ConfigEntry<float> snowStalkerBabyRandomizeMin;
        public static ConfigEntry<float> snowStalkerBabyRandomizeMax;
        public static ConfigEntry<float> snowStalkerBabyBaseHealth;
        public static ConfigEntry<float> snowStalkerBabyBaseMaxAcceleration;
        public static ConfigEntry<float> snowStalkerBabyBaseForwardRotationSpeed;
        public static ConfigEntry<float> snowStalkerBabyBaseUpRotationSpeed;
        public static ConfigEntry<float> snowStalkerBabyBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> snowStalkerExclude;
        public static ConfigEntry<float> snowStalkerScale;
        public static ConfigEntry<float> snowStalkerSlowness;
        public static ConfigEntry<float> snowStalkerHealth;
        public static ConfigEntry<float> snowStalkerLimit;
        public static ConfigEntry<bool> snowStalkerRandomize;
        public static ConfigEntry<float> snowStalkerRandomizeMin;
        public static ConfigEntry<float> snowStalkerRandomizeMax;
        public static ConfigEntry<float> snowStalkerBaseHealth;
        public static ConfigEntry<float> snowStalkerBaseMaxAcceleration;
        public static ConfigEntry<float> snowStalkerBaseForwardRotationSpeed;
        public static ConfigEntry<float> snowStalkerBaseUpRotationSpeed;
        public static ConfigEntry<float> snowStalkerBaseTraitsAnimatorSpeed;

        public static ConfigEntry<bool> rockPuncherExclude;
        public static ConfigEntry<float> rockPuncherScale;
        public static ConfigEntry<float> rockPuncherSlowness;
        public static ConfigEntry<float> rockPuncherHealth;
        public static ConfigEntry<float> rockPuncherLimit;
        public static ConfigEntry<bool> rockPuncherRandomize;
        public static ConfigEntry<float> rockPuncherRandomizeMin;
        public static ConfigEntry<float> rockPuncherRandomizeMax;
        public static ConfigEntry<float> rockPuncherBaseHealth;
        public static ConfigEntry<float> rockPuncherBaseMaxAcceleration;
        public static ConfigEntry<float> rockPuncherBaseForwardRotationSpeed;
        public static ConfigEntry<float> rockPuncherBaseUpRotationSpeed;
        public static ConfigEntry<float> rockPuncherBaseTraitsAnimatorSpeed;

        public static ConfigEntry<float> smallVentGardenScale;
        public static ConfigEntry<float> largeVentGardenScale;
        public static ConfigEntry<bool> ventgardenRandomize;
        public static ConfigEntry<float> ventgardenRandomizeMin;
        public static ConfigEntry<float> ventgardenRandomizeMax;

        List<OptionItem> miscOptions = new List<OptionItem>();
        List<OptionItem> proportionalOptions = new List<OptionItem>();
        List<OptionItem> arcticPeeperOptions = new List<OptionItem>();
        List<OptionItem> arrowRayOptions = new List<OptionItem>();
        List<OptionItem> boomerangOptions = new List<OptionItem>();
        List<OptionItem> bladderFishOptions = new List<OptionItem>();
        List<OptionItem> hoopFishOptions = new List<OptionItem>();
        List<OptionItem> discusFishOptions = new List<OptionItem>();
        List<OptionItem> featherFishOptions = new List<OptionItem>();
        List<OptionItem> nootFishOptions = new List<OptionItem>();
        List<OptionItem> spinnerFishOptions = new List<OptionItem>();
        List<OptionItem> arcticRayOptions = new List<OptionItem>();
        List<OptionItem> jellyFishOptions = new List<OptionItem>();
        List<OptionItem> titanHoleFishOptions = new List<OptionItem>();
        List<OptionItem> glowWhaleOptions = new List<OptionItem>();
        List<OptionItem> pinnacaridOptions = new List<OptionItem>();
        List<OptionItem> triopsOptions = new List<OptionItem>();
        List<OptionItem> trivalveOptions = new List<OptionItem>();
        List<OptionItem> symbioteFishOptions = new List<OptionItem>();
        List<OptionItem> rockGrubOptions = new List<OptionItem>();
        List<OptionItem> crashFishOptions = new List<OptionItem>();
        List<OptionItem> brineWingOptions = new List<OptionItem>();
        List<OptionItem> lilyPaddlerOptions = new List<OptionItem>();
        List<OptionItem> cryptosuchusOptions = new List<OptionItem>();
        List<OptionItem> bruteSharkOptions = new List<OptionItem>();
        List<OptionItem> squidSharkOptions = new List<OptionItem>();
        List<OptionItem> chelicerateOptions = new List<OptionItem>();
        List<OptionItem> shadowLeviathanOptions = new List<OptionItem>();
        List<OptionItem> voidLeviathanOptions = new List<OptionItem>();
        List<OptionItem> skyRayOptions = new List<OptionItem>();
        List<OptionItem> penglingOptions = new List<OptionItem>();
        List<OptionItem> pengwingOptions = new List<OptionItem>();
        List<OptionItem> seaMonkeyBabyOptions = new List<OptionItem>();
        List<OptionItem> seaMonkeyOptions = new List<OptionItem>();
        List<OptionItem> snowStalkerBabyOptions = new List<OptionItem>();
        List<OptionItem> snowStalkerOptions = new List<OptionItem>();
        List<OptionItem> rockPuncherOptions = new List<OptionItem>();
        List<OptionItem> ventgardenOptions = new List<OptionItem>();
        #endregion

        public MyModOptions() : base("Bigger Fish")
        {
            ModToggleOption removeFishSchoolsOption = removeFishSchools.ToModToggleOption();
            removeFishSchoolsOption.OnChanged += ToggleOptionsChanged;
            AddItem(removeFishSchoolsOption);

            ModToggleOption proportionalOption = proportionalToggle.ToModToggleOption();
            proportionalOption.OnChanged += ToggleOptionsChanged;
            AddItem(proportionalOption);

            ModSliderOption proportionalScaleOption = proportionalScale.ToModSliderOption(1, 50);
            proportionalScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalScaleOption);

            ModSliderOption proportionalSlownessOption = proportionalSlowness.ToModSliderOption(1, 100);
            proportionalSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalSlownessOption);

            ModSliderOption proportionalHealthOption = proportionalHealth.ToModSliderOption(1, 100);
            proportionalHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalHealthOption);

            ModSliderOption proportionalCreatureLimitOption = proportionalCreatureLimit.ToModSliderOption(0, 50);
            proportionalCreatureLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalCreatureLimitOption);

            ModToggleOption proportionalRandomizeOption = proportionalRandomize.ToModToggleOption();
            proportionalRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(proportionalRandomizeOption);

            ModSliderOption proportionalRandomizeMinOption = proportionalRandomizeMin.ToModSliderOption(1, 50);
            proportionalRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalRandomizeMinOption);

            ModSliderOption proportionalRandomizeMaxOption = proportionalRandomizeMax.ToModSliderOption(1, 50);
            proportionalRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(proportionalRandomizeMaxOption);



            ModToggleOption peeperExcludeOption = arcticPeeperExclude.ToModToggleOption();
            peeperExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(peeperExcludeOption);

            ModSliderOption peeperScaleOption = arcticPeeperScale.ToModSliderOption(1, 50);
            peeperScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperScaleOption);

            ModSliderOption peeperSlownessOption = arcticPeeperSlowness.ToModSliderOption(1, 100);
            peeperSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperSlownessOption);

            ModSliderOption peeperHealthOption = arcticPeeperHealth.ToModSliderOption(1, 100);
            peeperHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperHealthOption);

            ModSliderOption peeperLimitOption = arcticPeeperLimit.ToModSliderOption(0, 50);
            peeperLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperLimitOption);

            ModToggleOption peeperRandomizeOption = arcticPeeperRandomize.ToModToggleOption();
            peeperRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(peeperRandomizeOption);

            ModSliderOption peeperRandomizeMinOption = arcticPeeperRandomizeMin.ToModSliderOption(1, 50);
            peeperRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperRandomizeMinOption);

            ModSliderOption peeperRandomizeMaxOption = arcticPeeperRandomizeMax.ToModSliderOption(1, 50);
            peeperRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(peeperRandomizeMaxOption);





            ModToggleOption arcticRayExcludeOption = arcticRayExclude.ToModToggleOption();
            arcticRayExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(arcticRayExcludeOption);

            ModSliderOption arcticRayScaleOption = arcticRayScale.ToModSliderOption(1, 50);
            arcticRayScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(arcticRayScaleOption);

            ModSliderOption arcticRaySlownessOption = arcticRaySlowness.ToModSliderOption(1, 100);
            arcticRaySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(arcticRaySlownessOption);

            ModSliderOption arcticRayHealthOption = arcticRayHealth.ToModSliderOption(1, 100);
            arcticRayHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(arcticRayHealthOption);

            ModSliderOption arcticRayLimitOption = arcticRayLimit.ToModSliderOption(0, 50);
            arcticRayLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(arcticRayLimitOption);

            ModToggleOption arcticRayRandomizeOption = arcticRayRandomize.ToModToggleOption();
            arcticRayRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(arcticRayRandomizeOption);

            ModSliderOption arcticRayRandomizeMinOption = arcticRayRandomizeMin.ToModSliderOption(1, 50);
            arcticRayRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(arcticRayRandomizeMinOption);

            ModSliderOption arcticRayRandomizeMaxOption = arcticRayRandomizeMax.ToModSliderOption(1, 50);
            arcticRayRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(arcticRayRandomizeMaxOption);





            ModToggleOption arrowRayExcludeOption = arrowRayExclude.ToModToggleOption();
            arrowRayExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(arrowRayExcludeOption);

            ModSliderOption arrowRayScaleOption = arrowRayScale.ToModSliderOption(1, 50);
            arrowRayScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(arrowRayScaleOption);

            ModSliderOption arrowRaySlownessOption = arrowRaySlowness.ToModSliderOption(1, 100);
            arrowRaySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(arrowRaySlownessOption);

            ModSliderOption arrowRayHealthOption = arrowRayHealth.ToModSliderOption(1, 100);
            arrowRayHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(arrowRayHealthOption);

            ModSliderOption arrowRayLimitOption = arrowRayLimit.ToModSliderOption(0, 50);
            arrowRayLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(arrowRayLimitOption);

            ModToggleOption arrowRayRandomizeOption = arrowRayRandomize.ToModToggleOption();
            arrowRayRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(arrowRayRandomizeOption);

            ModSliderOption arrowRayRandomizeMinOption = arrowRayRandomizeMin.ToModSliderOption(1, 50);
            arrowRayRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(arrowRayRandomizeMinOption);

            ModSliderOption arrowRayRandomizeMaxOption = arrowRayRandomizeMax.ToModSliderOption(1, 50);
            arrowRayRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(arrowRayRandomizeMaxOption);





            ModToggleOption bladderFishExcludeOption = bladderFishExclude.ToModToggleOption();
            bladderFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(bladderFishExcludeOption);

            ModSliderOption bladderFishScaleOption = bladderFishScale.ToModSliderOption(1, 50);
            bladderFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishScaleOption);

            ModSliderOption bladderFishSlownessOption = bladderFishSlowness.ToModSliderOption(1, 100);
            bladderFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishSlownessOption);

            ModSliderOption bladderFishHealthOption = bladderFishHealth.ToModSliderOption(1, 100);
            bladderFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishHealthOption);

            ModSliderOption bladderFishLimitOption = bladderFishLimit.ToModSliderOption(0, 50);
            bladderFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishLimitOption);

            ModToggleOption bladderFishRandomizeOption = bladderFishRandomize.ToModToggleOption();
            bladderFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(bladderFishRandomizeOption);

            ModSliderOption bladderFishRandomizeMinOption = bladderFishRandomizeMin.ToModSliderOption(1, 50);
            bladderFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishRandomizeMinOption);

            ModSliderOption bladderFishRandomizeMaxOption = bladderFishRandomizeMax.ToModSliderOption(1, 50);
            bladderFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(bladderFishRandomizeMaxOption);





            ModToggleOption boomerangExcludeOption = boomerangExclude.ToModToggleOption();
            boomerangExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(boomerangExcludeOption);

            ModSliderOption boomerangScaleOption = boomerangScale.ToModSliderOption(1, 50);
            boomerangScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangScaleOption);

            ModSliderOption boomerangSlownessOption = boomerangSlowness.ToModSliderOption(1, 100);
            boomerangSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangSlownessOption);

            ModSliderOption boomerangHealthOption = boomerangHealth.ToModSliderOption(1, 100);
            boomerangHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangHealthOption);

            ModSliderOption boomerangLimitOption = boomerangLimit.ToModSliderOption(0, 50);
            boomerangLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangLimitOption);

            ModToggleOption boomerangRandomizeOption = boomerangRandomize.ToModToggleOption();
            boomerangRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(boomerangRandomizeOption);

            ModSliderOption boomerangRandomizeMinOption = boomerangRandomizeMin.ToModSliderOption(1, 50);
            boomerangRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangRandomizeMinOption);

            ModSliderOption boomerangRandomizeMaxOption = boomerangRandomizeMax.ToModSliderOption(1, 50);
            boomerangRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(boomerangRandomizeMaxOption);





            ModToggleOption brineWingExcludeOption = brineWingExclude.ToModToggleOption();
            brineWingExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(brineWingExcludeOption);

            ModSliderOption brineWingScaleOption = brineWingScale.ToModSliderOption(1, 50);
            brineWingScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(brineWingScaleOption);

            ModSliderOption brineWingSlownessOption = brineWingSlowness.ToModSliderOption(1, 100);
            brineWingSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(brineWingSlownessOption);

            ModSliderOption brineWingHealthOption = brineWingHealth.ToModSliderOption(1, 100);
            brineWingHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(brineWingHealthOption);

            ModSliderOption brineWingLimitOption = brineWingLimit.ToModSliderOption(0, 50);
            brineWingLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(brineWingLimitOption);

            ModToggleOption brineWingRandomizeOption = brineWingRandomize.ToModToggleOption();
            brineWingRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(brineWingRandomizeOption);

            ModSliderOption brineWingRandomizeMinOption = brineWingRandomizeMin.ToModSliderOption(1, 50);
            brineWingRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(brineWingRandomizeMinOption);

            ModSliderOption brineWingRandomizeMaxOption = brineWingRandomizeMax.ToModSliderOption(1, 50);
            brineWingRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(brineWingRandomizeMaxOption);





            ModToggleOption bruteSharkExcludeOption = bruteSharkExclude.ToModToggleOption();
            bruteSharkExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(bruteSharkExcludeOption);

            ModSliderOption bruteSharkScaleOption = bruteSharkScale.ToModSliderOption(1, 50);
            bruteSharkScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(bruteSharkScaleOption);

            ModSliderOption bruteSharkSlownessOption = bruteSharkSlowness.ToModSliderOption(1, 100);
            bruteSharkSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(bruteSharkSlownessOption);

            ModSliderOption bruteSharkHealthOption = bruteSharkHealth.ToModSliderOption(1, 100);
            bruteSharkHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(bruteSharkHealthOption);

            ModSliderOption bruteSharkLimitOption = bruteSharkLimit.ToModSliderOption(0, 50);
            bruteSharkLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(bruteSharkLimitOption);

            ModToggleOption bruteSharkRandomizeOption = bruteSharkRandomize.ToModToggleOption();
            bruteSharkRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(bruteSharkRandomizeOption);

            ModSliderOption bruteSharkRandomizeMinOption = bruteSharkRandomizeMin.ToModSliderOption(1, 50);
            bruteSharkRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(bruteSharkRandomizeMinOption);

            ModSliderOption bruteSharkRandomizeMaxOption = bruteSharkRandomizeMax.ToModSliderOption(1, 50);
            bruteSharkRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(bruteSharkRandomizeMaxOption);





            ModToggleOption chelicerateExcludeOption = chelicerateExclude.ToModToggleOption();
            chelicerateExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(chelicerateExcludeOption);

            ModSliderOption chelicerateScaleOption = chelicerateScale.ToModSliderOption(1, 50);
            chelicerateScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(chelicerateScaleOption);

            ModSliderOption chelicerateSlownessOption = chelicerateSlowness.ToModSliderOption(1, 100);
            chelicerateSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(chelicerateSlownessOption);

            ModSliderOption chelicerateHealthOption = chelicerateHealth.ToModSliderOption(1, 100);
            chelicerateHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(chelicerateHealthOption);

            ModSliderOption chelicerateLimitOption = chelicerateLimit.ToModSliderOption(0, 50);
            chelicerateLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(chelicerateLimitOption);

            ModToggleOption chelicerateRandomizeOption = chelicerateRandomize.ToModToggleOption();
            chelicerateRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(chelicerateRandomizeOption);

            ModSliderOption chelicerateRandomizeMinOption = chelicerateRandomizeMin.ToModSliderOption(1, 50);
            chelicerateRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(chelicerateRandomizeMinOption);

            ModSliderOption chelicerateRandomizeMaxOption = chelicerateRandomizeMax.ToModSliderOption(1, 50);
            chelicerateRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(chelicerateRandomizeMaxOption);





            ModToggleOption crashFishExcludeOption = crashFishExclude.ToModToggleOption();
            crashFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(crashFishExcludeOption);

            ModSliderOption crashFishScaleOption = crashFishScale.ToModSliderOption(1, 50);
            crashFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishScaleOption);

            ModSliderOption crashFishSlownessOption = crashFishSlowness.ToModSliderOption(1, 100);
            crashFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishSlownessOption);

            ModSliderOption crashFishHealthOption = crashFishHealth.ToModSliderOption(1, 100);
            crashFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishHealthOption);

            ModSliderOption crashFishLimitOption = crashFishLimit.ToModSliderOption(0, 50);
            crashFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishLimitOption);

            ModToggleOption crashFishRandomizeOption = crashFishRandomize.ToModToggleOption();
            crashFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(crashFishRandomizeOption);

            ModSliderOption crashFishRandomizeMinOption = crashFishRandomizeMin.ToModSliderOption(1, 50);
            crashFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishRandomizeMinOption);

            ModSliderOption crashFishRandomizeMaxOption = crashFishRandomizeMax.ToModSliderOption(1, 50);
            crashFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(crashFishRandomizeMaxOption);





            ModToggleOption cryptosuchusExcludeOption = cryptosuchusExclude.ToModToggleOption();
            cryptosuchusExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(cryptosuchusExcludeOption);

            ModSliderOption cryptosuchusScaleOption = cryptosuchusScale.ToModSliderOption(1, 50);
            cryptosuchusScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(cryptosuchusScaleOption);

            ModSliderOption cryptosuchusSlownessOption = cryptosuchusSlowness.ToModSliderOption(1, 100);
            cryptosuchusSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(cryptosuchusSlownessOption);

            ModSliderOption cryptosuchusHealthOption = cryptosuchusHealth.ToModSliderOption(1, 100);
            cryptosuchusHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(cryptosuchusHealthOption);

            ModSliderOption cryptosuchusLimitOption = cryptosuchusLimit.ToModSliderOption(0, 50);
            cryptosuchusLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(cryptosuchusLimitOption);

            ModToggleOption cryptosuchusRandomizeOption = cryptosuchusRandomize.ToModToggleOption();
            cryptosuchusRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(cryptosuchusRandomizeOption);

            ModSliderOption cryptosuchusRandomizeMinOption = cryptosuchusRandomizeMin.ToModSliderOption(1, 50);
            cryptosuchusRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(cryptosuchusRandomizeMinOption);

            ModSliderOption cryptosuchusRandomizeMaxOption = cryptosuchusRandomizeMax.ToModSliderOption(1, 50);
            cryptosuchusRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(cryptosuchusRandomizeMaxOption);





            ModToggleOption discusFishExcludeOption = discusFishExclude.ToModToggleOption();
            discusFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(discusFishExcludeOption);

            ModSliderOption discusFishScaleOption = discusFishScale.ToModSliderOption(1, 50);
            discusFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(discusFishScaleOption);

            ModSliderOption discusFishSlownessOption = discusFishSlowness.ToModSliderOption(1, 100);
            discusFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(discusFishSlownessOption);

            ModSliderOption discusFishHealthOption = discusFishHealth.ToModSliderOption(1, 100);
            discusFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(discusFishHealthOption);

            ModSliderOption discusFishLimitOption = discusFishLimit.ToModSliderOption(0, 50);
            discusFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(discusFishLimitOption);

            ModToggleOption discusFishRandomizeOption = discusFishRandomize.ToModToggleOption();
            discusFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(discusFishRandomizeOption);

            ModSliderOption discusFishRandomizeMinOption = discusFishRandomizeMin.ToModSliderOption(1, 50);
            discusFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(discusFishRandomizeMinOption);

            ModSliderOption discusFishRandomizeMaxOption = discusFishRandomizeMax.ToModSliderOption(1, 50);
            discusFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(discusFishRandomizeMaxOption);





            ModToggleOption jellyFishExcludeOption = jellyFishExclude.ToModToggleOption();
            jellyFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(jellyFishExcludeOption);

            ModSliderOption jellyFishScaleOption = jellyFishScale.ToModSliderOption(1, 50);
            jellyFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyFishScaleOption);

            ModSliderOption jellyFishSlownessOption = jellyFishSlowness.ToModSliderOption(1, 100);
            jellyFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyFishSlownessOption);

            ModSliderOption jellyFishHealthOption = jellyFishHealth.ToModSliderOption(1, 100);
            jellyFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyFishHealthOption);

            ModSliderOption jellyFishLimitOption = jellyFishLimit.ToModSliderOption(0, 50);
            jellyFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyFishLimitOption);

            ModToggleOption jellyFishRandomizeOption = jellyFishRandomize.ToModToggleOption();
            jellyFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(jellyFishRandomizeOption);

            ModSliderOption jellyFishRandomizeMinOption = jellyFishRandomizeMin.ToModSliderOption(1, 50);
            jellyFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyFishRandomizeMinOption);

            ModSliderOption jellyFishRandomizeMaxOption = jellyFishRandomizeMax.ToModSliderOption(1, 50);
            jellyFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(jellyFishRandomizeMaxOption);





            ModToggleOption featherFishExcludeOption = featherFishExclude.ToModToggleOption();
            featherFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(featherFishExcludeOption);

            ModSliderOption featherFishScaleOption = featherFishScale.ToModSliderOption(1, 50);
            featherFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(featherFishScaleOption);

            ModSliderOption featherFishSlownessOption = featherFishSlowness.ToModSliderOption(1, 100);
            featherFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(featherFishSlownessOption);

            ModSliderOption featherFishHealthOption = featherFishHealth.ToModSliderOption(1, 100);
            featherFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(featherFishHealthOption);

            ModSliderOption featherFishLimitOption = featherFishLimit.ToModSliderOption(0, 50);
            featherFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(featherFishLimitOption);

            ModToggleOption featherFishRandomizeOption = featherFishRandomize.ToModToggleOption();
            featherFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(featherFishRandomizeOption);

            ModSliderOption featherFishRandomizeMinOption = featherFishRandomizeMin.ToModSliderOption(1, 50);
            featherFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(featherFishRandomizeMinOption);

            ModSliderOption featherFishRandomizeMaxOption = featherFishRandomizeMax.ToModSliderOption(1, 50);
            featherFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(featherFishRandomizeMaxOption);





            ModToggleOption glowWhaleExcludeOption = glowWhaleExclude.ToModToggleOption();
            glowWhaleExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(glowWhaleExcludeOption);

            ModSliderOption glowWhaleScaleOption = glowWhaleScale.ToModSliderOption(1, 50);
            glowWhaleScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(glowWhaleScaleOption);

            ModSliderOption glowWhaleSlownessOption = glowWhaleSlowness.ToModSliderOption(1, 100);
            glowWhaleSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(glowWhaleSlownessOption);

            ModSliderOption glowWhaleHealthOption = glowWhaleHealth.ToModSliderOption(1, 100);
            glowWhaleHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(glowWhaleHealthOption);

            ModSliderOption glowWhaleLimitOption = glowWhaleLimit.ToModSliderOption(0, 50);
            glowWhaleLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(glowWhaleLimitOption);

            ModToggleOption glowWhaleRandomizeOption = glowWhaleRandomize.ToModToggleOption();
            glowWhaleRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(glowWhaleRandomizeOption);

            ModSliderOption glowWhaleRandomizeMinOption = glowWhaleRandomizeMin.ToModSliderOption(1, 50);
            glowWhaleRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(glowWhaleRandomizeMinOption);

            ModSliderOption glowWhaleRandomizeMaxOption = glowWhaleRandomizeMax.ToModSliderOption(1, 50);
            glowWhaleRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(glowWhaleRandomizeMaxOption);





            ModToggleOption hoopFishExcludeOption = hoopFishExclude.ToModToggleOption();
            hoopFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(hoopFishExcludeOption);

            ModSliderOption hoopFishScaleOption = hoopFishScale.ToModSliderOption(1, 50);
            hoopFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishScaleOption);

            ModSliderOption hoopFishSlownessOption = hoopFishSlowness.ToModSliderOption(1, 100);
            hoopFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishSlownessOption);

            ModSliderOption hoopFishHealthOption = hoopFishHealth.ToModSliderOption(1, 100);
            hoopFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishHealthOption);

            ModSliderOption hoopFishLimitOption = hoopFishLimit.ToModSliderOption(0, 50);
            hoopFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishLimitOption);

            ModToggleOption hoopFishRandomizeOption = hoopFishRandomize.ToModToggleOption();
            hoopFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(hoopFishRandomizeOption);

            ModSliderOption hoopFishRandomizeMinOption = hoopFishRandomizeMin.ToModSliderOption(1, 50);
            hoopFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishRandomizeMinOption);

            ModSliderOption hoopFishRandomizeMaxOption = hoopFishRandomizeMax.ToModSliderOption(1, 50);
            hoopFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(hoopFishRandomizeMaxOption);





            ModToggleOption lilyPaddlerExcludeOption = lilyPaddlerExclude.ToModToggleOption();
            lilyPaddlerExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(lilyPaddlerExcludeOption);

            ModSliderOption lilyPaddlerScaleOption = lilyPaddlerScale.ToModSliderOption(1, 50);
            lilyPaddlerScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(lilyPaddlerScaleOption);

            ModSliderOption lilyPaddlerSlownessOption = lilyPaddlerSlowness.ToModSliderOption(1, 100);
            lilyPaddlerSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(lilyPaddlerSlownessOption);

            ModSliderOption lilyPaddlerHealthOption = lilyPaddlerHealth.ToModSliderOption(1, 100);
            lilyPaddlerHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(lilyPaddlerHealthOption);

            ModSliderOption lilyPaddlerLimitOption = lilyPaddlerLimit.ToModSliderOption(0, 50);
            lilyPaddlerLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(lilyPaddlerLimitOption);

            ModToggleOption lilyPaddlerRandomizeOption = lilyPaddlerRandomize.ToModToggleOption();
            lilyPaddlerRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(lilyPaddlerRandomizeOption);

            ModSliderOption lilyPaddlerRandomizeMinOption = lilyPaddlerRandomizeMin.ToModSliderOption(1, 50);
            lilyPaddlerRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(lilyPaddlerRandomizeMinOption);

            ModSliderOption lilyPaddlerRandomizeMaxOption = lilyPaddlerRandomizeMax.ToModSliderOption(1, 50);
            lilyPaddlerRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(lilyPaddlerRandomizeMaxOption);





            ModToggleOption nootFishExcludeOption = nootFishExclude.ToModToggleOption();
            nootFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(nootFishExcludeOption);

            ModSliderOption nootFishScaleOption = nootFishScale.ToModSliderOption(1, 50);
            nootFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(nootFishScaleOption);

            ModSliderOption nootFishSlownessOption = nootFishSlowness.ToModSliderOption(1, 100);
            nootFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(nootFishSlownessOption);

            ModSliderOption nootFishHealthOption = nootFishHealth.ToModSliderOption(1, 100);
            nootFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(nootFishHealthOption);

            ModSliderOption nootFishLimitOption = nootFishLimit.ToModSliderOption(0, 50);
            nootFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(nootFishLimitOption);

            ModToggleOption nootFishRandomizeOption = nootFishRandomize.ToModToggleOption();
            nootFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(nootFishRandomizeOption);

            ModSliderOption nootFishRandomizeMinOption = nootFishRandomizeMin.ToModSliderOption(1, 50);
            nootFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(nootFishRandomizeMinOption);

            ModSliderOption nootFishRandomizeMaxOption = nootFishRandomizeMax.ToModSliderOption(1, 50);
            nootFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(nootFishRandomizeMaxOption);





            ModToggleOption penglingExcludeOption = penglingExclude.ToModToggleOption();
            penglingExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(penglingExcludeOption);

            ModSliderOption penglingScaleOption = penglingScale.ToModSliderOption(1, 50);
            penglingScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(penglingScaleOption);

            ModSliderOption penglingSlownessOption = penglingSlowness.ToModSliderOption(1, 100);
            penglingSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(penglingSlownessOption);

            ModSliderOption penglingHealthOption = penglingHealth.ToModSliderOption(1, 100);
            penglingHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(penglingHealthOption);

            ModSliderOption penglingLimitOption = penglingLimit.ToModSliderOption(0, 50);
            penglingLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(penglingLimitOption);

            ModToggleOption penglingRandomizeOption = penglingRandomize.ToModToggleOption();
            penglingRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(penglingRandomizeOption);

            ModSliderOption penglingRandomizeMinOption = penglingRandomizeMin.ToModSliderOption(1, 50);
            penglingRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(penglingRandomizeMinOption);

            ModSliderOption penglingRandomizeMaxOption = penglingRandomizeMax.ToModSliderOption(1, 50);
            penglingRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(penglingRandomizeMaxOption);





            ModToggleOption pengwingExcludeOption = pengwingExclude.ToModToggleOption();
            pengwingExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(pengwingExcludeOption);

            ModSliderOption pengwingScaleOption = pengwingScale.ToModSliderOption(1, 50);
            pengwingScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(pengwingScaleOption);

            ModSliderOption pengwingSlownessOption = pengwingSlowness.ToModSliderOption(1, 100);
            pengwingSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(pengwingSlownessOption);

            ModSliderOption pengwingHealthOption = pengwingHealth.ToModSliderOption(1, 100);
            pengwingHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(pengwingHealthOption);

            ModSliderOption pengwingLimitOption = pengwingLimit.ToModSliderOption(0, 50);
            pengwingLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(pengwingLimitOption);

            ModToggleOption pengwingRandomizeOption = pengwingRandomize.ToModToggleOption();
            pengwingRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(pengwingRandomizeOption);

            ModSliderOption pengwingRandomizeMinOption = pengwingRandomizeMin.ToModSliderOption(1, 50);
            pengwingRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(pengwingRandomizeMinOption);

            ModSliderOption pengwingRandomizeMaxOption = pengwingRandomizeMax.ToModSliderOption(1, 50);
            pengwingRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(pengwingRandomizeMaxOption);





            ModToggleOption pinnacaridExcludeOption = pinnacaridExclude.ToModToggleOption();
            pinnacaridExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(pinnacaridExcludeOption);

            ModSliderOption pinnacaridScaleOption = pinnacaridScale.ToModSliderOption(1, 50);
            pinnacaridScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(pinnacaridScaleOption);

            ModSliderOption pinnacaridSlownessOption = pinnacaridSlowness.ToModSliderOption(1, 100);
            pinnacaridSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(pinnacaridSlownessOption);

            ModSliderOption pinnacaridHealthOption = pinnacaridHealth.ToModSliderOption(1, 100);
            pinnacaridHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(pinnacaridHealthOption);

            ModSliderOption pinnacaridLimitOption = pinnacaridLimit.ToModSliderOption(0, 50);
            pinnacaridLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(pinnacaridLimitOption);

            ModToggleOption pinnacaridRandomizeOption = pinnacaridRandomize.ToModToggleOption();
            pinnacaridRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(pinnacaridRandomizeOption);

            ModSliderOption pinnacaridRandomizeMinOption = pinnacaridRandomizeMin.ToModSliderOption(1, 50);
            pinnacaridRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(pinnacaridRandomizeMinOption);

            ModSliderOption pinnacaridRandomizeMaxOption = pinnacaridRandomizeMax.ToModSliderOption(1, 50);
            pinnacaridRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(pinnacaridRandomizeMaxOption);





            ModToggleOption rockGrubExcludeOption = rockGrubExclude.ToModToggleOption();
            rockGrubExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(rockGrubExcludeOption);

            ModSliderOption rockGrubScaleOption = rockGrubScale.ToModSliderOption(1, 50);
            rockGrubScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(rockGrubScaleOption);

            ModSliderOption rockGrubSlownessOption = rockGrubSlowness.ToModSliderOption(1, 100);
            rockGrubSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(rockGrubSlownessOption);

            ModSliderOption rockGrubHealthOption = rockGrubHealth.ToModSliderOption(1, 100);
            rockGrubHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(rockGrubHealthOption);

            ModSliderOption rockGrubLimitOption = rockGrubLimit.ToModSliderOption(0, 50);
            rockGrubLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(rockGrubLimitOption);

            ModToggleOption rockGrubRandomizeOption = rockGrubRandomize.ToModToggleOption();
            rockGrubRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(rockGrubRandomizeOption);

            ModSliderOption rockGrubRandomizeMinOption = rockGrubRandomizeMin.ToModSliderOption(1, 50);
            rockGrubRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(rockGrubRandomizeMinOption);

            ModSliderOption rockGrubRandomizeMaxOption = rockGrubRandomizeMax.ToModSliderOption(1, 50);
            rockGrubRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(rockGrubRandomizeMaxOption);





            ModToggleOption rockPuncherExcludeOption = rockPuncherExclude.ToModToggleOption();
            rockPuncherExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(rockPuncherExcludeOption);

            ModSliderOption rockPuncherScaleOption = rockPuncherScale.ToModSliderOption(1, 50);
            rockPuncherScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(rockPuncherScaleOption);

            ModSliderOption rockPuncherSlownessOption = rockPuncherSlowness.ToModSliderOption(1, 100);
            rockPuncherSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(rockPuncherSlownessOption);

            ModSliderOption rockPuncherHealthOption = rockPuncherHealth.ToModSliderOption(1, 100);
            rockPuncherHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(rockPuncherHealthOption);

            ModSliderOption rockPuncherLimitOption = rockPuncherLimit.ToModSliderOption(0, 50);
            rockPuncherLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(rockPuncherLimitOption);

            ModToggleOption rockPuncherRandomizeOption = rockPuncherRandomize.ToModToggleOption();
            rockPuncherRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(rockPuncherRandomizeOption);

            ModSliderOption rockPuncherRandomizeMinOption = rockPuncherRandomizeMin.ToModSliderOption(1, 50);
            rockPuncherRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(rockPuncherRandomizeMinOption);

            ModSliderOption rockPuncherRandomizeMaxOption = rockPuncherRandomizeMax.ToModSliderOption(1, 50);
            rockPuncherRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(rockPuncherRandomizeMaxOption);





            ModToggleOption seaMonkeyExcludeOption = seaMonkeyExclude.ToModToggleOption();
            seaMonkeyExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaMonkeyExcludeOption);

            ModSliderOption seaMonkeyScaleOption = seaMonkeyScale.ToModSliderOption(1, 50);
            seaMonkeyScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyScaleOption);

            ModSliderOption seaMonkeySlownessOption = seaMonkeySlowness.ToModSliderOption(1, 100);
            seaMonkeySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeySlownessOption);

            ModSliderOption seaMonkeyHealthOption = seaMonkeyHealth.ToModSliderOption(1, 100);
            seaMonkeyHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyHealthOption);

            ModSliderOption seaMonkeyLimitOption = seaMonkeyLimit.ToModSliderOption(0, 50);
            seaMonkeyLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyLimitOption);

            ModToggleOption seaMonkeyRandomizeOption = seaMonkeyRandomize.ToModToggleOption();
            seaMonkeyRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaMonkeyRandomizeOption);

            ModSliderOption seaMonkeyRandomizeMinOption = seaMonkeyRandomizeMin.ToModSliderOption(1, 50);
            seaMonkeyRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyRandomizeMinOption);

            ModSliderOption seaMonkeyRandomizeMaxOption = seaMonkeyRandomizeMax.ToModSliderOption(1, 50);
            seaMonkeyRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyRandomizeMaxOption);





            ModToggleOption seaMonkeyBabyExcludeOption = seaMonkeyBabyExclude.ToModToggleOption();
            seaMonkeyBabyExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaMonkeyBabyExcludeOption);

            ModSliderOption seaMonkeyBabyScaleOption = seaMonkeyBabyScale.ToModSliderOption(1, 50);
            seaMonkeyBabyScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyBabyScaleOption);

            ModSliderOption seaMonkeyBabySlownessOption = seaMonkeyBabySlowness.ToModSliderOption(1, 100);
            seaMonkeyBabySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyBabySlownessOption);

            ModSliderOption seaMonkeyBabyHealthOption = seaMonkeyBabyHealth.ToModSliderOption(1, 100);
            seaMonkeyBabyHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyBabyHealthOption);

            ModSliderOption seaMonkeyBabyLimitOption = seaMonkeyBabyLimit.ToModSliderOption(0, 50);
           seaMonkeyBabyLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyBabyLimitOption);

            ModToggleOption seaMonkeyBabyRandomizeOption = seaMonkeyBabyRandomize.ToModToggleOption();
            seaMonkeyBabyRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(seaMonkeyBabyRandomizeOption);

            ModSliderOption seaMonkeyBabyRandomizeMinOption = seaMonkeyBabyRandomizeMin.ToModSliderOption(1, 50);
            seaMonkeyBabyRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyBabyRandomizeMinOption);

            ModSliderOption seaMonkeyBabyRandomizeMaxOption = seaMonkeyBabyRandomizeMax.ToModSliderOption(1, 50);
            seaMonkeyBabyRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(seaMonkeyBabyRandomizeMaxOption);





            ModToggleOption shadowLeviathanExcludeOption = shadowLeviathanExclude.ToModToggleOption();
            shadowLeviathanExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(shadowLeviathanExcludeOption);

            ModSliderOption shadowLeviathanScaleOption = shadowLeviathanScale.ToModSliderOption(1, 50);
            shadowLeviathanScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(shadowLeviathanScaleOption);

            ModSliderOption shadowLeviathanSlownessOption = shadowLeviathanSlowness.ToModSliderOption(1, 100);
            shadowLeviathanSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(shadowLeviathanSlownessOption);

            ModSliderOption shadowLeviathanHealthOption = shadowLeviathanHealth.ToModSliderOption(1, 100);
            shadowLeviathanHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(shadowLeviathanHealthOption);

            ModSliderOption shadowLeviathanLimitOption = shadowLeviathanLimit.ToModSliderOption(0, 50);
            shadowLeviathanLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(shadowLeviathanLimitOption);

            ModToggleOption shadowLeviathanRandomizeOption = shadowLeviathanRandomize.ToModToggleOption();
            shadowLeviathanRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(shadowLeviathanRandomizeOption);

            ModSliderOption shadowLeviathanRandomizeMinOption = shadowLeviathanRandomizeMin.ToModSliderOption(1, 50);
            shadowLeviathanRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(shadowLeviathanRandomizeMinOption);

            ModSliderOption shadowLeviathanRandomizeMaxOption = shadowLeviathanRandomizeMax.ToModSliderOption(1, 50);
            shadowLeviathanRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(shadowLeviathanRandomizeMaxOption);





            ModToggleOption skyRayExcludeOption = skyRayExclude.ToModToggleOption();
            skyRayExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(skyRayExcludeOption);

            ModSliderOption skyRayScaleOption = skyRayScale.ToModSliderOption(1, 50);
            skyRayScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayScaleOption);

            ModSliderOption skyRaySlownessOption = skyRaySlowness.ToModSliderOption(1, 100);
            skyRaySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRaySlownessOption);

            ModSliderOption skyRayHealthOption = skyRayHealth.ToModSliderOption(1, 100);
            skyRayHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayHealthOption);

            ModSliderOption skyRayLimitOption = skyRayLimit.ToModSliderOption(0, 50);
            skyRayLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayLimitOption);

            ModToggleOption skyRayRandomizeOption = skyRayRandomize.ToModToggleOption();
            skyRayRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(skyRayRandomizeOption);

            ModSliderOption skyRayRandomizeMinOption = skyRayRandomizeMin.ToModSliderOption(1, 50);
            skyRayRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayRandomizeMinOption);

            ModSliderOption skyRayRandomizeMaxOption = skyRayRandomizeMax.ToModSliderOption(1, 50);
            skyRayRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(skyRayRandomizeMaxOption);





            ModToggleOption snowStalkerExcludeOption = snowStalkerExclude.ToModToggleOption();
            snowStalkerExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(snowStalkerExcludeOption);

            ModSliderOption snowStalkerScaleOption = snowStalkerScale.ToModSliderOption(1, 50);
            snowStalkerScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerScaleOption);

            ModSliderOption snowStalkerSlownessOption = snowStalkerSlowness.ToModSliderOption(1, 100);
            snowStalkerSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerSlownessOption);

            ModSliderOption snowStalkerHealthOption = snowStalkerHealth.ToModSliderOption(1, 100);
            snowStalkerHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerHealthOption);

            ModSliderOption snowStalkerLimitOption = snowStalkerLimit.ToModSliderOption(0, 50);
            snowStalkerLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerLimitOption);

            ModToggleOption snowStalkerRandomizeOption = snowStalkerRandomize.ToModToggleOption();
            snowStalkerRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(snowStalkerRandomizeOption);

            ModSliderOption snowStalkerRandomizeMinOption = snowStalkerRandomizeMin.ToModSliderOption(1, 50);
            snowStalkerRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerRandomizeMinOption);

            ModSliderOption snowStalkerRandomizeMaxOption = snowStalkerRandomizeMax.ToModSliderOption(1, 50);
            snowStalkerRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerRandomizeMaxOption);





            ModToggleOption snowStalkerBabyExcludeOption = snowStalkerBabyExclude.ToModToggleOption();
            snowStalkerBabyExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(snowStalkerBabyExcludeOption);

            ModSliderOption snowStalkerBabyScaleOption = snowStalkerBabyScale.ToModSliderOption(1, 50);
            snowStalkerBabyScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerBabyScaleOption);

            ModSliderOption snowStalkerBabySlownessOption = snowStalkerBabySlowness.ToModSliderOption(1, 100);
            snowStalkerBabySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerBabySlownessOption);

            ModSliderOption snowStalkerBabyHealthOption = snowStalkerBabyHealth.ToModSliderOption(1, 100);
            snowStalkerBabyHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerBabyHealthOption);

            ModSliderOption snowStalkerBabyLimitOption = snowStalkerBabyLimit.ToModSliderOption(0, 50);
            snowStalkerBabyLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerBabyLimitOption);

            ModToggleOption snowStalkerBabyRandomizeOption = snowStalkerBabyRandomize.ToModToggleOption();
            snowStalkerBabyRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(snowStalkerBabyRandomizeOption);

            ModSliderOption snowStalkerBabyRandomizeMinOption = snowStalkerBabyRandomizeMin.ToModSliderOption(1, 50);
            snowStalkerBabyRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerBabyRandomizeMinOption);

            ModSliderOption snowStalkerBabyRandomizeMaxOption = snowStalkerBabyRandomizeMax.ToModSliderOption(1, 50);
            snowStalkerBabyRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(snowStalkerBabyRandomizeMaxOption);





            ModToggleOption spinnerFishExcludeOption = spinnerFishExclude.ToModToggleOption();
            spinnerFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(spinnerFishExcludeOption);

            ModSliderOption spinnerFishScaleOption = spinnerFishScale.ToModSliderOption(1, 50);
            spinnerFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(spinnerFishScaleOption);

            ModSliderOption spinnerFishSlownessOption = spinnerFishSlowness.ToModSliderOption(1, 100);
            spinnerFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(spinnerFishSlownessOption);

            ModSliderOption spinnerFishHealthOption = spinnerFishHealth.ToModSliderOption(1, 100);
            spinnerFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(spinnerFishHealthOption);

            ModSliderOption spinnerFishLimitOption = spinnerFishLimit.ToModSliderOption(0, 50);
            spinnerFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(spinnerFishLimitOption);

            ModToggleOption spinnerFishRandomizeOption = spinnerFishRandomize.ToModToggleOption();
            spinnerFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(spinnerFishRandomizeOption);

            ModSliderOption spinnerFishRandomizeMinOption = spinnerFishRandomizeMin.ToModSliderOption(1, 50);
            spinnerFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(spinnerFishRandomizeMinOption);

            ModSliderOption spinnerFishRandomizeMaxOption = spinnerFishRandomizeMax.ToModSliderOption(1, 50);
            spinnerFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(spinnerFishRandomizeMaxOption);





            ModToggleOption squidSharkExcludeOption = squidSharkExclude.ToModToggleOption();
            squidSharkExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(squidSharkExcludeOption);

            ModSliderOption squidSharkScaleOption = squidSharkScale.ToModSliderOption(1, 50);
            squidSharkScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(squidSharkScaleOption);

            ModSliderOption squidSharkSlownessOption = squidSharkSlowness.ToModSliderOption(1, 100);
            squidSharkSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(squidSharkSlownessOption);

            ModSliderOption squidSharkHealthOption = squidSharkHealth.ToModSliderOption(1, 100);
            squidSharkHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(squidSharkHealthOption);

            ModSliderOption squidSharkLimitOption = squidSharkLimit.ToModSliderOption(0, 50);
            squidSharkLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(squidSharkLimitOption);

            ModToggleOption squidSharkRandomizeOption = squidSharkRandomize.ToModToggleOption();
            squidSharkRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(squidSharkRandomizeOption);

            ModSliderOption squidSharkRandomizeMinOption = squidSharkRandomizeMin.ToModSliderOption(1, 50);
            squidSharkRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(squidSharkRandomizeMinOption);

            ModSliderOption squidSharkRandomizeMaxOption = squidSharkRandomizeMax.ToModSliderOption(1, 50);
            squidSharkRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(squidSharkRandomizeMaxOption);





            ModToggleOption symbioteFishExcludeOption = symbioteFishExclude.ToModToggleOption();
            symbioteFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(symbioteFishExcludeOption);

            ModSliderOption symbioteFishScaleOption = symbioteFishScale.ToModSliderOption(1, 50);
            symbioteFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(symbioteFishScaleOption);

            ModSliderOption symbioteFishSlownessOption = symbioteFishSlowness.ToModSliderOption(1, 100);
            symbioteFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(symbioteFishSlownessOption);

            ModSliderOption symbioteFishHealthOption = symbioteFishHealth.ToModSliderOption(1, 100);
            symbioteFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(symbioteFishHealthOption);

            ModSliderOption symbioteFishLimitOption = symbioteFishLimit.ToModSliderOption(0, 50);
            symbioteFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(symbioteFishLimitOption);

            ModToggleOption symbioteFishRandomizeOption = symbioteFishRandomize.ToModToggleOption();
            symbioteFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(symbioteFishRandomizeOption);

            ModSliderOption symbioteFishRandomizeMinOption = symbioteFishRandomizeMin.ToModSliderOption(1, 50);
            symbioteFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(symbioteFishRandomizeMinOption);

            ModSliderOption symbioteFishRandomizeMaxOption = symbioteFishRandomizeMax.ToModSliderOption(1, 50);
            symbioteFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(symbioteFishRandomizeMaxOption);





            ModToggleOption titanHoleFishExcludeOption = titanHoleFishExclude.ToModToggleOption();
            titanHoleFishExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(titanHoleFishExcludeOption);

            ModSliderOption titanHoleFishScaleOption = titanHoleFishScale.ToModSliderOption(1, 50);
            titanHoleFishScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(titanHoleFishScaleOption);

            ModSliderOption titanHoleFishSlownessOption = titanHoleFishSlowness.ToModSliderOption(1, 100);
            titanHoleFishSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(titanHoleFishSlownessOption);

            ModSliderOption titanHoleFishHealthOption = titanHoleFishHealth.ToModSliderOption(1, 100);
            titanHoleFishHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(titanHoleFishHealthOption);

            ModSliderOption titanHoleFishLimitOption = titanHoleFishLimit.ToModSliderOption(0, 50);
            titanHoleFishLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(titanHoleFishLimitOption);

            ModToggleOption titanHoleFishRandomizeOption = titanHoleFishRandomize.ToModToggleOption();
            titanHoleFishRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(titanHoleFishRandomizeOption);

            ModSliderOption titanHoleFishRandomizeMinOption = titanHoleFishRandomizeMin.ToModSliderOption(1, 50);
            titanHoleFishRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(titanHoleFishRandomizeMinOption);

            ModSliderOption titanHoleFishRandomizeMaxOption = titanHoleFishRandomizeMax.ToModSliderOption(1, 50);
            titanHoleFishRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(titanHoleFishRandomizeMaxOption);





            ModToggleOption triopsExcludeOption = triopsExclude.ToModToggleOption();
            triopsExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(triopsExcludeOption);

            ModSliderOption triopsScaleOption = triopsScale.ToModSliderOption(1, 50);
            triopsScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(triopsScaleOption);

            ModSliderOption triopsSlownessOption = triopsSlowness.ToModSliderOption(1, 100);
            triopsSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(triopsSlownessOption);

            ModSliderOption triopsHealthOption = triopsHealth.ToModSliderOption(1, 100);
            triopsHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(triopsHealthOption);

            ModSliderOption triopsLimitOption = triopsLimit.ToModSliderOption(0, 50);
            triopsLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(triopsLimitOption);

            ModToggleOption triopsRandomizeOption = triopsRandomize.ToModToggleOption();
            triopsRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(triopsRandomizeOption);

            ModSliderOption triopsRandomizeMinOption = triopsRandomizeMin.ToModSliderOption(1, 50);
            triopsRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(triopsRandomizeMinOption);

            ModSliderOption triopsRandomizeMaxOption = triopsRandomizeMax.ToModSliderOption(1, 50);
            triopsRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(triopsRandomizeMaxOption);





            ModToggleOption trivalveExcludeOption = trivalveExclude.ToModToggleOption();
            trivalveExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(trivalveExcludeOption);

            ModSliderOption trivalveScaleOption = trivalveScale.ToModSliderOption(1, 50);
            trivalveScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(trivalveScaleOption);

            ModSliderOption trivalveSlownessOption = trivalveSlowness.ToModSliderOption(1, 100);
            trivalveSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(trivalveSlownessOption);

            ModSliderOption trivalveHealthOption = trivalveHealth.ToModSliderOption(1, 100);
            trivalveHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(trivalveHealthOption);

            ModSliderOption trivalveLimitOption = trivalveLimit.ToModSliderOption(0, 50);
            trivalveLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(trivalveLimitOption);

            ModToggleOption trivalveRandomizeOption = trivalveRandomize.ToModToggleOption();
            trivalveRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(trivalveRandomizeOption);

            ModSliderOption trivalveRandomizeMinOption = trivalveRandomizeMin.ToModSliderOption(1, 50);
            trivalveRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(trivalveRandomizeMinOption);

            ModSliderOption trivalveRandomizeMaxOption = trivalveRandomizeMax.ToModSliderOption(1, 50);
            trivalveRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(trivalveRandomizeMaxOption);





            ModToggleOption voidLeviathanExcludeOption = voidLeviathanExclude.ToModToggleOption();
            voidLeviathanExcludeOption.OnChanged += ToggleOptionsChanged;
            AddItem(voidLeviathanExcludeOption);

            ModSliderOption voidLeviathanScaleOption = voidLeviathanScale.ToModSliderOption(1, 50);
            voidLeviathanScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(voidLeviathanScaleOption);

            ModSliderOption voidLeviathanSlownessOption = voidLeviathanSlowness.ToModSliderOption(1, 100);
            voidLeviathanSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(voidLeviathanSlownessOption);

            ModSliderOption voidLeviathanHealthOption = voidLeviathanHealth.ToModSliderOption(1, 100);
            voidLeviathanHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(voidLeviathanHealthOption);

            ModSliderOption voidLeviathanLimitOption = voidLeviathanLimit.ToModSliderOption(0, 50);
            voidLeviathanLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(voidLeviathanLimitOption);

            ModToggleOption voidLeviathanRandomizeOption = voidLeviathanRandomize.ToModToggleOption();
            voidLeviathanRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(voidLeviathanRandomizeOption);

            ModSliderOption voidLeviathanRandomizeMinOption = voidLeviathanRandomizeMin.ToModSliderOption(1, 50);
            voidLeviathanRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(voidLeviathanRandomizeMinOption);

            ModSliderOption voidLeviathanRandomizeMaxOption = voidLeviathanRandomizeMax.ToModSliderOption(1, 50);
            voidLeviathanRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(voidLeviathanRandomizeMaxOption);





            ModSliderOption smallVentGardenScaleOption = smallVentGardenScale.ToModSliderOption(1, 50);
            smallVentGardenScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(smallVentGardenScaleOption);

            ModSliderOption largeVentGardenScaleOption = largeVentGardenScale.ToModSliderOption(1, 50);
            largeVentGardenScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(largeVentGardenScaleOption);

            ModToggleOption ventGardenRandomizeOption = ventgardenRandomize.ToModToggleOption();
            ventGardenRandomizeOption.OnChanged += ToggleOptionsChanged;
            AddItem(ventGardenRandomizeOption);

            ModSliderOption ventGardenRandomizeMinOption = ventgardenRandomizeMin.ToModSliderOption(1, 50);
            ventGardenRandomizeMinOption.OnChanged += SliderOptionsChanged;
            AddItem(ventGardenRandomizeMinOption);

            ModSliderOption ventGardenRandomizeMaxOption = ventgardenRandomizeMax.ToModSliderOption(1, 50);
            ventGardenRandomizeMaxOption.OnChanged += SliderOptionsChanged;
            AddItem(ventGardenRandomizeMaxOption);





            OptionsPanelHandler.RegisterModOptions(this);
        }

        public override void BuildModOptions(uGUI_TabbedControlsPanel panel, int modsTabIndex, IReadOnlyCollection<OptionItem> options)
        {
            HashSet<OptionItem> optionItemsHash = options.ToHashSet<OptionItem>();

            int p = panel.AddTab("Bigger Fish");

            foreach (OptionItem option in optionItemsHash)
            {
                if (option.Id.Contains("Misc. Options") && !miscOptions.Contains(option))
                {
                    miscOptions.Add(option);
                }
                else if (option.Id.Contains("Proportional Values") && !proportionalOptions.Contains(option))
                {
                    proportionalOptions.Add(option);
                }
                else if (option.Id.Contains("Arctic Peeper Values") && !arcticPeeperOptions.Contains(option))
                {
                    arcticPeeperOptions.Add(option);
                }
                else if (option.Id.Contains("Arrow Ray Values") && !arrowRayOptions.Contains(option))
                {
                    arrowRayOptions.Add(option);
                }
                else if (option.Id.Contains("Boomerang Values") && !boomerangOptions.Contains(option))
                {
                    boomerangOptions.Add(option);
                }
                else if (option.Id.Contains("Bladderfish Values") && !bladderFishOptions.Contains(option))
                {
                    bladderFishOptions.Add(option);
                }
                else if (option.Id.Contains("Hoopfish Values") && !hoopFishOptions.Contains(option))
                {
                    hoopFishOptions.Add(option);
                }
                else if (option.Id.Contains("Discusfish Values") && !discusFishOptions.Contains(option))
                {
                    discusFishOptions.Add(option);
                }
                else if (option.Id.Contains("Featherfish Values") && !featherFishOptions.Contains(option))
                {
                    featherFishOptions.Add(option);
                }
                else if (option.Id.Contains("Nootfish Values") && !nootFishOptions.Contains(option))
                {
                    nootFishOptions.Add(option);
                }
                else if (option.Id.Contains("Spinnerfish Values") && !spinnerFishOptions.Contains(option))
                {
                    spinnerFishOptions.Add(option);
                }
                else if (option.Id.Contains("Arctic Ray Values") && !arcticRayOptions.Contains(option))
                {
                    arcticRayOptions.Add(option);
                }
                else if (option.Id.Contains("Eye Jelly Values") && !jellyFishOptions.Contains(option))
                {
                    jellyFishOptions.Add(option);
                }
                else if (option.Id.Contains("Titan Hole Fish Values") && !titanHoleFishOptions.Contains(option))
                {
                    titanHoleFishOptions.Add(option);
                }
                else if (option.Id.Contains("Glow Whale Values") && !glowWhaleOptions.Contains(option))
                {
                    glowWhaleOptions.Add(option);
                }
                else if (option.Id.Contains("Pinnacarid Values") && !pinnacaridOptions.Contains(option))
                {
                    pinnacaridOptions.Add(option);
                }
                else if (option.Id.Contains("Triops Values") && !triopsOptions.Contains(option))
                {
                    triopsOptions.Add(option);
                }
                else if (option.Id.Contains("Trivalve Values") && !trivalveOptions.Contains(option))
                {
                    trivalveOptions.Add(option);
                }
                else if (option.Id.Contains("Symbiotefish Values") && !symbioteFishOptions.Contains(option))
                {
                    symbioteFishOptions.Add(option);
                }
                else if (option.Id.Contains("Rock Grub Values") && !rockGrubOptions.Contains(option))
                {
                    rockGrubOptions.Add(option);
                }
                else if (option.Id.Contains("Crash Fish Values") && !crashFishOptions.Contains(option))
                {
                    crashFishOptions.Add(option);
                }
                else if (option.Id.Contains("Brinewing Values") && !brineWingOptions.Contains(option))
                {
                    brineWingOptions.Add(option);
                }
                else if (option.Id.Contains("Lily Paddler Values") && !lilyPaddlerOptions.Contains(option))
                {
                    lilyPaddlerOptions.Add(option);
                }
                else if (option.Id.Contains("Cryptosuchus Values") && !cryptosuchusOptions.Contains(option))
                {
                    cryptosuchusOptions.Add(option);
                }
                else if (option.Id.Contains("Brute Shark Values") && !bruteSharkOptions.Contains(option))
                {
                    bruteSharkOptions.Add(option);
                }
                else if (option.Id.Contains("Squid Shark Values") && !squidSharkOptions.Contains(option))
                {
                    squidSharkOptions.Add(option);
                }
                else if (option.Id.Contains("Chelicerate Values") && !chelicerateOptions.Contains(option))
                {
                    chelicerateOptions.Add(option);
                }
                else if (option.Id.Contains("Shadow Leviathan Values") && !shadowLeviathanOptions.Contains(option))
                {
                    shadowLeviathanOptions.Add(option);
                }
                else if (option.Id.Contains("Void Leviathan Values") && !voidLeviathanOptions.Contains(option))
                {
                    voidLeviathanOptions.Add(option);
                }
                else if (option.Id.Contains("Skyray Values") && !skyRayOptions.Contains(option))
                {
                    skyRayOptions.Add(option);
                }
                else if (option.Id.Contains("Pengling Values") && !penglingOptions.Contains(option))
                {
                    penglingOptions.Add(option);
                }
                else if (option.Id.Contains("Pengwing Values") && !pengwingOptions.Contains(option))
                {
                    pengwingOptions.Add(option);
                }
                else if (option.Id.Contains("Sea Monkey Baby Values") && !seaMonkeyBabyOptions.Contains(option))
                {
                    seaMonkeyBabyOptions.Add(option);
                }
                else if (option.Id.Contains("Sea Monkey Values") && !seaMonkeyOptions.Contains(option))
                {
                    seaMonkeyOptions.Add(option);
                }
                else if (option.Id.Contains("Snow Stalker Baby Values") && !snowStalkerBabyOptions.Contains(option))
                {
                    snowStalkerBabyOptions.Add(option);
                }
                else if (option.Id.Contains("Snow Stalker Values") && !snowStalkerOptions.Contains(option))
                {
                    snowStalkerOptions.Add(option);
                }
                else if (option.Id.Contains("Rock Puncher Values") && !rockPuncherOptions.Contains(option))
                {
                    rockPuncherOptions.Add(option);
                }
                else if(option.Id.Contains("Ventgarden Values") && !ventgardenOptions.Contains(option))
                {
                    ventgardenOptions.Add(option);
                }
            }
            panel.AddHeading(p, "~~~Misc. Options~~~");
            foreach (OptionItem option in miscOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Proportional Options~~~");
            foreach (OptionItem option in proportionalOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Arctic Peeper Options~~~");
            foreach (OptionItem option in arcticPeeperOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Arctic Ray Options~~~");
            foreach (OptionItem option in arcticRayOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Arrow Ray Options~~~");
            foreach (OptionItem option in arrowRayOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Bladderfish Options~~~");
            foreach (OptionItem option in bladderFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Boomerang Options~~~");
            foreach (OptionItem option in boomerangOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Brinewing Options~~~");
            foreach (OptionItem option in brineWingOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Brute Shark Options~~~");
            foreach (OptionItem option in bruteSharkOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Chelicerate Options~~~");
            foreach (OptionItem option in chelicerateOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Crash Fish Options~~~");
            foreach (OptionItem option in crashFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Cryptosuchus Options~~~");
            foreach (OptionItem option in cryptosuchusOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Discusfish Options~~~");
            foreach (OptionItem option in discusFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Eye Jelly Options~~~");
            foreach (OptionItem option in jellyFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Featherfish Options~~~");
            foreach (OptionItem option in featherFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Glow Whale Options~~~");
            foreach (OptionItem option in glowWhaleOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Hoopfish Options~~~");
            foreach (OptionItem option in hoopFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Lily Paddler Options~~~");
            foreach (OptionItem option in lilyPaddlerOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Nootfish Options~~~");
            foreach (OptionItem option in nootFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Pengling Options~~~");
            foreach (OptionItem option in penglingOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Pengwing Options~~~");
            foreach (OptionItem option in pengwingOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Pinnacarid Options~~~");
            foreach (OptionItem option in pinnacaridOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Rock Grub Options~~~");
            foreach (OptionItem option in rockGrubOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Rock Puncher Options~~~");
            foreach (OptionItem option in rockPuncherOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Sea Monkey Options~~~");
            foreach (OptionItem option in seaMonkeyOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Sea Monkey Baby Options~~~");
            foreach (OptionItem option in seaMonkeyBabyOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Shadow Leviathan Options~~~");
            foreach (OptionItem option in shadowLeviathanOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Skyray Options~~~");
            foreach (OptionItem option in skyRayOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Snow Stalker Options~~~");
            foreach (OptionItem option in snowStalkerOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Snow Stalker Baby Options~~~");
            foreach (OptionItem option in snowStalkerBabyOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Spinnerfish Options~~~");
            foreach (OptionItem option in spinnerFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Squid Shark Options~~~");
            foreach (OptionItem option in squidSharkOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Symbiotefish Options~~~");
            foreach (OptionItem option in symbioteFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Titan Holefish Options~~~");
            foreach (OptionItem option in titanHoleFishOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Triops Options~~~");
            foreach (OptionItem option in triopsOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Trivalve Options~~~");
            foreach (OptionItem option in trivalveOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Ventgarden Options~~~");
            foreach(OptionItem option in ventgardenOptions)
            {
                option.AddToPanel(panel, p);
            }

            panel.AddHeading(p, "~~~Void Leviathan Options~~~");
            foreach (OptionItem option in voidLeviathanOptions)
            {
                option.AddToPanel(panel, p);
            }
        }

        private void ToggleOptionsChanged(object sender, ToggleChangedEventArgs e)
        {
            switch(e.Id)
            {
                case "Proportional":
                    proportionalToggle.Value = e.Value;
                    break;
                case "Remove Fish Schools":
                    removeFishSchools.Value = e.Value;
                    break;
                case "Arctic Peeper Exclude":
                    arcticPeeperExclude.Value = e.Value;
                    break;
                case "Arctic Peeper Randomize":
                    arcticPeeperRandomize.Value = e.Value;
                    break;
                case "Arrow Ray Exclude":
                    arrowRayExclude.Value = e.Value;
                    break;
                case "Arrow Ray Randomize":
                    arrowRayRandomize.Value = e.Value;
                    break;
                case "Boomerang Exclude":
                    boomerangExclude.Value = e.Value;
                    break;
                case "Boomerang Randomize":
                    boomerangRandomize.Value = e.Value;
                    break;
                case "Bladderfish Exclude":
                    bladderFishExclude.Value = e.Value;
                    break;
                case "Bladderfish Randomize":
                    bladderFishRandomize.Value = e.Value;
                    break;
                case "Hoopfish Exclude":
                    hoopFishExclude.Value = e.Value;
                    break;
                case "Hoopfish Randomize":
                    hoopFishRandomize.Value = e.Value;
                    break;
                case "Discusfish Exclude":
                    discusFishExclude.Value = e.Value;
                    break;
                case "Discusfish Randomize":
                    discusFishRandomize.Value = e.Value;
                    break;
                case "Featherfish Exclude":
                    featherFishExclude.Value = e.Value;
                    break;
                case "Featherfish Randomize":
                    featherFishRandomize.Value = e.Value;
                    break;
                case "Nootfish Exclude":
                    nootFishExclude.Value = e.Value;
                    break;
                case "Nootfish Randomize":
                    nootFishRandomize.Value = e.Value;
                    break;
                case "Spinnerfish Exclude":
                    spinnerFishExclude.Value = e.Value;
                    break;
                case "Spinnerfish Randomize":
                    spinnerFishRandomize.Value = e.Value;
                    break;
                case "Arctic Ray Exclude":
                    arcticRayExclude.Value = e.Value;
                    break;
                case "Arctic Ray Randomize":
                    arcticRayRandomize.Value = e.Value;
                    break;
                case "Eye Jelly Exclude":
                    jellyFishExclude.Value = e.Value;
                    break;
                case "Eye Jelly Randomize":
                    jellyFishRandomize.Value = e.Value;
                    break;
                case "Titan Hole Fish Exclude":
                    titanHoleFishExclude.Value = e.Value;
                    break;
                case "Titan Hole Fish Randomize":
                    titanHoleFishRandomize.Value = e.Value;
                    break;
                case "Glow Whale Exclude":
                    glowWhaleExclude.Value = e.Value;
                    break;
                case "Glow Whale Randomize":
                    glowWhaleRandomize.Value = e.Value;
                    break;
                case "Pinnacarid Exclude":
                    pinnacaridExclude.Value = e.Value;
                    break;
                case "Pinnacarid Randomize":
                    pinnacaridRandomize.Value = e.Value;
                    break;
                case "Triops Exclude":
                    triopsExclude.Value = e.Value;
                    break;
                case "Triops Randomize":
                    triopsRandomize.Value = e.Value;
                    break;
                case "Trivalve Exclude":
                    trivalveExclude.Value = e.Value;
                    break;
                case "Trivalve Randomize":
                    trivalveRandomize.Value = e.Value;
                    break;
                case "Symbiotefish Exclude":
                    symbioteFishExclude.Value = e.Value;
                    break;
                case "Symbiotefish Randomize":
                    symbioteFishRandomize.Value = e.Value;
                    break;
                case "Rock Grub Exclude":
                    rockGrubExclude.Value = e.Value;
                    break;
                case "Rock Grub Randomize":
                    rockGrubRandomize.Value = e.Value;
                    break;
                case "Crashfish Exclude":
                    crashFishExclude.Value = e.Value;
                    break;
                case "Crashfish Randomize":
                    crashFishRandomize.Value = e.Value;
                    break;
                case "Brinewing Exclude":
                    brineWingExclude.Value = e.Value;
                    break;
                case "Brinewing Randomize":
                    brineWingRandomize.Value = e.Value;
                    break;
                case "Lily Paddler Exclude":
                    lilyPaddlerExclude.Value = e.Value;
                    break;
                case "Lily Paddler Randomize":
                    lilyPaddlerRandomize.Value = e.Value;
                    break;
                case "Cryptosuchus Exclude":
                    cryptosuchusExclude.Value = e.Value;
                    break;
                case "Cryptosuchus Randomize":
                    cryptosuchusRandomize.Value = e.Value;
                    break;
                case "Brute Shark Exclude":
                    bruteSharkExclude.Value = e.Value;
                    break;
                case "Brute Shark Randomize":
                    bruteSharkRandomize.Value = e.Value;
                    break;
                case "Squid Shark Exclude":
                    squidSharkExclude.Value = e.Value;
                    break;
                case "Squid Shark Randomize":
                    squidSharkRandomize.Value = e.Value;
                    break;
                case "Chelicerate Exclude":
                    chelicerateExclude.Value = e.Value;
                    break;
                case "Chelicerate Randomize":
                    chelicerateRandomize.Value = e.Value;
                    break;
                case "Shadow Leviathan Exclude":
                    shadowLeviathanExclude.Value = e.Value;
                    break;
                case "Shadow Leviathan Randomize":
                    shadowLeviathanRandomize.Value = e.Value;
                    break;
                case "Void Leviathan Exclude":
                    voidLeviathanExclude.Value = e.Value;
                    break;
                case "Void Leviathan Randomize":
                    voidLeviathanRandomize.Value = e.Value;
                    break;
                case "Sky Ray Exclude":
                    skyRayExclude.Value = e.Value;
                    break;
                case "Sky Ray Randomize":
                    skyRayRandomize.Value = e.Value;
                    break;
                case "Pengling Exclude":
                    penglingExclude.Value = e.Value;
                    break;
                case "Pengling Randomize":
                    penglingRandomize.Value = e.Value;
                    break;
                case "Pengwing Exclude":
                    pengwingExclude.Value = e.Value;
                    break;
                case "Pengwing Randomize":
                    pengwingRandomize.Value = e.Value;
                    break;
                case "Sea Monkey Baby Exclude":
                    seaMonkeyBabyExclude.Value = e.Value;
                    break;
                case "Sea Monkey Baby Randomize":
                    seaMonkeyBabyRandomize.Value = e.Value;
                    break;
                case "Sea Monkey Exclude":
                    seaMonkeyExclude.Value = e.Value;
                    break;
                case "Sea Monkey Randomize":
                    seaMonkeyRandomize.Value = e.Value;
                    break;
                case "Snow Stalker Baby Exclude":
                    snowStalkerBabyExclude.Value = e.Value;
                    break;
                case "Snow Stalker Baby Randomize":
                    snowStalkerBabyRandomize.Value = e.Value;
                    break;
                case "Snow Stalker Exclude":
                    snowStalkerExclude.Value = e.Value;
                    break;
                case "Snow Stalker Randomize":
                    snowStalkerRandomize.Value = e.Value;
                    break;
                case "Rock Puncher Exclude":
                    rockPuncherExclude.Value = e.Value;
                    break;
                case "Rock Puncher Randomize":
                    rockPuncherRandomize.Value = e.Value;
                    break;
                case "Ventgarden Randomize":
                    ventgardenRandomize.Value = e.Value;
                    break;
            }
        }

        private void SliderOptionsChanged(object sender, SliderChangedEventArgs e)
        {
            switch(e.Id)
            {
                case "Proportional Scale":
                    proportionalScale.Value = e.Value;
                    break;
                case "Proportional Slowness":
                    proportionalSlowness.Value = e.Value;
                    break;
                case "Proportional Health":
                    proportionalHealth.Value = e.Value;
                    break;
                case "Proportional Creature Limit":
                    proportionalCreatureLimit.Value = e.Value;
                    break;
                case "Proportional Randomize Min":
                    proportionalRandomizeMin.Value = e.Value;
                    break;
                case "Proportional Randomize Max":
                    proportionalRandomizeMax.Value = e.Value;
                    break;

                case "Arctic Peeper Scale":
                    arcticPeeperScale.Value = e.Value;
                    break;
                case "Arctic Peeper Slowness":
                    arcticPeeperSlowness.Value = e.Value;
                    break;
                case "Arctic Peeper Health":
                    arcticPeeperHealth.Value = e.Value;
                    break;
                case "Arctic Peeper Limit":
                    arcticPeeperLimit.Value = e.Value;
                    break;
                case "Arctic Peeper Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Arctic Peeper Randomize Max":
                    arcticPeeperRandomizeMax.Value= e.Value;
                    break;

                case "Arrow Ray Scale":
                    arrowRayScale.Value = e.Value;
                    break;
                case "Arrow Ray Slowness":
                    arrowRaySlowness.Value = e.Value;
                    break;
                case "Arrow Ray Health":
                    arrowRayHealth.Value = e.Value;
                    break;
                case "Arrow Ray Limit":
                    arrowRayLimit.Value = e.Value;
                    break;
                case "Arrow Ray Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Arrow Ray Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Boomerang Scale":
                    boomerangScale.Value = e.Value;
                    break;
                case "Boomerang Slowness":
                    boomerangSlowness.Value = e.Value;
                    break;
                case "Boomerang Health":
                    boomerangHealth.Value = e.Value;
                    break;
                case "Boomerang Limit":
                    boomerangLimit.Value = e.Value;
                    break;
                case "Boomerang Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Boomerang Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Bladderfish Scale":
                    bladderFishScale.Value = e.Value;
                    break;
                case "Bladderfish Slowness":
                    bladderFishSlowness.Value = e.Value;
                    break;
                case "Bladderfish Health":
                    bladderFishHealth.Value = e.Value;
                    break;
                case "Bladderfish Limit":
                    bladderFishLimit.Value = e.Value;
                    break;
                case "Bladderfish Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Bladderfish Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Hoopfish Scale":
                    hoopFishScale.Value = e.Value;
                    break;
                case "Hoopfish Slowness":
                    hoopFishSlowness.Value = e.Value;
                    break;
                case "Hoopfish Health":
                    hoopFishHealth.Value = e.Value;
                    break;
                case "Hoopfish Limit":
                    hoopFishLimit.Value = e.Value;
                    break;
                case "Hoopfish Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Hoopfish Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Discusfish Scale":
                    discusFishScale.Value = e.Value;
                    break;
                case "Discusfish Slowness":
                    discusFishSlowness.Value = e.Value;
                    break;
                case "Discusfish Health":
                    discusFishHealth.Value = e.Value;
                    break;
                case "Discusfish Limit":
                    discusFishLimit.Value = e.Value;
                    break;
                case "Discusfish Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Discusfish Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Featherfish Scale":
                    featherFishScale.Value = e.Value;
                    break;
                case "Featherfish Slowness":
                    featherFishSlowness.Value = e.Value;
                    break;
                case "Featherfish Health":
                    featherFishHealth.Value = e.Value;
                    break;
                case "Featherfish Limit":
                    featherFishLimit.Value = e.Value;
                    break;
                case "Featherfish Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Featherfish Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Nootfish Scale":
                    nootFishScale.Value = e.Value;
                    break;
                case "Nootfish Slowness":
                    nootFishSlowness.Value = e.Value;
                    break;
                case "Nootfish Health":
                    nootFishHealth.Value = e.Value;
                    break;
                case "Nootfish Limit":
                    nootFishLimit.Value = e.Value;
                    break;
                case "Nootfish Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Nootfish Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Spinnerfish Scale":
                    spinnerFishScale.Value = e.Value;
                    break;
                case "Spinnerfish Slowness":
                    spinnerFishSlowness.Value = e.Value;
                    break;
                case "Spinnerfish Health":
                    spinnerFishHealth.Value = e.Value;
                    break;
                case "Spinnerfish Limit":
                    spinnerFishLimit.Value = e.Value;
                    break;
                case "Spinnerfish Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Spinnerfish Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Arctic Ray Scale":
                    arcticRayScale.Value = e.Value;
                    break;
                case "Arctic Ray Slowness":
                    arcticRaySlowness.Value = e.Value;
                    break;
                case "Arctic Ray Health":
                    arcticRayHealth.Value = e.Value;
                    break;
                case "Arctic Ray Limit":
                    arcticRayLimit.Value = e.Value;
                    break;
                case "Arctic Ray Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Arctic Ray Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Eye Jelly Scale":
                    jellyFishScale.Value = e.Value;
                    break;
                case "Eye Jelly Slowness":
                    jellyFishSlowness.Value = e.Value;
                    break;
                case "Eye Jelly Health":
                    jellyFishHealth.Value = e.Value;
                    break;
                case "Eye Jelly Limit":
                    jellyFishLimit.Value = e.Value;
                    break;
                case "Eye Jelly Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Eye Jelly Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Titan Hole Fish Scale":
                    titanHoleFishScale.Value = e.Value;
                    break;
                case "Titan Hole Fish Slowness":
                    titanHoleFishSlowness.Value = e.Value;
                    break;
                case "Titan Hole Fish Health":
                    titanHoleFishHealth.Value = e.Value;
                    break;
                case "Titan Hole Fish Limit":
                    titanHoleFishLimit.Value = e.Value;
                    break;
                case "Titan Hole Fish Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Titan Hole Fish Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Glow Whale Scale":
                    glowWhaleScale.Value = e.Value;
                    break;
                case "Glow Whale Slowness":
                    glowWhaleSlowness.Value = e.Value;
                    break;
                case "Glow Whale Health":
                    glowWhaleHealth.Value = e.Value;
                    break;
                case "Glow Whale Limit":
                    glowWhaleLimit.Value = e.Value;
                    break;
                case "Glow Whale Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Glow Whale Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Pinnacarid Scale":
                    pinnacaridScale.Value = e.Value;
                    break;
                case "Pinnacarid Slowness":
                    pinnacaridSlowness.Value = e.Value;
                    break;
                case "Pinnacarid Health":
                    pinnacaridHealth.Value = e.Value;
                    break;
                case "Pinnacarid Limit":
                    pinnacaridLimit.Value = e.Value;
                    break;
                case "Pinnacarid Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Pinnacarid Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Triops Scale":
                    triopsScale.Value = e.Value;
                    break;
                case "Triops Slowness":
                    triopsSlowness.Value = e.Value;
                    break;
                case "Triops Health":
                    triopsHealth.Value = e.Value;
                    break;
                case "Triops Limit":
                    triopsLimit.Value = e.Value;
                    break;
                case "Triops Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Triops Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Trivalve Scale":
                    trivalveScale.Value = e.Value;
                    break;
                case "Trivalve Slowness":
                    trivalveSlowness.Value = e.Value;
                    break;
                case "Trivalve Health":
                    trivalveHealth.Value = e.Value;
                    break;
                case "Trivalve Limit":
                    trivalveLimit.Value = e.Value;
                    break;
                case "Trivalve Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Trivalve Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Symbiotefish Scale":
                    symbioteFishScale.Value = e.Value;
                    break;
                case "Symbiotefish Slowness":
                    symbioteFishSlowness.Value = e.Value;
                    break;
                case "Symbiotefish Health":
                    symbioteFishHealth.Value = e.Value;
                    break;
                case "Symbiotefish Limit":
                    symbioteFishLimit.Value = e.Value;
                    break;
                case "Symbiotefish Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Symbiotefish Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Rock Grub Scale":
                    rockGrubScale.Value = e.Value;
                    break;
                case "Rock Grub Slowness":
                    rockGrubSlowness.Value = e.Value;
                    break;
                case "Rock Grub Health":
                    rockGrubHealth.Value = e.Value;
                    break;
                case "Rock Grub Limit":
                    rockGrubLimit.Value = e.Value;
                    break;
                case "Rock Grub Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Rock Grub Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Crash Fish Scale":
                    crashFishScale.Value = e.Value;
                    break;
                case "Crash Fish Slowness":
                    crashFishSlowness.Value = e.Value;
                    break;
                case "Crash Fish Health":
                    crashFishHealth.Value = e.Value;
                    break;
                case "Crash Fish Limit":
                    crashFishLimit.Value = e.Value;
                    break;
                case "Crash Fish Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Crash Fish Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Brinewing Scale":
                    brineWingScale.Value = e.Value;
                    break;
                case "Brinewing Slowness":
                    brineWingSlowness.Value = e.Value;
                    break;
                case "Brinewing Health":
                    brineWingHealth.Value = e.Value;
                    break;
                case "Brinewing Limit":
                    brineWingLimit.Value = e.Value;
                    break;
                case "Brinewing Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Brinewing Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;

                    break;
                case "Lily Paddler Scale":
                    lilyPaddlerScale.Value = e.Value;
                    break;
                case "Lily Paddler Slowness":
                    lilyPaddlerSlowness.Value = e.Value;
                    break;
                case "Lily Paddler Health":
                    lilyPaddlerHealth.Value = e.Value;
                    break;
                case "Lily Paddler Limit":
                    lilyPaddlerLimit.Value = e.Value;
                    break;
                case "Lily Paddler Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Lily Paddler Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Cryptosuchus Scale":
                    cryptosuchusScale.Value = e.Value;
                    break;
                case "Cryptosuchus Slowness":
                    cryptosuchusSlowness.Value = e.Value;
                    break;
                case "Cryptosuchus Health":
                    cryptosuchusHealth.Value = e.Value;
                    break;
                case "Cryptosuchus Limit":
                    cryptosuchusLimit.Value = e.Value;
                    break;
                case "Cryptosuchus Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Cryptosuchus Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Brute Shark Scale":
                    bruteSharkScale.Value = e.Value;
                    break;
                case "Brute Shark Slowness":
                    bruteSharkSlowness.Value = e.Value;
                    break;
                case "Brute Shark Health":
                    bruteSharkHealth.Value = e.Value;
                    break;
                case "Brute Shark Limit":
                    bruteSharkLimit.Value = e.Value;
                    break;
                case "Brute Shark Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Brute Shark Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;

                    break;
                case "Squid Shark Scale":
                    squidSharkScale.Value = e.Value;
                    break;
                case "Squid Shark Slowness":
                    squidSharkSlowness.Value = e.Value;
                    break;
                case "Squid Shark Health":
                    squidSharkHealth.Value = e.Value;
                    break;
                case "Squid Shark Limit":
                    squidSharkLimit.Value = e.Value;
                    break;
                case "Squid Shark Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Squid Shark Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;

                    break;
                case "Chelicerate Scale":
                    chelicerateScale.Value = e.Value;
                    break;
                case "Chelicerate Slowness":
                    chelicerateSlowness.Value = e.Value;
                    break;
                case "Chelicerate Health":
                    chelicerateHealth.Value = e.Value;
                    break;
                case "Chelicerate Limit":
                    chelicerateLimit.Value = e.Value;
                    break;
                case "Chelicerate Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Chelicerate Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Shadow Leviathan Scale":
                    shadowLeviathanScale.Value = e.Value;
                    break;
                case "Shadow Leviathan Slowness":
                    shadowLeviathanSlowness.Value = e.Value;
                    break;
                case "Shadow Leviathan Health":
                    shadowLeviathanHealth.Value = e.Value;
                    break;
                case "Shadow Leviathan Limit":
                    shadowLeviathanLimit.Value = e.Value;
                    break;
                case "Shadow Leviathan Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Shadow Leviathan Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Void Leviathan Scale":
                    voidLeviathanScale.Value = e.Value;
                    break;
                case "Void Leviathan Slowness":
                    voidLeviathanSlowness.Value = e.Value;
                    break;
                case "Void Leviathan Health":
                    voidLeviathanHealth.Value = e.Value;
                    break;
                case "Void Leviathan Limit":
                    voidLeviathanLimit.Value = e.Value;
                    break;
                case "Void Leviathan Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Void Leviathan Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Skyray Scale":
                    skyRayScale.Value = e.Value;
                    break;
                case "Skyray Slowness":
                    skyRaySlowness.Value = e.Value;
                    break;
                case "Skyray Health":
                    skyRayHealth.Value = e.Value;
                    break;
                case "Skyray Limit":
                    skyRayLimit.Value = e.Value;
                    break;
                case "Skyray Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Skyray Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Pengling Scale":
                    penglingScale.Value = e.Value;
                    break;
                case "Pengling Slowness":
                    penglingSlowness.Value = e.Value;
                    break;
                case "Pengling Health":
                    penglingHealth.Value = e.Value;
                    break;
                case "Pengling Limit":
                    penglingLimit.Value = e.Value;
                    break;
                case "Pengling Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Pengling Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Pengwing Scale":
                    pengwingScale.Value = e.Value;
                    break;
                case "Pengwing Slowness":
                    pengwingSlowness.Value = e.Value;
                    break;
                case "Pengwing Health":
                    pengwingHealth.Value = e.Value;
                    break;
                case "Pengwing Limit":
                    pengwingLimit.Value = e.Value;
                    break;
                case "Pengwing Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Pengwing Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Sea Monkey Baby Scale":
                    seaMonkeyBabyScale.Value = e.Value;
                    break;
                case "Sea Monkey Baby Slowness":
                    seaMonkeyBabySlowness.Value = e.Value;
                    break;
                case "Sea Monkey Baby Health":
                    seaMonkeyBabyHealth.Value = e.Value;
                    break;
                case "Sea Monkey Baby Limit":
                    seaMonkeyBabyLimit.Value = e.Value;
                    break;
                case "Sea Monkey Baby Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Sea Monkey Baby Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Sea Monkey Scale":
                    seaMonkeyScale.Value = e.Value;
                    break;
                case "Sea Monkey Slowness":
                    seaMonkeySlowness.Value = e.Value;
                    break;
                case "Sea Monkey Health":
                    seaMonkeyHealth.Value = e.Value;
                    break;
                case "Sea Monkey Limit":
                    seaMonkeyLimit.Value = e.Value;
                    break;
                case "Sea Monkey Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Sea Monkey Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Snow Stalker Baby Scale":
                    snowStalkerBabyScale.Value = e.Value;
                    break;
                case "Snow Stalker Baby Slowness":
                    snowStalkerBabySlowness.Value = e.Value;
                    break;
                case "Snow Stalker Baby Health":
                    snowStalkerBabyHealth.Value = e.Value;
                    break;
                case "Snow Stalker Baby Limit":
                    snowStalkerBabyLimit.Value = e.Value;
                    break;
                case "Snow Stalker Baby Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Snow Stalker Baby Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Snow Stalker Scale":
                    snowStalkerScale.Value = e.Value;
                    break;
                case "Snow Stalker Slowness":
                    snowStalkerSlowness.Value = e.Value;
                    break;
                case "Snow Stalker Health":
                    snowStalkerHealth.Value = e.Value;
                    break;
                case "Snow Stalker Limit":
                    snowStalkerLimit.Value = e.Value;
                    break;
                case "Snow Stalker Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Snow Stalker Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Rock Puncher Scale":
                    rockPuncherScale.Value = e.Value;
                    break;
                case "Rock Puncher Slowness":
                    rockPuncherSlowness.Value = e.Value;
                    break;
                case "Rock Puncher Health":
                    rockPuncherHealth.Value = e.Value;
                    break;
                case "Rock Puncher Limit":
                    rockPuncherLimit.Value = e.Value;
                    break;
                case "Rock Puncher Randomize Min":
                    arcticPeeperRandomizeMin.Value = e.Value;
                    break;
                case "Rock Puncher Randomize Max":
                    arcticPeeperRandomizeMax.Value = e.Value;
                    break;

                case "Small Ventgarden Scale":
                    smallVentGardenScale.Value = e.Value;
                    break;
                case "Large Ventgarden Scale":
                    largeVentGardenScale.Value = e.Value;
                    break;
                case "Ventgarden Randomize Min":
                    ventgardenRandomizeMin.Value = e.Value;
                    break;
                case "Ventgarden Randomize Max":
                    ventgardenRandomizeMax.Value = e.Value;
                    break;
            }
        }
    }
#endif
}