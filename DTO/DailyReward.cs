using System;
using UnityEngine;

// Token: 0x0200009F RID: 159
[Serializable]
public class DailyReward
{
    // Token: 0x06000A30 RID: 2608 RVA: 0x00085C18 File Offset: 0x00084018
    public DailyReward()
    {
        this.totalSpins = 0L;
        this.spinTime = new PlayerTime();
        this.spinTime.setTime(82800f);
        this.freeSpins = 0L;
    }

    // Token: 0x04000815 RID: 2069
    public long totalSpins;

    // Token: 0x04000816 RID: 2070
    public PlayerTime spinTime = new PlayerTime();

    // Token: 0x04000817 RID: 2071
    //public UnityEngine.Random.State dailyRewardState = default(UnityEngine.Random.State);

    // Token: 0x04000818 RID: 2072
    public long freeSpins;
}
