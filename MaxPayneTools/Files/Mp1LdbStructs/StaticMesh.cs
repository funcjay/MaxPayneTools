using System.Numerics;
using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class StaticMesh : Readable {
    public int GroupId;
    public List<Vector3>? Vertices;
    public List<Vector3>? Normals;
    public float[] Transform;
    public List<Polygon>? Polygons;
    public List<InitialRadiosity>? InitialRadiosities;

    public StaticMesh(BinaryReader br) : base(br) {
        this.GroupId = br.Read<DataTypeInt>().Value;

        var vertCount = br.Read<DataTypeUInt>().Value;
        for (var i = 0; i < vertCount; i++) {
            this.Vertices?.Add(br.Read<DataTypeVector3>().Value);
        }

        br.ReadByte(); // Type tag
        var normalCount = br.Read<DataTypeInt>().Value;
        for (var j = 0; j < normalCount; j++) {
            this.Normals?.Add(br.Read<DataTypeVector3>().Value);
        }

        this.Transform = br.Read<DataTypeMatrix4X3>().Value;

        var polyCount = br.Read<DataTypeInt>().Value;
        for (var k = 0; k < polyCount; k++) {
            this.Polygons?.Add(new Polygon(br));
        }

        br.ReadByte(); // Type tag
        var radCount = br.Read<DataTypeInt>().Value;
        for (var l = 0; l < radCount; l++) {
            this.InitialRadiosities?.Add(new InitialRadiosity(br));
        }
    }
}
