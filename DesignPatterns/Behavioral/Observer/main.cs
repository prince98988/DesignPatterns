namespace DesignPatterns.Behavioral.Observer
{
    public class Main
    {
        public static void Run()
        {
            IObserver mobile = new MobileObserver();
            IObserver web = new WebObserver();

            INotifier notifier = new Notifier();
            notifier.AddObserver(mobile);
            notifier.AddObserver(web);

            notifier.UpdateObject();

            notifier.RemoveObserver(mobile);

            notifier.UpdateObject();
        }
    }
}
