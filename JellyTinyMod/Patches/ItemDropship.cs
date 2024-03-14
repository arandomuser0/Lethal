// Decompiled with JetBrains decompiler
// Type: JellyJamMadness.Patches.ItemDropship
// Assembly: JellyJamMadness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7B2576F-62FF-4EAE-A49A-0C18CFDDA436
// Assembly location: C:\Users\tania\Downloads\JellyJamMadness.dll

using HarmonyLib;

#nullable disable
namespace JellyJamMadness.Patches
{
  internal class ItemDropship
  {
    [HarmonyPatch("Update")]
    [HarmonyPostfix]
    private static void UpdatePatch(ref float ___shipTimer) => ___shipTimer = 0.0f;
  }
}
