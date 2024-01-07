namespace DesignPatterns.Singleton
{
    public class Main
    {
        public static void Run()
        {
            var singleton1 = Singleton.GetCarInstance();
            Console.WriteLine("Sigleton1: " + singleton1.Name);
            singleton1.SetName("Lemborgini");

            var singleton2 = Singleton.GetCarInstance();
            Console.WriteLine("Sigleton2: " + singleton2.Name);


            var singletonWithThreadSafety1 = SingletonWithThreadSafety.GetInstance();
            Console.WriteLine("singletonWithThreadSafety1: " + singletonWithThreadSafety1.Name);
            singletonWithThreadSafety1.SetName("Lemborgini");

            var singletonWithThreadSafety2 = SingletonWithThreadSafety.GetInstance();
            Console.WriteLine("singletonWithThreadSafety2: " + singletonWithThreadSafety2.Name);


            var singletonWithThreadSafetyAndDoubleCheck1 = SingletonWithThreadSafetyAndDoubleCheck.GetInstance();
            Console.WriteLine("singletonWithThreadSafetyAndDoubleCheck1: " + singletonWithThreadSafetyAndDoubleCheck1.Name);
            singletonWithThreadSafetyAndDoubleCheck1.SetName("Lemborgini");

            var singletonWithThreadSafetyAndDoubleCheck2 = SingletonWithThreadSafetyAndDoubleCheck.GetInstance();
            Console.WriteLine("singletonWithThreadSafetyAndDoubleCheck2: " + singletonWithThreadSafetyAndDoubleCheck1.Name);

            var singletonWithLazyLoading1 = SingletonWithLazyLoading.GetInstance();
            Console.WriteLine("singletonWithLazyLoading1: " + singletonWithLazyLoading1.Name);
            singletonWithLazyLoading1.SetName("Lemborgini");

            var SingletonWithLazyLoading2 = SingletonWithLazyLoading.GetInstance();
            Console.WriteLine("SingletonWithLazyLoading2: " + SingletonWithLazyLoading2.Name);
        }
    }
}
