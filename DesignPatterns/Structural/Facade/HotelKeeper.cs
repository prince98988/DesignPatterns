using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class HotelKeeper : IHotelKeeper
    {
        public Dictionary<string, int> GetNonVegMenu()
        {
            IHotel nonVegMenu = new NonVegMenu();
            return nonVegMenu.GetMenu();
        }

        public Dictionary<string, int> GetVegMenu()
        {
            IHotel vegMenu = new VegMenu();
            return vegMenu.GetMenu();
        }
    }
}
