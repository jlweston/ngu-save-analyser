using System;
using System.Collections.Generic;

// Token: 0x020000CD RID: 205
[Serializable]
public class Loadout
{
	// Token: 0x06000D79 RID: 3449 RVA: 0x000CE250 File Offset: 0x000CC650
	public Loadout()
	{
		this.head = -1000;
		this.chest = -1000;
		this.legs = -1000;
		this.boots = -1000;
		this.weapon = -1000;
		this.weapon2 = -1000;
		while (this.accessories.Count < this.accessoriesSize())
		{
			this.accessories.Add(-1000);
		}
		this.temp = -1000;
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x000CE2E6 File Offset: 0x000CC6E6
	public int accessoriesSize()
	{
		return 8;
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x000CE2E9 File Offset: 0x000CC6E9
	public void validateLoadout()
	{
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x000CE2EB File Offset: 0x000CC6EB
	public int toArrayIndex(int id)
	{
		return id - 10000;
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x000CE2F4 File Offset: 0x000CC6F4
	public int toControllerIndex(int id)
	{
		return id + 10000;
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x000CE300 File Offset: 0x000CC700
	public void debugLoadout()
	{
		string text = string.Concat(new object[]
		{
			this.head,
			" head, ",
			this.legs,
			" legs, ",
			this.chest,
			" chest,",
			this.boots,
			" boots,",
			this.weapon,
			" weapon, "
		});
		for (int i = 0; i < this.accessories.Count; i++)
		{
			string text2 = text;
			text = string.Concat(new object[]
			{
				text2,
				this.accessories[i],
				" accesorry ",
				i,
				", "
			});
		}
	}

	// Token: 0x04000A3E RID: 2622
	public int head;

	// Token: 0x04000A3F RID: 2623
	public int chest;

	// Token: 0x04000A40 RID: 2624
	public int legs;

	// Token: 0x04000A41 RID: 2625
	public int boots;

	// Token: 0x04000A42 RID: 2626
	public int weapon;

	// Token: 0x04000A43 RID: 2627
	public int weapon2;

	// Token: 0x04000A44 RID: 2628
	public List<int> accessories = new List<int>();

	// Token: 0x04000A45 RID: 2629
	public int temp;

	// Token: 0x04000A46 RID: 2630
	public string loadoutName;
}
