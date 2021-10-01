using System;

namespace Observer
{
    public interface ISubject<T> where T : new()
    {
        void Subscribe(IObserver<T> o);
        void Unsubscribe(IObserver<T> o);
    
    }
}