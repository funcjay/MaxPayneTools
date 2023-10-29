using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class AnimationGraph : Readable {
    public int Header; // 113
    public int MajorVer; // 3
    public int MinorVer; // 1
    public int SampleRate;
    public float[] CurveControlPoint;

    public AnimationGraph(BinaryReader br) : base(br) {
        this.Header = br.Read<DataTypeInt>().Value;
        this.MajorVer = br.Read<DataTypeInt>().Value;
        this.MinorVer = br.Read<DataTypeInt>().Value;
        this.SampleRate = br.Read<DataTypeInt>().Value;

        this.CurveControlPoint = new float[this.SampleRate];
        for (var i = 0; i < this.SampleRate; i++) {
            this.CurveControlPoint[i] = br.Read<DataTypeFloat>().Value;
        }
    }
}
