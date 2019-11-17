using System;

// Token: 0x0200007B RID: 123
[Serializable]
public class Perk
{
    // Token: 0x0600090B RID: 2315 RVA: 0x00073761 File Offset: 0x00071B61
    public Perk(int cost, int cap)
    {
        this.level = 0;
        this.perLevelCost = cost;
        this.levelCap = cap;
    }

    // Token: 0x0600090C RID: 2316 RVA: 0x0007377E File Offset: 0x00071B7E
    public Perk()
    {
        this.level = 0;
        this.perLevelCost = 1;
        this.levelCap = 5;
    }

    // Token: 0x0600090D RID: 2317 RVA: 0x0007379B File Offset: 0x00071B9B
    public void updateBaseStats(int baseCost, int cap)
    {
        this.perLevelCost = baseCost;
        this.levelCap = cap;
        if (this.level > this.levelCap)
        {
            this.level = this.levelCap;
        }
    }

    // Token: 0x0600090E RID: 2318 RVA: 0x000737C8 File Offset: 0x00071BC8
    public void respec()
    {
        this.level = 0;
    }

    // Token: 0x04000699 RID: 1689
    public int level;

    // Token: 0x0400069A RID: 1690
    public int perLevelCost;

    // Token: 0x0400069B RID: 1691
    public int levelCap;

    // Token: 0x0400069C RID: 1692
    public perkType type;
}
