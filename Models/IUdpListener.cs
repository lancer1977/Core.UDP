using System;

namespace PolyhydraSoftware.Core.UDP;

public interface IUdpListener<out T> : IObservable<T>
{
    void Stop();
    void Start();
}