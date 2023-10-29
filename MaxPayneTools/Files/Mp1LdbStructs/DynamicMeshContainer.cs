using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class DynamicMeshContainer : Readable {
    public List<TextureVertex>? TextureVertices;
    public List<DynamicMesh>? Meshes;

    public DynamicMeshContainer(BinaryReader br) : base(br) {
        br.ReadByte(); // Type tag

        var texVertCount = br.Read<DataTypeInt>().Value;
        for (var i = 0; i < texVertCount; i++) {
            this.TextureVertices?.Add(new TextureVertex(br));
        }

        var meshCount = br.Read<DataTypeInt>().Value;
        for (var j = 0; j < meshCount; j++) {
            this.Meshes?.Add(new DynamicMesh(br));
        }
    }
}
