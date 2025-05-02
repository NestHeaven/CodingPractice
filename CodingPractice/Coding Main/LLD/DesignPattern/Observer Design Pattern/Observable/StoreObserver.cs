using Coding_Main.LLD.DesignPattern.Observer_Design_Pattern.Observer;

namespace Coding_Main.LLD.DesignPattern.Observer_Design_Pattern.Observable
{
    public class StoreObserver : IStoreObservable
    {
        public int data;
        public List<IObserver> observers;

        public StoreObserver()
        {
            observers = new List<IObserver>();
        }
        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers) { 
                observer.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetData(int d)
        {
            data = d;
            Notify();
        }

        public void SetAvailabilty()
        {
            Console.WriteLine("Available");
        }
    }
}
