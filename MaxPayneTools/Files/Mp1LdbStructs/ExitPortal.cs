using System.Numerics;
using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class ExitPortal : Readable {
    public string Name;
    public List<Vector3>? Vertices;
    public Vector3 Normal;
    public float[] Transform;
    public int ParentRoomId;
    public int DestinationRoomId;
    public string DestinationExitName;
    public List<ConvexRegion>? ConvexRegions;

    public ExitPortal(BinaryReader br) : base(br) {
        this.Name = br.Read<DataTypeString>().Value;

        var vertCount = br.ReadSpecificDataType<DataTypeUInt>().Value;
        for (var i = 0; i < vertCount; i++) {
            this.Vertices?.Add(br.Read<DataTypeVector3>().Value);
        }

        this.Normal = br.Read<DataTypeVector3>().Value;
        this.Transform = br.Read<DataTypeMatrix4X3>().Value;
        this.ParentRoomId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.DestinationRoomId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.DestinationExitName = br.Read<DataTypeString>().Value;

        br.ReadByte(); // Type tag
        var convRegCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        for (var j = 0; j < convRegCount; j++) {
            this.ConvexRegions?.Add(new ConvexRegion(br));
        }
    }
}
