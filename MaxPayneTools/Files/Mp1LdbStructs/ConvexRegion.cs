using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class ConvexRegion : Readable {
    public int[] Points;

    public ConvexRegion(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag
        var pointCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.Points = new int[pointCount];
        for (var i = 0; i < pointCount; i++) {
            this.Points[i] = br.ReadSpecificDataType<DataTypeInt>().Value;
        }
    }
}
