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
        this.Id = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.TexVertStartId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.VertCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.Normal = br.Read<DataTypeVector3>().Value;
        this.EngineMaterialType = br.ReadSpecificDataType<DataTypeUInt>().Value;
        this.MaterialId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.LightMapId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.MaxEdgeLength = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.MaxAngle = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.SmoothingGroup = br.ReadSpecificDataType<DataTypeInt>().Value;
    }
}
