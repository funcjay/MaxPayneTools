using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class Waypoint : Readable {
    public EntityProperties EntProperties;
    public int Type; // 0 - way_point, 1 - start_point

    public Waypoint(BinaryReader br) : base(br) {
        this.EntProperties = new EntityProperties(br);
        this.Type = br.Read<DataTypeInt>().Value;
    }
}
