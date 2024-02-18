namespace DesignPatterns.Behavioral.ChainResponsibility
{
    public class Main
    {
        public static void Run()
        {
            IHandler level1Handler = new Level1Handler();
            IHandler level2Handler = new Level2Handler();
            level1Handler.SetNextHandler(level2Handler);

            level1Handler.HandleRequest(new Request(Priority.High));
        }

    }
}
