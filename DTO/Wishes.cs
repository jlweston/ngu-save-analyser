using System;
using System.Collections.Generic;

// Token: 0x02000130 RID: 304
[Serializable]
public class Wishes
{
    // Token: 0x06001184 RID: 4484 RVA: 0x000FB570 File Offset: 0x000F9970
    public Wishes()
    {
        this.wishes = new List<Wish>();
        this.wishesOn = false;
        for (int i = 0; i < this.wishSize(); i++)
        {
            this.wishes.Add(new Wish());
        }
        this.filterDiff = false;
        this.filterAfford = false;
        this.filterMaxxed = false;
        this.orderType = orderWish.Default;
    }

    // Token: 0x06001185 RID: 4485 RVA: 0x000FB5D8 File Offset: 0x000F99D8
    public int wishSize()
    {
        return 110;
    }

    // Token: 0x06001186 RID: 4486 RVA: 0x000FB5DC File Offset: 0x000F99DC
    public void updateWishes()
    {
        if (this.wishes == null)
        {
            this.wishes = new List<Wish>();
        }
        while (this.wishes.Count < this.wishSize())
        {
            this.wishes.Add(new Wish());
        }
    }

    // Token: 0x04000D6D RID: 3437
    public List<Wish> wishes;

    // Token: 0x04000D6E RID: 3438
    public bool wishesOn;

    // Token: 0x04000D6F RID: 3439
    public bool filterDiff;

    // Token: 0x04000D70 RID: 3440
    public bool filterAfford;

    // Token: 0x04000D71 RID: 3441
    public bool filterMaxxed;

    // Token: 0x04000D72 RID: 3442
    public orderWish orderType;
}
