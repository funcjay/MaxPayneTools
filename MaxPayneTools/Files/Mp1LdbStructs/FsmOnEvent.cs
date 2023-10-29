using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmOnEvent : Readable {
    public string[] Messages;

    public FsmOnEvent(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag

        var msgCount = br.Read<DataTypeInt>().Value;
        this.Messages = new string[msgCount];
        for (var i = 0; i < msgCount; i++) {
            this.Messages[i] = br.Read<DataTypeString>().Value;
        }
    }
}
