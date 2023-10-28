using System.Numerics;

namespace MaxPayneTools.DataTypes;

public class DataTypeVector4 : DataType {
    public Vector4 Value;

    public DataTypeVector4(BinaryReader br) : base(br) {
        this.Value = new Vector4(br.ReadSingle(), br.ReadSingle(), br.ReadSingle(), br.ReadSingle());
    }
}
