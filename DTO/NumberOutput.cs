using System;
using System.Collections.Generic;

// Token: 0x02000113 RID: 275
public static class NumberOutput
{
    // Token: 0x06001093 RID: 4243 RVA: 0x000F14B4 File Offset: 0x000EF8B4
    static NumberOutput()
    {
        NumberOutput.suffixString.Add(0, " Million");
        NumberOutput.suffixString.Add(1, " Million");
        NumberOutput.suffixString.Add(2, " Million");
        NumberOutput.suffixString.Add(3, " Billion");
        NumberOutput.suffixString.Add(4, " Trillion");
        NumberOutput.suffixString.Add(5, " Quadrillion");
        NumberOutput.suffixString.Add(6, " Quintillion");
        NumberOutput.suffixString.Add(7, " Sextillion");
        NumberOutput.suffixString.Add(8, " Septillion");
        NumberOutput.suffixString.Add(9, " Octillion");
        NumberOutput.suffixString.Add(10, " Nonillion");
        NumberOutput.suffixString.Add(11, " Decillion");
        NumberOutput.suffixString.Add(12, " Undecillion");
        NumberOutput.suffixString.Add(13, " Duodecillion");
        NumberOutput.suffixString.Add(14, " Tredecillion");
        NumberOutput.suffixString.Add(15, " Quattuordecillion");
        NumberOutput.suffixString.Add(16, " Quindecillion");
        NumberOutput.suffixString.Add(17, " Sexdecillion");
        NumberOutput.suffixString.Add(18, " Septendecillion");
        NumberOutput.suffixString.Add(19, " Octodecillion");
        NumberOutput.suffixString.Add(20, " Novemdecillion");
        NumberOutput.suffixString.Add(21, " Vigintillion");
        NumberOutput.suffixString.Add(22, " Unvigintillion");
        NumberOutput.suffixString.Add(23, " Duovigintillion");
        NumberOutput.suffixString.Add(24, " Trevigintillion");
        NumberOutput.suffixString.Add(25, " Quattuorvigintillion");
        NumberOutput.suffixString.Add(26, " Quinvigintillion");
        NumberOutput.suffixString.Add(27, " Sexvigintillion");
        NumberOutput.suffixString.Add(28, " Septenvigintillion");
        NumberOutput.suffixString.Add(29, " Octovigintillion");
        NumberOutput.suffixString.Add(30, " Novemvigintillion");
        NumberOutput.suffixString.Add(31, " Trigintillion");
        NumberOutput.suffixString.Add(32, " Untrigintillion");
        NumberOutput.suffixString.Add(33, " Duotrigintillion");
        NumberOutput.suffixString.Add(34, " Tretrigintillion");
        NumberOutput.suffixString.Add(35, " Quattuortrigintillion");
        NumberOutput.suffixString.Add(36, " Quintrigintillion");
        NumberOutput.suffixString.Add(37, " Sextrigintillion");
        NumberOutput.suffixString.Add(38, " Septentrigintillion");
        NumberOutput.suffixString.Add(39, " Octotrigintillion");
        NumberOutput.suffixString.Add(40, " Novemtrigintillion");
        NumberOutput.suffixString.Add(41, " Quadragintillion");
        NumberOutput.suffixString.Add(42, " Unquadragintillion");
        NumberOutput.suffixString.Add(43, " Duoquadragintillion");
        NumberOutput.suffixString.Add(44, " Trequadragintillion");
        NumberOutput.suffixString.Add(45, " Quattuorquadragintillion");
        NumberOutput.suffixString.Add(46, " Quinquadragintillion");
        NumberOutput.suffixString.Add(47, " Sexquadragintillion");
        NumberOutput.suffixString.Add(48, " Septenquadragintillion");
        NumberOutput.suffixString.Add(49, " Octoquadragintillion");
        NumberOutput.suffixString.Add(50, " Novemquadragintillion");
        NumberOutput.suffixString.Add(51, " Quinquagintillion");
        NumberOutput.suffixString.Add(52, " Unquinquagintillion");
        NumberOutput.suffixString.Add(53, " Duoquinquagintillion");
        NumberOutput.suffixString.Add(54, " Trequinquagintillion");
        NumberOutput.suffixString.Add(55, " Quattuorquinquagintillion");
        NumberOutput.suffixString.Add(56, " Quinquinquagintillion");
        NumberOutput.suffixString.Add(57, " Sexquinquagintillion");
        NumberOutput.suffixString.Add(58, " Septenquinquagintillion");
        NumberOutput.suffixString.Add(59, " Octoquinquagintillion");
        NumberOutput.suffixString.Add(60, " Novemquinquagintillion");
        NumberOutput.suffixString.Add(61, " Sexagintillion");
        NumberOutput.suffixString.Add(62, " Unsexagintillion");
        NumberOutput.suffixString.Add(63, " Duosexagintillion");
        NumberOutput.suffixString.Add(64, " Tresexagintillion");
        NumberOutput.suffixString.Add(65, " Quattuorsexagintillion");
        NumberOutput.suffixString.Add(66, " Quinsexagintillion");
        NumberOutput.suffixString.Add(67, " Sexsexagintillion\n The sexiest number ;)");
        NumberOutput.suffixString.Add(68, " Septensexagintillion");
        NumberOutput.suffixString.Add(69, " Octosexagintillion");
        NumberOutput.suffixString.Add(70, " Novemsexagintillion");
        NumberOutput.suffixString.Add(71, " Septuagintillion");
        NumberOutput.suffixString.Add(72, " Unseptuagintillion");
        NumberOutput.suffixString.Add(73, " Duoseptuagintillion");
        NumberOutput.suffixString.Add(74, " Treseptuagintillion");
        NumberOutput.suffixString.Add(75, " Quattuorseptuagintillion");
        NumberOutput.suffixString.Add(76, " Quinseptuagintillion");
        NumberOutput.suffixString.Add(77, " Sexseptuagintillion");
        NumberOutput.suffixString.Add(78, " Septenseptuagintillion");
        NumberOutput.suffixString.Add(79, " Octoseptuagintillion");
        NumberOutput.suffixString.Add(80, " Novemseptuagintillion");
        NumberOutput.suffixString.Add(81, " Octogintillion");
        NumberOutput.suffixString.Add(82, " Unoctogintillion");
        NumberOutput.suffixString.Add(83, " Duooctogintillion");
        NumberOutput.suffixString.Add(84, " Treoctogintillion");
        NumberOutput.suffixString.Add(85, " Quattuoroctogintillion");
        NumberOutput.suffixString.Add(86, " Quinoctogintillion");
        NumberOutput.suffixString.Add(87, " Sexoctogintillion");
        NumberOutput.suffixString.Add(88, " Septenoctogintillion");
        NumberOutput.suffixString.Add(89, " Octooctogintillion");
        NumberOutput.suffixString.Add(90, " Novemoctogintillion");
        NumberOutput.suffixString.Add(91, " Nonagintillion");
        NumberOutput.suffixString.Add(92, " Unnonagintillion");
        NumberOutput.suffixString.Add(93, " Duononagintillion");
        NumberOutput.suffixString.Add(94, " Trenonagintillion");
        NumberOutput.suffixString.Add(95, " Quattuornonagintillion");
        NumberOutput.suffixString.Add(96, " Quinnonagintillion");
        NumberOutput.suffixString.Add(97, " Sexnonagintillion");
        NumberOutput.suffixString.Add(98, " Septennonagintillion");
        NumberOutput.suffixString.Add(99, " Octononagintillion");
        NumberOutput.suffixString.Add(100, " Novemnonagintillion");
        NumberOutput.suffixString.Add(101, " CENTILLION");
        NumberOutput.suffixString.Add(102, " SUPERCENTILLION");
        NumberOutput.expPrintString.Add(0, "K");
        NumberOutput.expPrintString.Add(1, "K");
        NumberOutput.expPrintString.Add(2, "M");
        NumberOutput.expPrintString.Add(3, "B");
        NumberOutput.expPrintString.Add(4, "T");
        NumberOutput.expPrintString.Add(5, "Q");
        NumberOutput.expPrintString.Add(6, "Qi");
    }

    // Token: 0x06001094 RID: 4244 RVA: 0x000F1C13 File Offset: 0x000F0013
    public static string suffixFormat(double number, int displayType)
    {
        if (displayType == 3)
        {
            return string.Empty;
        }
        if (displayType == 0)
        {
            return NumberOutput.realSuffixFormat(number);
        }
        if (displayType == 1)
        {
            return NumberOutput.engineerFormat(number);
        }
        if (displayType == 2)
        {
            return NumberOutput.sciFormat(number);
        }
        return NumberOutput.realSuffixFormat(number);
    }

    // Token: 0x06001095 RID: 4245 RVA: 0x000F1C54 File Offset: 0x000F0054
    private static string realSuffixFormat(double number)
    {
        if (double.IsPositiveInfinity(number))
        {
            number = double.MaxValue;
        }
        if (double.IsNegativeInfinity(number))
        {
            number = double.MinValue;
        }
        if (double.IsNaN(number))
        {
            number = 0.0;
        }
        if (number < 1.0)
        {
            return number.ToString();
        }
        if (number < 1000000.0)
        {
            return number.ToString("###,##0");
        }
        string str = string.Empty;
        int num = (int)Math.Floor(Math.Log(number, 1000.0));
        number /= Math.Pow(1000.0, (double)num);
        str = NumberOutput.suffixString[num];
        return number.ToString("###.000") + str;
    }

    // Token: 0x06001096 RID: 4246 RVA: 0x000F1D2C File Offset: 0x000F012C
    private static string engineerFormat(double number)
    {
        if (number < 1000000.0)
        {
            return number.ToString("###,##0");
        }
        double num = Math.Log10(Math.Abs(number));
        double num2 = Math.Floor(num / 3.0) * 3.0;
        number /= Math.Pow(10.0, num2);
        return number.ToString("###.000") + "E+" + num2;
    }

    // Token: 0x06001097 RID: 4247 RVA: 0x000F1DAB File Offset: 0x000F01AB
    private static string sciFormat(double number)
    {
        if (number < 1000000.0)
        {
            return number.ToString("###,##0");
        }
        return number.ToString("E3");
    }

    // Token: 0x06001098 RID: 4248 RVA: 0x000F1DD8 File Offset: 0x000F01D8
    public static string timeOutput(float seconds)
    {
        float num = 0f;
        float num2 = 0f;
        float num3 = 0f;
        if (seconds >= 3.4028235E+38f)
        {
            return "Dis Gunna Take A While.";
        }
        if (seconds >= 86400f)
        {
            num3 = (float)Math.Floor(seconds / 86400f);
            seconds %= 86400f;
        }
        if (seconds >= 3600f)
        {
            num2 = (float)Math.Floor(seconds / 3600f);
            seconds %= 3600f;
        }
        if (seconds >= 60f)
        {
            num = (float)Math.Floor(seconds / 60f);
            seconds %= 60f;
        }
        if (num3 > 1f)
        {
            return string.Concat(new object[]
            {
                num3,
                " days ",
                num2.ToString("00"),
                ":",
                num.ToString("00"),
                ":",
                Math.Floor(seconds).ToString("00")
            });
        }
        if (num3 > 0f)
        {
            return string.Concat(new object[]
            {
                num3,
                " day ",
                num2.ToString("00"),
                ":",
                num.ToString("00"),
                ":",
                Math.Floor(seconds).ToString("00")
            });
        }
        if (num2 > 0f)
        {
            return string.Concat(new object[]
            {
                num2,
                ":",
                num.ToString("00"),
                ":",
                Math.Floor(seconds).ToString("00")
            });
        }
        if (num > 0f)
        {
            return num + ":" + Math.Floor(seconds).ToString("00");
        }
        return seconds.ToString("#0.0") + "s";
    }

    // Token: 0x06001099 RID: 4249 RVA: 0x000F1FE0 File Offset: 0x000F03E0
    public static string timeOutput(double seconds)
    {
        double num = 0.0;
        double num2 = 0.0;
        double num3 = 0.0;
        if (seconds >= 86400.0)
        {
            num3 = Math.Floor(seconds / 86400.0);
            seconds %= 86400.0;
        }
        if (seconds >= 3600.0)
        {
            num2 = Math.Floor(seconds / 3600.0);
            seconds %= 3600.0;
        }
        if (seconds >= 60.0)
        {
            num = Math.Floor(seconds / 60.0);
            seconds %= 60.0;
        }
        if (num3 > 0.0)
        {
            if (num3 == 1.0)
            {
                return string.Concat(new object[]
                {
                    num3,
                    " day ",
                    num2.ToString("00"),
                    ":",
                    num.ToString("00"),
                    ":",
                    Math.Floor(seconds).ToString("00")
                });
            }
            return string.Concat(new object[]
            {
                num3,
                " days ",
                num2.ToString("00"),
                ":",
                num.ToString("00"),
                ":",
                Math.Floor(seconds).ToString("00")
            });
        }
        else
        {
            if (num2 > 0.0)
            {
                return string.Concat(new object[]
                {
                    num2,
                    ":",
                    num.ToString("00"),
                    ":",
                    Math.Floor(seconds).ToString("00")
                });
            }
            if (num > 0.0)
            {
                return num + ":" + Math.Floor(seconds).ToString("00");
            }
            return seconds.ToString("#0.0") + "s";
        }
    }

    // Token: 0x0600109A RID: 4250 RVA: 0x000F2218 File Offset: 0x000F0618
    public static string expPrint(long exp)
    {
        if (exp < 10000L)
        {
            return exp.ToString();
        }
        int num = (int)Math.Floor(Math.Log((double)exp, 1000.0));
        return ((double)exp / Math.Pow(1000.0, (double)num)).ToString("##0.###") + NumberOutput.expPrintString[num];
    }

    // Token: 0x04000C6C RID: 3180
    private static readonly Dictionary<int, string> suffixString = new Dictionary<int, string>();

    // Token: 0x04000C6D RID: 3181
    private static readonly Dictionary<int, string> expPrintString = new Dictionary<int, string>();

    //// Token: 0x04000C6E RID: 3182
    //public static readonly Character character;
}
