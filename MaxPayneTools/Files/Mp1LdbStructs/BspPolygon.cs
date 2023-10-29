using System.Numerics;
using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class BspPolygon : Readable {
    public int StartBspVertId;
    public int NumVertsInPoly;
    public int PolyIdInGroup;
    public int GroupId;
    public Vector3 Normal;
    public Vector3 Pivot;

    public BspPolygon(BinaryReader br) : base(br) {
        this.StartBspVertId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.NumVertsInPoly = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.PolyIdInGroup = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.GroupId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.Normal = br.Read<DataTypeVector3>().Value;
        this.Pivot = br.Read<DataTypeVector3>().Value;
    }
}
