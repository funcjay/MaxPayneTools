using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class MaterialProperty : Readable {
    public string CategoryName;
    public List<Material>? Materials;

    public MaterialProperty(BinaryReader br) : base(br) {
        this.CategoryName = br.Read<DataTypeString>().Value;

        var matCount = br.Read<DataTypeInt>().Value;
        for (var i = 0; i < matCount; i++) {
            this.Materials?.Add(new Material(br));
        }
    }
}
