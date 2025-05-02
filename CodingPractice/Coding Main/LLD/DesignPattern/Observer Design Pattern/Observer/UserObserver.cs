using System;

namespace Coding_Main.LLD.DesignPattern.Observer_Design_Pattern.Observer
{
    public class UserObserver : IObserver
    {
        public readonly IStoreObservable observable;

        public UserObserver(IStoreObservable observable)
        {
            this.observable = observable;
        }


        public void Update()
        {
            observable.SetAvailabilty();
        }
    }
}
