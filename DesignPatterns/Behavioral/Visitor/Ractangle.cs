namespace DesignPatterns.Behavioral.Visitor
{
    public class Ractangle : IShape
    {
        public int _width, _height;
        public Ractangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int getSize()
        {
            return _width*_height;
        }
    }
}
