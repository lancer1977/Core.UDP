using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.Extensions.Logging;
using PolyhydraGames.Core.Models;

namespace PolyhydraSoftware.Core.UDP;

public class ObservableJsonUdpListener<T> : IUdpListener<T>
{
    private readonly ILogger<ObservableJsonUdpListener<T>>? _log;
    public Observable<bool> Running { get; } = new();
    private readonly Observable<T> _announcer = new();
    private CancellationTokenSource MonitoringCTS { get; set; }
    UdpClient listener;
    IPEndPoint groupEP;
    public ObservableJsonUdpListener(ILogger<ObservableJsonUdpListener<T>> log, int port)
    {
        _log = log;
        listener = new UdpClient(port);
        groupEP = new IPEndPoint(IPAddress.Any, port);

    }
    public IDisposable Subscribe(IObserver<T> observer)
    {
        return _announcer.Subscribe(observer);
    }

    public void Stop()
    {
        MonitoringCTS.Cancel();
    }

    private void Listen()
    {
        using (MonitoringCTS = new CancellationTokenSource())
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Waiting for broadcast");
                    byte[] bytes = listener.Receive(ref groupEP);

                    Console.WriteLine($"Received broadcast from {groupEP} :");
                    var text = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    _announcer.SetValue(text.FromJson<T>());
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                listener.Close();
            }
        }
    }

    public void Start()
    {
        if (Running.Value) return;
        Running.SetValue(true);

        try
        {

            Listen();
            _log?.LogTrace("Current Track Manager is now monitoring for changes.");
        }

        catch (Exception ex)
        {
            _log?.LogCritical(ex, "Start failed");
        }

        Running.SetValue(false);
    }
}