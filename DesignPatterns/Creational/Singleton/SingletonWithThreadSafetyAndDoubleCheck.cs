using System.Xml.Linq;

namespace DesignPatterns.Creational.Singleton
{
    public class SingletonWithThreadSafetyAndDoubleCheck
    {
        public string Name = "tesla";
        private static SingletonWithThreadSafetyAndDoubleCheck _instance;
        private static readonly object _lock = new object();
        private SingletonWithThreadSafetyAndDoubleCheck() { }
        public static SingletonWithThreadSafetyAndDoubleCheck GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonWithThreadSafetyAndDoubleCheck();
                    }
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
