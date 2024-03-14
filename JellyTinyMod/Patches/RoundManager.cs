// Decompiled with JetBrains decompiler
// Type: JellyJamMadness.Patches.RoundManager
// Assembly: JellyJamMadness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7B2576F-62FF-4EAE-A49A-0C18CFDDA436
// Assembly location: C:\Users\tania\Downloads\JellyJamMadness.dll

using HarmonyLib;

#nullable disable
namespace JellyJamMadness.Patches
{
  [HarmonyPatch(typeof (RoundManager))]
  internal class RoundManager
  {
    [HarmonyPatch("Update")]
    [HarmonyPrefix]
    private static void UpdatePatch()
    {
    }
  }
}
