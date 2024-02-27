namespace DesignPatterns.Structural.Bridge
{
    public class Assemble : IWorkshop
    {
        public override void Work()
        {
            Console.WriteLine("Assembled");
        }
    }
}
