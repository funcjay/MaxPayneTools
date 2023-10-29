using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmCustomStringEventContainer : Readable {
    public List<FsmCustomStringEvent>? CustomStringEvents;

    public FsmCustomStringEventContainer(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag

        var eventCount = br.Read<DataTypeInt>().Value;
        for (var i = 0; i < eventCount; i++) {
            this.CustomStringEvents?.Add(new FsmCustomStringEvent(br));
        }
    }
}
