using System;

// Token: 0x0200009C RID: 156
[Serializable]
public class Stats
{
    // Token: 0x06000A19 RID: 2585 RVA: 0x0007C910 File Offset: 0x0007AD10
    public Stats()
    {
        this.rebirthNumber = 0L;
        this.highestBoss = 0L;
        this.lifeTimeEnergy = 0L;
        this.advBossesKilled = 0L;
        this.highestDamageDealt = 0f;
        this.highestDamageTaken = 0f;
        this.totalExp = 0L;
        this.totalGold = 0.0;
        this.titansDefeated = 0L;
        this.bossesDefeated = 0L;
        this.lastBloodMagic = 0.0;
        this.poopUsed = 0L;
    }

    // Token: 0x06000A1A RID: 2586 RVA: 0x0007C997 File Offset: 0x0007AD97
    public void validateStats()
    {
        if (double.IsInfinity(this.totalGold))
        {
            this.totalGold = double.MaxValue;
        }
    }

    // Token: 0x040007F8 RID: 2040
    public long rebirthNumber;

    // Token: 0x040007F9 RID: 2041
    public long highestBoss;

    // Token: 0x040007FA RID: 2042
    public long lifeTimeEnergy;

    // Token: 0x040007FB RID: 2043
    public long advBossesKilled;

    // Token: 0x040007FC RID: 2044
    public float highestDamageDealt;

    // Token: 0x040007FD RID: 2045
    public float highestDamageTaken;

    // Token: 0x040007FE RID: 2046
    public long totalExp;

    // Token: 0x040007FF RID: 2047
    public double totalGold;

    // Token: 0x04000800 RID: 2048
    public long titansDefeated;

    // Token: 0x04000801 RID: 2049
    public long bossesDefeated;

    // Token: 0x04000802 RID: 2050
    public double lastBloodMagic;

    // Token: 0x04000803 RID: 2051
    public long poopUsed;
}
