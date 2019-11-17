using System;
using System.Collections.Generic;

// Token: 0x02000040 RID: 64
[Serializable]
public class BloodMagic
{
    // Token: 0x0600052B RID: 1323 RVA: 0x00047854 File Offset: 0x00045C54
    public BloodMagic()
    {
        this.ritual = new List<Ritual>();
        this.updateRitualCount(this.size());
        this.bloodPoints = 0.0;
        this.rebirthPower = 1.0;
        this.adventureSpellTime = new PlayerTime();
        this.macguffin1Time = new PlayerTime();
        this.macguffin2Time = new PlayerTime();
        this.goldSpellBlood = 0.0;
        this.lootSpellBlood = 0.0;
        this.rebirthAutoSpell = false;
        this.lootAutoSpell = false;
        this.goldAutoSpell = false;
    }

    // Token: 0x0600052C RID: 1324 RVA: 0x00047907 File Offset: 0x00045D07
    public int size()
    {
        return 8;
    }

    // Token: 0x0600052D RID: 1325 RVA: 0x0004790C File Offset: 0x00045D0C
    public void updateRitualCount(int size)
    {
        for (int i = 0; i < size; i++)
        {
            this.ritual.Add(new Ritual());
        }
    }

    // Token: 0x040003A2 RID: 930
    public Ritual[] rituals = new Ritual[1];

    // Token: 0x040003A3 RID: 931
    public List<Ritual> ritual = new List<Ritual>();

    // Token: 0x040003A4 RID: 932
    public double bloodPoints;

    // Token: 0x040003A5 RID: 933
    public double rebirthPower;

    // Token: 0x040003A6 RID: 934
    public PlayerTime adventureSpellTime;

    // Token: 0x040003A7 RID: 935
    public PlayerTime macguffin1Time;

    // Token: 0x040003A8 RID: 936
    public PlayerTime macguffin2Time;

    // Token: 0x040003A9 RID: 937
    public double goldSpellBlood;

    // Token: 0x040003AA RID: 938
    public double lootSpellBlood;

    // Token: 0x040003AB RID: 939
    public bool rebirthAutoSpell;

    // Token: 0x040003AC RID: 940
    public bool lootAutoSpell;

    // Token: 0x040003AD RID: 941
    public bool goldAutoSpell;
}
