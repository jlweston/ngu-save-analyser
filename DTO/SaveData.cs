using System;

// Token: 0x02000128 RID: 296
[Serializable]
public class SaveData
{
    // Token: 0x060011ED RID: 4589 RVA: 0x001003C8 File Offset: 0x000FE7C8
    public SaveData(string data, string checksumString)
    {
        this.playerData = data;
        this.checksum = checksumString;
    }

    // Token: 0x04000D50 RID: 3408
    public string playerData;

    // Token: 0x04000D51 RID: 3409
    public string checksum;
}
