// Decompiled with JetBrains decompiler
// Type: JellyJamMadness.ModBase
// Assembly: JellyJamMadness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7B2576F-62FF-4EAE-A49A-0C18CFDDA436
// Assembly location: C:\Users\tania\Downloads\JellyJamMadness.dll

using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

#nullable disable
namespace JellyJamMadness
{
  [BepInPlugin("JellyJam.MadnessMod", "JellyJamMadness Mod", "1.0.0.0")]
  public class ModBase : BaseUnityPlugin
  {
    private const string modGUID = "JellyJam.MadnessMod";
    private const string modName = "JellyJamMadness Mod";
    private const string modVersion = "1.0.0.0";
    private readonly Harmony harmony = new Harmony("JellyJam.MadnessMod");
    private static ModBase Instance;
    internal ManualLogSource mls;

    private void Awake()
    {
      if (Object.op_Equality((Object) ModBase.Instance, (Object) null))
        ModBase.Instance = this;
      this.mls = Logger.CreateLogSource("JellyJam.MadnessMod");
      this.mls.LogInfo((object) "The JellyJam mod has started");
      this.harmony.PatchAll();
    }
  }
}
