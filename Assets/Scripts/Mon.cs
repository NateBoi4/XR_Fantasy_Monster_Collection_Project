using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Status
{
    INVALID = -1,
    NONE = 0,
    STUNNED = 1,
    BLINDED = 2,
    DISTRACTED = 3
}

[System.Serializable]
public struct stats
{
    [Range(1, 10)]
    public int damage;
    [Range(1, 10)]
    public int resistance;
    [Range(1, 10)]
    public int accuracy;
    [Range(1, 10)]
    public int speed;
    [Range(100, 300)]
    public int hp;
    [StringInList(typeof(Moves), "GetAllTypes")] public string type;
}

public class Mon : MonoBehaviour
{
    [StringInList(typeof(Moves), "GetAllMoves")] public string[] knownMoves = new string[4];
    [SerializeField] private int currentHP;
    [SerializeField] private Status currentStatus;
    public stats stats;

    public void Attack(string attackName)
    {
        int damage;
        int acc;
        Typing type;
        int uses;
        
    }
}
