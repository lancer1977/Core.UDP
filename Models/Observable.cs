using System;
using System.Collections.Generic;

namespace PolyhydraSoftware.Core.UDP;

public sealed class Observable<T> : IObservable<T>
{
    private readonly List<IObserver<T>> _observers = new();

    public T Value { get; private set; } = default!;

    public IDisposable Subscribe(IObserver<T> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }

        return new Subscription(_observers, observer);
    }

    public void SetValue(T value)
    {
        Value = value;

        foreach (var observer in _observers.ToArray())
        {
            observer.OnNext(value);
        }
    }

    private sealed class Subscription : IDisposable
    {
        private readonly List<IObserver<T>> _observers;
        private readonly IObserver<T> _observer;

        public Subscription(List<IObserver<T>> observers, IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            _observers.Remove(_observer);
        }
    }
}
