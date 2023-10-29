using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class Room : Readable {
    public int Id;
    public int[]? StaticMeshIds;
    public string[]? StaticLightNames;
    public string[]? ExitNames;
    public string[]? StartPointNames;
    public string[]? FsmNames;
    public string[]? CharacterNames;
    public string[]? TriggerNames;
    public string[]? DynamicMeshNames;
    public string[]? ItemNames;
    public int[]? PointLightIds;
    public string Name;
    public float AiNetDensity;
    public BspUnknown BspUnk;

    public Room(BinaryReader br) : base(br) {
        this.Id = br.Read<DataTypeInt>().Value;

        for (var i = 0; i < 10; i++) {
            br.ReadByte(); // Type tag
            var count = br.Read<DataTypeInt>().Value;

            switch (i) {
                default: {
                    this.StaticMeshIds = new int[count];
                    for (var j = 0; j < count; j++) {
                        this.StaticMeshIds[j] = br.Read<DataTypeInt>().Value;
                    }

                    break;
                }
                case 1: {
                    this.StaticLightNames = new string[count];
                    for (var j = 0; j < count; j++) {
                        this.StaticLightNames[j] = br.Read<DataTypeString>().Value;
                    }

                    break;
                }
                case 2: {
                    this.ExitNames = new string[count];
                    for (var j = 0; j < count; j++) {
                        this.ExitNames[j] = br.Read<DataTypeString>().Value;
                    }

                    break;
                }
                case 3: {
                    this.StartPointNames = new string[count];
                    for (var j = 0; j < count; j++) {
                        this.StartPointNames[j] = br.Read<DataTypeString>().Value;
                    }

                    break;
                }
                case 4: {
                    this.FsmNames = new string[count];
                    for (var j = 0; j < count; j++) {
                        this.FsmNames[j] = br.Read<DataTypeString>().Value;
                    }

                    break;
                }
                case 5: {
                    this.CharacterNames = new string[count];
                    for (var j = 0; j < count; j++) {
                        this.CharacterNames[j] = br.Read<DataTypeString>().Value;
                    }

                    break;
                }
                case 6: {
                    this.TriggerNames = new string[count];
                    for (var j = 0; j < count; j++) {
                        this.TriggerNames[j] = br.Read<DataTypeString>().Value;
                    }

                    break;
                }
                case 7: {
                    this.DynamicMeshNames = new string[count];
                    for (var j = 0; j < count; j++) {
                        this.DynamicMeshNames[j] = br.Read<DataTypeString>().Value;
                    }

                    break;
                }
                case 8: {
                    this.ItemNames = new string[count];
                    for (var j = 0; j < count; j++) {
                        this.ItemNames[j] = br.Read<DataTypeString>().Value;
                    }

                    break;
                }
                case 9: {
                    this.PointLightIds = new int[count];
                    for (var j = 0; j < count; j++) {
                        this.PointLightIds[j] = br.Read<DataTypeInt>().Value;
                    }

                    break;
                }
            }
        }

        this.Name = br.Read<DataTypeString>().Value;
        this.AiNetDensity = br.Read<DataTypeFloat>().Value;
        this.BspUnk = new BspUnknown(br);
    }
}
