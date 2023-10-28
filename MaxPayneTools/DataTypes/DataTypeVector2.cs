using System.Numerics;

namespace MaxPayneTools.DataTypes;

public class DataTypeVector2 : DataType {
    public Vector2 Value;

    public DataTypeVector2(BinaryReader br) : base(br) {
        this.Value = new Vector2(br.ReadSingle(), br.ReadSingle());
    }
}
