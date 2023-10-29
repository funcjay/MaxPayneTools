using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmStateSwitchEvent : Readable {
    public string StateName;
    public FsmOnEvent OnBeforeEvent;
    public FsmStateSpecificEventContainer StateSpecificEvents;
    public FsmOnEvent OnAfterEvent;

    public FsmStateSwitchEvent(BinaryReader br) : base(br) {
        this.StateName = br.Read<DataTypeString>().Value;
        this.OnBeforeEvent = new FsmOnEvent(br);
        this.StateSpecificEvents = new FsmStateSpecificEventContainer(br);
        this.OnAfterEvent = new FsmOnEvent(br);
    }
}
