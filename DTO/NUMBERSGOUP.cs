using System;
using System.Collections.Generic;

// Token: 0x020000DC RID: 220
[Serializable]
public class NUMBERSSGOUP
{
    // Token: 0x06000E96 RID: 3734 RVA: 0x000DC7E4 File Offset: 0x000DABE4
    public NUMBERSSGOUP()
    {
        for (int i = 0; i < this.size(); i++)
        {
            this.skills.Add(new NGU());
        }
        for (int j = 0; j < this.size(); j++)
        {
            this.magicSkills.Add(new NGU());
        }
        this.autoAdvance = false;
        this.disabled = false;
    }

    // Token: 0x06000E97 RID: 3735 RVA: 0x000DC869 File Offset: 0x000DAC69
    public int size()
    {
        return 11;
    }

    // Token: 0x06000E98 RID: 3736 RVA: 0x000DC86D File Offset: 0x000DAC6D
    public int NGUEnergySize()
    {
        return 9;
    }

    // Token: 0x06000E99 RID: 3737 RVA: 0x000DC871 File Offset: 0x000DAC71
    public int NGUMagicSize()
    {
        return 7;
    }

    // Token: 0x06000E9A RID: 3738 RVA: 0x000DC874 File Offset: 0x000DAC74
    public void checkNGU()
    {
        if (this.skills == null)
        {
            this.skills = new List<NGU>();
        }
        while (this.skills.Count < this.size())
        {
            this.skills.Add(new NGU());
        }
        if (this.magicSkills == null)
        {
            this.magicSkills = new List<NGU>();
        }
        while (this.magicSkills.Count < this.size())
        {
            this.magicSkills.Add(new NGU());
        }
    }

    // Token: 0x04000AD2 RID: 2770
    public List<NGU> skills = new List<NGU>();

    // Token: 0x04000AD3 RID: 2771
    public List<NGU> magicSkills = new List<NGU>();

    // Token: 0x04000AD4 RID: 2772
    public bool autoAdvance;

    // Token: 0x04000AD5 RID: 2773
    public bool disabled;
}
