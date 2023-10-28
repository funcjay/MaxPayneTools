namespace MaxPayneTools.DataTypes;

public class DataTypeUInt : DataType {
    public uint Value;

    public DataTypeUInt(BinaryReader br, int size) : base(br) {
        switch (size) {
            default:
                this.Value = br.ReadUInt32();
                break;
            case 3: {
                var bytes = br.ReadBytes(3);
                var finBytes = new byte[4];
                var startAt = finBytes.Length - bytes.Length;
                Array.Copy(bytes, 0, finBytes, startAt, bytes.Length);

                this.Value = Convert.ToUInt32(finBytes);
                break;
            }
            case 2:
                this.Value = br.ReadUInt16();
                break;
            case 1: {
                var bytes = br.ReadBytes(1);
                var finBytes = new byte[4];
                var startAt = finBytes.Length - bytes.Length;
                Array.Copy(bytes, 0, finBytes, startAt, bytes.Length);

                this.Value = Convert.ToUInt32(finBytes);
                break;
            }
        }
    }
}
