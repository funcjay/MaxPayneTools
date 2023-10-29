using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class Animation : Readable {
    public string Name;
    public float LengthInSeconds;
    public float[] StartTransform;
    public float[] EndTransform;
    public AnimationFsm Fsm;
    public AnimationGraph TranslationGraph;
    public AnimationGraph RotationGraph;

    public Animation(BinaryReader br) : base(br) {
        this.Name = br.Read<DataTypeString>().Value;
        this.LengthInSeconds = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.StartTransform = br.Read<DataTypeMatrix4X3>().Value;
        this.EndTransform = br.Read<DataTypeMatrix4X3>().Value;
        this.Fsm = new AnimationFsm(br);
        this.TranslationGraph = new AnimationGraph(br);
        this.RotationGraph = new AnimationGraph(br);
    }
}
