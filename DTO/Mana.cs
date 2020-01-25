using System;

// Token: 0x0200005C RID: 92
[Serializable]
public class Mana
{
    // Token: 0x060006D2 RID: 1746 RVA: 0x0005773F File Offset: 0x00055B3F
    public Mana()
    {
        this.progress = 0f;
        this.amount = 0;
        this.running = false;
    }

    // Token: 0x040004C4 RID: 1220
    public float progress;

    // Token: 0x040004C5 RID: 1221
    public int amount;

    // Token: 0x040004C6 RID: 1222
    public bool running;
}
