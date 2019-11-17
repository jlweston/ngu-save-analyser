using System;
using UnityEngine;

// Token: 0x02000116 RID: 278
[Serializable]
public class PlayerData
{
    // Token: 0x04000C8C RID: 3212
    public string playerName;

    // Token: 0x04000C8D RID: 3213
    public bool firstTimePlaying;

    // Token: 0x04000C8E RID: 3214
    public int version;

    // Token: 0x04000C8F RID: 3215
    public int lastTime;

    // Token: 0x04000C90 RID: 3216
    public difficulty nextRebirthDifficulty;

    // Token: 0x04000C91 RID: 3217
    public double maxHP;

    // Token: 0x04000C92 RID: 3218
    public double curHP;

    // Token: 0x04000C93 RID: 3219
    public double hpRegen;

    // Token: 0x04000C94 RID: 3220
    public double attack;

    // Token: 0x04000C95 RID: 3221
    public double defense;

    // Token: 0x04000C96 RID: 3222
    public float gold;

    // Token: 0x04000C97 RID: 3223
    public double realGold;

    // Token: 0x04000C98 RID: 3224
    public double attackMulti;

    // Token: 0x04000C99 RID: 3225
    public double defenseMulti;

    // Token: 0x04000C9A RID: 3226
    public double nextAttackMulti;

    // Token: 0x04000C9B RID: 3227
    public double nextDefenseMulti;

    // Token: 0x04000C9C RID: 3228
    public double oldBossMulti;

    // Token: 0x04000C9D RID: 3229
    public double timeMulti;

    // Token: 0x04000C9E RID: 3230
    public double oldTimeMulti;

    // Token: 0x04000C9F RID: 3231
    public int exp;

    // Token: 0x04000CA0 RID: 3232
    public long realExp;

    // Token: 0x04000CA1 RID: 3233
    public float attackBoost;

    // Token: 0x04000CA2 RID: 3234
    public float defenseBoost;

    // Token: 0x04000CA3 RID: 3235
    public float energySpeed;

    // Token: 0x04000CA4 RID: 3236
    public long capEnergy;

    // Token: 0x04000CA5 RID: 3237
    public long curEnergy;

    // Token: 0x04000CA6 RID: 3238
    public long idleEnergy;

    // Token: 0x04000CA7 RID: 3239
    public long energyGained;

    // Token: 0x04000CA8 RID: 3240
    public int energyPerBar;

    // Token: 0x04000CA9 RID: 3241
    public long energyBars;

    // Token: 0x04000CAA RID: 3242
    public float energyPower;

    // Token: 0x04000CAB RID: 3243
    public float energyBarProgress;

    // Token: 0x04000CAC RID: 3244
    public Training training;

    // Token: 0x04000CAD RID: 3245
    public int bossID;

    // Token: 0x04000CAE RID: 3246
    public double bossAttack;

    // Token: 0x04000CAF RID: 3247
    public double bossDefense;

    // Token: 0x04000CB0 RID: 3248
    public double bossRegen;

    // Token: 0x04000CB1 RID: 3249
    public double bossCurHP;

    // Token: 0x04000CB2 RID: 3250
    public double bossMaxHP;

    // Token: 0x04000CB3 RID: 3251
    public double bossMulti;

    // Token: 0x04000CB4 RID: 3252
    public int highestBoss;

    // Token: 0x04000CB5 RID: 3253
    public int highestHardBoss;

    // Token: 0x04000CB6 RID: 3254
    public int highestSadisticBoss;

    // Token: 0x04000CB7 RID: 3255
    public bool firstBossEver;

    // Token: 0x04000CB8 RID: 3256
    public int currentHighestBoss;

    // Token: 0x04000CB9 RID: 3257
    public Adventure adventure;

    // Token: 0x04000CBA RID: 3258
    public Inventory inventory;

    // Token: 0x04000CBB RID: 3259
    public AdvancedTraining advancedTraining;

    // Token: 0x04000CBC RID: 3260
    public Augmentation augments;

    // Token: 0x04000CBD RID: 3261
    public Magic magic;

    // Token: 0x04000CBE RID: 3262
    public TimeMachine machine;

    // Token: 0x04000CBF RID: 3263
    public BloodMagic bloodMagic;

    // Token: 0x04000CC0 RID: 3264
    public PlayerTime rebirthTime;

    // Token: 0x04000CC1 RID: 3265
    public PlayerTime totalPlaytime;

    // Token: 0x04000CC2 RID: 3266
    //public UnityEngine.Random.State lootState;

    // Token: 0x04000CC3 RID: 3267
    //public UnityEngine.Random.State boostState;

    // Token: 0x04000CC4 RID: 3268
    public Purchases purchases;

    // Token: 0x04000CC5 RID: 3269
    public Stats stats;

    // Token: 0x04000CC6 RID: 3270
    public Perks perks;

    // Token: 0x04000CC7 RID: 3271
    public PlayerSettings settings;

    // Token: 0x04000CC8 RID: 3272
    public Challenges challenges;

    // Token: 0x04000CC9 RID: 3273
    public Pit pit;

    // Token: 0x04000CCA RID: 3274
    public LootBoxes lootBoxes;

    // Token: 0x04000CCB RID: 3275
    public Wandoos98 wandoos98;

    // Token: 0x04000CCC RID: 3276
    public Yggdrasil yggdrasil;

    // Token: 0x04000CCD RID: 3277
    public NUMBERSSGOUP NGU;

    // Token: 0x04000CCE RID: 3278
    public Arbitrary arbitrary;

    // Token: 0x04000CCF RID: 3279
    public AchievementList achievements;

    // Token: 0x04000CD0 RID: 3280
    public DailyReward daily;

    // Token: 0x04000CD1 RID: 3281
    public Beards beards;

    // Token: 0x04000CD2 RID: 3282
    public GoldDiggers diggers;

    // Token: 0x04000CD3 RID: 3283
    public BeastQuest beastQuest;

    // Token: 0x04000CD4 RID: 3284
    public Resource3 res3;

    // Token: 0x04000CD5 RID: 3285
    public Hacks hacks;

    // Token: 0x04000CD6 RID: 3286
    public Wishes wishes;

    // Token: 0x04000CD7 RID: 3287
    public PlayerPortraits portraits;
}
