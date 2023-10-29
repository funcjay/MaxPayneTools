using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class StaticMeshContainer : Readable {
    public List<TextureVertex>? TextureVertices;
    public List<StaticMesh>? Meshes;

    public StaticMeshContainer(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag
        var texVertCount = br.Read<DataTypeInt>().Value;
        for (var i = 0; i < texVertCount; i++) {
            this.TextureVertices?.Add(new TextureVertex(br));
        }

        var staticMeshCount = br.Read<DataTypeInt>().Value;
        for (var j = 0; j < staticMeshCount; j++) {
            this.Meshes?.Add(new StaticMesh(br));
        }
    }
}
