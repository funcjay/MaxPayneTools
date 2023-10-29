using System.Numerics;
using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class BspNode : Readable {
    public Vector3 TransformOrOrientation;
    public Vector3 Position;
    public BspNodeHalfSpace HalfSpace1;
    public BspNodeHalfSpace HalfSpace2;

    public BspNode(BinaryReader br) : base(br) {
        this.TransformOrOrientation = br.Read<DataTypeVector3>().Value;
        this.Position = br.Read<DataTypeVector3>().Value;
        this.HalfSpace1 = new BspNodeHalfSpace(br);
        this.HalfSpace2 = new BspNodeHalfSpace(br);
    }
}
