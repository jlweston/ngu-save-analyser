using System;

// Token: 0x02000097 RID: 151
[Serializable]
public class PlayerSettings
{
    // Token: 0x06000A03 RID: 2563 RVA: 0x0007C198 File Offset: 0x0007A598
    public PlayerSettings()
    {
        this.numberDisplay = 0;
        this.tooltipsOn = true;
        this.special1Bought = false;
        this.special2Bought = false;
        this.special3Bought = false;
        this.filterTitan = false;
        this.specialAdvHpBars = true;
        this.filterOn = true;
        this.wandoos98On = false;
        this.yggdrasilOn = false;
        this.customEnergy1 = 0L;
        this.customEnergy2 = 0L;
        this.customMagic1 = 0L;
        this.customMagic2 = 0L;
        this.hasHyperRegen = false;
        this.syncTraining = false;
        this.rebirthDifficulty = difficulty.normal;
        this.rebirthLevels = 0L;
        this.speedrunCount = 0;
        this.gotSpeedrunSecret = false;
        this.nguOn = false;
        this.inventoryOn = false;
        this.antiFlickerBars = false;
        this.autoAssignOn = false;
        this.autoAssignTime = 0f;
        this.machineEnergyAmount = 0L;
        this.machineGoldMultiAmount = 0L;
        this.tutorialState = -1;
        this.tutorialOffForever = false;
        this.tutorial1Complete = false;
        this.expPopups = true;
        this.dailySaveRewardTime = new PlayerTime();
        this.submitHighscores = true;
        this.timedTooltipsOn = true;
        this.inputAmount = 250L;
        this.autoKillTitans = true;
        this.autoMergeOn = false;
        this.autoBoostOn = false;
        this.invAutoMergeOn = true;
        this.invAutoBoostOn = true;
        this.customEnergyPercent1 = 1f;
        this.customEnergyPercent2 = 1f;
        this.customMagicPercent1 = 1f;
        this.customMagicPercent2 = 1f;
        this.customRes3Percent1 = 1f;
        this.customRes3Percent2 = 1f;
        this.customIdleEnergyPercent1 = 1f;
        this.customIdleEnergyPercent2 = 1f;
        this.customIdleMagicPercent1 = 1f;
        this.customIdleMagicPercent2 = 1f;
        this.customIdleRes3Percent1 = 1f;
        this.customIdleRes3Percent2 = 1f;
        this.autoboostRecycledBoosts = false;
        this.unassignWhenSwapping = false;
        this.shakeySales = false;
        this.beardsOn = false;
        this.beardPopup = false;
        this.checkForUpdates = true;
        this.fancyYggBars = true;
        this.autoTransform = 0;
        this.simpleInvShortcuts = false;
        this.poopOnlyMaxTier = false;
        this.itopodOn = false;
        this.itopodConfirmation = true;
        this.buffedKillsOn = false;
        this.customPowerAmount = 1;
        this.customBarAmount = 1;
        this.customCapAmount = 10000L;
        this.customMagicPowerAmount = 1;
        this.customMagicBarAmount = 1;
        this.customMagicCapAmount = 10000L;
        this.customRes3PowerAmount = 1;
        this.customRes3BarAmount = 1;
        this.customRes3CapAmount = 10000L;
        this.customAttackInput = 100L;
        this.customDefenseInput = 100L;
        this.beastModeUnlocked = false;
        this.diggersOn = false;
        this.nguLevelTrack = difficulty.normal;
        this.themeID = 0;
        this.genericRes3ColourID = 0;
        this.beastConfirmation = true;
        this.beastOn = false;
        this.useMajorQuests = true;
        this.autoNukeOn = false;
        this.nguCapModifier = 1f;
        this.idleQuestAutocycle = true;
        this.res3NameGeneratorOn = false;
        this.claimedKartPromo = false;
        this.claimedSteamPromo = false;
        this.assholeSetting = true;
        this.badge1Complete = false;
        this.badge2Started = false;
        this.badge2Part1Complete = false;
        this.badge2Part2Complete = false;
        this.badge2Part3Complete = false;
        this.badge2Part4Complete = false;
        this.exilev4Defeated = false;
    }

    // Token: 0x06000A04 RID: 2564 RVA: 0x0007C5CF File Offset: 0x0007A9CF
    public void updateSettings()
    {
    }

    // Token: 0x0400077A RID: 1914
    public int numberDisplay;

    // Token: 0x0400077B RID: 1915
    public bool tooltipsOn;

    // Token: 0x0400077C RID: 1916
    public bool special1Bought;

    // Token: 0x0400077D RID: 1917
    public bool special2Bought;

    // Token: 0x0400077E RID: 1918
    public bool special3Bought;

    // Token: 0x0400077F RID: 1919
    public bool specialAdvHpBars = true;

    // Token: 0x04000780 RID: 1920
    public bool filterOn = true;

    // Token: 0x04000781 RID: 1921
    public bool wandoos98On;

    // Token: 0x04000782 RID: 1922
    public long customEnergy1;

    // Token: 0x04000783 RID: 1923
    public long customEnergy2;

    // Token: 0x04000784 RID: 1924
    public long customMagic1;

    // Token: 0x04000785 RID: 1925
    public long customMagic2;

    // Token: 0x04000786 RID: 1926
    public bool yggdrasilOn;

    // Token: 0x04000787 RID: 1927
    public bool filterHead;

    // Token: 0x04000788 RID: 1928
    public bool filterChest;

    // Token: 0x04000789 RID: 1929
    public bool filterLegs;

    // Token: 0x0400078A RID: 1930
    public bool filterBoots;

    // Token: 0x0400078B RID: 1931
    public bool filterWeapon;

    // Token: 0x0400078C RID: 1932
    public bool filterAccessory;

    // Token: 0x0400078D RID: 1933
    public bool filterBoosts;

    // Token: 0x0400078E RID: 1934
    public bool filterBoostAtk;

    // Token: 0x0400078F RID: 1935
    public bool filterBoostDef;

    // Token: 0x04000790 RID: 1936
    public bool filterBoostSpec;

    // Token: 0x04000791 RID: 1937
    public bool filterMisc;

    // Token: 0x04000792 RID: 1938
    public bool filterTitan;

    // Token: 0x04000793 RID: 1939
    public bool syncTraining;

    // Token: 0x04000794 RID: 1940
    public bool hasHyperRegen;

    // Token: 0x04000795 RID: 1941
    public difficulty rebirthDifficulty;

    // Token: 0x04000796 RID: 1942
    public long rebirthLevels;

    // Token: 0x04000797 RID: 1943
    public int speedrunCount;

    // Token: 0x04000798 RID: 1944
    public bool gotSpeedrunSecret;

    // Token: 0x04000799 RID: 1945
    public bool nguOn;

    // Token: 0x0400079A RID: 1946
    public bool inventoryOn;

    // Token: 0x0400079B RID: 1947
    public bool antiFlickerBars;

    // Token: 0x0400079C RID: 1948
    public bool autoAssignOn;

    // Token: 0x0400079D RID: 1949
    public float autoAssignTime;

    // Token: 0x0400079E RID: 1950
    public long machineEnergyAmount;

    // Token: 0x0400079F RID: 1951
    public long machineGoldMultiAmount;

    // Token: 0x040007A0 RID: 1952
    public int tutorialState = -1;

    // Token: 0x040007A1 RID: 1953
    public bool tutorialOffForever;

    // Token: 0x040007A2 RID: 1954
    public bool tutorial1Complete;

    // Token: 0x040007A3 RID: 1955
    public bool expPopups = true;

    // Token: 0x040007A4 RID: 1956
    public PlayerTime dailySaveRewardTime = new PlayerTime();

    // Token: 0x040007A5 RID: 1957
    public bool submitHighscores = true;

    // Token: 0x040007A6 RID: 1958
    public bool timedTooltipsOn = true;

    // Token: 0x040007A7 RID: 1959
    public bool autoMergeOn;

    // Token: 0x040007A8 RID: 1960
    public long inputAmount = 1000L;

    // Token: 0x040007A9 RID: 1961
    public bool autoKillTitans;

    // Token: 0x040007AA RID: 1962
    public bool autoBoostOn;

    // Token: 0x040007AB RID: 1963
    public float customEnergyPercent1;

    // Token: 0x040007AC RID: 1964
    public float customEnergyPercent2;

    // Token: 0x040007AD RID: 1965
    public float customMagicPercent1;

    // Token: 0x040007AE RID: 1966
    public float customMagicPercent2;

    // Token: 0x040007AF RID: 1967
    public float customRes3Percent1;

    // Token: 0x040007B0 RID: 1968
    public float customRes3Percent2;

    // Token: 0x040007B1 RID: 1969
    public float customIdleEnergyPercent1;

    // Token: 0x040007B2 RID: 1970
    public float customIdleEnergyPercent2;

    // Token: 0x040007B3 RID: 1971
    public float customIdleMagicPercent1;

    // Token: 0x040007B4 RID: 1972
    public float customIdleMagicPercent2;

    // Token: 0x040007B5 RID: 1973
    public float customIdleRes3Percent1;

    // Token: 0x040007B6 RID: 1974
    public float customIdleRes3Percent2;

    // Token: 0x040007B7 RID: 1975
    public bool autoboostRecycledBoosts;

    // Token: 0x040007B8 RID: 1976
    public bool unassignWhenSwapping;

    // Token: 0x040007B9 RID: 1977
    public bool shakeySales;

    // Token: 0x040007BA RID: 1978
    public bool beardsOn;

    // Token: 0x040007BB RID: 1979
    public bool beardPopup;

    // Token: 0x040007BC RID: 1980
    public bool checkForUpdates = true;

    // Token: 0x040007BD RID: 1981
    public bool fancyYggBars = true;

    // Token: 0x040007BE RID: 1982
    public int autoTransform;

    // Token: 0x040007BF RID: 1983
    public bool simpleInvShortcuts;

    // Token: 0x040007C0 RID: 1984
    public bool poopOnlyMaxTier;

    // Token: 0x040007C1 RID: 1985
    public bool itopodOn;

    // Token: 0x040007C2 RID: 1986
    public bool itopodConfirmation = true;

    // Token: 0x040007C3 RID: 1987
    public bool buffedKillsOn;

    // Token: 0x040007C4 RID: 1988
    public int customPowerAmount = 1;

    // Token: 0x040007C5 RID: 1989
    public int customBarAmount = 1;

    // Token: 0x040007C6 RID: 1990
    public long customCapAmount = 10000L;

    // Token: 0x040007C7 RID: 1991
    public int customMagicPowerAmount = 1;

    // Token: 0x040007C8 RID: 1992
    public int customMagicBarAmount = 1;

    // Token: 0x040007C9 RID: 1993
    public long customMagicCapAmount = 10000L;

    // Token: 0x040007CA RID: 1994
    public int customRes3PowerAmount = 1;

    // Token: 0x040007CB RID: 1995
    public int customRes3BarAmount = 1;

    // Token: 0x040007CC RID: 1996
    public long customRes3CapAmount = 10000L;

    // Token: 0x040007CD RID: 1997
    public long customAttackInput = 100L;

    // Token: 0x040007CE RID: 1998
    public long customDefenseInput = 100L;

    // Token: 0x040007CF RID: 1999
    public long customPowerInput = 10000L;

    // Token: 0x040007D0 RID: 2000
    public long customToughnessInput = 10000L;

    // Token: 0x040007D1 RID: 2001
    public long customHPInput = 100000L;

    // Token: 0x040007D2 RID: 2002
    public long customRegenInput = 10000L;

    // Token: 0x040007D3 RID: 2003
    public bool beastModeUnlocked;

    // Token: 0x040007D4 RID: 2004
    public bool diggersOn;

    // Token: 0x040007D5 RID: 2005
    public difficulty nguLevelTrack;

    // Token: 0x040007D6 RID: 2006
    public bool pitUnlocked;

    // Token: 0x040007D7 RID: 2007
    public int themeID;

    // Token: 0x040007D8 RID: 2008
    public int genericRes3ColourID;

    // Token: 0x040007D9 RID: 2009
    public bool beastConfirmation = true;

    // Token: 0x040007DA RID: 2010
    public bool beastOn;

    // Token: 0x040007DB RID: 2011
    public bool useMajorQuests = true;

    // Token: 0x040007DC RID: 2012
    public bool autoNukeOn;

    // Token: 0x040007DD RID: 2013
    public float nguCapModifier = 1f;

    // Token: 0x040007DE RID: 2014
    public bool idleQuestAutocycle = true;

    // Token: 0x040007DF RID: 2015
    public bool res3NameGeneratorOn;

    // Token: 0x040007E0 RID: 2016
    public bool claimedKartPromo;

    // Token: 0x040007E1 RID: 2017
    public bool claimedSteamPromo;

    // Token: 0x040007E2 RID: 2018
    public bool assholeSetting = true;

    // Token: 0x040007E3 RID: 2019
    public bool badge1Complete;

    // Token: 0x040007E4 RID: 2020
    public bool badge2Started;

    // Token: 0x040007E5 RID: 2021
    public bool badge2Part1Complete;

    // Token: 0x040007E6 RID: 2022
    public bool badge2Part2Complete;

    // Token: 0x040007E7 RID: 2023
    public bool badge2Part3Complete;

    // Token: 0x040007E8 RID: 2024
    public bool badge2Part4Complete;

    // Token: 0x040007E9 RID: 2025
    public bool invAutoMergeOn = true;

    // Token: 0x040007EA RID: 2026
    public bool invAutoBoostOn = true;

    // Token: 0x040007EB RID: 2027
    public bool exilev4Defeated;
}
