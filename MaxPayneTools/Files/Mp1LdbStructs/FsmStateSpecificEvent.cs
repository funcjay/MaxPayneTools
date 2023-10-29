using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmStateSpecificEvent : Readable {
    public string StateName;
    public string[] Messages;

    public FsmStateSpecificEvent(BinaryReader br) : base(br) {
        this.StateName = br.Read<DataTypeString>().Value;

        br.ReadByte(); // Type tag

        var msgCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.Messages = new string[msgCount];
        for (var i = 0; i < msgCount; i++) {
            this.Messages[i] = br.Read<DataTypeString>().Value;
        }
    }
}
