using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class LightMap : Readable {
    public int Id;
    public uint FileType; // 0x00 - TGA, 0x02 - SCX, 0x03 - PCX, 0x04 - JPG, 0x05 - DDS
    public int FileSize;
    public byte[] FileData;

    public LightMap(BinaryReader br) : base(br) {
        this.Id = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.FileType = br.ReadSpecificDataType<DataTypeUInt>().Value;
        this.FileSize = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.FileData = br.ReadBytes(this.FileSize);
    }
}
