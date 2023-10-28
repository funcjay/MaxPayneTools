namespace MaxPayneTools.DataTypes;

public class DataTypeUShort : DataType {
    public ushort Value;

    public DataTypeUShort(BinaryReader br) : base(br) {
        this.Value = br.ReadUInt16();
    }
}
