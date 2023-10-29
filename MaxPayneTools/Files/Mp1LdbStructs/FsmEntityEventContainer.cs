using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmEntityEventContainer : Readable {
    public List<FsmEntityEvent>? EntityEvents;

    public FsmEntityEventContainer(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag

        var eventCount = br.Read<DataTypeInt>().Value;
        for (var i = 0; i < eventCount; i++) {
            this.EntityEvents?.Add(new FsmEntityEvent(br));
        }
    }
}
