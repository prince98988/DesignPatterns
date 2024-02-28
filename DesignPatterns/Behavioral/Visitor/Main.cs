namespace DesignPatterns.Behavioral.Visitor
{
    public class Main
    {
        public static void Run()
        {
            Circle circle = new Circle(2);
            Ractangle ractangle = new Ractangle(3, 4);

            IVisitor sizeCalcualtor = new SizeCalculator();
            Console.WriteLine(sizeCalcualtor.getRadius(circle));
            Console.WriteLine(sizeCalcualtor.getHeight(ractangle));
        }
    }
}
