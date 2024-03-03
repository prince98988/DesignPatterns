namespace DesignPatterns.Structural.Flyweight
{
    public class TreeType
    {
        public string color;
        public int height;
        public string Name;
        public TreeType(string color, int height, string name)
        {
            this.color = color;
            this.height = height;
            this.Name = name;
        }
    }
}
