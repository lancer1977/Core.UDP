using System.Net;
using System.Net.Sockets;
using System.Text;
using PolyhydraGames.Core.Models;

namespace PolyhydraSoftware.Core.UDP;

public class SocketTransmitter
{
    private readonly string _ip;
    private readonly int _port;
    private readonly IPEndPoint _tcpEndPoint;
    private readonly Socket socket;
    public SocketTransmitter(string ip, int port)
    {
        _ip = ip;
        _port = port;
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        var broadcast = IPAddress.Parse(_ip);
        _tcpEndPoint = new IPEndPoint(broadcast, _port);
    }
    public void Send<T>(T value)
    {

        var payload = Encoding.ASCII.GetBytes(value.ToJson());


        socket.SendTo(payload, _tcpEndPoint);
    }

}
