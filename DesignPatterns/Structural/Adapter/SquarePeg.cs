namespace DesignPatterns.Structural.Adapter
{
    public class SquarePeg : ISquarePeg
    {
        private double _width;
        public SquarePeg(double width) { 
            this._width = width;
        }
        public double getWidth()
        {
            return _width;
        }
    }
}
