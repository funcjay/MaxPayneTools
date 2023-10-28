namespace MaxPayneTools.DataTypes;

public class DataTypeShort : DataType {
    public short Value;

    public DataTypeShort(BinaryReader br) : base(br) {
        this.Value = br.ReadInt16();
    }
}
