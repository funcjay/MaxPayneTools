using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class MaterialCategory : Readable {
    public int MaterialId;
    public string Name;
    public string MaterialName;

    public MaterialCategory(BinaryReader br) : base(br) {
        this.MaterialId = br.Read<DataTypeInt>().Value;
        br.ReadByte(); // Type tag
        this.Name = br.Read<DataTypeString>().Value;
        this.MaterialName = br.Read<DataTypeString>().Value;
    }
}
