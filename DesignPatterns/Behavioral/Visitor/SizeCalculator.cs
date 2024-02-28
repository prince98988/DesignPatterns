namespace DesignPatterns.Behavioral.Visitor
{
    public class SizeCalculator : IVisitor
    {
        public int getHeight(Ractangle ractangle)
        {
            return ractangle._height;
        }

        public int getRadius(Circle circle)
        {
            return circle._radius;
        }
    }
}
