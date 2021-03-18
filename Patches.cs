using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using UnityEngine;

namespace TLDQOL_Windproof
{
    class Patches
    {
        [HarmonyPatch(typeof(PlayerMovement), "GetWindMovementMultiplier")]
        internal class Patch_WindReduction
        {
            private static void Postfix(ref float __result)
            {
                float windproofness = UnityEngine.Mathf.Clamp(GameManager.GetPlayerManagerComponent().m_WindproofBonusFromClothing / 16, 0, 1);
                __result = 1 + (1 - windproofness) * (1 - __result);

            }
        }
    }
}
