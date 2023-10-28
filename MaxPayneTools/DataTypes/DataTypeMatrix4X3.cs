namespace MaxPayneTools.DataTypes;

public class DataTypeMatrix4X3 : DataType {
    public float[] Value;

    public DataTypeMatrix4X3(BinaryReader br) : base(br) {
        var arr = new float[12];
        for (var i = 0; i < arr.Length; i++) {
            arr[i] = br.ReadSingle();
        }

        this.Value = arr;
    }
}
