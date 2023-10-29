using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class EntityProperties : Readable {
    public string SharedName;
    public string Name;
    public float[] ObjectToRoomTransform;
    public float[] ObjectToParentTransform;
    public int RoomId;
    public string ParentDynamicMeshName;

    public EntityProperties(BinaryReader br) : base(br) {
        this.SharedName = br.Read<DataTypeString>().Value;
        this.Name = br.Read<DataTypeString>().Value;
        this.ObjectToRoomTransform = br.Read<DataTypeMatrix4X3>().Value;
        this.ObjectToParentTransform = br.Read<DataTypeMatrix4X3>().Value;
        this.RoomId = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.ParentDynamicMeshName = br.Read<DataTypeString>().Value;
    }
}
