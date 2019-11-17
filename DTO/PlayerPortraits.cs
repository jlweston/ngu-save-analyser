using System;
using System.Collections.Generic;

// Token: 0x0200004A RID: 74
[Serializable]
public class PlayerPortraits
{
    // Token: 0x060005AB RID: 1451 RVA: 0x0004BDDC File Offset: 0x0004A1DC
    public PlayerPortraits()
    {
        this.portraitUnlocked = new List<bool>();
        while (this.portraitUnlocked.Count < this.maxPortraits())
        {
            this.portraitUnlocked.Add(false);
        }
        this.portraitUnlocked[0] = true;
        this.curPortrait = 0;
    }

    // Token: 0x060005AC RID: 1452 RVA: 0x0004BE35 File Offset: 0x0004A235
    public int maxPortraits()
    {
        return 52;
    }

    // Token: 0x060005AD RID: 1453 RVA: 0x0004BE3C File Offset: 0x0004A23C
    public void updatePortraits()
    {
        if (this.portraitUnlocked == null)
        {
            this.portraitUnlocked = new List<bool>();
        }
        while (this.portraitUnlocked.Count < this.maxPortraits())
        {
            this.portraitUnlocked.Add(false);
        }
        this.portraitUnlocked[0] = true;
    }

    // Token: 0x04000406 RID: 1030
    public List<bool> portraitUnlocked;

    // Token: 0x04000407 RID: 1031
    public int curPortrait;
}
