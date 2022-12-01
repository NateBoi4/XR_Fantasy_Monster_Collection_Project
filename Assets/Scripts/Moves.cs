using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;
using System;

public enum Typing
{
    UNKNOWN = -1,
    NEUTRAL = 0,
    FIRE = 1,
    WATER = 2,
    WIND = 3,
    EARTH = 4
}

public static class Moves
{
    private static string attackData;

    public static string[] types =
    {
        "Neutral",
        "Fire",
        "Water",
        "Wind",
        "Earth"
    };

    public static string[] moves =
    {
        "Flame Breath",
        "Splash",
        "Lightning Strike",
        "Earthquake",
        "Ice Storm",
        "Full Counter",
        "Guard Up",
        "False Strike",
        "Flash Bang",
        "Tsunami",
        "Gut Punch",
        "Twin Step",
        "-------------"
    };

    public static string[] GetAllMoves()
    {
        return moves;
    }

    public static string[] GetAllTypes()
    {
        return types;
    }

    public struct attackValues
    {
        public int attackId;
        public string attackName;
        public int damageVal;
        public int acc;
        public Typing type;
        public int uses;
    }

    public static List<attackValues> attackList = new List<attackValues>();

    private static void ReadAttackData()
    {
        string path = Application.dataPath + "/Resources/attackData.txt";
        StreamReader reader = new StreamReader(path);
        attackData = reader.ReadToEnd();
        reader.Close();
    }

    public static void PopulateAttackList()
    {
        ReadAttackData();
        string[] lines = attackData.Split("\n"[0]);
        foreach(string line in lines)
        {
            Debug.Log(line);
        }
        for(int i = 0; i < lines.Length; i++)
        {
            attackValues av = new attackValues();
            string[] data = lines[i].Split(' ');
            av.attackId = Int32.Parse(data[0]);
            av.attackName = data[1];
            av.damageVal = Int32.Parse(data[2]);
            av.acc = Int32.Parse(data[3]);
            av.type = (Typing)Enum.Parse(typeof(Typing), data[4]);
            av.uses = Int32.Parse(data[5]);
            attackList.Add(av);
        }
        Debug.Log("List contains " + attackList.Count + " entries.");
    }
}
