using System;
using UnityEngine;

// Token: 0x0200011B RID: 283
[Serializable]
public class PlayerData
{
    // Token: 0x04000CAD RID: 3245
    public string playerName;

    // Token: 0x04000CAE RID: 3246
    public bool firstTimePlaying;

    // Token: 0x04000CAF RID: 3247
    public int version;

    // Token: 0x04000CB0 RID: 3248
    public int lastTime;

    // Token: 0x04000CB1 RID: 3249
    public difficulty nextRebirthDifficulty;

    // Token: 0x04000CB2 RID: 3250
    public double maxHP;

    // Token: 0x04000CB3 RID: 3251
    public double curHP;

    // Token: 0x04000CB4 RID: 3252
    public double hpRegen;

    // Token: 0x04000CB5 RID: 3253
    public double attack;

    // Token: 0x04000CB6 RID: 3254
    public double defense;

    // Token: 0x04000CB7 RID: 3255
    public float gold;

    // Token: 0x04000CB8 RID: 3256
    public double realGold;

    // Token: 0x04000CB9 RID: 3257
    public double attackMulti;

    // Token: 0x04000CBA RID: 3258
    public double defenseMulti;

    // Token: 0x04000CBB RID: 3259
    public double nextAttackMulti;

    // Token: 0x04000CBC RID: 3260
    public double nextDefenseMulti;

    // Token: 0x04000CBD RID: 3261
    public double oldBossMulti;

    // Token: 0x04000CBE RID: 3262
    public double timeMulti;

    // Token: 0x04000CBF RID: 3263
    public double oldTimeMulti;

    // Token: 0x04000CC0 RID: 3264
    public int exp;

    // Token: 0x04000CC1 RID: 3265
    public long realExp;

    // Token: 0x04000CC2 RID: 3266
    public float attackBoost;

    // Token: 0x04000CC3 RID: 3267
    public float defenseBoost;

    // Token: 0x04000CC4 RID: 3268
    public float energySpeed;

    // Token: 0x04000CC5 RID: 3269
    public long capEnergy;

    // Token: 0x04000CC6 RID: 3270
    public long curEnergy;

    // Token: 0x04000CC7 RID: 3271
    public long idleEnergy;

    // Token: 0x04000CC8 RID: 3272
    public long energyGained;

    // Token: 0x04000CC9 RID: 3273
    public int energyPerBar;

    // Token: 0x04000CCA RID: 3274
    public long energyBars;

    // Token: 0x04000CCB RID: 3275
    public float energyPower;

    // Token: 0x04000CCC RID: 3276
    public float energyBarProgress;

    // Token: 0x04000CCD RID: 3277
    public Training training;

    // Token: 0x04000CCE RID: 3278
    public int bossID;

    // Token: 0x04000CCF RID: 3279
    public double bossAttack;

    // Token: 0x04000CD0 RID: 3280
    public double bossDefense;

    // Token: 0x04000CD1 RID: 3281
    public double bossRegen;

    // Token: 0x04000CD2 RID: 3282
    public double bossCurHP;

    // Token: 0x04000CD3 RID: 3283
    public double bossMaxHP;

    // Token: 0x04000CD4 RID: 3284
    public double bossMulti;

    // Token: 0x04000CD5 RID: 3285
    public int highestBoss;

    // Token: 0x04000CD6 RID: 3286
    public int highestHardBoss;

    // Token: 0x04000CD7 RID: 3287
    public int highestSadisticBoss;

    // Token: 0x04000CD8 RID: 3288
    public bool firstBossEver;

    // Token: 0x04000CD9 RID: 3289
    public int currentHighestBoss;

    // Token: 0x04000CDA RID: 3290
    public Adventure adventure;

    // Token: 0x04000CDB RID: 3291
    public Inventory inventory;

    // Token: 0x04000CDC RID: 3292
    public AdvancedTraining advancedTraining;

    // Token: 0x04000CDD RID: 3293
    public Augmentation augments;

    // Token: 0x04000CDE RID: 3294
    public Magic magic;

    // Token: 0x04000CDF RID: 3295
    public TimeMachine machine;

    // Token: 0x04000CE0 RID: 3296
    public BloodMagic bloodMagic;

    // Token: 0x04000CE1 RID: 3297
    public PlayerTime rebirthTime;

    // Token: 0x04000CE2 RID: 3298
    public PlayerTime totalPlaytime;

    // Token: 0x04000CE5 RID: 3301
    public Purchases purchases;

    // Token: 0x04000CE6 RID: 3302
    public Stats stats;

    // Token: 0x04000CE7 RID: 3303
    public Perks perks;

    // Token: 0x04000CE8 RID: 3304
    public PlayerSettings settings;

    // Token: 0x04000CE9 RID: 3305
    public Challenges challenges;

    // Token: 0x04000CEA RID: 3306
    public Pit pit;

    // Token: 0x04000CEB RID: 3307
    public LootBoxes lootBoxes;

    // Token: 0x04000CEC RID: 3308
    public Wandoos98 wandoos98;

    // Token: 0x04000CED RID: 3309
    public Yggdrasil yggdrasil;

    // Token: 0x04000CEE RID: 3310
    public NUMBERSSGOUP NGU;

    // Token: 0x04000CEF RID: 3311
    public Arbitrary arbitrary;

    // Token: 0x04000CF0 RID: 3312
    public AchievementList achievements;

    // Token: 0x04000CF1 RID: 3313
    public DailyReward daily;

    // Token: 0x04000CF2 RID: 3314
    public Beards beards;

    // Token: 0x04000CF3 RID: 3315
    public GoldDiggers diggers;

    // Token: 0x04000CF4 RID: 3316
    public BeastQuest beastQuest;

    // Token: 0x04000CF5 RID: 3317
    public Resource3 res3;

    // Token: 0x04000CF6 RID: 3318
    public Hacks hacks;

    // Token: 0x04000CF7 RID: 3319
    public Wishes wishes;

    // Token: 0x04000CF8 RID: 3320
    public PlayerPortraits portraits;

    // Token: 0x04000CF9 RID: 3321
    public Bestiary bestiary;
}
