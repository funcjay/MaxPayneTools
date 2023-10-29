using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class PointLight : Readable {
    public int Id;
    public EntityProperties EntProperties;
    public float R, G, B, A;
    public float Falloff;
    public float Intensity;

    public PointLight(BinaryReader br) : base(br) {
        this.Id = br.Read<DataTypeInt>().Value;
        this.EntProperties = new EntityProperties(br);
        this.R = br.Read<DataTypeFloat>().Value;
        this.G = br.Read<DataTypeFloat>().Value;
        this.B = br.Read<DataTypeFloat>().Value;
        this.A = br.Read<DataTypeFloat>().Value;
        this.Falloff = br.Read<DataTypeFloat>().Value;
        this.Intensity = br.Read<DataTypeFloat>().Value;
    }
}
