using System;
using System.Collections.Generic;

// Token: 0x0200013F RID: 319
[Serializable]
public class Yggdrasil
{
    // Token: 0x060012C4 RID: 4804 RVA: 0x001061AC File Offset: 0x001045AC
    public Yggdrasil()
    {
        this.goldFruit = new Fruit();
        this.adventureFruit = new Fruit();
        this.luckFruit = new Fruit();
        this.statFruit = new Fruit();
        this.knowledgeFruit = new Fruit();
        this.pomegranate = new Fruit();
        this.seeds = 0L;
        this.resetFactor = 0f;
        this.totalLuck = 0L;
        this.totalPermStatBonus = 0L;
        this.permBonusOn = false;
        for (int i = 0; i < 21; i++)
        {
            this.fruits.Add(new Fruit());
        }
        this.usePoop = false;
    }

    // Token: 0x060012C5 RID: 4805 RVA: 0x00106260 File Offset: 0x00104660
    public void reset()
    {
        if (this.resetFactor > 1f)
        {
            this.resetFactor = 0f;
        }
        this.goldFruit.reset(this.resetFactor);
        this.adventureFruit.reset(this.resetFactor);
        this.luckFruit.reset(this.resetFactor);
        this.statFruit.reset(this.resetFactor);
        this.knowledgeFruit.reset(this.resetFactor);
        this.pomegranate.reset(this.resetFactor);
        this.statBonus = 0f;
        this.permBonusOn = false;
        this.permNumberBonusOn = false;
        for (int i = 0; i < 20; i++)
        {
            this.fruits[i].reset(this.resetFactor);
        }
    }

    // Token: 0x060012C6 RID: 4806 RVA: 0x00106331 File Offset: 0x00104731
    public double totalStatBonus()
    {
        return Math.Pow((double)this.fruits[1].totalLevels, 1.5);
    }

    // Token: 0x060012C7 RID: 4807 RVA: 0x00106353 File Offset: 0x00104753
    public void checkYggdrasil()
    {
        if (this.fruits == null)
        {
            this.fruits = new List<Fruit>();
        }
        while (this.fruits.Count < 14)
        {
            this.fruits.Add(new Fruit());
        }
    }

    // Token: 0x060012C8 RID: 4808 RVA: 0x00106394 File Offset: 0x00104794
    public void transferData()
    {
        this.fruits[0].totalLevels = this.goldFruit.totalLevels;
        this.fruits[0].seconds = this.goldFruit.seconds;
        this.fruits[0].activated = this.goldFruit.activated;
        this.fruits[0].maxTier = this.goldFruit.maxTier;
        this.fruits[1].totalLevels = this.statFruit.totalLevels;
        this.fruits[1].seconds = this.statFruit.seconds;
        this.fruits[1].activated = this.statFruit.activated;
        this.fruits[1].maxTier = this.statFruit.maxTier;
        this.fruits[2].totalLevels = this.adventureFruit.totalLevels;
        this.fruits[2].seconds = this.adventureFruit.seconds;
        this.fruits[2].activated = this.adventureFruit.activated;
        this.fruits[2].maxTier = this.adventureFruit.maxTier;
        this.fruits[3].totalLevels = this.knowledgeFruit.totalLevels;
        this.fruits[3].seconds = this.knowledgeFruit.seconds;
        this.fruits[3].activated = this.knowledgeFruit.activated;
        this.fruits[3].maxTier = this.knowledgeFruit.maxTier;
        this.fruits[4].totalLevels = this.pomegranate.totalLevels;
        this.fruits[4].seconds = this.pomegranate.seconds;
        this.fruits[4].activated = this.pomegranate.activated;
        this.fruits[4].maxTier = this.pomegranate.maxTier;
    }

    // Token: 0x04000E23 RID: 3619
    public Fruit goldFruit;

    // Token: 0x04000E24 RID: 3620
    public Fruit adventureFruit;

    // Token: 0x04000E25 RID: 3621
    public Fruit luckFruit;

    // Token: 0x04000E26 RID: 3622
    public Fruit statFruit;

    // Token: 0x04000E27 RID: 3623
    public Fruit knowledgeFruit;

    // Token: 0x04000E28 RID: 3624
    public Fruit pomegranate;

    // Token: 0x04000E29 RID: 3625
    public List<Fruit> fruits = new List<Fruit>();

    // Token: 0x04000E2A RID: 3626
    public float resetFactor;

    // Token: 0x04000E2B RID: 3627
    public float statBonus;

    // Token: 0x04000E2C RID: 3628
    public long seeds;

    // Token: 0x04000E2D RID: 3629
    public long totalLuck;

    // Token: 0x04000E2E RID: 3630
    public long totalPermStatBonus;

    // Token: 0x04000E2F RID: 3631
    public bool permBonusOn;

    // Token: 0x04000E30 RID: 3632
    public long totalPermStatBonus2;

    // Token: 0x04000E31 RID: 3633
    public long totalPermNumberBonus;

    // Token: 0x04000E32 RID: 3634
    public bool permNumberBonusOn;

    // Token: 0x04000E33 RID: 3635
    public bool usePoop;
}
