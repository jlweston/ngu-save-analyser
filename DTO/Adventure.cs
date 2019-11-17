using System;

// Token: 0x02000008 RID: 8
[Serializable]
public class Adventure
{
    // Token: 0x0600004B RID: 75 RVA: 0x000057F8 File Offset: 0x00003BF8
    public Adventure()
    {
        this.zone = -1;
        this.autoattacking = false;
        this.attack = 10f;
        this.defense = 10f;
        this.regen = 1f;
        this.curHP = 10f;
        this.maxHP = 50f;
        this.respawnRate = 5f;
        this.attackSpeed = 1f;
        this.boss5Defeated = false;
        this.waldoDefeats = 0;
        this.waldoFinds = 0;
        this.boss5Kills = 0;
        this.titan1Kills = 0;
        this.titan2Kills = 0;
        this.titan3Kills = 0;
        this.titan4Kills = 0;
        this.titan5Kills = 0;
        this.titan6Kills = 0;
        this.idleAttackMulti = 1.2f;
        this.regAttackMulti = 1.5f;
        this.strongAttackMulti = 3f;
        this.pierceAttackMulti = 1f;
        this.ultimateAttackMulti = 1f;
        this.offenseBuffMulti = 1.2f;
        this.defenseBuffMulti = 1.2f;
        this.ultimateBuffMulti = 1.3f;
        this.chargeMulti = 2f;
        this.blockMulti = 2f;
        this.parryMulti = 2f;
        this.healMulti = 0.15f;
        this.focusMulti = 0.15f;
        this.paralyzeMulti = 3f;
        this.regAttackCooldown = 1f;
        this.strongAttackCooldown = 4f;
        this.pierceAttackCooldown = 8f;
        this.ultimateAttackCooldown = 15f;
        this.offenseBuffCooldown = 45f;
        this.defenseBuffCooldown = 45f;
        this.ultimateBuffCooldown = 45f;
        this.chargeCooldown = 30f;
        this.blockCooldown = 10f;
        this.parryCooldown = 15f;
        this.healCooldown = 15f;
        this.focusCooldown = 15f;
        this.paralyzeCooldown = 25f;
        this.blockDuration = 3f;
        this.offenseBuffDuration = 15f;
        this.defenseBuffDuration = 15f;
        this.ultimateBuffDuration = 15f;
        this.itopod = new ITOPOD();
        this.itopodStart = 0;
        this.itopodEnd = 20;
        this.highestItopodLevel = 0;
        this.titan6Version = 1;
        this.beastModeOn = false;
        this.didAdvAdvance = false;
        this.titan10Unlocked = true;
    }

    // Token: 0x0600004C RID: 76 RVA: 0x00005AB4 File Offset: 0x00003EB4
    public void resetAdventure()
    {
        this.zone = -1;
        this.idleAttackMulti = 1.2f;
        this.regAttackMulti = 1.5f;
        this.strongAttackMulti = 2f;
        this.pierceAttackMulti = 0.8f;
        this.ultimateAttackMulti = 1f;
        this.offenseBuffMulti = 1.2f;
        this.defenseBuffMulti = 1.2f;
        this.ultimateBuffMulti = 1.3f;
        this.chargeMulti = 2f;
        this.blockMulti = 2f;
        this.parryMulti = 2f;
        this.healMulti = 0.15f;
        this.focusMulti = 0.15f;
        this.regAttackCooldown = 1f;
        this.strongAttackCooldown = 4f;
        this.pierceAttackCooldown = 8f;
        this.ultimateAttackCooldown = 15f;
        this.offenseBuffCooldown = 45f;
        this.defenseBuffCooldown = 45f;
        this.ultimateBuffCooldown = 45f;
        this.chargeCooldown = 30f;
        this.blockCooldown = 10f;
        this.parryCooldown = 15f;
        this.healCooldown = 15f;
        this.focusCooldown = 15f;
        this.hyperRegenCooldown = 35f;
        this.blockDuration = 3f;
        this.offenseBuffDuration = 15f;
        this.defenseBuffDuration = 15f;
        this.ultimateBuffDuration = 15f;
        this.hyperRegenDuration = 5f;
        this.boss1Spawn.reset();
        this.boss1Defeated = false;
        this.titan1Kills = 0;
        this.boss2Spawn.reset();
        this.boss2Defeated = false;
        this.titan2Kills = 0;
        this.boss3Spawn.reset();
        this.boss3Defeated = false;
        this.titan3Kills = 0;
        this.boss4Spawn.reset();
        this.boss4Defeated = false;
        this.titan4Kills = 0;
        this.boss5Spawn.reset();
        this.boss5Defeated = false;
        this.titan5Kills = 0;
        this.boss6Spawn.reset();
        this.boss6Defeated = false;
        this.titan6Kills = 0;
        this.boss7Spawn.reset();
        this.boss7Defeated = false;
        this.titan7Kills = 0;
        this.boss8Spawn.reset();
        this.boss8Defeated = false;
        this.titan8Kills = 0;
        this.boss9Spawn.reset();
        this.boss9Defeated = false;
        this.titan9Kills = 0;
        this.boss10Spawn.reset();
        this.boss10Defeated = false;
        this.titan10Kills = 0;
        this.didAdvAdvance = false;
    }

    // Token: 0x0600004D RID: 77 RVA: 0x00005D20 File Offset: 0x00004120
    public void updateBaseStats()
    {
        this.idleAttackMulti = 1.2f;
        this.regAttackMulti = 1.5f;
        this.strongAttackMulti = 2f;
        this.pierceAttackMulti = 0.8f;
        this.ultimateAttackMulti = 1f;
        this.offenseBuffMulti = 1.2f;
        this.defenseBuffMulti = 1.2f;
        this.ultimateBuffMulti = 1.3f;
        this.chargeMulti = 2f;
        this.blockMulti = 2f;
        this.parryMulti = 2f;
        this.healMulti = 0.15f;
        this.focusMulti = 0.15f;
        this.paralyzeMulti = 0f;
        this.regAttackCooldown = 1f;
        this.strongAttackCooldown = 4f;
        this.pierceAttackCooldown = 5f;
        this.ultimateAttackCooldown = 15f;
        this.offenseBuffCooldown = 45f;
        this.defenseBuffCooldown = 45f;
        this.ultimateBuffCooldown = 45f;
        this.chargeCooldown = 30f;
        this.blockCooldown = 10f;
        this.parryCooldown = 15f;
        this.healCooldown = 15f;
        this.focusCooldown = 15f;
        this.paralyzeCooldown = 25f;
        this.blockDuration = 3f;
        this.offenseBuffDuration = 15f;
        this.defenseBuffDuration = 15f;
        this.ultimateBuffDuration = 15f;
    }

    // Token: 0x0600004E RID: 78 RVA: 0x00005E82 File Offset: 0x00004282
    public void setFasterIdleAttack()
    {
        this.attackSpeed = 0.8f;
    }

    // Token: 0x04000037 RID: 55
    public float attack;

    // Token: 0x04000038 RID: 56
    public float defense;

    // Token: 0x04000039 RID: 57
    public float regen;

    // Token: 0x0400003A RID: 58
    public float curHP;

    // Token: 0x0400003B RID: 59
    public float maxHP;

    // Token: 0x0400003C RID: 60
    public float respawnRate;

    // Token: 0x0400003D RID: 61
    public float attackSpeed;

    // Token: 0x0400003E RID: 62
    public int zone;

    // Token: 0x0400003F RID: 63
    public bool autoattacking;

    // Token: 0x04000040 RID: 64
    public PlayerTime boss1Spawn = new PlayerTime();

    // Token: 0x04000041 RID: 65
    public bool boss1Defeated;

    // Token: 0x04000042 RID: 66
    public int titan1Kills;

    // Token: 0x04000043 RID: 67
    public PlayerTime boss2Spawn = new PlayerTime();

    // Token: 0x04000044 RID: 68
    public bool boss2Defeated;

    // Token: 0x04000045 RID: 69
    public int titan2Kills;

    // Token: 0x04000046 RID: 70
    public PlayerTime boss3Spawn = new PlayerTime();

    // Token: 0x04000047 RID: 71
    public bool boss3Defeated;

    // Token: 0x04000048 RID: 72
    public int titan3Kills;

    // Token: 0x04000049 RID: 73
    public PlayerTime boss4Spawn = new PlayerTime();

    // Token: 0x0400004A RID: 74
    public bool boss4Defeated;

    // Token: 0x0400004B RID: 75
    public int titan4Kills;

    // Token: 0x0400004C RID: 76
    public PlayerTime boss5Spawn = new PlayerTime();

    // Token: 0x0400004D RID: 77
    public bool boss5Defeated;

    // Token: 0x0400004E RID: 78
    public int waldoDefeats;

    // Token: 0x0400004F RID: 79
    public int waldoFinds;

    // Token: 0x04000050 RID: 80
    public int boss5Kills;

    // Token: 0x04000051 RID: 81
    public int titan5Kills;

    // Token: 0x04000052 RID: 82
    public PlayerTime boss6Spawn = new PlayerTime();

    // Token: 0x04000053 RID: 83
    public bool boss6Defeated;

    // Token: 0x04000054 RID: 84
    public int titan6Kills;

    // Token: 0x04000055 RID: 85
    public bool clue1Complete;

    // Token: 0x04000056 RID: 86
    public bool clue2Complete;

    // Token: 0x04000057 RID: 87
    public bool clue3Complete;

    // Token: 0x04000058 RID: 88
    public bool clue4Complete;

    // Token: 0x04000059 RID: 89
    public bool titan6Unlocked;

    // Token: 0x0400005A RID: 90
    public int titan6Version;

    // Token: 0x0400005B RID: 91
    public int boss6Kills;

    // Token: 0x0400005C RID: 92
    public int titan6V1Kills;

    // Token: 0x0400005D RID: 93
    public int titan6V2Kills;

    // Token: 0x0400005E RID: 94
    public int titan6V3Kills;

    // Token: 0x0400005F RID: 95
    public int titan6V4Kills;

    // Token: 0x04000060 RID: 96
    public PlayerTime boss7Spawn = new PlayerTime();

    // Token: 0x04000061 RID: 97
    public bool boss7Defeated;

    // Token: 0x04000062 RID: 98
    public bool titan7questStarted;

    // Token: 0x04000063 RID: 99
    public int titan7QuestSequence;

    // Token: 0x04000064 RID: 100
    public bool titan7questComplete;

    // Token: 0x04000065 RID: 101
    public int titan7Kills;

    // Token: 0x04000066 RID: 102
    public bool titan7Unlocked;

    // Token: 0x04000067 RID: 103
    public int titan7Version;

    // Token: 0x04000068 RID: 104
    public int boss7Kills;

    // Token: 0x04000069 RID: 105
    public int titan7V1Kills;

    // Token: 0x0400006A RID: 106
    public int titan7V2Kills;

    // Token: 0x0400006B RID: 107
    public int titan7V3Kills;

    // Token: 0x0400006C RID: 108
    public int titan7V4Kills;

    // Token: 0x0400006D RID: 109
    public PlayerTime boss8Spawn = new PlayerTime();

    // Token: 0x0400006E RID: 110
    public bool boss8Defeated;

    // Token: 0x0400006F RID: 111
    public bool titan8questStarted;

    // Token: 0x04000070 RID: 112
    public int titan8QuestSequence;

    // Token: 0x04000071 RID: 113
    public bool titan8questComplete;

    // Token: 0x04000072 RID: 114
    public int titan8Kills;

    // Token: 0x04000073 RID: 115
    public bool titan8Unlocked;

    // Token: 0x04000074 RID: 116
    public int titan8Version;

    // Token: 0x04000075 RID: 117
    public int boss8Kills;

    // Token: 0x04000076 RID: 118
    public int titan8V1Kills;

    // Token: 0x04000077 RID: 119
    public int titan8V2Kills;

    // Token: 0x04000078 RID: 120
    public int titan8V3Kills;

    // Token: 0x04000079 RID: 121
    public int titan8V4Kills;

    // Token: 0x0400007A RID: 122
    public bool skeletonWhacked;

    // Token: 0x0400007B RID: 123
    public bool icarusWhacked;

    // Token: 0x0400007C RID: 124
    public bool emptyNameWhacked;

    // Token: 0x0400007D RID: 125
    public bool kingCircleWhacked;

    // Token: 0x0400007E RID: 126
    public bool robBossWhacked;

    // Token: 0x0400007F RID: 127
    public PlayerTime boss9Spawn = new PlayerTime();

    // Token: 0x04000080 RID: 128
    public bool boss9Defeated;

    // Token: 0x04000081 RID: 129
    public bool titan9questStarted;

    // Token: 0x04000082 RID: 130
    public bool titan9questComplete;

    // Token: 0x04000083 RID: 131
    public bool titan9SpecialReward;

    // Token: 0x04000084 RID: 132
    public int titan9Kills;

    // Token: 0x04000085 RID: 133
    public bool titan9Unlocked;

    // Token: 0x04000086 RID: 134
    public int titan9Version;

    // Token: 0x04000087 RID: 135
    public int boss9Kills;

    // Token: 0x04000088 RID: 136
    public int titan9V1Kills;

    // Token: 0x04000089 RID: 137
    public int titan9V2Kills;

    // Token: 0x0400008A RID: 138
    public int titan9V3Kills;

    // Token: 0x0400008B RID: 139
    public int titan9V4Kills;

    // Token: 0x0400008C RID: 140
    public PlayerTime boss10Spawn = new PlayerTime();

    // Token: 0x0400008D RID: 141
    public bool boss10Defeated;

    // Token: 0x0400008E RID: 142
    public bool titan10questStarted;

    // Token: 0x0400008F RID: 143
    public bool titan10SpecialReward;

    // Token: 0x04000090 RID: 144
    public int titan10Kills;

    // Token: 0x04000091 RID: 145
    public bool titan10Unlocked = true;

    // Token: 0x04000092 RID: 146
    public int titan10Version;

    // Token: 0x04000093 RID: 147
    public int boss10Kills;

    // Token: 0x04000094 RID: 148
    public int titan10V1Kills;

    // Token: 0x04000095 RID: 149
    public int titan10V2Kills;

    // Token: 0x04000096 RID: 150
    public int titan10V3Kills;

    // Token: 0x04000097 RID: 151
    public int titan10V4Kills;

    // Token: 0x04000098 RID: 152
    public int itopodStart;

    // Token: 0x04000099 RID: 153
    public int itopodEnd;

    // Token: 0x0400009A RID: 154
    public int highestItopodLevel;

    // Token: 0x0400009B RID: 155
    public ITOPOD itopod;

    // Token: 0x0400009C RID: 156
    public bool beastModeOn;

    // Token: 0x0400009D RID: 157
    public bool didAdvAdvance;

    // Token: 0x0400009E RID: 158
    [NonSerialized]
    public float idleAttackMulti;

    // Token: 0x0400009F RID: 159
    [NonSerialized]
    public float regAttackMulti;

    // Token: 0x040000A0 RID: 160
    [NonSerialized]
    public float strongAttackMulti;

    // Token: 0x040000A1 RID: 161
    [NonSerialized]
    public float pierceAttackMulti;

    // Token: 0x040000A2 RID: 162
    [NonSerialized]
    public float ultimateAttackMulti;

    // Token: 0x040000A3 RID: 163
    [NonSerialized]
    public float offenseBuffMulti;

    // Token: 0x040000A4 RID: 164
    [NonSerialized]
    public float defenseBuffMulti;

    // Token: 0x040000A5 RID: 165
    [NonSerialized]
    public float ultimateBuffMulti;

    // Token: 0x040000A6 RID: 166
    [NonSerialized]
    public float chargeMulti;

    // Token: 0x040000A7 RID: 167
    [NonSerialized]
    public float blockMulti;

    // Token: 0x040000A8 RID: 168
    [NonSerialized]
    public float parryMulti;

    // Token: 0x040000A9 RID: 169
    [NonSerialized]
    public float healMulti;

    // Token: 0x040000AA RID: 170
    [NonSerialized]
    public float focusMulti;

    // Token: 0x040000AB RID: 171
    [NonSerialized]
    public float paralyzeMulti;

    // Token: 0x040000AC RID: 172
    [NonSerialized]
    public float idleAttackCooldown;

    // Token: 0x040000AD RID: 173
    [NonSerialized]
    public float regAttackCooldown;

    // Token: 0x040000AE RID: 174
    [NonSerialized]
    public float strongAttackCooldown;

    // Token: 0x040000AF RID: 175
    [NonSerialized]
    public float pierceAttackCooldown;

    // Token: 0x040000B0 RID: 176
    [NonSerialized]
    public float ultimateAttackCooldown;

    // Token: 0x040000B1 RID: 177
    [NonSerialized]
    public float offenseBuffCooldown;

    // Token: 0x040000B2 RID: 178
    [NonSerialized]
    public float defenseBuffCooldown;

    // Token: 0x040000B3 RID: 179
    [NonSerialized]
    public float ultimateBuffCooldown;

    // Token: 0x040000B4 RID: 180
    [NonSerialized]
    public float chargeCooldown;

    // Token: 0x040000B5 RID: 181
    [NonSerialized]
    public float blockCooldown;

    // Token: 0x040000B6 RID: 182
    [NonSerialized]
    public float parryCooldown;

    // Token: 0x040000B7 RID: 183
    [NonSerialized]
    public float healCooldown;

    // Token: 0x040000B8 RID: 184
    [NonSerialized]
    public float focusCooldown;

    // Token: 0x040000B9 RID: 185
    [NonSerialized]
    public float paralyzeCooldown;

    // Token: 0x040000BA RID: 186
    [NonSerialized]
    public float hyperRegenCooldown;

    // Token: 0x040000BB RID: 187
    [NonSerialized]
    public float blockDuration;

    // Token: 0x040000BC RID: 188
    [NonSerialized]
    public float offenseBuffDuration;

    // Token: 0x040000BD RID: 189
    [NonSerialized]
    public float defenseBuffDuration;

    // Token: 0x040000BE RID: 190
    [NonSerialized]
    public float ultimateBuffDuration;

    // Token: 0x040000BF RID: 191
    [NonSerialized]
    public float hyperRegenDuration;
}
