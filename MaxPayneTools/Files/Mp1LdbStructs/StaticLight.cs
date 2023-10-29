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
        this.R = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.G = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.B = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.A = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.Area = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.Intensity = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.HotspotAngle = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.FalloffAngle = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.FalloffRange = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.ColorMultiplier = br.ReadSpecificDataType<DataTypeFloat>().Value;
    }
}
