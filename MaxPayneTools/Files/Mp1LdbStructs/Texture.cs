using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class Texture : Readable {
    public string SourceFileName;
    public uint FileType; // 0x00 - TGA, 0x02 - SCX, 0x03 - PCX, 0x04 - JPG, 0x05 - DDS
    public int FileSize;
    public byte[] FileData;

    public Texture(BinaryReader br) : base(br) {
        this.SourceFileName = br.Read<DataTypeString>().Value;
        this.FileType = br.Read<DataTypeUInt>().Value;
        this.FileSize = br.Read<DataTypeInt>().Value;
        this.FileData = br.ReadBytes(this.FileSize);
    }
}
