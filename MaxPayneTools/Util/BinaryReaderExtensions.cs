using MaxPayneTools.DataTypes;

namespace MaxPayneTools.Util;

public static class BinaryReaderExtensions {
    public static T Read<T>(this BinaryReader br) where T : Readable {
        return (T)Activator.CreateInstance(typeof(T), br)!;
    }

    public static DataType ReadDataType(this BinaryReader br) {
        Console.WriteLine($"DEBUG: pos = {br.BaseStream.Position:X}");
        var type = (DataTypeTags)br.ReadByte();
        Console.WriteLine($"DEBUG: got type {type}");
        
        return type switch {
            DataTypeTags.Long => new DataTypeLong(br),
            DataTypeTags.ULong => new DataTypeULong(br),
            DataTypeTags.Short => new DataTypeShort(br),
            DataTypeTags.UShort => new DataTypeLong(br),
            DataTypeTags.Char => new DataTypeChar(br),
            DataTypeTags.SChar => new DataTypeChar(br),
            DataTypeTags.UChar => new DataTypeChar(br),
            DataTypeTags.Float4 => new DataTypeFloat(br, 4),
            DataTypeTags.Double => new DataTypeDouble(br),
            DataTypeTags.Bool => new DataTypeBool(br),
            DataTypeTags.Int4 => new DataTypeInt(br, 4),
            DataTypeTags.Int3 => new DataTypeInt(br, 3),
            DataTypeTags.Int2 => new DataTypeInt(br, 2),
            DataTypeTags.Int1 => new DataTypeInt(br, 1),
            DataTypeTags.UInt4 => new DataTypeUInt(br, 4),
            DataTypeTags.UInt3 => new DataTypeUInt(br, 3),
            DataTypeTags.UInt2 => new DataTypeUInt(br, 2),
            DataTypeTags.UInt1 => new DataTypeUInt(br, 1),
            DataTypeTags.Vector2 => new DataTypeVector2(br),
            DataTypeTags.Vector3 => new DataTypeVector3(br),
            DataTypeTags.Vector4 => new DataTypeVector4(br),
            DataTypeTags.Float2 => new DataTypeFloat(br, 2),
            DataTypeTags.String => new DataTypeString(br),
            DataTypeTags.Matrix2X2 => new DataTypeMatrix2X2(br),
            DataTypeTags.Matrix3X3 => new DataTypeMatrix3X3(br),
            DataTypeTags.Matrix4X3 => new DataTypeMatrix4X3(br),
            DataTypeTags.Matrix4X4 => new DataTypeMatrix4X4(br),
            _ => throw new ArgumentOutOfRangeException(nameof(type), $"Received unknown data type \"{type.ToString()}\"")
        };
    }
    
    public static T ReadSpecificDataType<T>(this BinaryReader br) where T : DataType {
        var val = br.ReadDataType();
        if (val is not T casted) throw new InvalidDataException();
        return casted;
    }
}
