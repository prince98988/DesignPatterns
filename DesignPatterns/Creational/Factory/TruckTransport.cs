namespace DesignPatterns.Creational.Factory
{
    public class TruckTransport : Transport
    {
        public override IVehicle GetVehicle()
        {
            return new Truck();
        }
    }
}
