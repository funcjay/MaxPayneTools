using System.Numerics;
using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class InitialRadiosity : Readable {
    public int Key;
    public Vector3 Value;

    public InitialRadiosity(BinaryReader br) : base(br) {
        this.Key = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.Value = br.Read<DataTypeVector3>().Value;
    }
}
