using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class Material : Readable {
    public string Name;
    public string DiffuseSourceFileName;
    public string AlphaSourceFileName;
    public bool AlphaTest;
    public bool AdultContent;

    public Material(BinaryReader br) : base(br) {
        this.Name = br.Read<DataTypeString>().Value;
        this.DiffuseSourceFileName = br.Read<DataTypeString>().Value;
        this.AlphaSourceFileName = br.Read<DataTypeString>().Value;
        this.AlphaTest = br.Read<DataTypeBool>().Value;
        this.AdultContent = br.Read<DataTypeBool>().Value;
    }
}
