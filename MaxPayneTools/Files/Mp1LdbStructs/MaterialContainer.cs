using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class MaterialContainer : Readable {
    public List<Texture>? Textures;
    public List<MaterialCategory>? Categories;
    public List<SortedMaterialCategory>? SortedCategories;
    public List<MaterialProperty>? Properties;
    public List<LightMap>? LightMaps;

    public MaterialContainer(BinaryReader br) : base(br) {
        // Textures
        var texCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        for (var i = 0; i < texCount; i++) {
            this.Textures?.Add(new Texture(br));
        }

        // Material categories
        br.ReadByte(); // Type tag
        var catCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        for (var j = 0; j < catCount; j++) {
            this.Categories?.Add(new MaterialCategory(br));
        }

        // Sorted material categories
        br.ReadByte(); // Type tag
        var sortCatCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        for (var k = 0; k < sortCatCount; k++) {
            this.SortedCategories?.Add(new SortedMaterialCategory(br));
        }

        // Material properties
        var matPropCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        for (var l = 0; l < matPropCount; l++) {
            this.Properties?.Add(new MaterialProperty(br));
        }

        // Light maps
        var lightMapCount = br.ReadSpecificDataType<DataTypeInt>().Value;
        for (var m = 0; m < lightMapCount; m++) {
            this.LightMaps?.Add(new LightMap(br));
        }
    }
}
