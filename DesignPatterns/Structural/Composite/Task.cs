namespace DesignPatterns.Structural.Composite
{
    public class Task : ITask
    {
        private String title;

        public Task(String title)
        {
            this.title = title;
        }

        public String getTitle()
        {
            return title;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }

        public void display()
        {
            Console.WriteLine("Simple Task: " + title);
        }
    }
}
