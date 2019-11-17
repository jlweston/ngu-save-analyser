using System;

// Token: 0x02000043 RID: 67
[Serializable]
public class Ritual
{
    // Token: 0x06000570 RID: 1392 RVA: 0x00049DE0 File Offset: 0x000481E0
    public Ritual()
    {
        this.progress = 0f;
        this.magic = 0L;
        this.level = 0L;
        this.baseBuildTime = 1f;
        this.baseRebirthBoost = 1L;
        this.paid = false;
        this.baseCost = 1f;
        this.name = string.Empty;
        this.desc = string.Empty;
    }

    // Token: 0x06000571 RID: 1393 RVA: 0x00049E4C File Offset: 0x0004824C
    public Ritual(float time, float cost, long boost)
    {
        this.progress = 0f;
        this.magic = 0L;
        this.level = 0L;
        this.baseBuildTime = time;
        this.baseRebirthBoost = boost;
        this.paid = false;
        this.baseCost = cost;
        this.name = string.Empty;
        this.desc = string.Empty;
    }

    // Token: 0x06000572 RID: 1394 RVA: 0x00049EAC File Offset: 0x000482AC
    public Ritual(float time, float cost, long boost, string sname, string sdesc, int rboss)
    {
        this.progress = 0f;
        this.magic = 0L;
        this.level = 0L;
        this.baseBuildTime = time;
        this.baseRebirthBoost = boost;
        this.paid = false;
        this.baseCost = cost;
        this.name = sname;
        this.desc = sdesc;
        this.boss = rboss;
    }

    // Token: 0x06000573 RID: 1395 RVA: 0x00049F0E File Offset: 0x0004830E
    public void updateBaseStats(float time, float cost, long boost, int rboss)
    {
        this.baseBuildTime = time;
        this.baseRebirthBoost = boost;
        this.baseCost = cost;
        this.boss = rboss;
    }

    // Token: 0x06000574 RID: 1396 RVA: 0x00049F2D File Offset: 0x0004832D
    public void advanceProgress(float magicPower)
    {
        if (this.magic == 0L)
        {
            return;
        }
        this.progress += (float)this.magic * magicPower / 50000f / this.baseBuildTime;
    }

    // Token: 0x06000575 RID: 1397 RVA: 0x00049F60 File Offset: 0x00048360
    public long capValue(float magicPower)
    {
        return (long)Math.Ceiling(50000f * this.baseBuildTime / magicPower);
    }

    // Token: 0x06000576 RID: 1398 RVA: 0x00049F76 File Offset: 0x00048376
    public void reset()
    {
        this.progress = 0f;
        this.magic = 0L;
        this.level = 0L;
    }

    // Token: 0x06000577 RID: 1399 RVA: 0x00049F93 File Offset: 0x00048393
    public double rebirthBoost()
    {
        return (double)(this.baseRebirthBoost * this.level);
    }

    // Token: 0x06000578 RID: 1400 RVA: 0x00049FA4 File Offset: 0x000483A4
    public string timeLeft(float magicPower)
    {
        if (this.magic == 0L)
        {
            return "N/A";
        }
        float num = (1f - this.progress) * this.baseBuildTime / ((float)this.magic * magicPower / 1000f);
        float num2 = (float)Math.Floor(num / 86400f);
        num %= 86400f;
        float num3 = (float)Math.Floor(num / 3600f);
        num %= 3600f;
        float num4 = (float)Math.Floor(num / 60f);
        num %= 60f;
        return string.Concat(new object[]
        {
            num2,
            " days ",
            num3,
            " : ",
            num4,
            " : ",
            num.ToString("0.0")
        });
    }

    // Token: 0x06000579 RID: 1401 RVA: 0x0004A086 File Offset: 0x00048486
    public void updateBaseStats(float btime, float bcost, long bBoost)
    {
        this.baseBuildTime = btime;
        this.baseCost = bcost;
        this.baseRebirthBoost = bBoost;
    }

    // Token: 0x040003D2 RID: 978
    public float progress;

    // Token: 0x040003D3 RID: 979
    public long magic;

    // Token: 0x040003D4 RID: 980
    public long level;

    // Token: 0x040003D5 RID: 981
    [NonSerialized]
    public float baseBuildTime;

    // Token: 0x040003D6 RID: 982
    [NonSerialized]
    public long baseRebirthBoost;

    // Token: 0x040003D7 RID: 983
    [NonSerialized]
    public bool paid;

    // Token: 0x040003D8 RID: 984
    [NonSerialized]
    public float baseCost;

    // Token: 0x040003D9 RID: 985
    [NonSerialized]
    public string name;

    // Token: 0x040003DA RID: 986
    [NonSerialized]
    public string desc;

    // Token: 0x040003DB RID: 987
    [NonSerialized]
    public int boss;
}
