using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class StaticLight : Readable {
    public EntityProperties EntProperties;
    public float[] RotationInsideRoom;
    public float R, G, B, A;
    public float Area;
    public float Intensity;
    public float HotspotAngle;
    public float FalloffAngle;
    public float FalloffRange;
    public float ColorMultiplier;

    public StaticLight(BinaryReader br) : base(br) {
        this.EntProperties = new EntityProperties(br);
        this.RotationInsideRoom = br.Read<DataTypeMatrix3X3>().Value;
        this.R = br.Read<DataTypeFloat>().Value;
        this.G = br.Read<DataTypeFloat>().Value;
        this.B = br.Read<DataTypeFloat>().Value;
        this.A = br.Read<DataTypeFloat>().Value;
        this.Area = br.Read<DataTypeFloat>().Value;
        this.Intensity = br.Read<DataTypeFloat>().Value;
        this.HotspotAngle = br.Read<DataTypeFloat>().Value;
        this.FalloffAngle = br.Read<DataTypeFloat>().Value;
        this.FalloffRange = br.Read<DataTypeFloat>().Value;
        this.ColorMultiplier = br.Read<DataTypeFloat>().Value;
    }
}
