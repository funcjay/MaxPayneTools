using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmStateSpecificEventContainer : Readable {
    public List<FsmStateSpecificEvent>? StateSpecificEvents;

    public FsmStateSpecificEventContainer(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag

        var eventCount = br.Read<DataTypeInt>().Value;
        for (var i = 0; i < eventCount; i++) {
            this.StateSpecificEvents?.Add(new FsmStateSpecificEvent(br));
        }
    }
}
