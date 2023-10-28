namespace MaxPayneTools.DataTypes;

public class DataTypeULong : DataType {
    public uint Value;

    public DataTypeULong(BinaryReader br) : base(br) {
        this.Value = br.ReadUInt32();
    }
}
