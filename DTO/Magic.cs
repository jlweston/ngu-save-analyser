using System;

// Token: 0x02000079 RID: 121
[Serializable]
public class Magic
{
    // Token: 0x060008FD RID: 2301 RVA: 0x00072EF4 File Offset: 0x000712F4
    public Magic()
    {
        this.capMagic = 0L;
        this.curMagic = 0L;
        this.idleMagic = 0L;
        this.magicBarSpeed = 0f;
        this.magicPerBar = 0L;
        this.magicGained = 0L;
        this.magicPower = 1f;
        this.magicBarProgress = 0f;
    }

    // Token: 0x060008FE RID: 2302 RVA: 0x00072F50 File Offset: 0x00071350
    public void unlockMagic()
    {
        if (this.capMagic < 10000L)
        {
            this.capMagic = 10000L;
        }
        if (this.magicBarSpeed < 3f)
        {
            this.magicBarSpeed = 3f;
        }
        if (this.magicPerBar < 1L)
        {
            this.magicPerBar = 1L;
        }
    }

    // Token: 0x060008FF RID: 2303 RVA: 0x00072FAA File Offset: 0x000713AA
    public void reset()
    {
        this.idleMagic = 0L;
        this.curMagic = 0L;
        this.magicBarProgress = 0f;
    }

    // Token: 0x0400068C RID: 1676
    public long capMagic;

    // Token: 0x0400068D RID: 1677
    public long curMagic;

    // Token: 0x0400068E RID: 1678
    public long idleMagic;

    // Token: 0x0400068F RID: 1679
    public float magicBarSpeed;

    // Token: 0x04000690 RID: 1680
    public long magicPerBar;

    // Token: 0x04000691 RID: 1681
    public long magicGained;

    // Token: 0x04000692 RID: 1682
    public float magicPower;

    // Token: 0x04000693 RID: 1683
    public float magicBarProgress;
}
