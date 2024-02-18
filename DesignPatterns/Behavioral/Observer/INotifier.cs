namespace DesignPatterns.Behavioral.Observer
{
    public interface INotifier
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void Notify();
        public void UpdateObject();
    }
}
