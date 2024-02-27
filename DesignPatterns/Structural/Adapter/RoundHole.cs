namespace DesignPatterns.Structural.Adapter
{
    public class RoundHole
    {
        private double _radius;
        public RoundHole(double radius)
        {
            _radius = radius;
        }
        public double getRedius()
        {
            return _radius;
        }
        public Boolean IsPegFit(IRoundPeg peg)
        {
            return peg.getRedius() < _radius;
        }
    }
}
