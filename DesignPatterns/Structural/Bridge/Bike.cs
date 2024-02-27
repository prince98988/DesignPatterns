namespace DesignPatterns.Structural.Bridge
{
    public class Bike : Vehicle
    {
        public Bike(IWorkshop workShop1, IWorkshop workShop2) : base(workShop1, workShop2)
        {
        }

        public override void Manufacture()
        {
            Console.WriteLine("Bike ");
            workShop1.Work();
            workShop2.Work();
        }
    }
}
