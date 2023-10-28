using System.Numerics;

namespace MaxPayneTools.DataTypes;

public class DataTypeVector3 : DataType {
    public Vector3 Value;

    public DataTypeVector3(BinaryReader br) : base(br) {
        this.Value = new Vector3(br.ReadSingle(), br.ReadSingle(), br.ReadSingle());
    }
}
