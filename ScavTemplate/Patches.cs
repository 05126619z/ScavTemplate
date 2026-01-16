using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace ModNamespace
{
    internal class Patches
    {
        [HarmonyPatch(typeof(Body))]
        internal static class BodyPatch
        {
            [HarmonyPatch(nameof(Body.Start))]
            [HarmonyPostfix]
            private static void StartPatch()
            {
                ConsoleScript.instance.LogToConsole("Hello World!");
            }
        }
    }
}
