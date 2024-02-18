namespace DesignPatterns.Behavioral.ChainResponsibility
{
    public interface IHandler
    {
        public void SetNextHandler(IHandler handler);
        public void HandleRequest(Request request);
    }
}
