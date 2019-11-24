using System;

// Token: 0x02000057 RID: 87
[Serializable]
public class Challenges

{
    // Token: 0x0600064F RID: 1615 RVA: 0x000534BC File Offset: 0x000518BC
    public Challenges()
    {
        this.basicChallenge = new Challenge();
        this.noAugsChallenge = new Challenge();
        this.hour24Challenge = new Challenge(false);
        this.levelChallenge10k = new Challenge();
        this.noEquipmentChallenge = new Challenge();
        this.noRebirthChallenge = new Challenge(false);
        this.trollChallenge = new Challenge();
        this.laserSwordChallenge = new Challenge();
        this.blindChallenge = new Challenge();
        this.timeMachineChallenge = new Challenge();
        this.nguChallenge = new Challenge();
        this.unlocked = false;
        this.inChallenge = false;
        this.curChallengeType = challengeType.None;
        this.curPoints = 0;
        this.maxPoints = 0;
        this.trollCounter = 0;
        this.trollUnlocked = false;
        this.trollDisplay = false;
        this.trollMenuSwap = false;
        this.trollDivided = false;
        this.laserSwordChallengeUnlocked = false;
        this.blindChallengeUnlocked = false;
    }

    // Token: 0x06000650 RID: 1616 RVA: 0x000535A0 File Offset: 0x000519A0
    public void updateAllChallenges()
    {
        if (this.basicChallenge == null)
        {
            this.basicChallenge = new Challenge();
        }
        if (this.noAugsChallenge == null)
        {
            this.noAugsChallenge = new Challenge();
        }
        if (this.hour24Challenge == null)
        {
            this.hour24Challenge = new Challenge(false);
        }
        if (this.levelChallenge10k == null)
        {
            this.levelChallenge10k = new Challenge();
        }
        if (this.noEquipmentChallenge == null)
        {
            this.noEquipmentChallenge = new Challenge();
        }
        if (this.noRebirthChallenge == null)
        {
            this.noRebirthChallenge = new Challenge(false);
        }
        if (this.trollChallenge == null)
        {
            this.trollChallenge = new Challenge();
        }
        if (this.laserSwordChallenge == null)
        {
            this.laserSwordChallenge = new Challenge();
        }
        if (this.blindChallenge == null)
        {
            this.blindChallenge = new Challenge();
        }
        if (this.nguChallenge == null)
        {
            this.nguChallenge = new Challenge();
        }
        if (this.timeMachineChallenge == null)
        {
            this.timeMachineChallenge = new Challenge();
        }
    }

    // Token: 0x04000484 RID: 1156
    public Challenge basicChallenge;

    // Token: 0x04000485 RID: 1157
    public Challenge noAugsChallenge;

    // Token: 0x04000486 RID: 1158
    public Challenge hour24Challenge;

    // Token: 0x04000487 RID: 1159
    public Challenge levelChallenge10k;

    // Token: 0x04000488 RID: 1160
    public Challenge noEquipmentChallenge;

    // Token: 0x04000489 RID: 1161
    public Challenge noRebirthChallenge;

    // Token: 0x0400048A RID: 1162
    public Challenge trollChallenge;

    // Token: 0x0400048B RID: 1163
    public Challenge laserSwordChallenge;

    // Token: 0x0400048C RID: 1164
    public Challenge blindChallenge;

    // Token: 0x0400048D RID: 1165
    public Challenge nguChallenge;

    // Token: 0x0400048E RID: 1166
    public Challenge timeMachineChallenge;

    // Token: 0x0400048F RID: 1167
    public bool unlocked;

    // Token: 0x04000490 RID: 1168
    public bool inChallenge;

    // Token: 0x04000491 RID: 1169
    public challengeType curChallengeType;

    // Token: 0x04000492 RID: 1170
    public int curPoints;

    // Token: 0x04000493 RID: 1171
    public int maxPoints;

    // Token: 0x04000494 RID: 1172
    public int trollCounter;

    // Token: 0x04000495 RID: 1173
    public bool trollUnlocked;

    // Token: 0x04000496 RID: 1174
    public bool trollDisplay;

    // Token: 0x04000497 RID: 1175
    public bool trollMenuSwap;

    // Token: 0x04000498 RID: 1176
    public bool trollDivided;

    // Token: 0x04000499 RID: 1177
    public bool blindChallengeUnlocked;

    // Token: 0x0400049A RID: 1178
    public bool laserSwordChallengeUnlocked;
}
