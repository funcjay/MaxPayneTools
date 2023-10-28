namespace MaxPayneTools.DataTypes;

public class DataTypeBool : DataType {
    public bool Value;

    public DataTypeBool(BinaryReader br) : base(br) {
        this.Value = br.ReadBoolean();
    }
}
