using System;

// Token: 0x020000FC RID: 252
[Serializable]
public class Training
{
    // Token: 0x06000FAB RID: 4011 RVA: 0x000E6648 File Offset: 0x000E4A48
    public Training()
    {
        for (int i = 0; i < 6; i++)
        {
            this.attackTraining[i] = 0L;
            this.defenseTraining[i] = 0L;
            this.attackEnergy[i] = 0L;
            this.defenseEnergy[i] = 0L;
            this.totalDefenseLevels = 0L;
            this.totalAttackLevels = 0L;
            this.attackBarProgress[i] = 0f;
            this.defenseBarProgress[i] = 0f;
        }
        this.hasAutoAdvance = false;
        this.autoAdvanceToggle = false;
    }

    // Token: 0x17000010 RID: 16
    // (get) Token: 0x06000FAC RID: 4012 RVA: 0x000E6788 File Offset: 0x000E4B88
    // (set) Token: 0x06000FAD RID: 4013 RVA: 0x000E6790 File Offset: 0x000E4B90
    public int[] attackCaps
    {
        get
        {
            return this._attackCaps;
        }
        set
        {
            this._attackCaps = value;
        }
    }

    // Token: 0x17000011 RID: 17
    // (get) Token: 0x06000FAE RID: 4014 RVA: 0x000E6799 File Offset: 0x000E4B99
    // (set) Token: 0x06000FAF RID: 4015 RVA: 0x000E67A1 File Offset: 0x000E4BA1
    public int[] defenseCaps
    {
        get
        {
            return this._defenseCaps;
        }
        set
        {
            this._defenseCaps = value;
        }
    }

    // Token: 0x06000FB0 RID: 4016 RVA: 0x000E67AA File Offset: 0x000E4BAA
    public int getTrainingSize()
    {
        return this._attackCaps.Length;
    }

    // Token: 0x17000012 RID: 18
    // (get) Token: 0x06000FB1 RID: 4017 RVA: 0x000E67B4 File Offset: 0x000E4BB4
    // (set) Token: 0x06000FB2 RID: 4018 RVA: 0x000E67BC File Offset: 0x000E4BBC
    public long[] attackTraining
    {
        get
        {
            return this._attackTraining;
        }
        set
        {
            this._attackTraining = value;
        }
    }

    // Token: 0x17000013 RID: 19
    // (get) Token: 0x06000FB3 RID: 4019 RVA: 0x000E67C5 File Offset: 0x000E4BC5
    // (set) Token: 0x06000FB4 RID: 4020 RVA: 0x000E67CD File Offset: 0x000E4BCD
    public long[] defenseTraining
    {
        get
        {
            return this._defenseTraining;
        }
        set
        {
            this._defenseTraining = value;
        }
    }

    // Token: 0x17000014 RID: 20
    // (get) Token: 0x06000FB5 RID: 4021 RVA: 0x000E67D6 File Offset: 0x000E4BD6
    // (set) Token: 0x06000FB6 RID: 4022 RVA: 0x000E67DE File Offset: 0x000E4BDE
    public long[] attackEnergy
    {
        get
        {
            return this._attackEnergy;
        }
        set
        {
            this._attackEnergy = value;
        }
    }

    // Token: 0x17000015 RID: 21
    // (get) Token: 0x06000FB7 RID: 4023 RVA: 0x000E67E7 File Offset: 0x000E4BE7
    // (set) Token: 0x06000FB8 RID: 4024 RVA: 0x000E67EF File Offset: 0x000E4BEF
    public long[] defenseEnergy
    {
        get
        {
            return this._defenseEnergy;
        }
        set
        {
            this._defenseEnergy = value;
        }
    }

    // Token: 0x17000016 RID: 22
    // (get) Token: 0x06000FB9 RID: 4025 RVA: 0x000E67F8 File Offset: 0x000E4BF8
    // (set) Token: 0x06000FBA RID: 4026 RVA: 0x000E6800 File Offset: 0x000E4C00
    public long totalAttackLevels
    {
        get
        {
            return this._totalAttackLevels;
        }
        set
        {
            this._totalAttackLevels = value;
        }
    }

    // Token: 0x17000017 RID: 23
    // (get) Token: 0x06000FBB RID: 4027 RVA: 0x000E6809 File Offset: 0x000E4C09
    // (set) Token: 0x06000FBC RID: 4028 RVA: 0x000E6811 File Offset: 0x000E4C11
    public long totalDefenseLevels
    {
        get
        {
            return this._totalDefenseLevels;
        }
        set
        {
            this._totalDefenseLevels = value;
        }
    }

    // Token: 0x17000018 RID: 24
    // (get) Token: 0x06000FBD RID: 4029 RVA: 0x000E681A File Offset: 0x000E4C1A
    // (set) Token: 0x06000FBE RID: 4030 RVA: 0x000E6822 File Offset: 0x000E4C22
    public float[] attackBarProgress
    {
        get
        {
            return this._attackBarProgress;
        }
        set
        {
            this._attackBarProgress = value;
        }
    }

    // Token: 0x17000019 RID: 25
    // (get) Token: 0x06000FBF RID: 4031 RVA: 0x000E682B File Offset: 0x000E4C2B
    // (set) Token: 0x06000FC0 RID: 4032 RVA: 0x000E6833 File Offset: 0x000E4C33
    public float[] defenseBarProgress
    {
        get
        {
            return this._defenseBarProgress;
        }
        set
        {
            this._defenseBarProgress = value;
        }
    }

    // Token: 0x1700001A RID: 26
    // (get) Token: 0x06000FC1 RID: 4033 RVA: 0x000E683C File Offset: 0x000E4C3C
    // (set) Token: 0x06000FC2 RID: 4034 RVA: 0x000E6844 File Offset: 0x000E4C44
    public int[] trainFactor
    {
        get
        {
            return this._trainFactor;
        }
        set
        {
            this._trainFactor = value;
        }
    }

    // Token: 0x1700001B RID: 27
    // (get) Token: 0x06000FC3 RID: 4035 RVA: 0x000E684D File Offset: 0x000E4C4D
    // (set) Token: 0x06000FC4 RID: 4036 RVA: 0x000E6855 File Offset: 0x000E4C55
    public bool hasAutoAdvance
    {
        get
        {
            return this._hasAutoAdvance;
        }
        set
        {
            this._hasAutoAdvance = value;
        }
    }

    // Token: 0x1700001C RID: 28
    // (get) Token: 0x06000FC5 RID: 4037 RVA: 0x000E685E File Offset: 0x000E4C5E
    // (set) Token: 0x06000FC6 RID: 4038 RVA: 0x000E6866 File Offset: 0x000E4C66
    public bool autoAdvanceToggle
    {
        get
        {
            return this._autoAdvanceToggle;
        }
        set
        {
            this._autoAdvanceToggle = value;
        }
    }

    // Token: 0x06000FC7 RID: 4039 RVA: 0x000E6870 File Offset: 0x000E4C70
    public double getTotalAttack()
    {
        double num = 0.0;
        for (int i = 0; i < this.getTrainingSize(); i++)
        {
            num += Math.Pow((double)this.attackTraining[i], 1.3) * (double)this.trainFactor[i];
        }
        return num;
    }

    // Token: 0x06000FC8 RID: 4040 RVA: 0x000E68C4 File Offset: 0x000E4CC4
    public double getTotalDefense()
    {
        double num = 0.0;
        for (int i = 0; i < this.getTrainingSize(); i++)
        {
            num += Math.Pow((double)this.defenseTraining[i], 1.3) * (double)this.trainFactor[i];
        }
        return num;
    }

    // Token: 0x06000FC9 RID: 4041 RVA: 0x000E6917 File Offset: 0x000E4D17
    public void updateBaseStats(int f0, int f1, int f2, int f3, int f4, int f5)
    {
        this.trainFactor[0] = f0;
        this.trainFactor[1] = f1;
        this.trainFactor[2] = f2;
        this.trainFactor[3] = f3;
        this.trainFactor[4] = f4;
        this.trainFactor[5] = f5;
    }

    // Token: 0x06000FCA RID: 4042 RVA: 0x000E6954 File Offset: 0x000E4D54
    public string attackName(int id)
    {
        switch (id)
        {
            case 0:
                return "Idle Attack";
            case 1:
                return "Regular Attack";
            case 2:
                return "Strong Attack";
            case 3:
                return "Parry";
            case 4:
                return "Piercing Attack";
            case 5:
                return "Ultimate Attack";
            default:
                return "Bug. Ah crap...";
        }
    }

    // Token: 0x06000FCB RID: 4043 RVA: 0x000E69B0 File Offset: 0x000E4DB0
    public string defenseName(int id)
    {
        switch (id)
        {
            case 0:
                return "Block";
            case 1:
                return "Defensive Buff";
            case 2:
                return "Heal";
            case 3:
                return "Offensive Buff";
            case 4:
                return "Charge";
            case 5:
                return "Ultimate Buff";
            default:
                return "Bug. Ah crap...";
        }
    }

    // Token: 0x04000BA2 RID: 2978
    public int[] _attackCaps = new int[]
    {
        2500,
        15000,
        30000,
        50000,
        70000,
        100000
    };

    // Token: 0x04000BA3 RID: 2979
    public int[] _defenseCaps = new int[]
    {
        2500,
        15000,
        30000,
        50000,
        70000,
        100000
    };

    // Token: 0x04000BA4 RID: 2980
    public int[] evilAttackCaps = new int[]
    {
        250000,
        1500000,
        3000000,
        5000000,
        7000000,
        10000000
    };

    // Token: 0x04000BA5 RID: 2981
    public int[] evilDefenseCaps = new int[]
    {
        250000,
        1500000,
        3000000,
        5000000,
        7000000,
        10000000
    };

    // Token: 0x04000BA6 RID: 2982
    public long[] _attackTraining = new long[6];

    // Token: 0x04000BA7 RID: 2983
    public long[] _defenseTraining = new long[6];

    // Token: 0x04000BA8 RID: 2984
    public long[] _attackEnergy = new long[6];

    // Token: 0x04000BA9 RID: 2985
    public long[] _defenseEnergy = new long[6];

    // Token: 0x04000BAA RID: 2986
    public long _totalAttackLevels;

    // Token: 0x04000BAB RID: 2987
    public long _totalDefenseLevels;

    // Token: 0x04000BAC RID: 2988
    public float[] _attackBarProgress = new float[6];

    // Token: 0x04000BAD RID: 2989
    public float[] _defenseBarProgress = new float[6];

    // Token: 0x04000BAE RID: 2990
    public int[] _trainFactor = new int[]
    {
        150,
        1000,
        5000,
        20000,
        80000,
        250000
    };

    // Token: 0x04000BAF RID: 2991
    public bool _hasAutoAdvance;

    // Token: 0x04000BB0 RID: 2992
    public bool _autoAdvanceToggle;
}
