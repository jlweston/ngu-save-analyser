using System;
using UnityEngine;

// Token: 0x02000055 RID: 85
[Serializable]
public class Challenge
{
    // Token: 0x06000649 RID: 1609 RVA: 0x00053350 File Offset: 0x00051750
    public Challenge()
    {
        this.inChallenge = false;
        this.targetBoss = 0;
        this.challengeType = challengeType.Basic;
        this.challengeTime = new PlayerTime();
        this.bestTime = int.MaxValue;
        this.highScore = 0;
        this.unlocked = false;
    }

    // Token: 0x0600064A RID: 1610 RVA: 0x0005339C File Offset: 0x0005179C
    public Challenge(bool highLow)
    {
        this.inChallenge = false;
        this.targetBoss = 0;
        this.challengeType = challengeType.Basic;
        this.challengeTime = new PlayerTime();
        if (highLow)
        {
            this.bestTime = int.MaxValue;
        }
        else
        {
            this.bestTime = 0;
        }
        this.highScore = 0;
        this.unlocked = false;
    }

    // Token: 0x0600064B RID: 1611 RVA: 0x000533FC File Offset: 0x000517FC
    public void setChallengeStats(challengeType type, int boss, int reward, int preward, int maxComp)
    {
        this.targetBoss = boss;
        this.challengeType = type;
        this.expReward = reward;
        this.perkPointReward = preward;
        this.maxCompletions = maxComp;
        if (this.bestTime < 0)
        {
            if (type == challengeType.timeBased)
            {
                this.bestTime = 0;
            }
            else
            {
                this.bestTime = int.MaxValue;
            }
        }
        if (this.challengeTime == null)
        {
            this.challengeTime = new PlayerTime();
        }
    }

    // Token: 0x0600064C RID: 1612 RVA: 0x0005346E File Offset: 0x0005186E
    public int getPoints()
    {
        if (this.maxCompletions == 0)
        {
            return this.curCompletions * this.perkPointReward;
        }
        return Mathf.Min(this.curCompletions, this.maxCompletions) * this.perkPointReward;
    }

    // Token: 0x0600064D RID: 1613 RVA: 0x000534A1 File Offset: 0x000518A1
    public void initializeEvilStuff()
    {
        this.curEvilCompletions = 0;
        this.curSadisticCompletions = 0;
    }

    // Token: 0x04000470 RID: 1136
    public bool inChallenge;

    // Token: 0x04000471 RID: 1137
    [NonSerialized]
    public int targetBoss;

    // Token: 0x04000472 RID: 1138
    [NonSerialized]
    public int expReward;

    // Token: 0x04000473 RID: 1139
    [NonSerialized]
    public int perkPointReward;

    // Token: 0x04000474 RID: 1140
    public int curCompletions;

    // Token: 0x04000475 RID: 1141
    public int curEvilCompletions;

    // Token: 0x04000476 RID: 1142
    public int curSadisticCompletions;

    // Token: 0x04000477 RID: 1143
    [NonSerialized]
    public int maxCompletions;

    // Token: 0x04000478 RID: 1144
    public int bestTime;

    // Token: 0x04000479 RID: 1145
    public challengeType challengeType;

    // Token: 0x0400047A RID: 1146
    public PlayerTime challengeTime;

    // Token: 0x0400047B RID: 1147
    public int highScore;

    // Token: 0x0400047C RID: 1148
    public bool unlocked;
}
