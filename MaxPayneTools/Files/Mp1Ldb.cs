using MaxPayneTools.DataTypes;
using MaxPayneTools.Files.Mp1LdbStructs;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files;

public class Mp1Ldb : Readable {
    public BspContainer Bsp;
    public int FileVersion;
    public MaterialContainer Materials;
    public List<ExitPortal>? ExitPortals;
    public StaticMeshContainer StaticMeshes;
    public List<StaticLight>? StaticLights;
    public List<Waypoint>? Waypoints;
    public List<FsmScript>? FsmScripts;
    public List<Character>? Characters;
    public List<Trigger>? Triggers;
    public DynamicMeshContainer DynamicMeshes;
    public List<Item>? Items;
    public List<PointLight>? PointLights;
    public List<Room>? Rooms;

    public Mp1Ldb(BinaryReader br) : base(br) {
        this.Bsp = new BspContainer(br);
        this.FileVersion = br.Read<DataTypeInt>().Value;
        this.Materials = new MaterialContainer(br);

        var exitCount = br.Read<DataTypeInt>().Value;
        for (var i = 0; i < exitCount; i++) {
            this.ExitPortals?.Add(new ExitPortal(br));
        }

        this.StaticMeshes = new StaticMeshContainer(br);

        var staticLightCount = br.Read<DataTypeInt>().Value;
        for (var j = 0; j < staticLightCount; j++) {
            this.StaticLights?.Add(new StaticLight(br));
        }

        var waypointCount = br.Read<DataTypeInt>().Value;
        for (var k = 0; k < waypointCount; k++) {
            this.Waypoints?.Add(new Waypoint(br));
        }

        var fsmCount = br.Read<DataTypeInt>().Value;
        for (var l = 0; l < fsmCount; l++) {
            this.FsmScripts?.Add(new FsmScript(br));
        }

        var charCount = br.Read<DataTypeInt>().Value;
        for (var m = 0; m < charCount; m++) {
            this.Characters?.Add(new Character(br));
        }

        var triggerCount = br.Read<DataTypeInt>().Value;
        for (var n = 0; n < triggerCount; n++) {
            this.Triggers?.Add(new Trigger(br));
        }

        this.DynamicMeshes = new DynamicMeshContainer(br);

        var itemCount = br.Read<DataTypeInt>().Value;
        for (var o = 0; o < itemCount; o++) {
            this.Items?.Add(new Item(br));
        }

        var pointLightCount = br.Read<DataTypeInt>().Value;
        for (var p = 0; p < pointLightCount; p++) {
            this.PointLights?.Add(new PointLight(br));
        }

        var roomCount = br.Read<DataTypeInt>().Value;
        for (var q = 0; q < roomCount; q++) {
            this.Rooms?.Add(new Room(br));
        }
    }
}
