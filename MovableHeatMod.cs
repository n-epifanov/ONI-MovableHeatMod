using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using JetBrains.Annotations;

namespace Patches
{
    public static class MovableHeatMod
    {
        private static float OVERHEAT_TEMP = 1273.15f;

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
}
