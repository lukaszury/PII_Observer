using System;

namespace Observer
{
    public interface IObserver<T>
    {
        void Update(T o);
    }
}