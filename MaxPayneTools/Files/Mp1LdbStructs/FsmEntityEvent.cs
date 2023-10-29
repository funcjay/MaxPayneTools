using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmEntityEvent : Readable {
    public string Name;
    public FsmOnEvent OnBeforeEvent;
    public FsmStateSpecificEventContainer StateSpecificEvents;
    public FsmOnEvent OnAfterEvent;

    public FsmEntityEvent(BinaryReader br) : base(br) {
        this.Name = br.Read<DataTypeString>().Value;
        this.OnBeforeEvent = new FsmOnEvent(br);
        this.StateSpecificEvents = new FsmStateSpecificEventContainer(br);
        this.OnAfterEvent = new FsmOnEvent(br);
    }
}
