using System;
using System.Collections.Generic;

// Token: 0x02000059 RID: 89
[Serializable]
public class Cards
{
    // Token: 0x06000625 RID: 1573 RVA: 0x0005230C File Offset: 0x0005070C
    public Cards()
    {
        this.cards = new List<Card>();
        this.manas = new List<Mana>();
        this.bonuses = new List<float>();
        this.cardSpawnTimer = new PlayerTime();
        this.chonkerSpawnTimer = new PlayerTime();
        this.taggedBonuses = new List<cardBonus>();
        while (this.manas.Count < this.manaSize())
        {
            this.manas.Add(new Mana());
        }
        while (this.bonuses.Count < this.bonusesSize())
        {
            this.bonuses.Add(1f);
        }
        this.cardState = default(UnityEngine.Random.State);
        this.chonkerState = default(UnityEngine.Random.State);
        this.cardsOn = false;
        this.cardsGenerated = 0;
        this.extraDeckSpace = 0;
    }

    // Token: 0x06000626 RID: 1574 RVA: 0x000523EA File Offset: 0x000507EA
    public int bonusesSize()
    {
        return Enum.GetNames(typeof(cardBonus)).Length;
    }

    // Token: 0x06000627 RID: 1575 RVA: 0x000523FD File Offset: 0x000507FD
    public int manaSize()
    {
        return 6;
    }

    // Token: 0x06000628 RID: 1576 RVA: 0x00052400 File Offset: 0x00050800
    public void deleteCard(int index)
    {
        if (index < 0 || index >= this.cards.Count)
        {
            return;
        }
        this.cards.RemoveAt(index);
    }

    // Token: 0x06000629 RID: 1577 RVA: 0x00052427 File Offset: 0x00050827
    public bool filtered(Card newCard)
    {
        return false;
    }

    // Token: 0x0600062A RID: 1578 RVA: 0x0005242A File Offset: 0x0005082A
    public void updateCards()
    {
        while (this.bonuses.Count < this.bonusesSize())
        {
            this.bonuses.Add(1f);
        }
    }

    // Token: 0x04000478 RID: 1144
    public List<Card> cards;

    // Token: 0x04000479 RID: 1145
    public List<Mana> manas;

    // Token: 0x0400047A RID: 1146
    public bool cardsOn;

    // Token: 0x0400047B RID: 1147
    public List<float> bonuses;

    // Token: 0x0400047C RID: 1148
    public UnityEngine.Random.State cardState;

    // Token: 0x0400047D RID: 1149
    public UnityEngine.Random.State chonkerState;

    // Token: 0x0400047E RID: 1150
    public PlayerTime cardSpawnTimer;

    // Token: 0x0400047F RID: 1151
    public PlayerTime chonkerSpawnTimer;

    // Token: 0x04000480 RID: 1152
    public List<cardBonus> taggedBonuses;

    // Token: 0x04000481 RID: 1153
    public int cardsGenerated;

    // Token: 0x04000482 RID: 1154
    public int extraDeckSpace;
}
