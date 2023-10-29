using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class SortedMaterialCategory : Readable {
    public string Name;
    public string MaterialName;
    public int MaterialId;

    public SortedMaterialCategory(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag
        this.Name = br.Read<DataTypeString>().Value;
        this.MaterialName = br.Read<DataTypeString>().Value;
        this.MaterialId = br.Read<DataTypeInt>().Value;
    }
}
