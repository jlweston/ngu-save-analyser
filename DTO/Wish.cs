using System;

// Token: 0x0200012C RID: 300
[Serializable]
public class Wish
{
    // Token: 0x06001173 RID: 4467 RVA: 0x000FAF3B File Offset: 0x000F933B
    public Wish()
    {
        this.energy = 0L;
        this.magic = 0L;
        this.res3 = 0L;
        this.level = 0;
        this.progress = 0f;
    }

    // Token: 0x06001174 RID: 4468 RVA: 0x000FAF6D File Offset: 0x000F936D
    public void reset()
    {
        this.energy = 0L;
        this.magic = 0L;
        this.res3 = 0L;
    }

    // Token: 0x04000D59 RID: 3417
    public long energy;

    // Token: 0x04000D5A RID: 3418
    public long magic;

    // Token: 0x04000D5B RID: 3419
    public long res3;

    // Token: 0x04000D5C RID: 3420
    public int level;

    // Token: 0x04000D5D RID: 3421
    public float progress;
}
