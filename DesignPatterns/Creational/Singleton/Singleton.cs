namespace DesignPatterns.Creational.Singleton
{
    public sealed class Singleton
    {
        public string Name = "tesla";
        private static Singleton _instance { get; set; }
        private Singleton() { }
        public static Singleton GetCarInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
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
