namespace DesignPatterns.Creational.Factory
{
    public class ShipTransport : Transport
    {
        public override IVehicle GetVehicle()
        {
            return new Ship();
        }
    }
}
