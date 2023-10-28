using MaxPayneTools.Util;

namespace MaxPayneTools.DataTypes;

public abstract class DataType : Readable {
    protected DataType(BinaryReader br) : base(br) { }
}
