using System.Numerics;
using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class TextureVertex : Readable {
    public int VertId;
    public Vector2 Uv;
    public Vector2 LightMapUv;
    public uint Flags;
    public bool Smooth;

    public TextureVertex(BinaryReader br) : base(br) {
        this.VertId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.Uv = br.Read<DataTypeVector2>().Value;
        this.LightMapUv = br.Read<DataTypeVector2>().Value;
        this.Flags = br.ReadSpecificDataType<DataTypeUInt>().Value;
        this.Smooth = br.Read<DataTypeBool>().Value;
    }
}
