namespace MaxPayneTools.DataTypes;

public class DataTypeMatrix2X2 : DataType {
    public float[] Value;

    public DataTypeMatrix2X2(BinaryReader br) : base(br) {
        var arr = new float[4];
        for (var i = 0; i < arr.Length; i++) {
            arr[i] = br.ReadSingle();
        }

        this.Value = arr;
    }
}
