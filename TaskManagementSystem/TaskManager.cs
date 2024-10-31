using System;

namespace TaskManagement{
  public class TaskManager
{
    private List<Task> tasks;
    private List<User> users;

    public TaskManager()
    {
        tasks = new List<Task>();
        users = new List<User>();
    }

    // Add user to the task manager
    public void AddUser(User user)
    {
        users.Add(user);
    }

    // List users for selection
    public void DisplayUsers()
    {
        Console.WriteLine("Users:");
        foreach (var user in users)
        {
            Console.WriteLine($"{user.UserId}: {user.Name}");
        }
    }

    // Find a user by ID
    public User? GetUserById(int userId)
    {
        return users.FirstOrDefault(u => u.UserId == userId);
    }

    // Add task to the task manager
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    // Display all tasks
    public void DisplayTasks()
    {
        Console.WriteLine("\nTasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.TaskId}: {task.Title}, Status: {task.Status}, Priority: {task.Priority}, Deadline: {task.Deadline}, Assigned to: {task.Assignee?.Name}");
        }
    }
}

}