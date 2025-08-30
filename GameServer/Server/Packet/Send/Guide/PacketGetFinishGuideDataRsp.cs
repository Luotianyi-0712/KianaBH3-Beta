using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Guide;

public class PacketGetFinishGuideDataRsp : BasePacket
{
    public PacketGetFinishGuideDataRsp(PlayerInstance player) : base(CmdIds.GetFinishGuideDataRsp)
    {
        var proto = new GetFinishGuideDataRsp
        {
            GuideIdList = { player.GuideData!.GuideFinishList }
        };

        SetData(proto);
    }
}
