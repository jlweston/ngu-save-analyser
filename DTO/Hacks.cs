using System;
using System.Collections.Generic;

// Token: 0x020000B1 RID: 177
[Serializable]
public class Hacks
{
    // Token: 0x06000AFA RID: 2810 RVA: 0x00091726 File Offset: 0x0008FB26
    public Hacks()
    {
        this.hacks = new List<Hack>();
        this.hacksOn = false;
        this.updateHackSize();
        this.autoAdvance = true;
        this.target = 0L;
        this.disabled = false;
    }

    // Token: 0x06000AFB RID: 2811 RVA: 0x0009175C File Offset: 0x0008FB5C
    public int hacksSize()
    {
        return 15;
    }

    // Token: 0x06000AFC RID: 2812 RVA: 0x00091760 File Offset: 0x0008FB60
    public void updateHackSize()
    {
        while (this.hacks.Count < this.hacksSize())
        {
            this.hacks.Add(new Hack());
        }
    }

    // Token: 0x040008C1 RID: 2241
    public List<Hack> hacks;

    // Token: 0x040008C2 RID: 2242
    public bool hacksOn;

    // Token: 0x040008C3 RID: 2243
    public bool autoAdvance;

    // Token: 0x040008C4 RID: 2244
    public long target;

    // Token: 0x040008C5 RID: 2245
    public bool disabled;
}
