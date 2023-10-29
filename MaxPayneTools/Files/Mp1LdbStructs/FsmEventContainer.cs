using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmStateSwitchEventContainer : Readable {
    public List<FsmStateSwitchEvent>? StateSwitchEvents;

    public FsmStateSwitchEventContainer(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag

        var eventCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        for (var i = 0; i < eventCount; i++) {
            this.StateSwitchEvents?.Add(new FsmStateSwitchEvent(br));
        }
    }
}
