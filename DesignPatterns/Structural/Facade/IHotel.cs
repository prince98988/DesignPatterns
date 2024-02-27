using System.Collections;

namespace DesignPatterns.Structural.Facade
{
    public interface IHotel
    {
        public Dictionary<string, int> GetMenu();
    }
}
