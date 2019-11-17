using System;
using UnityEngine;

// Token: 0x02000030 RID: 48
[Serializable]
public class Aug
{
    // Token: 0x060003D3 RID: 979 RVA: 0x0003D624 File Offset: 0x0003BA24
    public Aug(float installtime, float augGold, float upInstallTime, float upGold, long attack, long defense, int boss, int uboss, string sname, string sdesc, string supdesc)
    {
        this.augLevel = 0L;
        this.augProgress = 0f;
        this.upgradeLevel = 0L;
        this.upgradeProgress = 0f;
        this.augEnergy = 0L;
        this.upgradeEnergy = 0L;
        this.augmentTarget = 0L;
        this.upgradeTarget = 0L;
        this.augInstallTime = installtime;
        this.augGoldCost = augGold;
        this.upgradeInstallTime = upInstallTime;
        this.upgradeGoldCost = upGold;
        this.speed = 0f;
        this.target = 0L;
        this.attackFactor = attack;
        this.defenseFactor = defense;
        this.augBoss = boss;
        this.upBoss = uboss;
        this.name = sname;
        this.desc = sdesc;
        this.upDesc = supdesc;
    }

    // Token: 0x060003D4 RID: 980 RVA: 0x0003D6E5 File Offset: 0x0003BAE5
    public float getAugCost()
    {
        return this.augGoldCost * (float)(this.augLevel + 1L);
    }

    // Token: 0x060003D5 RID: 981 RVA: 0x0003D6F8 File Offset: 0x0003BAF8
    public float getUpgradeCost()
    {
        return this.upgradeGoldCost * Mathf.Pow((float)(1L + this.upgradeLevel), 2f);
    }

    // Token: 0x060003D6 RID: 982 RVA: 0x0003D715 File Offset: 0x0003BB15
    public void addEnergyAug(long energy)
    {
        this.augEnergy += energy;
    }

    // Token: 0x060003D7 RID: 983 RVA: 0x0003D725 File Offset: 0x0003BB25
    public void addEnergyUpgrade(long energy)
    {
        this.upgradeEnergy += energy;
    }

    // Token: 0x060003D8 RID: 984 RVA: 0x0003D735 File Offset: 0x0003BB35
    public long removeEnergyAug(long target)
    {
        if (target >= this.augEnergy)
        {
            target = this.augEnergy;
            this.augEnergy = 0L;
            return target;
        }
        this.augEnergy -= target;
        return target;
    }

    // Token: 0x060003D9 RID: 985 RVA: 0x0003D764 File Offset: 0x0003BB64
    public long removeEnergyUpgrade(long target)
    {
        if (target >= this.upgradeEnergy)
        {
            target = this.upgradeEnergy;
            this.upgradeEnergy = 0L;
            return target;
        }
        this.upgradeEnergy -= target;
        return target;
    }

    // Token: 0x060003DA RID: 986 RVA: 0x0003D794 File Offset: 0x0003BB94
    public void advanceAugProgress(float speed)
    {
        float num = (float)this.augEnergy / 50000f * speed / (this.augInstallTime * (float)(this.augLevel + 1L));
        this.augProgress += num;
    }

    // Token: 0x060003DB RID: 987 RVA: 0x0003D7D1 File Offset: 0x0003BBD1
    public void levelAug()
    {
        this.augLevel += 1L;
        this.augProgress = 0f;
    }

    // Token: 0x060003DC RID: 988 RVA: 0x0003D7ED File Offset: 0x0003BBED
    public void levelUpgrade()
    {
        this.upgradeLevel += 1L;
        this.upgradeProgress = 0f;
    }

    // Token: 0x060003DD RID: 989 RVA: 0x0003D80C File Offset: 0x0003BC0C
    public double bonus()
    {
        if (this.augLevel == 0L)
        {
            return 0.0;
        }
        return (double)((float)this.augLevel * (1f + Mathf.Pow((float)this.upgradeLevel, 2f)) * (float)this.attackFactor);
    }

    // Token: 0x060003DE RID: 990 RVA: 0x0003D858 File Offset: 0x0003BC58
    public double perLevelBonus()
    {
        return (1.0 + Math.Pow((double)this.upgradeLevel, 2.0)) * (double)this.attackFactor;
    }

    // Token: 0x060003DF RID: 991 RVA: 0x0003D882 File Offset: 0x0003BC82
    public string augNameDesc()
    {
        return this.name + "\n" + this.desc;
    }

    // Token: 0x060003E0 RID: 992 RVA: 0x0003D89C File Offset: 0x0003BC9C
    public void reset()
    {
        this.augLevel = 0L;
        this.augEnergy = 0L;
        this.upgradeLevel = 0L;
        this.upgradeEnergy = 0L;
        this.augProgress = 0f;
        this.upgradeProgress = 0f;
        this.name = string.Empty;
        this.desc = string.Empty;
        this.upDesc = string.Empty;
    }

    // Token: 0x060003E1 RID: 993 RVA: 0x0003D900 File Offset: 0x0003BD00
    public void updateBaseStats(float atime, float aCost, float utime, float ucost, long atk, long def, int aboss, int uboss, string aname, string adesc, string udesc)
    {
        this.augInstallTime = atime;
        this.augGoldCost = aCost;
        this.upgradeInstallTime = utime;
        this.upgradeGoldCost = ucost;
        this.attackFactor = atk;
        this.defenseFactor = def;
        this.augBoss = aboss;
        this.upBoss = uboss;
        this.name = aname;
        this.desc = adesc;
        this.upDesc = udesc;
    }

    // Token: 0x040002EE RID: 750
    public long augLevel;

    // Token: 0x040002EF RID: 751
    public float augProgress;

    // Token: 0x040002F0 RID: 752
    public long upgradeLevel;

    // Token: 0x040002F1 RID: 753
    public float upgradeProgress;

    // Token: 0x040002F2 RID: 754
    public long augEnergy;

    // Token: 0x040002F3 RID: 755
    public long upgradeEnergy;

    // Token: 0x040002F4 RID: 756
    public long augmentTarget;

    // Token: 0x040002F5 RID: 757
    public long upgradeTarget;

    // Token: 0x040002F6 RID: 758
    [NonSerialized]
    public float augInstallTime;

    // Token: 0x040002F7 RID: 759
    [NonSerialized]
    public float augGoldCost;

    // Token: 0x040002F8 RID: 760
    [NonSerialized]
    public float upgradeInstallTime;

    // Token: 0x040002F9 RID: 761
    [NonSerialized]
    public float upgradeGoldCost;

    // Token: 0x040002FA RID: 762
    [NonSerialized]
    public float speed;

    // Token: 0x040002FB RID: 763
    [NonSerialized]
    public long target;

    // Token: 0x040002FC RID: 764
    [NonSerialized]
    public long attackFactor;

    // Token: 0x040002FD RID: 765
    [NonSerialized]
    public long defenseFactor;

    // Token: 0x040002FE RID: 766
    [NonSerialized]
    public int augBoss;

    // Token: 0x040002FF RID: 767
    [NonSerialized]
    public int upBoss;

    // Token: 0x04000300 RID: 768
    [NonSerialized]
    public string name;

    // Token: 0x04000301 RID: 769
    [NonSerialized]
    public string desc;

    // Token: 0x04000302 RID: 770
    [NonSerialized]
    public string upDesc;
}
