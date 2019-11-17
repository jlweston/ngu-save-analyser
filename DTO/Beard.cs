using System;

// Token: 0x02000036 RID: 54
[Serializable]
public class Beard
{
    // Token: 0x06000453 RID: 1107 RVA: 0x0004159C File Offset: 0x0003F99C
    public Beard()
    {
        this.progress = 0f;
        this.active = false;
        this.beardLevel = 0L;
        this.permLevel = 0L;
        this.bankedLevel = 0L;
    }

    // Token: 0x06000454 RID: 1108 RVA: 0x000415CE File Offset: 0x0003F9CE
    public void reset()
    {
        this.progress = 0f;
        this.beardLevel = 0L;
    }

    // Token: 0x0400032B RID: 811
    public float progress;

    // Token: 0x0400032C RID: 812
    public bool active;

    // Token: 0x0400032D RID: 813
    public long beardLevel;

    // Token: 0x0400032E RID: 814
    public long permLevel;

    // Token: 0x0400032F RID: 815
    public long bankedLevel;
}
