namespace DesignPatterns.Structural.Adapter
{
    public class SquarePegAdapter : SquarePeg, IRoundPeg
    {
        public SquarePegAdapter(double width) : base(width)
        {
        }

        public double getRedius()
        {
            return getWidth() * getWidth();
        }
    }
}
