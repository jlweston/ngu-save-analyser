using System;
using System.Collections.Generic;

// Token: 0x02000010 RID: 16
[Serializable]
public class ITOPOD
{
    // Token: 0x06000105 RID: 261 RVA: 0x000147B8 File Offset: 0x00012BB8
    public ITOPOD()
    {
        this.perkPoints = 0L;
        this.lifetimePoints = 0L;
        this.pointProgress = 0L;
        this.enemiesKilled = 0;
        this.poopProgress = 0L;
        this.buffedKills = 0L;
        this.updateItopod();
        this.filterDiff = false;
        this.filterAfford = false;
        this.filterMaxxed = false;
        this.orderType = orderPerks.Default;
    }

    // Token: 0x06000106 RID: 262 RVA: 0x0001481C File Offset: 0x00012C1C
    public long curSize()
    {
        return 159L;
    }

    // Token: 0x06000107 RID: 263 RVA: 0x00014824 File Offset: 0x00012C24
    public void updateItopod()
    {
        if (this.perkLevel == null)
        {
            this.perkLevel = new List<long>();
        }
        while ((long)this.perkLevel.Count < this.curSize())
        {
            this.perkLevel.Add(0L);
        }
    }

    // Token: 0x0400017D RID: 381
    public List<long> perkLevel;

    // Token: 0x0400017E RID: 382
    public long perkPoints;

    // Token: 0x0400017F RID: 383
    public long lifetimePoints;

    // Token: 0x04000180 RID: 384
    public long pointProgress;

    // Token: 0x04000181 RID: 385
    public int enemiesKilled;

    // Token: 0x04000182 RID: 386
    public long poopProgress;

    // Token: 0x04000183 RID: 387
    public long buffedKills;

    // Token: 0x04000184 RID: 388
    public bool filterDiff;

    // Token: 0x04000185 RID: 389
    public bool filterAfford;

    // Token: 0x04000186 RID: 390
    public bool filterMaxxed;

    // Token: 0x04000187 RID: 391
    public orderPerks orderType;
}
