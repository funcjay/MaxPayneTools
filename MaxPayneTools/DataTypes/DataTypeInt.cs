namespace MaxPayneTools.DataTypes;

public class DataTypeInt : DataType {
    public int Value;

    public DataTypeInt(BinaryReader br, int size) : base(br) {
        switch (size) {
            default:
                this.Value = br.ReadInt32();
                break;
            case 3: {
                var bytes = br.ReadBytes(3);
                var finBytes = new byte[4];
                var startAt = finBytes.Length - bytes.Length;
                Array.Copy(bytes, 0, finBytes, startAt, bytes.Length);

                this.Value = Convert.ToInt32(finBytes);
                break;
            }
            case 2:
                this.Value = br.ReadInt16();
                break;
            case 1: {
                var bytes = br.ReadBytes(1);
                var finBytes = new byte[4];
                var startAt = finBytes.Length - bytes.Length;
                Array.Copy(bytes, 0, finBytes, startAt, bytes.Length);

                this.Value = Convert.ToInt32(finBytes);
                break;
            }
        }
    }
}
