using System;

// Token: 0x0200011D RID: 285
[Serializable]
public class SaveData
{
	// Token: 0x0600111E RID: 4382 RVA: 0x000F95A4 File Offset: 0x000F79A4
	public SaveData(string data, string checksumString)
	{
		this.playerData = data;
		this.checksum = checksumString;
	}

	// Token: 0x04000CFF RID: 3327
	public string playerData;

	// Token: 0x04000D00 RID: 3328
	public string checksum;
}
