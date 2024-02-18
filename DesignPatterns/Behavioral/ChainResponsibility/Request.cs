namespace DesignPatterns.Behavioral.ChainResponsibility
{
    public class Request
    {
        private Priority _priority { get; set; }

        public Request(Priority priority)
        {
            _priority = priority;
        }

        public Priority getPriority()
        {
            return _priority;
        }
    }
}
