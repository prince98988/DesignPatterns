namespace DesignPatterns.Structural.Composite
{
    public class TaskList : ITask
    {
        private String Title;
        private List<ITask> Tasks;

        public TaskList(String title)
        {
            this.Title = title;
            this.Tasks = new List<ITask>();
        }

        public String getTitle()
        {
            return Title;
        }

        public void setTitle(String title)
        {
            this.Title = title;
        }

        public void addTask(ITask task)
        {
            Tasks.Add(task);
        }

        public void removeTask(ITask task)
        {
            Tasks.Remove(task);
        }
        public void display()
        {
            Console.WriteLine("Task List: " + Title);
            foreach (ITask task in Tasks)
            {
                task.display();
            }
        }
    }
}
