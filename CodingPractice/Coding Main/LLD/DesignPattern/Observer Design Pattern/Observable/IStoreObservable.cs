using Coding_Main.LLD.DesignPattern.Observer_Design_Pattern.Observer;
using System;

namespace Coding_Main.LLD.DesignPattern.Observer_Design_Pattern
{
    public interface IStoreObservable
    {
        void Add(IObserver observer);

        void Remove(IObserver observer);

        void Notify();

        void SetData(int d);

        void SetAvailabilty();
    }
}
