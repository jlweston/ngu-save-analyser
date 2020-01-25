using System;

// Token: 0x02000093 RID: 147
[Serializable]
public class PlayerTime
{
    // Token: 0x06000A20 RID: 2592 RVA: 0x0007D8A5 File Offset: 0x0007BCA5
    public PlayerTime()
    {
        this.totalseconds = 0.0;
        this.seconds = 0.0;
        this.minutes = 0;
        this.hours = 0;
        this.days = 0;
    }

    // Token: 0x06000A21 RID: 2593 RVA: 0x0007D8E0 File Offset: 0x0007BCE0
    public void setTime(float t)
    {
        this.totalseconds = (double)t;
        this.recalculateTime();
    }

    // Token: 0x06000A22 RID: 2594 RVA: 0x0007D8F0 File Offset: 0x0007BCF0
    public void setTime(double t)
    {
        this.totalseconds = t;
        this.recalculateTime();
    }

    // Token: 0x06000A23 RID: 2595 RVA: 0x0007D8FF File Offset: 0x0007BCFF
    public void advanceTime(float t)
    {
        this.totalseconds += (double)t;
        this.recalculateTime();
    }

    // Token: 0x06000A24 RID: 2596 RVA: 0x0007D916 File Offset: 0x0007BD16
    public void advanceTime(int time)
    {
        this.totalseconds += (double)time;
        this.recalculateTime();
    }

    // Token: 0x06000A25 RID: 2597 RVA: 0x0007D92D File Offset: 0x0007BD2D
    public void removeTime(float amount)
    {
        this.totalseconds -= (double)amount;
        this.recalculateTime();
    }

    // Token: 0x06000A26 RID: 2598 RVA: 0x0007D944 File Offset: 0x0007BD44
    public string timeDisplay()
    {
        string empty = string.Empty;
        if (this.days != 0)
        {
            return string.Concat(new object[]
            {
                this.days,
                " days ",
                this.hours,
                " hours ",
                this.minutes,
                " minutes ",
                this.seconds.ToString("#0"),
                " seconds "
            });
        }
        if (this.hours != 0)
        {
            return string.Concat(new object[]
            {
                this.hours,
                " hours ",
                this.minutes.ToString("00"),
                " minutes ",
                this.seconds.ToString("#0"),
                " seconds "
            });
        }
        if (this.minutes != 0)
        {
            return string.Concat(new object[]
            {
                this.minutes,
                " minutes ",
                this.seconds.ToString("#0"),
                " seconds "
            });
        }
        return this.seconds.ToString("#0") + " seconds";
    }

    // Token: 0x06000A27 RID: 2599 RVA: 0x0007DA98 File Offset: 0x0007BE98
    public string timeDisplayColon()
    {
        return NumberOutput.timeOutput(this.totalseconds);
    }

    // Token: 0x06000A28 RID: 2600 RVA: 0x0007DAA8 File Offset: 0x0007BEA8
    public string timeDisplayColon(int time)
    {
        string result = string.Empty;
        int num = time / 86400;
        time %= 86400;
        int num2 = time / 3600;
        time %= 3600;
        int num3 = time / 60;
        time %= 60;
        int num4 = time;
        if (num != 0)
        {
            if (num > 1)
            {
                result = string.Concat(new object[]
                {
                    num,
                    " days ",
                    num2.ToString("00"),
                    ":",
                    num3.ToString("00"),
                    ":",
                    num4.ToString("00")
                });
            }
            else
            {
                result = string.Concat(new object[]
                {
                    num,
                    " day ",
                    num2.ToString("00"),
                    ":",
                    num3.ToString("00"),
                    ":",
                    num4.ToString("00")
                });
            }
            return result;
        }
        if (num2 != 0)
        {
            return string.Concat(new object[]
            {
                num2,
                ":",
                num3.ToString("00"),
                ":",
                num4.ToString("00")
            });
        }
        if (num3 != 0)
        {
            return num3 + ":" + num4.ToString("00");
        }
        return num4.ToString("#0") + "s";
    }

    // Token: 0x06000A29 RID: 2601 RVA: 0x0007DC44 File Offset: 0x0007C044
    public string inverseDisplay(double target)
    {
        double num = target - this.totalseconds;
        return NumberOutput.timeOutput(num);
    }

    // Token: 0x06000A2A RID: 2602 RVA: 0x0007DC60 File Offset: 0x0007C060
    public string inverseDisplayColon(double target)
    {
        double num = target - this.totalseconds;
        return NumberOutput.timeOutput(num);
    }

    // Token: 0x06000A2B RID: 2603 RVA: 0x0007DC7C File Offset: 0x0007C07C
    public bool atTargetTime(double t)
    {
        return this.totalseconds >= t;
    }

    // Token: 0x06000A2C RID: 2604 RVA: 0x0007DC8D File Offset: 0x0007C08D
    public void reset()
    {
        this.totalseconds = 0.0;
        this.seconds = 0.0;
        this.minutes = 0;
        this.hours = 0;
        this.days = 0;
    }

    // Token: 0x06000A2D RID: 2605 RVA: 0x0007DCC4 File Offset: 0x0007C0C4
    public void recalculateTime()
    {
        double num = this.totalseconds;
        if (this.totalseconds < 0.0)
        {
            this.totalseconds = 0.0;
        }
        this.days = (int)(num / 86400.0);
        num %= 86400.0;
        this.hours = (int)(num / 3600.0);
        num %= 3600.0;
        this.days = (int)(num / 86400.0);
        num %= 60.0;
        this.seconds = num;
    }

    // Token: 0x06000A2E RID: 2606 RVA: 0x0007DD5C File Offset: 0x0007C15C
    public int getTimeAsHighscore()
    {
        if (this.totalseconds > 2147483647.0)
        {
            return int.MaxValue;
        }
        return (int)this.totalseconds;
    }

    // Token: 0x0400078F RID: 1935
    public double totalseconds;

    // Token: 0x04000790 RID: 1936
    public double seconds;

    // Token: 0x04000791 RID: 1937
    public int minutes;

    // Token: 0x04000792 RID: 1938
    public int hours;

    // Token: 0x04000793 RID: 1939
    public int days;
}
