namespace MaxPayneTools.DataTypes;

public class DataTypeDouble : DataType {
    public double Value;

    public DataTypeDouble(BinaryReader br) : base(br) {
        this.Value = br.ReadDouble();
    }
}
