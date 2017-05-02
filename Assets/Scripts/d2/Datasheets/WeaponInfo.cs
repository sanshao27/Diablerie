﻿[System.Serializable]
public class WeaponInfo : ItemInfo
{
    public string _name;
    public string _type1;
    public string _type2;
    public string _code;
    public string alternateGfx;
    public string nameStr;
    public int version;
    public int compactSave;
    public int rarity;
    public bool spawnable;
    public int minDamage;
    public int maxDamage;
    public bool oneOrTwoHanded;
    public bool twoHanded;
    public int twoHandedMinDamage;
    public int twoHandedMaxDamage;
    public int missileMinDamage;
    public int missileMaxDamage;
    public int unknown;
    public int rangeAdder;
    public int speed;
    public int strBonus;
    public int dexBonus;
    public int reqStr;
    public int reqDex;
    public int durability;
    public bool noDurability;
    public int _level;
    public int _levelReq;
    public int _cost;
    public int _gambleCost;
    [Datasheet.Sequence(length = 16)]
    public string[] skipped;
    public string _flippyFile;
    [Datasheet.Sequence(length = 118)]
    public string[] skipped2;
}