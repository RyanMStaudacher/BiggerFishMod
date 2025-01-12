using BepInEx.Configuration;
using JetBrains.Annotations;
using Nautilus.Handlers;
using Nautilus.Options;

namespace BiggerFishMod
{
#if SUBNAUTICA
    public class MyModOptions : ModOptions
    {
        public static ConfigEntry<bool> proportionalToggle;
        public static ConfigEntry<float> proportionalScale;
        public static ConfigEntry<float> proportionalSlowness;
        public static ConfigEntry<float> proportionalHealth;
        public static ConfigEntry<float> proportionalCreatureLimit;
        //public static ConfigEntry<bool> randomizeAllToggle;
        //public static ConfigEntry<float> randomizeAllMin;
        //public static ConfigEntry<float> randomizeAllMax;
        public static ConfigEntry<bool> removeFishSchools;
        //public static ConfigEntry<bool> biterRandomize;
        //public static ConfigEntry<float> biterRandomizeMin;
        //public static ConfigEntry<float> biterRandomizeMax;
        public static ConfigEntry<float> biterScale;
        public static ConfigEntry<float> biterSlowness;
        public static ConfigEntry<float> biterHealth;
        public static ConfigEntry<float> biterLimit;
        //public static ConfigEntry<bool> bladderFishrRandomize;
        //public static ConfigEntry<float> bladderFishRandomizeMin;
        //public static ConfigEntry<float> bladderFishRandomizeMax;
        public static ConfigEntry<float> bladderFishScale;
        public static ConfigEntry<float> bladderFishSlowness;
        public static ConfigEntry<float> bladderFishHealth;
        public static ConfigEntry<float> bladderFishLimit;
        //public static ConfigEntry<bool> bleederRandomize;
        //public static ConfigEntry<float> bleederRandomizeMin;
        //public static ConfigEntry<float> bleederRandomizeMax;
        public static ConfigEntry<float> bleederScale;
        public static ConfigEntry<float> bleederSlowness;
        public static ConfigEntry<float> bleederHealth;
        public static ConfigEntry<float> bleederLimit;
        //public static ConfigEntry<bool> boneSharkRandomize;
        //public static ConfigEntry<float> boneSharkRandomizeMin;
        //public static ConfigEntry<float> boneSharkRandomizeMax;
        public static ConfigEntry<float> boneSharkScale;
        public static ConfigEntry<float> boneSharkSlowness;
        public static ConfigEntry<float> boneSharkHealth;
        public static ConfigEntry<float> boneSharkLimit;
        //public static ConfigEntry<bool> boomerangRandomize;
        //public static ConfigEntry<float> boomerangRandomizeMin;
        //public static ConfigEntry<float> boomerangRandomizeMax;
        public static ConfigEntry<float> boomerangScale;
        public static ConfigEntry<float> boomerangSlowness;
        public static ConfigEntry<float> boomerangHealth;
        public static ConfigEntry<float> boomerangLimit;
        //public static ConfigEntry<bool> caveCrawlerRandomize;
        //public static ConfigEntry<float> caveCrawlerRandomizeMin;
        //public static ConfigEntry<float> caveCrawlerRandomizeMax;
        public static ConfigEntry<float> caveCrawlerScale;
        public static ConfigEntry<float> caveCrawlerSlowness;
        public static ConfigEntry<float> caveCrawlerHealth;
        public static ConfigEntry<float> caveCrawlerLimit;
        //public static ConfigEntry<bool> crabSnakeRandomize;
        //public static ConfigEntry<float> crabSnakeRandomizeMin;
        //public static ConfigEntry<float> crabSnakeRandomizeMax;
        public static ConfigEntry<float> crabSnakeScale;
        public static ConfigEntry<float> crabSnakeSlowness;
        public static ConfigEntry<float> crabSnakeHealth;
        public static ConfigEntry<float> crabSnakeLimit;
        //public static ConfigEntry<bool> crabSquidRandomize;
        //public static ConfigEntry<float> crabSquidRandomizeMin;
        //public static ConfigEntry<float> crabSquidRandomizeMax;
        public static ConfigEntry<float> crabSquidScale;
        public static ConfigEntry<float> crabSquidSlowness;
        public static ConfigEntry<float> crabSquidHealth;
        public static ConfigEntry<float> crabSquidLimit;
        //public static ConfigEntry<bool> crashFishRandomize;
        //public static ConfigEntry<float> crashFishRandomizeMin;
        //public static ConfigEntry<float> crashFishRandomizeMax;
        public static ConfigEntry<float> crashFishScale;
        public static ConfigEntry<float> crashFishSlowness;
        public static ConfigEntry<float> crashFishHealth;
        public static ConfigEntry<float> crashFishLimit;
        //public static ConfigEntry<bool> cuddleFishRandomize;
        //public static ConfigEntry<float> cuddleFishRandomizeMin;
        //public static ConfigEntry<float> cuddleFishRandomizeMax;
        public static ConfigEntry<float> cuddleFishScale;
        public static ConfigEntry<float> cuddleFishSlowness;
        public static ConfigEntry<float> cuddleFishHealth;
        public static ConfigEntry<float> cuddleFishLimit;
        //public static ConfigEntry<bool> eyeyeRandomize;
        //public static ConfigEntry<float> eyeyeRandomizeMin;
        //public static ConfigEntry<float> eyeyeRandomizeMax;
        public static ConfigEntry<float> eyeyeScale;
        public static ConfigEntry<float> eyeyeSlowness;
        public static ConfigEntry<float> eyeyeHealth;
        public static ConfigEntry<float> eyeyeLimit;
        //public static ConfigEntry<bool> garryFishRandomize;
        //public static ConfigEntry<float> garryFishRandomizeMin;
        //public static ConfigEntry<float> garryFishRandomizeMax;
        public static ConfigEntry<float> garryFishScale;
        public static ConfigEntry<float> garryFishSlowness;
        public static ConfigEntry<float> garryFishHealth;
        public static ConfigEntry<float> garryFishLimit;
        //public static ConfigEntry<bool> gasopodRandomize;
        //public static ConfigEntry<float> gasopodRandomizeMin;
        //public static ConfigEntry<float> gasopodRandomizeMax;
        public static ConfigEntry<float> gasopodScale;
        public static ConfigEntry<float> gasopodSlowness;
        public static ConfigEntry<float> gasopodHealth;
        public static ConfigEntry<float> gasopodLimit;
        //public static ConfigEntry<bool> voidGhostLeviathanRandomize;
        //public static ConfigEntry<float> voidGhostLeviathanRandomizeMin;
        //public static ConfigEntry<float> voidGhostLeviathanRandomizeMax;
        public static ConfigEntry<float> voidGhostLeviathanScale;
        public static ConfigEntry<float> voidGhostLeviathanSlowness;
        public static ConfigEntry<float> voidGhostLeviathanHealth;
        public static ConfigEntry<float> voidGhostLeviathanLimit;
        //public static ConfigEntry<bool> ghostLeviathanRandomize;
        //public static ConfigEntry<float> ghostLeviathanRandomizeMin;
        //public static ConfigEntry<float> ghostLeviathanRandomizeMax;
        public static ConfigEntry<float> ghostLeviathanScale;
        public static ConfigEntry<float> ghostLeviathanSlowness;
        public static ConfigEntry<float> ghostLeviathanHealth;
        public static ConfigEntry<float> ghostLeviathanLimit;
        //public static ConfigEntry<bool> ghostRayRandomize;
        //public static ConfigEntry<float> ghostRayRandomizeMin;
        //public static ConfigEntry<float> ghostRayRandomizeMax;
        public static ConfigEntry<float> ghostRayScale;
        public static ConfigEntry<float> ghostRaySlowness;
        public static ConfigEntry<float> ghostRayHealth;
        public static ConfigEntry<float> ghostRayLimit;
        //public static ConfigEntry<bool> holeFishRandomize;
        //public static ConfigEntry<float> holeFishRandomizeMin;
        //public static ConfigEntry<float> holeFishRandomizeMax;
        public static ConfigEntry<float> holeFishScale;
        public static ConfigEntry<float> holeFishSlowness;
        public static ConfigEntry<float> holeFishHealth;
        public static ConfigEntry<float> holeFishLimit;
        //public static ConfigEntry<bool> hoopFishRandomize;
        //public static ConfigEntry<float> hoopFishRandomizeMin;
        //public static ConfigEntry<float> hoopFishRandomizeMax;
        public static ConfigEntry<float> hoopFishScale;
        public static ConfigEntry<float> hoopFishSlowness;
        public static ConfigEntry<float> hoopFishHealth;
        public static ConfigEntry<float> hoopFishLimit;
        //public static ConfigEntry<bool> hoverFishRandomize;
        //public static ConfigEntry<float> hoverFishRandomizeMin;
        //public static ConfigEntry<float> hoverFishRandomizeMax;
        public static ConfigEntry<float> hoverFishScale;
        public static ConfigEntry<float> hoverFishSlowness;
        public static ConfigEntry<float> hoverFishHealth;
        public static ConfigEntry<float> hoverFishLimit;
        //public static ConfigEntry<bool> jellyRayRandomize;
        //public static ConfigEntry<float> jellyRayRandomizeMin;
        //public static ConfigEntry<float> jellyRayRandomizeMax;
        public static ConfigEntry<float> jellyRayScale;
        public static ConfigEntry<float> jellyRaySlowness;
        public static ConfigEntry<float> jellyRayHealth;
        public static ConfigEntry<float> jellyRayLimit;
        //public static ConfigEntry<bool> jumperRandomize;
        //public static ConfigEntry<float> jumperRandomizeMin;
        //public static ConfigEntry<float> jumperRandomizeMax;
        public static ConfigEntry<float> jumperScale;
        public static ConfigEntry<float> jumperSlowness;
        public static ConfigEntry<float> jumperHealth;
        public static ConfigEntry<float> jumperLimit;
        //public static ConfigEntry<bool> lavaLarvaRandomize;
        //public static ConfigEntry<float> lavaLarvaRandomizeMin;
        //public static ConfigEntry<float> lavaLarvaRandomizeMax;
        public static ConfigEntry<float> lavaLarvaScale;
        public static ConfigEntry<float> lavaLarvaSlowness;
        public static ConfigEntry<float> lavaLarvaHealth;
        public static ConfigEntry<float> lavaLarvaLimit;
        //public static ConfigEntry<bool> lavaLizardRandomize;
        //public static ConfigEntry<float> lavaLizardRandomizeMin;
        //public static ConfigEntry<float> lavaLizardRandomizeMax;
        public static ConfigEntry<float> lavaLizardScale;
        public static ConfigEntry<float> lavaLizardSlowness;
        public static ConfigEntry<float> lavaLizardHealth;
        public static ConfigEntry<float> lavaLizardLimit;
        //public static ConfigEntry<bool> mesmerRandomize;
        //public static ConfigEntry<float> mesmerRandomizeMin;
        //public static ConfigEntry<float> mesmerRandomizeMax;
        public static ConfigEntry<float> mesmerScale;
        public static ConfigEntry<float> mesmerSlowness;
        public static ConfigEntry<float> mesmerHealth;
        public static ConfigEntry<float> mesmerLimit;
        //public static ConfigEntry<bool> oculusFishRandomize;
        //public static ConfigEntry<float> oculusFishRandomizeMin;
        //public static ConfigEntry<float> oculusFishRandomizeMax;
        public static ConfigEntry<float> oculusFishScale;
        public static ConfigEntry<float> oculusFishSlowness;
        public static ConfigEntry<float> oculusFishHealth;
        public static ConfigEntry<float> oculusFishLimit;
        //public static ConfigEntry<bool> peeperRandomize;
        //public static ConfigEntry<float> peeperRandomizeMin;
        //public static ConfigEntry<float> peeperRandomizeMax;
        public static ConfigEntry<float> peeperScale;
        public static ConfigEntry<float> peeperSlowness;
        public static ConfigEntry<float> peeperHealth;
        public static ConfigEntry<float> peeperLimit;
        //public static ConfigEntry<bool> rabbitRayRandomize;
        //public static ConfigEntry<float> rabbitRayRandomizeMin;
        //public static ConfigEntry<float> rabbitRayRandomizeMax;
        public static ConfigEntry<float> rabbitRayScale;
        public static ConfigEntry<float> rabbitRaySlowness;
        public static ConfigEntry<float> rabbitRayHealth;
        public static ConfigEntry<float> rabbitRayLimit;
        //public static ConfigEntry<bool> reaperLeviathanRandomize;
        //public static ConfigEntry<float> reaperLeviathanRandomizeMin;
        //public static ConfigEntry<float> reaperLeviathanRandomizeMax;
        public static ConfigEntry<float> reaperLeviathanScale;
        public static ConfigEntry<float> reaperLeviathanSlowness;
        public static ConfigEntry<float> reaperLeviathanHealth;
        public static ConfigEntry<float> reaperLeviathanLimit;
        //public static ConfigEntry<bool> reefbackRandomize;
        //public static ConfigEntry<float> reefbackRandomizeMin;
        //public static ConfigEntry<float> reefbackRandomizeMax;
        public static ConfigEntry<float> reefbackScale;
        public static ConfigEntry<float> reefbackSlowness;
        public static ConfigEntry<float> reefbackHealth;
        public static ConfigEntry<float> reefbackLimit;
        //public static ConfigEntry<bool> reginaldRandomize;
        //public static ConfigEntry<float> reginaldRandomizeMin;
        //public static ConfigEntry<float> reginaldRandomizeMax;
        public static ConfigEntry<float> reginaldScale;
        public static ConfigEntry<float> reginaldSlowness;
        public static ConfigEntry<float> reginaldHealth;
        public static ConfigEntry<float> reginaldLimit;
        //public static ConfigEntry<bool> sandSharkRandomize;
        //public static ConfigEntry<float> sandSharkRandomizeMin;
        //public static ConfigEntry<float> sandSharkRandomizeMax;
        public static ConfigEntry<float> sandSharkScale;
        public static ConfigEntry<float> sandSharkSlowness;
        public static ConfigEntry<float> sandSharkHealth;
        public static ConfigEntry<float> sandSharkLimit;
        //public static ConfigEntry<bool> seaDragonRandomize;
        //public static ConfigEntry<float> seaDragonRandomizeMin;
        //public static ConfigEntry<float> seaDragonRandomizeMax;
        public static ConfigEntry<float> seaDragonScale;
        public static ConfigEntry<float> seaDragonSlowness;
        public static ConfigEntry<float> seaDragonHealth;
        public static ConfigEntry<float> seaDragonLimit;
        //public static ConfigEntry<bool> seaEmporerBabyRandomize;
        //public static ConfigEntry<float> seaEmporerBabyRandomizeMin;
        //public static ConfigEntry<float> seaEmporerBabyRandomizeMax;
        public static ConfigEntry<float> seaEmporerBabyScale;
        public static ConfigEntry<float> seaEmporerBabySlowness;
        public static ConfigEntry<float> seaEmporerBabyHealth;
        public static ConfigEntry<float> seaEmporerBabyLimit;
        //public static ConfigEntry<bool> seaEmporerJuvenileRandomize;
        //public static ConfigEntry<float> seaEmporerJuvenileRandomizeMin;
        //public static ConfigEntry<float> seaEmporerJuvenileRandomizeMax;
        public static ConfigEntry<float> seaEmporerJuvenileScale;
        public static ConfigEntry<float> seaEmporerJuvenileSlowness;
        public static ConfigEntry<float> seaEmporerJuvenileHealth;
        public static ConfigEntry<float> seaEmporerJuvenileLimit;
        //public static ConfigEntry<bool> seaTreaderRandomize;
        //public static ConfigEntry<float> seaTreaderRandomizeMin;
        //public static ConfigEntry<float> seaTreaderRandomizeMax;
        public static ConfigEntry<float> seaTreaderScale;
        public static ConfigEntry<float> seaTreaderSlowness;
        public static ConfigEntry<float> seaTreaderHealth;
        public static ConfigEntry<float> seaTreaderLimit;
        //public static ConfigEntry<bool> shockerRandomize;
        //public static ConfigEntry<float> shockerRandomizeMin;
        //public static ConfigEntry<float> shockerRandomizeMax;
        public static ConfigEntry<float> shockerScale;
        public static ConfigEntry<float> shockerSlowness;
        public static ConfigEntry<float> shockerHealth;
        public static ConfigEntry<float> shockerLimit;
        //public static ConfigEntry<bool> spadeFishRandomize;
        //public static ConfigEntry<float> spadeFishRandomizeMin;
        //public static ConfigEntry<float> spadeFishRandomizeMax;
        public static ConfigEntry<float> spadeFishScale;
        public static ConfigEntry<float> spadeFishSlowness;
        public static ConfigEntry<float> spadeFishHealth;
        public static ConfigEntry<float> spadeFishLimit;
        //public static ConfigEntry<bool> spineEelRandomize;
        //public static ConfigEntry<float> spineEelRandomizeMin;
        //public static ConfigEntry<float> spineEelRandomizeMax;
        public static ConfigEntry<float> spineEelScale;
        public static ConfigEntry<float> spineEelSlowness;
        public static ConfigEntry<float> spineEelHealth;
        public static ConfigEntry<float> spineEelLimit;
        //public static ConfigEntry<bool> stalkerRandomize;
        //public static ConfigEntry<float> stalkerRandomizeMin;
        //public static ConfigEntry<float> stalkerRandomizeMax;
        public static ConfigEntry<float> stalkerScale;
        public static ConfigEntry<float> stalkerSlowness;
        public static ConfigEntry<float> stalkerHealth;
        public static ConfigEntry<float> stalkerLimit;
        //public static ConfigEntry<bool> warperRandomize;
        //public static ConfigEntry<float> warperRandomizeMin;
        //public static ConfigEntry<float> warperRandomizeMax;
        public static ConfigEntry<float> warperScale;
        public static ConfigEntry<float> warperSlowness;
        public static ConfigEntry<float> warperHealth;
        public static ConfigEntry<float> warperLimit;

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

            //ModToggleOption randomizeAllOption = randomizeAllToggle.ToModToggleOption();
            //randomizeAllOption.OnChanged += ToggleOptionsChanged;
            //AddItem(randomizeAllOption);

            //ModSliderOption randomizeAllMinOption = randomizeAllMin.ToModSliderOption(1, 50);
            //randomizeAllMinOption.OnChanged += SliderOptionsChanged;
            //AddItem(randomizeAllMinOption);

            //ModSliderOption randomizeAllMaxOption = randomizeAllMax.ToModSliderOption(1, 50);
            //randomizeAllMaxOption.OnChanged += SliderOptionsChanged;
            //AddItem(randomizeAllMaxOption);

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

            ModSliderOption boneSharkScaleOption = boneSharkScale.ToModSliderOption(1, 50);
            boneSharkScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkScaleOption);

            ModSliderOption boneSharkSlownessOption = boneSharkSlowness.ToModSliderOption(1, 100);
            boneSharkSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkSlownessOption);

            ModSliderOption boneSharkHealthOption = boneSharkHealth.ToModSliderOption(1, 100);
            boneSharkHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkHealthOption);

            ModSliderOption boneSharkLimitOption = boneSharkLimit.ToModSliderOption(1, 100);
            boneSharkLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(boneSharkLimitOption);

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

            ModSliderOption seaEmporerBabyScaleOption = seaEmporerBabyScale.ToModSliderOption(1, 50);
            seaEmporerBabyScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmporerBabyScaleOption);

            ModSliderOption seaEmporerBabySlownessOption = seaEmporerBabySlowness.ToModSliderOption(1, 100);
            seaEmporerBabySlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmporerBabySlownessOption);

            ModSliderOption seaEmporerBabyHealthOption = seaEmporerBabyHealth.ToModSliderOption(1, 100);
            seaEmporerBabyHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmporerBabyHealthOption);

            ModSliderOption seaEmporerBabyLimitOption = seaEmporerBabyLimit.ToModSliderOption(0, 50);
            seaEmporerBabyLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmporerBabyLimitOption);

            ModSliderOption seaEmporerJuvenileScaleOption = seaEmporerJuvenileScale.ToModSliderOption(1, 50);
            seaEmporerJuvenileScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmporerJuvenileScaleOption);

            ModSliderOption seaEmporerJuvenileSlownessOption = seaEmporerJuvenileSlowness.ToModSliderOption(1, 100);
            seaEmporerJuvenileSlownessOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmporerJuvenileSlownessOption);

            ModSliderOption seaEmporerJuvenileHealthOption = seaEmporerJuvenileHealth.ToModSliderOption(1, 100);
            seaEmporerJuvenileHealthOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmporerJuvenileHealthOption);

            ModSliderOption seaEmporerJuvenileLimitOption = seaEmporerJuvenileLimit.ToModSliderOption(0, 50);
            seaEmporerJuvenileLimitOption.OnChanged += SliderOptionsChanged;
            AddItem(seaEmporerJuvenileLimitOption);

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

            OptionsPanelHandler.RegisterModOptions(this);
        }

        private void ToggleOptionsChanged(object sender, ToggleChangedEventArgs e)
        {
            switch (e.Id)
            {
                case "Proportional":
                    proportionalToggle.Value = e.Value;
                    break;
                case "Remove Fish Schools":
                    removeFishSchools.Value = e.Value;
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
                case "Void Ghost Leviathan Scale":
                    voidGhostLeviathanScale.Value = e.Value;
                    break;
                case "Void Ghost Leviathan Slowness":
                    voidGhostLeviathanSlowness.Value = e.Value;
                    break;
                case "Void Ghost Leviathan Health":
                    voidGhostLeviathanHealth.Value = e.Value;
                    break;
                case "Void Ghost Leviathan Limit":
                    voidGhostLeviathanLimit.Value = e.Value;
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
                case "Sea Emporer Baby Scale":
                    seaEmporerBabyScale.Value = e.Value;
                    break;
                case "Sea Emporer Baby Slowness":
                    seaEmporerBabySlowness.Value = e.Value;
                    break;
                case "Sea Emporer Baby Health":
                    seaEmporerBabyHealth.Value = e.Value;
                    break;
                case "Sea Emporer Baby Limit":
                    seaEmporerBabyLimit.Value = e.Value;
                    break;
                case "Sea Emporer Juvenile Scale":
                    seaEmporerJuvenileScale.Value = e.Value;
                    break;
                case "Sea Emporer Juvenile Slowness":
                    seaEmporerJuvenileSlowness.Value = e.Value;
                    break;
                case "Sea Emporer Juvenile Health":
                    seaEmporerJuvenileHealth.Value = e.Value;
                    break;
                case "Sea Emporer Juvenile Limit":
                    seaEmporerJuvenileLimit.Value = e.Value;
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
        public static ConfigEntry<float> peeperScale;
        public static ConfigEntry<float> peeperSlowness;
        public static ConfigEntry<float> peeperHealth;
        public static ConfigEntry<float> peeperLimit;
        public static ConfigEntry<float> arrowRayScale;
        public static ConfigEntry<float> arrowRaySlowness;
        public static ConfigEntry<float> arrowRayHealth;
        public static ConfigEntry<float> arrowRayLimit;
        public static ConfigEntry<float> boomerangScale;
        public static ConfigEntry<float> boomerangSlowness;
        public static ConfigEntry<float> boomerangHealth;
        public static ConfigEntry<float> boomerangLimit;
        public static ConfigEntry<float> bladderFishScale;
        public static ConfigEntry<float> bladderFishSlowness;
        public static ConfigEntry<float> bladderFishHealth;
        public static ConfigEntry<float> bladderFishLimit;
        public static ConfigEntry<float> hoopFishScale;
        public static ConfigEntry<float> hoopFishSlowness;
        public static ConfigEntry<float> hoopFishHealth;
        public static ConfigEntry<float> hoopFishLimit;
        public static ConfigEntry<float> discusFishScale;
        public static ConfigEntry<float> discusFishSlowness;
        public static ConfigEntry<float> discusFishHealth;
        public static ConfigEntry<float> discusFishLimit;
        public static ConfigEntry<float> featherFishScale;
        public static ConfigEntry<float> featherFishSlowness;
        public static ConfigEntry<float> featherFishHealth;
        public static ConfigEntry<float> featherFishLimit;
        public static ConfigEntry<float> nootFishScale;
        public static ConfigEntry<float> nootFishSlowness;
        public static ConfigEntry<float> nootFishHealth;
        public static ConfigEntry<float> nootFishLimit;
        //public static ConfigEntry<float> spineFishScale; // Spine fish reference not working. Will enable once I figure out how to reference.
        //public static ConfigEntry<float> spineFishSlowness; // Spine fish reference not working. Will enable once I figure out how to reference.
        //public static ConfigEntry<float> spineFishLimit;
        public static ConfigEntry<float> spinnerFishScale;
        public static ConfigEntry<float> spinnerFishSlowness;
        public static ConfigEntry<float> spinnerFishHealth;
        public static ConfigEntry<float> spinnerFishLimit;
        public static ConfigEntry<float> arcticRayScale;
        public static ConfigEntry<float> arcticRaySlowness;
        public static ConfigEntry<float> arcticRayHealth;
        public static ConfigEntry<float> arcticRayLimit;
        public static ConfigEntry<float> jellyFishScale;
        public static ConfigEntry<float> jellyFishSlowness;
        public static ConfigEntry<float> jellyFishHealth;
        public static ConfigEntry<float> jellyFishLimit;
        public static ConfigEntry<float> titanHoleFishScale;
        public static ConfigEntry<float> titanHoleFishSlowness;
        public static ConfigEntry<float> titanHoleFishHealth;
        public static ConfigEntry<float> titanHoleFishLimit;
        public static ConfigEntry<float> glowWhaleScale;
        public static ConfigEntry<float> glowWhaleSlowness;
        public static ConfigEntry<float> glowWhaleHealth;
        public static ConfigEntry<float> glowWhaleLimit;
        public static ConfigEntry<float> pinnacaridScale;
        public static ConfigEntry<float> pinnacaridSlowness;
        public static ConfigEntry<float> pinnacaridHealth;
        public static ConfigEntry<float> pinnacaridLimit;
        public static ConfigEntry<float> triopsScale;
        public static ConfigEntry<float> triopsSlowness;
        public static ConfigEntry<float> triopsHealth;
        public static ConfigEntry<float> triopsLimit;
        public static ConfigEntry<float> trivalveScale;
        public static ConfigEntry<float> trivalveSlowness;
        public static ConfigEntry<float> trivalveHealth;
        public static ConfigEntry<float> trivalveLimit;
        public static ConfigEntry<float> symbioteFishScale;
        public static ConfigEntry<float> symbioteFishSlowness;
        public static ConfigEntry<float> symbioteFishHealth;
        public static ConfigEntry<float> symbioteFishLimit;
        public static ConfigEntry<float> rockGrubScale;
        public static ConfigEntry<float> rockGrubSlowness;
        public static ConfigEntry<float> rockGrubHealth;
        public static ConfigEntry<float> rockGrubLimit;
        public static ConfigEntry<float> crashFishScale;
        public static ConfigEntry<float> crashFishSlowness;
        public static ConfigEntry<float> crashFishHealth;
        public static ConfigEntry<float> crashFishLimit;
        public static ConfigEntry<float> brineWingScale;
        public static ConfigEntry<float> brineWingSlowness;
        public static ConfigEntry<float> brineWingHealth;
        public static ConfigEntry<float> brineWingLimit;
        public static ConfigEntry<float> lilyPaddlerScale;
        public static ConfigEntry<float> lilyPaddlerSlowness;
        public static ConfigEntry<float> lilyPaddlerHealth;
        public static ConfigEntry<float> lilyPaddlerLimit;
        public static ConfigEntry<float> cryptosuchusScale;
        public static ConfigEntry<float> cryptosuchusSlowness;
        public static ConfigEntry<float> cryptosuchusHealth;
        public static ConfigEntry<float> cryptosuchusLimit;
        public static ConfigEntry<float> bruteSharkScale;
        public static ConfigEntry<float> bruteSharkSlowness;
        public static ConfigEntry<float> bruteSharkHealth;
        public static ConfigEntry<float> bruteSharkLimit;
        public static ConfigEntry<float> squidSharkScale;
        public static ConfigEntry<float> squidSharkSlowness;
        public static ConfigEntry<float> squidSharkHealth;
        public static ConfigEntry<float> squidSharkLimit;
        public static ConfigEntry<float> chelicerateScale;
        public static ConfigEntry<float> chelicerateSlowness;
        public static ConfigEntry<float> chelicerateHealth;
        public static ConfigEntry<float> chelicerateLimit;
        public static ConfigEntry<float> shadowLeviathanScale;
        public static ConfigEntry<float> shadowLeviathanSlowness;
        public static ConfigEntry<float> shadowLeviathanHealth;
        public static ConfigEntry<float> shadowLeviathanLimit;
        public static ConfigEntry<float> voidLeviathanScale;
        public static ConfigEntry<float> voidLeviathanSlowness;
        public static ConfigEntry<float> voidLeviathanHealth;
        public static ConfigEntry<float> voidLeviathanLimit;
        public static ConfigEntry<float> skyRayScale;
        public static ConfigEntry<float> skyRaySlowness;
        public static ConfigEntry<float> skyRayHealth;
        public static ConfigEntry<float> skyRayLimit;
        public static ConfigEntry<float> penglingScale;
        public static ConfigEntry<float> penglingSlowness;
        public static ConfigEntry<float> penglingHealth;
        public static ConfigEntry<float> penglingLimit;
        public static ConfigEntry<float> pengwingScale;
        public static ConfigEntry<float> pengwingSlowness;
        public static ConfigEntry<float> pengwingHealth;
        public static ConfigEntry<float> pengwingLimit;
        public static ConfigEntry<float> seaMonkeyBabyScale;
        public static ConfigEntry<float> seaMonkeyBabySlowness;
        public static ConfigEntry<float> seaMonkeyBabyHealth;
        public static ConfigEntry<float> seaMonkeyBabyLimit;
        public static ConfigEntry<float> seaMonkeyScale;
        public static ConfigEntry<float> seaMonkeySlowness;
        public static ConfigEntry<float> seaMonkeyHealth;
        public static ConfigEntry<float> seaMonkeyLimit;
        public static ConfigEntry<float> snowStalkerBabyScale;
        public static ConfigEntry<float> snowStalkerBabySlowness;
        public static ConfigEntry<float> snowStalkerBabyHealth;
        public static ConfigEntry<float> snowStalkerBabyLimit;
        public static ConfigEntry<float> snowStalkerScale;
        public static ConfigEntry<float> snowStalkerSlowness;
        public static ConfigEntry<float> snowStalkerHealth;
        public static ConfigEntry<float> snowStalkerLimit;
        public static ConfigEntry<float> rockPuncherScale;
        public static ConfigEntry<float> rockPuncherSlowness;
        public static ConfigEntry<float> rockPuncherHealth;
        public static ConfigEntry<float> rockPuncherLimit;
        public static ConfigEntry<float> smallVentGardenScale;
        public static ConfigEntry<float> largeVentGardenScale;
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

            ModSliderOption smallVentGardenScaleOption = smallVentGardenScale.ToModSliderOption(1, 50);
            smallVentGardenScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(smallVentGardenScaleOption);

            ModSliderOption largeVentGardenScaleOption = largeVentGardenScale.ToModSliderOption(1, 50);
            largeVentGardenScaleOption.OnChanged += SliderOptionsChanged;
            AddItem(largeVentGardenScaleOption);

            // Spine fish reference not working, will enable once reference is figured out.
            //ModSliderOption spineFishScaleOption = spineFishScale.ToModSliderOption(1, 30);
            //spineFishScaleOption.OnChanged += SliderOptionsChanged;
            //AddItem(spineFishScaleOption);

            //ModSliderOption spineFishSlownessOption = spineFishSlowness.ToModSliderOption(1, 10);
            //spineFishSlownessOption.OnChanged += SliderOptionsChanged;
            //AddItem(spineFishSlownessOption);

            OptionsPanelHandler.RegisterModOptions(this);
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
                // Spine fish not working atm.
                //case "Spinefish Scale":
                //    spineFishScale.Value = e.Value;
                //    break;
                //case "Spinefish Slowness":
                //    spineFishSlowness.Value = e.Value;
                //    break;
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
                case "Small Ventgarden Scale":
                    smallVentGardenScale.Value = e.Value;
                    break;
                case "Large Ventgarden Scale":
                    largeVentGardenScale.Value = e.Value;
                    break;
            }
        }
    }
#endif
}