namespace MaxPayneTools.DataTypes; 

public class DataTypeLong : DataType {
    public int Value;

    public DataTypeLong(BinaryReader br) : base(br) {
        this.Value = br.ReadInt32();
    }
}
