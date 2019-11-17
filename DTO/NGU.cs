using System;

// Token: 0x020000D9 RID: 217
[Serializable]
public class NGU
{
    // Token: 0x06000E5B RID: 3675 RVA: 0x000D794D File Offset: 0x000D5D4D
    public NGU()
    {
        this.progress = 0f;
        this.level = 0L;
        this.energy = 0L;
        this.magic = 0L;
        this.target = 0L;
    }

    // Token: 0x06000E5C RID: 3676 RVA: 0x000D7980 File Offset: 0x000D5D80
    public void reset()
    {
        this.energy = 0L;
        this.magic = 0L;
    }

    // Token: 0x06000E5D RID: 3677 RVA: 0x000D7994 File Offset: 0x000D5D94
    public long targetLevel()
    {
        long num = this.target;
        if (num == 0L)
        {
            num = long.MaxValue;
        }
        if (num == -1L)
        {
            num = 0L;
        }
        return num;
    }

    // Token: 0x06000E5E RID: 3678 RVA: 0x000D79C8 File Offset: 0x000D5DC8
    public long evilTargetLevel()
    {
        long num = this.evilTarget;
        if (num == 0L)
        {
            num = long.MaxValue;
        }
        if (num == -1L)
        {
            num = 0L;
        }
        return num;
    }

    // Token: 0x06000E5F RID: 3679 RVA: 0x000D79FC File Offset: 0x000D5DFC
    public long sadisticTargetLevel()
    {
        long num = this.sadisticTarget;
        if (num == 0L)
        {
            num = long.MaxValue;
        }
        if (num == -1L)
        {
            num = 0L;
        }
        return num;
    }

    // Token: 0x04000AAB RID: 2731
    public float progress;

    // Token: 0x04000AAC RID: 2732
    public long level;

    // Token: 0x04000AAD RID: 2733
    public float evilProgress;

    // Token: 0x04000AAE RID: 2734
    public long evilLevel;

    // Token: 0x04000AAF RID: 2735
    public float sadisticProgress;

    // Token: 0x04000AB0 RID: 2736
    public long sadisticLevel;

    // Token: 0x04000AB1 RID: 2737
    public long energy;

    // Token: 0x04000AB2 RID: 2738
    public long magic;

    // Token: 0x04000AB3 RID: 2739
    public long target;

    // Token: 0x04000AB4 RID: 2740
    public long evilTarget;

    // Token: 0x04000AB5 RID: 2741
    public long sadisticTarget;
}
