using System.Numerics;
using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class BspContainer : Readable {
    public List<Vector3>? Vertices;
    public List<BspPolygon>? Polygons;
    public List<BspNode>? Nodes;
    public int[] PolygonIndices;

    public BspContainer(BinaryReader br) : base(br) {
        // Vertices
        br.ReadByte(); // Type tag
        var vertCount = br.Read<DataTypeInt>().Value;
        for (var i = 0; i < vertCount; i++) {
            this.Vertices?.Add(br.Read<DataTypeVector3>().Value);
        }

        // Polygons
        br.ReadByte(); // Type tag
        var polyCount = br.Read<DataTypeInt>().Value;
        for (var j = 0; j < polyCount; j++) {
            this.Polygons?.Add(new BspPolygon(br));
        }

        // Nodes
        br.ReadByte(); // Type tag
        var nodeCount = br.Read<DataTypeInt>().Value;
        for (var k = 0; k < nodeCount; k++) {
            this.Nodes?.Add(new BspNode(br));
        }

        // Polygon indices
        br.ReadByte(); // Type tag
        var polyIdCount = br.Read<DataTypeInt>().Value;
        this.PolygonIndices = new int[polyIdCount];
        for (var l = 0; l < polyIdCount; l++) {
            this.PolygonIndices[l] = br.Read<DataTypeInt>().Value;
        }
    }
}
