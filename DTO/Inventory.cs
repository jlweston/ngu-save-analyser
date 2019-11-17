using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000C7 RID: 199
[Serializable]
public class Inventory
{
    // Token: 0x06000C2B RID: 3115 RVA: 0x0009DCFC File Offset: 0x0009C0FC
    public Inventory()
    {
        this.spaces = 24;
        this.head = new Equipment();
        this.chest = new Equipment();
        this.legs = new Equipment();
        this.boots = new Equipment();
        this.weapon = new Equipment();
        this.weapon2 = new Equipment();
        this.acc1 = new Equipment();
        this.acc2 = new Equipment();
        this.acc3 = new Equipment();
        this.temp = new Equipment();
        this.trash = new Equipment();
        for (int i = 0; i < this.items.Length; i++)
        {
            this.items[i] = new Equipment();
        }
        for (int j = 0; j < this.accessories.Length; j++)
        {
            this.accessories[j] = new Equipment();
        }
        this.item1 = -1;
        this.item2 = -1;
        this.itemList = new ItemList();
        this.autoMergeSlot1 = 0;
        //this.boostCombineState = default(UnityEngine.Random.State);
        while (this.loadouts.Count < this.loadoutsSize())
        {
            this.loadouts.Add(new Loadout());
        }
        for (int k = 0; k < this.loadouts.Count; k++)
        {
            this.loadouts[k].loadoutName = "Loadout " + (k + 1).ToString();
        }
        while (this.inventory.Count < 24)
        {
            this.inventory.Add(new Equipment());
        }
        while (this.accs.Count < 2)
        {
            this.accs.Add(new Equipment());
        }
        while (this.macguffins.Count < 1)
        {
            this.macguffins.Add(new Equipment());
        }
        while (this.daycare.Count < 1)
        {
            this.daycare.Add(new Equipment());
            this.daycareTimers.Add(new PlayerTime());
        }
        while (this.macguffinBonuses.Count < 24)
        {
            this.macguffinBonuses.Add(1f);
        }
        while (this.unlockedKittyArt.Count < this.kittyArtSize())
        {
            this.unlockedKittyArt.Add(false);
        }
        this.cubePower = 0f;
        this.cubeToughness = 0f;
        this.disabled = false;
        this.selectedGraphic = 0;
        this.kittyArt = 0;
    }

    // Token: 0x06000C2C RID: 3116 RVA: 0x0009E02E File Offset: 0x0009C42E
    public int loadoutsSize()
    {
        return 10;
    }

    // Token: 0x06000C2D RID: 3117 RVA: 0x0009E032 File Offset: 0x0009C432
    public int kittyArtSize()
    {
        return 11;
    }

    // Token: 0x06000C2E RID: 3118 RVA: 0x0009E036 File Offset: 0x0009C436
    public float adventureAttackBonus()
    {
        return this.attackBonus();
    }

    // Token: 0x06000C2F RID: 3119 RVA: 0x0009E03E File Offset: 0x0009C43E
    public float adventureDefenseBonus()
    {
        return this.defenseBonus();
    }

    // Token: 0x06000C30 RID: 3120 RVA: 0x0009E046 File Offset: 0x0009C446
    public float adventureHPBonus()
    {
        return this.defenseBonus() * 3f;
    }

    // Token: 0x06000C31 RID: 3121 RVA: 0x0009E054 File Offset: 0x0009C454
    public float adventureHPRegenBonus()
    {
        return this.defenseBonus() * 0.03f;
    }

    // Token: 0x06000C32 RID: 3122 RVA: 0x0009E062 File Offset: 0x0009C462
    public float attackBonus()
    {
        return this.weaponAttack() + this.acc1Attack() + this.acc2Attack() + this.acc3Attack() + this.headAttack() + this.chestAttack() + this.legsAttack() + this.bootsAttack();
    }

    // Token: 0x06000C33 RID: 3123 RVA: 0x0009E09B File Offset: 0x0009C49B
    public float defenseBonus()
    {
        return this.headDefense() + this.chestDefense() + this.legsDefense() + this.bootsDefense() + this.acc1Defense() + this.acc2Defense() + this.acc3Defense() + this.weaponDefense();
    }

    // Token: 0x06000C34 RID: 3124 RVA: 0x0009E0D4 File Offset: 0x0009C4D4
    public float weaponAttack()
    {
        return this.weapon.curAttack;
    }

    // Token: 0x06000C35 RID: 3125 RVA: 0x0009E0E1 File Offset: 0x0009C4E1
    public float weaponDefense()
    {
        return this.weapon.curDefense;
    }

    // Token: 0x06000C36 RID: 3126 RVA: 0x0009E0EE File Offset: 0x0009C4EE
    public float headDefense()
    {
        return this.head.curDefense;
    }

    // Token: 0x06000C37 RID: 3127 RVA: 0x0009E0FB File Offset: 0x0009C4FB
    public float chestDefense()
    {
        return this.chest.curDefense;
    }

    // Token: 0x06000C38 RID: 3128 RVA: 0x0009E108 File Offset: 0x0009C508
    public float legsDefense()
    {
        return this.legs.curDefense;
    }

    // Token: 0x06000C39 RID: 3129 RVA: 0x0009E115 File Offset: 0x0009C515
    public float bootsDefense()
    {
        return this.boots.curDefense;
    }

    // Token: 0x06000C3A RID: 3130 RVA: 0x0009E122 File Offset: 0x0009C522
    public float headAttack()
    {
        return this.head.curAttack;
    }

    // Token: 0x06000C3B RID: 3131 RVA: 0x0009E12F File Offset: 0x0009C52F
    public float chestAttack()
    {
        return this.chest.curAttack;
    }

    // Token: 0x06000C3C RID: 3132 RVA: 0x0009E13C File Offset: 0x0009C53C
    public float legsAttack()
    {
        return this.legs.curAttack;
    }

    // Token: 0x06000C3D RID: 3133 RVA: 0x0009E149 File Offset: 0x0009C549
    public float bootsAttack()
    {
        return this.boots.curAttack;
    }

    // Token: 0x06000C3E RID: 3134 RVA: 0x0009E156 File Offset: 0x0009C556
    public float acc1Attack()
    {
        return this.acc1.curAttack;
    }

    // Token: 0x06000C3F RID: 3135 RVA: 0x0009E163 File Offset: 0x0009C563
    public float acc1Defense()
    {
        return this.acc1.curDefense;
    }

    // Token: 0x06000C40 RID: 3136 RVA: 0x0009E170 File Offset: 0x0009C570
    public float acc2Attack()
    {
        return this.acc2.curAttack;
    }

    // Token: 0x06000C41 RID: 3137 RVA: 0x0009E17D File Offset: 0x0009C57D
    public float acc2Defense()
    {
        return this.acc2.curDefense;
    }

    // Token: 0x06000C42 RID: 3138 RVA: 0x0009E18A File Offset: 0x0009C58A
    public float acc3Attack()
    {
        return this.acc3.curAttack;
    }

    // Token: 0x06000C43 RID: 3139 RVA: 0x0009E197 File Offset: 0x0009C597
    public float acc3Defense()
    {
        return this.acc3.curDefense;
    }

    // Token: 0x06000C44 RID: 3140 RVA: 0x0009E1A4 File Offset: 0x0009C5A4
    public void swapItems()
    {
        this.markLoadoutIDSwap(this.item1, this.item2);
        this.temp = this.inventory[this.item1];
        this.inventory[this.item1] = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C45 RID: 3141 RVA: 0x0009E214 File Offset: 0x0009C614
    public void swapHead()
    {
        this.markLoadoutIDSwap(-1, this.item2);
        this.temp = this.head;
        this.head = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C46 RID: 3142 RVA: 0x0009E268 File Offset: 0x0009C668
    public bool boostHead()
    {
        return this.head.boostEquip(this.inventory[this.item2]);
    }

    // Token: 0x06000C47 RID: 3143 RVA: 0x0009E288 File Offset: 0x0009C688
    public void swapChest()
    {
        this.markLoadoutIDSwap(-2, this.item2);
        this.temp = this.chest;
        this.chest = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C48 RID: 3144 RVA: 0x0009E2DD File Offset: 0x0009C6DD
    public bool boostChest()
    {
        return this.chest.boostEquip(this.inventory[this.item2]);
    }

    // Token: 0x06000C49 RID: 3145 RVA: 0x0009E2FC File Offset: 0x0009C6FC
    public void swapLegs()
    {
        this.markLoadoutIDSwap(-3, this.item2);
        this.temp = this.legs;
        this.legs = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C4A RID: 3146 RVA: 0x0009E351 File Offset: 0x0009C751
    public bool boostLegs()
    {
        return this.legs.boostEquip(this.inventory[this.item2]);
    }

    // Token: 0x06000C4B RID: 3147 RVA: 0x0009E370 File Offset: 0x0009C770
    public void swapBoots()
    {
        this.markLoadoutIDSwap(-4, this.item2);
        this.temp = this.boots;
        this.boots = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C4C RID: 3148 RVA: 0x0009E3C5 File Offset: 0x0009C7C5
    public bool boostBoots()
    {
        return this.boots.boostEquip(this.inventory[this.item2]);
    }

    // Token: 0x06000C4D RID: 3149 RVA: 0x0009E3E4 File Offset: 0x0009C7E4
    public void swapWeapon()
    {
        this.markLoadoutIDSwap(-5, this.item2);
        this.temp = this.weapon;
        this.weapon = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C4E RID: 3150 RVA: 0x0009E43C File Offset: 0x0009C83C
    public void swapWeapon2()
    {
        this.markLoadoutIDSwap(-6, this.item2);
        this.temp = this.weapon2;
        this.weapon2 = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C4F RID: 3151 RVA: 0x0009E491 File Offset: 0x0009C891
    public void swapWeapons()
    {
        this.markLoadoutIDSwap(-5, -6);
        this.temp = this.weapon2;
        this.weapon2 = this.weapon;
        this.weapon = this.temp;
    }

    // Token: 0x06000C50 RID: 3152 RVA: 0x0009E4C1 File Offset: 0x0009C8C1
    public bool boostWeapon()
    {
        return this.weapon.boostEquip(this.inventory[this.item2]);
    }

    // Token: 0x06000C51 RID: 3153 RVA: 0x0009E4E0 File Offset: 0x0009C8E0
    public void swapAccs(int a, int b)
    {
        if (a >= this.accs.Count || b >= this.accs.Count)
        {
            return;
        }
        this.markLoadoutIDSwap(a + 10000, b + 10000);
        this.temp = this.accs[a];
        this.accs[a] = this.accs[b];
        this.accs[b] = this.temp;
    }

    // Token: 0x06000C52 RID: 3154 RVA: 0x0009E560 File Offset: 0x0009C960
    public void swapAccWithItem(int accessoryIndex, int itemIndex)
    {
        if (accessoryIndex >= this.accs.Count || itemIndex >= this.inventory.Count)
        {
            return;
        }
        this.markLoadoutIDSwap(accessoryIndex + 10000, itemIndex);
        this.temp = this.accs[accessoryIndex];
        this.accs[accessoryIndex] = this.inventory[itemIndex];
        this.inventory[itemIndex] = this.temp;
    }

    // Token: 0x06000C53 RID: 3155 RVA: 0x0009E5DC File Offset: 0x0009C9DC
    public void swapDaycareWithItem(int daycareIndex, int itemIndex, int levelsToAdd)
    {
        if (daycareIndex >= this.daycare.Count || itemIndex >= this.inventory.Count)
        {
            return;
        }
        this.daycare[daycareIndex].level += levelsToAdd;
        if (this.daycare[daycareIndex].level > 100 && this.daycare[daycareIndex].type != part.MacGuffin)
        {
            this.daycare[daycareIndex].level = 100;
        }
        this.markLoadoutIDSwap(daycareIndex + 100000, itemIndex);
        this.temp = this.daycare[daycareIndex];
        this.daycare[daycareIndex] = this.inventory[itemIndex];
        this.inventory[itemIndex] = this.temp;
    }

    // Token: 0x06000C54 RID: 3156 RVA: 0x0009E6B4 File Offset: 0x0009CAB4
    public void swapMacguffinWithItem(int macguffinIndex, int itemIndex)
    {
        if (macguffinIndex >= this.macguffins.Count || itemIndex >= this.inventory.Count)
        {
            return;
        }
        this.temp = this.macguffins[macguffinIndex];
        this.macguffins[macguffinIndex] = this.inventory[itemIndex];
        this.inventory[itemIndex] = this.temp;
    }

    // Token: 0x06000C55 RID: 3157 RVA: 0x0009E720 File Offset: 0x0009CB20
    public void swapMacguffins(int index1, int index2)
    {
        if (index1 >= this.macguffins.Count || index2 >= this.macguffins.Count)
        {
            return;
        }
        this.temp = this.macguffins[index1];
        this.macguffins[index1] = this.macguffins[index2];
        this.macguffins[index2] = this.temp;
    }

    // Token: 0x06000C56 RID: 3158 RVA: 0x0009E78C File Offset: 0x0009CB8C
    public void swapAcc1()
    {
        this.temp = this.acc1;
        this.acc1 = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C57 RID: 3159 RVA: 0x0009E7C8 File Offset: 0x0009CBC8
    public bool boostAcc1()
    {
        return this.acc1.boostEquip(this.inventory[this.item2]);
    }

    // Token: 0x06000C58 RID: 3160 RVA: 0x0009E7E6 File Offset: 0x0009CBE6
    public void swapAcc2()
    {
        this.temp = this.acc2;
        this.acc2 = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C59 RID: 3161 RVA: 0x0009E822 File Offset: 0x0009CC22
    public bool boostAcc2()
    {
        return this.acc2.boostEquip(this.inventory[this.item2]);
    }

    // Token: 0x06000C5A RID: 3162 RVA: 0x0009E840 File Offset: 0x0009CC40
    public void swapAcc3()
    {
        this.temp = this.acc3;
        this.acc3 = this.inventory[this.item2];
        this.inventory[this.item2] = this.temp;
    }

    // Token: 0x06000C5B RID: 3163 RVA: 0x0009E87C File Offset: 0x0009CC7C
    public bool boostAcc3()
    {
        return this.acc3.boostEquip(this.inventory[this.item2]);
    }

    // Token: 0x06000C5C RID: 3164 RVA: 0x0009E89A File Offset: 0x0009CC9A
    public void swapAccs12()
    {
        this.temp = this.acc1;
        this.acc1 = this.acc2;
        this.acc2 = this.temp;
    }

    // Token: 0x06000C5D RID: 3165 RVA: 0x0009E8C0 File Offset: 0x0009CCC0
    public void swapAccs13()
    {
        this.temp = this.acc1;
        this.acc1 = this.acc3;
        this.acc3 = this.temp;
    }

    // Token: 0x06000C5E RID: 3166 RVA: 0x0009E8E6 File Offset: 0x0009CCE6
    public void swapAccs23()
    {
        this.temp = this.acc2;
        this.acc2 = this.acc3;
        this.acc3 = this.temp;
    }

    // Token: 0x06000C5F RID: 3167 RVA: 0x0009E90C File Offset: 0x0009CD0C
    public void deleteItem(int id)
    {
        this.inventory[id] = null;
        this.inventory[id] = new Equipment();
        this.markLoadoutIDAsDeleted(id);
    }

    // Token: 0x06000C60 RID: 3168 RVA: 0x0009E933 File Offset: 0x0009CD33
    public void deleteHead()
    {
        this.head = null;
        this.head = new Equipment();
        this.markLoadoutIDAsDeleted(-1);
    }

    // Token: 0x06000C61 RID: 3169 RVA: 0x0009E94E File Offset: 0x0009CD4E
    public void deleteChest()
    {
        this.chest = null;
        this.chest = new Equipment();
        this.markLoadoutIDAsDeleted(-2);
    }

    // Token: 0x06000C62 RID: 3170 RVA: 0x0009E96A File Offset: 0x0009CD6A
    public void deleteLegs()
    {
        this.legs = null;
        this.legs = new Equipment();
        this.markLoadoutIDAsDeleted(-3);
    }

    // Token: 0x06000C63 RID: 3171 RVA: 0x0009E986 File Offset: 0x0009CD86
    public void deleteBoots()
    {
        this.boots = null;
        this.boots = new Equipment();
        this.markLoadoutIDAsDeleted(-4);
    }

    // Token: 0x06000C64 RID: 3172 RVA: 0x0009E9A2 File Offset: 0x0009CDA2
    public void deleteWeapon()
    {
        this.weapon = null;
        this.weapon = new Equipment();
        this.markLoadoutIDAsDeleted(-5);
    }

    // Token: 0x06000C65 RID: 3173 RVA: 0x0009E9BE File Offset: 0x0009CDBE
    public void deleteWeapon2()
    {
        this.weapon2 = null;
        this.weapon2 = new Equipment();
        this.markLoadoutIDAsDeleted(-6);
    }

    // Token: 0x06000C66 RID: 3174 RVA: 0x0009E9DA File Offset: 0x0009CDDA
    public void deleteAcc1()
    {
        this.acc1 = null;
        this.acc1 = new Equipment();
    }

    // Token: 0x06000C67 RID: 3175 RVA: 0x0009E9EE File Offset: 0x0009CDEE
    public void deleteAcc2()
    {
        this.acc2 = null;
        this.acc2 = new Equipment();
    }

    // Token: 0x06000C68 RID: 3176 RVA: 0x0009EA02 File Offset: 0x0009CE02
    public void deleteAcc3()
    {
        this.acc3 = null;
        this.acc3 = new Equipment();
    }

    // Token: 0x06000C69 RID: 3177 RVA: 0x0009EA18 File Offset: 0x0009CE18
    public bool mergeable()
    {
        return this.inventory[this.item1].id == this.inventory[this.item2].id && (this.inventory[this.item1].type == part.Accessory || this.inventory[this.item1].type == part.Head || this.inventory[this.item1].type == part.Chest || this.inventory[this.item1].type == part.Legs || this.inventory[this.item1].type == part.Boots || this.inventory[this.item1].type == part.Weapon);
    }

    // Token: 0x06000C6A RID: 3178 RVA: 0x0009EB00 File Offset: 0x0009CF00
    public void validateInventory()
    {
        if (this.spaces < 24)
        {
            this.spaces = 24;
        }
        for (int i = 0; i < this.inventory.Count; i++)
        {
            if (this.inventory[i].id > 200)
            {
                this.inventory[i] = new Equipment();
            }
        }
        for (int j = 0; j < this.inventory.Count; j++)
        {
            if (this.inventory[j].id > 200)
            {
                this.inventory[j] = new Equipment();
            }
        }
        if (this.itemList == null)
        {
            this.itemList = new ItemList();
        }
        if (this.head.id > 200)
        {
            this.head = new Equipment();
        }
        if (this.chest.id > 200)
        {
            this.chest = new Equipment();
        }
        if (this.legs.id > 200)
        {
            this.legs = new Equipment();
        }
        if (this.boots.id > 200)
        {
            this.boots = new Equipment();
        }
        if (this.weapon.id > 200)
        {
            this.weapon = new Equipment();
        }
        if (this.acc1.id > 200)
        {
            this.acc1 = new Equipment();
        }
        if (this.acc2.id > 200)
        {
            this.acc2 = new Equipment();
        }
        if (this.acc3.id > 200)
        {
            this.acc3 = new Equipment();
        }
        if (this.trash.id > 200)
        {
            this.trash = new Equipment();
        }
        for (int k = 0; k < this.accs.Count; k++)
        {
            if (this.accs[k].id > 200)
            {
                this.accs[k] = new Equipment();
            }
        }
    }

    // Token: 0x06000C6B RID: 3179 RVA: 0x0009ED30 File Offset: 0x0009D130
    public void markLoadoutIDAsDeleted(int id)
    {
        for (int i = 0; i < this.loadouts.Count; i++)
        {
            if (this.loadouts[i].head == id)
            {
                this.loadouts[i].head = -1000;
            }
            if (this.loadouts[i].chest == id)
            {
                this.loadouts[i].chest = -1000;
            }
            if (this.loadouts[i].legs == id)
            {
                this.loadouts[i].legs = -1000;
            }
            if (this.loadouts[i].boots == id)
            {
                this.loadouts[i].boots = -1000;
            }
            if (this.loadouts[i].weapon == id)
            {
                this.loadouts[i].weapon = -1000;
            }
            if (this.loadouts[i].weapon2 == id)
            {
                this.loadouts[i].weapon2 = -1000;
            }
            for (int j = 0; j < this.loadouts[i].accessories.Count; j++)
            {
                if (this.loadouts[i].accessories[j] == id)
                {
                    this.loadouts[i].accessories[j] = -1000;
                }
            }
        }
    }

    // Token: 0x06000C6C RID: 3180 RVA: 0x0009EEC8 File Offset: 0x0009D2C8
    public void markLoadoutIDSwap(int id1, int id2)
    {
        for (int i = 0; i < this.loadouts.Count; i++)
        {
            if (this.loadouts[i].head == id1)
            {
                this.loadouts[i].head = id2;
            }
            else if (this.loadouts[i].head == id2)
            {
                this.loadouts[i].head = id1;
            }
            if (this.loadouts[i].chest == id1)
            {
                this.loadouts[i].chest = id2;
            }
            else if (this.loadouts[i].chest == id2)
            {
                this.loadouts[i].chest = id1;
            }
            if (this.loadouts[i].legs == id1)
            {
                this.loadouts[i].legs = id2;
            }
            else if (this.loadouts[i].legs == id2)
            {
                this.loadouts[i].legs = id1;
            }
            if (this.loadouts[i].boots == id1)
            {
                this.loadouts[i].boots = id2;
            }
            else if (this.loadouts[i].boots == id2)
            {
                this.loadouts[i].boots = id1;
            }
            if (this.loadouts[i].weapon == id1)
            {
                this.loadouts[i].weapon = id2;
            }
            else if (this.loadouts[i].weapon == id2)
            {
                this.loadouts[i].weapon = id1;
            }
            if (this.loadouts[i].weapon2 == id1)
            {
                this.loadouts[i].weapon2 = id2;
            }
            else if (this.loadouts[i].weapon2 == id2)
            {
                this.loadouts[i].weapon2 = id1;
            }
            for (int j = 0; j < this.loadouts[i].accessories.Count; j++)
            {
                if (this.loadouts[i].accessories[j] == id1)
                {
                    this.loadouts[i].accessories[j] = id2;
                }
                else if (this.loadouts[i].accessories[j] == id2)
                {
                    this.loadouts[i].accessories[j] = id1;
                }
            }
        }
    }

    // Token: 0x06000C6D RID: 3181 RVA: 0x0009F191 File Offset: 0x0009D591
    public void updateInvSpaces(int spaces)
    {
        while (this.inventory.Count < spaces)
        {
            this.inventory.Add(new Equipment());
        }
    }

    // Token: 0x06000C6E RID: 3182 RVA: 0x0009F1B9 File Offset: 0x0009D5B9
    public void updateAccSpaces(int spaces)
    {
        while (this.accs.Count < spaces)
        {
            this.accs.Add(new Equipment());
        }
    }

    // Token: 0x06000C6F RID: 3183 RVA: 0x0009F1E1 File Offset: 0x0009D5E1
    public void updateMacGuffinSpaces(int spaces)
    {
        while (this.macguffins.Count < spaces)
        {
            this.macguffins.Add(new Equipment());
        }
    }

    // Token: 0x06000C70 RID: 3184 RVA: 0x0009F20C File Offset: 0x0009D60C
    public void updateMacguffinSpaces(int spaces)
    {
        while (this.macguffins.Count < spaces)
        {
            this.macguffins.Add(new Equipment());
        }
        while (this.macguffinBonuses.Count < 24)
        {
            this.macguffinBonuses.Add(1f);
        }
    }

    // Token: 0x06000C71 RID: 3185 RVA: 0x0009F268 File Offset: 0x0009D668
    public void updateLoadoutAccs(int size)
    {
        for (int i = 0; i < this.loadouts.Count; i++)
        {
            while (this.loadouts[i].accessories.Count < size)
            {
                this.loadouts[i].accessories.Add(-1000);
            }
        }
    }

    // Token: 0x06000C72 RID: 3186 RVA: 0x0009F2D0 File Offset: 0x0009D6D0
    public void updateDaycareSpaces(int spaces)
    {
        while (this.daycare.Count < spaces)
        {
            this.daycare.Add(new Equipment());
        }
        while (this.daycareTimers.Count < spaces)
        {
            this.daycareTimers.Add(new PlayerTime());
        }
    }

    // Token: 0x040009C5 RID: 2501
    public int spaces;

    // Token: 0x040009C6 RID: 2502
    public int item1;

    // Token: 0x040009C7 RID: 2503
    public int item2;

    // Token: 0x040009C8 RID: 2504
    public Equipment head;

    // Token: 0x040009C9 RID: 2505
    public Equipment chest;

    // Token: 0x040009CA RID: 2506
    public Equipment legs;

    // Token: 0x040009CB RID: 2507
    public Equipment boots;

    // Token: 0x040009CC RID: 2508
    public Equipment weapon;

    // Token: 0x040009CD RID: 2509
    public Equipment weapon2;

    // Token: 0x040009CE RID: 2510
    public Equipment acc1;

    // Token: 0x040009CF RID: 2511
    public Equipment acc2;

    // Token: 0x040009D0 RID: 2512
    public Equipment acc3;

    // Token: 0x040009D1 RID: 2513
    public Equipment temp;

    // Token: 0x040009D2 RID: 2514
    public Equipment trash;

    // Token: 0x040009D3 RID: 2515
    public Equipment[] items = new Equipment[1];

    // Token: 0x040009D4 RID: 2516
    public Equipment[] accessories = new Equipment[6];

    // Token: 0x040009D5 RID: 2517
    //public UnityEngine.Random.State boostCombineState;

    // Token: 0x040009D6 RID: 2518
    public List<Equipment> inventory = new List<Equipment>(10);

    // Token: 0x040009D7 RID: 2519
    public List<Equipment> accs = new List<Equipment>(10);

    // Token: 0x040009D8 RID: 2520
    public List<Equipment> macguffins = new List<Equipment>(1);

    // Token: 0x040009D9 RID: 2521
    public List<Equipment> daycare = new List<Equipment>();

    // Token: 0x040009DA RID: 2522
    public List<PlayerTime> daycareTimers = new List<PlayerTime>();

    // Token: 0x040009DB RID: 2523
    public ItemList itemList;

    // Token: 0x040009DC RID: 2524
    public int autoMergeSlot1;

    // Token: 0x040009DD RID: 2525
    public PlayerTime mergeTime = new PlayerTime();

    // Token: 0x040009DE RID: 2526
    public PlayerTime boostTime = new PlayerTime();

    // Token: 0x040009DF RID: 2527
    public List<Loadout> loadouts = new List<Loadout>();

    // Token: 0x040009E0 RID: 2528
    public float cubePower;

    // Token: 0x040009E1 RID: 2529
    public float cubeToughness;

    // Token: 0x040009E2 RID: 2530
    public int selectedGraphic;

    // Token: 0x040009E3 RID: 2531
    public bool disabled;

    // Token: 0x040009E4 RID: 2532
    public int kittyArt;

    // Token: 0x040009E5 RID: 2533
    public List<bool> unlockedKittyArt = new List<bool>();

    // Token: 0x040009E6 RID: 2534
    public List<float> macguffinBonuses = new List<float>(24);
}
