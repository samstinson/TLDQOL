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
        [HarmonyPatch(typeof(GameManager),"Awake")]

        internal class GameManager_Awake
        {
            private static void Postfix()
            {
                MelonLoader.MelonLogger.Log("Hello World");
            }
        }
    }
}
