using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class Trigger : Readable {
    public EntityProperties EntProperties;
    public float Radius;

    // 0 - action_button 1 - player_collide 2 - projectile_collide 3 - character_collide 4 - look_at_trigger
    public int Type;

    public Trigger(BinaryReader br) : base(br) {
        this.EntProperties = new EntityProperties(br);
        this.Radius = br.ReadSpecificDataType<DataTypeFloat>().Value;
        this.Type = br.ReadSpecificDataType<DataTypeInt>().Value;
    }
}
