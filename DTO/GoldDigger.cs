using System;

// Token: 0x020000AB RID: 171
[Serializable]
public class GoldDigger
{
    // Token: 0x06000AD6 RID: 2774 RVA: 0x00090595 File Offset: 0x0008E995
    public GoldDigger()
    {
        this.curLevel = 0L;
        this.maxLevel = 0L;
        this.active = false;
        this.cooldown = new PlayerTime();
    }

    // Token: 0x04000894 RID: 2196
    public long curLevel;

    // Token: 0x04000895 RID: 2197
    public long maxLevel;

    // Token: 0x04000896 RID: 2198
    public bool active;

    // Token: 0x04000897 RID: 2199
    public PlayerTime cooldown;
}
