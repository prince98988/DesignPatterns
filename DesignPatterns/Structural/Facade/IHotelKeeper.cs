using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public interface IHotelKeeper
    {
        public Dictionary<string, int> GetVegMenu();
        public Dictionary<string, int> GetNonVegMenu();
    }
}
