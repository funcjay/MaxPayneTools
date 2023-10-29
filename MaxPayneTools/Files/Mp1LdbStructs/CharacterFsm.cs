using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class CharacterFsm : Readable {
    public FsmOnEvent OnStartupSendBeforeEvent;
    public FsmOnEvent OnDeathSendBeforeEvent;
    public FsmOnEvent OnActivateSendBeforeEvent;
    public FsmOnEvent OnSpecialSendBeforeEvent;

    public CharacterFsm(BinaryReader br) : base(br) {
        this.OnStartupSendBeforeEvent = new FsmOnEvent(br);
        this.OnDeathSendBeforeEvent = new FsmOnEvent(br);
        this.OnActivateSendBeforeEvent = new FsmOnEvent(br);
        this.OnSpecialSendBeforeEvent = new FsmOnEvent(br);
    }
}
