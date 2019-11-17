using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000C4 RID: 196
[Serializable]
public class ItemList
{
    // Token: 0x06000BDF RID: 3039 RVA: 0x0009A774 File Offset: 0x00098B74
    public ItemList()
    {
        for (int i = 0; i < 400; i++)
        {
            this.itemDropped.Add(false);
            this.itemMaxxed.Add(false);
            this.itemFiltered.Add(false);
        }
        this.totalDiscovered = 0;
        this.totalMaxxed = 0;
        this.trainingComplete = false;
        this.sewersComplete = false;
        this.forestComplete = false;
        this.caveComplete = false;
        this.skyComplete = false;
        this.HSBComplete = false;
        this.GRBComplete = false;
        this.clockComplete = false;
        this.twoDComplete = false;
        this.ghostComplete = false;
        this.jakeComplete = false;
        this.gaudyComplete = false;
        this.megaComplete = false;
        this.beardverseComplete = false;
        this.waldoComplete = false;
        this.antiWaldoComplete = false;
        this.badlyDrawnComplete = false;
        this.stealthComplete = false;
        this.beast1complete = false;
        this.chocoComplete = false;
        this.edgyComplete = false;
        this.edgyBootsComplete = false;
        this.prettyComplete = false;
        this.nerdComplete = false;
        this.metaComplete = false;
        this.partyComplete = false;
        this.godmotherComplete = false;
        this.typoComplete = false;
        this.fadComplete = false;
        this.jrpgComplete = false;
        this.exileComplete = false;
        this.radComplete = false;
        this.schoolComplete = false;
        this.westernComplete = false;
        this.spaceComplete = false;
        this.wandoosComplete = false;
        this.tutorialCubeComplete = false;
        this.numberComplete = false;
        this.flubberComplete = false;
        this.seedComplete = false;
        this.uugComplete = false;
        this.uugRingComplete = false;
        this.redLiquidComplete = false;
        this.brownHeartComplete = false;
        this.xlComplete = false;
        this.greenHeartComplete = false;
        this.itopodKeyComplete = false;
        this.purpleLiquidComplete = false;
        this.blueHeartComplete = false;
        this.jakeNoteComplete = false;
        this.purpleHeartComplete = false;
        this.orangeHeartComplete = false;
        this.greyHeartComplete = false;
        this.sigilComplete = false;
        this.evidenceComplete = false;
        this.greyHeartComplete = false;
        this.pinkHeartComplete = false;
        this.severedHeadComplete = false;
    }

    // Token: 0x06000BE0 RID: 3040 RVA: 0x0009A988 File Offset: 0x00098D88
    public void checkItemList()
    {
        if (this.itemDropped == null)
        {
            this.itemDropped = new List<bool>();
        }
        if (this.itemMaxxed == null)
        {
            this.itemDropped = new List<bool>();
        }
        if (this.itemFiltered == null)
        {
            this.itemFiltered = new List<bool>();
        }
        while (this.itemDropped.Count < 400)
        {
            this.itemDropped.Add(false);
        }
        while (this.itemMaxxed.Count < 400)
        {
            this.itemMaxxed.Add(false);
        }
        while (this.itemFiltered.Count < 400)
        {
            this.itemFiltered.Add(false);
        }
        if (this.itemDropped.Count >= 289 && this.itemDropped[288] && !this.itemMaxxed[288])
        {
            this.itemMaxxed[288] = true;
        }
    }

    // Token: 0x06000BE1 RID: 3041 RVA: 0x0009AA9C File Offset: 0x00098E9C
    //public void debugList()
    //{
    //    for (int i = 0; i < 400; i++)
    //    {
    //        Debug.Log(i + " id dropped is " + this.itemDropped[i]);
    //        Debug.Log(i + " id maxxxed is " + this.itemMaxxed[i]);
    //        Debug.Log(i + " id filtered is " + this.itemMaxxed[i]);
    //    }
    //}

    // Token: 0x06000BE2 RID: 3042 RVA: 0x0009AB34 File Offset: 0x00098F34
    //public void debugList(int i)
    //{
    //    Debug.Log(i + " id dropped is " + this.itemDropped[i]);
    //    Debug.Log(i + " id maxxxed is " + this.itemMaxxed[i]);
    //    Debug.Log(i + " id filtered is " + this.itemMaxxed[i]);
    //}

    // Token: 0x06000BE3 RID: 3043 RVA: 0x0009ABB3 File Offset: 0x00098FB3
    public float totalBonus()
    {
        return (1f + (float)this.totalDiscovered * 0.005f) * (1f + (float)this.totalMaxxed * 0.01f);
    }

    // Token: 0x06000BE4 RID: 3044 RVA: 0x0009ABDC File Offset: 0x00098FDC
    public bool maxxedTraining()
    {
        return this.itemMaxxed[62] && this.itemMaxxed[63] && this.itemMaxxed[64] && this.itemMaxxed[65] && this.itemMaxxed[75];
    }

    // Token: 0x06000BE5 RID: 3045 RVA: 0x0009AC44 File Offset: 0x00099044
    public bool maxxedSewers()
    {
        return this.itemMaxxed[40] && this.itemMaxxed[41] && this.itemMaxxed[42] && this.itemMaxxed[43] && this.itemMaxxed[44] && this.itemMaxxed[45] && this.itemMaxxed[46];
    }

    // Token: 0x06000BE6 RID: 3046 RVA: 0x0009ACD0 File Offset: 0x000990D0
    public bool maxxedForest()
    {
        return this.itemMaxxed[47] && this.itemMaxxed[48] && this.itemMaxxed[49] && this.itemMaxxed[50] && this.itemMaxxed[51] && this.itemMaxxed[52] && this.itemMaxxed[53];
    }

    // Token: 0x06000BE7 RID: 3047 RVA: 0x0009AD5C File Offset: 0x0009915C
    public bool maxxedCave()
    {
        return this.itemMaxxed[54] && this.itemMaxxed[55] && this.itemMaxxed[56] && this.itemMaxxed[57] && this.itemMaxxed[58] && this.itemMaxxed[59] && this.itemMaxxed[60] && this.itemMaxxed[61];
    }

    // Token: 0x06000BE8 RID: 3048 RVA: 0x0009ADF8 File Offset: 0x000991F8
    public bool maxxedHSB()
    {
        return this.itemMaxxed[68] && this.itemMaxxed[69] && this.itemMaxxed[70] && this.itemMaxxed[71] && this.itemMaxxed[72] && this.itemMaxxed[73] && this.itemMaxxed[74];
    }

    // Token: 0x06000BE9 RID: 3049 RVA: 0x0009AE84 File Offset: 0x00099284
    public bool maxxedGRB()
    {
        return this.itemMaxxed[78] && this.itemMaxxed[79] && this.itemMaxxed[80] && this.itemMaxxed[81] && this.itemMaxxed[82] && this.itemMaxxed[83] && this.itemMaxxed[84];
    }

    // Token: 0x06000BEA RID: 3050 RVA: 0x0009AF10 File Offset: 0x00099310
    public bool maxxedClock()
    {
        return this.itemMaxxed[85] && this.itemMaxxed[86] && this.itemMaxxed[87] && this.itemMaxxed[88] && this.itemMaxxed[89] && this.itemMaxxed[90] && this.itemMaxxed[91];
    }

    // Token: 0x06000BEB RID: 3051 RVA: 0x0009AF9C File Offset: 0x0009939C
    public bool maxxed2D()
    {
        return this.itemMaxxed[95] && this.itemMaxxed[96] && this.itemMaxxed[97] && this.itemMaxxed[98] && this.itemMaxxed[99] && this.itemMaxxed[100] && this.itemMaxxed[101];
    }

    // Token: 0x06000BEC RID: 3052 RVA: 0x0009B028 File Offset: 0x00099428
    public bool maxxedGhost()
    {
        return this.itemMaxxed[103] && this.itemMaxxed[104] && this.itemMaxxed[105] && this.itemMaxxed[106] && this.itemMaxxed[107] && this.itemMaxxed[108] && this.itemMaxxed[109];
    }

    // Token: 0x06000BED RID: 3053 RVA: 0x0009B0B4 File Offset: 0x000994B4
    public bool maxxedJake()
    {
        return this.itemMaxxed[111] && this.itemMaxxed[112] && this.itemMaxxed[113] && this.itemMaxxed[114] && this.itemMaxxed[115] && this.itemMaxxed[116] && this.itemMaxxed[117];
    }

    // Token: 0x06000BEE RID: 3054 RVA: 0x0009B140 File Offset: 0x00099540
    public bool maxxedGaudy()
    {
        return this.itemMaxxed[122] && this.itemMaxxed[123] && this.itemMaxxed[124] && this.itemMaxxed[125] && this.itemMaxxed[126];
    }

    // Token: 0x06000BEF RID: 3055 RVA: 0x0009B1A8 File Offset: 0x000995A8
    public bool maxxedMega()
    {
        return this.itemMaxxed[130] && this.itemMaxxed[131] && this.itemMaxxed[132] && this.itemMaxxed[133] && this.itemMaxxed[134];
    }

    // Token: 0x06000BF0 RID: 3056 RVA: 0x0009B21C File Offset: 0x0009961C
    public bool maxxedWandoos()
    {
        return this.itemMaxxed[66];
    }

    // Token: 0x06000BF1 RID: 3057 RVA: 0x0009B22B File Offset: 0x0009962B
    public bool maxxedNumber()
    {
        return this.itemMaxxed[102];
    }

    // Token: 0x06000BF2 RID: 3058 RVA: 0x0009B23A File Offset: 0x0009963A
    public bool maxxedTutorialCube()
    {
        return this.itemMaxxed[77];
    }

    // Token: 0x06000BF3 RID: 3059 RVA: 0x0009B24C File Offset: 0x0009964C
    public bool receivedGRBSet()
    {
        return this.itemDropped[78] && this.itemDropped[79] && this.itemDropped[80] && this.itemDropped[81] && this.itemDropped[82] && this.itemDropped[83] && this.itemDropped[84];
    }

    // Token: 0x06000BF4 RID: 3060 RVA: 0x0009B2D5 File Offset: 0x000996D5
    public bool maxxedFlubber()
    {
        return this.itemMaxxed[121];
    }

    // Token: 0x06000BF5 RID: 3061 RVA: 0x0009B2E4 File Offset: 0x000996E4
    public bool maxxedSeed()
    {
        return this.itemMaxxed[92];
    }

    // Token: 0x06000BF6 RID: 3062 RVA: 0x0009B2F3 File Offset: 0x000996F3
    public bool maxxedUUG()
    {
        return this.itemMaxxed[141];
    }

    // Token: 0x06000BF7 RID: 3063 RVA: 0x0009B308 File Offset: 0x00099708
    public bool maxxedRingUUG()
    {
        return this.itemMaxxed[136] && this.itemMaxxed[137] && this.itemMaxxed[138] && this.itemMaxxed[139] && this.itemMaxxed[140];
    }

    // Token: 0x06000BF8 RID: 3064 RVA: 0x0009B37C File Offset: 0x0009977C
    public bool maxxedBeardverse()
    {
        return this.itemMaxxed[143] && this.itemMaxxed[144] && this.itemMaxxed[145] && this.itemMaxxed[146] && this.itemMaxxed[147];
    }

    // Token: 0x06000BF9 RID: 3065 RVA: 0x0009B3F0 File Offset: 0x000997F0
    public bool maxxedRedLiquid()
    {
        return this.itemMaxxed[93];
    }

    // Token: 0x06000BFA RID: 3066 RVA: 0x0009B400 File Offset: 0x00099800
    public bool maxxedWaldo()
    {
        return this.itemMaxxed[150] && this.itemMaxxed[151] && this.itemMaxxed[152] && this.itemMaxxed[153];
    }

    // Token: 0x06000BFB RID: 3067 RVA: 0x0009B460 File Offset: 0x00099860
    public bool maxxedAntiWaldo()
    {
        return this.itemMaxxed[155] && this.itemMaxxed[156] && this.itemMaxxed[157] && this.itemMaxxed[158];
    }

    // Token: 0x06000BFC RID: 3068 RVA: 0x0009B4C0 File Offset: 0x000998C0
    public bool maxxedBadlyDrawn()
    {
        return this.itemMaxxed[164] && this.itemMaxxed[165] && this.itemMaxxed[166] && this.itemMaxxed[167] && this.itemMaxxed[168];
    }

    // Token: 0x06000BFD RID: 3069 RVA: 0x0009B534 File Offset: 0x00099934
    public bool maxxedStealth()
    {
        return this.itemMaxxed[173] && this.itemMaxxed[174] && this.itemMaxxed[175] && this.itemMaxxed[176] && this.itemMaxxed[177];
    }

    // Token: 0x06000BFE RID: 3070 RVA: 0x0009B5A8 File Offset: 0x000999A8
    public bool maxxedBeast1()
    {
        return this.itemMaxxed[184] && this.itemMaxxed[185] && this.itemMaxxed[186] && this.itemMaxxed[187] && this.itemMaxxed[188];
    }

    // Token: 0x06000BFF RID: 3071 RVA: 0x0009B61C File Offset: 0x00099A1C
    public bool maxxedEdgy()
    {
        return this.itemMaxxed[213] && this.itemMaxxed[214] && this.itemMaxxed[215] && this.itemMaxxed[217] && this.itemMaxxed[218];
    }

    // Token: 0x06000C00 RID: 3072 RVA: 0x0009B690 File Offset: 0x00099A90
    public bool maxxedEdgyBoots()
    {
        return this.itemMaxxed[216] && this.itemMaxxed[219];
    }

    // Token: 0x06000C01 RID: 3073 RVA: 0x0009B6BA File Offset: 0x00099ABA
    public bool maxxedBrownHeart()
    {
        return this.itemMaxxed[162];
    }

    // Token: 0x06000C02 RID: 3074 RVA: 0x0009B6CC File Offset: 0x00099ACC
    public bool maxxedXL()
    {
        return this.itemMaxxed[163];
    }

    // Token: 0x06000C03 RID: 3075 RVA: 0x0009B6DE File Offset: 0x00099ADE
    public bool maxxedGreenHeart()
    {
        return this.itemMaxxed[171];
    }

    // Token: 0x06000C04 RID: 3076 RVA: 0x0009B6F0 File Offset: 0x00099AF0
    public bool maxxedItopodKey()
    {
        return this.itemMaxxed[172];
    }

    // Token: 0x06000C05 RID: 3077 RVA: 0x0009B702 File Offset: 0x00099B02
    public bool maxxedPurpleLiquid()
    {
        return this.itemMaxxed[191];
    }

    // Token: 0x06000C06 RID: 3078 RVA: 0x0009B714 File Offset: 0x00099B14
    public bool maxxedBlueHeart()
    {
        return this.itemMaxxed[196];
    }

    // Token: 0x06000C07 RID: 3079 RVA: 0x0009B726 File Offset: 0x00099B26
    public bool maxxedJakeNote()
    {
        return this.itemMaxxed[197];
    }

    // Token: 0x06000C08 RID: 3080 RVA: 0x0009B738 File Offset: 0x00099B38
    public bool maxxedPurpleHeart()
    {
        return this.itemMaxxed[212];
    }

    // Token: 0x06000C09 RID: 3081 RVA: 0x0009B74A File Offset: 0x00099B4A
    public bool maxxedGreyHeart()
    {
        return this.itemMaxxed[297];
    }

    // Token: 0x06000C0A RID: 3082 RVA: 0x0009B75C File Offset: 0x00099B5C
    public bool maxxedPinkHeart()
    {
        return this.itemMaxxed[344];
    }

    // Token: 0x06000C0B RID: 3083 RVA: 0x0009B770 File Offset: 0x00099B70
    public bool maxxedChoco()
    {
        return this.itemMaxxed[221] && this.itemMaxxed[222] && this.itemMaxxed[223] && this.itemMaxxed[224] && this.itemMaxxed[225];
    }

    // Token: 0x06000C0C RID: 3084 RVA: 0x0009B7E4 File Offset: 0x00099BE4
    public bool maxxedPretty()
    {
        return this.itemMaxxed[231] && this.itemMaxxed[232] && this.itemMaxxed[233] && this.itemMaxxed[234] && this.itemMaxxed[235] && this.itemMaxxed[236];
    }

    // Token: 0x06000C0D RID: 3085 RVA: 0x0009B870 File Offset: 0x00099C70
    public bool maxxedNerd()
    {
        return this.itemMaxxed[237] && this.itemMaxxed[238] && this.itemMaxxed[239] && this.itemMaxxed[240] && this.itemMaxxed[241];
    }

    // Token: 0x06000C0E RID: 3086 RVA: 0x0009B8E4 File Offset: 0x00099CE4
    public bool maxxedMeta()
    {
        return this.itemMaxxed[251] && this.itemMaxxed[252] && this.itemMaxxed[253] && this.itemMaxxed[254] && this.itemMaxxed[255] && this.itemMaxxed[256] && this.itemMaxxed[257];
    }

    // Token: 0x06000C0F RID: 3087 RVA: 0x0009B984 File Offset: 0x00099D84
    public bool maxxedParty()
    {
        return this.itemMaxxed[258] && this.itemMaxxed[259] && this.itemMaxxed[260] && this.itemMaxxed[261] && this.itemMaxxed[262] && this.itemMaxxed[263] && this.itemMaxxed[264];
    }

    // Token: 0x06000C10 RID: 3088 RVA: 0x0009BA24 File Offset: 0x00099E24
    public bool maxxedGodmother()
    {
        return this.itemMaxxed[265] && this.itemMaxxed[266] && this.itemMaxxed[267] && this.itemMaxxed[268] && this.itemMaxxed[269] && this.itemMaxxed[270] && this.itemMaxxed[271];
    }

    // Token: 0x06000C11 RID: 3089 RVA: 0x0009BAC2 File Offset: 0x00099EC2
    public bool maxxedOrangeHeart()
    {
        return this.itemMaxxed[293];
    }

    // Token: 0x06000C12 RID: 3090 RVA: 0x0009BAD4 File Offset: 0x00099ED4
    public bool maxxedHeroicSigil()
    {
        return this.itemMaxxed[292];
    }

    // Token: 0x06000C13 RID: 3091 RVA: 0x0009BAE6 File Offset: 0x00099EE6
    public bool maxxedEvidence()
    {
        return this.itemMaxxed[294];
    }

    // Token: 0x06000C14 RID: 3092 RVA: 0x0009BAF8 File Offset: 0x00099EF8
    public bool maxxedSeveredHead()
    {
        return this.itemMaxxed[343];
    }

    // Token: 0x06000C15 RID: 3093 RVA: 0x0009BB0C File Offset: 0x00099F0C
    public bool maxxedTypo()
    {
        return this.itemMaxxed[301] && this.itemMaxxed[302] && this.itemMaxxed[303] && this.itemMaxxed[304] && this.itemMaxxed[305] && this.itemMaxxed[306] && this.itemMaxxed[307];
    }

    // Token: 0x06000C16 RID: 3094 RVA: 0x0009BBAC File Offset: 0x00099FAC
    public bool maxxedFad()
    {
        return this.itemMaxxed[308] && this.itemMaxxed[309] && this.itemMaxxed[310] && this.itemMaxxed[311] && this.itemMaxxed[312] && this.itemMaxxed[313] && this.itemMaxxed[314];
    }

    // Token: 0x06000C17 RID: 3095 RVA: 0x0009BC4C File Offset: 0x0009A04C
    public bool maxxedJRPG()
    {
        return this.itemMaxxed[315] && this.itemMaxxed[316] && this.itemMaxxed[317] && this.itemMaxxed[318] && this.itemMaxxed[319] && this.itemMaxxed[320] && this.itemMaxxed[321];
    }

    // Token: 0x06000C18 RID: 3096 RVA: 0x0009BCEC File Offset: 0x0009A0EC
    public bool maxxedExile()
    {
        return this.itemMaxxed[322] && this.itemMaxxed[323] && this.itemMaxxed[324] && this.itemMaxxed[325] && this.itemMaxxed[326];
    }

    // Token: 0x06000C19 RID: 3097 RVA: 0x0009BD60 File Offset: 0x0009A160
    public bool droppedAllSewers()
    {
        return this.itemDropped[40] && this.itemDropped[41] && this.itemDropped[42] && this.itemDropped[43] && this.itemDropped[44] && this.itemDropped[45] && this.itemDropped[46];
    }

    // Token: 0x06000C1A RID: 3098 RVA: 0x0009BDEC File Offset: 0x0009A1EC
    public bool maxxedRad()
    {
        return this.itemMaxxed[345] && this.itemMaxxed[346] && this.itemMaxxed[347] && this.itemMaxxed[348] && this.itemMaxxed[349] && this.itemMaxxed[350] && this.itemMaxxed[351];
    }

    // Token: 0x06000C1B RID: 3099 RVA: 0x0009BE8C File Offset: 0x0009A28C
    public bool maxxedSchool()
    {
        return this.itemMaxxed[352] && this.itemMaxxed[353] && this.itemMaxxed[354] && this.itemMaxxed[355] && this.itemMaxxed[356] && this.itemMaxxed[357] && this.itemMaxxed[358];
    }

    // Token: 0x06000C1C RID: 3100 RVA: 0x0009BF2C File Offset: 0x0009A32C
    public bool maxxedWestern()
    {
        return this.itemMaxxed[359] && this.itemMaxxed[360] && this.itemMaxxed[361] && this.itemMaxxed[362] && this.itemMaxxed[363] && this.itemMaxxed[364] && this.itemMaxxed[365];
    }

    // Token: 0x06000C1D RID: 3101 RVA: 0x0009BFCC File Offset: 0x0009A3CC
    public bool maxxedSpace()
    {
        return this.itemMaxxed[373] && this.itemMaxxed[374] && this.itemMaxxed[375] && this.itemMaxxed[376] && this.itemMaxxed[377] && this.itemMaxxed[378] && this.itemMaxxed[379];
    }

    // Token: 0x0400097C RID: 2428
    public List<bool> itemDropped = new List<bool>();

    // Token: 0x0400097D RID: 2429
    public List<bool> itemMaxxed = new List<bool>();

    // Token: 0x0400097E RID: 2430
    public List<bool> itemFiltered = new List<bool>();

    // Token: 0x0400097F RID: 2431
    public int totalDiscovered;

    // Token: 0x04000980 RID: 2432
    public int totalMaxxed;

    // Token: 0x04000981 RID: 2433
    public bool trainingComplete;

    // Token: 0x04000982 RID: 2434
    public bool sewersComplete;

    // Token: 0x04000983 RID: 2435
    public bool forestComplete;

    // Token: 0x04000984 RID: 2436
    public bool caveComplete;

    // Token: 0x04000985 RID: 2437
    public bool skyComplete;

    // Token: 0x04000986 RID: 2438
    public bool HSBComplete;

    // Token: 0x04000987 RID: 2439
    public bool GRBComplete;

    // Token: 0x04000988 RID: 2440
    public bool clockComplete;

    // Token: 0x04000989 RID: 2441
    public bool twoDComplete;

    // Token: 0x0400098A RID: 2442
    public bool ghostComplete;

    // Token: 0x0400098B RID: 2443
    public bool jakeComplete;

    // Token: 0x0400098C RID: 2444
    public bool gaudyComplete;

    // Token: 0x0400098D RID: 2445
    public bool megaComplete;

    // Token: 0x0400098E RID: 2446
    public bool beardverseComplete;

    // Token: 0x0400098F RID: 2447
    public bool waldoComplete;

    // Token: 0x04000990 RID: 2448
    public bool antiWaldoComplete;

    // Token: 0x04000991 RID: 2449
    public bool badlyDrawnComplete;

    // Token: 0x04000992 RID: 2450
    public bool stealthComplete;

    // Token: 0x04000993 RID: 2451
    public bool beast1complete;

    // Token: 0x04000994 RID: 2452
    public bool chocoComplete;

    // Token: 0x04000995 RID: 2453
    public bool edgyComplete;

    // Token: 0x04000996 RID: 2454
    public bool edgyBootsComplete;

    // Token: 0x04000997 RID: 2455
    public bool prettyComplete;

    // Token: 0x04000998 RID: 2456
    public bool nerdComplete;

    // Token: 0x04000999 RID: 2457
    public bool metaComplete;

    // Token: 0x0400099A RID: 2458
    public bool partyComplete;

    // Token: 0x0400099B RID: 2459
    public bool godmotherComplete;

    // Token: 0x0400099C RID: 2460
    public bool typoComplete;

    // Token: 0x0400099D RID: 2461
    public bool fadComplete;

    // Token: 0x0400099E RID: 2462
    public bool jrpgComplete;

    // Token: 0x0400099F RID: 2463
    public bool exileComplete;

    // Token: 0x040009A0 RID: 2464
    public bool radComplete;

    // Token: 0x040009A1 RID: 2465
    public bool schoolComplete;

    // Token: 0x040009A2 RID: 2466
    public bool westernComplete;

    // Token: 0x040009A3 RID: 2467
    public bool spaceComplete;

    // Token: 0x040009A4 RID: 2468
    public bool wandoosComplete;

    // Token: 0x040009A5 RID: 2469
    public bool tutorialCubeComplete;

    // Token: 0x040009A6 RID: 2470
    public bool numberComplete;

    // Token: 0x040009A7 RID: 2471
    public bool flubberComplete;

    // Token: 0x040009A8 RID: 2472
    public bool seedComplete;

    // Token: 0x040009A9 RID: 2473
    public bool uugComplete;

    // Token: 0x040009AA RID: 2474
    public bool uugRingComplete;

    // Token: 0x040009AB RID: 2475
    public bool redLiquidComplete;

    // Token: 0x040009AC RID: 2476
    public bool brownHeartComplete;

    // Token: 0x040009AD RID: 2477
    public bool xlComplete;

    // Token: 0x040009AE RID: 2478
    public bool greenHeartComplete;

    // Token: 0x040009AF RID: 2479
    public bool itopodKeyComplete;

    // Token: 0x040009B0 RID: 2480
    public bool purpleLiquidComplete;

    // Token: 0x040009B1 RID: 2481
    public bool blueHeartComplete;

    // Token: 0x040009B2 RID: 2482
    public bool jakeNoteComplete;

    // Token: 0x040009B3 RID: 2483
    public bool purpleHeartComplete;

    // Token: 0x040009B4 RID: 2484
    public bool orangeHeartComplete;

    // Token: 0x040009B5 RID: 2485
    public bool greyHeartComplete;

    // Token: 0x040009B6 RID: 2486
    public bool sigilComplete;

    // Token: 0x040009B7 RID: 2487
    public bool evidenceComplete;

    // Token: 0x040009B8 RID: 2488
    public bool pinkHeartComplete;

    // Token: 0x040009B9 RID: 2489
    public bool severedHeadComplete;
}
