using System;

// Token: 0x02000082 RID: 130
[Serializable]
public class PlayerTime
{
    // Token: 0x0600091E RID: 2334 RVA: 0x00073D8D File Offset: 0x0007218D
    public PlayerTime()
    {
        this.totalseconds = 0.0;
        this.seconds = 0.0;
        this.minutes = 0;
        this.hours = 0;
        this.days = 0;
    }

    // Token: 0x0600091F RID: 2335 RVA: 0x00073DC8 File Offset: 0x000721C8
    public void setTime(float t)
    {
        this.totalseconds = (double)t;
        this.recalculateTime();
    }

    // Token: 0x06000920 RID: 2336 RVA: 0x00073DD8 File Offset: 0x000721D8
    public void setTime(double t)
    {
        this.totalseconds = t;
        this.recalculateTime();
    }

    // Token: 0x06000921 RID: 2337 RVA: 0x00073DE7 File Offset: 0x000721E7
    public void advanceTime(float t)
    {
        this.totalseconds += (double)t;
        this.recalculateTime();
    }

    // Token: 0x06000922 RID: 2338 RVA: 0x00073DFE File Offset: 0x000721FE
    public void advanceTime(int time)
    {
        this.totalseconds += (double)time;
        this.recalculateTime();
    }

    // Token: 0x06000923 RID: 2339 RVA: 0x00073E15 File Offset: 0x00072215
    public void removeTime(float amount)
    {
        this.totalseconds -= (double)amount;
        this.recalculateTime();
    }

    // Token: 0x06000924 RID: 2340 RVA: 0x00073E2C File Offset: 0x0007222C
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

    // Token: 0x06000925 RID: 2341 RVA: 0x00073F80 File Offset: 0x00072380
    public string timeDisplayColon()
    {
        return NumberOutput.timeOutput(this.totalseconds);
    }

    // Token: 0x06000926 RID: 2342 RVA: 0x00073F90 File Offset: 0x00072390
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

    // Token: 0x06000927 RID: 2343 RVA: 0x0007412C File Offset: 0x0007252C
    public string inverseDisplay(double target)
    {
        double num = target - this.totalseconds;
        return NumberOutput.timeOutput(num);
    }

    // Token: 0x06000928 RID: 2344 RVA: 0x00074148 File Offset: 0x00072548
    public string inverseDisplayColon(double target)
    {
        double num = target - this.totalseconds;
        return NumberOutput.timeOutput(num);
    }

    // Token: 0x06000929 RID: 2345 RVA: 0x00074164 File Offset: 0x00072564
    public bool atTargetTime(double t)
    {
        return this.totalseconds >= t;
    }

    // Token: 0x0600092A RID: 2346 RVA: 0x00074175 File Offset: 0x00072575
    public void reset()
    {
        this.totalseconds = 0.0;
        this.seconds = 0.0;
        this.minutes = 0;
        this.hours = 0;
        this.days = 0;
    }

    // Token: 0x0600092B RID: 2347 RVA: 0x000741AC File Offset: 0x000725AC
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

    // Token: 0x0600092C RID: 2348 RVA: 0x00074244 File Offset: 0x00072644
    public int getTimeAsHighscore()
    {
        if (this.totalseconds > 2147483647.0)
        {
            return int.MaxValue;
        }
        return (int)this.totalseconds;
    }

    // Token: 0x040006E1 RID: 1761
    public double totalseconds;

    // Token: 0x040006E2 RID: 1762
    public double seconds;

    // Token: 0x040006E3 RID: 1763
    public int minutes;

    // Token: 0x040006E4 RID: 1764
    public int hours;

    // Token: 0x040006E5 RID: 1765
    public int days;
}
