namespace MaxPayneTools.DataTypes;

public class DataTypeFloat : DataType {
    public float Value;

    public DataTypeFloat(BinaryReader br, int size) : base(br) {
        if (size == 8) this.Value = br.ReadSingle();
        else this.Value = (float)br.ReadHalf();
    }
}
