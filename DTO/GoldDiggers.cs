using System;
using System.Collections.Generic;

// Token: 0x020000AD RID: 173
[Serializable]
public class GoldDiggers
{
    // Token: 0x06000AE4 RID: 2788 RVA: 0x000910E8 File Offset: 0x0008F4E8
    public GoldDiggers()
    {
        this.diggers = new List<GoldDigger>();
        this.activeDiggers = new List<int>();
        this.loadoutDiggers = new List<int>();
        this.validateDiggers();
    }

    // Token: 0x06000AE5 RID: 2789 RVA: 0x00091143 File Offset: 0x0008F543
    public int diggersCount()
    {
        return 12;
    }

    // Token: 0x06000AE6 RID: 2790 RVA: 0x00091147 File Offset: 0x0008F547
    public void validateDiggers()
    {
        while (this.diggers.Count < this.diggersCount())
        {
            this.diggers.Add(new GoldDigger());
        }
    }

    // Token: 0x040008A6 RID: 2214
    public List<GoldDigger> diggers = new List<GoldDigger>();

    // Token: 0x040008A7 RID: 2215
    public List<int> activeDiggers = new List<int>();

    // Token: 0x040008A8 RID: 2216
    public List<int> loadoutDiggers = new List<int>();
}
