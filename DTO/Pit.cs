using System;
using UnityEngine;

// Token: 0x0200004C RID: 76
[Serializable]
public class Pit
{
    // Token: 0x060005B2 RID: 1458 RVA: 0x0004BED0 File Offset: 0x0004A2D0
    public Pit()
    {
        this.tossedGold = false;
        this.highestTier = 0;
        this.totalGold = 0.0;
        //this.pitState = default(UnityEngine.Random.State);
        this.pitTime = new PlayerTime();
        this.tossCount = 0;
    }

    // Token: 0x0400040A RID: 1034
    public double totalGold;

    // Token: 0x0400040B RID: 1035
    public int highestTier;

    // Token: 0x0400040C RID: 1036
    public bool tossedGold;

    // Token: 0x0400040D RID: 1037
    //public UnityEngine.Random.State pitState;

    // Token: 0x0400040E RID: 1038
    public PlayerTime pitTime;

    // Token: 0x0400040F RID: 1039
    public bool tier1TRewarded;

    // Token: 0x04000410 RID: 1040
    public bool tier2TRewarded;

    // Token: 0x04000411 RID: 1041
    public bool tier3TRewarded;

    // Token: 0x04000412 RID: 1042
    public bool tier4TRewarded;

    // Token: 0x04000413 RID: 1043
    public bool tier5TRewarded;

    // Token: 0x04000414 RID: 1044
    public int tossCount;
}
