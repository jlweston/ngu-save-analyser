using System;

// Token: 0x02000118 RID: 280
[Serializable]
public class SaveData
{
    // Token: 0x060010F1 RID: 4337 RVA: 0x000F6FF0 File Offset: 0x000F53F0
    public SaveData(string data, string checksumString)
    {
        this.playerData = data;
        this.checksum = checksumString;
    }

    // Token: 0x04000CDD RID: 3293
    public string playerData;

    // Token: 0x04000CDE RID: 3294
    public string checksum;
}
