namespace DesignPatterns.Behavioral.Observer
{
    internal class MobileObserver : IObserver
    {
        public void GetNotification(string notification)
        {
            Console.WriteLine("mobile: " + notification);
        }
    }
}
