using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmStartupEventContainer : Readable {
    public FsmOnEvent OnBeforeEvent;
    public FsmStateSpecificEventContainer StateSpecificEvents;
    public FsmOnEvent OnAfterEvent;

    public FsmStartupEventContainer(BinaryReader br) : base(br) {
        this.OnBeforeEvent = new FsmOnEvent(br);
        this.StateSpecificEvents = new FsmStateSpecificEventContainer(br);
        this.OnAfterEvent = new FsmOnEvent(br);
    }
}
