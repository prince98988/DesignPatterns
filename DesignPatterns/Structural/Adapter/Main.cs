namespace DesignPatterns.Structural.Adapter
{
    public class Main
    {
        public static void Run()
        {
            IRoundPeg roundPeg = new RoundPeg(5.7);
            IRoundPeg squarePeg = new SquarePegAdapter(5.7);

            RoundHole roundHole = new RoundHole(5.6);

            Console.WriteLine("Round Peg: " + roundHole.IsPegFit(roundPeg));
            Console.WriteLine("Square Peg: " + roundHole.IsPegFit(roundPeg));
        }
    }
}
