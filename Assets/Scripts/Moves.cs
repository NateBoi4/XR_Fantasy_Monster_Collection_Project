using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Typing
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
    public static string[] types =
    {
        "Neutral",
        "Fire",
        "Water",
        "Wing",
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

    #region Damage
    public struct flameBreath
    {
        static int damageVal = 50;
        static int acc = 100;
        static Typing type = Typing.FIRE;
        static int uses = 5;
    }
    public struct splash
    {
        static int damageVal = 20;
        static int acc = 100;
        static Typing type = Typing.WATER;
        static int uses = 10;
    }
    public struct lightningStrike
    {
        static int damageVal = 100;
        static int acc = 50;
        static Typing type = Typing.WIND;
        static int uses = 3;
    }
    public struct earthQuake
    {
        static int damageVal = 80;
        static int acc = 80;
        static Typing type = Typing.EARTH;
        static int uses = 4;
    }
    public struct iceStorm
    {
        static int damageVal = 70;
        static int acc = 100;
        static Typing type = Typing.WATER;
        static int uses = 1;
    }
    public struct tsunami
    {
        static int damageVal = 120;
        static int acc = 30;
        static Typing type = Typing.WATER;
        static int uses = 2;
    }
    #endregion
    //Not Implemented
    #region Effect
    public struct fullCounter
    {
        static int damageVal = 50;
        static int acc = 100;
        static Typing type = Typing.FIRE;
        static int uses = 5;
    }
    public struct guardUp
    {
        static int damageVal = 50;
        static int acc = 100;
        static Typing type = Typing.FIRE;
        static int uses = 5;
    }
    public struct falseStrike
    {
        static int damageVal = 50;
        static int acc = 100;
        static Typing type = Typing.FIRE;
        static int uses = 5;
    }
    public struct flashBang
    {
        static int damageVal = 50;
        static int acc = 100;
        static Typing type = Typing.FIRE;
        static int uses = 5;
    }
    public struct gutPunch
    {
        static int damageVal = 50;
        static int acc = 100;
        static Typing type = Typing.FIRE;
        static int uses = 5;
    }
    public struct twinStep
    {
        static int damageVal = 50;
        static int acc = 100;
        static Typing type = Typing.FIRE;
        static int uses = 5;
    }
    #endregion
}
