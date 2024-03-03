namespace DesignPatterns.Structural.Flyweight
{
    public class TreeFactory
    {
        private static Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();
        public static TreeType GetTreeType(string name, string color, int height)
        {
            var obj = name + color + height;
            if (_treeTypes.ContainsKey(obj)){
                return _treeTypes[obj];
            }
            else
            {
                var NewTreeType = new TreeType(color, height, name);
                _treeTypes[obj] = NewTreeType;
                return NewTreeType;
            }
        }
    }
}
