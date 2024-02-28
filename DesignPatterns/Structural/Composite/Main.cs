namespace DesignPatterns.Structural.Composite
{
    public class Main
    {
        public static void Run()
        {
            Task simpleTask1 = new Task("Complete Coding");
            Task simpleTask2 = new Task("Write Documentation");

            // Creating a task list
            TaskList projectTasks = new TaskList("Project Tasks");
            projectTasks.addTask(simpleTask1);
            projectTasks.addTask(simpleTask2);

            // Nested task list
            TaskList phase1Tasks = new TaskList("Phase 1 Tasks");
            phase1Tasks.addTask(new Task("Design"));
            phase1Tasks.addTask(new Task("Implementation"));

            projectTasks.addTask(phase1Tasks);

            // Displaying tasks
            projectTasks.display();
        }
    }
}
