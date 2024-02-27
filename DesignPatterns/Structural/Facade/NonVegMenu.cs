using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class NonVegMenu : IHotel
    {
        public Dictionary<string, int> GetMenu()
        {
            return new Dictionary<string, int>() { { "Chicken 65", 300 } };
        }
    }
}
