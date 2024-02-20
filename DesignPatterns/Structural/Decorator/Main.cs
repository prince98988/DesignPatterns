namespace DesignPatterns.Structural.Decorator
{
    public class Main
    {
        public static void Run()
        {
            IShape circle = new Circle();
            IShape ractangle = new Ractangle();

            IShape redCircle = new RedShapeDecorator(circle);
            IShape redRactangle = new RedShapeDecorator(ractangle);

            redCircle.Draw();
            redRactangle.Draw();
        }
    }
}
