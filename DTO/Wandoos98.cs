using System;
using UnityEngine;

// Token: 0x02000127 RID: 295
[Serializable]
public class Wandoos98
{
    // Token: 0x06001129 RID: 4393 RVA: 0x000F9034 File Offset: 0x000F7434
    public Wandoos98()
    {
        this.bootupProgress = 0f;
        this.energyProgress = 0f;
        this.magicProgress = 0f;
        this.energyLevel = 0L;
        this.magicLevel = 0L;
        this.wandoosEnergy = 0L;
        this.wandoosMagic = 0L;
        this.installed = false;
        this.disabled = false;
        this.bootupTime = new PlayerTime();
        this.installTime = new PlayerTime();
        this.os = OSType.wandoos98;
    }

    // Token: 0x0600112A RID: 4394 RVA: 0x000F90C9 File Offset: 0x000F74C9
    public void updateBaseStats()
    {
        if (this.installTime == null)
        {
            this.installTime = new PlayerTime();
        }
    }

    // Token: 0x0600112B RID: 4395 RVA: 0x000F90E4 File Offset: 0x000F74E4
    public void reset()
    {
        this.bootupTime.reset();
        this.bootupProgress = 0f;
        this.energyProgress = 0f;
        this.magicProgress = 0f;
        this.energyLevel = 0L;
        this.magicLevel = 0L;
        this.wandoosEnergy = 0L;
        this.wandoosMagic = 0L;
    }

    // Token: 0x0600112C RID: 4396 RVA: 0x000F913D File Offset: 0x000F753D
    public void changeOS(OSType newOS)
    {
        if (newOS == this.os)
        {
            return;
        }
        this.energyProgress = 0f;
        this.magicProgress = 0f;
        this.energyLevel = 0L;
        this.magicLevel = 0L;
        this.os = newOS;
    }

    // Token: 0x0600112D RID: 4397 RVA: 0x000F9179 File Offset: 0x000F7579
    public float timeFactor()
    {
        return Mathf.Min((float)(this.bootupTime.totalseconds / 3600.0), 1f);
    }

    // Token: 0x0600112E RID: 4398 RVA: 0x000F919B File Offset: 0x000F759B
    public double wandoosEnergyBonus()
    {
        return (double)(1f + (float)this.energyLevel / 100f);
    }

    // Token: 0x0600112F RID: 4399 RVA: 0x000F91B1 File Offset: 0x000F75B1
    public double wandoosMagicBonus()
    {
        return (double)(1f + (float)this.magicLevel / 25f);
    }

    // Token: 0x06001130 RID: 4400 RVA: 0x000F91C7 File Offset: 0x000F75C7
    public void validateWandoos()
    {
        if (this.installed)
        {
            this.installTime.totalseconds = 86400.0;
        }
    }

    // Token: 0x04000D29 RID: 3369
    public float energyProgress;

    // Token: 0x04000D2A RID: 3370
    public float magicProgress;

    // Token: 0x04000D2B RID: 3371
    public float bootupProgress;

    // Token: 0x04000D2C RID: 3372
    public long wandoosEnergy;

    // Token: 0x04000D2D RID: 3373
    public long wandoosMagic;

    // Token: 0x04000D2E RID: 3374
    public long energyLevel;

    // Token: 0x04000D2F RID: 3375
    public long magicLevel;

    // Token: 0x04000D30 RID: 3376
    public float baseEnergyTime;

    // Token: 0x04000D31 RID: 3377
    public float baseMagicTime;

    // Token: 0x04000D32 RID: 3378
    public long OSlevel;

    // Token: 0x04000D33 RID: 3379
    public long pitOSLevels;

    // Token: 0x04000D34 RID: 3380
    public long XLLevels;

    // Token: 0x04000D35 RID: 3381
    public bool installed;

    // Token: 0x04000D36 RID: 3382
    public bool disabled;

    // Token: 0x04000D37 RID: 3383
    public PlayerTime bootupTime = new PlayerTime();

    // Token: 0x04000D38 RID: 3384
    public PlayerTime installTime = new PlayerTime();

    // Token: 0x04000D39 RID: 3385
    public OSType os;
}
