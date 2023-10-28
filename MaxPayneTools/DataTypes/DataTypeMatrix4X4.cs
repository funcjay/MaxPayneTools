namespace MaxPayneTools.DataTypes;

public class DataTypeMatrix4X4 : DataType {
    public float[] Value;

    public DataTypeMatrix4X4(BinaryReader br) : base(br) {
        var arr = new float[16];
        for (var i = 0; i < arr.Length; i++) {
            arr[i] = br.ReadSingle();
        }

        this.Value = arr;
    }
}
