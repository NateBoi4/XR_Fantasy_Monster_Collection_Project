using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public static class BattleSystem
{
    public static Canvas battleUI;

    public static void StartBattle(Trainer trainer, GameObject player)
    {
        battleUI = player.GetComponentInChildren<Canvas>();
        if (!battleUI.enabled)
            battleUI.enabled = true;
        player.transform.position = trainer.GetBattlePos();
        LocomotionSystem locomotion;
        locomotion = player.GetComponentInChildren<LocomotionSystem>();
        if (locomotion)
            locomotion.enabled = false;
    }
}
