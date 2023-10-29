using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class Item : Readable {
    public EntityProperties EntProperties;
    public string Name;

    public Item(BinaryReader br) : base(br) {
        this.EntProperties = new EntityProperties(br);
        this.Name = br.Read<DataTypeString>().Value;
    }
}
