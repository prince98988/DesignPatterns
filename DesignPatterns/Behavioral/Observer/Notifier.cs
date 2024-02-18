using System.Collections;

namespace DesignPatterns.Behavioral.Observer
{
    public class Notifier : INotifier
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _observingItem;
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }
        public void Notify()
        {
            foreach(IObserver observer in _observers)
            {
                observer.GetNotification(_observingItem);
            }
        }

        public void UpdateObject()
        {
            _observingItem = Guid.NewGuid().ToString();
            Notify();
        }
    }
}
