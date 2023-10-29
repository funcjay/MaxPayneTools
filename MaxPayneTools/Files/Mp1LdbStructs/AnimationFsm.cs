using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class AnimationFsm : Readable {
    public FsmOnEvent OnLeavingFirstKeyFrameEvent;
    public FsmOnEvent OnReturningFirstKeyFrameEvent;
    public FsmOnEvent OnReachingSecondKeyFrameEvent;

    public AnimationFsm(BinaryReader br) : base(br) {
        this.OnLeavingFirstKeyFrameEvent = new FsmOnEvent(br);
        this.OnReturningFirstKeyFrameEvent = new FsmOnEvent(br);
        this.OnReachingSecondKeyFrameEvent = new FsmOnEvent(br);
    }
}
