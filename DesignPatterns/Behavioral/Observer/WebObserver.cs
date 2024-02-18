namespace DesignPatterns.Behavioral.Observer
{
    public class WebObserver : IObserver
    {
        public void GetNotification(string notification)
        {
            Console.WriteLine("web: " + notification);
        }
    }
}
