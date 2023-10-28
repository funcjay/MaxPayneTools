namespace MaxPayneTools.DataTypes;

public class DataTypeChar : DataType {
    public char Value;

    public DataTypeChar(BinaryReader br) : base(br) {
        this.Value = br.ReadChar();
    }
}
