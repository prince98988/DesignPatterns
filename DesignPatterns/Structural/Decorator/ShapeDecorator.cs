namespace DesignPatterns.Structural.Decorator
{
    public class ShapeDecorator : IShape
    {
        protected IShape shape;
        public ShapeDecorator(IShape shape)
        {
            this.shape = shape;
        }
        public virtual void Draw()
        {
            this.shape.Draw();
        }
    }
}
