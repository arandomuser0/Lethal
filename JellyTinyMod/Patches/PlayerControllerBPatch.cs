// Decompiled with JetBrains decompiler
// Type: JellyJamMadness.Patches.PlayerControllerBPatch
// Assembly: JellyJamMadness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7B2576F-62FF-4EAE-A49A-0C18CFDDA436
// Assembly location: C:\Users\tania\Downloads\JellyJamMadness.dll

using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace JellyJamMadness.Patches
{
  [HarmonyPatch(typeof (PlayerControllerB))]
  internal class PlayerControllerBPatch
  {
    public static Vector3 savedPos = Vector3.zero;
    public static GameObject managerObject;

    [HarmonyPatch("Update")]
    [HarmonyPostfix]
    private static void UpdatePatch(
      ref float ___sprintMeter,
      ref Transform ___thisPlayerBody,
      ref float ___movementSpeed,
      ref float ___jumpForce,
      ref float ___grabDistance)
    {
      ___sprintMeter += 0.01f;
      ___thisPlayerBody.localScale = new Vector3(0.2f, 0.2f, 0.2f);
      ___movementSpeed = 1.8f;
      ___jumpForce = 6f;
      ___grabDistance = 1f;
    }

    [HarmonyPatch("Awake")]
    [HarmonyPostfix]
    private static void FindObject(ref float ___jumpForce)
    {
      Scene activeScene = SceneManager.GetActiveScene();
      foreach (GameObject rootGameObject in ((Scene) ref activeScene).GetRootGameObjects())
      {
        if (rootGameObject.GetComponent<RoundManager>() != null)
        {
          PlayerControllerBPatch.managerObject = rootGameObject;
          ___jumpForce = 100f;
        }
      }
    }
  }
}
