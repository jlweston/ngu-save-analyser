using System;
using System.Collections.Generic;

// Token: 0x02000057 RID: 87
[Serializable]
public class Card
{
    // Token: 0x06000620 RID: 1568 RVA: 0x00052040 File Offset: 0x00050440
    public Card()
    {
        this.tier = 0;
        this.effectAmount = 0f;
        this.manaCosts = new List<int>(6);
        this.manaCosts[0] = 1;
        this.manaCosts[1] = 0;
        this.manaCosts[2] = 0;
        this.manaCosts[3] = 0;
        this.manaCosts[4] = 0;
        this.manaCosts[5] = 0;
        this.isProtected = false;
    }

    // Token: 0x06000621 RID: 1569 RVA: 0x000520C8 File Offset: 0x000504C8
    public Card(int cardTier, int art, string name, float cardEffect, cardType cardType, cardBonus cardBonus, rarity rarity, int mana1, int mana2, int mana3, int mana4, int mana5, int mana6)
    {
        this.tier = cardTier;
        this.artID = art;
        this.cardName = name;
        this.effectAmount = cardEffect;
        this.type = cardType;
        this.bonusType = cardBonus;
        this.cardRarity = rarity;
        this.manaCosts = new List<int>();
        this.manaCosts.Add(mana1);
        this.manaCosts.Add(mana2);
        this.manaCosts.Add(mana3);
        this.manaCosts.Add(mana4);
        this.manaCosts.Add(mana5);
        this.manaCosts.Add(mana6);
        this.isProtected = false;
    }

    // Token: 0x06000622 RID: 1570 RVA: 0x00052170 File Offset: 0x00050570
    public Card(Card otherCard)
    {
        this.tier = otherCard.tier;
        this.artID = otherCard.artID;
        this.cardName = otherCard.cardName;
        this.effectAmount = otherCard.effectAmount;
        this.type = otherCard.type;
        this.bonusType = otherCard.bonusType;
        this.cardRarity = otherCard.cardRarity;
        this.manaCosts = otherCard.manaCosts;
        this.isProtected = otherCard.isProtected;
    }

    // Token: 0x0400046C RID: 1132
    public int tier;

    // Token: 0x0400046D RID: 1133
    public int artID;

    // Token: 0x0400046E RID: 1134
    public string cardName;

    // Token: 0x0400046F RID: 1135
    public cardType type;

    // Token: 0x04000470 RID: 1136
    public float effectAmount;

    // Token: 0x04000471 RID: 1137
    public rarity cardRarity;

    // Token: 0x04000472 RID: 1138
    public cardBonus bonusType;

    // Token: 0x04000473 RID: 1139
    public List<int> manaCosts;

    // Token: 0x04000474 RID: 1140
    public bool isProtected;
}
