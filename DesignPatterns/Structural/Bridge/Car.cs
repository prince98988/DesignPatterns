namespace DesignPatterns.Structural.Bridge
{
    public class Car : Vehicle
    {
        public Car(IWorkshop workShop1, IWorkshop workShop2): base(workShop1, workShop2)
        {
            
        }

        public override void Manufacture()
        {
            Console.WriteLine("Car ");
            workShop1.Work();
            workShop2.Work();
        }

    }
}
