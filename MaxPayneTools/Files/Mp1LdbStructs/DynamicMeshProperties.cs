using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class DynamicMeshProperties : Readable {
    public bool DynamicCollisions;
    public bool BulletCollisions;
    public bool LightMapped;
    public bool ContUpdate;
    public bool PointLightAffected;
    public bool BlockExplosions;

    public DynamicMeshProperties(BinaryReader br) : base(br) {
        this.DynamicCollisions = br.Read<DataTypeBool>().Value;
        this.BulletCollisions = br.Read<DataTypeBool>().Value;
        this.LightMapped = br.Read<DataTypeBool>().Value;
        this.ContUpdate = br.Read<DataTypeBool>().Value;
        this.PointLightAffected = br.Read<DataTypeBool>().Value;
        this.BlockExplosions = br.Read<DataTypeBool>().Value;
    }
}
