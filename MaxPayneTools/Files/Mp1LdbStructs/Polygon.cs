using System.Numerics;
using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class Polygon : Readable {
    public int Id;
    public int TexVertStartId;
    public int VertCount;
    public Vector3 Normal;
    public uint EngineMaterialType;
    public int MaterialId;
    public int LightMapId;
    public float MaxEdgeLength;
    public float MaxAngle;
    public int SmoothingGroup;

    public Polygon(BinaryReader br) : base(br) {
        this.Id = br.Read<DataTypeInt>().Value;
        this.TexVertStartId = br.Read<DataTypeInt>().Value;
        this.VertCount = br.Read<DataTypeInt>().Value;
        this.Normal = br.Read<DataTypeVector3>().Value;
        this.EngineMaterialType = br.Read<DataTypeUInt>().Value;
        this.MaterialId = br.Read<DataTypeInt>().Value;
        this.LightMapId = br.Read<DataTypeInt>().Value;
        this.MaxEdgeLength = br.Read<DataTypeFloat>().Value;
        this.MaxAngle = br.Read<DataTypeFloat>().Value;
        this.SmoothingGroup = br.Read<DataTypeInt>().Value;
    }
}
