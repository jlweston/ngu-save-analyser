using System;

// Token: 0x0200002C RID: 44
[Serializable]
public class Arbitrary
{
    // Token: 0x060002A4 RID: 676 RVA: 0x00033438 File Offset: 0x00031838
    public Arbitrary()
    {
        this.arbitraryPoints = 0;
        this.lifetimePoints = 0;
        this.energyPotion1Count = 0;
        this.energyPotion1Time = new PlayerTime();
        this.energyPotion2Count = 0;
        this.energyPotion2InUse = false;
        this.magicPotion1Count = 0;
        this.magicPotion1Time = new PlayerTime();
        this.magicPotion2Count = 0;
        this.magicPotion2InUse = false;
        this.lootCharm1Count = 0;
        this.lootcharm1Time = new PlayerTime();
        this.energyBarBar1Count = 0;
        this.energyBarBar1Time = new PlayerTime();
        this.magicBarBar1Count = 0;
        this.magicBarBar1Time = new PlayerTime();
        this.macGuffinBooster1Count = 0;
        this.macGuffinBooster1Time = new PlayerTime();
        this.macGuffinBooster1InUse = false;
        this.lootFilter = false;
        this.improvedAutoBoostMerge = false;
        this.instaTrain = false;
        this.inventorySpaces = 0;
        this.hasStarterPack = false;
        this.hasAcc4 = false;
        this.hasAcc5 = false;
        this.hasAcc6 = false;
        this.hasAcc7 = false;
        this.hasAcc8 = false;
        this.poop1Count = 0;
        this.hasYggdrasilReminder = false;
        this.hasExtendedSpinBank = false;
        this.curLoadoutSlots = 0;
        this.energyPotion3Count = 0;
        this.magicPotion3Count = 0;
        this.beardSlots = 0;
        this.hasCubeFilter = false;
        this.lootCharm2Count = 0;
        this.hasDaycareSpeed = false;
        this.boughtNewbiePack = false;
        this.boughtAscendedNewbiePack = false;
        this.boughtAscendedNewbiePack2 = false;
        this.boughtAscendedNewbiePack3 = false;
        this.boughtFashionPack1 = false;
        this.boughtLazyITOPOD = false;
        this.lazyITOPODOn = false;
        this.diggerSlots = 0;
        this.macguffinSlots = 0;
        this.nameSlotsBought = 0;
        this.beastButterCount = 0;
        this.hasQuestLight = false;
        this.hasFasterQuests = false;
        this.hasExtendedQuestBank = false;
        this.boughtDaycareArt = false;
        this.hasNGUCapModifier = false;
        this.res3Potion1Count = 0;
        this.res3Potion1Time = new PlayerTime();
        this.res3Potion2Count = 0;
        this.res3Potion2InUse = false;
        this.res3Potion3Count = 0;
        this.res3NameGeneratorBought = false;
        this.wishSpeedBoster = false;
        this.wishSlotsBought = 0;
        this.invMergeSlots = 0;
        this.advLightBought = false;
        this.advAdvancerBought = false;
        this.goToQuestZoneBought = false;
    }

    // Token: 0x04000284 RID: 644
    public int arbitraryPoints;

    // Token: 0x04000285 RID: 645
    public int lifetimePoints;

    // Token: 0x04000286 RID: 646
    public long curArbitraryPoints;

    // Token: 0x04000287 RID: 647
    public long curLifetimePoints;

    // Token: 0x04000288 RID: 648
    public int energyPotion1Count;

    // Token: 0x04000289 RID: 649
    public PlayerTime energyPotion1Time;

    // Token: 0x0400028A RID: 650
    public int energyPotion2Count;

    // Token: 0x0400028B RID: 651
    public bool energyPotion2InUse;

    // Token: 0x0400028C RID: 652
    public int magicPotion1Count;

    // Token: 0x0400028D RID: 653
    public PlayerTime magicPotion1Time;

    // Token: 0x0400028E RID: 654
    public int magicPotion2Count;

    // Token: 0x0400028F RID: 655
    public bool magicPotion2InUse;

    // Token: 0x04000290 RID: 656
    public int lootCharm1Count;

    // Token: 0x04000291 RID: 657
    public PlayerTime lootcharm1Time;

    // Token: 0x04000292 RID: 658
    public int energyBarBar1Count;

    // Token: 0x04000293 RID: 659
    public PlayerTime energyBarBar1Time;

    // Token: 0x04000294 RID: 660
    public int magicBarBar1Count;

    // Token: 0x04000295 RID: 661
    public PlayerTime magicBarBar1Time;

    // Token: 0x04000296 RID: 662
    public int macGuffinBooster1Count;

    // Token: 0x04000297 RID: 663
    public PlayerTime macGuffinBooster1Time = new PlayerTime();

    // Token: 0x04000298 RID: 664
    public bool macGuffinBooster1InUse;

    // Token: 0x04000299 RID: 665
    public PlayerTime nukeTimer = new PlayerTime();

    // Token: 0x0400029A RID: 666
    public bool boughtAutoNuke;

    // Token: 0x0400029B RID: 667
    public bool lootFilter;

    // Token: 0x0400029C RID: 668
    public bool improvedAutoBoostMerge;

    // Token: 0x0400029D RID: 669
    public bool instaTrain;

    // Token: 0x0400029E RID: 670
    public int inventorySpaces;

    // Token: 0x0400029F RID: 671
    public bool hasStarterPack;

    // Token: 0x040002A0 RID: 672
    public bool hasAcc4;

    // Token: 0x040002A1 RID: 673
    public bool hasAcc5;

    // Token: 0x040002A2 RID: 674
    public bool hasAcc6;

    // Token: 0x040002A3 RID: 675
    public bool hasAcc7;

    // Token: 0x040002A4 RID: 676
    public bool hasAcc8;

    // Token: 0x040002A5 RID: 677
    public bool hasYggdrasilReminder;

    // Token: 0x040002A6 RID: 678
    public bool hasExtendedSpinBank;

    // Token: 0x040002A7 RID: 679
    public int curLoadoutSlots;

    // Token: 0x040002A8 RID: 680
    public int poop1Count;

    // Token: 0x040002A9 RID: 681
    public int energyPotion3Count;

    // Token: 0x040002AA RID: 682
    public int magicPotion3Count;

    // Token: 0x040002AB RID: 683
    public int beardSlots;

    // Token: 0x040002AC RID: 684
    public bool hasCubeFilter;

    // Token: 0x040002AD RID: 685
    public int lootCharm2Count;

    // Token: 0x040002AE RID: 686
    public bool hasDaycareSpeed;

    // Token: 0x040002AF RID: 687
    public bool boughtNewbiePack;

    // Token: 0x040002B0 RID: 688
    public bool boughtAscendedNewbiePack;

    // Token: 0x040002B1 RID: 689
    public bool boughtAscendedNewbiePack2;

    // Token: 0x040002B2 RID: 690
    public bool boughtAscendedNewbiePack3;

    // Token: 0x040002B3 RID: 691
    public bool boughtFashionPack1;

    // Token: 0x040002B4 RID: 692
    public bool boughtLazyITOPOD;

    // Token: 0x040002B5 RID: 693
    public bool lazyITOPODOn = true;

    // Token: 0x040002B6 RID: 694
    public bool boughtRes3Pack;

    // Token: 0x040002B7 RID: 695
    public int diggerSlots;

    // Token: 0x040002B8 RID: 696
    public int macguffinSlots;

    // Token: 0x040002B9 RID: 697
    public int nameSlotsBought;

    // Token: 0x040002BA RID: 698
    public int beastButterCount;

    // Token: 0x040002BB RID: 699
    public bool hasQuestLight;

    // Token: 0x040002BC RID: 700
    public bool hasFasterQuests;

    // Token: 0x040002BD RID: 701
    public bool hasExtendedQuestBank;

    // Token: 0x040002BE RID: 702
    public bool boughtDaycareArt;

    // Token: 0x040002BF RID: 703
    public bool hasNGUCapModifier;

    // Token: 0x040002C0 RID: 704
    public int res3Potion1Count;

    // Token: 0x040002C1 RID: 705
    public PlayerTime res3Potion1Time;

    // Token: 0x040002C2 RID: 706
    public int res3Potion2Count;

    // Token: 0x040002C3 RID: 707
    public bool res3Potion2InUse;

    // Token: 0x040002C4 RID: 708
    public int res3Potion3Count;

    // Token: 0x040002C5 RID: 709
    public bool res3NameGeneratorBought;

    // Token: 0x040002C6 RID: 710
    public bool wishSpeedBoster;

    // Token: 0x040002C7 RID: 711
    public int wishSlotsBought;

    // Token: 0x040002C8 RID: 712
    public int invMergeSlots;

    // Token: 0x040002C9 RID: 713
    public bool advLightBought;

    // Token: 0x040002CA RID: 714
    public bool advAdvancerBought;

    // Token: 0x040002CB RID: 715
    public bool goToQuestZoneBought;
}
