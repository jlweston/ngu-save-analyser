using System;
using System.Collections.Generic;

// Token: 0x0200003E RID: 62
[Serializable]
public class Bestiary
{
    // Token: 0x06000526 RID: 1318 RVA: 0x0004811F File Offset: 0x0004651F
    public Bestiary()
    {
        while (this.enemies.Count < this.bestiaryLength())
        {
            this.enemies.Add(new BestiaryInfo());
        }
    }

    // Token: 0x06000527 RID: 1319 RVA: 0x0004815D File Offset: 0x0004655D
    public int bestiaryLength()
    {
        return 369;
    }

    // Token: 0x06000528 RID: 1320 RVA: 0x00048164 File Offset: 0x00046564
    public void updateBestiary()
    {
        while (this.enemies.Count < this.bestiaryLength())
        {
            this.enemies.Add(new BestiaryInfo());
        }
    }

    // Token: 0x0400039D RID: 925
    public List<BestiaryInfo> enemies = new List<BestiaryInfo>();
}
