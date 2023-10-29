using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmStateContainer : Readable {
    public string[] StateNames;
    public string DefaultState;

    public FsmStateContainer(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag

        var stateCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        this.StateNames = new string[stateCount];
        for (var i = 0; i < stateCount; i++) {
            this.StateNames[i] = br.Read<DataTypeString>().Value;
        }

        this.DefaultState = br.Read<DataTypeString>().Value;
    }
}
