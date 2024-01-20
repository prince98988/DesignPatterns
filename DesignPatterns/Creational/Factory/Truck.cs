namespace DesignPatterns.Creational.Factory
{
    public class Truck : IVehicle
    {
        public string Name { get { return "Tata"; } set { } }
        public string GetName()
        {
            return Name;    
        }
    }
}
