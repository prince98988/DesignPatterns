namespace DesignPatterns.Structural.Flyweight
{
    public class Main
    {
        public static void Run()
        {
            Tree tree = new Tree(TreeFactory.GetTreeType("Neem", "Green", 10));
            Console.WriteLine("For Same Tree: " + tree.TreeType.GetHashCode());

            Tree tree1 = new Tree(TreeFactory.GetTreeType("Neem", "Green", 10));
            Console.WriteLine("For Same Tree: " + tree1.TreeType.GetHashCode());
            Console.WriteLine(tree.TreeType == tree1.TreeType);

            Tree tree2 = new Tree(TreeFactory.GetTreeType("Amla", "Geen", 5));
            Console.WriteLine("For Different Tree: " + tree2.TreeType.GetHashCode());
        }
    }
}
