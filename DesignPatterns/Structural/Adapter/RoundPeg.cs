namespace DesignPatterns.Structural.Adapter
{
    public class RoundPeg : IRoundPeg
    {
        private double _redius;
        public RoundPeg(double redius) {
            this._redius = redius;
        }
        public double getRedius()
        {
            return _redius;
        }
    }
}
