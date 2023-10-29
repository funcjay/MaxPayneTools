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
        this.Id = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.EntProperties = new EntityProperties(br);
        this.R = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.G = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.B = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.A = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.Falloff = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.Intensity = br.ReadSpecificDataType<DataTypeFloat>().Value;
    }
}
