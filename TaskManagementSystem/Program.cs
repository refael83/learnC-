using System;




namespace TaskManagement
{
    public enum Status
    {
        InProgress,
        Completed,
        Backlog
    }

    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            int userCounter = 1;
            int taskCounter = 101;

            while (true)
            {
                Console.WriteLine("1. Create New User");
                Console.WriteLine("2. Create New Task");
                Console.WriteLine("3. Display All Tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine() ?? string.Empty;

                switch (choice)
                {
                    case "1": // Create new user
                        Console.Write("Enter user name: ");
                        string userName = Console.ReadLine() ?? string.Empty;
                        User newUser = new User(userCounter++, userName);
                        taskManager.AddUser(newUser);
                        Console.WriteLine($"User '{userName}' created successfully.");
                        break;

                    case "2": // Create new task
                        Console.WriteLine("\n--- Create New Task ---");

                        Console.Write("Enter Task Title: ");
                        string title = Console.ReadLine() ?? string.Empty;

                        Console.Write("Enter Task Description: ");
                        string description = Console.ReadLine() ?? string.Empty;

                        Console.Write("Enter Task Priority (1 = High, 2 = Medium, 3 = Low): ");
                        int priority = int.Parse(Console.ReadLine() ?? string.Empty);

                        Console.Write("Enter Task Deadline (YYYY-MM-DD): ");
                        DateTime deadline = DateTime.Parse(Console.ReadLine() ?? string.Empty);

                        // Display users for assignment
                        Console.WriteLine("Assign this task to a user:");
                        taskManager.DisplayUsers();

                        Console.Write("Enter User ID: ");
                        int userId = int.Parse(Console.ReadLine() ?? string.Empty);

                        User? assignee = taskManager.GetUserById(userId);

                        if (assignee != null)
                        {
                            // Create and assign task
                            Task newTask = new Task(taskCounter++, title, description, priority, deadline);
                            newTask.Assignee = assignee;
                            taskManager.AddTask(newTask);

                            Console.WriteLine("Task created and assigned successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID. Task not created.");
                        }
                        break;

                    case "3": // Display all tasks
                        taskManager.DisplayTasks();
                        break;

                    case "4": // Exit
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
