using System;
using UnityEngine;

// Token: 0x02000088 RID: 136
[Serializable]
public class Resource3
{
    // Token: 0x0600097F RID: 2431 RVA: 0x000774DC File Offset: 0x000758DC
    public Resource3()
    {
        this.capRes3 = 0L;
        this.curRes3 = 0L;
        this.idleRes3 = 0L;
        this.res3BarSpeed = 0f;
        this.res3PerBar = 0L;
        this.res3Gained = 0L;
        this.res3Power = 1f;
        this.res3BarProgress = 0f;
        this.res3Name = "Butts";
        this.res3R = 0.8f;
        this.res3G = 0.25f;
        this.res3B = 0f;
        this.res3On = false;
    }

    // Token: 0x06000980 RID: 2432 RVA: 0x0007756B File Offset: 0x0007596B
    public void reset()
    {
        this.idleRes3 = 0L;
        this.curRes3 = 0L;
        this.res3BarProgress = 0f;
    }

    // Token: 0x06000981 RID: 2433 RVA: 0x00077588 File Offset: 0x00075988
    public void updateRes3()
    {
    }

    // Token: 0x06000982 RID: 2434 RVA: 0x0007758C File Offset: 0x0007598C
    public string colourHexString()
    {
        Color32 color = new Color(this.res3R, this.res3G, this.res3B);
        string str = color.r.ToString("X2");
        string str2 = color.g.ToString("X2");
        string str3 = color.b.ToString("X2");
        return str + str2 + str3;
    }

    // Token: 0x06000983 RID: 2435 RVA: 0x000775F4 File Offset: 0x000759F4
    public string colourHexStringAlpha()
    {
        return this.colourHexString() + "FF";
    }

    // Token: 0x06000984 RID: 2436 RVA: 0x00077608 File Offset: 0x00075A08
    public string colourHexStringTest()
    {
        Color32 color = new Color(0.8f, 0.25f, 0f);
        string str = color.r.ToString("X2");
        string str2 = color.g.ToString("X2");
        string str3 = color.b.ToString("X2");
        //Debug.Log(str + str2 + str3 + "FF");
        return str + str2 + str3 + "FF";
    }

    // Token: 0x04000707 RID: 1799
    public long capRes3;

    // Token: 0x04000708 RID: 1800
    public long curRes3;

    // Token: 0x04000709 RID: 1801
    public long idleRes3;

    // Token: 0x0400070A RID: 1802
    public float res3BarSpeed;

    // Token: 0x0400070B RID: 1803
    public long res3PerBar;

    // Token: 0x0400070C RID: 1804
    public long res3Gained;

    // Token: 0x0400070D RID: 1805
    public float res3Power;

    // Token: 0x0400070E RID: 1806
    public float res3BarProgress;

    // Token: 0x0400070F RID: 1807
    public string res3Name;

    // Token: 0x04000710 RID: 1808
    public float res3R;

    // Token: 0x04000711 RID: 1809
    public float res3G;

    // Token: 0x04000712 RID: 1810
    public float res3B;

    // Token: 0x04000713 RID: 1811
    public bool res3On;
}
