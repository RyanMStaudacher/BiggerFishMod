using HarmonyLib;
using UnityEngine;

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

                if (MyModOptions.biterExclude.Value)
                {
                    if (MyModOptions.biterRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.biterRandomizeMin.Value, MyModOptions.biterRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.biterScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if(MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.biterRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.biterRandomizeMin.Value, MyModOptions.biterRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.biterScale.Value;
                        }
                    }
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
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
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

                bladderFish.SetScale(sizeScale);
            }

            else if (__instance is Bleeder bleeder)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.bleederExclude.Value)
                {
                    if (MyModOptions.bleederRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.bleederRandomizeMin.Value, MyModOptions.bleederRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.bleederScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.bleederRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.bleederRandomizeMin.Value, MyModOptions.bleederRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.bleederScale.Value;
                        }
                    }
                }

                bleeder.SetScale(sizeScale);
            }

            else if (__instance is BoneShark boneShark)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.boneSharkExclude.Value)
                {
                    if (MyModOptions.boneSharkRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.boneSharkRandomizeMin.Value, MyModOptions.boneSharkRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.boneSharkScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.boneSharkRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.boneSharkRandomizeMin.Value, MyModOptions.boneSharkRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.boneSharkScale.Value;
                        }
                    }
                }

                boneShark.SetScale(sizeScale);
            }

            else if (__instance is Boomerang boomerang)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.boomerangExclude.Value)
                {
                    if (MyModOptions.boomerangRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.boomerangRandomizeMin.Value, MyModOptions.boomerangRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.boomerangScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.boomerangRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.boomerangRandomizeMin.Value, MyModOptions.boomerangRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.boomerangScale.Value;
                        }
                    }
                }

                boomerang.SetScale(sizeScale);
            }

            else if (__instance is CaveCrawler caveCrawler)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.caveCrawlerExclude.Value)
                {
                    if (MyModOptions.caveCrawlerRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.caveCrawlerRandomizeMin.Value, MyModOptions.caveCrawlerRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.caveCrawlerScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.caveCrawlerRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.caveCrawlerRandomizeMin.Value, MyModOptions.caveCrawlerRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.caveCrawlerScale.Value;
                        }
                    }
                }

                caveCrawler.SetScale(sizeScale);
            }

            else if (__instance is CrabSnake crabSnake)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.crabSnakeExclude.Value)
                {
                    if (MyModOptions.crabSnakeRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.crabSnakeRandomizeMin.Value, MyModOptions.crabSnakeRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.crabSnakeScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.crabSnakeRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.crabSnakeRandomizeMin.Value, MyModOptions.crabSnakeRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.crabSnakeScale.Value;
                        }
                    }
                }

                crabSnake.SetScale(sizeScale);
            }

            else if (__instance is CrabSquid crabSquid)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.crabSquidExclude.Value)
                {
                    if (MyModOptions.crabSquidRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.crabSquidRandomizeMin.Value, MyModOptions.crabSquidRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.crabSquidScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.crabSquidRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.crabSquidRandomizeMin.Value, MyModOptions.crabSquidRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.crabSquidScale.Value;
                        }
                    }
                }

                crabSquid.SetScale(sizeScale);
            }

            else if (__instance is Crash crashFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.crashFishExclude.Value)
                {
                    if (MyModOptions.crashFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.crashFishRandomizeMin.Value, MyModOptions.crashFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.crashFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.crashFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.crashFishRandomizeMin.Value, MyModOptions.crashFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.crashFishScale.Value;
                        }
                    }
                }

                crashFish.SetScale(sizeScale);
            }

            else if (__instance is CuteFish cuddleFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.cuddleFishExclude.Value)
                {
                    if (MyModOptions.cuddleFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.cuddleFishRandomizeMin.Value, MyModOptions.cuddleFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.cuddleFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.cuddleFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.cuddleFishRandomizeMin.Value, MyModOptions.cuddleFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.cuddleFishScale.Value;
                        }
                    }
                }

                cuddleFish.SetScale(sizeScale);
            }

            else if (__instance is Eyeye eyeye)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.eyeyeExclude.Value)
                {
                    if (MyModOptions.eyeyeRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.eyeyeRandomizeMin.Value, MyModOptions.eyeyeRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.eyeyeScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.eyeyeRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.eyeyeRandomizeMin.Value, MyModOptions.eyeyeRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.eyeyeScale.Value;
                        }
                    }
                }

                eyeye.SetScale(sizeScale);
            }

            else if (__instance is Garryfish garryFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.garryFishExclude.Value)
                {
                    if (MyModOptions.garryFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.garryFishRandomizeMin.Value, MyModOptions.garryFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.garryFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.garryFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.garryFishRandomizeMin.Value, MyModOptions.garryFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.garryFishScale.Value;
                        }
                    }
                }

                garryFish.SetScale(sizeScale);
            }

            else if (__instance is GasoPod gasopod)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.gasopodExclude.Value)
                {
                    if (MyModOptions.gasopodRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.gasopodRandomizeMin.Value, MyModOptions.gasopodRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.gasopodScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.gasopodRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.gasopodRandomizeMin.Value, MyModOptions.gasopodRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.gasopodScale.Value;
                        }
                    }
                }

                gasopod.SetScale(sizeScale);
            }

            else if (__instance is GhostLeviatanVoid voidGhostLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.voidGhostLeviathanExclude.Value)
                {
                    if (MyModOptions.voidGhostLeviathanRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.voidGhostLeviathanRandomizeMin.Value, MyModOptions.voidGhostLeviathanRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.voidGhostLeviathanScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.voidGhostLeviathanRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.voidGhostLeviathanRandomizeMin.Value, MyModOptions.voidGhostLeviathanRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.voidGhostLeviathanScale.Value;
                        }
                    }
                }

                voidGhostLeviathan.SetScale(sizeScale);
            }

            else if (__instance is GhostLeviathan ghostLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.ghostLeviathanExclude.Value)
                {
                    if (MyModOptions.ghostLeviathanRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.ghostLeviathanRandomizeMin.Value, MyModOptions.ghostLeviathanRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.ghostLeviathanScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.ghostLeviathanRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.ghostLeviathanRandomizeMin.Value, MyModOptions.ghostLeviathanRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.ghostLeviathanScale.Value;
                        }
                    }
                }

                ghostLeviathan.SetScale(sizeScale);
            }

            else if (__instance is GhostRay ghostRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.ghostRayExclude.Value)
                {
                    if (MyModOptions.ghostRayRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.ghostRayRandomizeMin.Value, MyModOptions.ghostRayRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.ghostRayScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.ghostRayRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.ghostRayRandomizeMin.Value, MyModOptions.ghostRayRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.ghostRayScale.Value;
                        }
                    }
                }

                ghostRay.SetScale(sizeScale);
            }

            else if (__instance is Holefish holeFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.holeFishExclude.Value)
                {
                    if (MyModOptions.holeFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.holeFishRandomizeMin.Value, MyModOptions.holeFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.holeFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.holeFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.holeFishRandomizeMin.Value, MyModOptions.holeFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.holeFishScale.Value;
                        }
                    }
                }

                holeFish.SetScale(sizeScale);
            }

            else if (__instance is Hoopfish hoopFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.hoopFishExclude.Value)
                {
                    if (MyModOptions.hoopFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.hoopFishRandomizeMin.Value, MyModOptions.hoopFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.hoopFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.hoopFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.hoopFishRandomizeMin.Value, MyModOptions.hoopFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.hoopFishScale.Value;
                        }
                    }
                }

                hoopFish.SetScale(sizeScale);
            }

            else if (__instance is Hoverfish hoverFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.hoverFishExclude.Value)
                {
                    if (MyModOptions.hoverFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.hoverFishRandomizeMin.Value, MyModOptions.hoverFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.hoverFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.hoverFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.hoverFishRandomizeMin.Value, MyModOptions.hoverFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.hoverFishScale.Value;
                        }
                    }
                }

                hoverFish.SetScale(sizeScale);
            }

            else if (__instance is Jellyray jellyRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.jellyRayExclude.Value)
                {
                    if (MyModOptions.jellyRayRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.jellyRayRandomizeMin.Value, MyModOptions.jellyRayRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.jellyRayScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.jellyRayRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.jellyRayRandomizeMin.Value, MyModOptions.jellyRayRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.jellyRayScale.Value;
                        }
                    }
                }

                jellyRay.SetScale(sizeScale);
            }

            else if (__instance is Jumper jumper)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.jumperExclude.Value)
                {
                    if (MyModOptions.jumperRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.jumperRandomizeMin.Value, MyModOptions.jumperRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.jumperScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.jumperRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.jumperRandomizeMin.Value, MyModOptions.jumperRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.jumperScale.Value;
                        }
                    }
                }

                jumper.SetScale(sizeScale);
            }

            else if (__instance is LavaLarva lavaLarva)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.lavaLarvaExclude.Value)
                {
                    if (MyModOptions.lavaLarvaRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.lavaLarvaRandomizeMin.Value, MyModOptions.lavaLarvaRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.lavaLarvaScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.lavaLarvaRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.lavaLarvaRandomizeMin.Value, MyModOptions.lavaLarvaRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.lavaLarvaScale.Value;
                        }
                    }
                }

                lavaLarva.SetScale(sizeScale);
            }

            else if (__instance is LavaLizard lavaLizard)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.lavaLizardExclude.Value)
                {
                    if (MyModOptions.lavaLizardRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.lavaLizardRandomizeMin.Value, MyModOptions.lavaLizardRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.lavaLizardScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.lavaLizardRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.lavaLizardRandomizeMin.Value, MyModOptions.lavaLizardRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.lavaLizardScale.Value;
                        }
                    }
                }

                lavaLizard.SetScale(sizeScale);
            }

            else if (__instance is Mesmer mesmer)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.mesmerExclude.Value)
                {
                    if (MyModOptions.mesmerRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.mesmerRandomizeMin.Value, MyModOptions.mesmerRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.mesmerScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.mesmerRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.mesmerRandomizeMin.Value, MyModOptions.mesmerRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.mesmerScale.Value;
                        }
                    }
                }

                mesmer.SetScale(sizeScale);
            }

            else if (__instance is OculusFish oculus)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.oculusFishExclude.Value)
                {
                    if (MyModOptions.oculusFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.oculusFishRandomizeMin.Value, MyModOptions.oculusFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.oculusFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.oculusFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.oculusFishRandomizeMin.Value, MyModOptions.oculusFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.oculusFishScale.Value;
                        }
                    }
                }

                oculus.SetScale(sizeScale);
            }

            else if (__instance is Peeper peeper)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.peeperExclude.Value)
                {
                    if (MyModOptions.peeperRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.peeperRandomizeMin.Value, MyModOptions.peeperRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.peeperScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.peeperRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.peeperRandomizeMin.Value, MyModOptions.peeperRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.peeperScale.Value;
                        }
                    }
                }

                peeper.SetScale(sizeScale);
            }

            else if (__instance is RabbitRay rabbitRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.rabbitRayExclude.Value)
                {
                    if (MyModOptions.rabbitRayRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.rabbitRayRandomizeMin.Value, MyModOptions.rabbitRayRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.rabbitRayScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.rabbitRayRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.rabbitRayRandomizeMin.Value, MyModOptions.rabbitRayRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.rabbitRayScale.Value;
                        }
                    }
                }

                rabbitRay.SetScale(sizeScale);
            }

            else if (__instance is ReaperLeviathan reaperLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.reaperLeviathanExclude.Value)
                {
                    if (MyModOptions.reaperLeviathanRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.reaperLeviathanRandomizeMin.Value, MyModOptions.reaperLeviathanRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.reaperLeviathanScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if(MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.reaperLeviathanRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.reaperLeviathanRandomizeMin.Value, MyModOptions.reaperLeviathanRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.reaperLeviathanScale.Value;
                        }
                    }
                }

                reaperLeviathan.SetScale(sizeScale);
            }

            else if (__instance is Reefback reefback)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.reefbackExclude.Value)
                {
                    if (MyModOptions.reefbackRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.reefbackRandomizeMin.Value, MyModOptions.reefbackRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.reefbackScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.reefbackRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.reefbackRandomizeMin.Value, MyModOptions.reefbackRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.reefbackScale.Value;
                        }
                    }
                }

                reefback.SetScale(sizeScale);
            }

            else if (__instance is Reginald reginald)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.reginaldExclude.Value)
                {
                    if (MyModOptions.reginaldRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.reginaldRandomizeMin.Value, MyModOptions.reginaldRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.reginaldScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.reginaldRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.reginaldRandomizeMin.Value, MyModOptions.reginaldRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.reginaldScale.Value;
                        }
                    }
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

                if (MyModOptions.sandSharkExclude.Value)
                {
                    if (MyModOptions.sandSharkRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.sandSharkRandomizeMin.Value, MyModOptions.sandSharkRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.sandSharkScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.sandSharkRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.sandSharkRandomizeMin.Value, MyModOptions.sandSharkRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.sandSharkScale.Value;
                        }
                    }
                }

                sandShark.SetScale(sizeScale);
            }

            else if (__instance is SeaDragon seaDragon)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.seaDragonExclude.Value)
                {
                    if (MyModOptions.seaDragonRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.seaDragonRandomizeMin.Value, MyModOptions.seaDragonRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.seaDragonScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.seaDragonRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.seaDragonRandomizeMin.Value, MyModOptions.seaDragonRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.seaDragonScale.Value;
                        }
                    }
                }

                seaDragon.SetScale(sizeScale);
            }

            else if (__instance is SeaEmperorBaby seaEmperorBaby)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.seaEmperorBabyExclude.Value)
                {
                    if (MyModOptions.seaEmperorBabyRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.seaEmperorBabyRandomizeMin.Value, MyModOptions.seaEmperorBabyRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.seaEmperorBabyScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.seaEmperorBabyRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.seaEmperorBabyRandomizeMin.Value, MyModOptions.seaEmperorBabyRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.seaEmperorBabyScale.Value;
                        }
                    }
                }

                seaEmperorBaby.SetScale(sizeScale);
            }

            else if (__instance is SeaEmperorJuvenile seaEmperorJuvenile)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.seaEmperorJuvenileExclude.Value)
                {
                    if (MyModOptions.seaEmperorJuvenileRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.seaEmperorJuvenileRandomizeMin.Value, MyModOptions.seaEmperorJuvenileRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.seaEmperorJuvenileScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.seaEmperorJuvenileRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.seaEmperorJuvenileRandomizeMin.Value, MyModOptions.seaEmperorJuvenileRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.seaEmperorJuvenileScale.Value;
                        }
                    }
                }

                seaEmperorJuvenile.SetScale(sizeScale);
            }

            else if (__instance is SeaTreader seaTreader)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.seaTreaderExclude.Value)
                {
                    if (MyModOptions.seaTreaderRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.seaTreaderRandomizeMin.Value, MyModOptions.seaTreaderRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.seaTreaderScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.seaTreaderRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.seaTreaderRandomizeMin.Value, MyModOptions.seaTreaderRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.seaTreaderScale.Value;
                        }
                    }
                }

                seaTreader.SetScale(sizeScale);
            }

            else if (__instance is Shocker shocker)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.shockerExclude.Value)
                {
                    if (MyModOptions.shockerRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.shockerRandomizeMin.Value, MyModOptions.shockerRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.shockerScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.shockerRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.shockerRandomizeMin.Value, MyModOptions.shockerRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.shockerScale.Value;
                        }
                    }
                }

                shocker.SetScale(sizeScale);
            }

            else if (__instance is Skyray skyRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.skyRayExclude.Value)
                {
                    if (MyModOptions.skyRayRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.skyRayRandomizeMin.Value, MyModOptions.skyRayRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.skyRayScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.skyRayRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.skyRayRandomizeMin.Value, MyModOptions.skyRayRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.skyRayScale.Value;
                        }
                    }
                }

                skyRay.SetScale(sizeScale);
            }

            else if (__instance is Spadefish spadeFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.spadeFishExclude.Value)
                {
                    if (MyModOptions.spadeFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.spadeFishRandomizeMin.Value, MyModOptions.spadeFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.spadeFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.spadeFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.spadeFishRandomizeMin.Value, MyModOptions.spadeFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.spadeFishScale.Value;
                        }
                    }
                }

                spadeFish.SetScale(sizeScale);
            }

            else if (__instance is SpineEel spineEel)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.spineEelExclude.Value)
                {
                    if (MyModOptions.spineEelRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.spineEelRandomizeMin.Value, MyModOptions.spineEelRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.spineEelScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.spineEelRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.spineEelRandomizeMin.Value, MyModOptions.spineEelRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.spineEelScale.Value;
                        }
                    }
                }

                spineEel.SetScale(sizeScale);
            }

            else if (__instance is Stalker stalker)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.stalkerExclude.Value)
                {
                    if (MyModOptions.stalkerRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.stalkerRandomizeMin.Value, MyModOptions.stalkerRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.stalkerScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.stalkerRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.stalkerRandomizeMin.Value, MyModOptions.stalkerRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.stalkerScale.Value;
                        }
                    }
                }

                stalker.SetScale(sizeScale);
            }

            else if (__instance is Warper warper)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.warperExclude.Value)
                {
                    if (MyModOptions.warperRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.warperRandomizeMin.Value, MyModOptions.warperRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.warperScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.warperRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.warperRandomizeMin.Value, MyModOptions.warperRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.warperScale.Value;
                        }
                    }
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

                if (MyModOptions.arcticPeeperExclude.Value)
                {
                    if (MyModOptions.arcticPeeperRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.arcticPeeperRandomizeMin.Value, MyModOptions.arcticPeeperRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.arcticPeeperScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.arcticPeeperRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.arcticPeeperRandomizeMin.Value, MyModOptions.arcticPeeperRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.arcticPeeperScale.Value;
                        }
                    }
                }

                arcticPeeper.SetScale(sizeScale);
            }

            else if (__instance is ArrowRay arrowRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.arrowRayExclude.Value)
                {
                    if (MyModOptions.arrowRayRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.arrowRayRandomizeMin.Value, MyModOptions.arrowRayRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.arrowRayScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.arrowRayRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.arrowRayRandomizeMin.Value, MyModOptions.arrowRayRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.arrowRayScale.Value;
                        }
                    }
                }

                arrowRay.SetScale(sizeScale);
            }

            else if (__instance is Boomerang boomerang)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.boomerangExclude.Value)
                {
                    if (MyModOptions.boomerangRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.boomerangRandomizeMin.Value, MyModOptions.boomerangRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.boomerangScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.boomerangRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.boomerangRandomizeMin.Value, MyModOptions.boomerangRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.boomerangScale.Value;
                        }
                    }
                }

                boomerang.SetScale(sizeScale);
            }

            else if (__instance is Bladderfish bladderFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.bladderFishExclude.Value)
                {
                    if (MyModOptions.bladderFishRandomize.Value)
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
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.bladderFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.bladderFishRandomizeMin.Value, MyModOptions.bladderFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.bladderFishScale.Value;
                        }
                    }
                }

                bladderFish.SetScale(sizeScale);
            }

            else if (__instance is Hoopfish hoopFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.hoopFishExclude.Value)
                {
                    if (MyModOptions.hoopFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.hoopFishRandomizeMin.Value, MyModOptions.hoopFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.hoopFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.hoopFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.hoopFishRandomizeMin.Value, MyModOptions.hoopFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.hoopFishScale.Value;
                        }
                    }
                }

                hoopFish.SetScale(sizeScale);
            }

            else if (__instance is DiscusFish discusFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.discusFishExclude.Value)
                {
                    if (MyModOptions.discusFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.discusFishRandomizeMin.Value, MyModOptions.discusFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.discusFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.discusFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.discusFishRandomizeMin.Value, MyModOptions.discusFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.discusFishScale.Value;
                        }
                    }
                }

                discusFish.SetScale(sizeScale);
            }

            else if (__instance is FeatherFish featherFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.featherFishExclude.Value)
                {
                    if (MyModOptions.featherFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.featherFishRandomizeMin.Value, MyModOptions.featherFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.featherFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.featherFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.featherFishRandomizeMin.Value, MyModOptions.featherFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.featherFishScale.Value;
                        }
                    }
                }

                featherFish.SetScale(sizeScale);
            }

            else if (__instance is NootFish nootFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.nootFishExclude.Value)
                {
                    if (MyModOptions.nootFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.nootFishRandomizeMin.Value, MyModOptions.nootFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.nootFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.nootFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.nootFishRandomizeMin.Value, MyModOptions.nootFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.nootFishScale.Value;
                        }
                    }
                }

                nootFish.SetScale(sizeScale);
            }

            else if (__instance is SpinnerFish spinnerFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.spinnerFishExclude.Value)
                {
                    if (MyModOptions.spinnerFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.spinnerFishRandomizeMin.Value, MyModOptions.spinnerFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.spinnerFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.spinnerFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.spinnerFishRandomizeMin.Value, MyModOptions.spinnerFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.spinnerFishScale.Value;
                        }
                    }
                }

                spinnerFish.SetScale(sizeScale);
            }

            else if (__instance is ArcticRay arcticRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.arcticRayExclude.Value)
                {
                    if (MyModOptions.arcticRayRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.arcticRayRandomizeMin.Value, MyModOptions.arcticRayRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.arcticRayScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.arcticRayRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.arcticRayRandomizeMin.Value, MyModOptions.arcticRayRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.arcticRayScale.Value;
                        }
                    }
                }

                arcticRay.SetScale(sizeScale);
            }

            else if (__instance is Jellyfish eyeJelly)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.jellyFishExclude.Value)
                {
                    if (MyModOptions.jellyFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.jellyFishRandomizeMin.Value, MyModOptions.jellyFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.jellyFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.jellyFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.jellyFishRandomizeMin.Value, MyModOptions.jellyFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.jellyFishScale.Value;
                        }
                    }
                }

                eyeJelly.SetScale(sizeScale);
            }

            else if (__instance is TitanHolefish titanHolefish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.titanHoleFishExclude.Value)
                {
                    if (MyModOptions.titanHoleFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.titanHoleFishRandomizeMin.Value, MyModOptions.titanHoleFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.titanHoleFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.titanHoleFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.titanHoleFishRandomizeMin.Value, MyModOptions.titanHoleFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.titanHoleFishScale.Value;
                        }
                    }
                }

                titanHolefish.SetScale(sizeScale);
            }

            else if (__instance is GlowWhale glowWhale)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.glowWhaleExclude.Value)
                {
                    if (MyModOptions.glowWhaleRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.glowWhaleRandomizeMin.Value, MyModOptions.glowWhaleRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.glowWhaleScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.glowWhaleRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.glowWhaleRandomizeMin.Value, MyModOptions.glowWhaleRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.glowWhaleScale.Value;
                        }
                    }
                }

                glowWhale.SetScale(sizeScale);
            }

            else if (__instance is Pinnacarid pinnacarid)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.pinnacaridExclude.Value)
                {
                    if (MyModOptions.pinnacaridRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.pinnacaridRandomizeMin.Value, MyModOptions.pinnacaridRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.pinnacaridScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.pinnacaridRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.pinnacaridRandomizeMin.Value, MyModOptions.pinnacaridRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.pinnacaridScale.Value;
                        }
                    }
                }

                pinnacarid.SetScale(sizeScale);
            }

            else if (__instance is Triops triops)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.triopsExclude.Value)
                {
                    if (MyModOptions.triopsRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.triopsRandomizeMin.Value, MyModOptions.triopsRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.triopsScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.triopsRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.triopsRandomizeMin.Value, MyModOptions.triopsRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.triopsScale.Value;
                        }
                    }
                }

                triops.SetScale(sizeScale);
            }

            else if (__instance is Trivalve trivalve)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.trivalveExclude.Value)
                {
                    if (MyModOptions.trivalveRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.trivalveRandomizeMin.Value, MyModOptions.trivalveRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.trivalveScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.trivalveRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.trivalveRandomizeMin.Value, MyModOptions.trivalveRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.trivalveScale.Value;
                        }
                    }
                }

                trivalve.SetScale(sizeScale);
            }

            else if (__instance is SymbioteFish symbioteFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.symbioteFishExclude.Value)
                {
                    if (MyModOptions.symbioteFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.symbioteFishRandomizeMin.Value, MyModOptions.symbioteFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.symbioteFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.symbioteFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.symbioteFishRandomizeMin.Value, MyModOptions.symbioteFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.symbioteFishScale.Value;
                        }
                    }
                }

                symbioteFish.SetScale(sizeScale);
            }

            else if (__instance is RockGrub rockGrub)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.rockGrubExclude.Value)
                {
                    if (MyModOptions.rockGrubRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.rockGrubRandomizeMin.Value, MyModOptions.rockGrubRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.rockGrubScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.rockGrubRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.rockGrubRandomizeMin.Value, MyModOptions.rockGrubRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.rockGrubScale.Value;
                        }
                    }
                }

                rockGrub.SetScale(sizeScale);
            }
            #endregion

            #region Aggressive Fish
            else if (__instance is Crash crashFish)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.crashFishExclude.Value)
                {
                    if (MyModOptions.crashFishRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.crashFishRandomizeMin.Value, MyModOptions.crashFishRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.crashFishScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.crashFishRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.crashFishRandomizeMin.Value, MyModOptions.crashFishRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.crashFishScale.Value;
                        }
                    }
                }

                crashFish.SetScale(sizeScale);
            }

            else if (__instance is Brinewing brinewing)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.brineWingExclude.Value)
                {
                    if (MyModOptions.brineWingRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.brineWingRandomizeMin.Value, MyModOptions.brineWingRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.brineWingScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.brineWingRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.brineWingRandomizeMin.Value, MyModOptions.brineWingRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.brineWingScale.Value;
                        }
                    }
                }

                brinewing.SetScale(sizeScale);
            }

            else if (__instance is LilyPaddler lilyPaddler)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.lilyPaddlerExclude.Value)
                {
                    if (MyModOptions.lilyPaddlerRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.lilyPaddlerRandomizeMin.Value, MyModOptions.lilyPaddlerRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.lilyPaddlerScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.lilyPaddlerRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.lilyPaddlerRandomizeMin.Value, MyModOptions.lilyPaddlerRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.lilyPaddlerScale.Value;
                        }
                    }
                }

                lilyPaddler.SetScale(sizeScale);
            }

            else if (__instance is Cryptosuchus cryptosuchus)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.cryptosuchusExclude.Value)
                {
                    if (MyModOptions.cryptosuchusRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.cryptosuchusRandomizeMin.Value, MyModOptions.cryptosuchusRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.cryptosuchusScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.cryptosuchusRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.cryptosuchusRandomizeMin.Value, MyModOptions.cryptosuchusRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.cryptosuchusScale.Value;
                        }
                    }
                }

                cryptosuchus.SetScale(sizeScale);
            }

            else if (__instance is BruteShark bruteShark)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.bruteSharkExclude.Value)
                {
                    if (MyModOptions.bruteSharkRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.bruteSharkRandomizeMin.Value, MyModOptions.bruteSharkRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.bruteSharkScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.bruteSharkRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.bruteSharkRandomizeMin.Value, MyModOptions.bruteSharkRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.bruteSharkScale.Value;
                        }
                    }
                }

                bruteShark.SetScale(sizeScale);
            }

            else if (__instance is SquidShark squidShark)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.squidSharkExclude.Value)
                {
                    if (MyModOptions.squidSharkRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.squidSharkRandomizeMin.Value, MyModOptions.squidSharkRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.squidSharkScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.squidSharkRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.squidSharkRandomizeMin.Value, MyModOptions.squidSharkRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.squidSharkScale.Value;
                        }
                    }
                }

                squidShark.SetScale(sizeScale);
            }

            else if (__instance is Chelicerate chelicerate)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.chelicerateExclude.Value)
                {
                    if (MyModOptions.chelicerateRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.chelicerateRandomizeMin.Value, MyModOptions.chelicerateRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.chelicerateScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.chelicerateRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.chelicerateRandomizeMin.Value, MyModOptions.chelicerateRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.chelicerateScale.Value;
                        }
                    }
                }

                chelicerate.SetScale(sizeScale);
            }

            else if (__instance is ShadowLeviathan shadowLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.shadowLeviathanExclude.Value)
                {
                    if (MyModOptions.shadowLeviathanRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.shadowLeviathanRandomizeMin.Value, MyModOptions.shadowLeviathanRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.shadowLeviathanScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.shadowLeviathanRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.shadowLeviathanRandomizeMin.Value, MyModOptions.shadowLeviathanRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.shadowLeviathanScale.Value;
                        }
                    }
                }

                shadowLeviathan.SetScale(sizeScale);
            }

            else if (__instance is VoidLeviathan voidLeviathan)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.voidLeviathanExclude.Value)
                {
                    if (MyModOptions.voidLeviathanRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.voidLeviathanRandomizeMin.Value, MyModOptions.voidLeviathanRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.voidLeviathanScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.voidLeviathanRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.voidLeviathanRandomizeMin.Value, MyModOptions.voidLeviathanRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.voidLeviathanScale.Value;
                        }
                    }
                }

                voidLeviathan.SetScale(sizeScale);
            }
            #endregion

            #region Not Fish
            else if (__instance is Skyray skyRay)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.skyRayExclude.Value)
                {
                    if (MyModOptions.skyRayRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.skyRayRandomizeMin.Value, MyModOptions.skyRayRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.skyRayScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.skyRayRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.skyRayRandomizeMin.Value, MyModOptions.skyRayRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.skyRayScale.Value;
                        }
                    }
                }

                skyRay.SetScale(sizeScale);
            }

            else if (__instance is PenguinBaby pengling)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.penglingExclude.Value)
                {
                    if (MyModOptions.penglingRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.penglingRandomizeMin.Value, MyModOptions.penglingRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.penglingScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.penglingRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.penglingRandomizeMin.Value, MyModOptions.penglingRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.penglingScale.Value;
                        }
                    }
                }

                pengling.SetScale(sizeScale);
            }

            else if (__instance is Penguin pengwing)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.pengwingExclude.Value)
                {
                    if (MyModOptions.pengwingRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.pengwingRandomizeMin.Value, MyModOptions.pengwingRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.pengwingScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.pengwingRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.pengwingRandomizeMin.Value, MyModOptions.pengwingRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.pengwingScale.Value;
                        }
                    }
                }

                pengwing.SetScale(sizeScale);
            }

            else if (__instance is SeaMonkeyBaby seaMonkeyBaby)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.seaMonkeyBabyExclude.Value)
                {
                    if (MyModOptions.seaMonkeyBabyRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.seaMonkeyBabyRandomizeMin.Value, MyModOptions.seaMonkeyBabyRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.seaMonkeyBabyScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.seaMonkeyBabyRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.seaMonkeyBabyRandomizeMin.Value, MyModOptions.seaMonkeyBabyRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.seaMonkeyBabyScale.Value;
                        }
                    }
                }

                seaMonkeyBaby.SetScale(sizeScale);
            }

            else if (__instance is SeaMonkey seaMonkey)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.seaMonkeyExclude.Value)
                {
                    if (MyModOptions.seaMonkeyRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.seaMonkeyRandomizeMin.Value, MyModOptions.seaMonkeyRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.seaMonkeyScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.seaMonkeyRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.seaMonkeyRandomizeMin.Value, MyModOptions.seaMonkeyRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.seaMonkeyScale.Value;
                        }
                    }
                }

                seaMonkey.SetScale(sizeScale);
            }

            else if (__instance is SnowStalkerBaby snowStalkerBaby)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.snowStalkerBabyExclude.Value)
                {
                    if (MyModOptions.snowStalkerBabyRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.snowStalkerBabyRandomizeMin.Value, MyModOptions.snowStalkerBabyRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.snowStalkerBabyScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.snowStalkerBabyRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.snowStalkerBabyRandomizeMin.Value, MyModOptions.snowStalkerBabyRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.snowStalkerBabyScale.Value;
                        }
                    }
                }

                snowStalkerBaby.SetScale(sizeScale);
            }

            else if (__instance is SnowStalker snowStalker)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.snowStalkerExclude.Value)
                {
                    if (MyModOptions.snowStalkerRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.snowStalkerRandomizeMin.Value, MyModOptions.snowStalkerRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.snowStalkerScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.snowStalkerRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.snowStalkerRandomizeMin.Value, MyModOptions.snowStalkerRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.snowStalkerScale.Value;
                        }
                    }
                }

                snowStalker.SetScale(sizeScale);
            }

            else if (__instance is RockPuncher rockPuncher)
            {
                float sizeScale = 4.0f;

                if (MyModOptions.rockPuncherExclude.Value)
                {
                    if (MyModOptions.rockPuncherRandomize.Value)
                    {
                        sizeScale = Random.Range(MyModOptions.rockPuncherRandomizeMin.Value, MyModOptions.rockPuncherRandomizeMax.Value);
                    }
                    else
                    {
                        sizeScale = MyModOptions.rockPuncherScale.Value;
                    }
                }
                else
                {
                    if (MyModOptions.proportionalToggle.Value)
                    {
                        if (MyModOptions.proportionalRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.proportionalRandomizeMin.Value, MyModOptions.proportionalRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.proportionalScale.Value;
                        }
                    }
                    else
                    {
                        if (MyModOptions.rockPuncherRandomize.Value)
                        {
                            sizeScale = Random.Range(MyModOptions.rockPuncherRandomizeMin.Value, MyModOptions.rockPuncherRandomizeMax.Value);
                        }
                        else
                        {
                            sizeScale = MyModOptions.rockPuncherScale.Value;
                        }
                    }
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
                if(MyModOptions.ventgardenRandomize.Value)
                {
                    float scaleValue = Random.Range(MyModOptions.ventgardenRandomizeMin.Value, MyModOptions.ventgardenRandomizeMax.Value);
                    smollVent.gameObject.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
                }
                else
                {
                    smollVent.gameObject.transform.localScale = new Vector3(MyModOptions.smallVentGardenScale.Value, MyModOptions.smallVentGardenScale.Value, MyModOptions.smallVentGardenScale.Value);
                }
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
                if (MyModOptions.ventgardenRandomize.Value)
                {
                    float scaleValue = Random.Range(MyModOptions.ventgardenRandomizeMin.Value, MyModOptions.ventgardenRandomizeMax.Value);
                    bigVent.gameObject.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
                }
                else
                {
                    bigVent.gameObject.transform.localScale = new Vector3(MyModOptions.smallVentGardenScale.Value, MyModOptions.smallVentGardenScale.Value, MyModOptions.smallVentGardenScale.Value);
                }
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
