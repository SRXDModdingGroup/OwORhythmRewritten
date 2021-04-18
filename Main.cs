using UnityEngine;
using UnityEngine.SceneManagement;
using BepInEx;
using BepInEx.IL2CPP;
using System.Threading;
using System.Threading.Tasks;
using HarmonyLib;
using TMPro;

namespace OwORhythmRewritten
{
    // Modified from Pink's original OwORhythm which is modified from lolpants.
    [BepInPlugin("OwORhythmRewritten", "OwORhythmRewritten", "1.0.0")]
    public class Main : BasePlugin
    {
        public override void Load()
        {
            Harmony.CreateAndPatchAll(typeof(Run));
        }

        class Run
        {
            [HarmonyPatch(typeof(TextMeshProUGUI), nameof(TextMeshProUGUI.Awake)), HarmonyPostfix]
            public static void AwakePostfix(TextMeshProUGUI __instance)
            {
                bool flag = __instance.text == null;
                if (!flag)
                {
                    __instance.text = XtraClass.OwO(__instance.text).Replace("bw", "br").Replace("cowo", "colo").Replace("winye", "line").Replace("mawk", "mark");
                }
            }


            [HarmonyPatch(typeof(TMP_Text), "set_text"), HarmonyPrefix]
            private static bool set_textPrefix(ref string value)
            {
                bool flag = value == null;
                bool result;
                if (flag)
                {
                    result = true;
                }
                else
                {
                    value = XtraClass.OwO(value).Replace("bw", "br").Replace("cowow", "color").Replace("winye", "line").Replace("mawk", "mark");
                    result = true;
                }
                return result;
            }
        }
    }
}