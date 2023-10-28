using MaxPayneTools.Util;

namespace MaxPayneTools.DataTypes;

public class DataTypeString : DataType {
    public string Value;

    public DataTypeString(BinaryReader br) : base(br) {
        var strSize = (DataTypeInt)br.ReadDataType();
        var strChars = new char[strSize.Value];
        this.Value = strChars.ToString()!;
    }
}
