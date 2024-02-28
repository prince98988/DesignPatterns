namespace DesignPatterns.Behavioral.Visitor
{
    public class Circle : IShape
    {
        public int _radius;
        public Circle(int radius) 
        {
            _radius = radius;
        }
        public int getSize()
        {
            return (int)(3.14 * _radius * _radius);
        }
    }
}
