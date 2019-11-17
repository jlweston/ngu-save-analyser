using System;
using System.Collections.Generic;

// Token: 0x02000038 RID: 56
[Serializable]
public class Beards
{
    // Token: 0x0600046B RID: 1131 RVA: 0x0004281C File Offset: 0x00040C1C
    public Beards()
    {
        this.beards = new List<Beard>();
        while (this.beards.Count < this.beardSize())
        {
            this.beards.Add(new Beard());
        }
        this.activeBeards = new List<int>();
        this.capBeards = 1;
        this.energyBeardCount = 0;
        this.magicBeardCount = 0;
        this.disabled = false;
        this.transferredBankedLevels = true;
    }

    // Token: 0x0600046C RID: 1132 RVA: 0x00042893 File Offset: 0x00040C93
    public int beardSize()
    {
        return 7;
    }

    // Token: 0x0600046D RID: 1133 RVA: 0x00042896 File Offset: 0x00040C96
    public void checkBeards()
    {
        while (this.beards.Count < this.beardSize())
        {
            this.beards.Add(new Beard());
        }
    }

    // Token: 0x04000342 RID: 834
    public List<Beard> beards;

    // Token: 0x04000343 RID: 835
    public List<int> activeBeards;

    // Token: 0x04000344 RID: 836
    public int capBeards;

    // Token: 0x04000345 RID: 837
    public int energyBeardCount;

    // Token: 0x04000346 RID: 838
    public int magicBeardCount;

    // Token: 0x04000347 RID: 839
    public bool disabled;

    // Token: 0x04000348 RID: 840
    public bool transferredBankedLevels;
}
