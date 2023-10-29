using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class BspNodeHalfSpace : Readable {
    public int StartIdInBspPolygonId;
    public int PolyCountInSpace;
    public int NextBspNode;

    public BspNodeHalfSpace(BinaryReader br) : base(br) {
        this.StartIdInBspPolygonId = br.Read<DataTypeInt>().Value;
        this.PolyCountInSpace = br.Read<DataTypeInt>().Value;
        this.NextBspNode = br.Read<DataTypeInt>().Value;
    }
}
