using System;
using UnityEngine;

// Token: 0x02000126 RID: 294
[Serializable]
public class PlayerData
{
    // Token: 0x04000CFD RID: 3325
    public string playerName;

    // Token: 0x04000CFE RID: 3326
    public bool firstTimePlaying;

    // Token: 0x04000CFF RID: 3327
    public int version;

    // Token: 0x04000D00 RID: 3328
    public int lastTime;

    // Token: 0x04000D01 RID: 3329
    public difficulty nextRebirthDifficulty;

    // Token: 0x04000D02 RID: 3330
    public double maxHP;

    // Token: 0x04000D03 RID: 3331
    public double curHP;

    // Token: 0x04000D04 RID: 3332
    public double hpRegen;

    // Token: 0x04000D05 RID: 3333
    public double attack;

    // Token: 0x04000D06 RID: 3334
    public double defense;

    // Token: 0x04000D07 RID: 3335
    public float gold;

    // Token: 0x04000D08 RID: 3336
    public double realGold;

    // Token: 0x04000D09 RID: 3337
    public double attackMulti;

    // Token: 0x04000D0A RID: 3338
    public double defenseMulti;

    // Token: 0x04000D0B RID: 3339
    public double nextAttackMulti;

    // Token: 0x04000D0C RID: 3340
    public double nextDefenseMulti;

    // Token: 0x04000D0D RID: 3341
    public double oldBossMulti;

    // Token: 0x04000D0E RID: 3342
    public double timeMulti;

    // Token: 0x04000D0F RID: 3343
    public double oldTimeMulti;

    // Token: 0x04000D10 RID: 3344
    public int exp;

    // Token: 0x04000D11 RID: 3345
    public long realExp;

    // Token: 0x04000D12 RID: 3346
    public float attackBoost;

    // Token: 0x04000D13 RID: 3347
    public float defenseBoost;

    // Token: 0x04000D14 RID: 3348
    public float energySpeed;

    // Token: 0x04000D15 RID: 3349
    public long capEnergy;

    // Token: 0x04000D16 RID: 3350
    public long curEnergy;

    // Token: 0x04000D17 RID: 3351
    public long idleEnergy;

    // Token: 0x04000D18 RID: 3352
    public long energyGained;

    // Token: 0x04000D19 RID: 3353
    public int energyPerBar;

    // Token: 0x04000D1A RID: 3354
    public long energyBars;

    // Token: 0x04000D1B RID: 3355
    public float energyPower;

    // Token: 0x04000D1C RID: 3356
    public float energyBarProgress;

    // Token: 0x04000D1D RID: 3357
    public Training training;

    // Token: 0x04000D1E RID: 3358
    public int bossID;

    // Token: 0x04000D1F RID: 3359
    public double bossAttack;

    // Token: 0x04000D20 RID: 3360
    public double bossDefense;

    // Token: 0x04000D21 RID: 3361
    public double bossRegen;

    // Token: 0x04000D22 RID: 3362
    public double bossCurHP;

    // Token: 0x04000D23 RID: 3363
    public double bossMaxHP;

    // Token: 0x04000D24 RID: 3364
    public double bossMulti;

    // Token: 0x04000D25 RID: 3365
    public int highestBoss;

    // Token: 0x04000D26 RID: 3366
    public int highestHardBoss;

    // Token: 0x04000D27 RID: 3367
    public int highestSadisticBoss;

    // Token: 0x04000D28 RID: 3368
    public bool firstBossEver;

    // Token: 0x04000D29 RID: 3369
    public int currentHighestBoss;

    // Token: 0x04000D2A RID: 3370
    public Adventure adventure;

    // Token: 0x04000D2B RID: 3371
    public Inventory inventory;

    // Token: 0x04000D2C RID: 3372
    public AdvancedTraining advancedTraining;

    // Token: 0x04000D2D RID: 3373
    public Augmentation augments;

    // Token: 0x04000D2E RID: 3374
    public Magic magic;

    // Token: 0x04000D2F RID: 3375
    public TimeMachine machine;

    // Token: 0x04000D30 RID: 3376
    public BloodMagic bloodMagic;

    // Token: 0x04000D31 RID: 3377
    public PlayerTime rebirthTime;

    // Token: 0x04000D32 RID: 3378
    public PlayerTime totalPlaytime;

    // Token: 0x04000D33 RID: 3379
    public UnityEngine.Random.State lootState;

    // Token: 0x04000D34 RID: 3380
    public UnityEngine.Random.State boostState;

    // Token: 0x04000D35 RID: 3381
    public Purchases purchases;

    // Token: 0x04000D36 RID: 3382
    public Stats stats;

    // Token: 0x04000D37 RID: 3383
    public Perks perks;

    // Token: 0x04000D38 RID: 3384
    public PlayerSettings settings;

    // Token: 0x04000D39 RID: 3385
    public Challenges challenges;

    // Token: 0x04000D3A RID: 3386
    public Pit pit;

    // Token: 0x04000D3B RID: 3387
    public LootBoxes lootBoxes;

    // Token: 0x04000D3C RID: 3388
    public Wandoos98 wandoos98;

    // Token: 0x04000D3D RID: 3389
    public Yggdrasil yggdrasil;

    // Token: 0x04000D3E RID: 3390
    public NUMBERSSGOUP NGU;

    // Token: 0x04000D3F RID: 3391
    public Arbitrary arbitrary;

    // Token: 0x04000D40 RID: 3392
    public AchievementList achievements;

    // Token: 0x04000D41 RID: 3393
    public DailyReward daily;

    // Token: 0x04000D42 RID: 3394
    public Beards beards;

    // Token: 0x04000D43 RID: 3395
    public GoldDiggers diggers;

    // Token: 0x04000D44 RID: 3396
    public BeastQuest beastQuest;

    // Token: 0x04000D45 RID: 3397
    public Resource3 res3;

    // Token: 0x04000D46 RID: 3398
    public Hacks hacks;

    // Token: 0x04000D47 RID: 3399
    public Wishes wishes;

    // Token: 0x04000D48 RID: 3400
    public PlayerPortraits portraits;

    // Token: 0x04000D49 RID: 3401
    public Bestiary bestiary;

    // Token: 0x04000D4A RID: 3402
    public Cards cards;
}
