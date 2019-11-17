using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000039 RID: 57
[Serializable]
public class BeastQuest
{
    // Token: 0x0600046E RID: 1134 RVA: 0x000428C4 File Offset: 0x00040CC4
    //public BeastQuest()
    //{
    //    this.quirkPoints = 0L;
    //    this.lifetimePoints = 0L;
    //    this.questsUnlocked = false;
    //    this.inQuest = false;
    //    this.idleMode = false;
    //    this.questID = 0;
    //    this.targetDrops = 0;
    //    this.curDrops = 0;
    //    this.curBankedQuests = 3;
    //    this.maxBankedQuests = 10;
    //    this.idleProgress = 0f;
    //    this.dailyQuestTimer = new PlayerTime();
    //    this.updateBeastQuest();
    //    this.reducedRewards = false;
    //    this.allActive = true;
    //    this.usedButter = false;
    //    this.filterDiff = false;
    //    this.filterAfford = false;
    //    this.filterMaxxed = false;
    //    this.orderType = orderQuirks.Default;
    //}

    // Token: 0x0600046F RID: 1135 RVA: 0x0004296D File Offset: 0x00040D6D
    public long curSize()
    {
        return 90L;
    }

    // Token: 0x06000470 RID: 1136 RVA: 0x00042974 File Offset: 0x00040D74
    //public void updateBeastQuest()
    //{
    //    if (this.quirkLevel == null)
    //    {
    //        this.quirkLevel = new List<long>();
    //    }
    //    while ((long)this.quirkLevel.Count < this.curSize())
    //    {
    //        this.quirkLevel.Add(0L);
    //    }
    //}

    // Token: 0x04000349 RID: 841
    public List<long> quirkLevel;

    // Token: 0x0400034A RID: 842
    public long quirkPoints;

    // Token: 0x0400034B RID: 843
    public long lifetimePoints;

    // Token: 0x0400034C RID: 844
    public bool questsUnlocked;

    // Token: 0x0400034D RID: 845
    public bool inQuest;

    // Token: 0x0400034E RID: 846
    public bool idleMode;

    // Token: 0x0400034F RID: 847
    public int questID;

    // Token: 0x04000350 RID: 848
    public int targetDrops;

    // Token: 0x04000351 RID: 849
    public int curDrops;

    // Token: 0x04000352 RID: 850
    public PlayerTime dailyQuestTimer;

    // Token: 0x04000353 RID: 851
    public int curBankedQuests;

    // Token: 0x04000354 RID: 852
    public int maxBankedQuests;

    // Token: 0x04000355 RID: 853
    //public UnityEngine.Random.State questState;

    // Token: 0x04000356 RID: 854
    public bool reducedRewards;

    // Token: 0x04000357 RID: 855
    public bool allActive;

    // Token: 0x04000358 RID: 856
    public bool usedButter;

    // Token: 0x04000359 RID: 857
    public float idleProgress;

    // Token: 0x0400035A RID: 858
    public bool filterDiff;

    // Token: 0x0400035B RID: 859
    public bool filterAfford;

    // Token: 0x0400035C RID: 860
    public bool filterMaxxed;

    // Token: 0x0400035D RID: 861
    public orderQuirks orderType;
}
