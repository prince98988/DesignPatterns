namespace DesignPatterns.Structural.Bridge
{
    public class Produce : IWorkshop
    {
        public override void Work()
        {
            Console.WriteLine("Produced");
        }
    }
}
