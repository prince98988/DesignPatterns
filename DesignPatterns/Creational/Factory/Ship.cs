namespace DesignPatterns.Creational.Factory
{
    public class Ship : IVehicle
    {
        public string Name { get { return "Titanic"; } set { } }
        public string GetName()
        {
            return Name;
        }
    }
}
