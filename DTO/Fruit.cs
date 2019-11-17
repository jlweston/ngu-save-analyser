using System;
using UnityEngine;

// Token: 0x02000136 RID: 310
[Serializable]
public class Fruit
{
    // Token: 0x06001231 RID: 4657 RVA: 0x000FFF81 File Offset: 0x000FE381
    public Fruit()
    {
        this.targetTime = 1000f;
        this.activated = false;
        this.maxTier = 0L;
        this.permCostPaid = false;
        this.usePoop = false;
        this.eatFruit = true;
        this.harvests = 0;
    }

    // Token: 0x06001232 RID: 4658 RVA: 0x000FFFBF File Offset: 0x000FE3BF
    public void reset()
    {
        this.activated = false;
        this.seconds = 0f;
        this.totalLevels = 0L;
        this.harvests = 0;
    }

    // Token: 0x06001233 RID: 4659 RVA: 0x000FFFE2 File Offset: 0x000FE3E2
    public void reset(float resetFactor)
    {
        if (resetFactor > 1f)
        {
            resetFactor = 1f;
        }
        this.activated = false;
        this.seconds *= Mathf.Floor(resetFactor);
        this.totalLevels = 0L;
        this.harvests = 0;
    }

    // Token: 0x06001234 RID: 4660 RVA: 0x0010001F File Offset: 0x000FE41F
    public void activate()
    {
        this.activated = true;
    }

    // Token: 0x06001235 RID: 4661 RVA: 0x00100028 File Offset: 0x000FE428
    public void deactivate()
    {
        this.activated = false;
        this.seconds = 0f;
    }

    // Token: 0x06001236 RID: 4662 RVA: 0x0010003C File Offset: 0x000FE43C
    public int harvestTier()
    {
        return Mathf.Min(Mathf.FloorToInt(this.seconds / 3600f), (int)this.maxTier);
    }

    // Token: 0x06001237 RID: 4663 RVA: 0x0010005B File Offset: 0x000FE45B
    public void addTime()
    {
        this.seconds += 1f;
    }

    // Token: 0x06001238 RID: 4664 RVA: 0x0010006F File Offset: 0x000FE46F
    public void addTime(int toAdd)
    {
        this.seconds += (float)toAdd;
    }

    // Token: 0x06001239 RID: 4665 RVA: 0x00100080 File Offset: 0x000FE480
    public bool growing()
    {
        return this.activated && this.maxTier != 0L;
    }

    // Token: 0x04000DBD RID: 3517
    [NonSerialized]
    public float targetTime;

    // Token: 0x04000DBE RID: 3518
    public float seconds;

    // Token: 0x04000DBF RID: 3519
    public bool activated;

    // Token: 0x04000DC0 RID: 3520
    public long unlockCost;

    // Token: 0x04000DC1 RID: 3521
    public long totalLevels;

    // Token: 0x04000DC2 RID: 3522
    public long maxTier;

    // Token: 0x04000DC3 RID: 3523
    public bool permCostPaid;

    // Token: 0x04000DC4 RID: 3524
    public bool usePoop;

    // Token: 0x04000DC5 RID: 3525
    public bool eatFruit;

    // Token: 0x04000DC6 RID: 3526
    public int harvests;
}
