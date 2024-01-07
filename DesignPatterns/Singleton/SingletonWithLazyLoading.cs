using System.Xml.Linq;

namespace DesignPatterns.Singleton
{
    public class SingletonWithLazyLoading
    {
        public string Name = "tesla";
        private static Lazy<SingletonWithLazyLoading> instance = new Lazy<SingletonWithLazyLoading>(() => new SingletonWithLazyLoading());
        private SingletonWithLazyLoading() { }

        public static SingletonWithLazyLoading GetInstance()
        {
            return instance.Value;
        }
        public string SetName(string name)
        {
            Name = name;
            return Name;
        }
    }
}
