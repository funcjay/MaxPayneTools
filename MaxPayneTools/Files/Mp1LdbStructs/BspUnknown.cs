using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class BspUnknown : Readable {
    public int Unk1, Unk2, Unk3, Unk4;

    public BspUnknown(BinaryReader br) : base(br) {
        this.Unk1 = br.Read<DataTypeInt>().Value;
        this.Unk2 = br.Read<DataTypeInt>().Value;
        this.Unk3 = br.Read<DataTypeInt>().Value;
        this.Unk4 = br.Read<DataTypeInt>().Value;
    }
}
