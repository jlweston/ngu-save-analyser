using System;

// Token: 0x020000C0 RID: 192
[Serializable]
public class Equipment
{
    // Token: 0x06000BA6 RID: 2982 RVA: 0x000965AC File Offset: 0x000949AC
    public Equipment()
    {
        this.path = "NoItem";
        this.id = 0;
        this.type = part.None;
        this.bossRequired = -1;
        this.capAttack = 0f;
        this.curAttack = 0f;
        this.capDefense = 0f;
        this.curDefense = 0f;
        this.spec1Type = specType.None;
        this.spec1Cur = 0f;
        this.spec1Cap = 0f;
        this.spec2Type = specType.None;
        this.spec2Cur = 0f;
        this.spec2Cap = 0f;
        this.spec3Type = specType.None;
        this.spec3Cur = 0f;
        this.spec3Cap = 0f;
        this.removable = true;
        this.numSpec = 0;
    }

    // Token: 0x06000BA7 RID: 2983 RVA: 0x00096674 File Offset: 0x00094A74
    public Equipment(string source)
    {
        this.path = source;
        this.id = 0;
        this.type = part.None;
        this.bossRequired = -1;
        this.capAttack = 0f;
        this.curAttack = 0f;
        this.capDefense = 0f;
        this.curDefense = 0f;
        this.spec1Type = specType.None;
        this.spec1Cur = 0f;
        this.spec1Cap = 0f;
        this.spec2Type = specType.None;
        this.spec2Cur = 0f;
        this.spec2Cap = 0f;
        this.spec3Type = specType.None;
        this.spec3Cur = 0f;
        this.spec3Cap = 0f;
        this.removable = true;
        this.numSpec = 0;
    }

    // Token: 0x06000BA8 RID: 2984 RVA: 0x00096738 File Offset: 0x00094B38
    public Equipment(part partType, int boss, float curAtk, float capAtk, float curDef, float capDef, specType type1, float cur1, float cap1, specType type2, float cur2, float cap2, specType type3, float cur3, float cap3, string source, int pid)
    {
        this.id = pid;
        this.path = source;
        this.type = partType;
        this.curAttack = curAtk;
        this.capAttack = capAtk;
        this.curDefense = curDef;
        this.capDefense = capDef;
        this.spec1Type = type1;
        this.spec1Cur = cur1;
        this.spec1Cap = cap1;
        this.spec2Type = type2;
        this.spec2Cur = cur2;
        this.spec2Cap = cap2;
        this.spec3Type = type3;
        this.spec3Cur = cur3;
        this.spec3Cap = cap3;
        this.removable = true;
        this.bossRequired = boss;
        this.level = 0;
    }

    // Token: 0x06000BA9 RID: 2985 RVA: 0x000967E0 File Offset: 0x00094BE0
    public Equipment(part partType, float boost, string source, int pid)
    {
        this.id = pid;
        this.bossRequired = -1;
        this.path = source;
        this.type = partType;
        this.bossRequired = 0;
        this.removable = true;
        this.numSpec = 0;
        this.level = 0;
        if (partType == part.atkBoost)
        {
            this.curAttack = boost;
            this.capAttack = 0f;
            this.curDefense = 0f;
            this.capDefense = 0f;
            this.spec1Type = specType.None;
            this.spec1Cur = 0f;
            this.spec1Cap = 0f;
            this.spec2Type = specType.None;
            this.spec2Cur = 0f;
            this.spec2Cap = 0f;
            this.spec3Type = specType.None;
            this.spec3Cur = 0f;
            this.spec3Cap = 0f;
        }
        else if (partType == part.defBoost)
        {
            this.curAttack = 0f;
            this.capAttack = 0f;
            this.curDefense = boost;
            this.capDefense = 0f;
            this.spec1Type = specType.None;
            this.spec1Cur = 0f;
            this.spec1Cap = 0f;
            this.spec2Type = specType.None;
            this.spec2Cur = 0f;
            this.spec2Cap = 0f;
            this.spec3Type = specType.None;
            this.spec3Cur = 0f;
            this.spec3Cap = 0f;
            this.bossRequired = 0;
        }
        else if (partType == part.specBoost)
        {
            this.curAttack = 0f;
            this.capAttack = 0f;
            this.curDefense = 0f;
            this.capDefense = 0f;
            this.spec1Type = specType.None;
            this.spec1Cur = boost;
            this.spec1Cap = 0f;
            this.spec2Type = specType.None;
            this.spec2Cur = boost;
            this.spec2Cap = 0f;
            this.spec3Type = specType.None;
            this.spec3Cur = boost;
            this.spec3Cap = 0f;
            this.bossRequired = 0;
        }
    }

    // Token: 0x06000BAA RID: 2986 RVA: 0x000969CE File Offset: 0x00094DCE
    public void Start()
    {
    }

    // Token: 0x06000BAB RID: 2987 RVA: 0x000969D0 File Offset: 0x00094DD0
    public string tooltipText(int bossID)
    {
        string text = string.Empty;
        text += "<b>Stats</b>";
        if (bossID < this.bossRequired)
        {
            text = text + "(" + (Math.Min((float)bossID / (float)this.bossRequired, 1f) * 100f).ToString("##.#") + "%)";
        }
        text += "\n";
        if (this.capAttack != 0f)
        {
            float num = (float)Math.Floor(this.curAttack * Math.Min((float)bossID / (float)this.bossRequired, 1f));
            string str = string.Concat(new object[]
            {
                "Power: ",
                num,
                " / ",
                Math.Floor(this.capAttack * (1f + (float)this.level / 100f)),
                "\nMax Health: ",
                num * 3f,
                " / ",
                Math.Floor(this.capAttack * (1f + (float)this.level / 100f)) * 3f,
                "\n"
            });
            if (this.curAttack >= Math.Floor(this.capAttack * (1f + (float)this.level / 100f)))
            {
                str = "<color=green>" + str + "</color>";
            }
            text += str;
        }
        if (this.capDefense != 0f)
        {
            float num2 = (float)Math.Floor(this.curDefense * Math.Min((float)bossID / (float)this.bossRequired, 1f));
            string str = string.Concat(new object[]
            {
                "Toughness: ",
                num2,
                " / ",
                Math.Floor(this.capDefense * (1f + (float)this.level / 100f)),
                "\nHealth Regen: ",
                num2 * 0.03f,
                " / ",
                Math.Floor(this.capDefense * (1f + (float)this.level / 100f)) * 0.03f,
                "\n"
            });
            if (this.curDefense >= Math.Floor(this.capDefense * (1f + (float)this.level / 100f)))
            {
                str = "<color=green>" + str + "</color>";
            }
            text += str;
        }
        if (text != "\n<b>Stats</b>\n")
        {
            text += "\n";
        }
        if (this.spec1Type != specType.None)
        {
            float num3 = (float)Math.Floor(this.spec1Cur * Math.Min((float)bossID / (float)this.bossRequired, 1f));
            float num4 = (float)Math.Floor(this.spec1Cap * (1f + (float)this.level / 100f));
            string str2 = string.Concat(new object[]
            {
                "Special Effect 1: ",
                this.effectName(this.spec1Type),
                "\nCurrent bonus: ",
                num3,
                " / ",
                num4,
                " (",
                this.effectBonus(num3, this.spec1Type),
                "% Bonus)"
            });
            if (this.spec1Cur >= Math.Floor(this.spec1Cap * (1f + (float)this.level / 100f)))
            {
                str2 = "<color=green>" + str2 + "</color>";
            }
            text += str2;
        }
        if (this.spec2Type != specType.None)
        {
            float num5 = (float)Math.Floor(this.spec2Cur * Math.Min((float)bossID / (float)this.bossRequired, 1f));
            float num6 = (float)Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f));
            string str3 = string.Concat(new object[]
            {
                "\n\nSpecial Effect 2: ",
                this.effectName(this.spec2Type),
                "\nCurrent bonus: ",
                num5,
                " / ",
                num6,
                " (",
                this.effectBonus(num5, this.spec2Type),
                "% Bonus)"
            });
            if (this.spec2Cur >= Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f)))
            {
                str3 = "<color=green>" + str3 + "</color>";
            }
            text += str3;
        }
        if (this.spec3Type != specType.None)
        {
            float num7 = (float)Math.Floor(this.spec3Cur * Math.Min((float)bossID / (float)this.bossRequired, 1f));
            float num8 = (float)Math.Floor(this.spec3Cap * (1f + (float)this.level / 100f));
            string str4 = string.Concat(new object[]
            {
                "\n\nSpecial Effect 3: ",
                this.effectName(this.spec3Type),
                "\nCurrent bonus: ",
                num7,
                " / ",
                num8,
                " (",
                this.effectBonus(num7, this.spec3Type),
                "% Bonus)"
            });
            if (this.spec3Cur >= Math.Floor(this.spec3Cap * (1f + (float)this.level / 100f)))
            {
                str4 = "<color=green>" + str4 + "</color>";
            }
            text += str4;
        }
        if (this.unique)
        {
            text += "\n\nUNIQUE: Cannot equip more than one at the same time!";
        }
        return text;
    }

    // Token: 0x06000BAC RID: 2988 RVA: 0x00096FB0 File Offset: 0x000953B0
    public float specBonus(specType type)
    {
        float num = 0f;
        if (this.spec1Type == specType.None)
        {
            return num;
        }
        if (this.spec1Type == type)
        {
            num += this.spec1Cur;
        }
        if (this.spec2Type == type)
        {
            num += this.spec2Cur;
        }
        if (this.spec3Type == type)
        {
            num += this.spec3Cur;
        }
        return num;
    }

    // Token: 0x06000BAD RID: 2989 RVA: 0x00097010 File Offset: 0x00095410
    public bool hasSpec(specType type)
    {
        return this.spec1Type == type || this.spec2Type == type || this.spec3Type == type;
    }

    // Token: 0x06000BAE RID: 2990 RVA: 0x0009703D File Offset: 0x0009543D
    public float reqBossFactor(int bossReq)
    {
        return Math.Min(1f, (float)(this.level / bossReq));
    }

    // Token: 0x06000BAF RID: 2991 RVA: 0x00097052 File Offset: 0x00095452
    public bool boostEquip(Equipment boost)
    {
        return this.boostEquip(boost, 1f);
    }

    // Token: 0x06000BB0 RID: 2992 RVA: 0x00097060 File Offset: 0x00095460
    public bool boostEquip(Equipment boost, float bonus)
    {
        if (this.id == 0)
        {
            return false;
        }
        if (boost.type == part.atkBoost)
        {
            float num = boost.capAttack * bonus;
            if (this.curAttack >= Math.Floor(this.capAttack * (1f + (float)this.level / 100f)))
            {
                return false;
            }
            this.curAttack += num;
            if (this.curAttack >= Math.Floor(this.capAttack * (1f + (float)this.level / 100f)))
            {
                this.curAttack = (float)Math.Floor(this.capAttack * (1f + (float)this.level / 100f));
            }
            return true;
        }
        else if (boost.type == part.defBoost)
        {
            float num2 = boost.capDefense * bonus;
            if (this.curDefense >= Math.Floor(this.capDefense * (1f + (float)this.level / 100f)))
            {
                return false;
            }
            this.curDefense += num2;
            if (this.curDefense >= Math.Floor(this.capDefense * (1f + (float)this.level / 100f)))
            {
                this.curDefense = (float)Math.Floor(this.capDefense * (1f + (float)this.level / 100f));
            }
            return true;
        }
        else
        {
            if (boost.type != part.specBoost)
            {
                return false;
            }
            float num3 = boost.spec1Cap * bonus;
            bool result = false;
            float num4 = (float)Math.Floor(this.spec1Cap * (1f + (float)this.level / 100f)) - this.spec1Cur;
            if (num4 >= num3)
            {
                this.spec1Cur += num3;
                return true;
            }
            if (num4 > 0f)
            {
                this.spec1Cur += num4;
                num3 -= num4;
                result = true;
            }
            float num5 = (float)Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f)) - this.spec2Cur;
            if (num5 >= num3)
            {
                this.spec2Cur += num3;
                return true;
            }
            if (num5 > 0f)
            {
                this.spec2Cur += num5;
                num3 -= num5;
                result = true;
            }
            float num6 = (float)Math.Floor(this.spec3Cap * (1f + (float)this.level / 100f)) - this.spec3Cur;
            if (num6 >= num3)
            {
                this.spec3Cur += num3;
                return true;
            }
            if (num6 > 0f)
            {
                this.spec3Cur += num6;
                num3 -= num6;
                result = true;
            }
            return result;
        }
    }

    // Token: 0x06000BB1 RID: 2993 RVA: 0x000972FC File Offset: 0x000956FC
    public bool maxEquipBoost(Equipment boost)
    {
        if (this.id == 0)
        {
            return false;
        }
        if (boost.id == 170)
        {
            if (this.curAttack >= Math.Floor(this.capAttack * (1f + (float)this.level / 100f)))
            {
                return false;
            }
            this.curAttack = (float)Math.Floor(this.capAttack * (1f + (float)this.level / 100f));
            return true;
        }
        else if (boost.id == 171)
        {
            if (this.curDefense >= Math.Floor(this.capDefense * (1f + (float)this.level / 100f)))
            {
                return false;
            }
            this.curDefense = (float)Math.Floor(this.capDefense * (1f + (float)this.level / 100f));
            return true;
        }
        else
        {
            if (boost.id != 172)
            {
                return false;
            }
            if (this.spec1Cur >= Math.Floor(this.spec1Cap * (1f + (float)this.level / 100f)) && this.spec2Cur >= Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f)) && this.spec2Cur >= Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f)))
            {
                return false;
            }
            this.spec1Cur = (float)Math.Floor(this.spec1Cap * (1f + (float)this.level / 100f));
            this.spec2Cur = (float)Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f));
            this.spec2Cur = (float)Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f));
            return true;
        }
    }

    // Token: 0x06000BB2 RID: 2994 RVA: 0x000974DE File Offset: 0x000958DE
    public float getAttack()
    {
        return this.curAttack;
    }

    // Token: 0x06000BB3 RID: 2995 RVA: 0x000974E8 File Offset: 0x000958E8
    public void updateItem(int rboss, part ptype, float capatk, float curatk, float capdef, float curdef, specType type1, float capspec1, float curspec1, specType type2, float capspec2, float curspec2, specType type3, float capspec3, float curspec3, string npath, bool punique)
    {
        this.bossRequired = rboss;
        this.capAttack = capatk;
        this.type = ptype;
        if (this.curAttack > Math.Floor(this.capAttack * (1f + (float)this.level / 100f)))
        {
            this.curAttack = (float)Math.Floor(this.capAttack * (1f + (float)this.level / 100f));
        }
        if (this.curAttack < curatk)
        {
            this.curAttack = curatk;
        }
        this.capDefense = capdef;
        if (this.curDefense > Math.Floor(this.capDefense * (1f + (float)this.level / 100f)))
        {
            this.curDefense = (float)Math.Floor(this.capDefense * (1f + (float)this.level / 100f));
        }
        if (this.curDefense < curdef)
        {
            this.curDefense = curdef;
        }
        this.spec1Type = type1;
        this.spec1Cap = capspec1;
        float num = (float)Math.Floor(this.spec1Cap * (1f + (float)this.level / 100f));
        if (this.spec1Cur > num)
        {
            this.spec1Cur = num;
        }
        if (this.spec1Cur < curspec1)
        {
            this.spec1Cur = curspec1;
        }
        this.spec2Type = type2;
        this.spec2Cap = capspec2;
        float num2 = (float)Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f));
        if (this.spec2Cur > num2)
        {
            this.spec2Cur = num2;
        }
        if (this.spec2Cur < curspec2)
        {
            this.spec2Cur = curspec2;
        }
        this.spec3Type = type3;
        this.spec3Cap = capspec3;
        float num3 = (float)Math.Floor(this.spec3Cap * (1f + (float)this.level / 100f));
        if (this.spec3Cur > num3)
        {
            this.spec3Cur = num3;
        }
        if (this.spec3Cur < curspec3)
        {
            this.spec3Cur = curspec3;
        }
        this.path = npath;
        this.unique = punique;
    }

    // Token: 0x06000BB4 RID: 2996 RVA: 0x000976F4 File Offset: 0x00095AF4
    public void mergeItem(Equipment equip)
    {
        if ((long)this.level + (long)equip.level + 1L > 2147483647L)
        {
            this.level = int.MaxValue;
        }
        else
        {
            this.level = this.level + equip.level + 1;
        }
        if (this.level > 100 && this.type != part.MacGuffin)
        {
            this.level = 100;
        }
        this.curAttack = Math.Max(this.curAttack, equip.curAttack);
        if (this.curAttack > Math.Floor(this.capAttack * (1f + (float)this.level / 100f)))
        {
            this.curAttack = (float)Math.Floor(this.capAttack * (1f + (float)this.level / 100f));
        }
        this.curDefense = Math.Max(this.curDefense, equip.curDefense);
        if (this.curDefense > Math.Floor(this.capDefense * (1f + (float)this.level / 100f)))
        {
            this.curDefense = (float)Math.Floor(this.capDefense * (1f + (float)this.level / 100f));
        }
        this.spec1Cur = Math.Max(this.spec1Cur, equip.spec1Cur);
        this.spec2Cur = Math.Max(this.spec2Cur, equip.spec2Cur);
        this.spec3Cur = Math.Max(this.spec3Cur, equip.spec3Cur);
        if (this.spec1Cur > Math.Floor(this.spec1Cap * (1f + (float)this.level / 100f)))
        {
            this.spec1Cur = (float)Math.Floor(this.spec1Cap * (1f + (float)this.level / 100f));
        }
        if (this.spec2Cur > Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f)))
        {
            this.spec2Cur = (float)Math.Floor(this.spec2Cap * (1f + (float)this.level / 100f));
        }
        if (this.spec3Cur > Math.Floor(this.spec3Cap * (1f + (float)this.level / 100f)))
        {
            this.spec3Cur = (float)Math.Floor(this.spec3Cap * (1f + (float)this.level / 100f));
        }
        if (!this.removable || !equip.removable)
        {
            this.removable = false;
        }
        else
        {
            this.removable = true;
        }
    }

    // Token: 0x06000BB5 RID: 2997 RVA: 0x0009798C File Offset: 0x00095D8C
    public void levelUp()
    {
        if (this.id == 0)
        {
            return;
        }
        if (this.level >= 100)
        {
            return;
        }
        this.level++;
        if (this.level > 100)
        {
            this.level = 100;
        }
    }

    // Token: 0x06000BB6 RID: 2998 RVA: 0x000979CB File Offset: 0x00095DCB
    public float statFactor(int bossID)
    {
        if (this.bossRequired == 0)
        {
            return 1f;
        }
        return Math.Min((float)bossID / (float)this.bossRequired, 1f);
    }

    // Token: 0x06000BB7 RID: 2999 RVA: 0x000979F2 File Offset: 0x00095DF2
    public bool isBoost()
    {
        return this.type == part.atkBoost || this.type == part.defBoost || this.type == part.specBoost;
    }

    // Token: 0x06000BB8 RID: 3000 RVA: 0x00097A1C File Offset: 0x00095E1C
    public bool isEquipment()
    {
        return this.type == part.Head || this.type == part.Chest || this.type == part.Legs || this.type == part.Boots || this.type == part.Weapon || this.type == part.Accessory;
    }

    // Token: 0x06000BB9 RID: 3001 RVA: 0x00097A73 File Offset: 0x00095E73
    public bool isMacGuffin()
    {
        return this.type == part.MacGuffin;
    }

    // Token: 0x06000BBA RID: 3002 RVA: 0x00097A88 File Offset: 0x00095E88
    private string effectName(specType type)
    {
        switch (type)
        {
            case specType.EnergyPower2:
                return "Energy Power";
            case specType.MagicPower2:
                return "Magic Power";
            case specType.EnergyPerBar2:
                return "Energy Bars";
            case specType.MagicPerBar2:
                return "Magic Bars";
            case specType.EnergyCap:
                return "Energy Cap";
            case specType.MagicCap:
                return "Magic Cap";
            default:
                switch (type)
                {
                    case specType.EnergyPerBar:
                        return "Energy Bars";
                    case specType.MagicPerBar:
                        return "Magic Bars";
                    default:
                        switch (type)
                        {
                            case specType.EnergyPower:
                                return "Energy Power";
                            case specType.MagicPower:
                                return "Magic Power";
                        }
                        return type.ToString();
                    case specType.AdvTraining:
                        return "Advanced Training";
                }
        }
    }

    // Token: 0x06000BBB RID: 3003 RVA: 0x00097B40 File Offset: 0x00095F40
    private float effectBonus(float amount, specType type)
    {
        switch (type)
        {
            case specType.BoostRecycle:
                return amount / 10f;
            default:
                if (type != specType.Looting)
                {
                    return amount;
                }
                return amount / 10f;
            case specType.Wandoos98:
                return amount / 100f;
            case specType.AdvTraining:
                return amount / 100f;
            case specType.Cooldown:
                return amount / 100f;
            case specType.EnergyPower2:
                return amount / 10f;
            case specType.MagicPower2:
                return amount / 10f;
            case specType.EnergyPerBar2:
                return amount / 10f;
            case specType.MagicPerBar2:
                return amount / 10f;
            case specType.EnergyCap:
                return amount / 100f;
            case specType.MagicCap:
                return amount / 100f;
        }
    }

    // Token: 0x06000BBC RID: 3004 RVA: 0x00097BEB File Offset: 0x00095FEB
    public bool needsAtkBoost()
    {
        return this.curAttack < this.capAttack;
    }

    // Token: 0x06000BBD RID: 3005 RVA: 0x00097C01 File Offset: 0x00096001
    public bool needsDefBoost()
    {
        return this.curDefense < this.capDefense;
    }

    // Token: 0x06000BBE RID: 3006 RVA: 0x00097C17 File Offset: 0x00096017
    public bool needsSpecBoost()
    {
        return this.spec1Cur < this.spec1Cap || this.spec2Cur < this.spec1Cap || this.spec3Cur < this.spec3Cap;
    }

    // Token: 0x06000BBF RID: 3007 RVA: 0x00097C53 File Offset: 0x00096053
    public void delete()
    {
    }

    // Token: 0x04000952 RID: 2386
    [NonSerialized]
    public string path;

    // Token: 0x04000953 RID: 2387
    public int id;

    // Token: 0x04000954 RID: 2388
    public part type;

    // Token: 0x04000955 RID: 2389
    public int bossRequired;

    // Token: 0x04000956 RID: 2390
    public float capAttack;

    // Token: 0x04000957 RID: 2391
    public float curAttack;

    // Token: 0x04000958 RID: 2392
    public float capDefense;

    // Token: 0x04000959 RID: 2393
    public float curDefense;

    // Token: 0x0400095A RID: 2394
    public specType spec1Type;

    // Token: 0x0400095B RID: 2395
    public float spec1Cur;

    // Token: 0x0400095C RID: 2396
    public float spec1Cap;

    // Token: 0x0400095D RID: 2397
    public specType spec2Type;

    // Token: 0x0400095E RID: 2398
    public float spec2Cur;

    // Token: 0x0400095F RID: 2399
    public float spec2Cap;

    // Token: 0x04000960 RID: 2400
    public specType spec3Type;

    // Token: 0x04000961 RID: 2401
    public float spec3Cur;

    // Token: 0x04000962 RID: 2402
    public float spec3Cap;

    // Token: 0x04000963 RID: 2403
    public bool removable;

    // Token: 0x04000964 RID: 2404
    [NonSerialized]
    public int numSpec;

    // Token: 0x04000965 RID: 2405
    public int level;

    // Token: 0x04000966 RID: 2406
    [NonSerialized]
    public bool unique;
}
