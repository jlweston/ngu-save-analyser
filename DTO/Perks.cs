using System;

// Token: 0x0200007D RID: 125
[Serializable]
public class Perks
{
    // Token: 0x0600090F RID: 2319 RVA: 0x000737D4 File Offset: 0x00071BD4
    public Perks()
    {
        this.respecTime = new PlayerTime();
        this.statPerk = new Perk();
        this.advStat1 = new Perk();
        this.lootPerk = new Perk();
        this.energyPower1 = new Perk();
        this.magicPower1 = new Perk();
        this.energyBar1 = new Perk();
        this.magicBar1 = new Perk();
        this.discount1 = new Perk();
        this.cooldown1 = new Perk();
        this.goldBoost1 = new Perk();
        this.recycleBonus1 = new Perk();
        this.paralyze = new Perk();
        this.wandoos1 = new Perk();
        this.yggdrasil1 = new Perk();
    }

    // Token: 0x06000910 RID: 2320 RVA: 0x0007388C File Offset: 0x00071C8C
    public void respec()
    {
        this.statPerk.respec();
        this.advStat1.respec();
        this.lootPerk.respec();
        this.energyPower1.respec();
        this.magicPower1.respec();
        this.energyBar1.respec();
        this.magicBar1.respec();
        this.discount1.respec();
        this.cooldown1.respec();
        this.goldBoost1.respec();
        this.recycleBonus1.respec();
        this.paralyze.respec();
    }

    // Token: 0x06000911 RID: 2321 RVA: 0x00073920 File Offset: 0x00071D20
    public void updateBaseStats()
    {
        if (this.statPerk == null)
        {
            this.statPerk = new Perk();
        }
        if (this.lootPerk == null)
        {
            this.lootPerk = new Perk();
        }
        if (this.energyPower1 == null)
        {
            this.energyPower1 = new Perk();
        }
        if (this.magicPower1 == null)
        {
            this.magicPower1 = new Perk();
        }
        if (this.energyBar1 == null)
        {
            this.energyBar1 = new Perk();
        }
        if (this.advStat1 == null)
        {
            this.advStat1 = new Perk();
        }
        if (this.magicBar1 == null)
        {
            this.magicBar1 = new Perk();
        }
        if (this.discount1 == null)
        {
            this.discount1 = new Perk();
        }
        if (this.cooldown1 == null)
        {
            this.cooldown1 = new Perk();
        }
        if (this.goldBoost1 == null)
        {
            this.goldBoost1 = new Perk();
        }
        if (this.recycleBonus1 == null)
        {
            this.recycleBonus1 = new Perk();
        }
        if (this.paralyze == null)
        {
            this.paralyze = new Perk();
        }
        if (this.wandoos1 == null)
        {
            this.wandoos1 = new Perk();
        }
        if (this.yggdrasil1 == null)
        {
            this.wandoos1 = new Perk();
        }
    }

    // Token: 0x040006A3 RID: 1699
    public Perk statPerk;

    // Token: 0x040006A4 RID: 1700
    public Perk advStat1;

    // Token: 0x040006A5 RID: 1701
    public Perk lootPerk;

    // Token: 0x040006A6 RID: 1702
    public Perk energyPower1;

    // Token: 0x040006A7 RID: 1703
    public Perk magicPower1;

    // Token: 0x040006A8 RID: 1704
    public Perk energyBar1;

    // Token: 0x040006A9 RID: 1705
    public Perk magicBar1;

    // Token: 0x040006AA RID: 1706
    public Perk discount1;

    // Token: 0x040006AB RID: 1707
    public Perk cooldown1;

    // Token: 0x040006AC RID: 1708
    public Perk goldBoost1;

    // Token: 0x040006AD RID: 1709
    public Perk recycleBonus1;

    // Token: 0x040006AE RID: 1710
    public Perk paralyze;

    // Token: 0x040006AF RID: 1711
    public Perk wandoos1;

    // Token: 0x040006B0 RID: 1712
    public Perk yggdrasil1;

    // Token: 0x040006B1 RID: 1713
    public PlayerTime respecTime;
}
