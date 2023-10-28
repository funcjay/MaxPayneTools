namespace MaxPayneTools.DataTypes;

public class DataTypeMatrix3X3 : DataType {
    public float[] Value;

    public DataTypeMatrix3X3(BinaryReader br) : base(br) {
        var arr = new float[9];
        for (var i = 0; i < arr.Length; i++) {
            arr[i] = br.ReadSingle();
        }

        this.Value = arr;
    }
}
