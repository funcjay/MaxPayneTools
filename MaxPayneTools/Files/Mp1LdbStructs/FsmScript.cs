using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class FsmScript : Readable {
    public EntityProperties EntProperties;
    public FsmStateContainer States;
    public FsmStartupEventContainer StartupEvents;
    public FsmStateSwitchEventContainer StateSwitchEvents;
    public FsmCustomStringEventContainer CustomStringEvents;
    public FsmEntityEventContainer EntityEvents;

    public FsmScript(BinaryReader br) : base(br) {
        this.EntProperties = new EntityProperties(br);
        this.States = new FsmStateContainer(br);
        this.StartupEvents = new FsmStartupEventContainer(br);
        this.StateSwitchEvents = new FsmStateSwitchEventContainer(br);
        this.CustomStringEvents = new FsmCustomStringEventContainer(br);
        this.EntityEvents = new FsmEntityEventContainer(br);
    }
}
