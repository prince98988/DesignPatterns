namespace DesignPatterns.Structural.Facade
{
    public class Main
    {
        public static void Run()
        {
            IHotelKeeper hotelKeeper = new HotelKeeper();
            Console.WriteLine("Veg Menu");
            foreach (var item in hotelKeeper.GetVegMenu())
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("Non Veg Menu");
            foreach (var item in hotelKeeper.GetNonVegMenu())
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
