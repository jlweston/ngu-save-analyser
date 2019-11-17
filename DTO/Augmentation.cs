using System;

// Token: 0x02000033 RID: 51
[Serializable]
public class Augmentation
{
    // Token: 0x0600040F RID: 1039 RVA: 0x0003F86C File Offset: 0x0003DC6C
    public Augmentation()
    {
        this.augs[0] = new Aug(150f, 10000f, 100f, 1E+09f, 1L, 1L, 13, 33, string.Empty, string.Empty, string.Empty);
        this.augs[1] = new Aug(1500f, 100000f, 800f, 8E+09f, 12L, 12L, 14, 36, string.Empty, string.Empty, string.Empty);
        this.augs[2] = new Aug(3000f, 400000f, 3000f, 3.0000001E+10f, 50L, 50L, 16, 40, string.Empty, string.Empty, string.Empty);
        this.augs[3] = new Aug(10000f, 1200000f, 10000f, 1E+11f, 200L, 200L, 20, 42, string.Empty, string.Empty, string.Empty);
        this.augs[4] = new Aug(40000f, 20000000f, 40000f, 3E+11f, 1000L, 1000L, 24, 44, string.Empty, string.Empty, string.Empty);
        this.augs[5] = new Aug(1600000f, 800000000f, 1600000f, 1.3E+13f, 50000L, 50000L, 30, 52, string.Empty, string.Empty, string.Empty);
        this.augs[6] = new Aug(30000000f, 1.2999999E+10f, 30000000f, 2E+14f, 1000000L, 1000000L, 40, 60, string.Empty, string.Empty, string.Empty);
        this.advanceEnergy = false;
    }

    // Token: 0x06000410 RID: 1040 RVA: 0x0003FA48 File Offset: 0x0003DE48
    public double totalBonus()
    {
        double num = 0.0;
        for (int i = 0; i < this.augs.Length; i++)
        {
            if (this.augs[i] != null)
            {
                num += this.augs[i].bonus();
            }
        }
        return num;
    }

    // Token: 0x06000411 RID: 1041 RVA: 0x0003FA98 File Offset: 0x0003DE98
    public void resetAugs()
    {
        for (int i = 0; i < this.augs.Length; i++)
        {
            if (this.augs[i] != null)
            {
                this.augs[i].reset();
            }
        }
    }

    // Token: 0x06000412 RID: 1042 RVA: 0x0003FAD8 File Offset: 0x0003DED8
    public void resetLast5Augs()
    {
        for (int i = 2; i < this.augs.Length; i++)
        {
            if (this.augs[i] != null)
            {
                this.augs[i].augLevel = 0L;
                this.augs[i].upgradeLevel = 0L;
            }
        }
    }

    // Token: 0x06000413 RID: 1043 RVA: 0x0003FB2C File Offset: 0x0003DF2C
    public long totalLevels()
    {
        long num = 1L;
        for (int i = 0; i < this.augs.Length; i++)
        {
            num += this.augs[i].augLevel + this.augs[i].upgradeLevel;
        }
        return num;
    }

    // Token: 0x04000322 RID: 802
    public Aug[] augs = new Aug[7];

    // Token: 0x04000323 RID: 803
    public bool advanceEnergy = true;
}
