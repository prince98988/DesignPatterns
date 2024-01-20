namespace DesignPatterns.Creational.Factory
{
    public class Main
    {
        public static void Run()
        {
            Transport truckTransport = new TruckTransport();
            Console.WriteLine(truckTransport.GetName());

            Transport shipTransport = new ShipTransport();
            Console.WriteLine(shipTransport.GetName());
        }
    }
}
