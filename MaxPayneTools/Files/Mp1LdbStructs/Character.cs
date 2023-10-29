using MaxPayneTools.DataTypes;
using MaxPayneTools.Util;

namespace MaxPayneTools.Files.Mp1LdbStructs;

public class Character : Readable {
    public EntityProperties EntProperties;
    public string Name;
    public CharacterFsm Fsm;

    public Character(BinaryReader br) : base(br) {
        this.EntProperties = new EntityProperties(br);
        this.Name = br.Read<DataTypeString>().Value;
        this.Fsm = new CharacterFsm(br);
    }
}
