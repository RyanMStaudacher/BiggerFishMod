using HarmonyLib;
using UnityEngine;
using static UnityEngine.PostProcessing.BuiltinDebugViewsComponent;

namespace BiggerFishMod
{
#if SUBNAUTICA
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    internal class CreatureSizePatch
    {
        [HarmonyPostfix]
        public static void OnEnablePostfix(Creature __instance)
        {
            if (__instance is Biter biter)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.biterExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.biterScale.Value;
                }

                biter.SetScale(sizeScale);
            }

            else if (__instance is Bladderfish bladderFish)
            {
                float sizeScale = 4.0f;

                if(MyModOptions.bladderFishExclude.Value)
                {
                    if(MyModOptions.bladderFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.bladderFishRandomizeMin.Value, MyModOptions.bladderFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.bladderFishScale.Value;
                    }
                }
                else
                {
                    if(MyModOptions.proportionalToggle.Value)
                    {
                        sizeScale = MyModOptions.proportionalScale.Value;
                    }
                    else
                    {
                        if(MyModOptions.bladderFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.bladderFishRandomizeMin.Value, MyModOptions.bladderFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.bladderFishScale.Value;
                        }
                    }
                }

                //if (MyModOptions.proportionalToggle.Value == true && MyModOptions.bladderFishExclude.Value == false)
                //{
                    
                //}
                //else if(MyModOptions.proportionalToggle.Value == false && MyModOptions.bladderFishRandomize.Value == true)
                //{
                    
                //}
                //else
                //{
                    
                //}

                bladderFish.SetScale(sizeScale);
            }

            else if (__instance is Bleeder bleeder)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.bleederExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.bleederScale.Value;
                }

                bleeder.SetScale(sizeScale);
            }

            else if (__instance is BoneShark boneShark)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.boneSharkExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.boneSharkScale.Value;
                }

                boneShark.SetScale(sizeScale);
            }

            else if (__instance is Boomerang boomerang)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.boomerangExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.boomerangScale.Value;
                }

                boomerang.SetScale(sizeScale);
            }

            else if (__instance is CaveCrawler caveCrawler)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.caveCrawlerExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.caveCrawlerScale.Value;
                }

                caveCrawler.SetScale(sizeScale);
            }

            else if (__instance is CrabSnake crabSnake)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.crabSnakeExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.crabSnakeScale.Value;
                }

                crabSnake.SetScale(sizeScale);
            }

            else if (__instance is CrabSquid crabSquid)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.crabSquidExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.crabSquidScale.Value;
                }

                crabSquid.SetScale(sizeScale);
            }

            else if (__instance is Crash crashFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.crashFishExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.crashFishScale.Value;
                }

                crashFish.SetScale(sizeScale);
            }

            else if (__instance is CuteFish cuddleFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.cuddleFishExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.cuddleFishScale.Value;
                }

                cuddleFish.SetScale(sizeScale);
            }

            else if (__instance is Eyeye eyeye)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.eyeyeExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.eyeyeScale.Value;
                }

                eyeye.SetScale(sizeScale);
            }

            else if (__instance is Garryfish garryFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.garryFishExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.garryFishScale.Value;
                }

                garryFish.SetScale(sizeScale);
            }

            else if (__instance is GasoPod gasopod)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.gasopodExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.gasopodScale.Value;
                }

                gasopod.SetScale(sizeScale);
            }

            else if (__instance is GhostLeviatanVoid voidGhostLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.voidGhostLeviathanExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.voidGhostLeviathanScale.Value;
                }

                voidGhostLeviathan.SetScale(sizeScale);
            }

            else if (__instance is GhostLeviathan ghostLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.ghostLeviathanExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.ghostLeviathanScale.Value;
                }

                ghostLeviathan.SetScale(sizeScale);
            }

            else if (__instance is GhostRay ghostRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.ghostRayExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.ghostRayScale.Value;
                }

                ghostRay.SetScale(sizeScale);
            }

            else if (__instance is Holefish holeFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.holeFishExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.holeFishScale.Value;
                }

                holeFish.SetScale(sizeScale);
            }

            else if (__instance is Hoopfish hoopFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.hoopFishExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.hoopFishScale.Value;
                }

                hoopFish.SetScale(sizeScale);
            }

            else if (__instance is Hoverfish hoverFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.hoverFishExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.hoverFishScale.Value;
                }

                hoverFish.SetScale(sizeScale);
            }

            else if (__instance is Jellyray jellyRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.jellyRayExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.jellyRayScale.Value;
                }

                jellyRay.SetScale(sizeScale);
            }

            else if (__instance is Jumper jumper)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.jumperExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.jumperScale.Value;
                }

                jumper.SetScale(sizeScale);
            }

            else if (__instance is LavaLarva lavaLarva)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.lavaLarvaExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.lavaLarvaScale.Value;
                }

                lavaLarva.SetScale(sizeScale);
            }

            else if (__instance is LavaLizard lavaLizard)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.lavaLizardExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.lavaLizardScale.Value;
                }

                lavaLizard.SetScale(sizeScale);
            }

            else if (__instance is Mesmer mesmer)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.mesmerExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.mesmerScale.Value;
                }

                mesmer.SetScale(sizeScale);
            }

            else if (__instance is OculusFish oculus)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.oculusFishExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.oculusFishScale.Value;
                }

                oculus.SetScale(sizeScale);
            }

            else if (__instance is Peeper peeper)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.peeperExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.peeperScale.Value;
                }

                peeper.SetScale(sizeScale);
            }

            else if (__instance is RabbitRay rabbitRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.rabbitRayExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.rabbitRayScale.Value;
                }

                rabbitRay.SetScale(sizeScale);
            }

            else if (__instance is ReaperLeviathan reaperLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.reaperLeviathanExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.reaperLeviathanScale.Value;
                }

                reaperLeviathan.SetScale(sizeScale);
            }

            else if (__instance is Reefback reefback)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.reefbackExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.reefbackScale.Value;
                }

                reefback.SetScale(sizeScale);
            }

            else if (__instance is Reginald reginald)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.reginaldExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.reginaldScale.Value;
                }

                reginald.SetScale(sizeScale);
            }

            //else if (__instance is RockGrub rockGrub)
            //{
            //    float sizeScale = 4.0f;

            //    if (MyModOptions.proportionalToggle.Value == true && MyModOptions.rockGrubExclude.Value == false)
            //    {
            //        sizeScale = MyModOptions.proportionalScale.Value;
            //    }
            //    else
            //    {
            //        sizeScale = MyModOptions.rockGrubScale.Value;
            //    }

            //    rockGrub.SetScale(sizeScale);
            //}

            else if (__instance is SandShark sandShark)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.sandSharkExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.sandSharkScale.Value;
                }

                sandShark.SetScale(sizeScale);
            }

            else if (__instance is SeaDragon seaDragon)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.seaDragonExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.seaDragonScale.Value;
                }

                seaDragon.SetScale(sizeScale);
            }

            else if (__instance is SeaEmperorBaby seaEmperorBaby)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.seaEmperorBabyExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.seaEmperorBabyScale.Value;
                }

                seaEmperorBaby.SetScale(sizeScale);
            }

            else if (__instance is SeaEmperorJuvenile seaEmperorJuvenile)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.seaEmperorJuvenileExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.seaEmperorJuvenileScale.Value;
                }

                seaEmperorJuvenile.SetScale(sizeScale);
            }

            else if (__instance is SeaTreader seaTreader)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.seaTreaderExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.seaTreaderScale.Value;
                }

                seaTreader.SetScale(sizeScale);
            }

            else if (__instance is Shocker shocker)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.shockerExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.shockerScale.Value;
                }

                shocker.SetScale(sizeScale);
            }

            else if (__instance is Skyray skyRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.skyRayExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.skyRayScale.Value;
                }

                skyRay.SetScale(sizeScale);
            }

            else if (__instance is Spadefish spadeFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.spadeFishExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.spadeFishScale.Value;
                }

                spadeFish.SetScale(sizeScale);
            }

            else if (__instance is SpineEel spineEel)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.spineEelExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.spineEelScale.Value;
                }

                spineEel.SetScale(sizeScale);
            }

            else if (__instance is Stalker stalker)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.stalkerExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.stalkerScale.Value;
                }

                stalker.SetScale(sizeScale);
            }

            else if (__instance is Warper warper)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true && MyModOptions.warperExclude.Value == false)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.warperScale.Value;
                }

                warper.SetScale(sizeScale);
            }
        }
    }

    [HarmonyPatch(typeof(VFXSchoolFish), nameof(VFXSchoolFish.OnEnable))]
    public class VFXSchoolPatch
    {
        [HarmonyPatch(typeof(VFXSchoolFish), nameof(VFXSchoolFish.OnEnable))]
        public class VFXSchoolFishPatch
        {
            [HarmonyPostfix]
            public static void SchoolFishPostfix(VFXSchoolFish __instance)
            {
                if (__instance is VFXSchoolFish schoolFish)
                {
                    if (MyModOptions.removeFishSchools.Value)
                    {
                        schoolFish.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
#endif

#if SUBNAUTICAZERO
    [HarmonyPatch(typeof(Creature), nameof(Creature.OnEnable))]
    public class CreatureSizePatch
    {
        [HarmonyPostfix]
        public static void OnEnableSizePostfix(Creature __instance)
        {
            #region Passive Fish
            if (__instance is ArcticPeeper arcticPeeper)
            {
                float sizeScale = 4.0f;

                if(MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.arcticPeeperScale.Value;
                }

                arcticPeeper.SetScale(sizeScale);
            }

            else if (__instance is ArrowRay arrowRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.arrowRayScale.Value;
                }

                arrowRay.SetScale(sizeScale);
            }

            else if (__instance is Boomerang boomerang)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.boomerangScale.Value;
                }

                boomerang.SetScale(sizeScale);
            }

            else if (__instance is Bladderfish bladderFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.bladderFishScale.Value;
                }

                bladderFish.SetScale(sizeScale);
            }

            else if (__instance is Hoopfish hoopFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.hoopFishScale.Value;
                }

                hoopFish.SetScale(sizeScale);
            }

            else if (__instance is DiscusFish discusFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.discusFishScale.Value;
                }

                discusFish.SetScale(sizeScale);
            }

            else if (__instance is FeatherFish featherFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.featherFishScale.Value;
                }

                featherFish.SetScale(sizeScale);
            }

            else if (__instance is NootFish nootFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.nootFishScale.Value;
                }

                nootFish.SetScale(sizeScale);
            }

            else if (__instance is SpinnerFish spinnerFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.spinnerFishScale.Value;
                }

                spinnerFish.SetScale(sizeScale);
            }

            else if (__instance is ArcticRay arcticRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.arcticRayScale.Value;
                }

                arcticRay.SetScale(sizeScale);
            }

            else if (__instance is Jellyfish eyeJelly)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.jellyFishScale.Value;
                }

                eyeJelly.SetScale(sizeScale);
            }

            else if (__instance is TitanHolefish titanHolefish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.titanHoleFishScale.Value;
                }

                titanHolefish.SetScale(sizeScale);
            }

            else if (__instance is GlowWhale glowWhale)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.glowWhaleScale.Value;
                }

                glowWhale.SetScale(sizeScale);
            }

            else if (__instance is Pinnacarid pinnacarid)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.pinnacaridScale.Value;
                }

                pinnacarid.SetScale(sizeScale);
            }

            else if (__instance is Triops triops)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.triopsScale.Value;
                }

                triops.SetScale(sizeScale);
            }

            else if (__instance is Trivalve trivalve)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.trivalveScale.Value;
                }

                trivalve.SetScale(sizeScale);
            }

            else if (__instance is SymbioteFish symbioteFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.symbioteFishScale.Value;
                }

                symbioteFish.SetScale(sizeScale);
            }

            else if (__instance is RockGrub rockGrub)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.rockGrubScale.Value;
                }

                rockGrub.SetScale(sizeScale);
            }
            #endregion

            #region Aggressive Fish
            else if (__instance is Crash crashFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.crashFishScale.Value;
                }

                crashFish.SetScale(sizeScale);
            }

            else if (__instance is Brinewing brinewing)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.brineWingScale.Value;
                }

                brinewing.SetScale(sizeScale);
            }

            else if (__instance is LilyPaddler lilyPaddler)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.lilyPaddlerScale.Value;
                }

                lilyPaddler.SetScale(sizeScale);
            }

            else if (__instance is Cryptosuchus cryptosuchus)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.cryptosuchusScale.Value;
                }

                cryptosuchus.SetScale(sizeScale);
            }

            else if (__instance is BruteShark bruteShark)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.bruteSharkScale.Value;
                }

                bruteShark.SetScale(sizeScale);
            }

            else if (__instance is SquidShark squidShark)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.squidSharkScale.Value;
                }

                squidShark.SetScale(sizeScale);
            }

            else if (__instance is Chelicerate chelicerate)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.chelicerateScale.Value;
                }

                chelicerate.SetScale(sizeScale);
            }

            else if (__instance is ShadowLeviathan shadowLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.shadowLeviathanScale.Value;
                }

                shadowLeviathan.SetScale(sizeScale);
            }

            else if (__instance is VoidLeviathan voidLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.voidLeviathanScale.Value;
                }

                voidLeviathan.SetScale(sizeScale);
            }
            #endregion

            #region Not Fish
            else if (__instance is Skyray skyRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.skyRayScale.Value;
                }

                skyRay.SetScale(sizeScale);
            }

            else if (__instance is PenguinBaby pengling)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.penglingScale.Value;
                }

                pengling.SetScale(sizeScale);
            }

            else if (__instance is Penguin pengwing)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.pengwingScale.Value;
                }

                pengwing.SetScale(sizeScale);
            }

            else if (__instance is SeaMonkeyBaby seaMonkeyBaby)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.seaMonkeyBabyScale.Value;
                }

                seaMonkeyBaby.SetScale(sizeScale);
            }

            else if (__instance is SeaMonkey seaMonkey)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.seaMonkeyScale.Value;
                }

                seaMonkey.SetScale(sizeScale);
            }

            else if (__instance is SnowStalkerBaby snowStalkerBaby)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.snowStalkerBabyScale.Value;
                }

                snowStalkerBaby.SetScale(sizeScale);
            }

            else if (__instance is SnowStalker snowStalker)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.snowStalkerScale.Value;
                }

                snowStalker.SetScale(sizeScale);
            }

            else if (__instance is RockPuncher rockPuncher)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.proportionalToggle.Value == true)
                {
                    sizeScale = MyModOptions.proportionalScale.Value;
                }
                else
                {
                    sizeScale = MyModOptions.rockPuncherScale.Value;
                }

                rockPuncher.SetScale(sizeScale);
            }
            #endregion
        }
    }

    [HarmonyPatch(typeof(VentGardenSmall), nameof(VentGardenSmall.OnEnable))]
    public class VentGardenSmallPatch
    {
        [HarmonyPostfix]
        public static void VentGardenScale(VentGardenSmall __instance)
        {
            if (__instance is VentGardenSmall smollVent)
            {
                smollVent.gameObject.transform.localScale = new Vector3(MyModOptions.smallVentGardenScale.Value, MyModOptions.smallVentGardenScale.Value, MyModOptions.smallVentGardenScale.Value);
            }
        }
    }

    [HarmonyPatch(typeof(VentGardenLarge), nameof(VentGardenLarge.OnEnable))]
    public class VentGardenLargePatch
    {
        [HarmonyPostfix]
        public static void VentGardenScale(VentGardenLarge __instance)
        {
            if (__instance is VentGardenLarge bigVent)
            {
                bigVent.gameObject.transform.localScale = new Vector3(MyModOptions.largeVentGardenScale.Value, MyModOptions.largeVentGardenScale.Value, MyModOptions.largeVentGardenScale.Value);
            }
        }
    }

    [HarmonyPatch(typeof(VFXSchoolFish), nameof(VFXSchoolFish.OnEnable))]
    public class VFXSchoolFishPatch
    {
        [HarmonyPostfix]
        public static void SchoolFishPostfix(VFXSchoolFish __instance)
        {
            if (__instance is VFXSchoolFish schoolFish)
            {
                if(MyModOptions.removeFishSchools.Value)
                {
                    schoolFish.gameObject.SetActive(false);
                }
            }
        }
    }
#endif
}
