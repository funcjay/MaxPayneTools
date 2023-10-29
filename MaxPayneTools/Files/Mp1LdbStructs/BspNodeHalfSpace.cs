using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class BspNodeHalfSpace : Readable {
    public int StartIdInBspPolygonId;
    public int PolyCountInSpace;
    public int NextBspNode;

    public BspNodeHalfSpace(BinaryReader br) : base(br) {
        this.StartIdInBspPolygonId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.PolyCountInSpace = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.NextBspNode = br.ReadSpecificDataType<DataTypeInt>().Value;
    }
}
