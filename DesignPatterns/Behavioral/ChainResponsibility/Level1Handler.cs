namespace DesignPatterns.Behavioral.ChainResponsibility
{
    public class Level1Handler : IHandler
    {
        private IHandler _nextHandler { get; set; }
        public void HandleRequest(Request request)
        {
            if(request != null && request.getPriority() == Priority.High)
            {
                Console.WriteLine("Level1 Handle");
            }
            else
            {
                Console.WriteLine("Level1 Not Handle");
            }
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
     
        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
