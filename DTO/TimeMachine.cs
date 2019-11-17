using System;
using UnityEngine;

// Token: 0x020000EF RID: 239
[Serializable]
public class TimeMachine
{
    // Token: 0x06000F18 RID: 3864 RVA: 0x000E1398 File Offset: 0x000DF798
    public TimeMachine()
    {
        this.baseGold = 0f;
        this.machineProgress = 0f;
        this.machineEnergy = 0L;
        this.speedLevel = 0f;
        this.levelSpeed = 0L;
        this.speedBuildTime = 100000f;
        this.speedProgress = 0f;
        this.speedEnergy = 0L;
        this.speedGoldCost = 1E+09f;
        this.goldMultiLevel = 0f;
        this.levelGoldMulti = 0L;
        this.goldMultiProgress = 0f;
        this.goldMultiBuildTime = 1000000f;
        this.goldMultiMagic = 0L;
        this.goldMultiGoldCost = 1E+09f;
        this.speedTarget = 0L;
        this.multiTarget = 0L;
        this.speedBankLevels = 0L;
        this.goldMultiBankLevels = 0L;
        this.transferredBankLevels = true;
    }

    // Token: 0x06000F19 RID: 3865 RVA: 0x000E1470 File Offset: 0x000DF870
    public void reset()
    {
        this.machineEnergy = 0L;
        this.machineProgress = 0f;
        this.speedLevel = 0f;
        this.levelSpeed = 0L;
        this.speedProgress = 0f;
        this.goldMultiLevel = 0f;
        this.levelGoldMulti = 0L;
        this.machineProgress = 0f;
    }

    // Token: 0x06000F1A RID: 3866 RVA: 0x000E14CC File Offset: 0x000DF8CC
    public void advanceMachineProgress()
    {
    }

    // Token: 0x06000F1B RID: 3867 RVA: 0x000E14D0 File Offset: 0x000DF8D0
    public string timeLeftSpeed(float speed)
    {
        if (speed == 0f)
        {
            return "N/A";
        }
        if (this.speedEnergy == 0L)
        {
            float num = (1f - this.speedProgress) * (this.speedBuildTime * (float)(this.levelSpeed + 1L)) / (1000f * speed / 1000f);
            float num2 = Mathf.Floor(num / 86400f);
            num %= 86400f;
            float num3 = Mathf.Floor(num / 3600f);
            num %= 3600f;
            float num4 = Mathf.Floor(num / 60f);
            num %= 60f;
            return string.Concat(new object[]
            {
                num2,
                " days ",
                num3,
                " hours ",
                num4,
                " minutes ",
                num.ToString("#0.0"),
                " seconds (with 1000 Energy)"
            });
        }
        float num5 = (1f - this.speedProgress) * (this.speedBuildTime * (float)(this.levelSpeed + 1L)) / ((float)this.speedEnergy * speed / 1000f);
        float num6 = Mathf.Floor(num5 / 86400f);
        num5 %= 86400f;
        float num7 = Mathf.Floor(num5 / 3600f);
        num5 %= 3600f;
        float num8 = Mathf.Floor(num5 / 60f);
        num5 %= 60f;
        return string.Concat(new object[]
        {
            num6,
            " days ",
            num7,
            " hours ",
            num8,
            " minutes ",
            num5.ToString("#0.0"),
            " seconds (with ",
            this.speedEnergy,
            " Energy)"
        });
    }

    // Token: 0x06000F1C RID: 3868 RVA: 0x000E16D0 File Offset: 0x000DFAD0
    public string goldMultiTimeLeft(float magicSpeed)
    {
        if (magicSpeed == 0f)
        {
            return "N/A";
        }
        if (this.goldMultiMagic == 0L)
        {
            float num = (1f - this.goldMultiProgress) * (this.goldMultiBuildTime * (float)(this.levelGoldMulti + 1L)) / (1000f * magicSpeed / 1000f);
            float num2 = Mathf.Floor(num / 86400f);
            num %= 86400f;
            float num3 = Mathf.Floor(num / 3600f);
            num %= 3600f;
            float num4 = Mathf.Floor(num / 60f);
            num %= 60f;
            return string.Concat(new object[]
            {
                num2,
                " days ",
                num3,
                " hours ",
                num4,
                " minutes ",
                num.ToString("#0.0"),
                " seconds (with 1000 Magic)"
            });
        }
        float num5 = (1f - this.goldMultiProgress) * (this.goldMultiBuildTime * (float)(this.levelGoldMulti + 1L)) / ((float)this.goldMultiMagic * magicSpeed / 1000f);
        float num6 = Mathf.Floor(num5 / 86400f);
        num5 %= 86400f;
        float num7 = Mathf.Floor(num5 / 3600f);
        num5 %= 3600f;
        float num8 = Mathf.Floor(num5 / 60f);
        num5 %= 60f;
        return string.Concat(new object[]
        {
            num6,
            " days ",
            num7,
            " hours ",
            num8,
            " minutes ",
            num5.ToString("#0.0"),
            " seconds (with ",
            this.goldMultiMagic,
            "Magic)"
        });
    }

    // Token: 0x06000F1D RID: 3869 RVA: 0x000E18CF File Offset: 0x000DFCCF
    public float getSpeedCost()
    {
        return (float)(1L + this.levelSpeed) * this.speedGoldCost;
    }

    // Token: 0x06000F1E RID: 3870 RVA: 0x000E18E2 File Offset: 0x000DFCE2
    public float getGoldMultiCost()
    {
        return (float)(1L + this.levelGoldMulti) * this.goldMultiGoldCost;
    }

    // Token: 0x06000F1F RID: 3871 RVA: 0x000E18F5 File Offset: 0x000DFCF5
    public void updateBaseStats(float stime, float sgold, float gmtime, float gmgold)
    {
        this.speedBuildTime = stime;
        this.speedGoldCost = sgold;
        this.goldMultiBuildTime = gmtime;
        this.goldMultiGoldCost = gmgold;
    }

    // Token: 0x04000B3F RID: 2879
    public float baseGold;

    // Token: 0x04000B40 RID: 2880
    public float machineProgress;

    // Token: 0x04000B41 RID: 2881
    public long machineEnergy;

    // Token: 0x04000B42 RID: 2882
    public double realBaseGold;

    // Token: 0x04000B43 RID: 2883
    public float speedLevel;

    // Token: 0x04000B44 RID: 2884
    public long levelSpeed;

    // Token: 0x04000B45 RID: 2885
    public float speedBuildTime;

    // Token: 0x04000B46 RID: 2886
    public float speedProgress;

    // Token: 0x04000B47 RID: 2887
    public long speedEnergy;

    // Token: 0x04000B48 RID: 2888
    public float speedGoldCost;

    // Token: 0x04000B49 RID: 2889
    public float goldMultiLevel;

    // Token: 0x04000B4A RID: 2890
    public long levelGoldMulti;

    // Token: 0x04000B4B RID: 2891
    public float goldMultiBuildTime;

    // Token: 0x04000B4C RID: 2892
    public float goldMultiProgress;

    // Token: 0x04000B4D RID: 2893
    public long goldMultiMagic;

    // Token: 0x04000B4E RID: 2894
    public float goldMultiGoldCost;

    // Token: 0x04000B4F RID: 2895
    public long speedTarget;

    // Token: 0x04000B50 RID: 2896
    public long multiTarget;

    // Token: 0x04000B51 RID: 2897
    public long speedBankLevels;

    // Token: 0x04000B52 RID: 2898
    public long goldMultiBankLevels;

    // Token: 0x04000B53 RID: 2899
    public bool transferredBankLevels = true;
}
