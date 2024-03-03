namespace DesignPatterns.Structural.Flyweight
{
    public class Tree
    {
        public TreeType TreeType { get; set; }
        public int OtherField {  get; set; }

        public Tree(TreeType treeType)
        {
            this.TreeType = treeType;
        }
        public void GetInfo() {
            Console.WriteLine($"TreeName: {TreeType.Name} And OtherField: {OtherField}");
        }

    }
}
