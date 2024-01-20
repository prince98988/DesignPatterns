namespace DesignPatterns.Creational.Factory
{
    public abstract class Transport
    {
        public abstract IVehicle GetVehicle();

        public string GetName()
        {
            IVehicle vehicle = GetVehicle();
            return vehicle.GetName();
        }
    }
}
