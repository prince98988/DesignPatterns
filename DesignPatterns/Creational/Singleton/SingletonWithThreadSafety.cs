using System.Xml.Linq;

namespace DesignPatterns.Creational.Singleton
{
    public class SingletonWithThreadSafety
    {
        public string Name = "tesla";
        private static SingletonWithThreadSafety _instance;
        private static readonly object _lock = new object();
        private SingletonWithThreadSafety() { }
        public static SingletonWithThreadSafety GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new SingletonWithThreadSafety();
                }
            }
            return _instance;
        }

        public string SetName(string name)
        {
            Name = name;
            return Name;
        }
    }
}
