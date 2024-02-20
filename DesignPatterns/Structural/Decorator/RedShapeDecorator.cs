namespace DesignPatterns.Structural.Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            base.shape.Draw();
            Console.WriteLine("RedShape");
        }
    }
}
