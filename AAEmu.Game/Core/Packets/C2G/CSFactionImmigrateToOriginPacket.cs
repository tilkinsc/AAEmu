using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSFactionImmigrateToOriginPacket : GamePacket
    {
        public CSFactionImmigrateToOriginPacket() : base(0x016, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            _log.Debug("FactionImmigrateToOrigin");
        }
    }
}
