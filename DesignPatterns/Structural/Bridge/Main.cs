namespace DesignPatterns.Structural.Bridge
{
    public class Main
    {
        public static void Run()
        {
            IWorkshop produce = new Produce();
            IWorkshop assemble = new Assemble();
            Vehicle car = new Car(produce, assemble);
            car.Manufacture();
        }
    }
}
