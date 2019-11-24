using System;
using System.Collections.Generic;

// Token: 0x02000003 RID: 3
[Serializable]
public class AchievementList
{
    // Token: 0x06000006 RID: 6 RVA: 0x00002260 File Offset: 0x00000660
    public AchievementList()
    {
        for (int i = 0; i < this.achievementsSize(); i++)
        {
            this.achievementComplete.Add(false);
        }
        this.totalAchieves = 0;
    }

    // Token: 0x06000007 RID: 7 RVA: 0x000022A8 File Offset: 0x000006A8
    public int achievementsSize()
    {
        return 153;
    }

    // Token: 0x06000008 RID: 8 RVA: 0x000022AF File Offset: 0x000006AF
    public void validate()
    {
        if (this.achievementComplete == null)
        {
            this.achievementComplete = new List<bool>();
        }
        while (this.achievementComplete.Count < this.achievementsSize())
        {
            this.achievementComplete.Add(false);
        }
    }

    // Token: 0x06000009 RID: 9 RVA: 0x000022F0 File Offset: 0x000006F0
    //public void debugList()
    //{
    //    for (int i = 0; i < this.achievementComplete.Count; i++)
    //    {
    //        Debug.Log(i + " id dropped is " + this.achievementComplete[i]);
    //    }
    //}

    // Token: 0x0600000A RID: 10 RVA: 0x0000233F File Offset: 0x0000073F
    //public void debugList(int i)
    //{
    //    Debug.Log(i + " id dropped is " + this.achievementComplete[i]);
    //}

    // Token: 0x04000007 RID: 7
    public List<bool> achievementComplete = new List<bool>();

    // Token: 0x04000008 RID: 8
    public int totalAchieves;
}
