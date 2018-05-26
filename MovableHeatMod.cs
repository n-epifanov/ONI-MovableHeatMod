using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using JetBrains.Annotations;

using STRINGS;
using TUNING;
using UnityEngine;


public static class MovableHeatMod
{
    private static float zeroC = 273.15f;
    private static float OVERHEAT_TEMP = 1000 + zeroC;
    private static float HEATER_TARGET_TEMP = 1000 + zeroC;
    private static float HEATER_OVERHEAT_TEMP = 1200 + zeroC;

    [HarmonyPatch(typeof(LiquidPumpConfig), nameof(LiquidPumpConfig.CreateBuildingDef))]
    public static class LiquidPumpConfigPatch
    {
        public static void Postfix([NotNull] ref BuildingDef __result)
        {
            __result.OverheatTemperature = OVERHEAT_TEMP;
        }
    }

    [HarmonyPatch(typeof(LiquidMiniPumpConfig), nameof(LiquidMiniPumpConfig.CreateBuildingDef))]
    public static class LiquidMiniPumpConfigPatch
    {
        public static void Postfix([NotNull] ref BuildingDef __result)
        {
            __result.OverheatTemperature = OVERHEAT_TEMP;
        }
    }

    [HarmonyPatch(typeof(GasPumpConfig), nameof(GasPumpConfig.CreateBuildingDef))]
    public static class GasPumpConfigPatch
    {
        public static void Postfix([NotNull] ref BuildingDef __result)
        {
            __result.OverheatTemperature = OVERHEAT_TEMP;
        }
    }

    [HarmonyPatch(typeof(GasMiniPumpConfig), nameof(GasMiniPumpConfig.CreateBuildingDef))]
    public static class GasMiniPumpConfigPatch
    {
        public static void Postfix([NotNull] ref BuildingDef __result)
        {
            __result.OverheatTemperature = OVERHEAT_TEMP;
        }
    }

    [HarmonyPatch(typeof(SpaceHeaterConfig), nameof(SpaceHeaterConfig.CreateBuildingDef))]
    public static class SpaceHeaterConfigDefPatch
    {
        public static void Postfix([NotNull] ref BuildingDef __result)
        {
            __result.OverheatTemperature = HEATER_OVERHEAT_TEMP;
        }
    }
    [HarmonyPatch(typeof(SpaceHeaterConfig), nameof(SpaceHeaterConfig.ConfigureBuildingTemplate))]
    public static class SpaceHeaterConfigTemplatePatch
    {
        public static void Postfix(GameObject go)
        {
            SpaceHeater spaceHeater = go.AddOrGet<SpaceHeater>();
            spaceHeater.targetTemperature = HEATER_TARGET_TEMP;
        }
    }

    [HarmonyPatch(typeof(LiquidHeaterConfig), nameof(LiquidHeaterConfig.CreateBuildingDef))]
    public static class LiquidHeaterConfigDefPatch
    {
        public static void Postfix([NotNull] ref BuildingDef __result)
        {
            __result.OverheatTemperature = HEATER_OVERHEAT_TEMP;
        }
    }
    [HarmonyPatch(typeof(LiquidHeaterConfig), nameof(LiquidHeaterConfig.ConfigureBuildingTemplate))]
    public static class LiquidHeaterConfigTemplatePatch
    {
        public static void Postfix(GameObject go)
        {
            SpaceHeater spaceHeater = go.AddOrGet<SpaceHeater>();
            spaceHeater.targetTemperature = HEATER_TARGET_TEMP;
        }
    }





    [HarmonyPatch(typeof(AirConditionerConfig), nameof(AirConditionerConfig.CreateBuildingDef))]
    public static class AirConditionerConfigPatch
    {
        public static void Postfix([NotNull] ref BuildingDef __result)
        {
            __result.OverheatTemperature = OVERHEAT_TEMP;
        }
    }

    [HarmonyPatch(typeof(LiquidConditionerConfig), nameof(LiquidConditionerConfig.CreateBuildingDef))]
    public static class LiquidConditionerConfigPatch
    {
        public static void Postfix([NotNull] ref BuildingDef __result)
        {
            __result.OverheatTemperature = OVERHEAT_TEMP;
        }
    }
}
