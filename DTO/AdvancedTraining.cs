using System;

// Token: 0x02000005 RID: 5
[Serializable]
public class AdvancedTraining
{
    // Token: 0x0600001E RID: 30 RVA: 0x00003FF4 File Offset: 0x000023F4
    public AdvancedTraining()
    {
        for (int i = 0; i < this.training.Length; i++)
        {
            this.training[i] = 0;
            this.level[i] = 0L;
            this.energy[i] = 0L;
            this.barProgress[i] = 0f;
            this.levelTarget[i] = 0L;
            this.target[i] = 0;
            this.speed[i] = 1f;
            this.bankedLevel[i] = 0L;
        }
        this.autoAdvance = false;
        this.cost[0] = 12000000f;
        this.cost[1] = 12000000f;
        this.cost[2] = 12000000f;
        this.cost[3] = 24000000f;
        this.cost[4] = 24000000f;
        this.cost[5] = 12000000f;
        this.cost[6] = 12000000f;
        this.cost[7] = 12000000f;
        this.cost[8] = 24000000f;
        this.transferredBankedLevels = true;
    }

    // Token: 0x0600001F RID: 31 RVA: 0x00004174 File Offset: 0x00002574
    public void reset()
    {
        for (int i = 0; i < this.training.Length; i++)
        {
            this.training[i] = 0;
            this.energy[i] = 0L;
            this.barProgress[i] = 0f;
            this.level[i] = 0L;
        }
    }

    // Token: 0x06000020 RID: 32 RVA: 0x000041C4 File Offset: 0x000025C4
    public void unlock()
    {
        this.training[0] = 0;
        this.training[1] = 0;
        this.training[2] = 0;
        this.training[3] = 0;
        this.training[4] = 0;
        this.training[5] = 0;
        this.training[6] = 0;
        this.training[7] = 0;
        this.training[8] = 0;
        this.training[9] = 0;
    }

    // Token: 0x06000021 RID: 33 RVA: 0x0000422C File Offset: 0x0000262C
    public long targetLevel(int id)
    {
        if (this.levelTarget[id] == 0L)
        {
            return long.MaxValue;
        }
        if (this.levelTarget[id] == -1L)
        {
            return 0L;
        }
        return this.levelTarget[id];
    }

    // Token: 0x04000014 RID: 20
    public int[] training = new int[10];

    // Token: 0x04000015 RID: 21
    public long[] level = new long[10];

    // Token: 0x04000016 RID: 22
    public long[] bankedLevel = new long[10];

    // Token: 0x04000017 RID: 23
    public long[] energy = new long[10];

    // Token: 0x04000018 RID: 24
    public float[] barProgress = new float[10];

    // Token: 0x04000019 RID: 25
    public long[] levelTarget = new long[10];

    // Token: 0x0400001A RID: 26
    public bool transferredBankedLevels = true;

    // Token: 0x0400001B RID: 27
    [NonSerialized]
    public int[] target = new int[10];

    // Token: 0x0400001C RID: 28
    [NonSerialized]
    public float[] cost = new float[10];

    // Token: 0x0400001D RID: 29
    [NonSerialized]
    public float[] speed = new float[10];

    // Token: 0x0400001E RID: 30
    public bool autoAdvance;
}
