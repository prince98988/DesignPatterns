namespace DesignPatterns.Behavioral.ChainResponsibility
{
    public class Level2Handler : IHandler
    {
        private IHandler _nextHandler;
        public void HandleRequest(Request request)
        {
            if (request != null && request.getPriority() == Priority.Medium)
            {
                Console.WriteLine("Level2 Handle");
            }
            else
            {
                Console.WriteLine("Level2 Not Handle");
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
